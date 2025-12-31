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
            if (checkEndAuto.Checked || checkActivities.Checked || checkEndMatch.Checked || checkMatchEvent.Checked || checkDefense.Checked)
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
                if (checkDefense.Checked)
                {
                    cbD = first + "'Defense'";
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
                var IDNumber = int.Parse(txtID.Text);
                var result = db.UpdatePreviewSet.FirstOrDefault(b => b.Id == IDNumber);

                var resultPrev = db.ActivitySet.FirstOrDefault(b => b.Id == IDNumber);
                if (IDNumber > 1)
                {
                    resultPrev = db.ActivitySet.FirstOrDefault(b => b.Id == IDNumber - 1);
                }
                if (result != null)
                {
                    
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
