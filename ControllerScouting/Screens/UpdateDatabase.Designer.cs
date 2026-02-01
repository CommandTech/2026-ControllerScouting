using System;
using System.Linq;

namespace ControllerScouting.Screens
{
    partial class UpdateDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel10 = new Panel();
            panel12 = new Panel();
            btnFetchValues = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            btnUpdateDatabase = new Button();
            button2 = new Button();
            checkEndMatch = new CheckBox();
            checkEndAuto = new CheckBox();
            panel3 = new Panel();
            groupBox3 = new GroupBox();
            ClimbLevelValue = new ComboBox();
            label10 = new Label();
            DefenseStrategyValue = new ComboBox();
            label9 = new Label();
            AvoidanceStrategyValue = new ComboBox();
            label16 = new Label();
            ClimbSuccessValue = new ComboBox();
            EndGameClimbTimerValue = new TextBox();
            label26 = new Label();
            label24 = new Label();
            groupBox1 = new GroupBox();
            AutoClimbValue = new ComboBox();
            AutoClimbLabel = new Label();
            groupBox2 = new GroupBox();
            TeleopShootingTimerValue = new TextBox();
            TeleopIntakeTimerValue = new TextBox();
            TeleopDefenseTimerValue = new TextBox();
            TeleopFeedingTimerValue = new TextBox();
            label1 = new Label();
            label6 = new Label();
            label8 = new Label();
            TeleopBumpValue = new TextBox();
            label15 = new Label();
            label18 = new Label();
            panel4 = new Panel();
            StartingLocationValue = new ComboBox();
            label33 = new Label();
            label34 = new Label();
            label4 = new Label();
            MatchEventValue = new ComboBox();
            StrategyValue = new ComboBox();
            panel11 = new Panel();
            label37 = new Label();
            panel2 = new Panel();
            comboTeamNumber = new ComboBox();
            label2 = new Label();
            comboMatchNumber = new ComboBox();
            label7 = new Label();
            checkActivities = new CheckBox();
            checkMatchEvent = new CheckBox();
            btnCreateTable = new Button();
            scoutingDBDataSet = new scoutingdbDataSet();
            updatePreviewsBindingSource = new BindingSource(components);
            updatePreviewsTableAdapter = new ControllerScouting.scoutingdbDataSetTableAdapters.UpdatePreviewsTableAdapter();
            panel1 = new Panel();
            label3 = new Label();
            txtID = new TextBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            teamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matchDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recordTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            modeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DriveSta = new DataGridViewTextBoxColumn();
            Defense = new DataGridViewTextBoxColumn();
            DefenseValue = new DataGridViewTextBoxColumn();
            Avoidance = new DataGridViewTextBoxColumn();
            ScouterName = new DataGridViewTextBoxColumn();
            ScouterError = new DataGridViewTextBoxColumn();
            Match_event = new DataGridViewTextBoxColumn();
            Strategy = new DataGridViewTextBoxColumn();
            Coop = new DataGridViewTextBoxColumn();
            DZTime = new DataGridViewTextBoxColumn();
            Del_Near_Far = new DataGridViewTextBoxColumn();
            AcqAlgae_Near_Far = new DataGridViewTextBoxColumn();
            AcqCoral_Near_Far = new DataGridViewTextBoxColumn();
            Starting_Loc = new DataGridViewTextBoxColumn();
            Leave = new DataGridViewTextBoxColumn();
            AcqCoralS = new DataGridViewTextBoxColumn();
            AcqCoralF = new DataGridViewTextBoxColumn();
            AcqAlgaeR = new DataGridViewTextBoxColumn();
            AcqAlgaeF = new DataGridViewTextBoxColumn();
            DelCoralL1 = new DataGridViewTextBoxColumn();
            DelCoralL2 = new DataGridViewTextBoxColumn();
            DelCoralL3 = new DataGridViewTextBoxColumn();
            DelCoralL4 = new DataGridViewTextBoxColumn();
            DelCoralF = new DataGridViewTextBoxColumn();
            DelAlgaeP = new DataGridViewTextBoxColumn();
            DelAlgaeN = new DataGridViewTextBoxColumn();
            DelAlgaeF = new DataGridViewTextBoxColumn();
            ClimbT = new DataGridViewTextBoxColumn();
            EndState = new DataGridViewTextBoxColumn();
            CageAttempt = new DataGridViewTextBoxColumn();
            PointScored = new DataGridViewTextBoxColumn();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            panel11.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scoutingDBDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updatePreviewsBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel10
            // 
            panel10.BackColor = Color.Goldenrod;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(panel12);
            panel10.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel10.Location = new Point(694, 583);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(159, 30);
            panel10.TabIndex = 363;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Black;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Controls.Add(btnFetchValues);
            panel12.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel12.Location = new Point(-2, -2);
            panel12.Margin = new Padding(3, 2, 3, 2);
            panel12.Name = "panel12";
            panel12.Size = new Size(159, 30);
            panel12.TabIndex = 351;
            // 
            // btnFetchValues
            // 
            btnFetchValues.BackColor = Color.Black;
            btnFetchValues.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFetchValues.ForeColor = Color.AliceBlue;
            btnFetchValues.Location = new Point(6, 2);
            btnFetchValues.Margin = new Padding(4);
            btnFetchValues.Name = "btnFetchValues";
            btnFetchValues.Size = new Size(146, 26);
            btnFetchValues.TabIndex = 11;
            btnFetchValues.Text = "Fetch Values";
            btnFetchValues.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Goldenrod;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(button2);
            panel5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel5.Location = new Point(858, 583);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(159, 30);
            panel5.TabIndex = 362;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Goldenrod;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(panel7);
            panel6.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel6.Location = new Point(-2, -2);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(159, 30);
            panel6.TabIndex = 351;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Goldenrod;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(panel8);
            panel7.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel7.Location = new Point(-2, -2);
            panel7.Margin = new Padding(3, 2, 3, 2);
            panel7.Name = "panel7";
            panel7.Size = new Size(159, 30);
            panel7.TabIndex = 351;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(btnUpdateDatabase);
            panel8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel8.Location = new Point(-2, -2);
            panel8.Margin = new Padding(3, 2, 3, 2);
            panel8.Name = "panel8";
            panel8.Size = new Size(159, 30);
            panel8.TabIndex = 351;
            // 
            // btnUpdateDatabase
            // 
            btnUpdateDatabase.BackColor = Color.Black;
            btnUpdateDatabase.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateDatabase.ForeColor = Color.AliceBlue;
            btnUpdateDatabase.Location = new Point(4, 2);
            btnUpdateDatabase.Margin = new Padding(4);
            btnUpdateDatabase.Name = "btnUpdateDatabase";
            btnUpdateDatabase.Size = new Size(146, 26);
            btnUpdateDatabase.TabIndex = 11;
            btnUpdateDatabase.Text = "Update Database";
            btnUpdateDatabase.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.MidnightBlue;
            button2.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.AliceBlue;
            button2.Location = new Point(4, 2);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(146, 26);
            button2.TabIndex = 11;
            button2.Text = "Update Database";
            button2.UseVisualStyleBackColor = false;
            // 
            // checkEndMatch
            // 
            checkEndMatch.AutoSize = true;
            checkEndMatch.BackColor = Color.Black;
            checkEndMatch.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkEndMatch.ForeColor = Color.White;
            checkEndMatch.Location = new Point(452, 21);
            checkEndMatch.Margin = new Padding(4);
            checkEndMatch.Name = "checkEndMatch";
            checkEndMatch.Size = new Size(79, 17);
            checkEndMatch.TabIndex = 357;
            checkEndMatch.Text = "EndMatch";
            checkEndMatch.UseVisualStyleBackColor = false;
            // 
            // checkEndAuto
            // 
            checkEndAuto.AutoSize = true;
            checkEndAuto.BackColor = Color.Black;
            checkEndAuto.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkEndAuto.ForeColor = Color.White;
            checkEndAuto.Location = new Point(364, 21);
            checkEndAuto.Margin = new Padding(4);
            checkEndAuto.Name = "checkEndAuto";
            checkEndAuto.Size = new Size(72, 17);
            checkEndAuto.TabIndex = 356;
            checkEndAuto.Text = "EndAuto";
            checkEndAuto.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(panel4);
            panel3.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.Location = new Point(14, 103);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1005, 235);
            panel3.TabIndex = 359;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Black;
            groupBox3.Controls.Add(AutoClimbValue);
            groupBox3.Controls.Add(AutoClimbLabel);
            groupBox3.Controls.Add(ClimbLevelValue);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(DefenseStrategyValue);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(AvoidanceStrategyValue);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(ClimbSuccessValue);
            groupBox3.Controls.Add(label24);
            groupBox3.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            groupBox3.Location = new Point(408, 7);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(262, 175);
            groupBox3.TabIndex = 41;
            groupBox3.TabStop = false;
            groupBox3.Text = "Booleans";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // ClimbLevelValue
            // 
            ClimbLevelValue.BackColor = Color.Black;
            ClimbLevelValue.ForeColor = Color.White;
            ClimbLevelValue.FormattingEnabled = true;
            ClimbLevelValue.Items.AddRange(new object[] { "-", "Y", "N" });
            ClimbLevelValue.Location = new Point(101, 87);
            ClimbLevelValue.Margin = new Padding(4);
            ClimbLevelValue.Name = "ClimbLevelValue";
            ClimbLevelValue.Size = new Size(70, 23);
            ClimbLevelValue.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(95, 68);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(68, 13);
            label10.TabIndex = 49;
            label10.Text = "Climb Level";
            // 
            // DefenseStrategyValue
            // 
            DefenseStrategyValue.BackColor = Color.Black;
            DefenseStrategyValue.ForeColor = Color.White;
            DefenseStrategyValue.FormattingEnabled = true;
            DefenseStrategyValue.Items.AddRange(new object[] { "-", "Elsewhere", "Park", "Shallow", "Deep" });
            DefenseStrategyValue.Location = new Point(101, 36);
            DefenseStrategyValue.Margin = new Padding(4);
            DefenseStrategyValue.Name = "DefenseStrategyValue";
            DefenseStrategyValue.Size = new Size(70, 23);
            DefenseStrategyValue.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(97, 17);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(49, 13);
            label9.TabIndex = 47;
            label9.Text = "Defense";
            // 
            // AvoidanceStrategyValue
            // 
            AvoidanceStrategyValue.BackColor = Color.Black;
            AvoidanceStrategyValue.ForeColor = Color.White;
            AvoidanceStrategyValue.FormattingEnabled = true;
            AvoidanceStrategyValue.Items.AddRange(new object[] { "-", "Elsewhere", "Park", "Shallow", "Deep" });
            AvoidanceStrategyValue.Location = new Point(14, 36);
            AvoidanceStrategyValue.Margin = new Padding(4);
            AvoidanceStrategyValue.Name = "AvoidanceStrategyValue";
            AvoidanceStrategyValue.Size = new Size(70, 23);
            AvoidanceStrategyValue.TabIndex = 44;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(10, 17);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(62, 13);
            label16.TabIndex = 43;
            label16.Text = "Avoidance";
            label16.Click += label16_Click;
            // 
            // ClimbSuccessValue
            // 
            ClimbSuccessValue.BackColor = Color.Black;
            ClimbSuccessValue.ForeColor = Color.White;
            ClimbSuccessValue.FormattingEnabled = true;
            ClimbSuccessValue.Items.AddRange(new object[] { "-", "Y", "N" });
            ClimbSuccessValue.Location = new Point(16, 88);
            ClimbSuccessValue.Margin = new Padding(4);
            ClimbSuccessValue.Name = "ClimbSuccessValue";
            ClimbSuccessValue.Size = new Size(70, 23);
            ClimbSuccessValue.TabIndex = 38;
            // 
            // EndGameClimbTimerValue
            // 
            EndGameClimbTimerValue.BackColor = SystemColors.InfoText;
            EndGameClimbTimerValue.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EndGameClimbTimerValue.ForeColor = Color.White;
            EndGameClimbTimerValue.Location = new Point(136, 87);
            EndGameClimbTimerValue.Margin = new Padding(4);
            EndGameClimbTimerValue.Name = "EndGameClimbTimerValue";
            EndGameClimbTimerValue.Size = new Size(50, 22);
            EndGameClimbTimerValue.TabIndex = 41;
            EndGameClimbTimerValue.TextAlign = HorizontalAlignment.Center;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label26.Location = new Point(131, 70);
            label26.Margin = new Padding(4, 0, 4, 0);
            label26.Name = "label26";
            label26.Size = new Size(66, 13);
            label26.TabIndex = 40;
            label26.Text = "Climb Time";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(10, 69);
            label24.Margin = new Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new Size(80, 13);
            label24.TabIndex = 35;
            label24.Text = "Climb Success";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(TeleopBumpValue);
            groupBox1.Controls.Add(label8);
            groupBox1.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(14, 6);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(134, 176);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Counters";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // AutoClimbValue
            // 
            AutoClimbValue.BackColor = Color.Black;
            AutoClimbValue.ForeColor = Color.White;
            AutoClimbValue.FormattingEnabled = true;
            AutoClimbValue.Items.AddRange(new object[] { "-", "Station", "Floor" });
            AutoClimbValue.Location = new Point(16, 136);
            AutoClimbValue.Margin = new Padding(4);
            AutoClimbValue.Name = "AutoClimbValue";
            AutoClimbValue.Size = new Size(105, 23);
            AutoClimbValue.TabIndex = 354;
            // 
            // AutoClimbLabel
            // 
            AutoClimbLabel.AutoSize = true;
            AutoClimbLabel.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AutoClimbLabel.Location = new Point(14, 118);
            AutoClimbLabel.Margin = new Padding(4, 0, 4, 0);
            AutoClimbLabel.Name = "AutoClimbLabel";
            AutoClimbLabel.Size = new Size(67, 13);
            AutoClimbLabel.TabIndex = 29;
            AutoClimbLabel.Text = "Climb Auto";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Black;
            groupBox2.Controls.Add(TeleopShootingTimerValue);
            groupBox2.Controls.Add(TeleopIntakeTimerValue);
            groupBox2.Controls.Add(TeleopDefenseTimerValue);
            groupBox2.Controls.Add(TeleopFeedingTimerValue);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(EndGameClimbTimerValue);
            groupBox2.Controls.Add(label26);
            groupBox2.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(159, 5);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(241, 177);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            groupBox2.Text = "Timers";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // TeleopShootingTimerValue
            // 
            TeleopShootingTimerValue.BackColor = SystemColors.InfoText;
            TeleopShootingTimerValue.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeleopShootingTimerValue.ForeColor = Color.White;
            TeleopShootingTimerValue.Location = new Point(10, 138);
            TeleopShootingTimerValue.Margin = new Padding(4);
            TeleopShootingTimerValue.Name = "TeleopShootingTimerValue";
            TeleopShootingTimerValue.Size = new Size(76, 22);
            TeleopShootingTimerValue.TabIndex = 391;
            TeleopShootingTimerValue.TextAlign = HorizontalAlignment.Center;
            // 
            // TeleopIntakeTimerValue
            // 
            TeleopIntakeTimerValue.BackColor = SystemColors.InfoText;
            TeleopIntakeTimerValue.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeleopIntakeTimerValue.ForeColor = Color.White;
            TeleopIntakeTimerValue.Location = new Point(136, 39);
            TeleopIntakeTimerValue.Margin = new Padding(4);
            TeleopIntakeTimerValue.Name = "TeleopIntakeTimerValue";
            TeleopIntakeTimerValue.Size = new Size(76, 22);
            TeleopIntakeTimerValue.TabIndex = 390;
            TeleopIntakeTimerValue.TextAlign = HorizontalAlignment.Center;
            // 
            // TeleopDefenseTimerValue
            // 
            TeleopDefenseTimerValue.BackColor = SystemColors.InfoText;
            TeleopDefenseTimerValue.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeleopDefenseTimerValue.ForeColor = Color.White;
            TeleopDefenseTimerValue.Location = new Point(11, 87);
            TeleopDefenseTimerValue.Margin = new Padding(4);
            TeleopDefenseTimerValue.Name = "TeleopDefenseTimerValue";
            TeleopDefenseTimerValue.Size = new Size(76, 22);
            TeleopDefenseTimerValue.TabIndex = 389;
            TeleopDefenseTimerValue.TextAlign = HorizontalAlignment.Center;
            // 
            // TeleopFeedingTimerValue
            // 
            TeleopFeedingTimerValue.BackColor = SystemColors.InfoText;
            TeleopFeedingTimerValue.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeleopFeedingTimerValue.ForeColor = Color.White;
            TeleopFeedingTimerValue.Location = new Point(10, 37);
            TeleopFeedingTimerValue.Margin = new Padding(4);
            TeleopFeedingTimerValue.Name = "TeleopFeedingTimerValue";
            TeleopFeedingTimerValue.Size = new Size(76, 22);
            TeleopFeedingTimerValue.TabIndex = 388;
            TeleopFeedingTimerValue.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 13);
            label1.TabIndex = 386;
            label1.Text = "Intake timer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 121);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(88, 13);
            label6.TabIndex = 384;
            label6.Text = "Shooting Timer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(4, 20);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 366;
            label8.Text = "Bump";
            label8.Click += label8_Click;
            // 
            // TeleopBumpValue
            // 
            TeleopBumpValue.BackColor = SystemColors.InfoText;
            TeleopBumpValue.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TeleopBumpValue.ForeColor = Color.White;
            TeleopBumpValue.Location = new Point(8, 39);
            TeleopBumpValue.Margin = new Padding(4);
            TeleopBumpValue.Name = "TeleopBumpValue";
            TeleopBumpValue.Size = new Size(36, 22);
            TeleopBumpValue.TabIndex = 365;
            TeleopBumpValue.TextAlign = HorizontalAlignment.Center;
            TeleopBumpValue.TextChanged += TeleopBumpValue_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(9, 70);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(78, 13);
            label15.TabIndex = 361;
            label15.Text = "Defense Time";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(8, 21);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(78, 13);
            label18.TabIndex = 29;
            label18.Text = "Feeding Time";
            label18.Click += label18_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(StartingLocationValue);
            panel4.Controls.Add(label33);
            panel4.Controls.Add(label34);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(MatchEventValue);
            panel4.Controls.Add(StrategyValue);
            panel4.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel4.Location = new Point(677, 16);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(315, 72);
            panel4.TabIndex = 349;
            // 
            // StartingLocationValue
            // 
            StartingLocationValue.BackColor = Color.Black;
            StartingLocationValue.ForeColor = Color.White;
            StartingLocationValue.FormattingEnabled = true;
            StartingLocationValue.Items.AddRange(new object[] { "-", "Y", "N" });
            StartingLocationValue.Location = new Point(5, 25);
            StartingLocationValue.Margin = new Padding(4);
            StartingLocationValue.Name = "StartingLocationValue";
            StartingLocationValue.Size = new Size(84, 21);
            StartingLocationValue.TabIndex = 59;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.BackColor = Color.Black;
            label33.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label33.ForeColor = SystemColors.ButtonFace;
            label33.Location = new Point(201, 5);
            label33.Margin = new Padding(4, 0, 4, 0);
            label33.Name = "label33";
            label33.Size = new Size(57, 15);
            label33.TabIndex = 57;
            label33.Text = "Strategy";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = Color.Black;
            label34.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.ForeColor = SystemColors.ButtonFace;
            label34.Location = new Point(1, 4);
            label34.Margin = new Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new Size(106, 15);
            label34.TabIndex = 55;
            label34.Text = "Starting Location";
            label34.Click += label34_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(103, 5);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 45;
            label4.Text = "Match Event";
            // 
            // MatchEventValue
            // 
            MatchEventValue.BackColor = Color.Black;
            MatchEventValue.ForeColor = Color.White;
            MatchEventValue.FormattingEnabled = true;
            MatchEventValue.Items.AddRange(new object[] { "Match_Event", "BrokeDown", "CrossedCenter", "LostParts", "AdditionPiece", "MultiClimb", "NoShow", "TippedOver", "JammedPiece", "WentUnderCages" });
            MatchEventValue.Location = new Point(104, 25);
            MatchEventValue.Margin = new Padding(4);
            MatchEventValue.Name = "MatchEventValue";
            MatchEventValue.Size = new Size(84, 21);
            MatchEventValue.TabIndex = 42;
            // 
            // StrategyValue
            // 
            StrategyValue.BackColor = Color.Black;
            StrategyValue.ForeColor = Color.White;
            StrategyValue.FormattingEnabled = true;
            StrategyValue.Items.AddRange(new object[] { "None", "Defense", "CoralScorer", "AlgaeScorer", "Hybrid", "Surfacing" });
            StrategyValue.Location = new Point(204, 25);
            StrategyValue.Margin = new Padding(4);
            StrategyValue.Name = "StrategyValue";
            StrategyValue.Size = new Size(74, 21);
            StrategyValue.TabIndex = 43;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.Controls.Add(label37);
            panel11.Controls.Add(panel2);
            panel11.Controls.Add(checkActivities);
            panel11.Controls.Add(checkMatchEvent);
            panel11.Controls.Add(btnCreateTable);
            panel11.Location = new Point(-4, 4);
            panel11.Margin = new Padding(4);
            panel11.Name = "panel11";
            panel11.Size = new Size(1044, 94);
            panel11.TabIndex = 361;
            panel11.Paint += panel11_Paint;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label37.ForeColor = Color.Red;
            label37.ImageAlign = ContentAlignment.TopLeft;
            label37.Location = new Point(487, 247);
            label37.Margin = new Padding(4, 0, 4, 0);
            label37.Name = "label37";
            label37.Size = new Size(38, 26);
            label37.TabIndex = 277;
            label37.Text = "00";
            label37.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(comboTeamNumber);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(comboMatchNumber);
            panel2.Controls.Add(label7);
            panel2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.Location = new Point(94, 11);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 71);
            panel2.TabIndex = 344;
            // 
            // comboTeamNumber
            // 
            comboTeamNumber.BackColor = Color.Black;
            comboTeamNumber.ForeColor = Color.White;
            comboTeamNumber.FormattingEnabled = true;
            comboTeamNumber.Location = new Point(6, 28);
            comboTeamNumber.Margin = new Padding(4);
            comboTeamNumber.Name = "comboTeamNumber";
            comboTeamNumber.Size = new Size(108, 25);
            comboTeamNumber.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 5);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 9;
            label2.Text = "Team Number";
            // 
            // comboMatchNumber
            // 
            comboMatchNumber.BackColor = Color.Black;
            comboMatchNumber.ForeColor = Color.White;
            comboMatchNumber.FormattingEnabled = true;
            comboMatchNumber.Location = new Point(136, 28);
            comboMatchNumber.Margin = new Padding(4);
            comboMatchNumber.Name = "comboMatchNumber";
            comboMatchNumber.Size = new Size(108, 25);
            comboMatchNumber.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(136, 5);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 10;
            label7.Text = "Match Number";
            // 
            // checkActivities
            // 
            checkActivities.AutoSize = true;
            checkActivities.BackColor = Color.Black;
            checkActivities.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkActivities.ForeColor = Color.White;
            checkActivities.Location = new Point(368, 64);
            checkActivities.Margin = new Padding(4);
            checkActivities.Name = "checkActivities";
            checkActivities.Size = new Size(73, 17);
            checkActivities.TabIndex = 4;
            checkActivities.Text = "Activities";
            checkActivities.UseVisualStyleBackColor = false;
            // 
            // checkMatchEvent
            // 
            checkMatchEvent.AutoSize = true;
            checkMatchEvent.BackColor = Color.Black;
            checkMatchEvent.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkMatchEvent.ForeColor = Color.White;
            checkMatchEvent.Location = new Point(456, 64);
            checkMatchEvent.Margin = new Padding(4);
            checkMatchEvent.Name = "checkMatchEvent";
            checkMatchEvent.Size = new Size(88, 17);
            checkMatchEvent.TabIndex = 6;
            checkMatchEvent.Text = "MatchEvent";
            checkMatchEvent.UseVisualStyleBackColor = false;
            // 
            // btnCreateTable
            // 
            btnCreateTable.BackColor = Color.Black;
            btnCreateTable.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateTable.ForeColor = Color.AliceBlue;
            btnCreateTable.Location = new Point(642, 13);
            btnCreateTable.Margin = new Padding(4);
            btnCreateTable.Name = "btnCreateTable";
            btnCreateTable.Size = new Size(146, 26);
            btnCreateTable.TabIndex = 11;
            btnCreateTable.Text = "Create Table";
            btnCreateTable.UseVisualStyleBackColor = false;
            // 
            // scoutingDBDataSet
            // 
            scoutingDBDataSet.DataSetName = "scoutingdbDataSet";
            scoutingDBDataSet.Namespace = "http://tempuri.org/scoutingdbDataSet.xsd";
            scoutingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // updatePreviewsBindingSource
            // 
            updatePreviewsBindingSource.DataMember = "UpdatePreviews";
            updatePreviewsBindingSource.DataSource = scoutingDBDataSet;
            // 
            // updatePreviewsTableAdapter
            // 
            updatePreviewsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(14, 335);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 223);
            panel1.TabIndex = 358;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(626, 590);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 365;
            label3.Text = "ID";
            // 
            // txtID
            // 
            txtID.BackColor = Color.Black;
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(651, 589);
            txtID.Margin = new Padding(4);
            txtID.Name = "txtID";
            txtID.Size = new Size(38, 23);
            txtID.TabIndex = 364;
            txtID.TextAlign = HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, teamDataGridViewTextBoxColumn, matchDataGridViewTextBoxColumn, timeDataGridViewTextBoxColumn, recordTypeDataGridViewTextBoxColumn, modeDataGridViewTextBoxColumn, DriveSta, Defense, DefenseValue, Avoidance, ScouterName, ScouterError, Match_event, Strategy, Coop, DZTime, Del_Near_Far, AcqAlgae_Near_Far, AcqCoral_Near_Far, Starting_Loc, Leave, AcqCoralS, AcqCoralF, AcqAlgaeR, AcqAlgaeF, DelCoralL1, DelCoralL2, DelCoralL3, DelCoralL4, DelCoralF, DelAlgaeP, DelAlgaeN, DelAlgaeF, ClimbT, EndState, CageAttempt, PointScored });
            dataGridView1.DataSource = updatePreviewsBindingSource;
            dataGridView1.Location = new Point(2, 2);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(984, 261);
            dataGridView1.TabIndex = 12;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // teamDataGridViewTextBoxColumn
            // 
            teamDataGridViewTextBoxColumn.DataPropertyName = "Team";
            teamDataGridViewTextBoxColumn.HeaderText = "Team";
            teamDataGridViewTextBoxColumn.MinimumWidth = 6;
            teamDataGridViewTextBoxColumn.Name = "teamDataGridViewTextBoxColumn";
            teamDataGridViewTextBoxColumn.Width = 125;
            // 
            // matchDataGridViewTextBoxColumn
            // 
            matchDataGridViewTextBoxColumn.DataPropertyName = "Match";
            matchDataGridViewTextBoxColumn.HeaderText = "Match";
            matchDataGridViewTextBoxColumn.MinimumWidth = 6;
            matchDataGridViewTextBoxColumn.Name = "matchDataGridViewTextBoxColumn";
            matchDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Time";
            timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // recordTypeDataGridViewTextBoxColumn
            // 
            recordTypeDataGridViewTextBoxColumn.DataPropertyName = "RecordType";
            recordTypeDataGridViewTextBoxColumn.HeaderText = "RecordType";
            recordTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            recordTypeDataGridViewTextBoxColumn.Name = "recordTypeDataGridViewTextBoxColumn";
            recordTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // modeDataGridViewTextBoxColumn
            // 
            modeDataGridViewTextBoxColumn.DataPropertyName = "Mode";
            modeDataGridViewTextBoxColumn.HeaderText = "Mode";
            modeDataGridViewTextBoxColumn.MinimumWidth = 6;
            modeDataGridViewTextBoxColumn.Name = "modeDataGridViewTextBoxColumn";
            modeDataGridViewTextBoxColumn.Width = 125;
            // 
            // DriveSta
            // 
            DriveSta.DataPropertyName = "DriveSta";
            DriveSta.HeaderText = "DriveSta";
            DriveSta.MinimumWidth = 6;
            DriveSta.Name = "DriveSta";
            DriveSta.Width = 125;
            // 
            // Defense
            // 
            Defense.DataPropertyName = "Defense";
            Defense.HeaderText = "Defense";
            Defense.MinimumWidth = 6;
            Defense.Name = "Defense";
            Defense.Width = 125;
            // 
            // DefenseValue
            // 
            DefenseValue.DataPropertyName = "DefenseValue";
            DefenseValue.HeaderText = "DefenseValue";
            DefenseValue.MinimumWidth = 6;
            DefenseValue.Name = "DefenseValue";
            DefenseValue.Width = 125;
            // 
            // Avoidance
            // 
            Avoidance.DataPropertyName = "Avoidance";
            Avoidance.HeaderText = "Avoidance";
            Avoidance.MinimumWidth = 6;
            Avoidance.Name = "Avoidance";
            Avoidance.Width = 125;
            // 
            // ScouterName
            // 
            ScouterName.DataPropertyName = "ScouterName";
            ScouterName.HeaderText = "ScouterName";
            ScouterName.MinimumWidth = 6;
            ScouterName.Name = "ScouterName";
            ScouterName.Width = 125;
            // 
            // ScouterError
            // 
            ScouterError.DataPropertyName = "ScouterError";
            ScouterError.HeaderText = "ScouterError";
            ScouterError.MinimumWidth = 6;
            ScouterError.Name = "ScouterError";
            ScouterError.Width = 125;
            // 
            // Match_event
            // 
            Match_event.DataPropertyName = "Match_event";
            Match_event.HeaderText = "Match_event";
            Match_event.MinimumWidth = 6;
            Match_event.Name = "Match_event";
            Match_event.Width = 125;
            // 
            // Strategy
            // 
            Strategy.DataPropertyName = "Strategy";
            Strategy.HeaderText = "Strategy";
            Strategy.MinimumWidth = 6;
            Strategy.Name = "Strategy";
            Strategy.Width = 125;
            // 
            // Coop
            // 
            Coop.DataPropertyName = "Coop";
            Coop.HeaderText = "Coop";
            Coop.MinimumWidth = 6;
            Coop.Name = "Coop";
            Coop.Width = 125;
            // 
            // DZTime
            // 
            DZTime.DataPropertyName = "DZTime";
            DZTime.HeaderText = "DZTime";
            DZTime.MinimumWidth = 6;
            DZTime.Name = "DZTime";
            DZTime.Width = 125;
            // 
            // Del_Near_Far
            // 
            Del_Near_Far.DataPropertyName = "Del_Near_Far";
            Del_Near_Far.HeaderText = "Del_Near_Far";
            Del_Near_Far.MinimumWidth = 6;
            Del_Near_Far.Name = "Del_Near_Far";
            Del_Near_Far.Width = 125;
            // 
            // AcqAlgae_Near_Far
            // 
            AcqAlgae_Near_Far.DataPropertyName = "AcqAlgae_Near_Far";
            AcqAlgae_Near_Far.HeaderText = "AcqAlgae_Near_Far";
            AcqAlgae_Near_Far.MinimumWidth = 6;
            AcqAlgae_Near_Far.Name = "AcqAlgae_Near_Far";
            AcqAlgae_Near_Far.Width = 125;
            // 
            // AcqCoral_Near_Far
            // 
            AcqCoral_Near_Far.DataPropertyName = "AcqCoral_Near_Far";
            AcqCoral_Near_Far.HeaderText = "AcqCoral_Near_Far";
            AcqCoral_Near_Far.MinimumWidth = 6;
            AcqCoral_Near_Far.Name = "AcqCoral_Near_Far";
            AcqCoral_Near_Far.Width = 125;
            // 
            // Starting_Loc
            // 
            Starting_Loc.DataPropertyName = "Starting_Loc";
            Starting_Loc.HeaderText = "Starting_Loc";
            Starting_Loc.MinimumWidth = 6;
            Starting_Loc.Name = "Starting_Loc";
            Starting_Loc.Width = 125;
            // 
            // Leave
            // 
            Leave.DataPropertyName = "Leave";
            Leave.HeaderText = "Leave";
            Leave.MinimumWidth = 6;
            Leave.Name = "Leave";
            Leave.Width = 125;
            // 
            // AcqCoralS
            // 
            AcqCoralS.DataPropertyName = "AcqCoralS";
            AcqCoralS.HeaderText = "AcqCoralS";
            AcqCoralS.MinimumWidth = 6;
            AcqCoralS.Name = "AcqCoralS";
            AcqCoralS.Width = 125;
            // 
            // AcqCoralF
            // 
            AcqCoralF.DataPropertyName = "AcqCoralF";
            AcqCoralF.HeaderText = "AcqCoralF";
            AcqCoralF.MinimumWidth = 6;
            AcqCoralF.Name = "AcqCoralF";
            AcqCoralF.Width = 125;
            // 
            // AcqAlgaeR
            // 
            AcqAlgaeR.DataPropertyName = "AcqAlgaeR";
            AcqAlgaeR.HeaderText = "AcqAlgaeR";
            AcqAlgaeR.MinimumWidth = 6;
            AcqAlgaeR.Name = "AcqAlgaeR";
            AcqAlgaeR.Width = 125;
            // 
            // AcqAlgaeF
            // 
            AcqAlgaeF.DataPropertyName = "AcqAlgaeF";
            AcqAlgaeF.HeaderText = "AcqAlgaeF";
            AcqAlgaeF.MinimumWidth = 6;
            AcqAlgaeF.Name = "AcqAlgaeF";
            AcqAlgaeF.Width = 125;
            // 
            // DelCoralL1
            // 
            DelCoralL1.DataPropertyName = "DelCoralL1";
            DelCoralL1.HeaderText = "DelCoralL1";
            DelCoralL1.MinimumWidth = 6;
            DelCoralL1.Name = "DelCoralL1";
            DelCoralL1.Width = 125;
            // 
            // DelCoralL2
            // 
            DelCoralL2.DataPropertyName = "DelCoralL2";
            DelCoralL2.HeaderText = "DelCoralL2";
            DelCoralL2.MinimumWidth = 6;
            DelCoralL2.Name = "DelCoralL2";
            DelCoralL2.Width = 125;
            // 
            // DelCoralL3
            // 
            DelCoralL3.DataPropertyName = "DelCoralL3";
            DelCoralL3.HeaderText = "DelCoralL3";
            DelCoralL3.MinimumWidth = 6;
            DelCoralL3.Name = "DelCoralL3";
            DelCoralL3.Width = 125;
            // 
            // DelCoralL4
            // 
            DelCoralL4.DataPropertyName = "DelCoralL4";
            DelCoralL4.HeaderText = "DelCoralL4";
            DelCoralL4.MinimumWidth = 6;
            DelCoralL4.Name = "DelCoralL4";
            DelCoralL4.Width = 125;
            // 
            // DelCoralF
            // 
            DelCoralF.DataPropertyName = "DelCoralF";
            DelCoralF.HeaderText = "DelCoralF";
            DelCoralF.MinimumWidth = 6;
            DelCoralF.Name = "DelCoralF";
            DelCoralF.Width = 125;
            // 
            // DelAlgaeP
            // 
            DelAlgaeP.DataPropertyName = "DelAlgaeP";
            DelAlgaeP.HeaderText = "DelAlgaeP";
            DelAlgaeP.MinimumWidth = 6;
            DelAlgaeP.Name = "DelAlgaeP";
            DelAlgaeP.Width = 125;
            // 
            // DelAlgaeN
            // 
            DelAlgaeN.DataPropertyName = "DelAlgaeN";
            DelAlgaeN.HeaderText = "DelAlgaeN";
            DelAlgaeN.MinimumWidth = 6;
            DelAlgaeN.Name = "DelAlgaeN";
            DelAlgaeN.Width = 125;
            // 
            // DelAlgaeF
            // 
            DelAlgaeF.DataPropertyName = "DelAlgaeF";
            DelAlgaeF.HeaderText = "DelAlgaeF";
            DelAlgaeF.MinimumWidth = 6;
            DelAlgaeF.Name = "DelAlgaeF";
            DelAlgaeF.Width = 125;
            // 
            // ClimbT
            // 
            ClimbT.DataPropertyName = "ClimbT";
            ClimbT.HeaderText = "ClimbT";
            ClimbT.MinimumWidth = 6;
            ClimbT.Name = "ClimbT";
            ClimbT.Width = 125;
            // 
            // EndState
            // 
            EndState.DataPropertyName = "EndState";
            EndState.HeaderText = "EndState";
            EndState.MinimumWidth = 6;
            EndState.Name = "EndState";
            EndState.Width = 125;
            // 
            // CageAttempt
            // 
            CageAttempt.DataPropertyName = "CageAttempt";
            CageAttempt.HeaderText = "CageAttempt";
            CageAttempt.MinimumWidth = 6;
            CageAttempt.Name = "CageAttempt";
            CageAttempt.Width = 125;
            // 
            // PointScored
            // 
            PointScored.DataPropertyName = "PointScored";
            PointScored.HeaderText = "PointScored";
            PointScored.MinimumWidth = 6;
            PointScored.Name = "PointScored";
            PointScored.Width = 125;
            // 
            // UpdateDatabase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1032, 623);
            Controls.Add(label3);
            Controls.Add(txtID);
            Controls.Add(panel10);
            Controls.Add(panel5);
            Controls.Add(checkEndMatch);
            Controls.Add(checkEndAuto);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel11);
            Margin = new Padding(4);
            Name = "UpdateDatabase";
            Text = "UpdateDatabase";
            panel10.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scoutingDBDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)updatePreviewsBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkEndMatch;
        private System.Windows.Forms.CheckBox checkEndAuto;
        private scoutingdbDataSet scoutingDBDataSet;
        private System.Windows.Forms.BindingSource updatePreviewsBindingSource;
        private scoutingdbDataSetTableAdapters.UpdatePreviewsTableAdapter updatePreviewsTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn acqLocDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn acqCenterDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn acqDisDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn acqDrpDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn delOrigDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn delDestDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn delMissDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn robotStaDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn hPAmpDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn stageStatDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn stageAttDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn stageLocDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn harmonyDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn spotlitDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn oZTimeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nZTimeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn aZTimeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn micsDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn matcheventDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.CheckBox checkActivities;
        private System.Windows.Forms.CheckBox checkMatchEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnFetchValues;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnUpdateDatabase;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboTeamNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMatchNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox AvoidanceStrategyValue;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox ClimbSuccessValue;
        private System.Windows.Forms.TextBox EndGameClimbTimerValue;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox IntakeTimerValue;
        private System.Windows.Forms.ComboBox BumpBool;
        private System.Windows.Forms.ComboBox ShootingTimerValue;
        private System.Windows.Forms.ComboBox AutoClimbValue;
        private System.Windows.Forms.Label AutoClimbLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboCoralDelSide;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboCoralDelDest;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MatchEventValue;
        private System.Windows.Forms.ComboBox StrategyValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TeleopBumpValue;
        private System.Windows.Forms.ComboBox StartingLocationValue;
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox DefenseStrategyValue;
        private Label label9;
        private ComboBox ClimbLevelValue;
        private Label label10;
        private TextBox TeleopShootingTimerValue;
        private TextBox TeleopIntakeTimerValue;
        private TextBox TeleopDefenseTimerValue;
        private TextBox TeleopFeedingTimerValue;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matchDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recordTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DriveSta;
        private DataGridViewTextBoxColumn Defense;
        private DataGridViewTextBoxColumn DefenseValue;
        private DataGridViewTextBoxColumn Avoidance;
        private DataGridViewTextBoxColumn ScouterName;
        private DataGridViewTextBoxColumn ScouterError;
        private DataGridViewTextBoxColumn Match_event;
        private DataGridViewTextBoxColumn Strategy;
        private DataGridViewTextBoxColumn Coop;
        private DataGridViewTextBoxColumn DZTime;
        private DataGridViewTextBoxColumn Del_Near_Far;
        private DataGridViewTextBoxColumn AcqAlgae_Near_Far;
        private DataGridViewTextBoxColumn AcqCoral_Near_Far;
        private DataGridViewTextBoxColumn Starting_Loc;
        private DataGridViewTextBoxColumn Leave;
        private DataGridViewTextBoxColumn AcqCoralS;
        private DataGridViewTextBoxColumn AcqCoralF;
        private DataGridViewTextBoxColumn AcqAlgaeR;
        private DataGridViewTextBoxColumn AcqAlgaeF;
        private DataGridViewTextBoxColumn DelCoralL1;
        private DataGridViewTextBoxColumn DelCoralL2;
        private DataGridViewTextBoxColumn DelCoralL3;
        private DataGridViewTextBoxColumn DelCoralL4;
        private DataGridViewTextBoxColumn DelCoralF;
        private DataGridViewTextBoxColumn DelAlgaeP;
        private DataGridViewTextBoxColumn DelAlgaeN;
        private DataGridViewTextBoxColumn DelAlgaeF;
        private DataGridViewTextBoxColumn ClimbT;
        private DataGridViewTextBoxColumn EndState;
        private DataGridViewTextBoxColumn CageAttempt;
        private DataGridViewTextBoxColumn PointScored;
    }
}