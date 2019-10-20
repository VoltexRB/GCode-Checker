namespace GCode_Checker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TB_PATH = new System.Windows.Forms.TextBox();
            this.BT_OPEN = new System.Windows.Forms.Button();
            this.PA_RESULT = new System.Windows.Forms.Panel();
            this.CB_BED = new System.Windows.Forms.CheckBox();
            this.TB_BEDX = new System.Windows.Forms.TextBox();
            this.TB_BEDY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_HOTEND_TEMP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_BED_TEMP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_BED_BL = new System.Windows.Forms.RadioButton();
            this.RB_BED_CENTER = new System.Windows.Forms.RadioButton();
            this.OF_GCODE = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PA_SETTINGS = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.CB_M201 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.CB_M304 = new System.Windows.Forms.CheckBox();
            this.CB_M500 = new System.Windows.Forms.CheckBox();
            this.CB_M906 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.CB_G20 = new System.Windows.Forms.CheckBox();
            this.CB_M502 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.CB_G91 = new System.Windows.Forms.CheckBox();
            this.CB_M428 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.CB_M92 = new System.Windows.Forms.CheckBox();
            this.CB_M410 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.CB_M110 = new System.Windows.Forms.CheckBox();
            this.CB_M401 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.CB_M149 = new System.Windows.Forms.CheckBox();
            this.CB_M302 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.CB_M203 = new System.Windows.Forms.CheckBox();
            this.CB_M350 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.CB_M303 = new System.Windows.Forms.CheckBox();
            this.CB_M206 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.CB_M301 = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.CB_M211 = new System.Windows.Forms.CheckBox();
            this.CB_M220 = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CB_ALL = new System.Windows.Forms.CheckBox();
            this.BT_GO = new System.Windows.Forms.Button();
            this.BT_ABORT = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.PA_SETTINGS.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_PATH
            // 
            this.TB_PATH.BackColor = System.Drawing.SystemColors.Window;
            this.TB_PATH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_PATH.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TB_PATH.Enabled = false;
            this.TB_PATH.Location = new System.Drawing.Point(111, 15);
            this.TB_PATH.Name = "TB_PATH";
            this.TB_PATH.ReadOnly = true;
            this.TB_PATH.Size = new System.Drawing.Size(677, 20);
            this.TB_PATH.TabIndex = 0;
            // 
            // BT_OPEN
            // 
            this.BT_OPEN.Location = new System.Drawing.Point(21, 12);
            this.BT_OPEN.Name = "BT_OPEN";
            this.BT_OPEN.Size = new System.Drawing.Size(75, 23);
            this.BT_OPEN.TabIndex = 1;
            this.BT_OPEN.Text = "Open File";
            this.BT_OPEN.UseVisualStyleBackColor = true;
            this.BT_OPEN.Click += new System.EventHandler(this.BT_OPEN_Click);
            // 
            // PA_RESULT
            // 
            this.PA_RESULT.AutoScroll = true;
            this.PA_RESULT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PA_RESULT.Location = new System.Drawing.Point(330, 41);
            this.PA_RESULT.Name = "PA_RESULT";
            this.PA_RESULT.Size = new System.Drawing.Size(458, 364);
            this.PA_RESULT.TabIndex = 2;
            // 
            // CB_BED
            // 
            this.CB_BED.AutoSize = true;
            this.CB_BED.Location = new System.Drawing.Point(30, 25);
            this.CB_BED.Name = "CB_BED";
            this.CB_BED.Size = new System.Drawing.Size(105, 17);
            this.CB_BED.TabIndex = 3;
            this.CB_BED.Text = "Check Boundary";
            this.CB_BED.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.CB_BED.UseVisualStyleBackColor = true;
            this.CB_BED.CheckedChanged += new System.EventHandler(this.CB_BED_CheckedChanged);
            // 
            // TB_BEDX
            // 
            this.TB_BEDX.BackColor = System.Drawing.Color.White;
            this.TB_BEDX.Enabled = false;
            this.TB_BEDX.Location = new System.Drawing.Point(197, 19);
            this.TB_BEDX.MaxLength = 3;
            this.TB_BEDX.Name = "TB_BEDX";
            this.TB_BEDX.ReadOnly = true;
            this.TB_BEDX.Size = new System.Drawing.Size(71, 20);
            this.TB_BEDX.TabIndex = 4;
            this.TB_BEDX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_BEDX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Values_KeyDown);
            // 
            // TB_BEDY
            // 
            this.TB_BEDY.BackColor = System.Drawing.Color.White;
            this.TB_BEDY.Enabled = false;
            this.TB_BEDY.Location = new System.Drawing.Point(197, 48);
            this.TB_BEDY.MaxLength = 3;
            this.TB_BEDY.Name = "TB_BEDY";
            this.TB_BEDY.ReadOnly = true;
            this.TB_BEDY.Size = new System.Drawing.Size(71, 20);
            this.TB_BEDY.TabIndex = 5;
            this.TB_BEDY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_BEDY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Values_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TB_HOTEND_TEMP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_BED_TEMP);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.CB_BED);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_BEDX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TB_BEDY);
            this.groupBox1.Location = new System.Drawing.Point(21, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tool Settings";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "mm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Head Max °C:";
            // 
            // TB_HOTEND_TEMP
            // 
            this.TB_HOTEND_TEMP.BackColor = System.Drawing.Color.White;
            this.TB_HOTEND_TEMP.Enabled = false;
            this.TB_HOTEND_TEMP.Location = new System.Drawing.Point(233, 106);
            this.TB_HOTEND_TEMP.MaxLength = 3;
            this.TB_HOTEND_TEMP.Name = "TB_HOTEND_TEMP";
            this.TB_HOTEND_TEMP.ReadOnly = true;
            this.TB_HOTEND_TEMP.Size = new System.Drawing.Size(64, 20);
            this.TB_HOTEND_TEMP.TabIndex = 12;
            this.TB_HOTEND_TEMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_HOTEND_TEMP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Values_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bed Max °C:";
            // 
            // TB_BED_TEMP
            // 
            this.TB_BED_TEMP.BackColor = System.Drawing.Color.White;
            this.TB_BED_TEMP.Enabled = false;
            this.TB_BED_TEMP.Location = new System.Drawing.Point(81, 106);
            this.TB_BED_TEMP.MaxLength = 3;
            this.TB_BED_TEMP.Name = "TB_BED_TEMP";
            this.TB_BED_TEMP.ReadOnly = true;
            this.TB_BED_TEMP.Size = new System.Drawing.Size(64, 20);
            this.TB_BED_TEMP.TabIndex = 10;
            this.TB_BED_TEMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_BED_TEMP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Values_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB_BED_BL);
            this.groupBox2.Controls.Add(this.RB_BED_CENTER);
            this.groupBox2.Location = new System.Drawing.Point(6, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 49);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Origin At:";
            // 
            // RB_BED_BL
            // 
            this.RB_BED_BL.AutoSize = true;
            this.RB_BED_BL.Enabled = false;
            this.RB_BED_BL.Location = new System.Drawing.Point(71, 19);
            this.RB_BED_BL.Name = "RB_BED_BL";
            this.RB_BED_BL.Size = new System.Drawing.Size(79, 17);
            this.RB_BED_BL.TabIndex = 1;
            this.RB_BED_BL.TabStop = true;
            this.RB_BED_BL.Text = "Bottom Left";
            this.RB_BED_BL.UseVisualStyleBackColor = true;
            // 
            // RB_BED_CENTER
            // 
            this.RB_BED_CENTER.AutoSize = true;
            this.RB_BED_CENTER.Enabled = false;
            this.RB_BED_CENTER.Location = new System.Drawing.Point(9, 19);
            this.RB_BED_CENTER.Name = "RB_BED_CENTER";
            this.RB_BED_CENTER.Size = new System.Drawing.Size(56, 17);
            this.RB_BED_CENTER.TabIndex = 0;
            this.RB_BED_CENTER.TabStop = true;
            this.RB_BED_CENTER.Text = "Center";
            this.RB_BED_CENTER.UseVisualStyleBackColor = true;
            // 
            // OF_GCODE
            // 
            this.OF_GCODE.FileName = "openFileDialog1";
            this.OF_GCODE.Filter = "gcode files (*.gcode)|*.gcode";
            this.OF_GCODE.FileOk += new System.ComponentModel.CancelEventHandler(this.OF_GCODE_FileOk);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PA_SETTINGS);
            this.groupBox3.Location = new System.Drawing.Point(21, 204);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 240);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Check For:";
            // 
            // PA_SETTINGS
            // 
            this.PA_SETTINGS.AutoScroll = true;
            this.PA_SETTINGS.Controls.Add(this.label14);
            this.PA_SETTINGS.Controls.Add(this.CB_M201);
            this.PA_SETTINGS.Controls.Add(this.label20);
            this.PA_SETTINGS.Controls.Add(this.label28);
            this.PA_SETTINGS.Controls.Add(this.CB_M304);
            this.PA_SETTINGS.Controls.Add(this.CB_M500);
            this.PA_SETTINGS.Controls.Add(this.CB_M906);
            this.PA_SETTINGS.Controls.Add(this.label7);
            this.PA_SETTINGS.Controls.Add(this.label27);
            this.PA_SETTINGS.Controls.Add(this.CB_G20);
            this.PA_SETTINGS.Controls.Add(this.CB_M502);
            this.PA_SETTINGS.Controls.Add(this.label8);
            this.PA_SETTINGS.Controls.Add(this.label26);
            this.PA_SETTINGS.Controls.Add(this.CB_G91);
            this.PA_SETTINGS.Controls.Add(this.CB_M428);
            this.PA_SETTINGS.Controls.Add(this.label9);
            this.PA_SETTINGS.Controls.Add(this.label25);
            this.PA_SETTINGS.Controls.Add(this.CB_M92);
            this.PA_SETTINGS.Controls.Add(this.CB_M410);
            this.PA_SETTINGS.Controls.Add(this.label10);
            this.PA_SETTINGS.Controls.Add(this.label24);
            this.PA_SETTINGS.Controls.Add(this.CB_M110);
            this.PA_SETTINGS.Controls.Add(this.CB_M401);
            this.PA_SETTINGS.Controls.Add(this.label11);
            this.PA_SETTINGS.Controls.Add(this.label23);
            this.PA_SETTINGS.Controls.Add(this.CB_M149);
            this.PA_SETTINGS.Controls.Add(this.CB_M302);
            this.PA_SETTINGS.Controls.Add(this.label12);
            this.PA_SETTINGS.Controls.Add(this.label22);
            this.PA_SETTINGS.Controls.Add(this.CB_M203);
            this.PA_SETTINGS.Controls.Add(this.CB_M350);
            this.PA_SETTINGS.Controls.Add(this.label13);
            this.PA_SETTINGS.Controls.Add(this.label21);
            this.PA_SETTINGS.Controls.Add(this.CB_M303);
            this.PA_SETTINGS.Controls.Add(this.CB_M206);
            this.PA_SETTINGS.Controls.Add(this.label15);
            this.PA_SETTINGS.Controls.Add(this.label19);
            this.PA_SETTINGS.Controls.Add(this.CB_M301);
            this.PA_SETTINGS.Controls.Add(this.label18);
            this.PA_SETTINGS.Controls.Add(this.CB_M211);
            this.PA_SETTINGS.Controls.Add(this.CB_M220);
            this.PA_SETTINGS.Controls.Add(this.label17);
            this.PA_SETTINGS.Location = new System.Drawing.Point(6, 12);
            this.PA_SETTINGS.Name = "PA_SETTINGS";
            this.PA_SETTINGS.Size = new System.Drawing.Size(291, 218);
            this.PA_SETTINGS.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(73, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "change max Acceleration";
            // 
            // CB_M201
            // 
            this.CB_M201.AutoSize = true;
            this.CB_M201.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M201.Location = new System.Drawing.Point(12, 199);
            this.CB_M201.Name = "CB_M201";
            this.CB_M201.Size = new System.Drawing.Size(57, 17);
            this.CB_M201.TabIndex = 14;
            this.CB_M201.Text = "M201";
            this.CB_M201.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(78, 384);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "Change Bed PID Tune";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(76, 62);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(168, 13);
            this.label28.TabIndex = 43;
            this.label28.Text = "Change Steppermotor max current";
            // 
            // CB_M304
            // 
            this.CB_M304.AutoSize = true;
            this.CB_M304.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M304.Location = new System.Drawing.Point(12, 383);
            this.CB_M304.Name = "CB_M304";
            this.CB_M304.Size = new System.Drawing.Size(57, 17);
            this.CB_M304.TabIndex = 26;
            this.CB_M304.Text = "M304";
            this.CB_M304.UseVisualStyleBackColor = true;
            // 
            // CB_M500
            // 
            this.CB_M500.AutoCheck = false;
            this.CB_M500.AutoSize = true;
            this.CB_M500.Checked = true;
            this.CB_M500.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_M500.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M500.ForeColor = System.Drawing.Color.Maroon;
            this.CB_M500.Location = new System.Drawing.Point(14, 15);
            this.CB_M500.Name = "CB_M500";
            this.CB_M500.Size = new System.Drawing.Size(57, 17);
            this.CB_M500.TabIndex = 0;
            this.CB_M500.Text = "M500";
            this.CB_M500.UseVisualStyleBackColor = true;
            // 
            // CB_M906
            // 
            this.CB_M906.AutoSize = true;
            this.CB_M906.Checked = true;
            this.CB_M906.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_M906.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M906.ForeColor = System.Drawing.Color.Maroon;
            this.CB_M906.Location = new System.Drawing.Point(13, 61);
            this.CB_M906.Name = "CB_M906";
            this.CB_M906.Size = new System.Drawing.Size(68, 17);
            this.CB_M906.TabIndex = 42;
            this.CB_M906.Text = "M906-7";
            this.CB_M906.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "save to EEPROM";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(74, 39);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(114, 13);
            this.label27.TabIndex = 41;
            this.label27.Text = "Factory Reset Settings";
            // 
            // CB_G20
            // 
            this.CB_G20.AutoSize = true;
            this.CB_G20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_G20.Location = new System.Drawing.Point(13, 84);
            this.CB_G20.Name = "CB_G20";
            this.CB_G20.Size = new System.Drawing.Size(49, 17);
            this.CB_G20.TabIndex = 2;
            this.CB_G20.Text = "G20";
            this.CB_G20.UseVisualStyleBackColor = true;
            // 
            // CB_M502
            // 
            this.CB_M502.AutoSize = true;
            this.CB_M502.Checked = true;
            this.CB_M502.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_M502.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M502.ForeColor = System.Drawing.Color.Maroon;
            this.CB_M502.Location = new System.Drawing.Point(14, 38);
            this.CB_M502.Name = "CB_M502";
            this.CB_M502.Size = new System.Drawing.Size(57, 17);
            this.CB_M502.TabIndex = 40;
            this.CB_M502.Text = "M502";
            this.CB_M502.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "change units to Inches";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(80, 476);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(143, 13);
            this.label26.TabIndex = 39;
            this.label26.Text = "Set current position as Home";
            // 
            // CB_G91
            // 
            this.CB_G91.AutoSize = true;
            this.CB_G91.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_G91.Location = new System.Drawing.Point(13, 107);
            this.CB_G91.Name = "CB_G91";
            this.CB_G91.Size = new System.Drawing.Size(49, 17);
            this.CB_G91.TabIndex = 4;
            this.CB_G91.Text = "G91";
            this.CB_G91.UseVisualStyleBackColor = true;
            // 
            // CB_M428
            // 
            this.CB_M428.AutoSize = true;
            this.CB_M428.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M428.Location = new System.Drawing.Point(12, 475);
            this.CB_M428.Name = "CB_M428";
            this.CB_M428.Size = new System.Drawing.Size(57, 17);
            this.CB_M428.TabIndex = 38;
            this.CB_M428.Text = "M428";
            this.CB_M428.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(73, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "change positioning to relative";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(78, 453);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(138, 13);
            this.label25.TabIndex = 37;
            this.label25.Text = "Instantly power off Steppers";
            // 
            // CB_M92
            // 
            this.CB_M92.AutoSize = true;
            this.CB_M92.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M92.Location = new System.Drawing.Point(13, 130);
            this.CB_M92.Name = "CB_M92";
            this.CB_M92.Size = new System.Drawing.Size(50, 17);
            this.CB_M92.TabIndex = 6;
            this.CB_M92.Text = "M92";
            this.CB_M92.UseVisualStyleBackColor = true;
            // 
            // CB_M410
            // 
            this.CB_M410.AutoSize = true;
            this.CB_M410.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M410.Location = new System.Drawing.Point(12, 452);
            this.CB_M410.Name = "CB_M410";
            this.CB_M410.Size = new System.Drawing.Size(57, 17);
            this.CB_M410.TabIndex = 36;
            this.CB_M410.Text = "M410";
            this.CB_M410.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "change E-Steps";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(78, 430);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 13);
            this.label24.TabIndex = 35;
            this.label24.Text = "deploy bed Probe";
            // 
            // CB_M110
            // 
            this.CB_M110.AutoSize = true;
            this.CB_M110.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M110.Location = new System.Drawing.Point(12, 153);
            this.CB_M110.Name = "CB_M110";
            this.CB_M110.Size = new System.Drawing.Size(57, 17);
            this.CB_M110.TabIndex = 8;
            this.CB_M110.Text = "M110";
            this.CB_M110.UseVisualStyleBackColor = true;
            // 
            // CB_M401
            // 
            this.CB_M401.AutoSize = true;
            this.CB_M401.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M401.Location = new System.Drawing.Point(12, 429);
            this.CB_M401.Name = "CB_M401";
            this.CB_M401.Size = new System.Drawing.Size(57, 17);
            this.CB_M401.TabIndex = 34;
            this.CB_M401.Text = "M401";
            this.CB_M401.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "go to Line NO. (may result in Loop)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(78, 338);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(167, 13);
            this.label23.TabIndex = 33;
            this.label23.Text = "Sets minimum Extrue Temperature";
            // 
            // CB_M149
            // 
            this.CB_M149.AutoSize = true;
            this.CB_M149.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M149.Location = new System.Drawing.Point(12, 176);
            this.CB_M149.Name = "CB_M149";
            this.CB_M149.Size = new System.Drawing.Size(57, 17);
            this.CB_M149.TabIndex = 10;
            this.CB_M149.Text = "M149";
            this.CB_M149.UseVisualStyleBackColor = true;
            // 
            // CB_M302
            // 
            this.CB_M302.AutoSize = true;
            this.CB_M302.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M302.Location = new System.Drawing.Point(12, 337);
            this.CB_M302.Name = "CB_M302";
            this.CB_M302.Size = new System.Drawing.Size(57, 17);
            this.CB_M302.TabIndex = 32;
            this.CB_M302.Text = "M302";
            this.CB_M302.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(73, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "may change Temperature Units";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(78, 407);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "Change Microsteps";
            // 
            // CB_M203
            // 
            this.CB_M203.AutoSize = true;
            this.CB_M203.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M203.Location = new System.Drawing.Point(12, 222);
            this.CB_M203.Name = "CB_M203";
            this.CB_M203.Size = new System.Drawing.Size(57, 17);
            this.CB_M203.TabIndex = 12;
            this.CB_M203.Text = "M203";
            this.CB_M203.UseVisualStyleBackColor = true;
            // 
            // CB_M350
            // 
            this.CB_M350.AutoSize = true;
            this.CB_M350.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M350.Location = new System.Drawing.Point(12, 406);
            this.CB_M350.Name = "CB_M350";
            this.CB_M350.Size = new System.Drawing.Size(57, 17);
            this.CB_M350.TabIndex = 30;
            this.CB_M350.Text = "M350";
            this.CB_M350.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "change max Feedrate";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(78, 361);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 13);
            this.label21.TabIndex = 29;
            this.label21.Text = "PID Autotune";
            // 
            // CB_M303
            // 
            this.CB_M303.AutoSize = true;
            this.CB_M303.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M303.Location = new System.Drawing.Point(12, 360);
            this.CB_M303.Name = "CB_M303";
            this.CB_M303.Size = new System.Drawing.Size(57, 17);
            this.CB_M303.TabIndex = 28;
            this.CB_M303.Text = "M303";
            this.CB_M303.UseVisualStyleBackColor = true;
            // 
            // CB_M206
            // 
            this.CB_M206.AutoSize = true;
            this.CB_M206.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M206.Location = new System.Drawing.Point(12, 245);
            this.CB_M206.Name = "CB_M206";
            this.CB_M206.Size = new System.Drawing.Size(57, 17);
            this.CB_M206.TabIndex = 18;
            this.CB_M206.Text = "M206";
            this.CB_M206.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(77, 246);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "offset Home Position";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(78, 315);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(136, 13);
            this.label19.TabIndex = 25;
            this.label19.Text = "Changes Hotend PID Tune";
            // 
            // CB_M301
            // 
            this.CB_M301.AutoSize = true;
            this.CB_M301.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M301.Location = new System.Drawing.Point(12, 314);
            this.CB_M301.Name = "CB_M301";
            this.CB_M301.Size = new System.Drawing.Size(57, 17);
            this.CB_M301.TabIndex = 24;
            this.CB_M301.Text = "M301";
            this.CB_M301.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(78, 292);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(93, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "changes Feedrate";
            // 
            // CB_M211
            // 
            this.CB_M211.AutoSize = true;
            this.CB_M211.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M211.Location = new System.Drawing.Point(12, 268);
            this.CB_M211.Name = "CB_M211";
            this.CB_M211.Size = new System.Drawing.Size(57, 17);
            this.CB_M211.TabIndex = 20;
            this.CB_M211.Text = "M211";
            this.CB_M211.UseVisualStyleBackColor = true;
            // 
            // CB_M220
            // 
            this.CB_M220.AutoSize = true;
            this.CB_M220.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_M220.Location = new System.Drawing.Point(12, 291);
            this.CB_M220.Name = "CB_M220";
            this.CB_M220.Size = new System.Drawing.Size(57, 17);
            this.CB_M220.TabIndex = 22;
            this.CB_M220.Text = "M220";
            this.CB_M220.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(77, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "creates virtual Endstops";
            // 
            // CB_ALL
            // 
            this.CB_ALL.AutoCheck = false;
            this.CB_ALL.AutoSize = true;
            this.CB_ALL.BackColor = System.Drawing.SystemColors.Control;
            this.CB_ALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ALL.ForeColor = System.Drawing.Color.Goldenrod;
            this.CB_ALL.Location = new System.Drawing.Point(276, 193);
            this.CB_ALL.Name = "CB_ALL";
            this.CB_ALL.Size = new System.Drawing.Size(48, 17);
            this.CB_ALL.TabIndex = 26;
            this.CB_ALL.Text = "ALL";
            this.CB_ALL.ThreeState = true;
            this.CB_ALL.UseVisualStyleBackColor = false;
            this.CB_ALL.CheckedChanged += new System.EventHandler(this.CB_ALL_CheckedChanged);
            this.CB_ALL.Click += new System.EventHandler(this.CB_ALL_Click);
            // 
            // BT_GO
            // 
            this.BT_GO.Enabled = false;
            this.BT_GO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_GO.Location = new System.Drawing.Point(330, 408);
            this.BT_GO.Name = "BT_GO";
            this.BT_GO.Size = new System.Drawing.Size(113, 36);
            this.BT_GO.TabIndex = 27;
            this.BT_GO.Text = "Search";
            this.BT_GO.UseVisualStyleBackColor = true;
            this.BT_GO.Click += new System.EventHandler(this.BT_GO_Click);
            // 
            // BT_ABORT
            // 
            this.BT_ABORT.Enabled = false;
            this.BT_ABORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ABORT.Location = new System.Drawing.Point(675, 408);
            this.BT_ABORT.Name = "BT_ABORT";
            this.BT_ABORT.Size = new System.Drawing.Size(113, 36);
            this.BT_ABORT.TabIndex = 28;
            this.BT_ABORT.Text = "Abort";
            this.BT_ABORT.UseVisualStyleBackColor = true;
            this.BT_ABORT.Click += new System.EventHandler(this.BT_ABORT_Click);
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.LightCoral;
            this.label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(449, 408);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(70, 36);
            this.label29.TabIndex = 29;
            this.label29.Text = "Important";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(524, 408);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(70, 36);
            this.label30.TabIndex = 30;
            this.label30.Text = "Saves to EEPROM";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.White;
            this.label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(599, 408);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(70, 36);
            this.label31.TabIndex = 31;
            this.label31.Text = "Situaltional";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 454);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.BT_ABORT);
            this.Controls.Add(this.BT_GO);
            this.Controls.Add(this.CB_ALL);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PA_RESULT);
            this.Controls.Add(this.BT_OPEN);
            this.Controls.Add(this.TB_PATH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GCode Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.PA_SETTINGS.ResumeLayout(false);
            this.PA_SETTINGS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_PATH;
        private System.Windows.Forms.Button BT_OPEN;
        private System.Windows.Forms.CheckBox CB_BED;
        private System.Windows.Forms.TextBox TB_BEDX;
        private System.Windows.Forms.TextBox TB_BEDY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_HOTEND_TEMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_BED_TEMP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB_BED_BL;
        private System.Windows.Forms.RadioButton RB_BED_CENTER;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog OF_GCODE;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CB_M500;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox CB_G91;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CB_G20;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.CheckBox CB_M906;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox CB_M502;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox CB_M428;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox CB_M410;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox CB_M401;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox CB_M302;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox CB_M350;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox CB_M303;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox CB_M304;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox CB_M301;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox CB_M220;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox CB_M211;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox CB_M206;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox CB_M201;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox CB_M203;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox CB_M149;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox CB_M110;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox CB_M92;
        private System.Windows.Forms.CheckBox CB_ALL;
        private System.Windows.Forms.Panel PA_SETTINGS;
        private System.Windows.Forms.Button BT_GO;
        private System.Windows.Forms.Button BT_ABORT;
        public System.Windows.Forms.Panel PA_RESULT;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
    }
}

