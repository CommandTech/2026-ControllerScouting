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
            lbl5Background = new Panel();
            lbl5Position2Value = new Label();
            lbl5Position3Value = new Label();
            lbl5Position9 = new Label();
            lbl5Position8 = new Label();
            lbl5Position7 = new Label();
            lbl5Position6 = new Label();
            lbl5Position4 = new Label();
            lbl5Position3 = new Label();
            lbl5Position2 = new Label();
            lbl5Position1 = new Label();
            lbl5Position4Value = new Label();
            lbl5Position0 = new Label();
            lbl5Divider1 = new Panel();
            lbl5Divider0 = new Panel();
            lbl5Divider2 = new Panel();
            lbl5MatchEvent = new Label();
            lbl5TeamName = new Label();
            lbl5ScoutName = new Label();
            lbl5ModeValue = new Label();
            lbl4Background = new Panel();
            lbl4Position2Value = new Label();
            lbl4Position3Value = new Label();
            lbl4Position9 = new Label();
            lbl4Position8 = new Label();
            lbl4Position7 = new Label();
            lbl4Position6 = new Label();
            lbl4Position4 = new Label();
            lbl4Position3 = new Label();
            lbl4Position2 = new Label();
            lbl4Position1 = new Label();
            lbl4Position4Value = new Label();
            lbl4Position0 = new Label();
            lbl4Divider1 = new Panel();
            lbl4Divider0 = new Panel();
            lbl4Divider2 = new Panel();
            lbl4MatchEvent = new Label();
            lbl4TeamName = new Label();
            lbl4ScoutName = new Label();
            lbl4ModeValue = new Label();
            lbl3Background = new Panel();
            lbl3Position2Value = new Label();
            lbl3Position3Value = new Label();
            lbl3Position9 = new Label();
            lbl3Position8 = new Label();
            lbl3Position7 = new Label();
            lbl3Position6 = new Label();
            lbl3Position4 = new Label();
            lbl3Position3 = new Label();
            lbl3Position2 = new Label();
            lbl3Position1 = new Label();
            lbl3Position4Value = new Label();
            lbl3Position0 = new Label();
            lbl3Divider1 = new Panel();
            lbl3Divider0 = new Panel();
            lbl3Divider2 = new Panel();
            lbl3MatchEvent = new Label();
            lbl3TeamName = new Label();
            lbl3ScoutName = new Label();
            lbl3ModeValue = new Label();
            redTeams = new TableLayoutPanel();
            lbl2Background = new Panel();
            lbl2MatchEvent = new Label();
            lbl2TeamName = new Label();
            lbl2Position2Value = new Label();
            lbl2Position3Value = new Label();
            lbl2Position9 = new Label();
            lbl2Position8 = new Label();
            lbl2Position7 = new Label();
            lbl2Position6 = new Label();
            lbl2Position4 = new Label();
            lbl2Position3 = new Label();
            lbl2Position2 = new Label();
            lbl2Position1 = new Label();
            lbl2Position4Value = new Label();
            lbl2Position0 = new Label();
            lbl2Divider1 = new Panel();
            lbl2Divider0 = new Panel();
            lbl2Divider2 = new Panel();
            lbl2ScoutName = new Label();
            lbl2ModeValue = new Label();
            lbl1Background = new Panel();
            lbl1MatchEvent = new Label();
            lbl1TeamName = new Label();
            lbl1Position2Value = new Label();
            lbl1Position3Value = new Label();
            lbl1Position9 = new Label();
            lbl1Position8 = new Label();
            lbl1Position7 = new Label();
            lbl1Position6 = new Label();
            lbl1Position4 = new Label();
            lbl1Position3 = new Label();
            lbl1Position2 = new Label();
            lbl1Position1 = new Label();
            lbl1Position4Value = new Label();
            lbl1Position0 = new Label();
            lbl1Divider1 = new Panel();
            lbl1Divider0 = new Panel();
            lbl1Divider2 = new Panel();
            lbl1ScoutName = new Label();
            lbl1ModeValue = new Label();
            lbl0Background = new Panel();
            lbl0Divider0 = new Panel();
            lbl0Position2Value = new Label();
            lbl0Position3Value = new Label();
            lbl0Position9 = new Label();
            lbl0Position8 = new Label();
            lbl0Position7 = new Label();
            lbl0Position6 = new Label();
            lbl0Position4 = new Label();
            lbl0Position3 = new Label();
            lbl0Position2 = new Label();
            lbl0Position1 = new Label();
            lbl0Position4Value = new Label();
            lbl0Position0 = new Label();
            lbl0Divider1 = new Panel();
            lbl0Divider2 = new Panel();
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
            blueTeams.SuspendLayout();
            lbl5Background.SuspendLayout();
            lbl4Background.SuspendLayout();
            lbl3Background.SuspendLayout();
            redTeams.SuspendLayout();
            lbl2Background.SuspendLayout();
            lbl1Background.SuspendLayout();
            lbl0Background.SuspendLayout();
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
            blueTeams.Controls.Add(lbl5Background, 2, 0);
            blueTeams.Controls.Add(lbl4Background, 1, 0);
            blueTeams.Controls.Add(lbl3Background, 0, 0);
            blueTeams.Dock = DockStyle.Fill;
            blueTeams.Location = new Point(3, 438);
            blueTeams.Name = "blueTeams";
            blueTeams.RowCount = 1;
            blueTeams.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            blueTeams.Size = new Size(1294, 379);
            blueTeams.TabIndex = 0;
            // 
            // lbl5Background
            // 
            lbl5Background.BackColor = Color.Black;
            lbl5Background.Controls.Add(lbl5Position2Value);
            lbl5Background.Controls.Add(lbl5Position3Value);
            lbl5Background.Controls.Add(lbl5Position9);
            lbl5Background.Controls.Add(lbl5Position8);
            lbl5Background.Controls.Add(lbl5Position7);
            lbl5Background.Controls.Add(lbl5Position6);
            lbl5Background.Controls.Add(lbl5Position4);
            lbl5Background.Controls.Add(lbl5Position3);
            lbl5Background.Controls.Add(lbl5Position2);
            lbl5Background.Controls.Add(lbl5Position1);
            lbl5Background.Controls.Add(lbl5Position4Value);
            lbl5Background.Controls.Add(lbl5Position0);
            lbl5Background.Controls.Add(lbl5Divider1);
            lbl5Background.Controls.Add(lbl5Divider0);
            lbl5Background.Controls.Add(lbl5Divider2);
            lbl5Background.Controls.Add(lbl5MatchEvent);
            lbl5Background.Controls.Add(lbl5TeamName);
            lbl5Background.Controls.Add(lbl5ScoutName);
            lbl5Background.Controls.Add(lbl5ModeValue);
            lbl5Background.Dock = DockStyle.Fill;
            lbl5Background.Location = new Point(865, 3);
            lbl5Background.Name = "lbl5Background";
            lbl5Background.Size = new Size(426, 373);
            lbl5Background.TabIndex = 3;
            // 
            // lbl5Position2Value
            // 
            lbl5Position2Value.AutoSize = true;
            lbl5Position2Value.BackColor = Color.Red;
            lbl5Position2Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl5Position2Value.ForeColor = Color.Red;
            lbl5Position2Value.ImageAlign = ContentAlignment.TopLeft;
            lbl5Position2Value.Location = new Point(407, 61);
            lbl5Position2Value.Name = "lbl5Position2Value";
            lbl5Position2Value.Size = new Size(16, 24);
            lbl5Position2Value.TabIndex = 407;
            lbl5Position2Value.Text = ".";
            lbl5Position2Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl5Position3Value
            // 
            lbl5Position3Value.AutoSize = true;
            lbl5Position3Value.BackColor = Color.Red;
            lbl5Position3Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl5Position3Value.ForeColor = Color.Red;
            lbl5Position3Value.ImageAlign = ContentAlignment.TopLeft;
            lbl5Position3Value.Location = new Point(165, 161);
            lbl5Position3Value.Name = "lbl5Position3Value";
            lbl5Position3Value.Size = new Size(16, 24);
            lbl5Position3Value.TabIndex = 406;
            lbl5Position3Value.Text = ".";
            lbl5Position3Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl5Position9
            // 
            lbl5Position9.AutoSize = true;
            lbl5Position9.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position9.ForeColor = Color.White;
            lbl5Position9.Location = new Point(257, 269);
            lbl5Position9.Name = "lbl5Position9";
            lbl5Position9.Size = new Size(244, 20);
            lbl5Position9.TabIndex = 405;
            lbl5Position9.Text = "Ladder Location: OUTPOST";
            lbl5Position9.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl5Position8
            // 
            lbl5Position8.AutoSize = true;
            lbl5Position8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position8.ForeColor = Color.White;
            lbl5Position8.Location = new Point(299, 161);
            lbl5Position8.Name = "lbl5Position8";
            lbl5Position8.Size = new Size(164, 24);
            lbl5Position8.TabIndex = 404;
            lbl5Position8.Text = "Strategy: VALUE";
            lbl5Position8.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl5Position7
            // 
            lbl5Position7.AutoSize = true;
            lbl5Position7.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position7.ForeColor = Color.White;
            lbl5Position7.Location = new Point(3, 266);
            lbl5Position7.Name = "lbl5Position7";
            lbl5Position7.Size = new Size(148, 22);
            lbl5Position7.TabIndex = 402;
            lbl5Position7.Text = "Climb Level: L#";
            // 
            // lbl5Position6
            // 
            lbl5Position6.AutoSize = true;
            lbl5Position6.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position6.ForeColor = Color.White;
            lbl5Position6.Location = new Point(3, 195);
            lbl5Position6.Name = "lbl5Position6";
            lbl5Position6.Size = new Size(179, 22);
            lbl5Position6.TabIndex = 401;
            lbl5Position6.Text = "Avoidance: VALUE";
            // 
            // lbl5Position4
            // 
            lbl5Position4.AutoSize = true;
            lbl5Position4.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position4.ForeColor = Color.White;
            lbl5Position4.Location = new Point(2, 231);
            lbl5Position4.Name = "lbl5Position4";
            lbl5Position4.Size = new Size(66, 22);
            lbl5Position4.TabIndex = 399;
            lbl5Position4.Text = "Climb:";
            // 
            // lbl5Position3
            // 
            lbl5Position3.AutoSize = true;
            lbl5Position3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position3.ForeColor = Color.White;
            lbl5Position3.Location = new Point(3, 161);
            lbl5Position3.Name = "lbl5Position3";
            lbl5Position3.Size = new Size(87, 24);
            lbl5Position3.TabIndex = 399;
            lbl5Position3.Text = "Bump: 0";
            // 
            // lbl5Position2
            // 
            lbl5Position2.AutoSize = true;
            lbl5Position2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position2.ForeColor = Color.White;
            lbl5Position2.Location = new Point(257, 61);
            lbl5Position2.Name = "lbl5Position2";
            lbl5Position2.Size = new Size(221, 24);
            lbl5Position2.TabIndex = 397;
            lbl5Position2.Text = "Shooting Timer: 0:00.0";
            // 
            // lbl5Position1
            // 
            lbl5Position1.AutoSize = true;
            lbl5Position1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position1.ForeColor = Color.White;
            lbl5Position1.Location = new Point(0, 61);
            lbl5Position1.Name = "lbl5Position1";
            lbl5Position1.Size = new Size(193, 24);
            lbl5Position1.TabIndex = 396;
            lbl5Position1.Text = "Intake Timer: 0:00.0";
            // 
            // lbl5Position4Value
            // 
            lbl5Position4Value.AutoSize = true;
            lbl5Position4Value.BackColor = Color.Red;
            lbl5Position4Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl5Position4Value.ForeColor = Color.Red;
            lbl5Position4Value.ImageAlign = ContentAlignment.TopLeft;
            lbl5Position4Value.Location = new Point(77, 231);
            lbl5Position4Value.Name = "lbl5Position4Value";
            lbl5Position4Value.Size = new Size(16, 24);
            lbl5Position4Value.TabIndex = 395;
            lbl5Position4Value.Text = ".";
            lbl5Position4Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl5Position0
            // 
            lbl5Position0.AutoSize = true;
            lbl5Position0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position0.ForeColor = Color.White;
            lbl5Position0.Location = new Point(231, 10);
            lbl5Position0.Name = "lbl5Position0";
            lbl5Position0.Size = new Size(262, 20);
            lbl5Position0.TabIndex = 394;
            lbl5Position0.Text = "Starting Location: Outer Trench";
            lbl5Position0.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl5Divider1
            // 
            lbl5Divider1.BackColor = Color.Blue;
            lbl5Divider1.Location = new Point(-5, 119);
            lbl5Divider1.Name = "lbl5Divider1";
            lbl5Divider1.Size = new Size(534, 11);
            lbl5Divider1.TabIndex = 389;
            // 
            // lbl5Divider0
            // 
            lbl5Divider0.BackColor = Color.Blue;
            lbl5Divider0.Location = new Point(-5, 40);
            lbl5Divider0.Name = "lbl5Divider0";
            lbl5Divider0.Size = new Size(534, 11);
            lbl5Divider0.TabIndex = 390;
            // 
            // lbl5Divider2
            // 
            lbl5Divider2.BackColor = Color.Blue;
            lbl5Divider2.Location = new Point(0, 314);
            lbl5Divider2.Name = "lbl5Divider2";
            lbl5Divider2.Size = new Size(534, 11);
            lbl5Divider2.TabIndex = 279;
            // 
            // lbl5MatchEvent
            // 
            lbl5MatchEvent.AutoSize = true;
            lbl5MatchEvent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5MatchEvent.ForeColor = Color.White;
            lbl5MatchEvent.Location = new Point(2, 328);
            lbl5MatchEvent.Name = "lbl5MatchEvent";
            lbl5MatchEvent.Size = new Size(125, 24);
            lbl5MatchEvent.TabIndex = 291;
            lbl5MatchEvent.Text = "Match Event";
            // 
            // lbl5TeamName
            // 
            lbl5TeamName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl5TeamName.ForeColor = Color.Goldenrod;
            lbl5TeamName.Location = new Point(323, 347);
            lbl5TeamName.Name = "lbl5TeamName";
            lbl5TeamName.Size = new Size(159, 37);
            lbl5TeamName.TabIndex = 294;
            lbl5TeamName.Text = "Team 0";
            lbl5TeamName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl5ScoutName
            // 
            lbl5ScoutName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5ScoutName.ForeColor = Color.Goldenrod;
            lbl5ScoutName.Location = new Point(3, 356);
            lbl5ScoutName.Name = "lbl5ScoutName";
            lbl5ScoutName.Size = new Size(158, 27);
            lbl5ScoutName.TabIndex = 293;
            lbl5ScoutName.Text = "Select Name";
            lbl5ScoutName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl5ModeValue
            // 
            lbl5ModeValue.AutoSize = true;
            lbl5ModeValue.BackColor = Color.Black;
            lbl5ModeValue.Font = new Font("Microsoft Sans Serif", 18F);
            lbl5ModeValue.ForeColor = Color.LimeGreen;
            lbl5ModeValue.Location = new Point(1, 3);
            lbl5ModeValue.Name = "lbl5ModeValue";
            lbl5ModeValue.Size = new Size(135, 29);
            lbl5ModeValue.TabIndex = 2;
            lbl5ModeValue.Text = "Auto Mode:";
            // 
            // lbl4Background
            // 
            lbl4Background.BackColor = Color.Black;
            lbl4Background.Controls.Add(lbl4Position2Value);
            lbl4Background.Controls.Add(lbl4Position3Value);
            lbl4Background.Controls.Add(lbl4Position9);
            lbl4Background.Controls.Add(lbl4Position8);
            lbl4Background.Controls.Add(lbl4Position7);
            lbl4Background.Controls.Add(lbl4Position6);
            lbl4Background.Controls.Add(lbl4Position4);
            lbl4Background.Controls.Add(lbl4Position3);
            lbl4Background.Controls.Add(lbl4Position2);
            lbl4Background.Controls.Add(lbl4Position1);
            lbl4Background.Controls.Add(lbl4Position4Value);
            lbl4Background.Controls.Add(lbl4Position0);
            lbl4Background.Controls.Add(lbl4Divider1);
            lbl4Background.Controls.Add(lbl4Divider0);
            lbl4Background.Controls.Add(lbl4Divider2);
            lbl4Background.Controls.Add(lbl4MatchEvent);
            lbl4Background.Controls.Add(lbl4TeamName);
            lbl4Background.Controls.Add(lbl4ScoutName);
            lbl4Background.Controls.Add(lbl4ModeValue);
            lbl4Background.Dock = DockStyle.Fill;
            lbl4Background.Location = new Point(434, 3);
            lbl4Background.Name = "lbl4Background";
            lbl4Background.Size = new Size(425, 373);
            lbl4Background.TabIndex = 2;
            // 
            // lbl4Position2Value
            // 
            lbl4Position2Value.AutoSize = true;
            lbl4Position2Value.BackColor = Color.Red;
            lbl4Position2Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl4Position2Value.ForeColor = Color.Red;
            lbl4Position2Value.ImageAlign = ContentAlignment.TopLeft;
            lbl4Position2Value.Location = new Point(407, 61);
            lbl4Position2Value.Name = "lbl4Position2Value";
            lbl4Position2Value.Size = new Size(16, 24);
            lbl4Position2Value.TabIndex = 407;
            lbl4Position2Value.Text = ".";
            lbl4Position2Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl4Position3Value
            // 
            lbl4Position3Value.AutoSize = true;
            lbl4Position3Value.BackColor = Color.Red;
            lbl4Position3Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl4Position3Value.ForeColor = Color.Red;
            lbl4Position3Value.ImageAlign = ContentAlignment.TopLeft;
            lbl4Position3Value.Location = new Point(165, 161);
            lbl4Position3Value.Name = "lbl4Position3Value";
            lbl4Position3Value.Size = new Size(16, 24);
            lbl4Position3Value.TabIndex = 406;
            lbl4Position3Value.Text = ".";
            lbl4Position3Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl4Position9
            // 
            lbl4Position9.AutoSize = true;
            lbl4Position9.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position9.ForeColor = Color.White;
            lbl4Position9.Location = new Point(257, 269);
            lbl4Position9.Name = "lbl4Position9";
            lbl4Position9.Size = new Size(244, 20);
            lbl4Position9.TabIndex = 405;
            lbl4Position9.Text = "Ladder Location: OUTPOST";
            lbl4Position9.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl4Position8
            // 
            lbl4Position8.AutoSize = true;
            lbl4Position8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position8.ForeColor = Color.White;
            lbl4Position8.Location = new Point(299, 161);
            lbl4Position8.Name = "lbl4Position8";
            lbl4Position8.Size = new Size(164, 24);
            lbl4Position8.TabIndex = 404;
            lbl4Position8.Text = "Strategy: VALUE";
            lbl4Position8.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl4Position7
            // 
            lbl4Position7.AutoSize = true;
            lbl4Position7.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position7.ForeColor = Color.White;
            lbl4Position7.Location = new Point(3, 266);
            lbl4Position7.Name = "lbl4Position7";
            lbl4Position7.Size = new Size(148, 22);
            lbl4Position7.TabIndex = 402;
            lbl4Position7.Text = "Climb Level: L#";
            // 
            // lbl4Position6
            // 
            lbl4Position6.AutoSize = true;
            lbl4Position6.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position6.ForeColor = Color.White;
            lbl4Position6.Location = new Point(3, 195);
            lbl4Position6.Name = "lbl4Position6";
            lbl4Position6.Size = new Size(179, 22);
            lbl4Position6.TabIndex = 401;
            lbl4Position6.Text = "Avoidance: VALUE";
            // 
            // lbl4Position4
            // 
            lbl4Position4.AutoSize = true;
            lbl4Position4.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position4.ForeColor = Color.White;
            lbl4Position4.Location = new Point(2, 231);
            lbl4Position4.Name = "lbl4Position4";
            lbl4Position4.Size = new Size(66, 22);
            lbl4Position4.TabIndex = 399;
            lbl4Position4.Text = "Climb:";
            // 
            // lbl4Position3
            // 
            lbl4Position3.AutoSize = true;
            lbl4Position3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position3.ForeColor = Color.White;
            lbl4Position3.Location = new Point(3, 161);
            lbl4Position3.Name = "lbl4Position3";
            lbl4Position3.Size = new Size(87, 24);
            lbl4Position3.TabIndex = 399;
            lbl4Position3.Text = "Bump: 0";
            // 
            // lbl4Position2
            // 
            lbl4Position2.AutoSize = true;
            lbl4Position2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position2.ForeColor = Color.White;
            lbl4Position2.Location = new Point(257, 61);
            lbl4Position2.Name = "lbl4Position2";
            lbl4Position2.Size = new Size(221, 24);
            lbl4Position2.TabIndex = 397;
            lbl4Position2.Text = "Shooting Timer: 0:00.0";
            // 
            // lbl4Position1
            // 
            lbl4Position1.AutoSize = true;
            lbl4Position1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position1.ForeColor = Color.White;
            lbl4Position1.Location = new Point(0, 61);
            lbl4Position1.Name = "lbl4Position1";
            lbl4Position1.Size = new Size(193, 24);
            lbl4Position1.TabIndex = 396;
            lbl4Position1.Text = "Intake Timer: 0:00.0";
            // 
            // lbl4Position4Value
            // 
            lbl4Position4Value.AutoSize = true;
            lbl4Position4Value.BackColor = Color.Red;
            lbl4Position4Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl4Position4Value.ForeColor = Color.Red;
            lbl4Position4Value.ImageAlign = ContentAlignment.TopLeft;
            lbl4Position4Value.Location = new Point(77, 231);
            lbl4Position4Value.Name = "lbl4Position4Value";
            lbl4Position4Value.Size = new Size(16, 24);
            lbl4Position4Value.TabIndex = 395;
            lbl4Position4Value.Text = ".";
            lbl4Position4Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl4Position0
            // 
            lbl4Position0.AutoSize = true;
            lbl4Position0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position0.ForeColor = Color.White;
            lbl4Position0.Location = new Point(213, 10);
            lbl4Position0.Name = "lbl4Position0";
            lbl4Position0.Size = new Size(262, 20);
            lbl4Position0.TabIndex = 394;
            lbl4Position0.Text = "Starting Location: Outer Trench";
            lbl4Position0.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl4Divider1
            // 
            lbl4Divider1.BackColor = Color.Blue;
            lbl4Divider1.Location = new Point(-5, 119);
            lbl4Divider1.Name = "lbl4Divider1";
            lbl4Divider1.Size = new Size(534, 11);
            lbl4Divider1.TabIndex = 389;
            // 
            // lbl4Divider0
            // 
            lbl4Divider0.BackColor = Color.Blue;
            lbl4Divider0.Location = new Point(-5, 40);
            lbl4Divider0.Name = "lbl4Divider0";
            lbl4Divider0.Size = new Size(534, 11);
            lbl4Divider0.TabIndex = 390;
            // 
            // lbl4Divider2
            // 
            lbl4Divider2.BackColor = Color.Blue;
            lbl4Divider2.Location = new Point(0, 314);
            lbl4Divider2.Name = "lbl4Divider2";
            lbl4Divider2.Size = new Size(534, 11);
            lbl4Divider2.TabIndex = 279;
            // 
            // lbl4MatchEvent
            // 
            lbl4MatchEvent.AutoSize = true;
            lbl4MatchEvent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4MatchEvent.ForeColor = Color.White;
            lbl4MatchEvent.Location = new Point(2, 328);
            lbl4MatchEvent.Name = "lbl4MatchEvent";
            lbl4MatchEvent.Size = new Size(125, 24);
            lbl4MatchEvent.TabIndex = 291;
            lbl4MatchEvent.Text = "Match Event";
            // 
            // lbl4TeamName
            // 
            lbl4TeamName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl4TeamName.ForeColor = Color.Goldenrod;
            lbl4TeamName.Location = new Point(323, 347);
            lbl4TeamName.Name = "lbl4TeamName";
            lbl4TeamName.Size = new Size(159, 37);
            lbl4TeamName.TabIndex = 294;
            lbl4TeamName.Text = "Team 0";
            lbl4TeamName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl4ScoutName
            // 
            lbl4ScoutName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4ScoutName.ForeColor = Color.Goldenrod;
            lbl4ScoutName.Location = new Point(3, 356);
            lbl4ScoutName.Name = "lbl4ScoutName";
            lbl4ScoutName.Size = new Size(158, 27);
            lbl4ScoutName.TabIndex = 293;
            lbl4ScoutName.Text = "Select Name";
            lbl4ScoutName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl4ModeValue
            // 
            lbl4ModeValue.AutoSize = true;
            lbl4ModeValue.BackColor = Color.Black;
            lbl4ModeValue.Font = new Font("Microsoft Sans Serif", 18F);
            lbl4ModeValue.ForeColor = Color.LimeGreen;
            lbl4ModeValue.Location = new Point(1, 3);
            lbl4ModeValue.Name = "lbl4ModeValue";
            lbl4ModeValue.Size = new Size(135, 29);
            lbl4ModeValue.TabIndex = 2;
            lbl4ModeValue.Text = "Auto Mode:";
            // 
            // lbl3Background
            // 
            lbl3Background.BackColor = Color.Black;
            lbl3Background.Controls.Add(lbl3Position2Value);
            lbl3Background.Controls.Add(lbl3Position3Value);
            lbl3Background.Controls.Add(lbl3Position9);
            lbl3Background.Controls.Add(lbl3Position8);
            lbl3Background.Controls.Add(lbl3Position7);
            lbl3Background.Controls.Add(lbl3Position6);
            lbl3Background.Controls.Add(lbl3Position4);
            lbl3Background.Controls.Add(lbl3Position3);
            lbl3Background.Controls.Add(lbl3Position2);
            lbl3Background.Controls.Add(lbl3Position1);
            lbl3Background.Controls.Add(lbl3Position4Value);
            lbl3Background.Controls.Add(lbl3Position0);
            lbl3Background.Controls.Add(lbl3Divider1);
            lbl3Background.Controls.Add(lbl3Divider0);
            lbl3Background.Controls.Add(lbl3Divider2);
            lbl3Background.Controls.Add(lbl3MatchEvent);
            lbl3Background.Controls.Add(lbl3TeamName);
            lbl3Background.Controls.Add(lbl3ScoutName);
            lbl3Background.Controls.Add(lbl3ModeValue);
            lbl3Background.Dock = DockStyle.Fill;
            lbl3Background.Location = new Point(3, 3);
            lbl3Background.Name = "lbl3Background";
            lbl3Background.Size = new Size(425, 373);
            lbl3Background.TabIndex = 1;
            // 
            // lbl3Position2Value
            // 
            lbl3Position2Value.AutoSize = true;
            lbl3Position2Value.BackColor = Color.Red;
            lbl3Position2Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl3Position2Value.ForeColor = Color.Red;
            lbl3Position2Value.ImageAlign = ContentAlignment.TopLeft;
            lbl3Position2Value.Location = new Point(407, 61);
            lbl3Position2Value.Name = "lbl3Position2Value";
            lbl3Position2Value.Size = new Size(16, 24);
            lbl3Position2Value.TabIndex = 407;
            lbl3Position2Value.Text = ".";
            lbl3Position2Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl3Position3Value
            // 
            lbl3Position3Value.AutoSize = true;
            lbl3Position3Value.BackColor = Color.Red;
            lbl3Position3Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl3Position3Value.ForeColor = Color.Red;
            lbl3Position3Value.ImageAlign = ContentAlignment.TopLeft;
            lbl3Position3Value.Location = new Point(165, 161);
            lbl3Position3Value.Name = "lbl3Position3Value";
            lbl3Position3Value.Size = new Size(16, 24);
            lbl3Position3Value.TabIndex = 406;
            lbl3Position3Value.Text = ".";
            lbl3Position3Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl3Position9
            // 
            lbl3Position9.AutoSize = true;
            lbl3Position9.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position9.ForeColor = Color.White;
            lbl3Position9.Location = new Point(257, 269);
            lbl3Position9.Name = "lbl3Position9";
            lbl3Position9.Size = new Size(244, 20);
            lbl3Position9.TabIndex = 405;
            lbl3Position9.Text = "Ladder Location: OUTPOST";
            lbl3Position9.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl3Position8
            // 
            lbl3Position8.AutoSize = true;
            lbl3Position8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position8.ForeColor = Color.White;
            lbl3Position8.Location = new Point(299, 161);
            lbl3Position8.Name = "lbl3Position8";
            lbl3Position8.Size = new Size(164, 24);
            lbl3Position8.TabIndex = 404;
            lbl3Position8.Text = "Strategy: VALUE";
            lbl3Position8.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl3Position7
            // 
            lbl3Position7.AutoSize = true;
            lbl3Position7.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position7.ForeColor = Color.White;
            lbl3Position7.Location = new Point(3, 266);
            lbl3Position7.Name = "lbl3Position7";
            lbl3Position7.Size = new Size(148, 22);
            lbl3Position7.TabIndex = 402;
            lbl3Position7.Text = "Climb Level: L#";
            // 
            // lbl3Position6
            // 
            lbl3Position6.AutoSize = true;
            lbl3Position6.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position6.ForeColor = Color.White;
            lbl3Position6.Location = new Point(3, 195);
            lbl3Position6.Name = "lbl3Position6";
            lbl3Position6.Size = new Size(179, 22);
            lbl3Position6.TabIndex = 401;
            lbl3Position6.Text = "Avoidance: VALUE";
            // 
            // lbl3Position4
            // 
            lbl3Position4.AutoSize = true;
            lbl3Position4.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position4.ForeColor = Color.White;
            lbl3Position4.Location = new Point(2, 231);
            lbl3Position4.Name = "lbl3Position4";
            lbl3Position4.Size = new Size(66, 22);
            lbl3Position4.TabIndex = 399;
            lbl3Position4.Text = "Climb:";
            // 
            // lbl3Position3
            // 
            lbl3Position3.AutoSize = true;
            lbl3Position3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position3.ForeColor = Color.White;
            lbl3Position3.Location = new Point(3, 161);
            lbl3Position3.Name = "lbl3Position3";
            lbl3Position3.Size = new Size(87, 24);
            lbl3Position3.TabIndex = 399;
            lbl3Position3.Text = "Bump: 0";
            // 
            // lbl3Position2
            // 
            lbl3Position2.AutoSize = true;
            lbl3Position2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position2.ForeColor = Color.White;
            lbl3Position2.Location = new Point(257, 61);
            lbl3Position2.Name = "lbl3Position2";
            lbl3Position2.Size = new Size(221, 24);
            lbl3Position2.TabIndex = 397;
            lbl3Position2.Text = "Shooting Timer: 0:00.0";
            // 
            // lbl3Position1
            // 
            lbl3Position1.AutoSize = true;
            lbl3Position1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position1.ForeColor = Color.White;
            lbl3Position1.Location = new Point(0, 61);
            lbl3Position1.Name = "lbl3Position1";
            lbl3Position1.Size = new Size(193, 24);
            lbl3Position1.TabIndex = 396;
            lbl3Position1.Text = "Intake Timer: 0:00.0";
            // 
            // lbl3Position4Value
            // 
            lbl3Position4Value.AutoSize = true;
            lbl3Position4Value.BackColor = Color.Red;
            lbl3Position4Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl3Position4Value.ForeColor = Color.Red;
            lbl3Position4Value.ImageAlign = ContentAlignment.TopLeft;
            lbl3Position4Value.Location = new Point(77, 231);
            lbl3Position4Value.Name = "lbl3Position4Value";
            lbl3Position4Value.Size = new Size(16, 24);
            lbl3Position4Value.TabIndex = 395;
            lbl3Position4Value.Text = ".";
            lbl3Position4Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl3Position0
            // 
            lbl3Position0.AutoSize = true;
            lbl3Position0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position0.ForeColor = Color.White;
            lbl3Position0.Location = new Point(231, 10);
            lbl3Position0.Name = "lbl3Position0";
            lbl3Position0.Size = new Size(262, 20);
            lbl3Position0.TabIndex = 394;
            lbl3Position0.Text = "Starting Location: Outer Trench";
            lbl3Position0.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl3Divider1
            // 
            lbl3Divider1.BackColor = Color.Blue;
            lbl3Divider1.Location = new Point(-5, 119);
            lbl3Divider1.Name = "lbl3Divider1";
            lbl3Divider1.Size = new Size(534, 11);
            lbl3Divider1.TabIndex = 389;
            // 
            // lbl3Divider0
            // 
            lbl3Divider0.BackColor = Color.Blue;
            lbl3Divider0.Location = new Point(-5, 40);
            lbl3Divider0.Name = "lbl3Divider0";
            lbl3Divider0.Size = new Size(534, 11);
            lbl3Divider0.TabIndex = 390;
            // 
            // lbl3Divider2
            // 
            lbl3Divider2.BackColor = Color.Blue;
            lbl3Divider2.Location = new Point(0, 314);
            lbl3Divider2.Name = "lbl3Divider2";
            lbl3Divider2.Size = new Size(534, 11);
            lbl3Divider2.TabIndex = 279;
            // 
            // lbl3MatchEvent
            // 
            lbl3MatchEvent.AutoSize = true;
            lbl3MatchEvent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3MatchEvent.ForeColor = Color.White;
            lbl3MatchEvent.Location = new Point(2, 328);
            lbl3MatchEvent.Name = "lbl3MatchEvent";
            lbl3MatchEvent.Size = new Size(125, 24);
            lbl3MatchEvent.TabIndex = 291;
            lbl3MatchEvent.Text = "Match Event";
            // 
            // lbl3TeamName
            // 
            lbl3TeamName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl3TeamName.ForeColor = Color.Goldenrod;
            lbl3TeamName.Location = new Point(323, 347);
            lbl3TeamName.Name = "lbl3TeamName";
            lbl3TeamName.Size = new Size(159, 37);
            lbl3TeamName.TabIndex = 294;
            lbl3TeamName.Text = "Team 0";
            lbl3TeamName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl3ScoutName
            // 
            lbl3ScoutName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3ScoutName.ForeColor = Color.Goldenrod;
            lbl3ScoutName.Location = new Point(3, 356);
            lbl3ScoutName.Name = "lbl3ScoutName";
            lbl3ScoutName.Size = new Size(158, 27);
            lbl3ScoutName.TabIndex = 293;
            lbl3ScoutName.Text = "Select Name";
            lbl3ScoutName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl3ModeValue
            // 
            lbl3ModeValue.AutoSize = true;
            lbl3ModeValue.BackColor = Color.Black;
            lbl3ModeValue.Font = new Font("Microsoft Sans Serif", 18F);
            lbl3ModeValue.ForeColor = Color.LimeGreen;
            lbl3ModeValue.Location = new Point(1, 3);
            lbl3ModeValue.Name = "lbl3ModeValue";
            lbl3ModeValue.Size = new Size(135, 29);
            lbl3ModeValue.TabIndex = 2;
            lbl3ModeValue.Text = "Auto Mode:";
            // 
            // redTeams
            // 
            redTeams.BackColor = Color.Red;
            redTeams.ColumnCount = 3;
            redTeams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            redTeams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            redTeams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            redTeams.Controls.Add(lbl2Background, 2, 0);
            redTeams.Controls.Add(lbl1Background, 1, 0);
            redTeams.Controls.Add(lbl0Background, 0, 0);
            redTeams.Dock = DockStyle.Fill;
            redTeams.Location = new Point(3, 53);
            redTeams.Name = "redTeams";
            redTeams.RowCount = 1;
            redTeams.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            redTeams.Size = new Size(1294, 379);
            redTeams.TabIndex = 0;
            // 
            // lbl2Background
            // 
            lbl2Background.BackColor = Color.Black;
            lbl2Background.Controls.Add(lbl2MatchEvent);
            lbl2Background.Controls.Add(lbl2TeamName);
            lbl2Background.Controls.Add(lbl2Position2Value);
            lbl2Background.Controls.Add(lbl2Position3Value);
            lbl2Background.Controls.Add(lbl2Position9);
            lbl2Background.Controls.Add(lbl2Position8);
            lbl2Background.Controls.Add(lbl2Position7);
            lbl2Background.Controls.Add(lbl2Position6);
            lbl2Background.Controls.Add(lbl2Position4);
            lbl2Background.Controls.Add(lbl2Position3);
            lbl2Background.Controls.Add(lbl2Position2);
            lbl2Background.Controls.Add(lbl2Position1);
            lbl2Background.Controls.Add(lbl2Position4Value);
            lbl2Background.Controls.Add(lbl2Position0);
            lbl2Background.Controls.Add(lbl2Divider1);
            lbl2Background.Controls.Add(lbl2Divider0);
            lbl2Background.Controls.Add(lbl2Divider2);
            lbl2Background.Controls.Add(lbl2ScoutName);
            lbl2Background.Controls.Add(lbl2ModeValue);
            lbl2Background.Dock = DockStyle.Fill;
            lbl2Background.Location = new Point(865, 3);
            lbl2Background.Name = "lbl2Background";
            lbl2Background.Size = new Size(426, 373);
            lbl2Background.TabIndex = 2;
            // 
            // lbl2MatchEvent
            // 
            lbl2MatchEvent.AutoSize = true;
            lbl2MatchEvent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2MatchEvent.ForeColor = Color.White;
            lbl2MatchEvent.Location = new Point(3, 328);
            lbl2MatchEvent.Name = "lbl2MatchEvent";
            lbl2MatchEvent.Size = new Size(125, 24);
            lbl2MatchEvent.TabIndex = 408;
            lbl2MatchEvent.Text = "Match Event";
            // 
            // lbl2TeamName
            // 
            lbl2TeamName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl2TeamName.ForeColor = Color.Goldenrod;
            lbl2TeamName.Location = new Point(324, 347);
            lbl2TeamName.Name = "lbl2TeamName";
            lbl2TeamName.Size = new Size(159, 37);
            lbl2TeamName.TabIndex = 409;
            lbl2TeamName.Text = "Team 0";
            lbl2TeamName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl2Position2Value
            // 
            lbl2Position2Value.AutoSize = true;
            lbl2Position2Value.BackColor = Color.Red;
            lbl2Position2Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl2Position2Value.ForeColor = Color.Red;
            lbl2Position2Value.ImageAlign = ContentAlignment.TopLeft;
            lbl2Position2Value.Location = new Point(407, 61);
            lbl2Position2Value.Name = "lbl2Position2Value";
            lbl2Position2Value.Size = new Size(16, 24);
            lbl2Position2Value.TabIndex = 407;
            lbl2Position2Value.Text = ".";
            lbl2Position2Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl2Position3Value
            // 
            lbl2Position3Value.AutoSize = true;
            lbl2Position3Value.BackColor = Color.Red;
            lbl2Position3Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl2Position3Value.ForeColor = Color.Red;
            lbl2Position3Value.ImageAlign = ContentAlignment.TopLeft;
            lbl2Position3Value.Location = new Point(165, 161);
            lbl2Position3Value.Name = "lbl2Position3Value";
            lbl2Position3Value.Size = new Size(16, 24);
            lbl2Position3Value.TabIndex = 406;
            lbl2Position3Value.Text = ".";
            lbl2Position3Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl2Position9
            // 
            lbl2Position9.AutoSize = true;
            lbl2Position9.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position9.ForeColor = Color.White;
            lbl2Position9.Location = new Point(257, 269);
            lbl2Position9.Name = "lbl2Position9";
            lbl2Position9.Size = new Size(244, 20);
            lbl2Position9.TabIndex = 405;
            lbl2Position9.Text = "Ladder Location: OUTPOST";
            lbl2Position9.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl2Position8
            // 
            lbl2Position8.AutoSize = true;
            lbl2Position8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position8.ForeColor = Color.White;
            lbl2Position8.Location = new Point(299, 161);
            lbl2Position8.Name = "lbl2Position8";
            lbl2Position8.Size = new Size(164, 24);
            lbl2Position8.TabIndex = 404;
            lbl2Position8.Text = "Strategy: VALUE";
            lbl2Position8.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl2Position7
            // 
            lbl2Position7.AutoSize = true;
            lbl2Position7.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position7.ForeColor = Color.White;
            lbl2Position7.Location = new Point(3, 266);
            lbl2Position7.Name = "lbl2Position7";
            lbl2Position7.Size = new Size(148, 22);
            lbl2Position7.TabIndex = 402;
            lbl2Position7.Text = "Climb Level: L#";
            // 
            // lbl2Position6
            // 
            lbl2Position6.AutoSize = true;
            lbl2Position6.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position6.ForeColor = Color.White;
            lbl2Position6.Location = new Point(3, 195);
            lbl2Position6.Name = "lbl2Position6";
            lbl2Position6.Size = new Size(179, 22);
            lbl2Position6.TabIndex = 401;
            lbl2Position6.Text = "Avoidance: VALUE";
            // 
            // lbl2Position4
            // 
            lbl2Position4.AutoSize = true;
            lbl2Position4.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position4.ForeColor = Color.White;
            lbl2Position4.Location = new Point(2, 231);
            lbl2Position4.Name = "lbl2Position4";
            lbl2Position4.Size = new Size(66, 22);
            lbl2Position4.TabIndex = 399;
            lbl2Position4.Text = "Climb:";
            // 
            // lbl2Position3
            // 
            lbl2Position3.AutoSize = true;
            lbl2Position3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position3.ForeColor = Color.White;
            lbl2Position3.Location = new Point(3, 161);
            lbl2Position3.Name = "lbl2Position3";
            lbl2Position3.Size = new Size(87, 24);
            lbl2Position3.TabIndex = 399;
            lbl2Position3.Text = "Bump: 0";
            // 
            // lbl2Position2
            // 
            lbl2Position2.AutoSize = true;
            lbl2Position2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position2.ForeColor = Color.White;
            lbl2Position2.Location = new Point(257, 61);
            lbl2Position2.Name = "lbl2Position2";
            lbl2Position2.Size = new Size(221, 24);
            lbl2Position2.TabIndex = 397;
            lbl2Position2.Text = "Shooting Timer: 0:00.0";
            // 
            // lbl2Position1
            // 
            lbl2Position1.AutoSize = true;
            lbl2Position1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position1.ForeColor = Color.White;
            lbl2Position1.Location = new Point(0, 61);
            lbl2Position1.Name = "lbl2Position1";
            lbl2Position1.Size = new Size(193, 24);
            lbl2Position1.TabIndex = 396;
            lbl2Position1.Text = "Intake Timer: 0:00.0";
            // 
            // lbl2Position4Value
            // 
            lbl2Position4Value.AutoSize = true;
            lbl2Position4Value.BackColor = Color.Red;
            lbl2Position4Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl2Position4Value.ForeColor = Color.Red;
            lbl2Position4Value.ImageAlign = ContentAlignment.TopLeft;
            lbl2Position4Value.Location = new Point(77, 231);
            lbl2Position4Value.Name = "lbl2Position4Value";
            lbl2Position4Value.Size = new Size(16, 24);
            lbl2Position4Value.TabIndex = 395;
            lbl2Position4Value.Text = ".";
            lbl2Position4Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl2Position0
            // 
            lbl2Position0.AutoSize = true;
            lbl2Position0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position0.ForeColor = Color.White;
            lbl2Position0.Location = new Point(231, 10);
            lbl2Position0.Name = "lbl2Position0";
            lbl2Position0.Size = new Size(262, 20);
            lbl2Position0.TabIndex = 394;
            lbl2Position0.Text = "Starting Location: Outer Trench";
            lbl2Position0.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl2Divider1
            // 
            lbl2Divider1.BackColor = Color.Red;
            lbl2Divider1.Location = new Point(-5, 119);
            lbl2Divider1.Name = "lbl2Divider1";
            lbl2Divider1.Size = new Size(534, 11);
            lbl2Divider1.TabIndex = 389;
            // 
            // lbl2Divider0
            // 
            lbl2Divider0.BackColor = Color.Red;
            lbl2Divider0.Location = new Point(-5, 40);
            lbl2Divider0.Name = "lbl2Divider0";
            lbl2Divider0.Size = new Size(534, 11);
            lbl2Divider0.TabIndex = 390;
            // 
            // lbl2Divider2
            // 
            lbl2Divider2.BackColor = Color.Red;
            lbl2Divider2.Location = new Point(0, 314);
            lbl2Divider2.Name = "lbl2Divider2";
            lbl2Divider2.Size = new Size(529, 11);
            lbl2Divider2.TabIndex = 279;
            // 
            // lbl2ScoutName
            // 
            lbl2ScoutName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2ScoutName.ForeColor = Color.Goldenrod;
            lbl2ScoutName.Location = new Point(3, 356);
            lbl2ScoutName.Name = "lbl2ScoutName";
            lbl2ScoutName.Size = new Size(158, 27);
            lbl2ScoutName.TabIndex = 293;
            lbl2ScoutName.Text = "Select Name";
            lbl2ScoutName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl2ModeValue
            // 
            lbl2ModeValue.AutoSize = true;
            lbl2ModeValue.BackColor = Color.Black;
            lbl2ModeValue.Font = new Font("Microsoft Sans Serif", 18F);
            lbl2ModeValue.ForeColor = Color.LimeGreen;
            lbl2ModeValue.Location = new Point(1, 3);
            lbl2ModeValue.Name = "lbl2ModeValue";
            lbl2ModeValue.Size = new Size(135, 29);
            lbl2ModeValue.TabIndex = 2;
            lbl2ModeValue.Text = "Auto Mode:";
            // 
            // lbl1Background
            // 
            lbl1Background.BackColor = Color.Black;
            lbl1Background.Controls.Add(lbl1MatchEvent);
            lbl1Background.Controls.Add(lbl1TeamName);
            lbl1Background.Controls.Add(lbl1Position2Value);
            lbl1Background.Controls.Add(lbl1Position3Value);
            lbl1Background.Controls.Add(lbl1Position9);
            lbl1Background.Controls.Add(lbl1Position8);
            lbl1Background.Controls.Add(lbl1Position7);
            lbl1Background.Controls.Add(lbl1Position6);
            lbl1Background.Controls.Add(lbl1Position4);
            lbl1Background.Controls.Add(lbl1Position3);
            lbl1Background.Controls.Add(lbl1Position2);
            lbl1Background.Controls.Add(lbl1Position1);
            lbl1Background.Controls.Add(lbl1Position4Value);
            lbl1Background.Controls.Add(lbl1Position0);
            lbl1Background.Controls.Add(lbl1Divider1);
            lbl1Background.Controls.Add(lbl1Divider0);
            lbl1Background.Controls.Add(lbl1Divider2);
            lbl1Background.Controls.Add(lbl1ScoutName);
            lbl1Background.Controls.Add(lbl1ModeValue);
            lbl1Background.Dock = DockStyle.Fill;
            lbl1Background.Location = new Point(434, 3);
            lbl1Background.Name = "lbl1Background";
            lbl1Background.Size = new Size(425, 373);
            lbl1Background.TabIndex = 1;
            // 
            // lbl1MatchEvent
            // 
            lbl1MatchEvent.AutoSize = true;
            lbl1MatchEvent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1MatchEvent.ForeColor = Color.White;
            lbl1MatchEvent.Location = new Point(3, 328);
            lbl1MatchEvent.Name = "lbl1MatchEvent";
            lbl1MatchEvent.Size = new Size(125, 24);
            lbl1MatchEvent.TabIndex = 408;
            lbl1MatchEvent.Text = "Match Event";
            // 
            // lbl1TeamName
            // 
            lbl1TeamName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl1TeamName.ForeColor = Color.Goldenrod;
            lbl1TeamName.Location = new Point(324, 347);
            lbl1TeamName.Name = "lbl1TeamName";
            lbl1TeamName.Size = new Size(159, 37);
            lbl1TeamName.TabIndex = 409;
            lbl1TeamName.Text = "Team 0";
            lbl1TeamName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl1Position2Value
            // 
            lbl1Position2Value.AutoSize = true;
            lbl1Position2Value.BackColor = Color.Red;
            lbl1Position2Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl1Position2Value.ForeColor = Color.Red;
            lbl1Position2Value.ImageAlign = ContentAlignment.TopLeft;
            lbl1Position2Value.Location = new Point(407, 61);
            lbl1Position2Value.Name = "lbl1Position2Value";
            lbl1Position2Value.Size = new Size(16, 24);
            lbl1Position2Value.TabIndex = 407;
            lbl1Position2Value.Text = ".";
            lbl1Position2Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl1Position3Value
            // 
            lbl1Position3Value.AutoSize = true;
            lbl1Position3Value.BackColor = Color.Red;
            lbl1Position3Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl1Position3Value.ForeColor = Color.Red;
            lbl1Position3Value.ImageAlign = ContentAlignment.TopLeft;
            lbl1Position3Value.Location = new Point(165, 161);
            lbl1Position3Value.Name = "lbl1Position3Value";
            lbl1Position3Value.Size = new Size(16, 24);
            lbl1Position3Value.TabIndex = 406;
            lbl1Position3Value.Text = ".";
            lbl1Position3Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl1Position9
            // 
            lbl1Position9.AutoSize = true;
            lbl1Position9.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position9.ForeColor = Color.White;
            lbl1Position9.Location = new Point(257, 269);
            lbl1Position9.Name = "lbl1Position9";
            lbl1Position9.Size = new Size(244, 20);
            lbl1Position9.TabIndex = 405;
            lbl1Position9.Text = "Ladder Location: OUTPOST";
            lbl1Position9.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl1Position8
            // 
            lbl1Position8.AutoSize = true;
            lbl1Position8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position8.ForeColor = Color.White;
            lbl1Position8.Location = new Point(299, 161);
            lbl1Position8.Name = "lbl1Position8";
            lbl1Position8.Size = new Size(164, 24);
            lbl1Position8.TabIndex = 404;
            lbl1Position8.Text = "Strategy: VALUE";
            lbl1Position8.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl1Position7
            // 
            lbl1Position7.AutoSize = true;
            lbl1Position7.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position7.ForeColor = Color.White;
            lbl1Position7.Location = new Point(3, 266);
            lbl1Position7.Name = "lbl1Position7";
            lbl1Position7.Size = new Size(148, 22);
            lbl1Position7.TabIndex = 402;
            lbl1Position7.Text = "Climb Level: L#";
            // 
            // lbl1Position6
            // 
            lbl1Position6.AutoSize = true;
            lbl1Position6.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position6.ForeColor = Color.White;
            lbl1Position6.Location = new Point(3, 195);
            lbl1Position6.Name = "lbl1Position6";
            lbl1Position6.Size = new Size(179, 22);
            lbl1Position6.TabIndex = 401;
            lbl1Position6.Text = "Avoidance: VALUE";
            // 
            // lbl1Position4
            // 
            lbl1Position4.AutoSize = true;
            lbl1Position4.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position4.ForeColor = Color.White;
            lbl1Position4.Location = new Point(2, 231);
            lbl1Position4.Name = "lbl1Position4";
            lbl1Position4.Size = new Size(66, 22);
            lbl1Position4.TabIndex = 399;
            lbl1Position4.Text = "Climb:";
            // 
            // lbl1Position3
            // 
            lbl1Position3.AutoSize = true;
            lbl1Position3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position3.ForeColor = Color.White;
            lbl1Position3.Location = new Point(3, 161);
            lbl1Position3.Name = "lbl1Position3";
            lbl1Position3.Size = new Size(87, 24);
            lbl1Position3.TabIndex = 399;
            lbl1Position3.Text = "Bump: 0";
            // 
            // lbl1Position2
            // 
            lbl1Position2.AutoSize = true;
            lbl1Position2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position2.ForeColor = Color.White;
            lbl1Position2.Location = new Point(257, 61);
            lbl1Position2.Name = "lbl1Position2";
            lbl1Position2.Size = new Size(221, 24);
            lbl1Position2.TabIndex = 397;
            lbl1Position2.Text = "Shooting Timer: 0:00.0";
            // 
            // lbl1Position1
            // 
            lbl1Position1.AutoSize = true;
            lbl1Position1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position1.ForeColor = Color.White;
            lbl1Position1.Location = new Point(0, 61);
            lbl1Position1.Name = "lbl1Position1";
            lbl1Position1.Size = new Size(193, 24);
            lbl1Position1.TabIndex = 396;
            lbl1Position1.Text = "Intake Timer: 0:00.0";
            // 
            // lbl1Position4Value
            // 
            lbl1Position4Value.AutoSize = true;
            lbl1Position4Value.BackColor = Color.Red;
            lbl1Position4Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl1Position4Value.ForeColor = Color.Red;
            lbl1Position4Value.ImageAlign = ContentAlignment.TopLeft;
            lbl1Position4Value.Location = new Point(77, 231);
            lbl1Position4Value.Name = "lbl1Position4Value";
            lbl1Position4Value.Size = new Size(16, 24);
            lbl1Position4Value.TabIndex = 395;
            lbl1Position4Value.Text = ".";
            lbl1Position4Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl1Position0
            // 
            lbl1Position0.AutoSize = true;
            lbl1Position0.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position0.ForeColor = Color.White;
            lbl1Position0.Location = new Point(231, 10);
            lbl1Position0.Name = "lbl1Position0";
            lbl1Position0.Size = new Size(262, 20);
            lbl1Position0.TabIndex = 394;
            lbl1Position0.Text = "Starting Location: Outer Trench";
            lbl1Position0.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl1Divider1
            // 
            lbl1Divider1.BackColor = Color.Red;
            lbl1Divider1.Location = new Point(-5, 119);
            lbl1Divider1.Name = "lbl1Divider1";
            lbl1Divider1.Size = new Size(534, 11);
            lbl1Divider1.TabIndex = 389;
            // 
            // lbl1Divider0
            // 
            lbl1Divider0.BackColor = Color.Red;
            lbl1Divider0.Location = new Point(-5, 40);
            lbl1Divider0.Name = "lbl1Divider0";
            lbl1Divider0.Size = new Size(534, 11);
            lbl1Divider0.TabIndex = 390;
            // 
            // lbl1Divider2
            // 
            lbl1Divider2.BackColor = Color.Red;
            lbl1Divider2.Location = new Point(0, 314);
            lbl1Divider2.Name = "lbl1Divider2";
            lbl1Divider2.Size = new Size(529, 11);
            lbl1Divider2.TabIndex = 279;
            // 
            // lbl1ScoutName
            // 
            lbl1ScoutName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1ScoutName.ForeColor = Color.Goldenrod;
            lbl1ScoutName.Location = new Point(3, 356);
            lbl1ScoutName.Name = "lbl1ScoutName";
            lbl1ScoutName.Size = new Size(158, 27);
            lbl1ScoutName.TabIndex = 293;
            lbl1ScoutName.Text = "Select Name";
            lbl1ScoutName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl1ModeValue
            // 
            lbl1ModeValue.AutoSize = true;
            lbl1ModeValue.BackColor = Color.Black;
            lbl1ModeValue.Font = new Font("Microsoft Sans Serif", 18F);
            lbl1ModeValue.ForeColor = Color.LimeGreen;
            lbl1ModeValue.Location = new Point(1, 3);
            lbl1ModeValue.Name = "lbl1ModeValue";
            lbl1ModeValue.Size = new Size(135, 29);
            lbl1ModeValue.TabIndex = 2;
            lbl1ModeValue.Text = "Auto Mode:";
            // 
            // lbl0Background
            // 
            lbl0Background.BackColor = Color.Black;
            lbl0Background.Controls.Add(lbl0Divider0);
            lbl0Background.Controls.Add(lbl0Position2Value);
            lbl0Background.Controls.Add(lbl0Position3Value);
            lbl0Background.Controls.Add(lbl0Position9);
            lbl0Background.Controls.Add(lbl0Position8);
            lbl0Background.Controls.Add(lbl0Position7);
            lbl0Background.Controls.Add(lbl0Position6);
            lbl0Background.Controls.Add(lbl0Position4);
            lbl0Background.Controls.Add(lbl0Position3);
            lbl0Background.Controls.Add(lbl0Position2);
            lbl0Background.Controls.Add(lbl0Position1);
            lbl0Background.Controls.Add(lbl0Position4Value);
            lbl0Background.Controls.Add(lbl0Position0);
            lbl0Background.Controls.Add(lbl0Divider1);
            lbl0Background.Controls.Add(lbl0Divider2);
            lbl0Background.Controls.Add(lbl0MatchEvent);
            lbl0Background.Controls.Add(lbl0TeamName);
            lbl0Background.Controls.Add(lbl0ScoutName);
            lbl0Background.Controls.Add(lbl0ModeValue);
            lbl0Background.Dock = DockStyle.Fill;
            lbl0Background.Location = new Point(3, 3);
            lbl0Background.Name = "lbl0Background";
            lbl0Background.Size = new Size(425, 373);
            lbl0Background.TabIndex = 0;
            // 
            // lbl0Divider0
            // 
            lbl0Divider0.BackColor = Color.Red;
            lbl0Divider0.Location = new Point(-1, 40);
            lbl0Divider0.Name = "lbl0Divider0";
            lbl0Divider0.Size = new Size(534, 11);
            lbl0Divider0.TabIndex = 408;
            // 
            // lbl0Position2Value
            // 
            lbl0Position2Value.AutoSize = true;
            lbl0Position2Value.BackColor = Color.Red;
            lbl0Position2Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl0Position2Value.ForeColor = Color.Red;
            lbl0Position2Value.ImageAlign = ContentAlignment.TopLeft;
            lbl0Position2Value.Location = new Point(407, 61);
            lbl0Position2Value.Name = "lbl0Position2Value";
            lbl0Position2Value.Size = new Size(16, 24);
            lbl0Position2Value.TabIndex = 407;
            lbl0Position2Value.Text = ".";
            lbl0Position2Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl0Position3Value
            // 
            lbl0Position3Value.AutoSize = true;
            lbl0Position3Value.BackColor = Color.Red;
            lbl0Position3Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl0Position3Value.ForeColor = Color.Red;
            lbl0Position3Value.ImageAlign = ContentAlignment.TopLeft;
            lbl0Position3Value.Location = new Point(165, 161);
            lbl0Position3Value.Name = "lbl0Position3Value";
            lbl0Position3Value.Size = new Size(16, 24);
            lbl0Position3Value.TabIndex = 406;
            lbl0Position3Value.Text = ".";
            lbl0Position3Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl0Position9
            // 
            lbl0Position9.AutoSize = true;
            lbl0Position9.Font = new Font("Microsoft Sans Serif", 12.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position9.ForeColor = Color.White;
            lbl0Position9.Location = new Point(257, 269);
            lbl0Position9.Name = "lbl0Position9";
            lbl0Position9.Size = new Size(244, 20);
            lbl0Position9.TabIndex = 405;
            lbl0Position9.Text = "Ladder Location: OUTPOST";
            lbl0Position9.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl0Position8
            // 
            lbl0Position8.AutoSize = true;
            lbl0Position8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position8.ForeColor = Color.White;
            lbl0Position8.Location = new Point(299, 161);
            lbl0Position8.Name = "lbl0Position8";
            lbl0Position8.Size = new Size(164, 24);
            lbl0Position8.TabIndex = 404;
            lbl0Position8.Text = "Strategy: VALUE";
            lbl0Position8.TextAlign = ContentAlignment.TopRight;
            // 
            // lbl0Position7
            // 
            lbl0Position7.AutoSize = true;
            lbl0Position7.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position7.ForeColor = Color.White;
            lbl0Position7.Location = new Point(3, 266);
            lbl0Position7.Name = "lbl0Position7";
            lbl0Position7.Size = new Size(148, 22);
            lbl0Position7.TabIndex = 402;
            lbl0Position7.Text = "Climb Level: L#";
            // 
            // lbl0Position6
            // 
            lbl0Position6.AutoSize = true;
            lbl0Position6.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position6.ForeColor = Color.White;
            lbl0Position6.Location = new Point(3, 195);
            lbl0Position6.Name = "lbl0Position6";
            lbl0Position6.Size = new Size(179, 22);
            lbl0Position6.TabIndex = 401;
            lbl0Position6.Text = "Avoidance: VALUE";
            // 
            // lbl0Position4
            // 
            lbl0Position4.AutoSize = true;
            lbl0Position4.Font = new Font("Microsoft Sans Serif", 13.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position4.ForeColor = Color.White;
            lbl0Position4.Location = new Point(2, 231);
            lbl0Position4.Name = "lbl0Position4";
            lbl0Position4.Size = new Size(66, 22);
            lbl0Position4.TabIndex = 399;
            lbl0Position4.Text = "Climb:";
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
            lbl0Position4Value.Location = new Point(77, 231);
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
            lbl0Position0.Location = new Point(231, 10);
            lbl0Position0.Name = "lbl0Position0";
            lbl0Position0.Size = new Size(262, 20);
            lbl0Position0.TabIndex = 394;
            lbl0Position0.Text = "Starting Location: Outer Trench";
            // 
            // lbl0Divider1
            // 
            lbl0Divider1.BackColor = Color.Red;
            lbl0Divider1.Location = new Point(-5, 119);
            lbl0Divider1.Name = "lbl0Divider1";
            lbl0Divider1.Size = new Size(534, 11);
            lbl0Divider1.TabIndex = 389;
            // 
            // lbl0Divider2
            // 
            lbl0Divider2.BackColor = Color.Red;
            lbl0Divider2.Location = new Point(0, 314);
            lbl0Divider2.Name = "lbl0Divider2";
            lbl0Divider2.Size = new Size(529, 11);
            lbl0Divider2.TabIndex = 279;
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
            lbl0ModeValue.Size = new Size(135, 29);
            lbl0ModeValue.TabIndex = 2;
            lbl0ModeValue.Text = "Auto Mode:";
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
            topPanel.Size = new Size(1294, 44);
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
            tableLayoutPanel.Size = new Size(1300, 820);
            tableLayoutPanel.TabIndex = 0;
            // 
            // BaseScreen
            // 
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(1300, 820);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseScreen";
            WindowState = FormWindowState.Maximized;
            blueTeams.ResumeLayout(false);
            lbl5Background.ResumeLayout(false);
            lbl5Background.PerformLayout();
            lbl4Background.ResumeLayout(false);
            lbl4Background.PerformLayout();
            lbl3Background.ResumeLayout(false);
            lbl3Background.PerformLayout();
            redTeams.ResumeLayout(false);
            lbl2Background.ResumeLayout(false);
            lbl2Background.PerformLayout();
            lbl1Background.ResumeLayout(false);
            lbl1Background.PerformLayout();
            lbl0Background.ResumeLayout(false);
            lbl0Background.PerformLayout();
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
        private Panel lbl0Background;
        private Panel lbl0Divider2;
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
        private Panel lbl0Divider1;
        private Label lblBlueScore;
        private Label lblRedScore;
        private Panel statusLight;
        private Panel topPanel;
        private Label lbl0Position1;
        private Label lbl0Position2;
        private Label lbl0Position3;
        private Label lbl0Position4;
        private Label lbl0Position6;
        private Label lbl0Position7;
        private Label lbl0Position9;
        private Label lbl0Position8;
        private Label lbl0Position3Value;
        private Label lbl0Position2Value;
        private Panel lbl1Background;
        private Label lbl1Position2Value;
        private Label lbl1Position3Value;
        private Label lbl1Position9;
        private Label lbl1Position8;
        private Label lbl1Position7;
        private Label lbl1Position6;
        private Label lbl1Position4;
        private Label lbl1Position3;
        private Label lbl1Position2;
        private Label lbl1Position1;
        private Label lbl1Position4Value;
        private Label lbl1Position0;
        private Panel lbl1Divider1;
        private Panel lbl1Divider0;
        private Panel lbl1Divider2;
        private Label lbl1ScoutName;
        private Label lbl1ModeValue;
        private Panel lbl5Background;
        private Label lbl5Position2Value;
        private Label lbl5Position3Value;
        private Label lbl5Position9;
        private Label lbl5Position8;
        private Label lbl5Position7;
        private Label lbl5Position6;
        private Label lbl5Position4;
        private Label lbl5Position3;
        private Label lbl5Position2;
        private Label lbl5Position1;
        private Label lbl5Position4Value;
        private Label lbl5Position0;
        private Panel lbl5Divider1;
        private Panel lbl5Divider0;
        private Panel lbl5Divider2;
        private Label lbl5MatchEvent;
        private Label lbl5TeamName;
        private Label lbl5ScoutName;
        private Label lbl5ModeValue;
        private Panel lbl4Background;
        private Label lbl4Position2Value;
        private Label lbl4Position3Value;
        private Label lbl4Position9;
        private Label lbl4Position8;
        private Label lbl4Position7;
        private Label lbl4Position6;
        private Label lbl4Position4;
        private Label lbl4Position3;
        private Label lbl4Position2;
        private Label lbl4Position1;
        private Label lbl4Position4Value;
        private Label lbl4Position0;
        private Panel lbl4Divider1;
        private Panel lbl4Divider0;
        private Panel lbl4Divider2;
        private Label lbl4MatchEvent;
        private Label lbl4TeamName;
        private Label lbl4ScoutName;
        private Label lbl4ModeValue;
        private Panel lbl3Background;
        private Label lbl3Position2Value;
        private Label lbl3Position3Value;
        private Label lbl3Position9;
        private Label lbl3Position8;
        private Label lbl3Position7;
        private Label lbl3Position6;
        private Label lbl3Position4;
        private Label lbl3Position3;
        private Label lbl3Position2;
        private Label lbl3Position1;
        private Label lbl3Position4Value;
        private Label lbl3Position0;
        private Panel lbl3Divider1;
        private Panel lbl3Divider0;
        private Panel lbl3Divider2;
        private Label lbl3MatchEvent;
        private Label lbl3TeamName;
        private Label lbl3ScoutName;
        private Label lbl3ModeValue;
        private Panel lbl2Background;
        private Label lbl2MatchEvent;
        private Label lbl2TeamName;
        private Label lbl2Position2Value;
        private Label lbl2Position3Value;
        private Label lbl2Position9;
        private Label lbl2Position8;
        private Label lbl2Position7;
        private Label lbl2Position6;
        private Label lbl2Position4;
        private Label lbl2Position3;
        private Label lbl2Position2;
        private Label lbl2Position1;
        private Label lbl2Position4Value;
        private Label lbl2Position0;
        private Panel lbl2Divider1;
        private Panel lbl2Divider0;
        private Panel lbl2Divider2;
        private Label lbl2ScoutName;
        private Label lbl2ModeValue;
        private Label lbl1MatchEvent;
        private Label lbl1TeamName;
        private Panel lbl0Divider0;
    }
}
