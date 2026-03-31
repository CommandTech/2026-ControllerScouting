using ControllerScouting.Database;
using ControllerScouting.Gamepad;
using ControllerScouting.Properties;
using ControllerScouting.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllerScouting.Screens
{
    public partial class BaseScreen : Form
    {
        // ── State ────────────────────────────────────────────────────────────
        private static volatile bool _loading = false;
        public string regional;

        // Label caches – populated once in InitializeRobotLabelCache()
        private Dictionary<RobotLabelType, Label>[] robotLabels;
        private Dictionary<RobotPositionLabelType, Label>[] robotPositionLabels;

        // Reusable HttpClient (avoids socket exhaustion from creating one per call)
        private static readonly HttpClient _httpClient = new();

        // Cancellation for background threads
        private readonly CancellationTokenSource _cts = new();

        // Cache last-known robot mode per scouter box to skip redundant visibility passes
        private readonly RobotState.ROBOT_MODE[] _lastMode = new RobotState.ROBOT_MODE[6];
        private readonly bool[] _lastModeInitialized = new bool[6];

        private enum RobotLabelType
        {
            ScoutName = 0,
            MatchEvent = 1,
            ModeValue = 2,
            TeamName = 3
        }

        private enum RobotPositionLabelType
        {
            Position0,
            Position1,
            Position2,
            Position2Value,
            Position3,
            Position3Value,
            Position4,
            Position4Value,
            Position6,
            Position7,
            Position8,
            Position9
        }

        // ── Constructor ──────────────────────────────────────────────────────
        public BaseScreen()
        {
            InitializeComponent();
            InitializeRobotLabelCache();
            StartBackgroundTasks();
            AdjustFormSizeAndScale();

            // Read ini value once instead of three times
            string savedEvent = BackgroundCode.iniFile.Read("MatchData", "event", "");
            if (!string.IsNullOrWhiteSpace(savedEvent))
            {
                if (MessageBox.Show("Do you want to load previous data?", "Please Confirm",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LoadData();
                }
            }

            timerJoysticks.Interval = 20;
            timerJoysticks.Tick += UpdateScreen;
            timerJoysticks.Enabled = true;
        }

        // ── Background threads ───────────────────────────────────────────────
        private void StartBackgroundTasks()
        {
            var token = _cts.Token;
            Task.Run(() => SendingToDatabaseThread(token), token);
            Task.Run(() => StatusLightThread(token), token);
        }

        private void StatusLightThread(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    if (statusLight.IsDisposed) return;

                    Action toggle = () =>
                    {
                        statusLight.BackColor =
                            statusLight.BackColor == Color.Green ? Color.Red : Color.Green;
                    };

                    if (statusLight.InvokeRequired)
                        statusLight.Invoke(toggle);
                    else
                        toggle();
                }
                catch (ObjectDisposedException) { return; }

                Thread.Sleep(500);
            }
        }

        private static void SendingToDatabaseThread(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (!BackgroundCode.activitiesQueue.IsEmpty)
                    DatabaseCode.SendToDatabase();

                if (BackgroundCode.dataExport == BackgroundCode.EXPORT_TYPE.SQLonline
                    && BackgroundCode.localSQLChanges)
                {
                    DatabaseCode.UpdateServerSQL();
                }

                Thread.Sleep(20);
            }
        }

        // ── Label cache init ─────────────────────────────────────────────────
        private void InitializeRobotLabelCache()
        {
            robotLabels = new Dictionary<RobotLabelType, Label>[6];
            robotPositionLabels = new Dictionary<RobotPositionLabelType, Label>[6];

            for (int i = 0; i < 6; i++)
            {
                robotLabels[i] = new Dictionary<RobotLabelType, Label>
                {
                    [RobotLabelType.ScoutName] = FindLabel($"lbl{i}ScoutName"),
                    [RobotLabelType.MatchEvent] = FindLabel($"lbl{i}MatchEvent"),
                    [RobotLabelType.ModeValue] = FindLabel($"lbl{i}ModeValue"),
                    [RobotLabelType.TeamName] = FindLabel($"lbl{i}TeamName")
                };

                robotPositionLabels[i] = new Dictionary<RobotPositionLabelType, Label>
                {
                    [RobotPositionLabelType.Position0] = FindLabel($"lbl{i}Position0"),
                    [RobotPositionLabelType.Position1] = FindLabel($"lbl{i}Position1"),
                    [RobotPositionLabelType.Position2] = FindLabel($"lbl{i}Position2"),
                    [RobotPositionLabelType.Position2Value] = FindLabel($"lbl{i}Position2Value"),
                    [RobotPositionLabelType.Position3] = FindLabel($"lbl{i}Position3"),
                    [RobotPositionLabelType.Position3Value] = FindLabel($"lbl{i}Position3Value"),
                    [RobotPositionLabelType.Position4] = FindLabel($"lbl{i}Position4"),
                    [RobotPositionLabelType.Position4Value] = FindLabel($"lbl{i}Position4Value"),
                    [RobotPositionLabelType.Position6] = FindLabel($"lbl{i}Position6"),
                    [RobotPositionLabelType.Position7] = FindLabel($"lbl{i}Position7"),
                    [RobotPositionLabelType.Position8] = FindLabel($"lbl{i}Position8"),
                    [RobotPositionLabelType.Position9] = FindLabel($"lbl{i}Position9")
                };
            }
        }

        // Helper: avoids repeated array allocation from Controls.Find
        private Label FindLabel(string name)
            => (Label)Controls.Find(name, true)[0];

        // ── Layout / scaling ─────────────────────────────────────────────────
        private void AdjustFormSizeAndScale()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.WorkingArea;

            Width = screenBounds.Width;
            Height = screenBounds.Height;
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Dpi;

            float sx = (float)screenBounds.Width / 1512f;
            float sy = (float)screenBounds.Height / 872f;

            SuspendLayout();
            ScaleControls(this, sx, sy);
            ResumeLayout(true);
        }

        private static void ScaleControls(Control parent, float sx, float sy)
        {
            // Batch all size/position changes under SuspendLayout to suppress
            // intermediate layout passes, then apply fonts in one sweep.
            float fontScale = Math.Min(sx, sy);

            parent.SuspendLayout();
            foreach (Control c in parent.Controls)
            {
                c.SetBounds(
                    (int)(c.Left * sx),
                    (int)(c.Top * sy),
                    (int)(c.Width * sx),
                    (int)(c.Height * sy));

                // Avoid creating a new Font object when the scale is negligible
                if (Math.Abs(fontScale - 1f) > 0.001f)
                    c.Font = new Font(c.Font.FontFamily, c.Font.Size * fontScale, c.Font.Style);

                if (c.HasChildren)
                    ScaleControls(c, sx, sy);
            }
            parent.ResumeLayout(false);
        }

        // ── Joystick helpers ─────────────────────────────────────────────────
        public static void UpdateJoysticks()
        {
            foreach (var cts in BackgroundCode.controllerCancellationTokens)
                cts.Cancel();

            BackgroundCode.controllerCancellationTokens.Clear();
            BackgroundCode.controllerThreads.Clear();
            BackgroundCode.gamePads = Controllers.GetGamePads();
            BackgroundCode.StartControllerThreads();
        }

        // ── Button handlers ──────────────────────────────────────────────────
        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Please Confirm",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            if (BackgroundCode.loadedEvent != null || BackgroundCode.manualMatchList != null)
            {
                if (MessageBox.Show("Do you want to save the current data?", "Please Confirm",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BackgroundCode.SaveData();
                }
            }

            _cts.Cancel();

            if (Settings.Default.sqlExists)
                BackgroundCode.localSeasonframework.Database.Connection.Close();

            BackgroundCode.serverSeasonframework.Database.Connection.Close();
            Environment.Exit(0);
        }

        private void BtnInitialDBLoad_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to load The Blue Alliance data?",
                    "Please Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                GetEvents(false);
                SetRedRight();
                Log("Start time is " + DateTime.Now.TimeOfDay);
            }
            else
            {
                if (MessageBox.Show("Do you want to load manual matches?", "Please Confirm",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SetRedRight();
                    Log("Loading manual matches.");
                    DatabaseCode.LoadManualMatches();
                    comboBoxSelectRegional.DataSource = null;
                    comboBoxSelectRegional.Items.Clear();
                    comboBoxSelectRegional.Items.Add("manualEvent");
                    comboBoxSelectRegional.SelectedItem = "manualEvent";
                }
            }
        }

        private static void SetRedRight()
        {
            BackgroundCode.redRight =
                MessageBox.Show("Is the Red Alliance on your right?", "Please Confirm",
                    MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        private void BtnNextMatch_Click(object sender, EventArgs e)
        {
            if (cbxEndMatch.Checked)
            {
                for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
                    DatabaseCode.SaveToRecord(BackgroundCode.Robots[BackgroundCode.Robots[i].ScouterBox], "EndMatch");

                ResetAllScouterRobots();
                cbxEndMatch.Checked = false;

                if (BackgroundCode.currentMatch == BackgroundCode.InMemoryMatchList.Count)
                    MessageBox.Show("You are at the last match.");
                else
                    NextMatch();
            }
            else
            {
                if (MessageBox.Show("All unsaved data will be lost.  Continue?", "Next Match",
                        MessageBoxButtons.YesNo) != DialogResult.Yes) return;

                ResetAllScouterRobots();

                if (BackgroundCode.currentMatch != BackgroundCode.InMemoryMatchList.Count)
                    NextMatch();
                else
                    MessageBox.Show("You are at the last match.");
            }
        }

        private void BtnPrevMatch_Click(object sender, EventArgs e)
        {
            ResetAllScouterRobots();

            if (BackgroundCode.currentMatch <= 1)
                MessageBox.Show("You are at the first match.");
            else
            {
                BackgroundCode.currentMatch--;
                LoadMatch();
            }
        }

        private void BtnFunctions_Click(object sender, EventArgs e)
        {
            new FunctionsForm().Show();
        }

        // ── Match navigation ─────────────────────────────────────────────────
        private void NextMatch()
        {
            BackgroundCode.currentMatch++;
            LoadMatch();
        }

        private void LoadMatch()
        {
            var match = BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1];
            SetTeamNameAndColor(lbl0TeamName, BackgroundCode.Robots[0], match.Redteam1);
            SetTeamNameAndColor(lbl1TeamName, BackgroundCode.Robots[1], match.Redteam2);
            SetTeamNameAndColor(lbl2TeamName, BackgroundCode.Robots[2], match.Redteam3);
            SetTeamNameAndColor(lbl3TeamName, BackgroundCode.Robots[3], match.Blueteam1);
            SetTeamNameAndColor(lbl4TeamName, BackgroundCode.Robots[4], match.Blueteam2);
            SetTeamNameAndColor(lbl5TeamName, BackgroundCode.Robots[5], match.Blueteam3);
            lblMatch.Text = $"{BackgroundCode.currentMatch}/{BackgroundCode.InMemoryMatchList.Count}";
        }

        private static void SetTeamNameAndColor(Label label, RobotState robot, string teamName)
        {
            label.Text = robot.TeamName = teamName;
            label.ForeColor = Color.Orange;
            CheckPrio(label, teamName);
        }

        // ── Robot resets ─────────────────────────────────────────────────────
        private static void ResetAllScouterRobots()
        {
            for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
                if (BackgroundCode.gamePads[i] != null)
                    BackgroundCode.Robots[i] = RobotState.ResetScouter(BackgroundCode.Robots[i]);
        }

        // ── Data load/save ────────────────────────────────────────────────────
        private void LoadData()
        {
            try
            {
                var ini = BackgroundCode.iniFile;
                string evt = ini.Read("MatchData", "event", "Please press the Load Events Button...");

                comboBoxSelectRegional.Items.Add(evt);
                comboBoxSelectRegional.SelectedItem = evt;

                BackgroundCode.currentMatch = int.Parse(ini.Read("MatchData", "match_number", "")) - 1;
                BackgroundCode.redRight = bool.Parse(ini.Read("MatchData", "redRight", ""));

                BackgroundCode.teamPrio.AddRange(ini.Read("MatchData", "teamPrio", "").Split(','));
                BackgroundCode.homeTeam = ini.Read("MatchData", "homeTeam", "None");
                BackgroundCode.loadedEvent = ini.Read("MatchData", "event", "");

                string[] scouterNames = ini.Read("MatchData", "scouterNames", "").Split(',');
                string[] scouterLocations = ini.Read("MatchData", "scouterLocations", "").Split(',');

                for (int i = 0; i < 6; i++)
                {
                    BackgroundCode.Robots[i]._ScouterName =
                        (RobotState.SCOUTER_NAME)Enum.Parse(typeof(RobotState.SCOUTER_NAME), scouterNames[i]);
                    BackgroundCode.Robots[i].ScouterBox = int.Parse(scouterLocations[i]);
                }

                BackgroundCode.InMemoryMatchList =
                    DatabaseCode.ListToMatch(ini.Read("EventData", "Matches", "").Split(','));

                ChangeSQLConnectionString(BackgroundCode.loadedEvent);

                if (comboBoxSelectRegional.SelectedItem.ToString() == "manualEvent")
                    DatabaseCode.LoadManualMatches();

                NextMatch();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load data.", "Error: " + ex);
            }
        }

        // ── SQL connection ────────────────────────────────────────────────────
        private static void ChangeSQLConnectionString(string newName)
        {
            if (Settings.Default.sqlExists)
                BackgroundCode.localSeasonframework.Database.Connection.Close();

            BackgroundCode.serverSeasonframework.Database.Connection.Close();

            string catalog = $"{DateTime.Now.Year}{newName}";

            var localBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder(
                Settings.Default._scoutingdbConnectionString)
            { InitialCatalog = catalog };

            var serverBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder(
                Settings.Default._scoutingdbServerConnectionString)
            { InitialCatalog = catalog };

            BackgroundCode.localSeasonframework.Database.Connection.ConnectionString = localBuilder.ConnectionString;
            BackgroundCode.serverSeasonframework.Database.Connection.ConnectionString = serverBuilder.ConnectionString;

            try
            {
                Settings.Default["_scoutingdbConnectionString"] = localBuilder.ConnectionString;
                Settings.Default["_scoutingdbServerConnectionString"] = serverBuilder.ConnectionString;
                Settings.Default.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not save new connection strings to Settings: " + ex.Message);
            }

            BackgroundCode.InitalizeDB();
        }

        // ── Event / match population ──────────────────────────────────────────
        private async void BtnpopulateForEvent_Click(object sender, EventArgs e)
        {
            if (_loading) return;

            ResetAllScouterRobots();

            _loading = true;
            BackgroundCode.UnSortedMatchList.Clear();
            BackgroundCode.InMemoryMatchList.Clear();

            try
            {
                if (BackgroundCode.manualMatchList != null)
                {
                    await PopulateManualMatchesAsync();
                }
                else if (comboBoxSelectRegional.Text == "Please press the Load Events Button...")
                {
                    MessageBox.Show("You must load an event first.", "Not Ready to Get Matches");
                    return;
                }
                else
                {
                    await PopulateTBAMatchesAsync();
                }

                BackgroundCode.currentMatch = 0;
                NextMatch();
            }
            catch { /* silently swallow – callers log individually */ }
            finally
            {
                _loading = false;
            }
        }

        private Task PopulateManualMatchesAsync()
        {
            ChangeSQLConnectionString("manualMatch");

            var manualTeams = new HashSet<string>(StringComparer.Ordinal);

            for (int i = 0; i < BackgroundCode.manualMatchList.Count; i++)
            {
                var matchData = new Match
                {
                    Match_number = i,
                    Set_number = i,
                    Key = "manualevent",
                    Comp_level = "qm",
                    Event_key = "manualevent",
                    Blueteam1 = "frc" + BackgroundCode.manualMatchList[i][0],
                    Blueteam2 = "frc" + BackgroundCode.manualMatchList[i][1],
                    Blueteam3 = "frc" + BackgroundCode.manualMatchList[i][2],
                    Redteam1 = "frc" + BackgroundCode.manualMatchList[i][3],
                    Redteam2 = "frc" + BackgroundCode.manualMatchList[i][4],
                    Redteam3 = "frc" + BackgroundCode.manualMatchList[i][5]
                };

                BackgroundCode.UnSortedMatchList.Add(matchData);
                BackgroundCode.InMemoryMatchList.Add(matchData);
                BackgroundCode.MatchNumbers.Add(i + 1);

                foreach (var team in BackgroundCode.manualMatchList[i])
                    manualTeams.Add(team);
            }

            BackgroundCode.InMemoryMatchList =
                [.. BackgroundCode.UnSortedMatchList.OrderBy(o => o.Match_number)];

            // Build match CSV with StringBuilder to avoid O(n²) string concatenation
            var sb = new StringBuilder();
            foreach (var m in BackgroundCode.InMemoryMatchList)
            {
                if (sb.Length > 0) sb.Append(',');
                sb.Append($"{m.Blueteam1};{m.Blueteam2};{m.Blueteam3};{m.Redteam1};{m.Redteam2};{m.Redteam3}");
            }
            BackgroundCode.iniFile.Write("EventData", "Matches", sb.ToString());

            foreach (var team in manualTeams)
            {
                BackgroundCode.teamlist.Add(team);
            }

            return Task.CompletedTask;
        }

        private async Task PopulateTBAMatchesAsync()
        {
            try
            {
                BackgroundCode.loadedEvent = comboBoxSelectRegional.SelectedItem.ToString();
                regional = BackgroundCode.loadedEvent.TrimStart('[');
                int idx = regional.IndexOf(',');
                if (idx > 0) regional = regional[..idx];

                string year = DateTime.Now.Year.ToString();
                string apiKey = Settings.Default.API_KEY;

                // ── Fetch teams ────────────────────────────────────────────
                string teamsUri = $"https://www.thebluealliance.com/api/v3/event/{year}{regional}/teams?X-TBA-Auth-Key={apiKey}";
                try
                {
                    var teamsJson = await _httpClient.GetStringAsync(teamsUri);
                    var teams = JsonConvert.DeserializeObject<List<TeamSummary>>(teamsJson);
                    Log($"Received {teams.Count} teams for {regional}.");

                    BackgroundCode.teamlist.Clear();
                    foreach (var t in teams)
                        BackgroundCode.teamlist.Add(t.Team_number);

                    Log("Teams -> " + string.Join(", ", teams.Select(t => t.Team_number)));
                }
                catch (HttpRequestException)
                {
                    _loading = false;
                    return;
                }

                // ── Fetch matches ──────────────────────────────────────────
                string matchesUri = $"https://www.thebluealliance.com/api/v3/event/{year}{regional}/matches?X-TBA-Auth-Key={apiKey}";
                try
                {
                    string matchesJson = await _httpClient.GetStringAsync(matchesUri);
                    var jsonMatches = JsonConvert.DeserializeObject<List<Match>>(matchesJson);
                    dynamic obj = JsonConvert.DeserializeObject(matchesJson);

                    int matchCount = 0;
                    BackgroundCode.MatchNumbers.Clear();

                    for (int i = 0; i < jsonMatches.Count; i++)
                    {
                        if (jsonMatches[i].Comp_level != "qm") continue;

                        matchCount++;
                        BackgroundCode.MatchNumbers.Add(matchCount);
                        BackgroundCode.InMemoryMatchList.Add(jsonMatches[i]);

                        dynamic alliances = obj[i].alliances;
                        dynamic blueteams = alliances.blue.team_keys;
                        dynamic redteams = alliances.red.team_keys;

                        var record = new Match
                        {
                            Match_number = (int)obj[i].match_number,
                            Set_number = obj[i].match_number,
                            Key = obj[i].key,
                            Comp_level = obj[i].comp_level,
                            Event_key = obj[i].event_key,
                            Blueteam1 = blueteams[0],
                            Blueteam2 = blueteams[1],
                            Blueteam3 = blueteams[2],
                            Redteam1 = redteams[0],
                            Redteam2 = redteams[1],
                            Redteam3 = redteams[2]
                        };
                        BackgroundCode.UnSortedMatchList.Add(record);
                    }

                    Log($"{BackgroundCode.UnSortedMatchList.Count} matches");
                }
                catch (HttpRequestException)
                {
                    _loading = false;
                    return;
                }

                ChangeSQLConnectionString(regional);
                BackgroundCode.InMemoryMatchList =
                    [.. BackgroundCode.UnSortedMatchList.OrderBy(o => o.Match_number)];
            }
            catch
            {
                MessageBox.Show("Please select an event from the drop down.");
            }
        }

        private async void GetEvents(bool isManual)
        {
            if (isManual)
            {
                DatabaseCode.LoadManualMatches();
                return;
            }

            string uri = $"https://www.thebluealliance.com/api/v3/events/{DateTime.Now.Year}?X-TBA-Auth-Key={Settings.Default.API_KEY}";
            try
            {
                string json = await _httpClient.GetStringAsync(uri);
                var events = JsonConvert.DeserializeObject<List<EventSummary>>(json);

                comboBoxSelectRegional.DataSource =
                    events.Select(ev => new KeyValuePair<string, string>(
                        ev.Event_code, $"{ev.Event_code} - {ev.Name}")).ToList();
            }
            catch (HttpRequestException)
            {
                if (MessageBox.Show("Do you want to load manual matches?",
                        "Error loading Blue Alliance data.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatabaseCode.LoadManualMatches();
                    comboBoxSelectRegional.Items.Add("manualEvent");
                    comboBoxSelectRegional.SelectedItem = "manualEvent";
                }
            }
        }

        // ── Priority check ────────────────────────────────────────────────────
        public static void CheckPrio(Label label, string teamName)
        {
            string number = teamName[3..];
            if (BackgroundCode.teamPrio.Contains(number) || BackgroundCode.homePrio.Contains(number))
                label.ForeColor = Color.White;
        }

        // ── Logging ───────────────────────────────────────────────────────────
        private static async void Log(string m) => await Logger.Log(m);

        // ── Screen update (called at 50 Hz by timerJoysticks) ─────────────────
        private void UpdateScreen(object sender, EventArgs e)
        {
            int padCount = BackgroundCode.gamePads.Length;
            for (int i = 0; i < padCount; i++)
            {
                if (BackgroundCode.gamePads[i] == null) continue;

                RobotState robot = BackgroundCode.Robots[i];
                int box = robot.ScouterBox;
                var mode = robot.GetRobotMode();

                // Only re-apply visibility + static text when mode changed
                if (!_lastModeInitialized[box] || _lastMode[box] != mode)
                {
                    switch (mode)
                    {
                        case RobotState.ROBOT_MODE.Prematch: InPrematchMode(robot, box); break;
                        case RobotState.ROBOT_MODE.Red: InRedMode(robot, box); break;
                        case RobotState.ROBOT_MODE.Neutral: InNeutralMode(robot, box); break;
                        case RobotState.ROBOT_MODE.Blue: InBlueMode(robot, box); break;
                        case RobotState.ROBOT_MODE.Endgame: InEndgameMode(robot, box); break;
                    }
                    _lastMode[box] = mode;
                    _lastModeInitialized[box] = true;
                }
                else
                {
                    // Mode unchanged – only update the dynamic timer text
                    UpdateDynamicLabels(robot, box, mode);
                }

                // Always refresh the header labels (cheap string assigns)
                SetLabelTextIfChanged(robotLabels[box][RobotLabelType.ScoutName], robot.GetScouterName().ToString());
                SetLabelTextIfChanged(robotLabels[box][RobotLabelType.MatchEvent], robot.MatchEvent.ToString());
                SetLabelTextIfChanged(robotLabels[box][RobotLabelType.TeamName], robot.TeamName);

                UpdateModeValueLabel(robot, box);
            }
        }

        // Only write to the Label if the text has actually changed (avoids WinForms repaint)
        private static void SetLabelTextIfChanged(Label lbl, string text)
        {
            if (lbl.Text != text) lbl.Text = text;
        }

        private static void SetLabelColorIfChanged(Label lbl, Color fore, Color back)
        {
            if (lbl.ForeColor != fore) lbl.ForeColor = fore;
            if (lbl.BackColor != back) lbl.BackColor = back;
        }

        private void UpdateModeValueLabel(RobotState robot, int box)
        {
            var lbl = robotLabels[box][RobotLabelType.ModeValue];

            if (robot.NoSho)
            {
                SetLabelTextIfChanged(lbl, "NO SHOW");
                SetLabelColorIfChanged(lbl, Color.White, Color.Red);
            }
            else if (robot.AUTO && robot.GetRobotMode() != RobotState.ROBOT_MODE.Prematch)
            {
                SetLabelTextIfChanged(lbl, "AUTO " + robot.GetRobotMode() + " Mode");
                SetLabelColorIfChanged(lbl, Color.LimeGreen, Color.Black);
            }
            else
            {
                SetLabelTextIfChanged(lbl, robot.GetRobotMode() + " Mode");
                SetLabelColorIfChanged(lbl, Color.White, Color.Black);
            }
        }

        // Updates only timer-driven labels when mode hasn't changed
        private void UpdateDynamicLabels(RobotState robot, int box, RobotState.ROBOT_MODE mode)
        {
            var pl = robotPositionLabels[box];
            switch (mode)
            {
                case RobotState.ROBOT_MODE.Red:
                case RobotState.ROBOT_MODE.Neutral:
                case RobotState.ROBOT_MODE.Blue:
                    SetLabelTextIfChanged(pl[RobotPositionLabelType.Position1],
                        "Intake Timer: " + robot.FuelIntakingTime.TotalSeconds.ToString("F2"));

                    if (mode == RobotState.ROBOT_MODE.Neutral)
                    {
                        SetLabelTextIfChanged(pl[RobotPositionLabelType.Position2],
                            "Feeding Timer: " + robot.FeedingTime.TotalSeconds.ToString("F2"));
                        SetLabelTextIfChanged(pl[RobotPositionLabelType.Position4],
                            "Defense Timer: " + robot.DefenseTime.TotalSeconds.ToString("F2"));
                    }
                    else
                    {
                        bool isOwnColor = (mode == RobotState.ROBOT_MODE.Red && robot.color == RobotState.COLOR.Red)
                                       || (mode == RobotState.ROBOT_MODE.Blue && robot.color == RobotState.COLOR.Blue);

                        if (isOwnColor)
                            SetLabelTextIfChanged(pl[RobotPositionLabelType.Position2],
                                "Shooting Timer: " + robot.FuelShootingTime.TotalSeconds.ToString("F2"));
                        else
                            SetLabelTextIfChanged(pl[RobotPositionLabelType.Position2],
                                "Feeding Timer: " + robot.FeedingTime.TotalSeconds.ToString("F2"));

                        if (!robot.AUTO)
                            SetLabelTextIfChanged(pl[RobotPositionLabelType.Position4],
                                "Defense Timer: " + robot.DefenseTime.TotalSeconds.ToString("F2"));
                    }
                    break;

                case RobotState.ROBOT_MODE.Endgame:
                    SetLabelTextIfChanged(pl[RobotPositionLabelType.Position1],
                        "Climb Timer: " + robot.ClimbTime.TotalSeconds.ToString("F2"));
                    break;
            }
        }

        // ── Mode display methods ──────────────────────────────────────────────
        // Helper to set visibility of all position labels in one call
        private void SetPositionVisibility(int box, bool p0, bool p1, bool p2, bool p2v, bool p3, bool p3v, bool p4, bool p4v, bool p6, bool p7, bool p8, bool p9)
        {
            var pl = robotPositionLabels[box];
            pl[RobotPositionLabelType.Position0].Visible = p0;
            pl[RobotPositionLabelType.Position1].Visible = p1;
            pl[RobotPositionLabelType.Position2].Visible = p2;
            pl[RobotPositionLabelType.Position2Value].Visible = p2v;
            pl[RobotPositionLabelType.Position3].Visible = p3;
            pl[RobotPositionLabelType.Position3Value].Visible = p3v;
            pl[RobotPositionLabelType.Position4].Visible = p4;
            pl[RobotPositionLabelType.Position4Value].Visible = p4v;
            pl[RobotPositionLabelType.Position6].Visible = p6;
            pl[RobotPositionLabelType.Position7].Visible = p7;
            pl[RobotPositionLabelType.Position8].Visible = p8;
            pl[RobotPositionLabelType.Position9].Visible = p9;
        }

        private void InPrematchMode(RobotState robot, int box)
        {
            SetPositionVisibility(box, p0: true, p1: false, p2: false, p2v: false, p3: false, p3v: false, p4: false, p4v: false, p6: false, p7: false, p8: false, p9: false);

            var lbl = robotPositionLabels[box][RobotPositionLabelType.Position0];
            lbl.ForeColor = robot.GetStartingLocation() == RobotState.STARTING_LOCATION.None
                ? Color.Yellow : Color.White;
            lbl.Text = "Starting Location: " + robot.GetStartingLocation();
        }

        private void InRedMode(RobotState robot, int box)
        {
            SetPositionVisibility(box, p0: true, p1: true, p2: true, p2v: false, p3: true, p3v: false, p4: true, p4v: false, p6: false, p7: false, p8: false, p9: false);

            ApplyColorModeLabels(robot, box, RobotState.COLOR.Red);
        }

        private void InNeutralMode(RobotState robot, int box)
        {
            SetPositionVisibility(box, p0: true, p1: true, p2: true, p2v: false, p3: true, p3v: false, p4: true, p4v: false, p6: false, p7: false, p8: false, p9: false);

            var pl = robotPositionLabels[box];
            pl[RobotPositionLabelType.Position0].Text = robot.NearFar.ToString() + " Side";
            pl[RobotPositionLabelType.Position1].Text = "Intake Timer: " + robot.FuelIntakingTime.TotalSeconds.ToString("F2");
            pl[RobotPositionLabelType.Position2].Text = "Feeding Timer: " + robot.FeedingTime.TotalSeconds.ToString("F2");
            pl[RobotPositionLabelType.Position3].Text = "Bump: " + robot.BumpTraversal;
            pl[RobotPositionLabelType.Position4].Text = "Defense Timer: " + robot.DefenseTime.TotalSeconds.ToString("F2");
        }

        private void InBlueMode(RobotState robot, int box)
        {
            SetPositionVisibility(box, p0: true, p1: true, p2: true, p2v: false, p3: true, p3v: false, p4: true, p4v: false, p6: false, p7: false, p8: false, p9: false);

            ApplyColorModeLabels(robot, box, RobotState.COLOR.Blue);
        }

        // Shared logic for Red / Blue modes (only differ in color check)
        private void ApplyColorModeLabels(RobotState robot, int box, RobotState.COLOR ownColor)
        {
            var pl = robotPositionLabels[box];
            pl[RobotPositionLabelType.Position0].Text = robot.NearFar.ToString() + " Side";
            pl[RobotPositionLabelType.Position1].Text = "Intake Timer: " + robot.FuelIntakingTime.TotalSeconds.ToString("F2");

            if (robot.color == ownColor)
            {
                pl[RobotPositionLabelType.Position2].Text = "Shooting Timer: " + robot.FuelShootingTime.TotalSeconds.ToString("F2");

                if (robot.AUTO)
                {
                    pl[RobotPositionLabelType.Position4].Text = "Climb: ";
                    pl[RobotPositionLabelType.Position4Value].Visible = true;
                    ApplyBooleanColor(pl[RobotPositionLabelType.Position4Value], robot.GetAutoClimb());
                }
            }
            else
            {
                pl[RobotPositionLabelType.Position2].Text = "Feeding Timer: " + robot.FeedingTime.TotalSeconds.ToString("F2");
            }

            if (!robot.AUTO)
            {
                pl[RobotPositionLabelType.Position4Value].Visible = false;
                pl[RobotPositionLabelType.Position4].Text = "Defense Timer: " + robot.DefenseTime.TotalSeconds.ToString("F2");
            }

            pl[RobotPositionLabelType.Position3].Text = "Bump: " + robot.BumpTraversal;
        }

        private void InEndgameMode(RobotState robot, int box)
        {
            SetPositionVisibility(box, p0: false, p1: true, p2: true, p2v: true, p3: true, p3v: true, p4: true, p4v: false, p6: true, p7: true, p8: true, p9: true);

            var pl = robotPositionLabels[box];

            pl[RobotPositionLabelType.Position1].Text = "Climb Timer: " + robot.ClimbTime.TotalSeconds.ToString("F2");
            pl[RobotPositionLabelType.Position2].Text = "End Match: ";
            pl[RobotPositionLabelType.Position3].Text = "Climb Attempt: ";

            // Coloured indicator labels default to Yellow (unset)
            ApplyBooleanColor(pl[RobotPositionLabelType.Position2Value], robot.GetEndMatch());
            ApplyBooleanColor(pl[RobotPositionLabelType.Position3Value], robot.GetClimbSuccess());

            SetStrategyLabelColor(pl[RobotPositionLabelType.Position4], robot.GetAvoidanceStrategy() == RobotState.AVOIDANCE_STRATEGY.Select);
            pl[RobotPositionLabelType.Position4].Text = "Avoidance: " + robot.GetAvoidanceStrategy();

            pl[RobotPositionLabelType.Position6].Text = "Climb Level: " + robot.GetClimbLevel();

            SetStrategyLabelColor(pl[RobotPositionLabelType.Position7], robot.GetDefenseStrategy() == RobotState.DEFENSE_STRATEGY.Select);
            pl[RobotPositionLabelType.Position7].Text = "Defense: " + robot.GetDefenseStrategy();

            SetStrategyLabelColor(pl[RobotPositionLabelType.Position8], robot.GetStrategy() == RobotState.STRATEGY.Select);
            pl[RobotPositionLabelType.Position8].Text = "Strategy: " + robot.GetStrategy();

            pl[RobotPositionLabelType.Position9].Text = "Ladder Location: " + robot.GetLadderLocation();
        }

        // ── Shared colour helpers ─────────────────────────────────────────────
        /// <summary>Maps a tri-state BOOLEAN to Yellow / Green / Red on a label.</summary>
        private static void ApplyBooleanColor(Label lbl, RobotState.BOOLEAN value)
        {
            Color c = value switch
            {
                RobotState.BOOLEAN.Yes => Color.Green,
                RobotState.BOOLEAN.No => Color.Red,
                _ => Color.Yellow  // Z / unset
            };
            SetLabelColorIfChanged(lbl, c, c);
        }

        /// <summary>Highlights a strategy label yellow when still on the default "Select" value.</summary>
        private static void SetStrategyLabelColor(Label lbl, bool isSelectState)
        {
            Color c = isSelectState ? Color.Yellow : Color.White;
            if (lbl.ForeColor != c) lbl.ForeColor = c;
        }
    }
}