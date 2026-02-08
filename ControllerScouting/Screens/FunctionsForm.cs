using ControllerScouting.Database;
using ControllerScouting.Properties;
using ControllerScouting.Utilities;
using System;
using System.Windows.Forms;

namespace ControllerScouting.Screens
{
    internal partial class FunctionsForm : Form
    {
        private readonly string oldLocation;
        public FunctionsForm()
        {
            InitializeComponent();
            cbxPractice.Checked = BackgroundCode.practiceMode;

            comboPracticeTeams.Visible = BackgroundCode.practiceMode;

            try
            {
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Redteam1);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Redteam2);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Redteam3);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Blueteam1);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Blueteam2);
                comboPracticeTeams.Items.Add(BackgroundCode.InMemoryMatchList[BackgroundCode.currentMatch - 1].Blueteam3);

                comboPracticeTeams.SelectedIndex = BackgroundCode.practiceTeam;
            }
            catch
            {

            }

            if (Settings.Default.sqlExists)
            {
                this.rdioLocalSQL.Visible = true;
                this.rdioServerSQL.Visible = true;
            }
            else
            {
                this.rdioLocalSQL.Visible = false;
                this.rdioServerSQL.Visible = false;
            }

            this.rdioCSV.Checked = false;
            this.rdioLocalSQL.Checked = false;
            this.rdioServerSQL.Checked = false;

            switch (BackgroundCode.dataExport)
            {
                case BackgroundCode.EXPORT_TYPE.CSV:
                    this.rdioCSV.Checked = true;
                    break;
                case BackgroundCode.EXPORT_TYPE.SQLlocal:
                    this.rdioLocalSQL.Checked = true;
                    break;
                case BackgroundCode.EXPORT_TYPE.SQLonline:
                    this.rdioServerSQL.Checked = true;
                    break;
            }

            this.txtCSVLocation.Visible = this.rdioCSV.Checked;
            this.txtCSVLocation.Text = Settings.Default.CSVLocation;
            oldLocation = Settings.Default.CSVLocation;

            this.txtLocalSQLLocation.Visible = this.rdioLocalSQL.Checked;
            this.txtLocalSQLLocation.Text = Settings.Default._scoutingdbConnectionString;

            this.txtServerSQLLocation.Visible = this.rdioServerSQL.Checked;
            this.txtServerSQLLocation.Text = Settings.Default._scoutingdbServerConnectionString;
        }
        private void ComboPracticeTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            BackgroundCode.practiceTeam = comboPracticeTeams.SelectedIndex;
        }

        private void FuncOK_Click(object sender, EventArgs e)
        {
            BackgroundCode.dataExport = this.rdioLocalSQL.Checked ? BackgroundCode.EXPORT_TYPE.SQLlocal :
                            this.rdioServerSQL.Checked ? BackgroundCode.EXPORT_TYPE.SQLonline :
                            BackgroundCode.EXPORT_TYPE.CSV;

            BackgroundCode.iniFile.Write("ProgramSettings", "exportType", BackgroundCode.dataExport.ToString());

            if (!Settings.Default.csvExists && rdioCSV.Checked)
            {
                DatabaseCode.CreateCSV(Settings.Default.CSVLocation);
            }
            else if (Settings.Default.csvExists && rdioCSV.Checked)
            {
                DatabaseCode.MoveCSV(oldLocation, Settings.Default.CSVLocation);
            }
            this.Hide();
        }

        private void BtnPriority_Click(object sender, EventArgs e)
        {
            PriorityForm frm = new();
            this.Hide();
            frm.Show();
        }

        private void BtnSwapScouters_Click(object sender, EventArgs e)
        {
            SwapScouters frm = new();
            this.Hide();
            frm.Show();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            BaseScreen.UpdateJoysticks();
            this.Hide();
        }

        private void BtnUpdateDatabase_Click(object sender, EventArgs e)
        {
            UpdateDatabase frm = new(BackgroundCode.teamlist, BackgroundCode.MatchNumbers);
            this.Hide();
            frm.Show();
        }

        private void CbxPractice_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundCode.practiceMode = cbxPractice.Checked;
            comboPracticeTeams.Visible = BackgroundCode.practiceMode;
        }

        private void BtnManualMatch_Click(object sender, EventArgs e)
        {
            ManualMatchList frm = new();
            this.Hide();
            frm.Show();
        }

        private void RdioCSV_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCSVLocation.Visible = this.rdioCSV.Checked;
        }
        private void RdioLocalSQL_CheckedChanged(object sender, EventArgs e)
        {
            this.txtLocalSQLLocation.Visible = this.rdioLocalSQL.Checked;
        }
        private void RdioServerSQL_CheckedChanged(object sender, EventArgs e)
        {
            this.txtServerSQLLocation.Visible = this.rdioServerSQL.Checked;
        }

        private void TxtCSVLocation_TextChanged(object sender, EventArgs e)
        {

            Settings.Default.CSVLocation = this.txtCSVLocation.Text;
            BackgroundCode.iniFile.Write("ProgramSettings", "csvLocation", Settings.Default.CSVLocation.ToString());
        }

        private void BtnBrowseCSV_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                this.txtCSVLocation.Text = fbd.SelectedPath;
            }
        }
    }
}
