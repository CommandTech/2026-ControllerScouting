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

            this.rdioSQLLite.Checked = false;
            this.rdioLocalSQL.Checked = false;
            this.rdioServerSQL.Checked = false;

            switch (BackgroundCode.dataExport)
            {
                case BackgroundCode.EXPORT_TYPE.NoDownloadSQL:
                    this.rdioSQLLite.Checked = true;
                    break;
                case BackgroundCode.EXPORT_TYPE.SQLlocal:
                    this.rdioLocalSQL.Checked = true;
                    break;
                case BackgroundCode.EXPORT_TYPE.SQLonline:
                    this.rdioServerSQL.Checked = true;
                    break;
            }

            this.txtSQLLiteLocation.Visible = this.rdioSQLLite.Checked;
            this.txtSQLLiteLocation.Text = Settings.Default.SQLLiteLocation;
            oldLocation = Settings.Default.SQLLiteLocation;

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
                            BackgroundCode.EXPORT_TYPE.NoDownloadSQL;

            BackgroundCode.iniFile.Write("ProgramSettings", "exportType", BackgroundCode.dataExport.ToString());

            if (!Settings.Default.sqlLiteExists && rdioSQLLite.Checked)
            {
                DatabaseCode.CreateSQLLite(Settings.Default.SQLLiteLocation);
            }
            else if (Settings.Default.sqlLiteExists && rdioSQLLite.Checked)
            {
                DatabaseCode.MoveSQLLite(oldLocation, Settings.Default.SQLLiteLocation);
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

        private void RdioSQLLite_CheckedChanged(object sender, EventArgs e)
        {
            this.txtSQLLiteLocation.Visible = this.rdioSQLLite.Checked;
        }
        private void RdioLocalSQL_CheckedChanged(object sender, EventArgs e)
        {
            this.txtLocalSQLLocation.Visible = this.rdioLocalSQL.Checked;
        }
        private void RdioServerSQL_CheckedChanged(object sender, EventArgs e)
        {
            this.txtServerSQLLocation.Visible = this.rdioServerSQL.Checked;
        }

        private void TxtSQLLiteLocation_TextChanged(object sender, EventArgs e)
        {

            Settings.Default.SQLLiteLocation = this.txtSQLLiteLocation.Text;
            BackgroundCode.iniFile.Write("ProgramSettings", "sqlLiteLocation", Settings.Default.SQLLiteLocation.ToString());
        }

        private void BtnBrowseSQLLite_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                this.txtSQLLiteLocation.Text = fbd.SelectedPath;
            }
        }
    }
}
