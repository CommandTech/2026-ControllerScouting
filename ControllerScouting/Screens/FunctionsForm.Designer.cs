namespace ControllerScouting.Screens
{
    partial class FunctionsForm
    {
        #region
        private void InitializeComponent()
        {
            FunctionFormText = new Label();
            FuncOK = new Button();
            btnPriority = new Button();
            btnSwapScouters = new Button();
            cbxPractice = new CheckBox();
            btnRefresh = new Button();
            btnUpdateDatabase = new Button();
            comboPracticeTeams = new ComboBox();
            btnManualMatch = new Button();
            rdioSQLLite = new RadioButton();
            rdioLocalSQL = new RadioButton();
            exportLabel = new Label();
            rdioServerSQL = new RadioButton();
            txtSQLLiteLocation = new TextBox();
            txtLocalSQLLocation = new TextBox();
            txtServerSQLLocation = new TextBox();
            btnBrowseSQLLIte = new Button();
            SuspendLayout();
            // 
            // FunctionFormText
            // 
            FunctionFormText.Anchor = AnchorStyles.None;
            FunctionFormText.BackColor = Color.Transparent;
            FunctionFormText.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FunctionFormText.ForeColor = Color.FloralWhite;
            FunctionFormText.Location = new Point(14, 14);
            FunctionFormText.Name = "FunctionFormText";
            FunctionFormText.Size = new Size(263, 74);
            FunctionFormText.TabIndex = 353;
            FunctionFormText.Text = "Functions";
            // 
            // FuncOK
            // 
            FuncOK.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FuncOK.ForeColor = Color.Black;
            FuncOK.Location = new Point(329, 354);
            FuncOK.Margin = new Padding(4, 5, 4, 5);
            FuncOK.Name = "FuncOK";
            FuncOK.Size = new Size(66, 35);
            FuncOK.TabIndex = 352;
            FuncOK.Text = "OK";
            FuncOK.UseVisualStyleBackColor = true;
            FuncOK.Click += FuncOK_Click;
            // 
            // btnPriority
            // 
            btnPriority.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPriority.ForeColor = Color.Black;
            btnPriority.Location = new Point(24, 99);
            btnPriority.Margin = new Padding(4, 5, 4, 5);
            btnPriority.Name = "btnPriority";
            btnPriority.Size = new Size(132, 35);
            btnPriority.TabIndex = 354;
            btnPriority.Text = "Priority v2.1";
            btnPriority.UseVisualStyleBackColor = true;
            btnPriority.Click += BtnPriority_Click;
            // 
            // btnSwapScouters
            // 
            btnSwapScouters.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSwapScouters.ForeColor = Color.Black;
            btnSwapScouters.Location = new Point(24, 144);
            btnSwapScouters.Margin = new Padding(4, 5, 4, 5);
            btnSwapScouters.Name = "btnSwapScouters";
            btnSwapScouters.Size = new Size(179, 35);
            btnSwapScouters.TabIndex = 355;
            btnSwapScouters.Text = "Swap Scouters";
            btnSwapScouters.UseVisualStyleBackColor = true;
            btnSwapScouters.Click += BtnSwapScouters_Click;
            // 
            // cbxPractice
            // 
            cbxPractice.AutoSize = true;
            cbxPractice.BackColor = Color.Black;
            cbxPractice.ForeColor = Color.Yellow;
            cbxPractice.Location = new Point(279, 106);
            cbxPractice.Margin = new Padding(2);
            cbxPractice.Name = "cbxPractice";
            cbxPractice.Size = new Size(102, 19);
            cbxPractice.TabIndex = 356;
            cbxPractice.Text = "Practice Mode";
            cbxPractice.UseVisualStyleBackColor = false;
            cbxPractice.CheckedChanged += CbxPractice_CheckedChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(24, 189);
            btnRefresh.Margin = new Padding(4, 5, 4, 5);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(226, 35);
            btnRefresh.TabIndex = 357;
            btnRefresh.Text = "Refresh Controllers";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnUpdateDatabase
            // 
            btnUpdateDatabase.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateDatabase.ForeColor = Color.Black;
            btnUpdateDatabase.Location = new Point(24, 234);
            btnUpdateDatabase.Margin = new Padding(4, 5, 4, 5);
            btnUpdateDatabase.Name = "btnUpdateDatabase";
            btnUpdateDatabase.Size = new Size(202, 35);
            btnUpdateDatabase.TabIndex = 358;
            btnUpdateDatabase.Text = "Update Database";
            btnUpdateDatabase.UseVisualStyleBackColor = true;
            btnUpdateDatabase.Click += BtnUpdateDatabase_Click;
            // 
            // comboPracticeTeams
            // 
            comboPracticeTeams.BackColor = Color.FromArgb(0, 0, 64);
            comboPracticeTeams.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPracticeTeams.ForeColor = Color.Yellow;
            comboPracticeTeams.FormattingEnabled = true;
            comboPracticeTeams.Location = new Point(279, 133);
            comboPracticeTeams.Margin = new Padding(4, 5, 4, 5);
            comboPracticeTeams.Name = "comboPracticeTeams";
            comboPracticeTeams.Size = new Size(116, 23);
            comboPracticeTeams.TabIndex = 361;
            comboPracticeTeams.SelectedIndexChanged += ComboPracticeTeams_SelectedIndexChanged;
            // 
            // btnManualMatch
            // 
            btnManualMatch.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManualMatch.ForeColor = Color.Black;
            btnManualMatch.Location = new Point(24, 279);
            btnManualMatch.Margin = new Padding(4, 5, 4, 5);
            btnManualMatch.Name = "btnManualMatch";
            btnManualMatch.Size = new Size(179, 35);
            btnManualMatch.TabIndex = 362;
            btnManualMatch.Text = "Manual Match List";
            btnManualMatch.UseVisualStyleBackColor = true;
            btnManualMatch.Click += BtnManualMatch_Click;
            // 
            // rdioSQLLite
            // 
            rdioSQLLite.AutoSize = true;
            rdioSQLLite.ForeColor = Color.White;
            rdioSQLLite.Location = new Point(279, 204);
            rdioSQLLite.Name = "rdioSQLLite";
            rdioSQLLite.Size = new Size(68, 19);
            rdioSQLLite.TabIndex = 363;
            rdioSQLLite.TabStop = true;
            rdioSQLLite.Text = "SQL Lite";
            rdioSQLLite.UseVisualStyleBackColor = true;
            rdioSQLLite.CheckedChanged += RdioSQLLite_CheckedChanged;
            // 
            // rdioLocalSQL
            // 
            rdioLocalSQL.AutoSize = true;
            rdioLocalSQL.ForeColor = Color.White;
            rdioLocalSQL.Location = new Point(279, 226);
            rdioLocalSQL.Name = "rdioLocalSQL";
            rdioLocalSQL.Size = new Size(77, 19);
            rdioLocalSQL.TabIndex = 364;
            rdioLocalSQL.TabStop = true;
            rdioLocalSQL.Text = "Local SQL";
            rdioLocalSQL.UseVisualStyleBackColor = true;
            rdioLocalSQL.CheckedChanged += RdioLocalSQL_CheckedChanged;
            // 
            // exportLabel
            // 
            exportLabel.Anchor = AnchorStyles.None;
            exportLabel.BackColor = Color.Transparent;
            exportLabel.Font = new Font("Comic Sans MS", 10F, FontStyle.Bold);
            exportLabel.ForeColor = Color.FloralWhite;
            exportLabel.Location = new Point(276, 166);
            exportLabel.Name = "exportLabel";
            exportLabel.Size = new Size(78, 29);
            exportLabel.TabIndex = 365;
            exportLabel.Text = "Export:";
            // 
            // rdioServerSQL
            // 
            rdioServerSQL.AutoSize = true;
            rdioServerSQL.ForeColor = Color.White;
            rdioServerSQL.Location = new Point(279, 248);
            rdioServerSQL.Name = "rdioServerSQL";
            rdioServerSQL.Size = new Size(81, 19);
            rdioServerSQL.TabIndex = 366;
            rdioServerSQL.TabStop = true;
            rdioServerSQL.Text = "Server SQL";
            rdioServerSQL.UseVisualStyleBackColor = true;
            rdioServerSQL.CheckedChanged += RdioServerSQL_CheckedChanged;
            // 
            // txtSQLLiteLocation
            // 
            txtSQLLiteLocation.Location = new Point(375, 204);
            txtSQLLiteLocation.Name = "txtSQLLiteLocation";
            txtSQLLiteLocation.Size = new Size(100, 23);
            txtSQLLiteLocation.TabIndex = 367;
            txtSQLLiteLocation.TextChanged += TxtSQLLiteLocation_TextChanged;
            // 
            // txtLocalSQLLocation
            // 
            txtLocalSQLLocation.Location = new Point(375, 226);
            txtLocalSQLLocation.Name = "txtLocalSQLLocation";
            txtLocalSQLLocation.Size = new Size(138, 23);
            txtLocalSQLLocation.TabIndex = 368;
            // 
            // txtServerSQLLocation
            // 
            txtServerSQLLocation.Location = new Point(375, 248);
            txtServerSQLLocation.Name = "txtServerSQLLocation";
            txtServerSQLLocation.Size = new Size(138, 23);
            txtServerSQLLocation.TabIndex = 369;
            // 
            // btnBrowseSQLLIte
            // 
            btnBrowseSQLLIte.Location = new Point(481, 203);
            btnBrowseSQLLIte.Name = "btnBrowseSQLLIte";
            btnBrowseSQLLIte.Size = new Size(32, 23);
            btnBrowseSQLLIte.TabIndex = 370;
            btnBrowseSQLLIte.Text = "...";
            btnBrowseSQLLIte.UseVisualStyleBackColor = true;
            btnBrowseSQLLIte.Click += BtnBrowseSQLLite_Click;
            // 
            // FunctionsForm
            // 
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(543, 408);
            Controls.Add(btnBrowseSQLLIte);
            Controls.Add(txtServerSQLLocation);
            Controls.Add(txtLocalSQLLocation);
            Controls.Add(txtSQLLiteLocation);
            Controls.Add(rdioServerSQL);
            Controls.Add(exportLabel);
            Controls.Add(rdioLocalSQL);
            Controls.Add(rdioSQLLite);
            Controls.Add(btnManualMatch);
            Controls.Add(comboPracticeTeams);
            Controls.Add(btnUpdateDatabase);
            Controls.Add(btnRefresh);
            Controls.Add(cbxPractice);
            Controls.Add(btnSwapScouters);
            Controls.Add(btnPriority);
            Controls.Add(FunctionFormText);
            Controls.Add(FuncOK);
            Name = "FunctionsForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FunctionFormText;
        private System.Windows.Forms.Button FuncOK;
        private System.Windows.Forms.Button btnPriority;
        private System.Windows.Forms.Button btnSwapScouters;
        private System.Windows.Forms.CheckBox cbxPractice;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdateDatabase;
        private System.Windows.Forms.ComboBox comboPracticeTeams;
        private System.Windows.Forms.Button btnManualMatch;
        private System.Windows.Forms.RadioButton rdioSQLLite;
        private System.Windows.Forms.RadioButton rdioLocalSQL;
        private System.Windows.Forms.Label exportLabel;
        private System.Windows.Forms.RadioButton rdioServerSQL;
        private System.Windows.Forms.TextBox txtSQLLiteLocation;
        private System.Windows.Forms.TextBox txtLocalSQLLocation;
        private System.Windows.Forms.TextBox txtServerSQLLocation;
        private System.Windows.Forms.Button btnBrowseSQLLIte;
    }
}
