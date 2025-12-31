using ControllerScouting.Database;
using ControllerScouting.Gamepad;
using ControllerScouting.Utilities;
using Newtonsoft.Json;
using Supabase;
using Supabase.Gotrue;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client = Supabase.Client;

namespace ControllerScouting.Screens
{
    public partial class BaseScreen : Form
    {
        private static bool loading = false;
        public string regional;

        public BaseScreen()
        {
            if (Enum.TryParse<BackgroundCode.EXPORT_TYPE>(BackgroundCode.iniFile.Read("ProgramProperties.Settings", "exportType", ""), out var exportType))
            {
                BackgroundCode.dataExport = exportType;
            }
            else
            {
                BackgroundCode.dataExport = BackgroundCode.EXPORT_TYPE.CSV;
            }
            Properties.Settings.Default.CSVLocation = BackgroundCode.iniFile.Read("ProgramProperties.Settings", "csvLocation", "");

            if (BackgroundCode.dataExport == BackgroundCode.EXPORT_TYPE.CSV)
            {
                Properties.Settings.Default.csvExists = DatabaseCode.DoesCSVExist(Properties.Settings.Default.CSVLocation);
            }


            //Initialization of the screen
            InitializeComponent();

            AdjustFormSizeAndScale();

            //If there is previous data, ask if the user wants to load it
            if (BackgroundCode.iniFile.Read("MatchData", "event", "") != null && BackgroundCode.iniFile.Read("MatchData", "event", "") != "" && BackgroundCode.iniFile.Read("MatchData", "event", "") != " ")
            {
                DialogResult loadPrevData = MessageBox.Show("Do you want to load previous data?", "Please Confirm", MessageBoxButtons.YesNo);
                if (loadPrevData == DialogResult.Yes)
                {
                    LoadData();
                }
            }

            timerJoysticks.Interval = 20;
            timerJoysticks.Tick += new EventHandler(this.UpdateScreen);
            timerJoysticks.Enabled = true;

            Thread statusLightThread = new(() => StatusLightThread());
            statusLightThread.Start();
        }

        private void AdjustFormSizeAndScale()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.WorkingArea;

            this.Width = screenBounds.Width;
            this.Height = screenBounds.Height;

            this.StartPosition = FormStartPosition.CenterScreen;

            this.AutoScaleMode = AutoScaleMode.Dpi;

            float scaleFactorX = (float)screenBounds.Width / 1512;
            float scaleFactorY = (float)screenBounds.Height / 872;

            ScaleControls(this, scaleFactorX, scaleFactorY);
        }

        private static void ScaleControls(Control parent, float scaleFactorX, float scaleFactorY)
        {
            foreach (Control control in parent.Controls)
            {
                control.Width = (int)(control.Width * scaleFactorX);
                control.Height = (int)(control.Height * scaleFactorY);

                control.Left = (int)(control.Left * scaleFactorX);
                control.Top = (int)(control.Top * scaleFactorY);

                control.Font = new System.Drawing.Font(control.Font.FontFamily, control.Font.Size * Math.Min(scaleFactorX, scaleFactorY), control.Font.Style);

                if (control.HasChildren)
                {
                    ScaleControls(control, scaleFactorX, scaleFactorY);
                }
            }
        }

        private void StatusLightThread()
        {
            while (true)
            {
                //Check the fore color of status light in the top right corner, if red, make it green. If green, make it red.
                if (this.statusLight.BackColor == Color.Green)
                {
                    this.statusLight.BackColor = Color.Red;
                }
                else
                {
                    this.statusLight.BackColor = Color.Green;
                }

                Thread.Sleep(500);
            }
        }
        private static void ControllerThreadMethod(GamePad gamePad, CancellationToken token)
        {
            // Logic to handle the controller
            while (!token.IsCancellationRequested)
            {
                // Read and process the controller input
                if (gamePad != null) Controllers.ReadStick(gamePad, Array.IndexOf(BackgroundCode.gamePads, gamePad));
            }
        }

        private static void InitalizeDB()
        {
            if (Properties.Settings.Default.sqlExists)
            {
                // Sets the connection string to the database
                BackgroundCode.seasonframework.Database.Connection.ConnectionString = Properties.Settings.Default._scoutingdbConnectionString;

                // initializes the database
                BackgroundCode.seasonframework.Database.Initialize(true);
            }

            _ = InitialzeSupabase();
        }

