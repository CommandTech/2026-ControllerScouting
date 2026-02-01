using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ControllerScouting.Database;

namespace ControllerScouting.Screens
{
    public partial class UpdateDatabase : Form
    {
        public UpdateDatabase(List<string> teamlist, List<int> MatchNumbers)
        {
            InitializeComponent();
            this.comboTeamNumber.DataSource = teamlist;
            this.comboMatchNumber.DataSource = MatchNumbers;
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
                    this.updatePreviewsTableAdapter.Fill(this.scoutingDBDataSet.UpdatePreviews);
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
                    //if (IDNumber > 1 && result.Team == resultPrev.Team)
                    //{
                    //    if (result.AcqCoralS > resultPrev.AcqCoralS)
                    //    {
                    //        comboCoralAcqLoc.Text = "Station";
                    //    }
                    //    else if (result.AcqCoralF > resultPrev.AcqCoralF)
                    //    {
                    //        comboCoralAcqLoc.Text = "Floor";
                    //    }
                    //    if (result.AcqAlgaeR > resultPrev.AcqAlgaeR)
                    //    {
                    //        comboAlgaeAcqLoc.Text = "Reef";
                    //    }
                    //    else if (result.AcqAlgaeF > resultPrev.AcqAlgaeF)
                    //    {
                    //        comboAlgaeAcqLoc.Text = "Floor";
                    //    }
                    //}
                    //else
                    //{
                    //    if (result.AcqCoralS == 1)
                    //    {
                    //        comboCoralAcqLoc.Text = "Station";
                    //    }
                    //    else if (result.AcqCoralF == 1)
                    //    {
                    //        comboCoralAcqLoc.Text = "Floor";
                    //    }
                    //    if (result.AcqAlgaeR == 1)
                    //    {
                    //        comboAlgaeAcqLoc.Text = "Reef";
                    //    }
                    //    else if (result.AcqAlgaeF == 1)
                    //    {
                    //        comboAlgaeAcqLoc.Text = "Floor";
                    //    }
                    //}

                    TeleopBumpValue.Text = result.BumpTraversal.ToString();
                    TeleopFeedingTimerValue.Text = result.FeedingTime.ToString();
                    TeleopDefenseTimerValue.Text = result.DefenseTime.ToString();
                    TeleopShootingTimerValue.Text = result.FuelShootingTime.ToString();
                    TeleopIntakeTimerValue.Text = result.FuelIntakingTime.ToString();
                    EndGameClimbTimerValue.Text = result.ClimbTime.ToString();
                    AvoidanceStrategyValue.Text = result.Avoidance.ToString();
                    DefenseStrategyValue.Text = result.Defense.ToString();
                    ClimbAttemptValue.Text = result.AttemptClimb.ToString();
                    ClimbLevelValue.Text = result.EndState.ToString();
                    AutoClimbValue.Text = result.AutoClimb.ToString();



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

        private void BtnUpdateDatabase_Click(object sender, EventArgs e)
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
                    List<string> valuesChanged = [];
                    string query = "UPDATE Activities SET BumpTraversal = '" + TeleopBumpValue.Text + "' WHERE Id = '" + result.Id + "';";
                    seasonframework.Database.ExecuteSqlCommand(query);

                    query = "UPDATE Activities SET FeedingTime = '" + TeleopFeedingTimerValue.Text + "' WHERE Id = '" + result.Id + "';";
                    seasonframework.Database.ExecuteSqlCommand(query);

                    query = "UPDATE Activities SET DefenseTime = '" + TeleopDefenseTimerValue.Text + "' WHERE Id = '" + result.Id + "';";
                    seasonframework.Database.ExecuteSqlCommand(query);

                    query = "UPDATE Activities SET FuelShootingTime = '" + TeleopShootingTimerValue.Text + "' WHERE Id = '" + result.Id + "';";
                    seasonframework.Database.ExecuteSqlCommand(query);

                    query = "UPDATE Activities SET FuelIntakingTime = '" + TeleopIntakeTimerValue.Text + "' WHERE Id = '" + result.Id + "';";
                    seasonframework.Database.ExecuteSqlCommand(query);

                    query = "UPDATE Activities SET  ClimbTime = '" + EndGameClimbTimerValue.Text + "' WHERE Id = '" + result.Id + "';";
                    seasonframework.Database.ExecuteSqlCommand(query);

                    query = "UPDATE Activities SET Defense = '" + DefenseStrategyValue.Text + "' WHERE Id = '" + result.Id + "';";
                    seasonframework.Database.ExecuteSqlCommand(query);

                    query = "UPDATE Activities SET AttemptClimb = '" + ClimbAttemptValue.Text + "' WHERE Id = '" + result.Id + "';";
                    seasonframework.Database.ExecuteSqlCommand(query);

                    query = "UPDATE Activities SET EndState = '" + ClimbLevelValue.Text + "' WHERE Id = '" + result.Id + "';";
                    seasonframework.Database.ExecuteSqlCommand(query);

                    query = "UPDATE Activities SET AutoClimb = '" + AutoClimbValue.Text + "' WHERE Id = '" + result.Id + "';";
                    seasonframework.Database.ExecuteSqlCommand(query);

                    string updateRestQuery = $"SELECT * FROM [scoutingdb].[dbo].[Activities] A WHERE (A.Team = '{result.Team}' AND A.Match = {result.Match} AND A.Id > {result.Id}) " +
                        $"UPDATE Activities Set BumpTraversal = BumpTraversal + {BumpChangeAmount};";
                    seasonframework.Database.ExecuteSqlCommand(updateRestQuery);
                }

                MessageBox.Show("Database Updated");
            }
            else
            {
                MessageBox.Show("Please enter a number for the ID");
            }
        }

    
    }
}
