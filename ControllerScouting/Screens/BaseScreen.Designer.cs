using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControllerScouting.Screens
{
    partial class BaseScreen
    {
        #region
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            comboBoxSelectRegional = new ComboBox();
            cbxEndMatch = new CheckBox();
            btnInitialDBLoad = new Button();
            btnNextMatch = new Button();
            btnPreviousMatch = new Button();
            btnpopulateForEvent = new Button();
            btnExit = new Button();
            blueTeams = new TableLayoutPanel();
            redTeams = new TableLayoutPanel();
            team0 = new Panel();
            lbl0Position3 = new Label();
            lbl0Position2 = new Label();
            lbl0Position1 = new Label();
            lbl0Position4Value = new Label();
            lbl0Position0 = new Label();
            lbl0Position2Value = new Label();
            team0Divider = new Panel();
            team0ModeDivider = new Panel();
            team0TeamDivider = new Panel();
            lbl0MatchEvent = new Label();
            lbl0TeamName = new Label();
            lbl0ScoutName = new Label();
            lbl0ModeValue = new Label();
            labelMatch = new Label();
            lblMatch = new Label();
            timerJoysticks = new System.Windows.Forms.Timer(components);
            btnFunctions = new Button();
            lblBlueScore = new Label();
            lblRedScore = new Label();
            statusLight = new Panel();
            topPanel = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            lbl0Position4 = new Label();
            lbl0Position5 = new Label();
            lbl0Position6 = new Label();
            lbl0Position7 = new Label();
            lbl0Position8 = new Label();
            lbl0Position9 = new Label();
            lbl0Position3Value = new Label();
            redTeams.SuspendLayout();
            team0.SuspendLayout();
            topPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxSelectRegional
            // 
            comboBoxSelectRegional.Anchor = AnchorStyles.Left;
            comboBoxSelectRegional.DisplayMember = "event_code";
            comboBoxSelectRegional.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxSelectRegional.FormattingEnabled = true;
            comboBoxSelectRegional.Location = new Point(127, 5);
            comboBoxSelectRegional.Margin = new Padding(5);
            comboBoxSelectRegional.Name = "comboBoxSelectRegional";
            comboBoxSelectRegional.Size = new Size(290, 23);
            comboBoxSelectRegional.TabIndex = 290;
            comboBoxSelectRegional.Text = "Please press the Load Events Button...";
            comboBoxSelectRegional.ValueMember = "event_code";
            // 
            // cbxEndMatch
            // 
            cbxEndMatch.Anchor = AnchorStyles.Left;
            cbxEndMatch.AutoSize = true;
            cbxEndMatch.BackColor = Color.Black;
            cbxEndMatch.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbxEndMatch.ForeColor = Color.Yellow;
            cbxEndMatch.Location = new Point(782, 5);
            cbxEndMatch.Margin = new Padding(5);
            cbxEndMatch.Name = "cbxEndMatch";
            cbxEndMatch.Size = new Size(85, 19);
            cbxEndMatch.TabIndex = 296;
            cbxEndMatch.Text = "End Match";
            cbxEndMatch.UseVisualStyleBackColor = false;
            // 
            // btnInitialDBLoad
            // 
            btnInitialDBLoad.BackColor = Color.Black;
            btnInitialDBLoad.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInitialDBLoad.ForeColor = Color.Navy;
            btnInitialDBLoad.Location = new Point(5, 3);
            btnInitialDBLoad.Name = "btnInitialDBLoad";
            btnInitialDBLoad.Size = new Size(100, 22);
            btnInitialDBLoad.TabIndex = 287;
            btnInitialDBLoad.Text = "Load >";
            btnInitialDBLoad.UseVisualStyleBackColor = true;
            btnInitialDBLoad.Click += BtnInitialDBLoad_Click;
            // 
            // btnNextMatch
            // 
            btnNextMatch.BackColor = Color.Black;
            btnNextMatch.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNextMatch.ForeColor = Color.Navy;
            btnNextMatch.Location = new Point(741, 5);
            btnNextMatch.Name = "btnNextMatch";
            btnNextMatch.Size = new Size(36, 23);
            btnNextMatch.TabIndex = 289;
            btnNextMatch.Text = ">>";
            btnNextMatch.UseVisualStyleBackColor = true;
            btnNextMatch.Click += BtnNextMatch_Click;
            // 
            // btnPreviousMatch
            // 
            btnPreviousMatch.BackColor = Color.Black;
            btnPreviousMatch.Font = new Font("Microsoft Sans Serif", 9.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPreviousMatch.ForeColor = Color.Navy;
            btnPreviousMatch.Location = new Point(546, 4);
            btnPreviousMatch.Name = "btnPreviousMatch";
            btnPreviousMatch.Size = new Size(36, 23);
            btnPreviousMatch.TabIndex = 286;
            btnPreviousMatch.Text = "<<";
            btnPreviousMatch.UseVisualStyleBackColor = true;
            btnPreviousMatch.Click += BtnPrevMatch_Click;
            // 
            // btnpopulateForEvent
            // 
            btnpopulateForEvent.BackColor = Color.Black;
            btnpopulateForEvent.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpopulateForEvent.ForeColor = Color.Navy;
            btnpopulateForEvent.Location = new Point(442, 4);
            btnpopulateForEvent.Name = "btnpopulateForEvent";
            btnpopulateForEvent.Size = new Size(102, 23);
            btnpopulateForEvent.TabIndex = 285;
            btnpopulateForEvent.Text = "Get Matches";
            btnpopulateForEvent.UseVisualStyleBackColor = true;
            btnpopulateForEvent.Click += BtnpopulateForEvent_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Black;
            btnExit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Crimson;
            btnExit.Location = new Point(881, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(40, 23);
            btnExit.TabIndex = 284;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += BtnExit_Click;
            // 
            // blueTeams
            // 
            blueTeams.BackColor = Color.Blue;
            blueTeams.ColumnCount = 3;
            blueTeams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            blueTeams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            blueTeams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            blueTeams.Dock = DockStyle.Fill;
            blueTeams.Location = new Point(3, 464);
            blueTeams.Name = "blueTeams";
            blueTeams.RowCount = 1;
            blueTeams.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            blueTeams.Size = new Size(1454, 405);
            blueTeams.TabIndex = 0;
            // 
            // redTeams
            // 
            redTeams.BackColor = Color.Red;
            redTeams.ColumnCount = 3;
            redTeams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            redTeams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            redTeams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            redTeams.Controls.Add(team0, 0, 0);
            redTeams.Dock = DockStyle.Fill;
            redTeams.Location = new Point(3, 53);
            redTeams.Name = "redTeams";
            redTeams.RowCount = 1;
            redTeams.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            redTeams.Size = new Size(1454, 405);
            redTeams.TabIndex = 0;
            // 
            // team0
            // 
            team0.BackColor = Color.Black;
            team0.Controls.Add(lbl0Position3Value);
            team0.Controls.Add(lbl0Position9);
            team0.Controls.Add(lbl0Position8);
            team0.Controls.Add(lbl0Position7);
            team0.Controls.Add(lbl0Position6);
            team0.Controls.Add(lbl0Position5);
            team0.Controls.Add(lbl0Position4);
            team0.Controls.Add(lbl0Position3);
            team0.Controls.Add(lbl0Position2);
            team0.Controls.Add(lbl0Position1);
            team0.Controls.Add(lbl0Position4Value);
            team0.Controls.Add(lbl0Position0);
            team0.Controls.Add(lbl0Position2Value);
            team0.Controls.Add(team0Divider);
            team0.Controls.Add(team0ModeDivider);
            team0.Controls.Add(team0TeamDivider);
            team0.Controls.Add(lbl0MatchEvent);
            team0.Controls.Add(lbl0TeamName);
            team0.Controls.Add(lbl0ScoutName);
            team0.Controls.Add(lbl0ModeValue);
            team0.Dock = DockStyle.Fill;
            team0.Location = new Point(3, 3);
            team0.Name = "team0";
            team0.Size = new Size(478, 399);
            team0.TabIndex = 0;
            // 
            // lbl0Position3
            // 
            lbl0Position3.AutoSize = true;
            lbl0Position3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position3.ForeColor = Color.White;
            lbl0Position3.Location = new Point(3, 161);
            lbl0Position3.Name = "lbl0Position3";
            lbl0Position3.Size = new Size(87, 24);
            lbl0Position3.TabIndex = 399;
            lbl0Position3.Text = "Bump: 0";
            // 
            // lbl0Position2
            // 
            lbl0Position2.AutoSize = true;
            lbl0Position2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position2.ForeColor = Color.White;
            lbl0Position2.Location = new Point(257, 61);
            lbl0Position2.Name = "lbl0Position2";
            lbl0Position2.Size = new Size(221, 24);
            lbl0Position2.TabIndex = 397;
            lbl0Position2.Text = "Shooting Timer: 0:00.0";
            // 
            // lbl0Position1
            // 
            lbl0Position1.AutoSize = true;
            lbl0Position1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position1.ForeColor = Color.White;
            lbl0Position1.Location = new Point(0, 61);
            lbl0Position1.Name = "lbl0Position1";
            lbl0Position1.Size = new Size(193, 24);
            lbl0Position1.TabIndex = 396;
            lbl0Position1.Text = "Intake Timer: 0:00.0";
            // 
            // lbl0Position4Value
            // 
            lbl0Position4Value.AutoSize = true;
            lbl0Position4Value.BackColor = Color.Red;
            lbl0Position4Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl0Position4Value.ForeColor = Color.Red;
            lbl0Position4Value.ImageAlign = ContentAlignment.TopLeft;
            lbl0Position4Value.Location = new Point(73, 231);
            lbl0Position4Value.Name = "lbl0Position4Value";
            lbl0Position4Value.Size = new Size(16, 24);
            lbl0Position4Value.TabIndex = 395;
            lbl0Position4Value.Text = ".";
            lbl0Position4Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl0Position0
            // 
            lbl0Position0.AutoSize = true;
            lbl0Position0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position0.ForeColor = Color.White;
            lbl0Position0.Location = new Point(213, 10);
            lbl0Position0.Name = "lbl0Position0";
            lbl0Position0.Size = new Size(262, 20);
            lbl0Position0.TabIndex = 394;
            lbl0Position0.Text = "Starting Location: Outer Trench";
            // 
            // lbl0Position2Value
            // 
            lbl0Position2Value.AutoSize = true;
            lbl0Position2Value.BackColor = Color.Red;
            lbl0Position2Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl0Position2Value.ForeColor = Color.Red;
            lbl0Position2Value.ImageAlign = ContentAlignment.TopLeft;
            lbl0Position2Value.Location = new Point(72, 109);
            lbl0Position2Value.Name = "lbl0Position2Value";
            lbl0Position2Value.Size = new Size(0, 24);
            lbl0Position2Value.TabIndex = 392;
            lbl0Position2Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // team0Divider
            // 
            team0Divider.BackColor = Color.Red;
            team0Divider.Location = new Point(-5, 119);
            team0Divider.Name = "team0Divider";
            team0Divider.Size = new Size(534, 11);
            team0Divider.TabIndex = 389;
            // 
            // team0ModeDivider
            // 
            team0ModeDivider.BackColor = Color.Red;
            team0ModeDivider.Location = new Point(-5, 40);
            team0ModeDivider.Name = "team0ModeDivider";
            team0ModeDivider.Size = new Size(534, 11);
            team0ModeDivider.TabIndex = 390;
            // 
            // team0TeamDivider
            // 
            team0TeamDivider.BackColor = Color.Red;
            team0TeamDivider.Location = new Point(0, 314);
            team0TeamDivider.Name = "team0TeamDivider";
            team0TeamDivider.Size = new Size(529, 11);
            team0TeamDivider.TabIndex = 279;
            // 
            // lbl0MatchEvent
            // 
            lbl0MatchEvent.AutoSize = true;
            lbl0MatchEvent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0MatchEvent.ForeColor = Color.White;
            lbl0MatchEvent.Location = new Point(2, 328);
            lbl0MatchEvent.Name = "lbl0MatchEvent";
            lbl0MatchEvent.Size = new Size(125, 24);
            lbl0MatchEvent.TabIndex = 291;
            lbl0MatchEvent.Text = "Match Event";
            // 
            // lbl0TeamName
            // 
            lbl0TeamName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl0TeamName.ForeColor = Color.Goldenrod;
            lbl0TeamName.Location = new Point(323, 347);
            lbl0TeamName.Name = "lbl0TeamName";
            lbl0TeamName.Size = new Size(159, 37);
            lbl0TeamName.TabIndex = 294;
            lbl0TeamName.Text = "Team 0";
            lbl0TeamName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl0ScoutName
            // 
            lbl0ScoutName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0ScoutName.ForeColor = Color.Goldenrod;
            lbl0ScoutName.Location = new Point(3, 356);
            lbl0ScoutName.Name = "lbl0ScoutName";
            lbl0ScoutName.Size = new Size(158, 27);
            lbl0ScoutName.TabIndex = 293;
            lbl0ScoutName.Text = "Select Name";
            lbl0ScoutName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl0ModeValue
            // 
            lbl0ModeValue.AutoSize = true;
            lbl0ModeValue.BackColor = Color.Black;
            lbl0ModeValue.Font = new Font("Microsoft Sans Serif", 18F);
            lbl0ModeValue.ForeColor = Color.LimeGreen;
            lbl0ModeValue.Location = new Point(1, 3);
            lbl0ModeValue.Name = "lbl0ModeValue";
            lbl0ModeValue.Size = new Size(67, 29);
            lbl0ModeValue.TabIndex = 2;
            lbl0ModeValue.Text = "Auto:";
            // 
            // labelMatch
            // 
            labelMatch.AutoSize = true;
            labelMatch.BackColor = Color.Black;
            labelMatch.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMatch.ForeColor = Color.LimeGreen;
            labelMatch.Location = new Point(584, 3);
            labelMatch.Name = "labelMatch";
            labelMatch.Size = new Size(66, 24);
            labelMatch.TabIndex = 291;
            labelMatch.Text = "Match:";
            // 
            // lblMatch
            // 
            lblMatch.AutoSize = true;
            lblMatch.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMatch.ForeColor = Color.White;
            lblMatch.Location = new Point(648, 5);
            lblMatch.Name = "lblMatch";
            lblMatch.Size = new Size(21, 24);
            lblMatch.TabIndex = 292;
            lblMatch.Text = "0";
            // 
            // timerJoysticks
            // 
            timerJoysticks.Interval = 20;
            // 
            // btnFunctions
            // 
            btnFunctions.BackColor = Color.Transparent;
            btnFunctions.Font = new Font("Microsoft Sans Serif", 8F);
            btnFunctions.ForeColor = SystemColors.ControlText;
            btnFunctions.Location = new Point(1158, 5);
            btnFunctions.Name = "btnFunctions";
            btnFunctions.Size = new Size(88, 23);
            btnFunctions.TabIndex = 304;
            btnFunctions.Text = "Functions";
            btnFunctions.UseVisualStyleBackColor = false;
            btnFunctions.Click += BtnFunctions_Click;
            // 
            // lblBlueScore
            // 
            lblBlueScore.AutoSize = true;
            lblBlueScore.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBlueScore.ForeColor = Color.Blue;
            lblBlueScore.Location = new Point(1016, 5);
            lblBlueScore.Name = "lblBlueScore";
            lblBlueScore.Size = new Size(21, 24);
            lblBlueScore.TabIndex = 390;
            lblBlueScore.Text = "0";
            // 
            // lblRedScore
            // 
            lblRedScore.AutoSize = true;
            lblRedScore.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRedScore.ForeColor = Color.Red;
            lblRedScore.Location = new Point(972, 5);
            lblRedScore.Name = "lblRedScore";
            lblRedScore.Size = new Size(21, 24);
            lblRedScore.TabIndex = 389;
            lblRedScore.Text = "0";
            // 
            // statusLight
            // 
            statusLight.BackColor = Color.Red;
            statusLight.Location = new Point(1462, 9);
            statusLight.Name = "statusLight";
            statusLight.Size = new Size(16, 16);
            statusLight.TabIndex = 280;
            // 
            // topPanel
            // 
            topPanel.Controls.Add(lblBlueScore);
            topPanel.Controls.Add(lblRedScore);
            topPanel.Controls.Add(btnExit);
            topPanel.Controls.Add(btnFunctions);
            topPanel.Controls.Add(lblMatch);
            topPanel.Controls.Add(btnNextMatch);
            topPanel.Controls.Add(btnInitialDBLoad);
            topPanel.Controls.Add(comboBoxSelectRegional);
            topPanel.Controls.Add(btnPreviousMatch);
            topPanel.Controls.Add(btnpopulateForEvent);
            topPanel.Controls.Add(cbxEndMatch);
            topPanel.Controls.Add(statusLight);
            topPanel.Controls.Add(labelMatch);
            topPanel.Dock = DockStyle.Fill;
            topPanel.Location = new Point(3, 3);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1454, 44);
            topPanel.TabIndex = 391;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(topPanel, 0, 0);
            tableLayoutPanel.Controls.Add(redTeams, 0, 1);
            tableLayoutPanel.Controls.Add(blueTeams, 0, 2);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Size = new Size(1460, 872);
            tableLayoutPanel.TabIndex = 0;
            // 
            // lbl0Position4
            // 
            lbl0Position4.AutoSize = true;
            lbl0Position4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position4.ForeColor = Color.White;
            lbl0Position4.Location = new Point(2, 231);
            lbl0Position4.Name = "lbl0Position4";
            lbl0Position4.Size = new Size(69, 24);
            lbl0Position4.TabIndex = 399;
            lbl0Position4.Text = "Climb:";
            // 
            // lbl0Position5
            // 
            lbl0Position5.AutoSize = true;
            lbl0Position5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position5.ForeColor = Color.White;
            lbl0Position5.Location = new Point(112, 92);
            lbl0Position5.Name = "lbl0Position5";
            lbl0Position5.Size = new Size(216, 24);
            lbl0Position5.TabIndex = 400;
            lbl0Position5.Text = "Feeding Timer: 0:00.0";
            // 
            // lbl0Position6
            // 
            lbl0Position6.AutoSize = true;
            lbl0Position6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position6.ForeColor = Color.White;
            lbl0Position6.Location = new Point(3, 195);
            lbl0Position6.Name = "lbl0Position6";
            lbl0Position6.Size = new Size(188, 24);
            lbl0Position6.TabIndex = 401;
            lbl0Position6.Text = "Avoidance: VALUE";
            // 
            // lbl0Position7
            // 
            lbl0Position7.AutoSize = true;
            lbl0Position7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position7.ForeColor = Color.White;
            lbl0Position7.Location = new Point(3, 266);
            lbl0Position7.Name = "lbl0Position7";
            lbl0Position7.Size = new Size(153, 24);
            lbl0Position7.TabIndex = 402;
            lbl0Position7.Text = "Climb Level: L#";
            // 
            // lbl0Position8
            // 
            lbl0Position8.AutoSize = true;
            lbl0Position8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position8.ForeColor = Color.White;
            lbl0Position8.Location = new Point(298, 195);
            lbl0Position8.Name = "lbl0Position8";
            lbl0Position8.Size = new Size(164, 24);
            lbl0Position8.TabIndex = 404;
            lbl0Position8.Text = "Strategy: VALUE";
            // 
            // lbl0Position9
            // 
            lbl0Position9.AutoSize = true;
            lbl0Position9.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position9.ForeColor = Color.White;
            lbl0Position9.Location = new Point(218, 231);
            lbl0Position9.Name = "lbl0Position9";
            lbl0Position9.Size = new Size(244, 20);
            lbl0Position9.TabIndex = 405;
            lbl0Position9.Text = "Ladder Location: OUTPOST";
            // 
            // lbl0Position3Value
            // 
            lbl0Position3Value.AutoSize = true;
            lbl0Position3Value.BackColor = Color.Red;
            lbl0Position3Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl0Position3Value.ForeColor = Color.Red;
            lbl0Position3Value.ImageAlign = ContentAlignment.TopLeft;
            lbl0Position3Value.Location = new Point(72, 161);
            lbl0Position3Value.Name = "lbl0Position3Value";
            lbl0Position3Value.Size = new Size(16, 24);
            lbl0Position3Value.TabIndex = 406;
            lbl0Position3Value.Text = ".";
            lbl0Position3Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BaseScreen
            // 
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(1460, 872);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseScreen";
            WindowState = FormWindowState.Maximized;
            redTeams.ResumeLayout(false);
            team0.ResumeLayout(false);
            team0.PerformLayout();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);

        }
        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private CheckBox cbxEndMatch;
        private Button btnInitialDBLoad;
        private ComboBox comboBoxSelectRegional;
        private Button btnNextMatch;
        private Button btnPreviousMatch;
        private Button btnpopulateForEvent;
        private Button btnExit;
        private TableLayoutPanel blueTeams;
        private TableLayoutPanel redTeams;
        private Panel team0;
        private Panel team0TeamDivider;
        private Label lbl0MatchEvent;
        private Label lbl0TeamName;
        private Label lbl0ScoutName;
        private Label lbl0ModeValue;
        private System.ComponentModel.IContainer components = null;
        private Label labelMatch;
        private Label lblMatch;
        private System.Windows.Forms.Timer timerJoysticks;
        private Button btnFunctions;
        private Label lbl0Position4Value;
        private Label lbl0Position0;
        private Label lbl0Position2Value;
        private Panel team0Divider;
        private Panel team0ModeDivider;
        private Label lblBlueScore;
        private Label lblRedScore;
        private Panel statusLight;
        private Panel topPanel;
        private scoutingdbDataSetTableAdapters.__MigrationHistoryTableAdapter ___MigrationHistoryTableAdapter;
        private Label lbl0Position5;
        private Label lbl0Position1;
        private Label lbl0Position2;
        private Label lbl0Position3;
        private Label lbl0Position4;
        private Label lbl0Position6;
        private Label lbl0Position7;
        private Label lbl0Position9;
        private Label lbl0Position8;
        private Label lbl0Position3Value;
    }
}