        private static async Task InitialzeSupabase()
        {
            NetworkStatus status = new();

            SupabaseOptions options = new()
            {
                AutoRefreshToken = true
            };

            Client _supabase = new(BackgroundCode.iniFile.Read("SupaBase","url",""), BackgroundCode.iniFile.Read("SupaBase", "key", ""), options);

            status.Client = (Supabase.Gotrue.Client)_supabase.Auth;

            _supabase.Auth.LoadSession();

            _supabase.Auth.Options.AllowUnconfirmedUserSessions = true;

            BackgroundCode.iniFile.Write("SupaBase", "url", "https://lmqqqmkygfkpuccptvzw.supabase.co");
            BackgroundCode.iniFile.Write("SupaBase", "key", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImxtcXFxbWt5Z2ZrcHVjY3B0dnp3Iiwicm9sZSI6ImFub24iLCJpYXQiOjE3NjE3NDYxNTUsImV4cCI6MjA3NzMyMjE1NX0.1_wX1GGEtHkLMo0Z-oI98UHdZnuGL3x3UnDjA0gbvlU");
            BackgroundCode.iniFile.Write("SupaBase", "email", "testingEmail@gmail.com");
            BackgroundCode.iniFile.Write("SupaBase", "password", "ReallyGoodPassword!");

            string url = $"{BackgroundCode.iniFile.Read("SupaBase", "url", "")}/auth/v1/settings?apikey={BackgroundCode.iniFile.Read("SupaBase", "key", "")}";
            try
            {
                _supabase!.Auth.Online = await status.StartAsync(url);
            }
            catch (NotSupportedException)
            {
                _supabase!.Auth.Online = true;
            }
            catch (Exception e)
            {
                _ = Logger.Log($"Network Error {e.GetType()}");
                _supabase!.Auth.Online = false;
            }
            if (_supabase.Auth.Online)
            {
                await _supabase.InitializeAsync();

                await _supabase.Auth.Settings();

                try
                {
                    var email = BackgroundCode.iniFile.Read("SupaBase","email","");
                    var password = BackgroundCode.iniFile.Read("SupaBase", "password","");

                    if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
                    {
                        var session = await _supabase.Auth.SignInWithPassword(email, password);
                        System.Diagnostics.Debug.WriteLine($"Supabase sign-in success. User: {session?.User?.Email ?? "unknown"}");

                        BackgroundCode.supabase = _supabase;
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Supabase sign-in skipped: missing INI credentials (Supabase.Auth email/password).");
                    }
                }
                catch (Exception ex)
                {
                    _ = Logger.Log($"Supabase sign-in failed: {ex.Message}");
                    System.Diagnostics.Debug.WriteLine($"Supabase sign-in failed: {ex}");
                }
            }
        }


        public static void UpdateJoysticks()
        {
            foreach (var cts in BackgroundCode.controllerCancellationTokens)
            {
                cts.Cancel();
            }
            BackgroundCode.controllerCancellationTokens.Clear();
            BackgroundCode.controllerThreads.Clear();

            //Updates the list of currently connected gamepads
            BackgroundCode.gamePads = Controllers.GetGamePads();
            BackgroundCode.StartControllerThreads();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Makes sure the user wants to exit
            DialogResult confirmExit = MessageBox.Show("Are you sure you want to exit?", "Please Confirm", MessageBoxButtons.YesNo);
            if (confirmExit == DialogResult.Yes)
            {
                //If the event is loaded or manual matches are loaded, ask if the user wants to save the data
                if (BackgroundCode.loadedEvent != null || BackgroundCode.manualMatchList != null)
                {
                    confirmExit = MessageBox.Show("Do you want to save the current data?", "Please Confirm", MessageBoxButtons.YesNo);
                    if (confirmExit == DialogResult.Yes)
                    {
                        //Save the data
                        BackgroundCode.SaveData();
                    }
                }

                //Close the connection then exit
                if (Properties.Settings.Default.sqlExists) 
                {
                    BackgroundCode.seasonframework.Database.Connection.Close();
                }
                Environment.Exit(0);
            }
        }
        private void BtnInitialDBLoad_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.sqlExists)
            {
                BackgroundCode.seasonframework.Database.Connection.Close();
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to load The Blue Alliance data?", "Please Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Properties.Settings.Default.sqlExists)
                {
                    BackgroundCode.seasonframework.Database.Connection.Open();
                }
                GetEvents(false);
                SetRedRight();

