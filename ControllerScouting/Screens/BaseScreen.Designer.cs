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
            team3 = new Panel();
            lbl3Position0Value = new Label();
            lbl3Position0 = new Label();
            lbl3Position12Value = new Label();
            lbl3Position12 = new Label();
            lbl3Position11Value = new Label();
            lbl3Position11 = new Label();
            lbl3Position8Value = new Label();
            lbl3Position8 = new Label();
            lbl3Position7Value = new Label();
            lbl3Position7 = new Label();
            lbl3Position5Value = new Label();
            lbl3Position5 = new Label();
            lbl3Position4Value = new Label();
            lbl3Position4 = new Label();
            lbl3Position3Des = new Label();
            lbl3Position3Source = new Label();
            lbl3Position2Des = new Label();
            lbl3Position2Source = new Label();
            lbl3Position1 = new Label();
            lbl3Position3Value = new Label();
            lbl3Position3 = new Label();
            lbl3Position2Value = new Label();
            lbl3Position2 = new Label();
            team3Divider = new Panel();
            team3ModeDivider = new Panel();
            lbl3MatchEvent = new Label();
            lbl3TeamName = new Label();
            lbl3ScoutName = new Label();
            lbl3ModeValue = new Label();
            team3TeamDivider = new Panel();
            team4 = new Panel();
            lbl4Position0Value = new Label();
            lbl4Position0 = new Label();
            lbl4Position12Value = new Label();
            lbl4Position12 = new Label();
            lbl4Position11Value = new Label();
            lbl4Position11 = new Label();
            lbl4Position8Value = new Label();
            lbl4Position8 = new Label();
            lbl4Position7Value = new Label();
            lbl4Position7 = new Label();
            lbl4Position5Value = new Label();
            lbl4Position5 = new Label();
            lbl4Position4Value = new Label();
            lbl4Position4 = new Label();
            lbl4Position3Des = new Label();
            lbl4Position3Source = new Label();
            lbl4Position2Des = new Label();
            lbl4Position2Source = new Label();
            lbl4Position1 = new Label();
            lbl4Position3Value = new Label();
            lbl4Position3 = new Label();
            lbl4Position2Value = new Label();
            lbl4Position2 = new Label();
            team4Divider = new Panel();
            team4ModeDivider = new Panel();
            lbl4MatchEvent = new Label();
            lbl4TeamName = new Label();
            lbl4ScoutName = new Label();
            lbl4ModeValue = new Label();
            team4TeamDivider = new Panel();
            team5 = new Panel();
            lbl5Position0Value = new Label();
            lbl5Position0 = new Label();
            lbl5Position12Value = new Label();
            lbl5Position12 = new Label();
            lbl5Position11Value = new Label();
            lbl5Position11 = new Label();
            lbl5Position8Value = new Label();
            lbl5Position8 = new Label();
            lbl5Position7Value = new Label();
            lbl5Position7 = new Label();
            lbl5Position5Value = new Label();
            lbl5Position5 = new Label();
            lbl5Position4Value = new Label();
            lbl5Position4 = new Label();
            lbl5Position3Des = new Label();
            lbl5Position3Source = new Label();
            lbl5Position2Des = new Label();
            lbl5Position2Source = new Label();
            lbl5Position1 = new Label();
            lbl5Position3Value = new Label();
            lbl5Position3 = new Label();
            lbl5Position2Value = new Label();
            lbl5Position2 = new Label();
            team5Divider = new Panel();
            team5ModeDivider = new Panel();
            lbl5MatchEvent = new Label();
            lbl5TeamName = new Label();
            lbl5ScoutName = new Label();
            lbl5ModeValue = new Label();
            team5TeamDivider = new Panel();
            redTeams = new TableLayoutPanel();
            team0 = new Panel();
            lbl0Position0Value = new Label();
            lbl0Position0 = new Label();
            lbl0Position12Value = new Label();
            lbl0Position12 = new Label();
            lbl0Position11Value = new Label();
            lbl0Position11 = new Label();
            lbl0Position8Value = new Label();
            lbl0Position8 = new Label();
            lbl0Position7Value = new Label();
            lbl0Position7 = new Label();
            lbl0Position5Value = new Label();
            lbl0Position5 = new Label();
            lbl0Position4Value = new Label();
            lbl0Position4 = new Label();
            lbl0Position3Des = new Label();
            lbl0Position3Source = new Label();
            lbl0Position2Des = new Label();
            lbl0Position2Source = new Label();
            lbl0Position1 = new Label();
            lbl0Position3Value = new Label();
            lbl0Position3 = new Label();
            lbl0Position2Value = new Label();
            lbl0Position2 = new Label();
            team0Divider = new Panel();
            team0ModeDivider = new Panel();
            team0TeamDivider = new Panel();
            lbl0MatchEvent = new Label();
            lbl0TeamName = new Label();
            lbl0ScoutName = new Label();
            lbl0ModeValue = new Label();
            team1 = new Panel();
            lbl1Position0Value = new Label();
            lbl1Position0 = new Label();
            lbl1Position12Value = new Label();
            lbl1Position12 = new Label();
            lbl1Position11Value = new Label();
            lbl1Position11 = new Label();
            lbl1Position8Value = new Label();
            lbl1Position8 = new Label();
            lbl1Position7Value = new Label();
            lbl1Position7 = new Label();
            lbl1Position5Value = new Label();
            lbl1Position5 = new Label();
            lbl1Position4Value = new Label();
            lbl1Position4 = new Label();
            lbl1Position3Des = new Label();
            lbl1Position3Source = new Label();
            lbl1Position2Des = new Label();
            lbl1Position2Source = new Label();
            lbl1Position1 = new Label();
            lbl1Position3Value = new Label();
            lbl1Position3 = new Label();
            lbl1Position2Value = new Label();
            lbl1Position2 = new Label();
            team1Divider = new Panel();
            team1ModeDivider = new Panel();
            team1TeamDivider = new Panel();
            lbl1MatchEvent = new Label();
            lbl1TeamName = new Label();
            lbl1ScoutName = new Label();
            lbl1ModeValue = new Label();
            team2 = new Panel();
            lbl2Position0Value = new Label();
            lbl2Position0 = new Label();
            lbl2Position12Value = new Label();
            lbl2Position12 = new Label();
            lbl2Position11Value = new Label();
            lbl2Position11 = new Label();
            lbl2Position8Value = new Label();
            lbl2Position8 = new Label();
            lbl2Position7Value = new Label();
            lbl2Position7 = new Label();
            lbl2Position5Value = new Label();
            lbl2Position5 = new Label();
            lbl2Position4Value = new Label();
            lbl2Position4 = new Label();
            lbl2Position3Des = new Label();
            lbl2Position3Source = new Label();
            lbl2Position2Des = new Label();
            lbl2Position2Source = new Label();
            lbl2Position1 = new Label();
            lbl2Position3Value = new Label();
            lbl2Position3 = new Label();
            lbl2Position2Value = new Label();
            lbl2Position2 = new Label();
            team2Divider = new Panel();
            team2ModeDivider = new Panel();
            team2TeamDivider = new Panel();
            lbl2MatchEvent = new Label();
            lbl2TeamName = new Label();
            lbl2ScoutName = new Label();
            lbl2ModeValue = new Label();
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
            team3.SuspendLayout();
            team4.SuspendLayout();
            team5.SuspendLayout();
            redTeams.SuspendLayout();
            team0.SuspendLayout();
            team1.SuspendLayout();
            team2.SuspendLayout();
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
            blueTeams.Controls.Add(team3, 0, 0);
            blueTeams.Controls.Add(team4, 1, 0);
            blueTeams.Controls.Add(team5, 2, 0);
            blueTeams.Dock = DockStyle.Fill;
            blueTeams.Location = new Point(3, 464);
            blueTeams.Name = "blueTeams";
            blueTeams.RowCount = 1;
            blueTeams.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            blueTeams.Size = new Size(1454, 405);
            blueTeams.TabIndex = 0;
            // 
            // team3
            // 
            team3.BackColor = Color.Black;
            team3.Controls.Add(lbl3Position0Value);
            team3.Controls.Add(lbl3Position0);
            team3.Controls.Add(lbl3Position12Value);
            team3.Controls.Add(lbl3Position12);
            team3.Controls.Add(lbl3Position11Value);
            team3.Controls.Add(lbl3Position11);
            team3.Controls.Add(lbl3Position8Value);
            team3.Controls.Add(lbl3Position8);
            team3.Controls.Add(lbl3Position7Value);
            team3.Controls.Add(lbl3Position7);
            team3.Controls.Add(lbl3Position5Value);
            team3.Controls.Add(lbl3Position5);
            team3.Controls.Add(lbl3Position4Value);
            team3.Controls.Add(lbl3Position4);
            team3.Controls.Add(lbl3Position3Des);
            team3.Controls.Add(lbl3Position3Source);
            team3.Controls.Add(lbl3Position2Des);
            team3.Controls.Add(lbl3Position2Source);
            team3.Controls.Add(lbl3Position1);
            team3.Controls.Add(lbl3Position3Value);
            team3.Controls.Add(lbl3Position3);
            team3.Controls.Add(lbl3Position2Value);
            team3.Controls.Add(lbl3Position2);
            team3.Controls.Add(team3Divider);
            team3.Controls.Add(team3ModeDivider);
            team3.Controls.Add(lbl3MatchEvent);
            team3.Controls.Add(lbl3TeamName);
            team3.Controls.Add(lbl3ScoutName);
            team3.Controls.Add(lbl3ModeValue);
            team3.Controls.Add(team3TeamDivider);
            team3.Dock = DockStyle.Fill;
            team3.Location = new Point(3, 3);
            team3.Name = "team3";
            team3.Size = new Size(478, 399);
            team3.TabIndex = 347;
            // 
            // lbl3Position0Value
            // 
            lbl3Position0Value.AutoSize = true;
            lbl3Position0Value.BackColor = Color.Red;
            lbl3Position0Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl3Position0Value.ForeColor = Color.Red;
            lbl3Position0Value.ImageAlign = ContentAlignment.TopLeft;
            lbl3Position0Value.Location = new Point(72, 55);
            lbl3Position0Value.Name = "lbl3Position0Value";
            lbl3Position0Value.Size = new Size(16, 24);
            lbl3Position0Value.TabIndex = 393;
            lbl3Position0Value.Text = ".";
            lbl3Position0Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl3Position0
            // 
            lbl3Position0.AutoSize = true;
            lbl3Position0.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position0.ForeColor = Color.White;
            lbl3Position0.Location = new Point(2, 55);
            lbl3Position0.Name = "lbl3Position0";
            lbl3Position0.Size = new Size(66, 24);
            lbl3Position0.TabIndex = 387;
            lbl3Position0.Text = "Leave";
            // 
            // lbl3Position12Value
            // 
            lbl3Position12Value.AutoSize = true;
            lbl3Position12Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position12Value.ForeColor = Color.White;
            lbl3Position12Value.Location = new Point(52, 273);
            lbl3Position12Value.Name = "lbl3Position12Value";
            lbl3Position12Value.Size = new Size(21, 24);
            lbl3Position12Value.TabIndex = 411;
            lbl3Position12Value.Text = "9";
            // 
            // lbl3Position12
            // 
            lbl3Position12.AutoSize = true;
            lbl3Position12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position12.ForeColor = Color.White;
            lbl3Position12.Location = new Point(2, 272);
            lbl3Position12.Name = "lbl3Position12";
            lbl3Position12.Size = new Size(57, 24);
            lbl3Position12.TabIndex = 410;
            lbl3Position12.Text = "Strat:";
            // 
            // lbl3Position11Value
            // 
            lbl3Position11Value.AutoSize = true;
            lbl3Position11Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position11Value.ForeColor = Color.White;
            lbl3Position11Value.Location = new Point(90, 245);
            lbl3Position11Value.Name = "lbl3Position11Value";
            lbl3Position11Value.Size = new Size(21, 24);
            lbl3Position11Value.TabIndex = 409;
            lbl3Position11Value.Text = "9";
            // 
            // lbl3Position11
            // 
            lbl3Position11.AutoSize = true;
            lbl3Position11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position11.ForeColor = Color.White;
            lbl3Position11.Location = new Point(2, 245);
            lbl3Position11.Name = "lbl3Position11";
            lbl3Position11.Size = new Size(86, 24);
            lbl3Position11.TabIndex = 408;
            lbl3Position11.Text = "Attempt:";
            // 
            // lbl3Position8Value
            // 
            lbl3Position8Value.AutoSize = true;
            lbl3Position8Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position8Value.ForeColor = Color.White;
            lbl3Position8Value.Location = new Point(379, 228);
            lbl3Position8Value.Name = "lbl3Position8Value";
            lbl3Position8Value.Size = new Size(21, 24);
            lbl3Position8Value.TabIndex = 403;
            lbl3Position8Value.Text = "9";
            // 
            // lbl3Position8
            // 
            lbl3Position8.AutoSize = true;
            lbl3Position8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position8.ForeColor = Color.White;
            lbl3Position8.Location = new Point(315, 227);
            lbl3Position8.Name = "lbl3Position8";
            lbl3Position8.Size = new Size(69, 24);
            lbl3Position8.TabIndex = 402;
            lbl3Position8.Text = "Avoid:";
            // 
            // lbl3Position7Value
            // 
            lbl3Position7Value.AutoSize = true;
            lbl3Position7Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position7Value.ForeColor = Color.White;
            lbl3Position7Value.Location = new Point(316, 274);
            lbl3Position7Value.Name = "lbl3Position7Value";
            lbl3Position7Value.Size = new Size(21, 24);
            lbl3Position7Value.TabIndex = 407;
            lbl3Position7Value.Text = "9";
            // 
            // lbl3Position7
            // 
            lbl3Position7.AutoSize = true;
            lbl3Position7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position7.ForeColor = Color.White;
            lbl3Position7.Location = new Point(281, 273);
            lbl3Position7.Name = "lbl3Position7";
            lbl3Position7.Size = new Size(40, 24);
            lbl3Position7.TabIndex = 406;
            lbl3Position7.Text = "Eff:";
            // 
            // lbl3Position5Value
            // 
            lbl3Position5Value.AutoSize = true;
            lbl3Position5Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position5Value.ForeColor = Color.White;
            lbl3Position5Value.Location = new Point(215, 226);
            lbl3Position5Value.Name = "lbl3Position5Value";
            lbl3Position5Value.Size = new Size(21, 24);
            lbl3Position5Value.TabIndex = 401;
            lbl3Position5Value.Text = "9";
            lbl3Position5Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl3Position5
            // 
            lbl3Position5.AutoSize = true;
            lbl3Position5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position5.ForeColor = Color.White;
            lbl3Position5.Location = new Point(163, 226);
            lbl3Position5.Name = "lbl3Position5";
            lbl3Position5.Size = new Size(47, 24);
            lbl3Position5.TabIndex = 400;
            lbl3Position5.Text = "Def:";
            lbl3Position5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl3Position4Value
            // 
            lbl3Position4Value.AutoSize = true;
            lbl3Position4Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position4Value.ForeColor = Color.White;
            lbl3Position4Value.Location = new Point(345, 178);
            lbl3Position4Value.Name = "lbl3Position4Value";
            lbl3Position4Value.Size = new Size(21, 24);
            lbl3Position4Value.TabIndex = 399;
            lbl3Position4Value.Text = "9";
            // 
            // lbl3Position4
            // 
            lbl3Position4.AutoSize = true;
            lbl3Position4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position4.ForeColor = Color.White;
            lbl3Position4.Location = new Point(243, 177);
            lbl3Position4.Name = "lbl3Position4";
            lbl3Position4.Size = new Size(106, 24);
            lbl3Position4.TabIndex = 398;
            lbl3Position4.Text = "End State:";
            // 
            // lbl3Position3Des
            // 
            lbl3Position3Des.AutoSize = true;
            lbl3Position3Des.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position3Des.ForeColor = Color.White;
            lbl3Position3Des.Location = new Point(176, 150);
            lbl3Position3Des.Name = "lbl3Position3Des";
            lbl3Position3Des.Size = new Size(59, 24);
            lbl3Position3Des.TabIndex = 397;
            lbl3Position3Des.Text = "Floor";
            // 
            // lbl3Position3Source
            // 
            lbl3Position3Source.AutoSize = true;
            lbl3Position3Source.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position3Source.ForeColor = Color.White;
            lbl3Position3Source.Location = new Point(103, 150);
            lbl3Position3Source.Name = "lbl3Position3Source";
            lbl3Position3Source.Size = new Size(59, 24);
            lbl3Position3Source.TabIndex = 405;
            lbl3Position3Source.Text = "Floor";
            // 
            // lbl3Position2Des
            // 
            lbl3Position2Des.AutoSize = true;
            lbl3Position2Des.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position2Des.ForeColor = Color.White;
            lbl3Position2Des.Location = new Point(176, 112);
            lbl3Position2Des.Name = "lbl3Position2Des";
            lbl3Position2Des.Size = new Size(59, 24);
            lbl3Position2Des.TabIndex = 396;
            lbl3Position2Des.Text = "Floor";
            // 
            // lbl3Position2Source
            // 
            lbl3Position2Source.AutoSize = true;
            lbl3Position2Source.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position2Source.ForeColor = Color.White;
            lbl3Position2Source.Location = new Point(103, 112);
            lbl3Position2Source.Name = "lbl3Position2Source";
            lbl3Position2Source.Size = new Size(73, 24);
            lbl3Position2Source.TabIndex = 404;
            lbl3Position2Source.Text = "Station";
            // 
            // lbl3Position1
            // 
            lbl3Position1.AutoSize = true;
            lbl3Position1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position1.ForeColor = Color.White;
            lbl3Position1.Location = new Point(245, 56);
            lbl3Position1.Name = "lbl3Position1";
            lbl3Position1.Size = new Size(103, 24);
            lbl3Position1.TabIndex = 388;
            lbl3Position1.Text = "Near Side";
            // 
            // lbl3Position3Value
            // 
            lbl3Position3Value.AutoSize = true;
            lbl3Position3Value.BackColor = Color.Red;
            lbl3Position3Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl3Position3Value.ForeColor = Color.Red;
            lbl3Position3Value.ImageAlign = ContentAlignment.TopLeft;
            lbl3Position3Value.Location = new Point(72, 150);
            lbl3Position3Value.Name = "lbl3Position3Value";
            lbl3Position3Value.Size = new Size(16, 24);
            lbl3Position3Value.TabIndex = 395;
            lbl3Position3Value.Text = ".";
            lbl3Position3Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl3Position3
            // 
            lbl3Position3.AutoSize = true;
            lbl3Position3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position3.ForeColor = Color.White;
            lbl3Position3.Location = new Point(2, 148);
            lbl3Position3.Name = "lbl3Position3";
            lbl3Position3.Size = new Size(70, 24);
            lbl3Position3.TabIndex = 394;
            lbl3Position3.Text = "Algae:";
            // 
            // lbl3Position2Value
            // 
            lbl3Position2Value.AutoSize = true;
            lbl3Position2Value.BackColor = Color.Red;
            lbl3Position2Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl3Position2Value.ForeColor = Color.Red;
            lbl3Position2Value.ImageAlign = ContentAlignment.TopLeft;
            lbl3Position2Value.Location = new Point(72, 109);
            lbl3Position2Value.Name = "lbl3Position2Value";
            lbl3Position2Value.Size = new Size(16, 24);
            lbl3Position2Value.TabIndex = 392;
            lbl3Position2Value.Text = ".";
            lbl3Position2Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl3Position2
            // 
            lbl3Position2.AutoSize = true;
            lbl3Position2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3Position2.ForeColor = Color.White;
            lbl3Position2.Location = new Point(2, 110);
            lbl3Position2.Name = "lbl3Position2";
            lbl3Position2.Size = new Size(65, 24);
            lbl3Position2.TabIndex = 391;
            lbl3Position2.Text = "Coral:";
            // 
            // team3Divider
            // 
            team3Divider.BackColor = Color.Blue;
            team3Divider.Location = new Point(-5, 88);
            team3Divider.Name = "team3Divider";
            team3Divider.Size = new Size(545, 11);
            team3Divider.TabIndex = 389;
            // 
            // team3ModeDivider
            // 
            team3ModeDivider.BackColor = Color.Blue;
            team3ModeDivider.Location = new Point(-5, 40);
            team3ModeDivider.Name = "team3ModeDivider";
            team3ModeDivider.Size = new Size(545, 11);
            team3ModeDivider.TabIndex = 390;
            // 
            // lbl3MatchEvent
            // 
            lbl3MatchEvent.AutoSize = true;
            lbl3MatchEvent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl3MatchEvent.ForeColor = Color.White;
            lbl3MatchEvent.Location = new Point(6, 325);
            lbl3MatchEvent.Name = "lbl3MatchEvent";
            lbl3MatchEvent.Size = new Size(125, 24);
            lbl3MatchEvent.TabIndex = 295;
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
            lbl3ScoutName.Location = new Point(7, 359);
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
            lbl3ModeValue.Location = new Point(3, 4);
            lbl3ModeValue.Name = "lbl3ModeValue";
            lbl3ModeValue.Size = new Size(67, 29);
            lbl3ModeValue.TabIndex = 292;
            lbl3ModeValue.Text = "Auto:";
            // 
            // team3TeamDivider
            // 
            team3TeamDivider.BackColor = Color.Blue;
            team3TeamDivider.Location = new Point(0, 308);
            team3TeamDivider.Name = "team3TeamDivider";
            team3TeamDivider.Size = new Size(540, 11);
            team3TeamDivider.TabIndex = 279;
            // 
            // team4
            // 
            team4.BackColor = Color.Black;
            team4.Controls.Add(lbl4Position0Value);
            team4.Controls.Add(lbl4Position0);
            team4.Controls.Add(lbl4Position12Value);
            team4.Controls.Add(lbl4Position12);
            team4.Controls.Add(lbl4Position11Value);
            team4.Controls.Add(lbl4Position11);
            team4.Controls.Add(lbl4Position8Value);
            team4.Controls.Add(lbl4Position8);
            team4.Controls.Add(lbl4Position7Value);
            team4.Controls.Add(lbl4Position7);
            team4.Controls.Add(lbl4Position5Value);
            team4.Controls.Add(lbl4Position5);
            team4.Controls.Add(lbl4Position4Value);
            team4.Controls.Add(lbl4Position4);
            team4.Controls.Add(lbl4Position3Des);
            team4.Controls.Add(lbl4Position3Source);
            team4.Controls.Add(lbl4Position2Des);
            team4.Controls.Add(lbl4Position2Source);
            team4.Controls.Add(lbl4Position1);
            team4.Controls.Add(lbl4Position3Value);
            team4.Controls.Add(lbl4Position3);
            team4.Controls.Add(lbl4Position2Value);
            team4.Controls.Add(lbl4Position2);
            team4.Controls.Add(team4Divider);
            team4.Controls.Add(team4ModeDivider);
            team4.Controls.Add(lbl4MatchEvent);
            team4.Controls.Add(lbl4TeamName);
            team4.Controls.Add(lbl4ScoutName);
            team4.Controls.Add(lbl4ModeValue);
            team4.Controls.Add(team4TeamDivider);
            team4.Dock = DockStyle.Fill;
            team4.Location = new Point(487, 3);
            team4.Name = "team4";
            team4.Size = new Size(478, 399);
            team4.TabIndex = 348;
            // 
            // lbl4Position0Value
            // 
            lbl4Position0Value.AutoSize = true;
            lbl4Position0Value.BackColor = Color.Red;
            lbl4Position0Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl4Position0Value.ForeColor = Color.Red;
            lbl4Position0Value.ImageAlign = ContentAlignment.TopLeft;
            lbl4Position0Value.Location = new Point(72, 55);
            lbl4Position0Value.Name = "lbl4Position0Value";
            lbl4Position0Value.Size = new Size(16, 24);
            lbl4Position0Value.TabIndex = 393;
            lbl4Position0Value.Text = ".";
            lbl4Position0Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl4Position0
            // 
            lbl4Position0.AutoSize = true;
            lbl4Position0.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position0.ForeColor = Color.White;
            lbl4Position0.Location = new Point(2, 55);
            lbl4Position0.Name = "lbl4Position0";
            lbl4Position0.Size = new Size(66, 24);
            lbl4Position0.TabIndex = 387;
            lbl4Position0.Text = "Leave";
            // 
            // lbl4Position12Value
            // 
            lbl4Position12Value.AutoSize = true;
            lbl4Position12Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position12Value.ForeColor = Color.White;
            lbl4Position12Value.Location = new Point(52, 273);
            lbl4Position12Value.Name = "lbl4Position12Value";
            lbl4Position12Value.Size = new Size(21, 24);
            lbl4Position12Value.TabIndex = 411;
            lbl4Position12Value.Text = "9";
            // 
            // lbl4Position12
            // 
            lbl4Position12.AutoSize = true;
            lbl4Position12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position12.ForeColor = Color.White;
            lbl4Position12.Location = new Point(2, 272);
            lbl4Position12.Name = "lbl4Position12";
            lbl4Position12.Size = new Size(57, 24);
            lbl4Position12.TabIndex = 410;
            lbl4Position12.Text = "Strat:";
            // 
            // lbl4Position11Value
            // 
            lbl4Position11Value.AutoSize = true;
            lbl4Position11Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position11Value.ForeColor = Color.White;
            lbl4Position11Value.Location = new Point(90, 245);
            lbl4Position11Value.Name = "lbl4Position11Value";
            lbl4Position11Value.Size = new Size(21, 24);
            lbl4Position11Value.TabIndex = 409;
            lbl4Position11Value.Text = "9";
            // 
            // lbl4Position11
            // 
            lbl4Position11.AutoSize = true;
            lbl4Position11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position11.ForeColor = Color.White;
            lbl4Position11.Location = new Point(2, 245);
            lbl4Position11.Name = "lbl4Position11";
            lbl4Position11.Size = new Size(86, 24);
            lbl4Position11.TabIndex = 408;
            lbl4Position11.Text = "Attempt:";
            // 
            // lbl4Position8Value
            // 
            lbl4Position8Value.AutoSize = true;
            lbl4Position8Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position8Value.ForeColor = Color.White;
            lbl4Position8Value.Location = new Point(379, 228);
            lbl4Position8Value.Name = "lbl4Position8Value";
            lbl4Position8Value.Size = new Size(21, 24);
            lbl4Position8Value.TabIndex = 403;
            lbl4Position8Value.Text = "9";
            // 
            // lbl4Position8
            // 
            lbl4Position8.AutoSize = true;
            lbl4Position8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position8.ForeColor = Color.White;
            lbl4Position8.Location = new Point(315, 227);
            lbl4Position8.Name = "lbl4Position8";
            lbl4Position8.Size = new Size(69, 24);
            lbl4Position8.TabIndex = 402;
            lbl4Position8.Text = "Avoid:";
            // 
            // lbl4Position7Value
            // 
            lbl4Position7Value.AutoSize = true;
            lbl4Position7Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position7Value.ForeColor = Color.White;
            lbl4Position7Value.Location = new Point(316, 274);
            lbl4Position7Value.Name = "lbl4Position7Value";
            lbl4Position7Value.Size = new Size(21, 24);
            lbl4Position7Value.TabIndex = 407;
            lbl4Position7Value.Text = "9";
            // 
            // lbl4Position7
            // 
            lbl4Position7.AutoSize = true;
            lbl4Position7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position7.ForeColor = Color.White;
            lbl4Position7.Location = new Point(281, 273);
            lbl4Position7.Name = "lbl4Position7";
            lbl4Position7.Size = new Size(40, 24);
            lbl4Position7.TabIndex = 406;
            lbl4Position7.Text = "Eff:";
            // 
            // lbl4Position5Value
            // 
            lbl4Position5Value.AutoSize = true;
            lbl4Position5Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position5Value.ForeColor = Color.White;
            lbl4Position5Value.Location = new Point(215, 226);
            lbl4Position5Value.Name = "lbl4Position5Value";
            lbl4Position5Value.Size = new Size(21, 24);
            lbl4Position5Value.TabIndex = 401;
            lbl4Position5Value.Text = "9";
            lbl4Position5Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl4Position5
            // 
            lbl4Position5.AutoSize = true;
            lbl4Position5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position5.ForeColor = Color.White;
            lbl4Position5.Location = new Point(163, 226);
            lbl4Position5.Name = "lbl4Position5";
            lbl4Position5.Size = new Size(47, 24);
            lbl4Position5.TabIndex = 400;
            lbl4Position5.Text = "Def:";
            lbl4Position5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl4Position4Value
            // 
            lbl4Position4Value.AutoSize = true;
            lbl4Position4Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position4Value.ForeColor = Color.White;
            lbl4Position4Value.Location = new Point(345, 178);
            lbl4Position4Value.Name = "lbl4Position4Value";
            lbl4Position4Value.Size = new Size(21, 24);
            lbl4Position4Value.TabIndex = 399;
            lbl4Position4Value.Text = "9";
            // 
            // lbl4Position4
            // 
            lbl4Position4.AutoSize = true;
            lbl4Position4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position4.ForeColor = Color.White;
            lbl4Position4.Location = new Point(243, 177);
            lbl4Position4.Name = "lbl4Position4";
            lbl4Position4.Size = new Size(106, 24);
            lbl4Position4.TabIndex = 398;
            lbl4Position4.Text = "End State:";
            // 
            // lbl4Position3Des
            // 
            lbl4Position3Des.AutoSize = true;
            lbl4Position3Des.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position3Des.ForeColor = Color.White;
            lbl4Position3Des.Location = new Point(176, 150);
            lbl4Position3Des.Name = "lbl4Position3Des";
            lbl4Position3Des.Size = new Size(59, 24);
            lbl4Position3Des.TabIndex = 397;
            lbl4Position3Des.Text = "Floor";
            // 
            // lbl4Position3Source
            // 
            lbl4Position3Source.AutoSize = true;
            lbl4Position3Source.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position3Source.ForeColor = Color.White;
            lbl4Position3Source.Location = new Point(103, 150);
            lbl4Position3Source.Name = "lbl4Position3Source";
            lbl4Position3Source.Size = new Size(59, 24);
            lbl4Position3Source.TabIndex = 405;
            lbl4Position3Source.Text = "Floor";
            // 
            // lbl4Position2Des
            // 
            lbl4Position2Des.AutoSize = true;
            lbl4Position2Des.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position2Des.ForeColor = Color.White;
            lbl4Position2Des.Location = new Point(176, 112);
            lbl4Position2Des.Name = "lbl4Position2Des";
            lbl4Position2Des.Size = new Size(59, 24);
            lbl4Position2Des.TabIndex = 396;
            lbl4Position2Des.Text = "Floor";
            // 
            // lbl4Position2Source
            // 
            lbl4Position2Source.AutoSize = true;
            lbl4Position2Source.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position2Source.ForeColor = Color.White;
            lbl4Position2Source.Location = new Point(103, 112);
            lbl4Position2Source.Name = "lbl4Position2Source";
            lbl4Position2Source.Size = new Size(73, 24);
            lbl4Position2Source.TabIndex = 404;
            lbl4Position2Source.Text = "Station";
            // 
            // lbl4Position1
            // 
            lbl4Position1.AutoSize = true;
            lbl4Position1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position1.ForeColor = Color.White;
            lbl4Position1.Location = new Point(245, 56);
            lbl4Position1.Name = "lbl4Position1";
            lbl4Position1.Size = new Size(103, 24);
            lbl4Position1.TabIndex = 388;
            lbl4Position1.Text = "Near Side";
            // 
            // lbl4Position3Value
            // 
            lbl4Position3Value.AutoSize = true;
            lbl4Position3Value.BackColor = Color.Red;
            lbl4Position3Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl4Position3Value.ForeColor = Color.Red;
            lbl4Position3Value.ImageAlign = ContentAlignment.TopLeft;
            lbl4Position3Value.Location = new Point(72, 150);
            lbl4Position3Value.Name = "lbl4Position3Value";
            lbl4Position3Value.Size = new Size(16, 24);
            lbl4Position3Value.TabIndex = 395;
            lbl4Position3Value.Text = ".";
            lbl4Position3Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl4Position3
            // 
            lbl4Position3.AutoSize = true;
            lbl4Position3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position3.ForeColor = Color.White;
            lbl4Position3.Location = new Point(2, 148);
            lbl4Position3.Name = "lbl4Position3";
            lbl4Position3.Size = new Size(70, 24);
            lbl4Position3.TabIndex = 394;
            lbl4Position3.Text = "Algae:";
            // 
            // lbl4Position2Value
            // 
            lbl4Position2Value.AutoSize = true;
            lbl4Position2Value.BackColor = Color.Red;
            lbl4Position2Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl4Position2Value.ForeColor = Color.Red;
            lbl4Position2Value.ImageAlign = ContentAlignment.TopLeft;
            lbl4Position2Value.Location = new Point(72, 109);
            lbl4Position2Value.Name = "lbl4Position2Value";
            lbl4Position2Value.Size = new Size(16, 24);
            lbl4Position2Value.TabIndex = 392;
            lbl4Position2Value.Text = ".";
            lbl4Position2Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl4Position2
            // 
            lbl4Position2.AutoSize = true;
            lbl4Position2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4Position2.ForeColor = Color.White;
            lbl4Position2.Location = new Point(2, 110);
            lbl4Position2.Name = "lbl4Position2";
            lbl4Position2.Size = new Size(65, 24);
            lbl4Position2.TabIndex = 391;
            lbl4Position2.Text = "Coral:";
            // 
            // team4Divider
            // 
            team4Divider.BackColor = Color.Blue;
            team4Divider.Location = new Point(-5, 88);
            team4Divider.Name = "team4Divider";
            team4Divider.Size = new Size(545, 11);
            team4Divider.TabIndex = 389;
            // 
            // team4ModeDivider
            // 
            team4ModeDivider.BackColor = Color.Blue;
            team4ModeDivider.Location = new Point(-5, 40);
            team4ModeDivider.Name = "team4ModeDivider";
            team4ModeDivider.Size = new Size(545, 11);
            team4ModeDivider.TabIndex = 390;
            // 
            // lbl4MatchEvent
            // 
            lbl4MatchEvent.AutoSize = true;
            lbl4MatchEvent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl4MatchEvent.ForeColor = Color.White;
            lbl4MatchEvent.Location = new Point(6, 325);
            lbl4MatchEvent.Name = "lbl4MatchEvent";
            lbl4MatchEvent.Size = new Size(125, 24);
            lbl4MatchEvent.TabIndex = 295;
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
            lbl4ScoutName.Location = new Point(7, 359);
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
            lbl4ModeValue.Location = new Point(1, 5);
            lbl4ModeValue.Name = "lbl4ModeValue";
            lbl4ModeValue.Size = new Size(67, 29);
            lbl4ModeValue.TabIndex = 292;
            lbl4ModeValue.Text = "Auto:";
            // 
            // team4TeamDivider
            // 
            team4TeamDivider.BackColor = Color.Blue;
            team4TeamDivider.Location = new Point(0, 307);
            team4TeamDivider.Name = "team4TeamDivider";
            team4TeamDivider.Size = new Size(540, 11);
            team4TeamDivider.TabIndex = 279;
            // 
            // team5
            // 
            team5.BackColor = Color.Black;
            team5.Controls.Add(lbl5Position0Value);
            team5.Controls.Add(lbl5Position0);
            team5.Controls.Add(lbl5Position12Value);
            team5.Controls.Add(lbl5Position12);
            team5.Controls.Add(lbl5Position11Value);
            team5.Controls.Add(lbl5Position11);
            team5.Controls.Add(lbl5Position8Value);
            team5.Controls.Add(lbl5Position8);
            team5.Controls.Add(lbl5Position7Value);
            team5.Controls.Add(lbl5Position7);
            team5.Controls.Add(lbl5Position5Value);
            team5.Controls.Add(lbl5Position5);
            team5.Controls.Add(lbl5Position4Value);
            team5.Controls.Add(lbl5Position4);
            team5.Controls.Add(lbl5Position3Des);
            team5.Controls.Add(lbl5Position3Source);
            team5.Controls.Add(lbl5Position2Des);
            team5.Controls.Add(lbl5Position2Source);
            team5.Controls.Add(lbl5Position1);
            team5.Controls.Add(lbl5Position3Value);
            team5.Controls.Add(lbl5Position3);
            team5.Controls.Add(lbl5Position2Value);
            team5.Controls.Add(lbl5Position2);
            team5.Controls.Add(team5Divider);
            team5.Controls.Add(team5ModeDivider);
            team5.Controls.Add(lbl5MatchEvent);
            team5.Controls.Add(lbl5TeamName);
            team5.Controls.Add(lbl5ScoutName);
            team5.Controls.Add(lbl5ModeValue);
            team5.Controls.Add(team5TeamDivider);
            team5.Dock = DockStyle.Fill;
            team5.Location = new Point(971, 3);
            team5.Name = "team5";
            team5.Size = new Size(480, 399);
            team5.TabIndex = 349;
            // 
            // lbl5Position0Value
            // 
            lbl5Position0Value.AutoSize = true;
            lbl5Position0Value.BackColor = Color.Red;
            lbl5Position0Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl5Position0Value.ForeColor = Color.Red;
            lbl5Position0Value.ImageAlign = ContentAlignment.TopLeft;
            lbl5Position0Value.Location = new Point(72, 55);
            lbl5Position0Value.Name = "lbl5Position0Value";
            lbl5Position0Value.Size = new Size(16, 24);
            lbl5Position0Value.TabIndex = 393;
            lbl5Position0Value.Text = ".";
            lbl5Position0Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl5Position0
            // 
            lbl5Position0.AutoSize = true;
            lbl5Position0.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position0.ForeColor = Color.White;
            lbl5Position0.Location = new Point(2, 55);
            lbl5Position0.Name = "lbl5Position0";
            lbl5Position0.Size = new Size(66, 24);
            lbl5Position0.TabIndex = 387;
            lbl5Position0.Text = "Leave";
            // 
            // lbl5Position12Value
            // 
            lbl5Position12Value.AutoSize = true;
            lbl5Position12Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position12Value.ForeColor = Color.White;
            lbl5Position12Value.Location = new Point(52, 273);
            lbl5Position12Value.Name = "lbl5Position12Value";
            lbl5Position12Value.Size = new Size(21, 24);
            lbl5Position12Value.TabIndex = 411;
            lbl5Position12Value.Text = "9";
            // 
            // lbl5Position12
            // 
            lbl5Position12.AutoSize = true;
            lbl5Position12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position12.ForeColor = Color.White;
            lbl5Position12.Location = new Point(2, 272);
            lbl5Position12.Name = "lbl5Position12";
            lbl5Position12.Size = new Size(57, 24);
            lbl5Position12.TabIndex = 410;
            lbl5Position12.Text = "Strat:";
            // 
            // lbl5Position11Value
            // 
            lbl5Position11Value.AutoSize = true;
            lbl5Position11Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position11Value.ForeColor = Color.White;
            lbl5Position11Value.Location = new Point(90, 245);
            lbl5Position11Value.Name = "lbl5Position11Value";
            lbl5Position11Value.Size = new Size(21, 24);
            lbl5Position11Value.TabIndex = 409;
            lbl5Position11Value.Text = "9";
            // 
            // lbl5Position11
            // 
            lbl5Position11.AutoSize = true;
            lbl5Position11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position11.ForeColor = Color.White;
            lbl5Position11.Location = new Point(2, 245);
            lbl5Position11.Name = "lbl5Position11";
            lbl5Position11.Size = new Size(86, 24);
            lbl5Position11.TabIndex = 408;
            lbl5Position11.Text = "Attempt:";
            // 
            // lbl5Position8Value
            // 
            lbl5Position8Value.AutoSize = true;
            lbl5Position8Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position8Value.ForeColor = Color.White;
            lbl5Position8Value.Location = new Point(379, 228);
            lbl5Position8Value.Name = "lbl5Position8Value";
            lbl5Position8Value.Size = new Size(21, 24);
            lbl5Position8Value.TabIndex = 403;
            lbl5Position8Value.Text = "9";
            // 
            // lbl5Position8
            // 
            lbl5Position8.AutoSize = true;
            lbl5Position8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position8.ForeColor = Color.White;
            lbl5Position8.Location = new Point(315, 227);
            lbl5Position8.Name = "lbl5Position8";
            lbl5Position8.Size = new Size(69, 24);
            lbl5Position8.TabIndex = 402;
            lbl5Position8.Text = "Avoid:";
            // 
            // lbl5Position7Value
            // 
            lbl5Position7Value.AutoSize = true;
            lbl5Position7Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position7Value.ForeColor = Color.White;
            lbl5Position7Value.Location = new Point(316, 274);
            lbl5Position7Value.Name = "lbl5Position7Value";
            lbl5Position7Value.Size = new Size(21, 24);
            lbl5Position7Value.TabIndex = 407;
            lbl5Position7Value.Text = "9";
            // 
            // lbl5Position7
            // 
            lbl5Position7.AutoSize = true;
            lbl5Position7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position7.ForeColor = Color.White;
            lbl5Position7.Location = new Point(281, 273);
            lbl5Position7.Name = "lbl5Position7";
            lbl5Position7.Size = new Size(40, 24);
            lbl5Position7.TabIndex = 406;
            lbl5Position7.Text = "Eff:";
            // 
            // lbl5Position5Value
            // 
            lbl5Position5Value.AutoSize = true;
            lbl5Position5Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position5Value.ForeColor = Color.White;
            lbl5Position5Value.Location = new Point(215, 226);
            lbl5Position5Value.Name = "lbl5Position5Value";
            lbl5Position5Value.Size = new Size(21, 24);
            lbl5Position5Value.TabIndex = 401;
            lbl5Position5Value.Text = "9";
            lbl5Position5Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl5Position5
            // 
            lbl5Position5.AutoSize = true;
            lbl5Position5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position5.ForeColor = Color.White;
            lbl5Position5.Location = new Point(163, 226);
            lbl5Position5.Name = "lbl5Position5";
            lbl5Position5.Size = new Size(47, 24);
            lbl5Position5.TabIndex = 400;
            lbl5Position5.Text = "Def:";
            lbl5Position5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl5Position4Value
            // 
            lbl5Position4Value.AutoSize = true;
            lbl5Position4Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position4Value.ForeColor = Color.White;
            lbl5Position4Value.Location = new Point(345, 178);
            lbl5Position4Value.Name = "lbl5Position4Value";
            lbl5Position4Value.Size = new Size(21, 24);
            lbl5Position4Value.TabIndex = 399;
            lbl5Position4Value.Text = "9";
            // 
            // lbl5Position4
            // 
            lbl5Position4.AutoSize = true;
            lbl5Position4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position4.ForeColor = Color.White;
            lbl5Position4.Location = new Point(243, 177);
            lbl5Position4.Name = "lbl5Position4";
            lbl5Position4.Size = new Size(106, 24);
            lbl5Position4.TabIndex = 398;
            lbl5Position4.Text = "End State:";
            // 
            // lbl5Position3Des
            // 
            lbl5Position3Des.AutoSize = true;
            lbl5Position3Des.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position3Des.ForeColor = Color.White;
            lbl5Position3Des.Location = new Point(176, 150);
            lbl5Position3Des.Name = "lbl5Position3Des";
            lbl5Position3Des.Size = new Size(59, 24);
            lbl5Position3Des.TabIndex = 397;
            lbl5Position3Des.Text = "Floor";
            // 
            // lbl5Position3Source
            // 
            lbl5Position3Source.AutoSize = true;
            lbl5Position3Source.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position3Source.ForeColor = Color.White;
            lbl5Position3Source.Location = new Point(103, 150);
            lbl5Position3Source.Name = "lbl5Position3Source";
            lbl5Position3Source.Size = new Size(59, 24);
            lbl5Position3Source.TabIndex = 405;
            lbl5Position3Source.Text = "Floor";
            // 
            // lbl5Position2Des
            // 
            lbl5Position2Des.AutoSize = true;
            lbl5Position2Des.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position2Des.ForeColor = Color.White;
            lbl5Position2Des.Location = new Point(176, 112);
            lbl5Position2Des.Name = "lbl5Position2Des";
            lbl5Position2Des.Size = new Size(59, 24);
            lbl5Position2Des.TabIndex = 396;
            lbl5Position2Des.Text = "Floor";
            // 
            // lbl5Position2Source
            // 
            lbl5Position2Source.AutoSize = true;
            lbl5Position2Source.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position2Source.ForeColor = Color.White;
            lbl5Position2Source.Location = new Point(103, 112);
            lbl5Position2Source.Name = "lbl5Position2Source";
            lbl5Position2Source.Size = new Size(73, 24);
            lbl5Position2Source.TabIndex = 404;
            lbl5Position2Source.Text = "Station";
            // 
            // lbl5Position1
            // 
            lbl5Position1.AutoSize = true;
            lbl5Position1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position1.ForeColor = Color.White;
            lbl5Position1.Location = new Point(245, 56);
            lbl5Position1.Name = "lbl5Position1";
            lbl5Position1.Size = new Size(103, 24);
            lbl5Position1.TabIndex = 388;
            lbl5Position1.Text = "Near Side";
            // 
            // lbl5Position3Value
            // 
            lbl5Position3Value.AutoSize = true;
            lbl5Position3Value.BackColor = Color.Red;
            lbl5Position3Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl5Position3Value.ForeColor = Color.Red;
            lbl5Position3Value.ImageAlign = ContentAlignment.TopLeft;
            lbl5Position3Value.Location = new Point(72, 150);
            lbl5Position3Value.Name = "lbl5Position3Value";
            lbl5Position3Value.Size = new Size(16, 24);
            lbl5Position3Value.TabIndex = 395;
            lbl5Position3Value.Text = ".";
            lbl5Position3Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl5Position3
            // 
            lbl5Position3.AutoSize = true;
            lbl5Position3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position3.ForeColor = Color.White;
            lbl5Position3.Location = new Point(2, 148);
            lbl5Position3.Name = "lbl5Position3";
            lbl5Position3.Size = new Size(70, 24);
            lbl5Position3.TabIndex = 394;
            lbl5Position3.Text = "Algae:";
            // 
            // lbl5Position2Value
            // 
            lbl5Position2Value.AutoSize = true;
            lbl5Position2Value.BackColor = Color.Red;
            lbl5Position2Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl5Position2Value.ForeColor = Color.Red;
            lbl5Position2Value.ImageAlign = ContentAlignment.TopLeft;
            lbl5Position2Value.Location = new Point(72, 109);
            lbl5Position2Value.Name = "lbl5Position2Value";
            lbl5Position2Value.Size = new Size(16, 24);
            lbl5Position2Value.TabIndex = 392;
            lbl5Position2Value.Text = ".";
            lbl5Position2Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl5Position2
            // 
            lbl5Position2.AutoSize = true;
            lbl5Position2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5Position2.ForeColor = Color.White;
            lbl5Position2.Location = new Point(2, 110);
            lbl5Position2.Name = "lbl5Position2";
            lbl5Position2.Size = new Size(65, 24);
            lbl5Position2.TabIndex = 391;
            lbl5Position2.Text = "Coral:";
            // 
            // team5Divider
            // 
            team5Divider.BackColor = Color.Blue;
            team5Divider.Location = new Point(-5, 88);
            team5Divider.Name = "team5Divider";
            team5Divider.Size = new Size(545, 11);
            team5Divider.TabIndex = 389;
            // 
            // team5ModeDivider
            // 
            team5ModeDivider.BackColor = Color.Blue;
            team5ModeDivider.Location = new Point(-5, 40);
            team5ModeDivider.Name = "team5ModeDivider";
            team5ModeDivider.Size = new Size(545, 11);
            team5ModeDivider.TabIndex = 390;
            // 
            // lbl5MatchEvent
            // 
            lbl5MatchEvent.AutoSize = true;
            lbl5MatchEvent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl5MatchEvent.ForeColor = Color.White;
            lbl5MatchEvent.Location = new Point(7, 325);
            lbl5MatchEvent.Name = "lbl5MatchEvent";
            lbl5MatchEvent.Size = new Size(125, 24);
            lbl5MatchEvent.TabIndex = 295;
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
            lbl5ScoutName.Location = new Point(7, 359);
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
            lbl5ModeValue.Location = new Point(2, 4);
            lbl5ModeValue.Name = "lbl5ModeValue";
            lbl5ModeValue.Size = new Size(67, 29);
            lbl5ModeValue.TabIndex = 292;
            lbl5ModeValue.Text = "Auto:";
            // 
            // team5TeamDivider
            // 
            team5TeamDivider.BackColor = Color.Blue;
            team5TeamDivider.Location = new Point(0, 307);
            team5TeamDivider.Name = "team5TeamDivider";
            team5TeamDivider.Size = new Size(540, 11);
            team5TeamDivider.TabIndex = 279;
            // 
            // redTeams
            // 
            redTeams.BackColor = Color.Red;
            redTeams.ColumnCount = 3;
            redTeams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            redTeams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            redTeams.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            redTeams.Controls.Add(team0, 0, 0);
            redTeams.Controls.Add(team1, 1, 0);
            redTeams.Controls.Add(team2, 2, 0);
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
            team0.Controls.Add(lbl0Position0Value);
            team0.Controls.Add(lbl0Position0);
            team0.Controls.Add(lbl0Position12Value);
            team0.Controls.Add(lbl0Position12);
            team0.Controls.Add(lbl0Position11Value);
            team0.Controls.Add(lbl0Position11);
            team0.Controls.Add(lbl0Position8Value);
            team0.Controls.Add(lbl0Position8);
            team0.Controls.Add(lbl0Position7Value);
            team0.Controls.Add(lbl0Position7);
            team0.Controls.Add(lbl0Position5Value);
            team0.Controls.Add(lbl0Position5);
            team0.Controls.Add(lbl0Position4Value);
            team0.Controls.Add(lbl0Position4);
            team0.Controls.Add(lbl0Position3Des);
            team0.Controls.Add(lbl0Position3Source);
            team0.Controls.Add(lbl0Position2Des);
            team0.Controls.Add(lbl0Position2Source);
            team0.Controls.Add(lbl0Position1);
            team0.Controls.Add(lbl0Position3Value);
            team0.Controls.Add(lbl0Position3);
            team0.Controls.Add(lbl0Position2Value);
            team0.Controls.Add(lbl0Position2);
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
            // lbl0Position0Value
            // 
            lbl0Position0Value.AutoSize = true;
            lbl0Position0Value.BackColor = Color.Red;
            lbl0Position0Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl0Position0Value.ForeColor = Color.Red;
            lbl0Position0Value.ImageAlign = ContentAlignment.TopLeft;
            lbl0Position0Value.Location = new Point(72, 55);
            lbl0Position0Value.Name = "lbl0Position0Value";
            lbl0Position0Value.Size = new Size(16, 24);
            lbl0Position0Value.TabIndex = 393;
            lbl0Position0Value.Text = ".";
            lbl0Position0Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl0Position0
            // 
            lbl0Position0.AutoSize = true;
            lbl0Position0.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position0.ForeColor = Color.White;
            lbl0Position0.Location = new Point(2, 55);
            lbl0Position0.Name = "lbl0Position0";
            lbl0Position0.Size = new Size(66, 24);
            lbl0Position0.TabIndex = 387;
            lbl0Position0.Text = "Leave";
            // 
            // lbl0Position12Value
            // 
            lbl0Position12Value.AutoSize = true;
            lbl0Position12Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position12Value.ForeColor = Color.White;
            lbl0Position12Value.Location = new Point(52, 273);
            lbl0Position12Value.Name = "lbl0Position12Value";
            lbl0Position12Value.Size = new Size(21, 24);
            lbl0Position12Value.TabIndex = 411;
            lbl0Position12Value.Text = "9";
            // 
            // lbl0Position12
            // 
            lbl0Position12.AutoSize = true;
            lbl0Position12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position12.ForeColor = Color.White;
            lbl0Position12.Location = new Point(2, 272);
            lbl0Position12.Name = "lbl0Position12";
            lbl0Position12.Size = new Size(57, 24);
            lbl0Position12.TabIndex = 410;
            lbl0Position12.Text = "Strat:";
            // 
            // lbl0Position11Value
            // 
            lbl0Position11Value.AutoSize = true;
            lbl0Position11Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position11Value.ForeColor = Color.White;
            lbl0Position11Value.Location = new Point(90, 245);
            lbl0Position11Value.Name = "lbl0Position11Value";
            lbl0Position11Value.Size = new Size(21, 24);
            lbl0Position11Value.TabIndex = 409;
            lbl0Position11Value.Text = "9";
            // 
            // lbl0Position11
            // 
            lbl0Position11.AutoSize = true;
            lbl0Position11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position11.ForeColor = Color.White;
            lbl0Position11.Location = new Point(2, 245);
            lbl0Position11.Name = "lbl0Position11";
            lbl0Position11.Size = new Size(86, 24);
            lbl0Position11.TabIndex = 408;
            lbl0Position11.Text = "Attempt:";
            // 
            // lbl0Position8Value
            // 
            lbl0Position8Value.AutoSize = true;
            lbl0Position8Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position8Value.ForeColor = Color.White;
            lbl0Position8Value.Location = new Point(379, 228);
            lbl0Position8Value.Name = "lbl0Position8Value";
            lbl0Position8Value.Size = new Size(21, 24);
            lbl0Position8Value.TabIndex = 403;
            lbl0Position8Value.Text = "9";
            // 
            // lbl0Position8
            // 
            lbl0Position8.AutoSize = true;
            lbl0Position8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position8.ForeColor = Color.White;
            lbl0Position8.Location = new Point(315, 227);
            lbl0Position8.Name = "lbl0Position8";
            lbl0Position8.Size = new Size(69, 24);
            lbl0Position8.TabIndex = 402;
            lbl0Position8.Text = "Avoid:";
            // 
            // lbl0Position7Value
            // 
            lbl0Position7Value.AutoSize = true;
            lbl0Position7Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position7Value.ForeColor = Color.White;
            lbl0Position7Value.Location = new Point(316, 274);
            lbl0Position7Value.Name = "lbl0Position7Value";
            lbl0Position7Value.Size = new Size(21, 24);
            lbl0Position7Value.TabIndex = 407;
            lbl0Position7Value.Text = "9";
            // 
            // lbl0Position7
            // 
            lbl0Position7.AutoSize = true;
            lbl0Position7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position7.ForeColor = Color.White;
            lbl0Position7.Location = new Point(281, 273);
            lbl0Position7.Name = "lbl0Position7";
            lbl0Position7.Size = new Size(40, 24);
            lbl0Position7.TabIndex = 406;
            lbl0Position7.Text = "Eff:";
            // 
            // lbl0Position5Value
            // 
            lbl0Position5Value.AutoSize = true;
            lbl0Position5Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position5Value.ForeColor = Color.White;
            lbl0Position5Value.Location = new Point(215, 226);
            lbl0Position5Value.Name = "lbl0Position5Value";
            lbl0Position5Value.Size = new Size(21, 24);
            lbl0Position5Value.TabIndex = 401;
            lbl0Position5Value.Text = "9";
            lbl0Position5Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl0Position5
            // 
            lbl0Position5.AutoSize = true;
            lbl0Position5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position5.ForeColor = Color.White;
            lbl0Position5.Location = new Point(163, 226);
            lbl0Position5.Name = "lbl0Position5";
            lbl0Position5.Size = new Size(47, 24);
            lbl0Position5.TabIndex = 400;
            lbl0Position5.Text = "Def:";
            lbl0Position5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl0Position4Value
            // 
            lbl0Position4Value.AutoSize = true;
            lbl0Position4Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position4Value.ForeColor = Color.White;
            lbl0Position4Value.Location = new Point(345, 178);
            lbl0Position4Value.Name = "lbl0Position4Value";
            lbl0Position4Value.Size = new Size(21, 24);
            lbl0Position4Value.TabIndex = 399;
            lbl0Position4Value.Text = "9";
            // 
            // lbl0Position4
            // 
            lbl0Position4.AutoSize = true;
            lbl0Position4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position4.ForeColor = Color.White;
            lbl0Position4.Location = new Point(243, 177);
            lbl0Position4.Name = "lbl0Position4";
            lbl0Position4.Size = new Size(106, 24);
            lbl0Position4.TabIndex = 398;
            lbl0Position4.Text = "End State:";
            // 
            // lbl0Position3Des
            // 
            lbl0Position3Des.AutoSize = true;
            lbl0Position3Des.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position3Des.ForeColor = Color.White;
            lbl0Position3Des.Location = new Point(176, 150);
            lbl0Position3Des.Name = "lbl0Position3Des";
            lbl0Position3Des.Size = new Size(59, 24);
            lbl0Position3Des.TabIndex = 397;
            lbl0Position3Des.Text = "Floor";
            // 
            // lbl0Position3Source
            // 
            lbl0Position3Source.AutoSize = true;
            lbl0Position3Source.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position3Source.ForeColor = Color.White;
            lbl0Position3Source.Location = new Point(103, 150);
            lbl0Position3Source.Name = "lbl0Position3Source";
            lbl0Position3Source.Size = new Size(59, 24);
            lbl0Position3Source.TabIndex = 405;
            lbl0Position3Source.Text = "Floor";
            // 
            // lbl0Position2Des
            // 
            lbl0Position2Des.AutoSize = true;
            lbl0Position2Des.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position2Des.ForeColor = Color.White;
            lbl0Position2Des.Location = new Point(176, 112);
            lbl0Position2Des.Name = "lbl0Position2Des";
            lbl0Position2Des.Size = new Size(59, 24);
            lbl0Position2Des.TabIndex = 396;
            lbl0Position2Des.Text = "Floor";
            // 
            // lbl0Position2Source
            // 
            lbl0Position2Source.AutoSize = true;
            lbl0Position2Source.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position2Source.ForeColor = Color.White;
            lbl0Position2Source.Location = new Point(103, 112);
            lbl0Position2Source.Name = "lbl0Position2Source";
            lbl0Position2Source.Size = new Size(73, 24);
            lbl0Position2Source.TabIndex = 404;
            lbl0Position2Source.Text = "Station";
            // 
            // lbl0Position1
            // 
            lbl0Position1.AutoSize = true;
            lbl0Position1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position1.ForeColor = Color.White;
            lbl0Position1.Location = new Point(245, 56);
            lbl0Position1.Name = "lbl0Position1";
            lbl0Position1.Size = new Size(103, 24);
            lbl0Position1.TabIndex = 388;
            lbl0Position1.Text = "Near Side";
            // 
            // lbl0Position3Value
            // 
            lbl0Position3Value.AutoSize = true;
            lbl0Position3Value.BackColor = Color.Red;
            lbl0Position3Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl0Position3Value.ForeColor = Color.Red;
            lbl0Position3Value.ImageAlign = ContentAlignment.TopLeft;
            lbl0Position3Value.Location = new Point(72, 150);
            lbl0Position3Value.Name = "lbl0Position3Value";
            lbl0Position3Value.Size = new Size(16, 24);
            lbl0Position3Value.TabIndex = 395;
            lbl0Position3Value.Text = ".";
            lbl0Position3Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl0Position3
            // 
            lbl0Position3.AutoSize = true;
            lbl0Position3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position3.ForeColor = Color.White;
            lbl0Position3.Location = new Point(2, 148);
            lbl0Position3.Name = "lbl0Position3";
            lbl0Position3.Size = new Size(70, 24);
            lbl0Position3.TabIndex = 394;
            lbl0Position3.Text = "Algae:";
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
            lbl0Position2Value.Size = new Size(16, 24);
            lbl0Position2Value.TabIndex = 392;
            lbl0Position2Value.Text = ".";
            lbl0Position2Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl0Position2
            // 
            lbl0Position2.AutoSize = true;
            lbl0Position2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl0Position2.ForeColor = Color.White;
            lbl0Position2.Location = new Point(2, 110);
            lbl0Position2.Name = "lbl0Position2";
            lbl0Position2.Size = new Size(65, 24);
            lbl0Position2.TabIndex = 391;
            lbl0Position2.Text = "Coral:";
            // 
            // team0Divider
            // 
            team0Divider.BackColor = Color.Red;
            team0Divider.Location = new Point(-5, 88);
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
            lbl0ScoutName.Location = new Point(7, 359);
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
            // team1
            // 
            team1.BackColor = Color.Black;
            team1.Controls.Add(lbl1Position0Value);
            team1.Controls.Add(lbl1Position0);
            team1.Controls.Add(lbl1Position12Value);
            team1.Controls.Add(lbl1Position12);
            team1.Controls.Add(lbl1Position11Value);
            team1.Controls.Add(lbl1Position11);
            team1.Controls.Add(lbl1Position8Value);
            team1.Controls.Add(lbl1Position8);
            team1.Controls.Add(lbl1Position7Value);
            team1.Controls.Add(lbl1Position7);
            team1.Controls.Add(lbl1Position5Value);
            team1.Controls.Add(lbl1Position5);
            team1.Controls.Add(lbl1Position4Value);
            team1.Controls.Add(lbl1Position4);
            team1.Controls.Add(lbl1Position3Des);
            team1.Controls.Add(lbl1Position3Source);
            team1.Controls.Add(lbl1Position2Des);
            team1.Controls.Add(lbl1Position2Source);
            team1.Controls.Add(lbl1Position1);
            team1.Controls.Add(lbl1Position3Value);
            team1.Controls.Add(lbl1Position3);
            team1.Controls.Add(lbl1Position2Value);
            team1.Controls.Add(lbl1Position2);
            team1.Controls.Add(team1Divider);
            team1.Controls.Add(team1ModeDivider);
            team1.Controls.Add(team1TeamDivider);
            team1.Controls.Add(lbl1MatchEvent);
            team1.Controls.Add(lbl1TeamName);
            team1.Controls.Add(lbl1ScoutName);
            team1.Controls.Add(lbl1ModeValue);
            team1.Dock = DockStyle.Fill;
            team1.Location = new Point(487, 3);
            team1.Name = "team1";
            team1.Size = new Size(478, 399);
            team1.TabIndex = 280;
            // 
            // lbl1Position0Value
            // 
            lbl1Position0Value.AutoSize = true;
            lbl1Position0Value.BackColor = Color.Red;
            lbl1Position0Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl1Position0Value.ForeColor = Color.Red;
            lbl1Position0Value.ImageAlign = ContentAlignment.TopLeft;
            lbl1Position0Value.Location = new Point(72, 55);
            lbl1Position0Value.Name = "lbl1Position0Value";
            lbl1Position0Value.Size = new Size(16, 24);
            lbl1Position0Value.TabIndex = 393;
            lbl1Position0Value.Text = ".";
            lbl1Position0Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl1Position0
            // 
            lbl1Position0.AutoSize = true;
            lbl1Position0.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position0.ForeColor = Color.White;
            lbl1Position0.Location = new Point(2, 55);
            lbl1Position0.Name = "lbl1Position0";
            lbl1Position0.Size = new Size(66, 24);
            lbl1Position0.TabIndex = 387;
            lbl1Position0.Text = "Leave";
            // 
            // lbl1Position12Value
            // 
            lbl1Position12Value.AutoSize = true;
            lbl1Position12Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position12Value.ForeColor = Color.White;
            lbl1Position12Value.Location = new Point(52, 273);
            lbl1Position12Value.Name = "lbl1Position12Value";
            lbl1Position12Value.Size = new Size(21, 24);
            lbl1Position12Value.TabIndex = 411;
            lbl1Position12Value.Text = "9";
            // 
            // lbl1Position12
            // 
            lbl1Position12.AutoSize = true;
            lbl1Position12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position12.ForeColor = Color.White;
            lbl1Position12.Location = new Point(2, 272);
            lbl1Position12.Name = "lbl1Position12";
            lbl1Position12.Size = new Size(57, 24);
            lbl1Position12.TabIndex = 410;
            lbl1Position12.Text = "Strat:";
            // 
            // lbl1Position11Value
            // 
            lbl1Position11Value.AutoSize = true;
            lbl1Position11Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position11Value.ForeColor = Color.White;
            lbl1Position11Value.Location = new Point(90, 245);
            lbl1Position11Value.Name = "lbl1Position11Value";
            lbl1Position11Value.Size = new Size(21, 24);
            lbl1Position11Value.TabIndex = 409;
            lbl1Position11Value.Text = "9";
            // 
            // lbl1Position11
            // 
            lbl1Position11.AutoSize = true;
            lbl1Position11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position11.ForeColor = Color.White;
            lbl1Position11.Location = new Point(2, 245);
            lbl1Position11.Name = "lbl1Position11";
            lbl1Position11.Size = new Size(86, 24);
            lbl1Position11.TabIndex = 408;
            lbl1Position11.Text = "Attempt:";
            // 
            // lbl1Position8Value
            // 
            lbl1Position8Value.AutoSize = true;
            lbl1Position8Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position8Value.ForeColor = Color.White;
            lbl1Position8Value.Location = new Point(379, 228);
            lbl1Position8Value.Name = "lbl1Position8Value";
            lbl1Position8Value.Size = new Size(21, 24);
            lbl1Position8Value.TabIndex = 403;
            lbl1Position8Value.Text = "9";
            // 
            // lbl1Position8
            // 
            lbl1Position8.AutoSize = true;
            lbl1Position8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position8.ForeColor = Color.White;
            lbl1Position8.Location = new Point(315, 227);
            lbl1Position8.Name = "lbl1Position8";
            lbl1Position8.Size = new Size(69, 24);
            lbl1Position8.TabIndex = 402;
            lbl1Position8.Text = "Avoid:";
            // 
            // lbl1Position7Value
            // 
            lbl1Position7Value.AutoSize = true;
            lbl1Position7Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position7Value.ForeColor = Color.White;
            lbl1Position7Value.Location = new Point(316, 274);
            lbl1Position7Value.Name = "lbl1Position7Value";
            lbl1Position7Value.Size = new Size(21, 24);
            lbl1Position7Value.TabIndex = 407;
            lbl1Position7Value.Text = "9";
            // 
            // lbl1Position7
            // 
            lbl1Position7.AutoSize = true;
            lbl1Position7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position7.ForeColor = Color.White;
            lbl1Position7.Location = new Point(281, 273);
            lbl1Position7.Name = "lbl1Position7";
            lbl1Position7.Size = new Size(40, 24);
            lbl1Position7.TabIndex = 406;
            lbl1Position7.Text = "Eff:";
            // 
            // lbl1Position5Value
            // 
            lbl1Position5Value.AutoSize = true;
            lbl1Position5Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position5Value.ForeColor = Color.White;
            lbl1Position5Value.Location = new Point(215, 226);
            lbl1Position5Value.Name = "lbl1Position5Value";
            lbl1Position5Value.Size = new Size(21, 24);
            lbl1Position5Value.TabIndex = 401;
            lbl1Position5Value.Text = "9";
            lbl1Position5Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl1Position5
            // 
            lbl1Position5.AutoSize = true;
            lbl1Position5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position5.ForeColor = Color.White;
            lbl1Position5.Location = new Point(163, 226);
            lbl1Position5.Name = "lbl1Position5";
            lbl1Position5.Size = new Size(47, 24);
            lbl1Position5.TabIndex = 400;
            lbl1Position5.Text = "Def:";
            lbl1Position5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl1Position4Value
            // 
            lbl1Position4Value.AutoSize = true;
            lbl1Position4Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position4Value.ForeColor = Color.White;
            lbl1Position4Value.Location = new Point(345, 178);
            lbl1Position4Value.Name = "lbl1Position4Value";
            lbl1Position4Value.Size = new Size(21, 24);
            lbl1Position4Value.TabIndex = 399;
            lbl1Position4Value.Text = "9";
            // 
            // lbl1Position4
            // 
            lbl1Position4.AutoSize = true;
            lbl1Position4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position4.ForeColor = Color.White;
            lbl1Position4.Location = new Point(243, 177);
            lbl1Position4.Name = "lbl1Position4";
            lbl1Position4.Size = new Size(106, 24);
            lbl1Position4.TabIndex = 398;
            lbl1Position4.Text = "End State:";
            // 
            // lbl1Position3Des
            // 
            lbl1Position3Des.AutoSize = true;
            lbl1Position3Des.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position3Des.ForeColor = Color.White;
            lbl1Position3Des.Location = new Point(176, 150);
            lbl1Position3Des.Name = "lbl1Position3Des";
            lbl1Position3Des.Size = new Size(59, 24);
            lbl1Position3Des.TabIndex = 397;
            lbl1Position3Des.Text = "Floor";
            // 
            // lbl1Position3Source
            // 
            lbl1Position3Source.AutoSize = true;
            lbl1Position3Source.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position3Source.ForeColor = Color.White;
            lbl1Position3Source.Location = new Point(103, 150);
            lbl1Position3Source.Name = "lbl1Position3Source";
            lbl1Position3Source.Size = new Size(59, 24);
            lbl1Position3Source.TabIndex = 405;
            lbl1Position3Source.Text = "Floor";
            // 
            // lbl1Position2Des
            // 
            lbl1Position2Des.AutoSize = true;
            lbl1Position2Des.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position2Des.ForeColor = Color.White;
            lbl1Position2Des.Location = new Point(176, 112);
            lbl1Position2Des.Name = "lbl1Position2Des";
            lbl1Position2Des.Size = new Size(59, 24);
            lbl1Position2Des.TabIndex = 396;
            lbl1Position2Des.Text = "Floor";
            // 
            // lbl1Position2Source
            // 
            lbl1Position2Source.AutoSize = true;
            lbl1Position2Source.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position2Source.ForeColor = Color.White;
            lbl1Position2Source.Location = new Point(103, 112);
            lbl1Position2Source.Name = "lbl1Position2Source";
            lbl1Position2Source.Size = new Size(73, 24);
            lbl1Position2Source.TabIndex = 404;
            lbl1Position2Source.Text = "Station";
            // 
            // lbl1Position1
            // 
            lbl1Position1.AutoSize = true;
            lbl1Position1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position1.ForeColor = Color.White;
            lbl1Position1.Location = new Point(245, 56);
            lbl1Position1.Name = "lbl1Position1";
            lbl1Position1.Size = new Size(103, 24);
            lbl1Position1.TabIndex = 388;
            lbl1Position1.Text = "Near Side";
            // 
            // lbl1Position3Value
            // 
            lbl1Position3Value.AutoSize = true;
            lbl1Position3Value.BackColor = Color.Red;
            lbl1Position3Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl1Position3Value.ForeColor = Color.Red;
            lbl1Position3Value.ImageAlign = ContentAlignment.TopLeft;
            lbl1Position3Value.Location = new Point(72, 150);
            lbl1Position3Value.Name = "lbl1Position3Value";
            lbl1Position3Value.Size = new Size(16, 24);
            lbl1Position3Value.TabIndex = 395;
            lbl1Position3Value.Text = ".";
            lbl1Position3Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl1Position3
            // 
            lbl1Position3.AutoSize = true;
            lbl1Position3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position3.ForeColor = Color.White;
            lbl1Position3.Location = new Point(2, 148);
            lbl1Position3.Name = "lbl1Position3";
            lbl1Position3.Size = new Size(70, 24);
            lbl1Position3.TabIndex = 394;
            lbl1Position3.Text = "Algae:";
            // 
            // lbl1Position2Value
            // 
            lbl1Position2Value.AutoSize = true;
            lbl1Position2Value.BackColor = Color.Red;
            lbl1Position2Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl1Position2Value.ForeColor = Color.Red;
            lbl1Position2Value.ImageAlign = ContentAlignment.TopLeft;
            lbl1Position2Value.Location = new Point(72, 109);
            lbl1Position2Value.Name = "lbl1Position2Value";
            lbl1Position2Value.Size = new Size(16, 24);
            lbl1Position2Value.TabIndex = 392;
            lbl1Position2Value.Text = ".";
            lbl1Position2Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl1Position2
            // 
            lbl1Position2.AutoSize = true;
            lbl1Position2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1Position2.ForeColor = Color.White;
            lbl1Position2.Location = new Point(2, 110);
            lbl1Position2.Name = "lbl1Position2";
            lbl1Position2.Size = new Size(65, 24);
            lbl1Position2.TabIndex = 391;
            lbl1Position2.Text = "Coral:";
            // 
            // team1Divider
            // 
            team1Divider.BackColor = Color.Red;
            team1Divider.Location = new Point(-5, 88);
            team1Divider.Name = "team1Divider";
            team1Divider.Size = new Size(534, 11);
            team1Divider.TabIndex = 389;
            // 
            // team1ModeDivider
            // 
            team1ModeDivider.BackColor = Color.Red;
            team1ModeDivider.Location = new Point(-5, 40);
            team1ModeDivider.Name = "team1ModeDivider";
            team1ModeDivider.Size = new Size(534, 11);
            team1ModeDivider.TabIndex = 390;
            // 
            // team1TeamDivider
            // 
            team1TeamDivider.BackColor = Color.Red;
            team1TeamDivider.Location = new Point(0, 314);
            team1TeamDivider.Name = "team1TeamDivider";
            team1TeamDivider.Size = new Size(529, 11);
            team1TeamDivider.TabIndex = 279;
            // 
            // lbl1MatchEvent
            // 
            lbl1MatchEvent.AutoSize = true;
            lbl1MatchEvent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1MatchEvent.ForeColor = Color.White;
            lbl1MatchEvent.Location = new Point(2, 328);
            lbl1MatchEvent.Name = "lbl1MatchEvent";
            lbl1MatchEvent.Size = new Size(125, 24);
            lbl1MatchEvent.TabIndex = 291;
            lbl1MatchEvent.Text = "Match Event";
            // 
            // lbl1TeamName
            // 
            lbl1TeamName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl1TeamName.ForeColor = Color.Goldenrod;
            lbl1TeamName.Location = new Point(323, 347);
            lbl1TeamName.Name = "lbl1TeamName";
            lbl1TeamName.Size = new Size(159, 37);
            lbl1TeamName.TabIndex = 294;
            lbl1TeamName.Text = "Team 0";
            lbl1TeamName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl1ScoutName
            // 
            lbl1ScoutName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1ScoutName.ForeColor = Color.Goldenrod;
            lbl1ScoutName.Location = new Point(7, 359);
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
            lbl1ModeValue.Size = new Size(67, 29);
            lbl1ModeValue.TabIndex = 2;
            lbl1ModeValue.Text = "Auto:";
            // 
            // team2
            // 
            team2.BackColor = Color.Black;
            team2.Controls.Add(lbl2Position0Value);
            team2.Controls.Add(lbl2Position0);
            team2.Controls.Add(lbl2Position12Value);
            team2.Controls.Add(lbl2Position12);
            team2.Controls.Add(lbl2Position11Value);
            team2.Controls.Add(lbl2Position11);
            team2.Controls.Add(lbl2Position8Value);
            team2.Controls.Add(lbl2Position8);
            team2.Controls.Add(lbl2Position7Value);
            team2.Controls.Add(lbl2Position7);
            team2.Controls.Add(lbl2Position5Value);
            team2.Controls.Add(lbl2Position5);
            team2.Controls.Add(lbl2Position4Value);
            team2.Controls.Add(lbl2Position4);
            team2.Controls.Add(lbl2Position3Des);
            team2.Controls.Add(lbl2Position3Source);
            team2.Controls.Add(lbl2Position2Des);
            team2.Controls.Add(lbl2Position2Source);
            team2.Controls.Add(lbl2Position1);
            team2.Controls.Add(lbl2Position3Value);
            team2.Controls.Add(lbl2Position3);
            team2.Controls.Add(lbl2Position2Value);
            team2.Controls.Add(lbl2Position2);
            team2.Controls.Add(team2Divider);
            team2.Controls.Add(team2ModeDivider);
            team2.Controls.Add(team2TeamDivider);
            team2.Controls.Add(lbl2MatchEvent);
            team2.Controls.Add(lbl2TeamName);
            team2.Controls.Add(lbl2ScoutName);
            team2.Controls.Add(lbl2ModeValue);
            team2.Dock = DockStyle.Fill;
            team2.Location = new Point(971, 3);
            team2.Name = "team2";
            team2.Size = new Size(480, 399);
            team2.TabIndex = 347;
            // 
            // lbl2Position0Value
            // 
            lbl2Position0Value.AutoSize = true;
            lbl2Position0Value.BackColor = Color.Red;
            lbl2Position0Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl2Position0Value.ForeColor = Color.Red;
            lbl2Position0Value.ImageAlign = ContentAlignment.TopLeft;
            lbl2Position0Value.Location = new Point(72, 56);
            lbl2Position0Value.Name = "lbl2Position0Value";
            lbl2Position0Value.Size = new Size(16, 24);
            lbl2Position0Value.TabIndex = 393;
            lbl2Position0Value.Text = ".";
            lbl2Position0Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl2Position0
            // 
            lbl2Position0.AutoSize = true;
            lbl2Position0.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position0.ForeColor = Color.White;
            lbl2Position0.Location = new Point(2, 56);
            lbl2Position0.Name = "lbl2Position0";
            lbl2Position0.Size = new Size(66, 24);
            lbl2Position0.TabIndex = 387;
            lbl2Position0.Text = "Leave";
            // 
            // lbl2Position12Value
            // 
            lbl2Position12Value.AutoSize = true;
            lbl2Position12Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position12Value.ForeColor = Color.White;
            lbl2Position12Value.Location = new Point(52, 274);
            lbl2Position12Value.Name = "lbl2Position12Value";
            lbl2Position12Value.Size = new Size(21, 24);
            lbl2Position12Value.TabIndex = 411;
            lbl2Position12Value.Text = "9";
            // 
            // lbl2Position12
            // 
            lbl2Position12.AutoSize = true;
            lbl2Position12.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position12.ForeColor = Color.White;
            lbl2Position12.Location = new Point(2, 273);
            lbl2Position12.Name = "lbl2Position12";
            lbl2Position12.Size = new Size(57, 24);
            lbl2Position12.TabIndex = 410;
            lbl2Position12.Text = "Strat:";
            // 
            // lbl2Position11Value
            // 
            lbl2Position11Value.AutoSize = true;
            lbl2Position11Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position11Value.ForeColor = Color.White;
            lbl2Position11Value.Location = new Point(90, 246);
            lbl2Position11Value.Name = "lbl2Position11Value";
            lbl2Position11Value.Size = new Size(21, 24);
            lbl2Position11Value.TabIndex = 409;
            lbl2Position11Value.Text = "9";
            // 
            // lbl2Position11
            // 
            lbl2Position11.AutoSize = true;
            lbl2Position11.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position11.ForeColor = Color.White;
            lbl2Position11.Location = new Point(2, 246);
            lbl2Position11.Name = "lbl2Position11";
            lbl2Position11.Size = new Size(86, 24);
            lbl2Position11.TabIndex = 408;
            lbl2Position11.Text = "Attempt:";
            // 
            // lbl2Position8Value
            // 
            lbl2Position8Value.AutoSize = true;
            lbl2Position8Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position8Value.ForeColor = Color.White;
            lbl2Position8Value.Location = new Point(379, 229);
            lbl2Position8Value.Name = "lbl2Position8Value";
            lbl2Position8Value.Size = new Size(21, 24);
            lbl2Position8Value.TabIndex = 403;
            lbl2Position8Value.Text = "9";
            // 
            // lbl2Position8
            // 
            lbl2Position8.AutoSize = true;
            lbl2Position8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position8.ForeColor = Color.White;
            lbl2Position8.Location = new Point(315, 228);
            lbl2Position8.Name = "lbl2Position8";
            lbl2Position8.Size = new Size(69, 24);
            lbl2Position8.TabIndex = 402;
            lbl2Position8.Text = "Avoid:";
            // 
            // lbl2Position7Value
            // 
            lbl2Position7Value.AutoSize = true;
            lbl2Position7Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position7Value.ForeColor = Color.White;
            lbl2Position7Value.Location = new Point(316, 275);
            lbl2Position7Value.Name = "lbl2Position7Value";
            lbl2Position7Value.Size = new Size(21, 24);
            lbl2Position7Value.TabIndex = 407;
            lbl2Position7Value.Text = "9";
            // 
            // lbl2Position7
            // 
            lbl2Position7.AutoSize = true;
            lbl2Position7.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position7.ForeColor = Color.White;
            lbl2Position7.Location = new Point(281, 274);
            lbl2Position7.Name = "lbl2Position7";
            lbl2Position7.Size = new Size(40, 24);
            lbl2Position7.TabIndex = 406;
            lbl2Position7.Text = "Eff:";
            // 
            // lbl2Position5Value
            // 
            lbl2Position5Value.AutoSize = true;
            lbl2Position5Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position5Value.ForeColor = Color.White;
            lbl2Position5Value.Location = new Point(215, 227);
            lbl2Position5Value.Name = "lbl2Position5Value";
            lbl2Position5Value.Size = new Size(21, 24);
            lbl2Position5Value.TabIndex = 401;
            lbl2Position5Value.Text = "9";
            lbl2Position5Value.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl2Position5
            // 
            lbl2Position5.AutoSize = true;
            lbl2Position5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position5.ForeColor = Color.White;
            lbl2Position5.Location = new Point(163, 227);
            lbl2Position5.Name = "lbl2Position5";
            lbl2Position5.Size = new Size(47, 24);
            lbl2Position5.TabIndex = 400;
            lbl2Position5.Text = "Def:";
            lbl2Position5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl2Position4Value
            // 
            lbl2Position4Value.AutoSize = true;
            lbl2Position4Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position4Value.ForeColor = Color.White;
            lbl2Position4Value.Location = new Point(345, 179);
            lbl2Position4Value.Name = "lbl2Position4Value";
            lbl2Position4Value.Size = new Size(21, 24);
            lbl2Position4Value.TabIndex = 399;
            lbl2Position4Value.Text = "9";
            // 
            // lbl2Position4
            // 
            lbl2Position4.AutoSize = true;
            lbl2Position4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position4.ForeColor = Color.White;
            lbl2Position4.Location = new Point(243, 178);
            lbl2Position4.Name = "lbl2Position4";
            lbl2Position4.Size = new Size(106, 24);
            lbl2Position4.TabIndex = 398;
            lbl2Position4.Text = "End State:";
            // 
            // lbl2Position3Des
            // 
            lbl2Position3Des.AutoSize = true;
            lbl2Position3Des.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position3Des.ForeColor = Color.White;
            lbl2Position3Des.Location = new Point(176, 151);
            lbl2Position3Des.Name = "lbl2Position3Des";
            lbl2Position3Des.Size = new Size(59, 24);
            lbl2Position3Des.TabIndex = 397;
            lbl2Position3Des.Text = "Floor";
            // 
            // lbl2Position3Source
            // 
            lbl2Position3Source.AutoSize = true;
            lbl2Position3Source.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position3Source.ForeColor = Color.White;
            lbl2Position3Source.Location = new Point(103, 151);
            lbl2Position3Source.Name = "lbl2Position3Source";
            lbl2Position3Source.Size = new Size(59, 24);
            lbl2Position3Source.TabIndex = 405;
            lbl2Position3Source.Text = "Floor";
            // 
            // lbl2Position2Des
            // 
            lbl2Position2Des.AutoSize = true;
            lbl2Position2Des.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position2Des.ForeColor = Color.White;
            lbl2Position2Des.Location = new Point(176, 113);
            lbl2Position2Des.Name = "lbl2Position2Des";
            lbl2Position2Des.Size = new Size(59, 24);
            lbl2Position2Des.TabIndex = 396;
            lbl2Position2Des.Text = "Floor";
            // 
            // lbl2Position2Source
            // 
            lbl2Position2Source.AutoSize = true;
            lbl2Position2Source.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position2Source.ForeColor = Color.White;
            lbl2Position2Source.Location = new Point(103, 113);
            lbl2Position2Source.Name = "lbl2Position2Source";
            lbl2Position2Source.Size = new Size(73, 24);
            lbl2Position2Source.TabIndex = 404;
            lbl2Position2Source.Text = "Station";
            // 
            // lbl2Position1
            // 
            lbl2Position1.AutoSize = true;
            lbl2Position1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position1.ForeColor = Color.White;
            lbl2Position1.Location = new Point(245, 57);
            lbl2Position1.Name = "lbl2Position1";
            lbl2Position1.Size = new Size(103, 24);
            lbl2Position1.TabIndex = 388;
            lbl2Position1.Text = "Near Side";
            // 
            // lbl2Position3Value
            // 
            lbl2Position3Value.AutoSize = true;
            lbl2Position3Value.BackColor = Color.Red;
            lbl2Position3Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl2Position3Value.ForeColor = Color.Red;
            lbl2Position3Value.ImageAlign = ContentAlignment.TopLeft;
            lbl2Position3Value.Location = new Point(72, 151);
            lbl2Position3Value.Name = "lbl2Position3Value";
            lbl2Position3Value.Size = new Size(16, 24);
            lbl2Position3Value.TabIndex = 395;
            lbl2Position3Value.Text = ".";
            lbl2Position3Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl2Position3
            // 
            lbl2Position3.AutoSize = true;
            lbl2Position3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position3.ForeColor = Color.White;
            lbl2Position3.Location = new Point(2, 149);
            lbl2Position3.Name = "lbl2Position3";
            lbl2Position3.Size = new Size(70, 24);
            lbl2Position3.TabIndex = 394;
            lbl2Position3.Text = "Algae:";
            // 
            // lbl2Position2Value
            // 
            lbl2Position2Value.AutoSize = true;
            lbl2Position2Value.BackColor = Color.Red;
            lbl2Position2Value.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lbl2Position2Value.ForeColor = Color.Red;
            lbl2Position2Value.ImageAlign = ContentAlignment.TopLeft;
            lbl2Position2Value.Location = new Point(72, 110);
            lbl2Position2Value.Name = "lbl2Position2Value";
            lbl2Position2Value.Size = new Size(16, 24);
            lbl2Position2Value.TabIndex = 392;
            lbl2Position2Value.Text = ".";
            lbl2Position2Value.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl2Position2
            // 
            lbl2Position2.AutoSize = true;
            lbl2Position2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2Position2.ForeColor = Color.White;
            lbl2Position2.Location = new Point(2, 111);
            lbl2Position2.Name = "lbl2Position2";
            lbl2Position2.Size = new Size(65, 24);
            lbl2Position2.TabIndex = 391;
            lbl2Position2.Text = "Coral:";
            // 
            // team2Divider
            // 
            team2Divider.BackColor = Color.Red;
            team2Divider.Location = new Point(-5, 89);
            team2Divider.Name = "team2Divider";
            team2Divider.Size = new Size(534, 11);
            team2Divider.TabIndex = 389;
            // 
            // team2ModeDivider
            // 
            team2ModeDivider.BackColor = Color.Red;
            team2ModeDivider.Location = new Point(-5, 41);
            team2ModeDivider.Name = "team2ModeDivider";
            team2ModeDivider.Size = new Size(534, 11);
            team2ModeDivider.TabIndex = 390;
            // 
            // team2TeamDivider
            // 
            team2TeamDivider.BackColor = Color.Red;
            team2TeamDivider.Location = new Point(0, 314);
            team2TeamDivider.Name = "team2TeamDivider";
            team2TeamDivider.Size = new Size(529, 11);
            team2TeamDivider.TabIndex = 279;
            // 
            // lbl2MatchEvent
            // 
            lbl2MatchEvent.AutoSize = true;
            lbl2MatchEvent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2MatchEvent.ForeColor = Color.White;
            lbl2MatchEvent.Location = new Point(6, 328);
            lbl2MatchEvent.Name = "lbl2MatchEvent";
            lbl2MatchEvent.Size = new Size(125, 24);
            lbl2MatchEvent.TabIndex = 291;
            lbl2MatchEvent.Text = "Match Event";
            // 
            // lbl2TeamName
            // 
            lbl2TeamName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl2TeamName.ForeColor = Color.Goldenrod;
            lbl2TeamName.Location = new Point(323, 347);
            lbl2TeamName.Name = "lbl2TeamName";
            lbl2TeamName.Size = new Size(159, 37);
            lbl2TeamName.TabIndex = 294;
            lbl2TeamName.Text = "Team 0";
            lbl2TeamName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl2ScoutName
            // 
            lbl2ScoutName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl2ScoutName.ForeColor = Color.Goldenrod;
            lbl2ScoutName.Location = new Point(7, 359);
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
            lbl2ModeValue.Size = new Size(67, 29);
            lbl2ModeValue.TabIndex = 2;
            lbl2ModeValue.Text = "Auto:";
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
            // BaseScreen
            // 
            AutoScroll = true;
            BackColor = Color.Black;
            ClientSize = new Size(1460, 872);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BaseScreen";
            WindowState = FormWindowState.Maximized;
            blueTeams.ResumeLayout(false);
            team3.ResumeLayout(false);
            team3.PerformLayout();
            team4.ResumeLayout(false);
            team4.PerformLayout();
            team5.ResumeLayout(false);
            team5.PerformLayout();
            redTeams.ResumeLayout(false);
            team0.ResumeLayout(false);
            team0.PerformLayout();
            team1.ResumeLayout(false);
            team1.PerformLayout();
            team2.ResumeLayout(false);
            team2.PerformLayout();
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
        private Panel team5;
        private Panel team5TeamDivider;
        private Panel team4;
        private Panel team3;
        private TableLayoutPanel redTeams;
        private Panel team2;
        private Label lbl2MatchEvent;
        private Label lbl2TeamName;
        private Label lbl2ScoutName;
        private Label lbl2ModeValue;
        private Panel team1;
        private Label lbl1MatchEvent;
        private Label lbl1TeamName;
        private Label lbl1ScoutName;
        private Panel team0;
        private Panel team4TeamDivider;
        private Panel team3TeamDivider;
        private Label lbl1ModeValue;
        private Panel team0TeamDivider;
        private Label lbl0MatchEvent;
        private Label lbl0TeamName;
        private Label lbl0ScoutName;
        private Label lbl0ModeValue;
        private System.ComponentModel.IContainer components = null;
        private Label labelMatch;
        private Label lblMatch;
        private System.Windows.Forms.Timer timerJoysticks;
        private Label lbl5MatchEvent;
        private Label lbl5TeamName;
        private Label lbl5ScoutName;
        private Label lbl5ModeValue;
        private Label lbl4MatchEvent;
        private Label lbl4TeamName;
        private Label lbl4ScoutName;
        private Label lbl4ModeValue;
        private Label lbl3MatchEvent;
        private Label lbl3TeamName;
        private Label lbl3ScoutName;
        private Label lbl3ModeValue;
        private Button btnFunctions;
        private Panel team2TeamDivider;
        private Panel team1TeamDivider;
        private Label lbl0Position0Value;
        private Label lbl0Position0;
        private Label lbl0Position12Value;
        private Label lbl0Position12;
        private Label lbl0Position11Value;
        private Label lbl0Position11;
        private Label lbl0Position8Value;
        private Label lbl0Position8;
        private Label lbl0Position7Value;
        private Label lbl0Position7;
        private Label lbl0Position5Value;
        private Label lbl0Position5;
        private Label lbl0Position4Value;
        private Label lbl0Position4;
        private Label lbl0Position3Des;
        private Label lbl0Position3Source;
        private Label lbl0Position2Des;
        private Label lbl0Position2Source;
        private Label lbl0Position1;
        private Label lbl0Position3Value;
        private Label lbl0Position3;
        private Label lbl0Position2Value;
        private Label lbl0Position2;
        private Panel team0Divider;
        private Panel team0ModeDivider;
        private Label lbl1Position0Value;
        private Label lbl1Position0;
        private Label lbl1Position12Value;
        private Label lbl1Position12;
        private Label lbl1Position11Value;
        private Label lbl1Position11;
        private Label lbl1Position8Value;
        private Label lbl1Position8;
        private Label lbl1Position7Value;
        private Label lbl1Position7;
        private Label lbl1Position5Value;
        private Label lbl1Position5;
        private Label lbl1Position4Value;
        private Label lbl1Position4;
        private Label lbl1Position3Des;
        private Label lbl1Position3Source;
        private Label lbl1Position2Des;
        private Label lbl1Position2Source;
        private Label lbl1Position1;
        private Label lbl1Position3Value;
        private Label lbl1Position3;
        private Label lbl1Position2Value;
        private Label lbl1Position2;
        private Panel team1Divider;
        private Panel team1ModeDivider;
        private Label lbl2Position0Value;
        private Label lbl2Position0;
        private Label lbl2Position12Value;
        private Label lbl2Position12;
        private Label lbl2Position11Value;
        private Label lbl2Position11;
        private Label lbl2Position8Value;
        private Label lbl2Position8;
        private Label lbl2Position7Value;
        private Label lbl2Position7;
        private Label lbl2Position5Value;
        private Label lbl2Position5;
        private Label lbl2Position4Value;
        private Label lbl2Position4;
        private Label lbl2Position3Des;
        private Label lbl2Position3Source;
        private Label lbl2Position2Des;
        private Label lbl2Position2Source;
        private Label lbl2Position1;
        private Label lbl2Position3Value;
        private Label lbl2Position3;
        private Label lbl2Position2Value;
        private Label lbl2Position2;
        private Panel team2Divider;
        private Panel team2ModeDivider;
        private Label lbl3Position0Value;
        private Label lbl3Position0;
        private Label lbl3Position12Value;
        private Label lbl3Position12;
        private Label lbl3Position11Value;
        private Label lbl3Position11;
        private Label lbl3Position8Value;
        private Label lbl3Position8;
        private Label lbl3Position7Value;
        private Label lbl3Position7;
        private Label lbl3Position5Value;
        private Label lbl3Position5;
        private Label lbl3Position4Value;
        private Label lbl3Position4;
        private Label lbl3Position3Des;
        private Label lbl3Position3Source;
        private Label lbl3Position2Des;
        private Label lbl3Position2Source;
        private Label lbl3Position1;
        private Label lbl3Position3Value;
        private Label lbl3Position3;
        private Label lbl3Position2Value;
        private Label lbl3Position2;
        private Panel team3Divider;
        private Panel team3ModeDivider;
        private Label lbl4Position0Value;
        private Label lbl4Position0;
        private Label lbl4Position12Value;
        private Label lbl4Position12;
        private Label lbl4Position11Value;
        private Label lbl4Position11;
        private Label lbl4Position8Value;
        private Label lbl4Position8;
        private Label lbl4Position7Value;
        private Label lbl4Position7;
        private Label lbl4Position5Value;
        private Label lbl4Position5;
        private Label lbl4Position4Value;
        private Label lbl4Position4;
        private Label lbl4Position3Des;
        private Label lbl4Position3Source;
        private Label lbl4Position2Des;
        private Label lbl4Position2Source;
        private Label lbl4Position1;
        private Label lbl4Position3Value;
        private Label lbl4Position3;
        private Label lbl4Position2Value;
        private Label lbl4Position2;
        private Panel team4Divider;
        private Panel team4ModeDivider;
        private Label lbl5Position0Value;
        private Label lbl5Position0;
        private Label lbl5Position12Value;
        private Label lbl5Position12;
        private Label lbl5Position11Value;
        private Label lbl5Position11;
        private Label lbl5Position8Value;
        private Label lbl5Position8;
        private Label lbl5Position7Value;
        private Label lbl5Position7;
        private Label lbl5Position5Value;
        private Label lbl5Position5;
        private Label lbl5Position4Value;
        private Label lbl5Position4;
        private Label lbl5Position3Des;
        private Label lbl5Position3Source;
        private Label lbl5Position2Des;
        private Label lbl5Position2Source;
        private Label lbl5Position1;
        private Label lbl5Position3Value;
        private Label lbl5Position3;
        private Label lbl5Position2Value;
        private Label lbl5Position2;
        private Panel team5Divider;
        private Panel team5ModeDivider;
        private Label lblBlueScore;
        private Label lblRedScore;
        private Panel statusLight;
        private Panel topPanel;
        private scoutingdbDataSetTableAdapters.__MigrationHistoryTableAdapter ___MigrationHistoryTableAdapter;
    }
}
