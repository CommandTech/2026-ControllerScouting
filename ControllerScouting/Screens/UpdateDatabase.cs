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

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        //    private void BtnCreateTable_Click(object sender, EventArgs e)
        //    {
        //        if (checkEndAuto.Checked || checkActivities.Checked || checkEndMatch.Checked || checkMatchEvent.Checked || checkDefense.Checked)
        //        {
        //            using var db = new SeasonContext();
        //            string cbEA = "";
        //            string cbA = "";
        //            string cbD = "";
        //            string cbEM = "";
        //            string cbME = "";
        //            string first = "";

        //            if (checkEndAuto.Checked)
        //            {
        //                cbEA = first + "'EndAuto'";
        //                first = ",";
        //            }
        //            if (checkActivities.Checked)
        //            {
        //                cbA = first + "'Activities'";
        //                first = ",";
        //            }
        //            if (checkEndMatch.Checked)
        //            {
        //                cbEM = first + "'EndMatch'";
        //                first = ",";
        //            }
        //            if (checkMatchEvent.Checked)
        //            {
        //                cbME = first + "'Match_Event'";
        //            }
        //            if (checkDefense.Checked)
        //            {
        //                cbD = first + "'Defense'";
        //            }

        //            string teamNumber = this.comboTeamNumber.Text;
        //            string matchNumber = this.comboMatchNumber.Text;
        //            bool isNumeric = int.TryParse(comboMatchNumber.Text, out _);
        //            if (isNumeric)
        //            {
        //                string Query = "Select * INTO UpdatePreviews FROM Activities WHERE Team = 'frc" + teamNumber + "' AND Match = '" + matchNumber + "' AND RecordType IN (" + cbEA + cbA + cbEM + cbME + cbD + ")";
        //                SeasonContext seasonframework = new();
        //                seasonframework.Database.ExecuteSqlCommand("IF OBJECT_ID ('UpdatePreviews') IS NOT NULL DROP TABLE UpdatePreviews");
        //                seasonframework.Database.ExecuteSqlCommand(Query);
        //                this.updatePreviewsTableAdapter.Fill(this.scoutingDBDataSet.UpdatePreviews);
        //            }
        //            else
        //            {
        //                MessageBox.Show("Please enter a valid Team Number");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please select at least one record type");
        //        }
        //    }

        //    private void BtnFetchValues_Click(object sender, EventArgs e)
        //    {
        //        using var db = new SeasonContext();
        //        bool isNumeric = int.TryParse(txtID.Text, out _);
        //        if (isNumeric)
        //        {
        //            var IDNumber = int.Parse(txtID.Text);
        //            var result = db.UpdatePreviewSet.FirstOrDefault(b => b.Id == IDNumber);

        //            var resultPrev = db.ActivitySet.FirstOrDefault(b => b.Id == IDNumber);
        //            if (IDNumber > 1)
        //            {
        //                resultPrev = db.ActivitySet.FirstOrDefault(b => b.Id == IDNumber - 1);
        //            }
        //            if (result != null)
        //            {
        //                if (IDNumber > 1 && result.Team == resultPrev.Team)
        //                {
        //                    if (result.AcqCoralS > resultPrev.AcqCoralS)
        //                    {
        //                        comboCoralAcqLoc.Text = "Station";
        //                    }
        //                    else if (result.AcqCoralF > resultPrev.AcqCoralF)
        //                    {
        //                        comboCoralAcqLoc.Text = "Floor";
        //                    }
        //                    if (result.AcqAlgaeR > resultPrev.AcqAlgaeR)
        //                    {
        //                        comboAlgaeAcqLoc.Text = "Reef";
        //                    }
        //                    else if (result.AcqAlgaeF > resultPrev.AcqAlgaeF)
        //                    {
        //                        comboAlgaeAcqLoc.Text = "Floor";
        //                    }
        //                }
        //                else
        //                {
        //                    if (result.AcqCoralS == 1)
        //                    {
        //                        comboCoralAcqLoc.Text = "Station";
        //                    }
        //                    else if (result.AcqCoralF == 1)
        //                    {
        //                        comboCoralAcqLoc.Text = "Floor";
        //                    }
        //                    if (result.AcqAlgaeR == 1)
        //                    {
        //                        comboAlgaeAcqLoc.Text = "Reef";
        //                    }
        //                    else if (result.AcqAlgaeF == 1)
        //                    {
        //                        comboAlgaeAcqLoc.Text = "Floor";
        //                    }
        //                }


        //                comboAlgaeAcqSide.Text = result.AcqAlgae_Near_Far.ToString();
        //                comboCoralAcqSide.Text = result.AcqCoral_Near_Far.ToString();

        //                comboCoralDelSide.Text = result.Del_Near_Far.ToString();
        //                comboAlgaeDelSide.Text = result.Del_Near_Far.ToString();

        //                txtDelCoralF.Text = result.DelCoralF.ToString();
        //                txtDelCoralL1.Text = result.DelCoralL1.ToString();
        //                txtDelCoralL2.Text = result.DelCoralL2.ToString();
        //                txtDelCoralL3.Text = result.DelCoralL3.ToString();
        //                txtDelCoralL4.Text = result.DelCoralL4.ToString();

        //                txtDelAlgaeF.Text = result.DelAlgaeF.ToString();
        //                txtDelAlgaeP.Text = result.DelAlgaeP.ToString();
        //                txtDelAlgaeN.Text = result.DelAlgaeN.ToString();

        //                comboStrategy.Text = result.Strategy.ToString();
        //                comboEndState.Text = result.EndState.ToString();
        //                comboClimbAttempt.Text = result.CageAttempt.ToString();
        //                txtClimbTime.Text = result.ClimbT.ToString();

        //                comboMode.Text = result.Mode.ToString();
        //                comboStart.Text = result.Starting_Loc.ToString();
        //                comboLeave.Text = result.Leave.ToString();
        //                comboMatchEvent.Text = result.Match_event.ToString();

        //                txtDefenseTime.Text = result.DZTime.ToString();
        //                txtDefense.Text = result.Defense.ToString();
        //                txtEffectiveness.Text = result.DefenseValue.ToString();
        //                txtAvoidance.Text = result.Avoidance.ToString();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Please enter a valid ID");
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please enter a number for the ID");
        //        }
        //    }

        //    private void BtnUpdateDatabase_Click(object sender, EventArgs e)
        //    {
        //        using var db = new SeasonContext();
        //        SeasonContext seasonframework = new();
        //        bool isNumeric = int.TryParse(txtID.Text, out _);
        //        if (isNumeric)
        //        {
        //            int L1ChangeAmount = 0;
        //            int L2ChangeAmount = 0;
        //            int L3ChangeAmount = 0;
        //            int L4ChangeAmount = 0;
        //            int CFChangeAmount = 0;

        //            int PChangeAmount = 0;
        //            int NChangeAmount = 0;
        //            int AFChangeAmount = 0;
        //            int DChangeAmount = 0;

        //            string AcqChange = "";

        //            var IDNumber = int.Parse(txtID.Text);
        //            var result = db.UpdatePreviewSet.FirstOrDefault(b => b.Id == IDNumber);

        //            var resultPrev = db.ActivitySet.FirstOrDefault(b => b.Id == IDNumber);
        //            if (IDNumber > 1)
        //            {
        //                resultPrev = db.ActivitySet.FirstOrDefault(b => b.Id == IDNumber - 1);
        //            }
        //            if (result != null)
        //            {
        //                List<string> valuesChanged = [];
        //                string query = "UPDATE Activities SET Defense = '" + txtDefense.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                query = "UPDATE Activities SET DefenseValue = '" + txtEffectiveness.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                query = "UPDATE Activities SET Avoidance = '" + txtAvoidance.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                query = "UPDATE Activities SET Match_event = '" + comboMatchEvent.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                query = "UPDATE Activities SET Strategy = '" + comboStrategy.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                query = "UPDATE Activities SET DZTime = '" + txtDefenseTime.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                if (comboAlgaeDelSide.Text != "-")
        //                {
        //                    query = "UPDATE Activities SET Del_Near_Far = '" + comboAlgaeDelSide.Text + "' WHERE Id = '" + result.Id + "';";
        //                    seasonframework.Database.ExecuteSqlCommand(query);
        //                }
        //                else
        //                {
        //                    query = "UPDATE Activities SET Del_Near_Far = '" + comboCoralDelSide.Text + "' WHERE Id = '" + result.Id + "';";
        //                    seasonframework.Database.ExecuteSqlCommand(query);
        //                }

        //                query = "UPDATE Activities SET AcqAlgae_Near_Far = '" + comboAlgaeAcqSide.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                query = "UPDATE Activities SET AcqCoral_Near_Far = '" + comboCoralAcqSide.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                query = "UPDATE Activities SET Starting_Loc = '" + comboStart.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                query = "UPDATE Activities SET Leave = '" + comboLeave.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                string prevCoralAcq = "";
        //                string prevAlgaeAcq = "";
        //                if (IDNumber > 1 && result.Team == resultPrev.Team)
        //                {
        //                    if (result.AcqCoralS > resultPrev.AcqCoralS)
        //                    {
        //                        prevCoralAcq = "Station";
        //                    }
        //                    else if (result.AcqCoralF > resultPrev.AcqCoralF)
        //                    {
        //                        prevCoralAcq = "Floor";
        //                    }
        //                    if (result.AcqAlgaeR > resultPrev.AcqAlgaeR)
        //                    {
        //                        prevAlgaeAcq = "Reef";
        //                    }
        //                    else if (result.AcqAlgaeF > resultPrev.AcqAlgaeF)
        //                    {
        //                        prevAlgaeAcq = "Floor";
        //                    }
        //                }
        //                else
        //                {
        //                    if (result.AcqCoralS == 1)
        //                    {
        //                        prevCoralAcq = "Station";
        //                    }
        //                    else if (result.AcqCoralF == 1)
        //                    {
        //                        prevCoralAcq = "Floor";
        //                    }
        //                    if (result.AcqAlgaeR == 1)
        //                    {
        //                        prevAlgaeAcq = "Reef";
        //                    }
        //                    else if (result.AcqAlgaeF == 1)
        //                    {
        //                        prevAlgaeAcq = "Floor";
        //                    }
        //                }

        //                if (prevCoralAcq == "Station" && comboCoralAcqLoc.Text == "Floor")
        //                {
        //                    if (result.AcqCoralS > 0)
        //                    {
        //                        result.AcqCoralS--;
        //                        query = "UPDATE Activities SET AcqCoralS = " + result.AcqCoralS + " WHERE Id = '" + result.Id + "';";
        //                        seasonframework.Database.ExecuteSqlCommand(query);
        //                    }

        //                    result.AcqCoralF++;
        //                    query = "UPDATE Activities SET AcqCoralF = " + result.AcqCoralF + " WHERE Id = '" + result.Id + "';";
        //                    seasonframework.Database.ExecuteSqlCommand(query);
        //                    AcqChange = "SF";
        //                }
        //                else if (prevCoralAcq == "Station" && comboCoralAcqLoc.Text == "-")
        //                {
        //                    if (result.AcqCoralS > 0)
        //                    {
        //                        result.AcqCoralS--;
        //                        query = "UPDATE Activities SET AcqCoralS = " + result.AcqCoralS + " WHERE Id = '" + result.Id + "';";
        //                        seasonframework.Database.ExecuteSqlCommand(query);
        //                    }
        //                    AcqChange = "SN";
        //                }
        //                else if (prevCoralAcq == "Floor" && comboCoralAcqLoc.Text == "Station")
        //                {
        //                    if (result.AcqCoralF > 0)
        //                    {
        //                        result.AcqCoralF--;
        //                        query = "UPDATE Activities SET AcqCoralF = " + result.AcqCoralF + " WHERE Id = '" + result.Id + "';";
        //                        seasonframework.Database.ExecuteSqlCommand(query);
        //                    }

        //                    result.AcqCoralS++;
        //                    query = "UPDATE Activities SET AcqCoralS = " + result.AcqCoralS + " WHERE Id = '" + result.Id + "';";
        //                    seasonframework.Database.ExecuteSqlCommand(query);
        //                    AcqChange = "FS";
        //                }
        //                else if (prevCoralAcq == "Floor" && comboCoralAcqLoc.Text == "-")
        //                {
        //                    if (result.AcqCoralF > 0)
        //                    {
        //                        result.AcqCoralF--;
        //                        query = "UPDATE Activities SET AcqCoralF = " + result.AcqCoralF + " WHERE Id = '" + result.Id + "';";
        //                        seasonframework.Database.ExecuteSqlCommand(query);
        //                    }
        //                    AcqChange = "CFN";
        //                }
        //                else if (prevCoralAcq == "-" && comboCoralAcqLoc.Text == "Floor")
        //                {
        //                    result.AcqCoralF++;
        //                    query = "UPDATE Activities SET AcqCoralF = " + result.AcqCoralF + " WHERE Id = '" + result.Id + "';";
        //                    seasonframework.Database.ExecuteSqlCommand(query);
        //                    AcqChange = "CNF";
        //                }
        //                else if (prevCoralAcq == "-" && comboCoralAcqLoc.Text == "Station")
        //                {
        //                    result.AcqCoralS++;
        //                    query = "UPDATE Activities SET AcqCoralS = " + result.AcqCoralS + " WHERE Id = '" + result.Id + "';";
        //                    seasonframework.Database.ExecuteSqlCommand(query);
        //                    AcqChange = "NS";
        //                }



        //                if (prevAlgaeAcq == "Reef" && comboAlgaeAcqLoc.Text == "Floor")
        //                {
        //                    if (result.AcqAlgaeR > 0)
        //                    {
        //                        result.AcqAlgaeR--;
        //                        query = "UPDATE Activities SET AcqAlgaeR = " + result.AcqAlgaeR + " WHERE Id = '" + result.Id + "';";
        //                        seasonframework.Database.ExecuteSqlCommand(query);
        //                    }

        //                    result.AcqAlgaeF++;
        //                    query = "UPDATE Activities SET AcqAlgaeF = " + result.AcqAlgaeF + " WHERE Id = '" + result.Id + "';";
        //                    seasonframework.Database.ExecuteSqlCommand(query);
        //                    AcqChange = "RF";
        //                }
        //                else if (prevAlgaeAcq == "Reef" && comboAlgaeAcqLoc.Text == "-")
        //                {
        //                    if (result.AcqAlgaeR > 0)
        //                    {
        //                        result.AcqAlgaeR--;
        //                        query = "UPDATE Activities SET AcqAlgaeR = " + result.AcqAlgaeR + " WHERE Id = '" + result.Id + "';";
        //                        seasonframework.Database.ExecuteSqlCommand(query);
        //                    }
        //                    AcqChange = "RN";
        //                }
        //                else if (prevAlgaeAcq == "Floor" && comboAlgaeAcqLoc.Text == "Reef")
        //                {
        //                    if (result.AcqAlgaeF > 0)
        //                    {
        //                        result.AcqAlgaeF--;
        //                        query = "UPDATE Activities SET AcqAlgaeF = " + result.AcqAlgaeF + " WHERE Id = '" + result.Id + "';";
        //                        seasonframework.Database.ExecuteSqlCommand(query);
        //                    }

        //                    result.AcqAlgaeR++;
        //                    query = "UPDATE Activities SET AcqAlgaeR = " + result.AcqAlgaeR + " WHERE Id = '" + result.Id + "';";
        //                    seasonframework.Database.ExecuteSqlCommand(query);
        //                    AcqChange = "FR";
        //                }
        //                else if (prevAlgaeAcq == "Floor" && comboAlgaeAcqLoc.Text == "-")
        //                {
        //                    if (result.AcqAlgaeF > 0)
        //                    {
        //                        result.AcqAlgaeF--;
        //                        query = "UPDATE Activities SET AcqAlgaeF = " + result.AcqAlgaeF + " WHERE Id = '" + result.Id + "';";
        //                        seasonframework.Database.ExecuteSqlCommand(query);
        //                    }
        //                    AcqChange = "AFN";
        //                }
        //                else if (prevAlgaeAcq == "-" && comboAlgaeAcqLoc.Text == "Floor")
        //                {
        //                    result.AcqAlgaeF++;
        //                    query = "UPDATE Activities SET AcqAlgaeF = " + result.AcqAlgaeF + " WHERE Id = '" + result.Id + "';";
        //                    seasonframework.Database.ExecuteSqlCommand(query);
        //                    AcqChange = "ANF";
        //                }
        //                else if (prevAlgaeAcq == "-" && comboAlgaeAcqLoc.Text == "Reef")
        //                {
        //                    result.AcqAlgaeR++;
        //                    query = "UPDATE Activities SET AcqAlgaeR = " + result.AcqAlgaeR + " WHERE Id = '" + result.Id + "';";
        //                    seasonframework.Database.ExecuteSqlCommand(query);
        //                    AcqChange = "NR";
        //                }


        //                if (int.TryParse(txtDelCoralL1.Text, out int delCoral))
        //                {
        //                    L1ChangeAmount = delCoral - result.DelCoralL1;
        //                }
        //                query = "UPDATE Activities SET DelCoralL1 = '" + txtDelCoralL1.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                if (int.TryParse(txtDelCoralL2.Text, out delCoral))
        //                {
        //                    L2ChangeAmount = delCoral - result.DelCoralL2;
        //                }
        //                query = "UPDATE Activities SET DelCoralL2 = '" + txtDelCoralL2.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                if (int.TryParse(txtDelCoralL3.Text, out delCoral))
        //                {
        //                    L3ChangeAmount = delCoral - result.DelCoralL3;
        //                }
        //                query = "UPDATE Activities SET DelCoralL3 = '" + txtDelCoralL3.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                if (int.TryParse(txtDelCoralL4.Text, out delCoral))
        //                {
        //                    L4ChangeAmount = delCoral - result.DelCoralL4;
        //                }
        //                query = "UPDATE Activities SET DelCoralL4 = '" + txtDelCoralL4.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                if (int.TryParse(txtDelCoralF.Text, out delCoral))
        //                {
        //                    CFChangeAmount = delCoral - result.DelCoralF;
        //                }
        //                query = "UPDATE Activities SET DelCoralF = '" + txtDelCoralF.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);


        //                if (int.TryParse(txtDelAlgaeP.Text, out int delAlgae))
        //                {
        //                    PChangeAmount = delAlgae - result.DelAlgaeP;
        //                }
        //                query = "UPDATE Activities SET DelAlgaeP = '" + txtDelAlgaeP.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                if (int.TryParse(txtDelAlgaeN.Text, out delAlgae))
        //                {
        //                    NChangeAmount = delAlgae - result.DelAlgaeN;
        //                }
        //                query = "UPDATE Activities SET DelAlgaeN = '" + txtDelAlgaeN.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                if (int.TryParse(txtDelAlgaeF.Text, out delAlgae))
        //                {
        //                    AFChangeAmount = delAlgae - result.DelAlgaeF;
        //                }
        //                query = "UPDATE Activities SET DelAlgaeF = '" + txtDelAlgaeF.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                if (int.TryParse(txtDisAlg.Text, out delAlgae))
        //                {
        //                    DChangeAmount = delAlgae - result.DisAlg;
        //                }
        //                query = "UPDATE Activities SET DisAlg = '" + txtDisAlg.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                query = "UPDATE Activities SET ClimbT = '" + txtClimbTime.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                query = "UPDATE Activities SET EndState = '" + comboEndState.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                query = "UPDATE Activities SET CageAttempt = '" + comboClimbAttempt.Text + "' WHERE Id = '" + result.Id + "';";
        //                seasonframework.Database.ExecuteSqlCommand(query);

        //                int acqCoralS = 0;
        //                int acqCoralF = 0;
        //                int acqAlgaeF = 0;
        //                int acqAlgaeR = 0;

        //                switch (AcqChange)
        //                {
        //                    case "SF":
        //                        acqCoralS--;
        //                        acqCoralF++;
        //                        break;
        //                    case "SN":
        //                        acqCoralS--;
        //                        break;
        //                    case "FS":
        //                        acqCoralF--;
        //                        acqCoralS++;
        //                        break;
        //                    case "CFN":
        //                        acqCoralF--;
        //                        break;
        //                    case "CNF":
        //                        acqCoralF++;
        //                        break;
        //                    case "NS":
        //                        acqCoralS++;
        //                        break;
        //                    case "RF":
        //                        acqAlgaeF++;
        //                        acqAlgaeR--;
        //                        break;
        //                    case "RN":
        //                        acqAlgaeR--;
        //                        break;
        //                    case "FR":
        //                        acqAlgaeF--;
        //                        acqAlgaeR++;
        //                        break;
        //                    case "AFN":
        //                        acqAlgaeF--;
        //                        break;
        //                    case "ANF":
        //                        acqAlgaeF++;
        //                        break;
        //                    case "NR":
        //                        acqAlgaeR++;
        //                        break;
        //                }

        //                string updateRestQuery = $"SELECT * FROM [scoutingdb].[dbo].[Activities] A WHERE (A.Team = '{result.Team}' AND A.Match = {result.Match} AND A.Id > {result.Id}) " +
        //                    $"UPDATE Activities Set DelCoralL4 = DelCoralL4 + {L4ChangeAmount}, " +
        //                    $"DelCoralL3 = DelCoralL3 + {L3ChangeAmount}, " +
        //                    $"DelCoralL2 = DelCoralL2 + {L2ChangeAmount}, " +
        //                    $"DelCoralL1 = DelCoralL1 + {L1ChangeAmount}, " +
        //                    $"DelCoralF = DelCoralF + {CFChangeAmount}," +
        //                    $"DelAlgaeP = DelAlgaeP + {PChangeAmount}," +
        //                    $"DelAlgaeN = DelAlgaeN + {NChangeAmount}," +
        //                    $"DelAlgaeF = DelAlgaeF + {AFChangeAmount}," +
        //                    $"DisAlg = DisAlg + {DChangeAmount}," +
        //                    $"AcqCoralS = AcqCoralS + {acqCoralS}," +
        //                    $"AcqCoralF = AcqCoralF + {acqCoralF}," +
        //                    $"AcqAlgaeR = AcqAlgaeR + {acqAlgaeR}," +
        //                    $"AcqAlgaeF = AcqAlgaeF + {acqAlgaeF};";
        //                seasonframework.Database.ExecuteSqlCommand(updateRestQuery);
        //            }

        //            MessageBox.Show("Database Updated");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please enter a number for the ID");
        //        }
        //    }
    }
}