                Log("Start time is " + DateTime.Now.TimeOfDay);
            }
            else
            {
                DialogResult manualMatches = MessageBox.Show("Do you want to load manual matches?", "Please Confirm", MessageBoxButtons.YesNo);
                if (manualMatches == DialogResult.Yes)
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
            //  Logic for setting left/right and near/far based on side of field scouters are sitting on
            DialogResult red = MessageBox.Show("Is the Red Alliance on your right?", "Please Confirm", MessageBoxButtons.YesNo);
            BackgroundCode.redRight = (red == DialogResult.Yes);
        }
        private void LoadData()
        {
            try
            {
                comboBoxSelectRegional.Items.Add(BackgroundCode.iniFile.Read("MatchData", "event", "Please press the Load Events Button..."));
                comboBoxSelectRegional.SelectedItem = BackgroundCode.iniFile.Read("MatchData", "event", "Please press the Load Events Button...");
                BackgroundCode.currentMatch = int.Parse(BackgroundCode.iniFile.Read("MatchData", "match_number", "")) - 1;
                BackgroundCode.redRight = bool.Parse(BackgroundCode.iniFile.Read("MatchData", "redRight", ""));
                var teamPrioList = new List<string>(BackgroundCode.iniFile.Read("MatchData", "teamPrio", "").Split(','));
                BackgroundCode.teamPrio.AddRange([.. teamPrioList]);
                BackgroundCode.homeTeam = BackgroundCode.iniFile.Read("MatchData", "homeTeam", "None");
                BackgroundCode.loadedEvent = BackgroundCode.iniFile.Read("MatchData", "event", "");


                List<string> scouterNames = [.. BackgroundCode.iniFile.Read("MatchData", "scouterNames", "").Split(',')];
                List<string> scouterLocations = [.. BackgroundCode.iniFile.Read("MatchData", "scouterLocations", "").Split(',')];

                for (int i = 0; i < 6; i++)
                {
                    BackgroundCode.Robots[i]._ScouterName = (RobotState.SCOUTER_NAME)Enum.Parse(typeof(RobotState.SCOUTER_NAME), scouterNames[i]);
                    BackgroundCode.Robots[i].ScouterBox = int.Parse(scouterLocations[i]);
                }

                BackgroundCode.InMemoryMatchList = DatabaseCode.ListToMatch(BackgroundCode.iniFile.Read("EventData", "Matches", "").Split(','));

                if (Properties.Settings.Default.sqlExists)
                {
                    BackgroundCode.seasonframework.Database.Connection.Close();
                }

                if (comboBoxSelectRegional.SelectedItem.ToString() == "manualEvent")
                {
                    DatabaseCode.LoadManualMatches();
                }

                NextMatch();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not load data.", "Error: " + e);
            }
        }

        private void BtnNextMatch_Click(object sender, EventArgs e)
        {
            if (cbxEndMatch.Checked)
            {
                for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
                {
                    DatabaseCode.SaveToRecord(BackgroundCode.Robots[BackgroundCode.Robots[i].ScouterBox], "EndMatch", i);
                }
                DatabaseCode.SendToDatabase();
                cbxEndMatch.Checked = false;

                if (BackgroundCode.currentMatch == BackgroundCode.InMemoryMatchList.Count)
                {
                    MessageBox.Show("You are at the last match.");
                }
                else
                {
                    NextMatch();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("All unsaved data will be lost.  Continue?", "Next Match", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes && BackgroundCode.currentMatch != BackgroundCode.InMemoryMatchList.Count)
                {
                    for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
                    {
                        if (BackgroundCode.gamePads[i] != null)
                        {
                            BackgroundCode.Robots[i] = RobotState.ResetScouter(BackgroundCode.Robots[i]);
                        }
                    }

                    NextMatch();
                }
                else if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
                    {
                        if (BackgroundCode.gamePads[i] != null)
                        {
                            BackgroundCode.Robots[i] = RobotState.ResetScouter(BackgroundCode.Robots[i]);
                        }
                    }

                    MessageBox.Show("You are at the last match.");
                }
            }
        }
        private void NextMatch()
        {
            BackgroundCode.currentMatch++;
            LoadMatch();
        }
        private void BtnPrevMatch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BackgroundCode.gamePads.Length; i++)
            {
                if (BackgroundCode.gamePads[i] != null)
                {
                    BackgroundCode.Robots[i] = RobotState.ResetScouter(BackgroundCode.Robots[i]);
                }
            }

            if (BackgroundCode.currentMatch == 0 || BackgroundCode.currentMatch == 1)
            {
                MessageBox.Show("You are at the first match.");
            }
            else
            {
                BackgroundCode.currentMatch--;

                LoadMatch();
            }
        }
        private void LoadMatch()
        {
            SetTeamNameAndColor(this.lbl0TeamName, BackgroundCode.Robots[0], BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Redteam1);
            SetTeamNameAndColor(this.lbl1TeamName, BackgroundCode.Robots[1], BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Redteam2);
            SetTeamNameAndColor(this.lbl2TeamName, BackgroundCode.Robots[2], BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Redteam3);
            SetTeamNameAndColor(this.lbl3TeamName, BackgroundCode.Robots[3], BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Blueteam1);
            SetTeamNameAndColor(this.lbl4TeamName, BackgroundCode.Robots[4], BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Blueteam2);
            SetTeamNameAndColor(this.lbl5TeamName, BackgroundCode.Robots[5], BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Blueteam3);
            
            this.lblMatch.Text = $"{BackgroundCode.currentMatch}/{BackgroundCode.InMemoryMatchList.Count}";
        }
        private static void SetTeamNameAndColor(Label label, RobotState robot, string teamName)
        {
            label.Text = robot.TeamName = teamName;
            label.ForeColor = Color.Orange;
            CheckPrio(label, teamName);
        }
        private async void BtnpopulateForEvent_Click(object sender, EventArgs e)
        {
            if (!loading)
            {
                loading = true;
                BackgroundCode.UnSortedMatchList.Clear();
                BackgroundCode.InMemoryMatchList.Clear();
                if (BackgroundCode.manualMatchList != null)
                {
                    List<string> manualTeams = [];

                    for (int i = 0; i < BackgroundCode.manualMatchList.Count; i++)
                    {
                        Match matchData = new()
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

                        for (int j = 0; j < BackgroundCode.manualMatchList[i].Count; j++)
                        {
                            if (!manualTeams.Contains(BackgroundCode.manualMatchList[i][j]))
                            {
                                manualTeams.Add(BackgroundCode.manualMatchList[i][j]);
                            }
                        }
                    }

                    BackgroundCode.InMemoryMatchList = [.. BackgroundCode.UnSortedMatchList.OrderBy(o => o.Match_number)];
                    
                    string matches = "";
                    foreach (var match in BackgroundCode.InMemoryMatchList)
                    {
                        if (matches.Length != 0)
                        {
                            matches += ",";
                        }
                        matches += $"{match.Blueteam1};{match.Blueteam2};{match.Blueteam3};{match.Redteam1};{match.Redteam2};{match.Redteam3}";
                    }
                    BackgroundCode.iniFile.Write("EventData", "Matches", matches);


                    foreach (var team in manualTeams)
                    {
                        TeamSummary teamData = new()
                        {
                            Team_key = "frc" + team,
                            Team_number = team,
                            Event_key = "manualevent",
                            Nickname = "manualevent"
                        };

                        BackgroundCode.teamlist.Add(team);
                    }
                }
                else if (this.comboBoxSelectRegional.Text == "Please press the Load Events Button...")
                {
                    MessageBox.Show("You must load an event first.", "Not Ready to Get Matches");
                    return;
                }
                else
                {
                    try
                    {
                        BackgroundCode.loadedEvent = comboBoxSelectRegional.SelectedItem.ToString();
                        regional = BackgroundCode.loadedEvent.TrimStart('[');
                        int index = regional.IndexOf(',');
                        if (index > 0) regional = regional[..index];

                        string uri = $"https://www.thebluealliance.com/api/v3/event/{DateTime.Now.Year}{regional}/teams?X-TBA-Auth-Key={Properties.Settings.Default.API_KEY}";

                        using (HttpClient client = new())
                        {
                            try
                            {
                                HttpResponseMessage response = await client.GetAsync(uri);
                                response.EnsureSuccessStatusCode(); // Throw if not a success code.

                                string responseFromServer = await response.Content.ReadAsStringAsync();
                                //Log("Response from Server -> " + responseFromServer);
                                //Console.Write(responseFromServer);

                                List<TeamSummary> JSONteams = JsonConvert.DeserializeObject<List<TeamSummary>>(responseFromServer);
                                Log("Received " + JSONteams.Count + " teams for " + regional + ".");

                                // Clear the existing team list
                                BackgroundCode.teamlist.Clear();

                                foreach (var item in JSONteams)
                                {
                                    BackgroundCode.teamlist.Add(item.Team_number);
                                }
                                Log("Teams -> " + string.Join(", ", JSONteams.Select(item => item.Team_number)));
                            }
                            catch (HttpRequestException)
                            {
                                loading = false;
                            }
                        }

                        string matchesuri = $"https://www.thebluealliance.com/api/v3/event/{DateTime.Now.Year}{regional}/matches?X-TBA-Auth-Key={Properties.Settings.Default.API_KEY}";

                        using (HttpClient client = new())
                        {
                            try
                            {
                                HttpResponseMessage response = await client.GetAsync(matchesuri);
                                response.EnsureSuccessStatusCode(); // Throw if not a success code.

                                string responseFromServer = await response.Content.ReadAsStringAsync();

                                List<Match> JSONmatches = JsonConvert.DeserializeObject<List<Match>>(responseFromServer);
                                dynamic obj = JsonConvert.DeserializeObject(responseFromServer);

                                int MatchCount = 0;
                                BackgroundCode.MatchNumbers.Clear();

                                for (int i = 0; i < JSONmatches.Count; i++)
                                {
                                    if (JSONmatches[i].Comp_level == "qm")
                                    {
                                        Match match_record = new();

                                        MatchCount++;
                                        BackgroundCode.MatchNumbers.Add(MatchCount);
                                        BackgroundCode.InMemoryMatchList.Add(JSONmatches[i]);

                                        dynamic alliances = obj[i].alliances;
                                        dynamic bluealliance = alliances.blue;
                                        dynamic redalliance = alliances.red;

                                        dynamic blueteamsobj = bluealliance.team_keys;
                                        dynamic redteamsobj = redalliance.team_keys;

                                        match_record.Match_number = (int)obj[i].match_number;

                                        match_record.Set_number = obj[i].match_number;

                                        match_record.Key = obj[i].key;
                                        match_record.Comp_level = obj[i].comp_level;
                                        match_record.Event_key = obj[i].event_key;
                                        match_record.Blueteam1 = blueteamsobj[0];
                                        match_record.Blueteam2 = blueteamsobj[1];
                                        match_record.Blueteam3 = blueteamsobj[2];
                                        match_record.Redteam1 = redteamsobj[0];
                                        match_record.Redteam2 = redteamsobj[1];
                                        match_record.Redteam3 = redteamsobj[2];

                                        BackgroundCode.UnSortedMatchList.Add(match_record);
                                    }
                                }
                                Log($"{BackgroundCode.UnSortedMatchList.Count} matches");
                            }
                            catch (HttpRequestException)
                            {
                                loading = false;
                            }
                        }

                        BackgroundCode.InMemoryMatchList = [.. BackgroundCode.UnSortedMatchList.OrderBy(o => o.Match_number)];
                    }
                    catch
                    {
                        MessageBox.Show("Please select an event from the drop down.");
                    }
                }
                try
                {
                    BackgroundCode.currentMatch = 0;
                    loading = false;
                    NextMatch();
                }
                catch { }
            }
        }
        private async void GetEvents(bool isManual)
        {
            if (isManual)
            {
                DatabaseCode.LoadManualMatches();
            }
            else
            {
                string uri = $"https://www.thebluealliance.com/api/v3/events/{DateTime.Now.Year}?X-TBA-Auth-Key={Properties.Settings.Default.API_KEY}";

                using HttpClient client = new();
                try
                {
                    HttpResponseMessage response = await client.GetAsync(uri);
                    response.EnsureSuccessStatusCode(); // Throw if not a success code.

                    string responseFromServer = await response.Content.ReadAsStringAsync();

                    List<EventSummary> JSONevents = JsonConvert.DeserializeObject<List<EventSummary>>(responseFromServer);
                    List<KeyValuePair<string, string>> elist = [];

                    foreach (var item in JSONevents)
                    {
                        elist.Add(new KeyValuePair<string, string>(item.Event_code, $"{item.Event_code} - {item.Name}"));
                    }
                    this.comboBoxSelectRegional.DataSource = elist;
                }
                catch (HttpRequestException)
                {
                    DialogResult manualMatches = MessageBox.Show("Do you want to load manual matches?", "Error loading Blue Alliance data.", MessageBoxButtons.YesNo);
                    if (manualMatches == DialogResult.Yes)
                    {
                        DatabaseCode.LoadManualMatches();
                        comboBoxSelectRegional.Items.Add("manualEvent");
                        comboBoxSelectRegional.SelectedItem = "manualEvent";
                    }
                }
            }
        }
        public static void CheckPrio(Label label, string teamName)
        {
            if (BackgroundCode.teamPrio.Contains(teamName[3..]) || BackgroundCode.homePrio.Contains(teamName[3..]))
            {
                label.ForeColor = Color.White;
            }
        }
        private static async void Log(string m)
        {
            await Logger.Log(m);
        }
        private void BtnFunctions_Click(object sender, EventArgs e)
        {
            FunctionsForm frm = new();
            frm.Show();
        }

        readonly Dictionary<int, string> DefenseEquality = new()
        {
            { 0, "None" },
            { 1, "1 Station" },
            { 2, "2 Stations" },
            { 3, "Chasing" },
            { 4, "Counter" },
            { 9, "Scouter Error" }
        };
        readonly Dictionary<int, string> AvoidanceEquality = new()
        {
            { 0, "None" },
            { 1, "1 Station" },
            { 2, "2 Stations" },
            { 3, "Chasing" },
            { 4, "Counter" },
            { 9, "Scouter Error" }
        };
        private void UpdateScreen(object sender, EventArgs e)
        {
            int redScore = 0;
            int blueScore = 0;
            //Loops through all 6 boxes to update the text to be based on the RobotState
            for (int i = 0; i < 6; i++)
            {
                RobotState robot = BackgroundCode.Robots[i];
                int robotBox = robot.ScouterBox;
                switch (BackgroundCode.Robots[i].Current_Mode)
                {
                    case RobotState.ROBOT_MODE.Auto:
                        InAutoMode(i, robotBox);
                        break;
                    case RobotState.ROBOT_MODE.Teleop:
                        InTeleopMode(i, robotBox);
                        break;
                    case RobotState.ROBOT_MODE.Endgame:
                        InEndgameMode(i, robotBox);
                        break;
                }

                //if (i < 3)
                //{
                //    redScore += BackgroundCode.Robots[i].PointsScored;
                //}
                //else
                //{
                //    blueScore += BackgroundCode.Robots[i].PointsScored;
                //}

                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}ScoutName", true)[0]).Text = robot.GetScouterName().ToString();
                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}ScoutName", true)[0]).Visible = true;
                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}MatchEvent", true)[0]).Text = robot.Match_event.ToString();
                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}MatchEvent", true)[0]).Visible = true;
                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}ModeValue", true)[0]).Text = robot.Current_Mode.ToString() + " Mode";
                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}ModeValue", true)[0]).Visible = true;

                ((Label)this.Controls.Find($"lbl{robot.ScouterBox}TeamName", true)[0]).Visible = true;
            }

            ((Label)this.Controls.Find($"lblRedScore", true)[0]).Text = redScore.ToString();
            ((Label)this.Controls.Find($"lblBlueScore", true)[0]).Text = blueScore.ToString();
        }
        private void InAutoMode(int Box_Number, int ScouterBox)
        {
            
        }
        private void InTeleopMode(int Box_Number, int ScouterBox)
        {
            
        }
        private void InEndgameMode(int Box_Number, int ScouterBox)
        {
            
        }
    }
}