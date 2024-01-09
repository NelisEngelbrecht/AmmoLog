namespace AmmoLog
{
    partial class ALMain
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
            this.dgvFA = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmbFACaliber = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFA = new System.Windows.Forms.Button();
            this.tbFASerial = new System.Windows.Forms.TextBox();
            this.tbFAModel = new System.Windows.Forms.TextBox();
            this.tbFABrand = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.numAmmoWeight = new System.Windows.Forms.NumericUpDown();
            this.cmbAmmoStyle = new System.Windows.Forms.ComboBox();
            this.cmbAmmoCaliber = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddAmmo = new System.Windows.Forms.Button();
            this.tbAmmoBrand = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddCaliber = new System.Windows.Forms.Button();
            this.tbCal = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvSession = new System.Windows.Forms.DataGridView();
            this.numFailures = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbSessionAmmo = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.numGroupSize = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.NumRoundCount = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.numDistance = new System.Windows.Forms.NumericUpDown();
            this.cmbSessionFA = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelRange = new System.Windows.Forms.Label();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.tbRange = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvAccuracy = new System.Windows.Forms.DataGridView();
            this.dgvReliablility = new System.Windows.Forms.DataGridView();
            this.cmbResultsFA = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFA)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmoWeight)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFailures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGroupSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRoundCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReliablility)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFA
            // 
            this.dgvFA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFA.Location = new System.Drawing.Point(6, 140);
            this.dgvFA.Name = "dgvFA";
            this.dgvFA.Size = new System.Drawing.Size(756, 254);
            this.dgvFA.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(778, 617);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbFACaliber);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnAddFA);
            this.tabPage1.Controls.Add(this.tbFASerial);
            this.tabPage1.Controls.Add(this.tbFAModel);
            this.tabPage1.Controls.Add(this.tbFABrand);
            this.tabPage1.Controls.Add(this.dgvFA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(770, 591);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Firearms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmbFACaliber
            // 
            this.cmbFACaliber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFACaliber.FormattingEnabled = true;
            this.cmbFACaliber.Location = new System.Drawing.Point(46, 84);
            this.cmbFACaliber.Name = "cmbFACaliber";
            this.cmbFACaliber.Size = new System.Drawing.Size(121, 21);
            this.cmbFACaliber.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Caliber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Serial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Brand";
            // 
            // btnAddFA
            // 
            this.btnAddFA.Location = new System.Drawing.Point(46, 111);
            this.btnAddFA.Name = "btnAddFA";
            this.btnAddFA.Size = new System.Drawing.Size(75, 23);
            this.btnAddFA.TabIndex = 5;
            this.btnAddFA.Text = "Add Firearm";
            this.btnAddFA.UseVisualStyleBackColor = true;
            this.btnAddFA.Click += new System.EventHandler(this.btnAddFA_Click);
            // 
            // tbFASerial
            // 
            this.tbFASerial.Location = new System.Drawing.Point(46, 58);
            this.tbFASerial.Name = "tbFASerial";
            this.tbFASerial.Size = new System.Drawing.Size(100, 20);
            this.tbFASerial.TabIndex = 3;
            // 
            // tbFAModel
            // 
            this.tbFAModel.Location = new System.Drawing.Point(46, 32);
            this.tbFAModel.Name = "tbFAModel";
            this.tbFAModel.Size = new System.Drawing.Size(100, 20);
            this.tbFAModel.TabIndex = 2;
            // 
            // tbFABrand
            // 
            this.tbFABrand.Location = new System.Drawing.Point(46, 6);
            this.tbFABrand.Name = "tbFABrand";
            this.tbFABrand.Size = new System.Drawing.Size(100, 20);
            this.tbFABrand.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.numAmmoWeight);
            this.tabPage2.Controls.Add(this.cmbAmmoStyle);
            this.tabPage2.Controls.Add(this.cmbAmmoCaliber);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnAddAmmo);
            this.tabPage2.Controls.Add(this.tbAmmoBrand);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(770, 591);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ammo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "grain";
            // 
            // numAmmoWeight
            // 
            this.numAmmoWeight.Location = new System.Drawing.Point(46, 58);
            this.numAmmoWeight.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numAmmoWeight.Name = "numAmmoWeight";
            this.numAmmoWeight.Size = new System.Drawing.Size(120, 20);
            this.numAmmoWeight.TabIndex = 21;
            // 
            // cmbAmmoStyle
            // 
            this.cmbAmmoStyle.FormattingEnabled = true;
            this.cmbAmmoStyle.Items.AddRange(new object[] {
            "FMJ - Round",
            "FMJ - Flat",
            "BPJ - Round",
            "BPJ - Flat",
            "Cast - Round",
            "Cast - Flat",
            "Hollow"});
            this.cmbAmmoStyle.Location = new System.Drawing.Point(46, 84);
            this.cmbAmmoStyle.Name = "cmbAmmoStyle";
            this.cmbAmmoStyle.Size = new System.Drawing.Size(121, 21);
            this.cmbAmmoStyle.TabIndex = 20;
            // 
            // cmbAmmoCaliber
            // 
            this.cmbAmmoCaliber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAmmoCaliber.FormattingEnabled = true;
            this.cmbAmmoCaliber.Location = new System.Drawing.Point(46, 31);
            this.cmbAmmoCaliber.Name = "cmbAmmoCaliber";
            this.cmbAmmoCaliber.Size = new System.Drawing.Size(121, 21);
            this.cmbAmmoCaliber.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Caliber";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Style";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Brand";
            // 
            // btnAddAmmo
            // 
            this.btnAddAmmo.Location = new System.Drawing.Point(46, 111);
            this.btnAddAmmo.Name = "btnAddAmmo";
            this.btnAddAmmo.Size = new System.Drawing.Size(75, 23);
            this.btnAddAmmo.TabIndex = 14;
            this.btnAddAmmo.Text = "Add Ammo";
            this.btnAddAmmo.UseVisualStyleBackColor = true;
            this.btnAddAmmo.Click += new System.EventHandler(this.btnAddAmmo_Click);
            // 
            // tbAmmoBrand
            // 
            this.tbAmmoBrand.Location = new System.Drawing.Point(46, 6);
            this.tbAmmoBrand.Name = "tbAmmoBrand";
            this.tbAmmoBrand.Size = new System.Drawing.Size(100, 20);
            this.tbAmmoBrand.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnAddCaliber);
            this.tabPage3.Controls.Add(this.tbCal);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(770, 591);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Calibers";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Caliber";
            // 
            // btnAddCaliber
            // 
            this.btnAddCaliber.Location = new System.Drawing.Point(7, 29);
            this.btnAddCaliber.Name = "btnAddCaliber";
            this.btnAddCaliber.Size = new System.Drawing.Size(75, 23);
            this.btnAddCaliber.TabIndex = 14;
            this.btnAddCaliber.Text = "Add Caliber";
            this.btnAddCaliber.UseVisualStyleBackColor = true;
            this.btnAddCaliber.Click += new System.EventHandler(this.btnAddCaliber_Click);
            // 
            // tbCal
            // 
            this.tbCal.Location = new System.Drawing.Point(45, 3);
            this.tbCal.Name = "tbCal";
            this.tbCal.Size = new System.Drawing.Size(100, 20);
            this.tbCal.TabIndex = 11;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvSession);
            this.tabPage4.Controls.Add(this.numFailures);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.cmbSessionAmmo);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.numGroupSize);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.NumRoundCount);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.dtDate);
            this.tabPage4.Controls.Add(this.numDistance);
            this.tabPage4.Controls.Add(this.cmbSessionFA);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.labelRange);
            this.tabPage4.Controls.Add(this.btnAddSession);
            this.tabPage4.Controls.Add(this.tbRange);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(770, 591);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Sessions";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvSession
            // 
            this.dgvSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSession.Location = new System.Drawing.Point(6, 252);
            this.dgvSession.Name = "dgvSession";
            this.dgvSession.Size = new System.Drawing.Size(761, 336);
            this.dgvSession.TabIndex = 42;
            // 
            // numFailures
            // 
            this.numFailures.Location = new System.Drawing.Point(79, 137);
            this.numFailures.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numFailures.Name = "numFailures";
            this.numFailures.Size = new System.Drawing.Size(120, 20);
            this.numFailures.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 140);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Failures";
            // 
            // cmbSessionAmmo
            // 
            this.cmbSessionAmmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSessionAmmo.FormattingEnabled = true;
            this.cmbSessionAmmo.Location = new System.Drawing.Point(78, 110);
            this.cmbSessionAmmo.Name = "cmbSessionAmmo";
            this.cmbSessionAmmo.Size = new System.Drawing.Size(282, 21);
            this.cmbSessionAmmo.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(205, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "millimeters";
            // 
            // numGroupSize
            // 
            this.numGroupSize.Location = new System.Drawing.Point(79, 189);
            this.numGroupSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numGroupSize.Name = "numGroupSize";
            this.numGroupSize.Size = new System.Drawing.Size(120, 20);
            this.numGroupSize.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Group Size";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(205, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "meters";
            // 
            // NumRoundCount
            // 
            this.NumRoundCount.Location = new System.Drawing.Point(79, 163);
            this.NumRoundCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumRoundCount.Name = "NumRoundCount";
            this.NumRoundCount.Size = new System.Drawing.Size(120, 20);
            this.NumRoundCount.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Rounds Fired";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Date";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(78, 6);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 20);
            this.dtDate.TabIndex = 31;
            // 
            // numDistance
            // 
            this.numDistance.Location = new System.Drawing.Point(79, 84);
            this.numDistance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDistance.Name = "numDistance";
            this.numDistance.Size = new System.Drawing.Size(120, 20);
            this.numDistance.TabIndex = 30;
            // 
            // cmbSessionFA
            // 
            this.cmbSessionFA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSessionFA.FormattingEnabled = true;
            this.cmbSessionFA.Location = new System.Drawing.Point(78, 32);
            this.cmbSessionFA.Name = "cmbSessionFA";
            this.cmbSessionFA.Size = new System.Drawing.Size(121, 21);
            this.cmbSessionFA.TabIndex = 28;
            this.cmbSessionFA.SelectedIndexChanged += new System.EventHandler(this.cmbSessionFA_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Firearm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Distance";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Ammo";
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(3, 61);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(70, 13);
            this.labelRange.TabIndex = 24;
            this.labelRange.Text = "Range Name";
            // 
            // btnAddSession
            // 
            this.btnAddSession.Location = new System.Drawing.Point(6, 223);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(75, 23);
            this.btnAddSession.TabIndex = 23;
            this.btnAddSession.Text = "Add Session";
            this.btnAddSession.UseVisualStyleBackColor = true;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // tbRange
            // 
            this.tbRange.Location = new System.Drawing.Point(79, 58);
            this.tbRange.Name = "tbRange";
            this.tbRange.Size = new System.Drawing.Size(100, 20);
            this.tbRange.TabIndex = 22;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Controls.Add(this.dgvAccuracy);
            this.tabPage5.Controls.Add(this.dgvReliablility);
            this.tabPage5.Controls.Add(this.cmbResultsFA);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(770, 591);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Results";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(3, 281);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 13);
            this.label22.TabIndex = 34;
            this.label22.Text = "Accuracy";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Reliability";
            // 
            // dgvAccuracy
            // 
            this.dgvAccuracy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccuracy.Location = new System.Drawing.Point(6, 297);
            this.dgvAccuracy.Name = "dgvAccuracy";
            this.dgvAccuracy.Size = new System.Drawing.Size(761, 216);
            this.dgvAccuracy.TabIndex = 32;
            // 
            // dgvReliablility
            // 
            this.dgvReliablility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReliablility.Location = new System.Drawing.Point(6, 62);
            this.dgvReliablility.Name = "dgvReliablility";
            this.dgvReliablility.Size = new System.Drawing.Size(761, 216);
            this.dgvReliablility.TabIndex = 31;
            // 
            // cmbResultsFA
            // 
            this.cmbResultsFA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResultsFA.FormattingEnabled = true;
            this.cmbResultsFA.Location = new System.Drawing.Point(78, 7);
            this.cmbResultsFA.Name = "cmbResultsFA";
            this.cmbResultsFA.Size = new System.Drawing.Size(121, 21);
            this.cmbResultsFA.TabIndex = 30;
            this.cmbResultsFA.SelectedIndexChanged += new System.EventHandler(this.cmbResultsFA_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Firearm";
            // 
            // ALMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 641);
            this.Controls.Add(this.tabControl1);
            this.Name = "ALMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFA)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmmoWeight)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFailures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGroupSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRoundCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReliablility)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFA;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAddFA;
        private System.Windows.Forms.TextBox tbFASerial;
        private System.Windows.Forms.TextBox tbFAModel;
        private System.Windows.Forms.TextBox tbFABrand;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFACaliber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddCaliber;
        private System.Windows.Forms.TextBox tbCal;
        private System.Windows.Forms.ComboBox cmbAmmoCaliber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddAmmo;
        private System.Windows.Forms.TextBox tbAmmoBrand;
        private System.Windows.Forms.ComboBox cmbAmmoStyle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numAmmoWeight;
        private System.Windows.Forms.NumericUpDown numDistance;
        private System.Windows.Forms.ComboBox cmbSessionFA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.TextBox tbRange;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numGroupSize;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown NumRoundCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbSessionAmmo;
        private System.Windows.Forms.NumericUpDown numFailures;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbResultsFA;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvAccuracy;
        private System.Windows.Forms.DataGridView dgvReliablility;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView dgvSession;
    }
}

