using ControllerScouting.Database;
using ControllerScouting.Utilities;
using System.Data;
using System.Data.SqlClient;

namespace ControllerScouting.Screens
{
    public partial class UpdateDatabase : Form
    {
        private readonly BindingSource bindingSource;
        private SqlDataAdapter dataAdapter;

        public UpdateDatabase(List<string> teamlist, List<int> MatchNumbers)
        {
            InitializeComponent();
            this.comboTeamNumber.DataSource = teamlist;
            this.comboMatchNumber.DataSource = MatchNumbers;

            bindingSource = [];
            dataGridView1.DataSource = bindingSource;
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {
            if (checkEndAuto.Checked || checkActivities.Checked || checkEndMatch.Checked || checkMatchEvent.Checked)
            {
                using var db = new SeasonContext();
                string cbEA = "";
                string cbA = "";
                string cbD = "";
                string cbEM = "";
                string cbME = "";
                string first = "";

                if (checkEndAuto.Checked)
                {
                    cbEA = first + "'EndAuto'";
                    first = ",";
                }
                if (checkActivities.Checked)
                {
                    cbA = first + "'Activities'";
                    first = ",";
                }
                if (checkEndMatch.Checked)
                {
                    cbEM = first + "'EndMatch'";
                    first = ",";
                }
                if (checkMatchEvent.Checked)
                {
                    cbME = first + "'Match_Event'";
                }

                string teamNumber = this.comboTeamNumber.Text;
                string matchNumber = this.comboMatchNumber.Text;
                bool isNumeric = int.TryParse(comboMatchNumber.Text, out _);
                if (isNumeric)
                {
                    string Query = "Select * INTO UpdatePreviews FROM Activities WHERE Team = 'frc" + teamNumber + "' AND Match = '" + matchNumber + "' AND RecordType IN (" + cbEA + cbA + cbEM + cbME + cbD + ")";
                    SeasonContext seasonframework = new();
                    seasonframework.Database.ExecuteSqlCommand("IF OBJECT_ID ('UpdatePreviews') IS NOT NULL DROP TABLE UpdatePreviews");
                    seasonframework.Database.ExecuteSqlCommand(Query);

                    LoadDataIntoBindingSource();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Team Number");
                }
            }
            else
            {
                MessageBox.Show("Please select at least one record type");
            }
        }

        private void LoadDataIntoBindingSource()
        {
            string connectionString = Properties.Settings.Default._scoutingdbConnectionString;
            string query = "SELECT * FROM UpdatePreviews";

            using SqlConnection connection = new(connectionString);
            dataAdapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new();

            try
            {
                connection.Open();
                dataAdapter.Fill(dataTable);
                bindingSource.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void BtnFetchValues_Click(object sender, EventArgs e)
        {
            using var db = new SeasonContext();
            bool isNumeric = int.TryParse(txtID.Text, out _);
            if (isNumeric)
            {
                var IDNumber = int.Parse(txtID.Text);
                var result = db.UpdatePreviewSet.FirstOrDefault(b => b.Id == IDNumber);

                var resultPrev = db.ActivitySet.FirstOrDefault(b => b.Id == IDNumber);
                if (IDNumber > 1)
                {
                    resultPrev = db.ActivitySet.FirstOrDefault(b => b.Id == IDNumber - 1);
                }
                if (result != null)
                {
                    TeleopBumpValue.Text = result.BumpTraversal.ToString();
                    TeleopFeedingTimerValue.Text = result.FuelFed.ToString();
                    TeleopDefenseTimerValue.Text = result.DefenseTime.ToString();
                    TeleopShootingTimerValue.Text = result.FuelShot.ToString();
                    EndGameClimbTimerValue.Text = result.ClimbTime.ToString();
                    AvoidanceStrategyValue.Text = result.Avoidance.ToString();
                    DefenseStrategyValue.Text = result.Defense.ToString();
                    ClimbAttemptValue.Text = result.AttemptClimb.ToString();
                    ClimbLevelValue.Text = result.EndState.ToString();
                    AutoClimbValue.Text = result.AutoClimb.ToString();
                    MatchEventValue.Text = result.MatchEvent.ToString();
                }
                else
                {
                    MessageBox.Show("Please enter a valid ID");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number for the ID");
            }
        }

        private async void BtnUpdateDatabase_Click(object sender, EventArgs e)
        {
            using var db = new SeasonContext();
            SeasonContext seasonframework = new();
            bool isNumeric = int.TryParse(txtID.Text, out _);
            if (isNumeric)
            {
                int BumpChangeAmount = 0;

                var IDNumber = int.Parse(txtID.Text);
                var result = db.UpdatePreviewSet.FirstOrDefault(b => b.Id == IDNumber);

                var resultPrev = db.ActivitySet.FirstOrDefault(b => b.Id == IDNumber);
                if (IDNumber > 1)
                {
                    resultPrev = db.ActivitySet.FirstOrDefault(b => b.Id == IDNumber - 1);
                }
                if (result != null)
                {
                    if (int.TryParse(TeleopBumpValue.Text, out int newBumpValue))
                    {
                        BumpChangeAmount = newBumpValue - result.BumpTraversal;
                    }

                    string query = $"UPDATE Activities SET " +
                                    $"BumpTraversal = {TeleopBumpValue.Text}, " +
                                    $"FeedingTime = {TeleopFeedingTimerValue.Text}, " +
                                    $"DefenseTime = {TeleopDefenseTimerValue.Text}, " +
                                    $"FuelShootingTime = {TeleopShootingTimerValue.Text}, " +
                                    $"FuelIntakingTime = {TeleopIntakeTimerValue.Text}, " +
                                    $"ClimbTime = {EndGameClimbTimerValue.Text}, " +
                                    $"Defense = '{DefenseStrategyValue.Text}', " +
                                    $"AttemptClimb = '{ClimbAttemptValue.Text}', " +
                                    $"EndState = '{ClimbLevelValue.Text}', " +
                                    $"AutoClimb = '{AutoClimbValue.Text}', " +
                                    $"MatchEvent = '{MatchEventValue.Text}' " +
                                    $"WHERE Id = {result.Id};";

                    seasonframework.Database.ExecuteSqlCommand(query);

                    string updateRestQuery = $"SELECT * FROM [scoutingdb].[dbo].[Activities] A WHERE (A.Team = '{result.Team}' AND A.Match = {result.Match} AND A.Id > {result.Id}) " +
                        $"UPDATE Activities Set BumpTraversal = BumpTraversal + {BumpChangeAmount};";

                    seasonframework.Database.ExecuteSqlCommand(updateRestQuery);
                }

                MessageBox.Show("Database Updated");

                BackgroundCode.localSQLChanges = true;
            }
            else
            {
                MessageBox.Show("Please enter a number for the ID");
            }
        }

    
    }
}
