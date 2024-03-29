﻿namespace OSSIM
{
    partial class mainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.clockLabel = new System.Windows.Forms.Label();
            this.quantumLabel = new System.Windows.Forms.Label();
            this.clockNumLabel = new System.Windows.Forms.Label();
            this.quantumNumLabel = new System.Windows.Forms.Label();
            this.boxWaiting = new System.Windows.Forms.TextBox();
            this.boxReady = new System.Windows.Forms.TextBox();
            this.boxRunning = new System.Windows.Forms.TextBox();
            this.boxFinished = new System.Windows.Forms.TextBox();
            this.labelWaiting = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxHold = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboAlgorithm = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.ioTimeBox = new System.Windows.Forms.TextBox();
            this.cpuAvgTimeBox = new System.Windows.Forms.TextBox();
            this.limitWaitingIOBox = new System.Windows.Forms.TextBox();
            this.limitReadyBox = new System.Windows.Forms.TextBox();
            this.limitNewBox = new System.Windows.Forms.TextBox();
            this.quantumBox = new System.Windows.Forms.TextBox();
            this.newProcessProbBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.speedSlow = new System.Windows.Forms.Button();
            this.speedNormal = new System.Windows.Forms.Button();
            this.speedFast = new System.Windows.Forms.Button();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.boxUsingIO = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.PCBbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.speedFlash = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clockLabel
            // 
            this.clockLabel.AutoSize = true;
            this.clockLabel.Location = new System.Drawing.Point(12, 9);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(40, 13);
            this.clockLabel.TabIndex = 0;
            this.clockLabel.Text = "Clock: ";
            // 
            // quantumLabel
            // 
            this.quantumLabel.AutoSize = true;
            this.quantumLabel.Location = new System.Drawing.Point(104, 9);
            this.quantumLabel.Name = "quantumLabel";
            this.quantumLabel.Size = new System.Drawing.Size(56, 13);
            this.quantumLabel.TabIndex = 1;
            this.quantumLabel.Text = "Quantum: ";
            // 
            // clockNumLabel
            // 
            this.clockNumLabel.AutoSize = true;
            this.clockNumLabel.Location = new System.Drawing.Point(58, 9);
            this.clockNumLabel.Name = "clockNumLabel";
            this.clockNumLabel.Size = new System.Drawing.Size(0, 13);
            this.clockNumLabel.TabIndex = 2;
            // 
            // quantumNumLabel
            // 
            this.quantumNumLabel.AutoSize = true;
            this.quantumNumLabel.Location = new System.Drawing.Point(166, 9);
            this.quantumNumLabel.Name = "quantumNumLabel";
            this.quantumNumLabel.Size = new System.Drawing.Size(13, 13);
            this.quantumNumLabel.TabIndex = 3;
            this.quantumNumLabel.Text = "0";
            // 
            // boxWaiting
            // 
            this.boxWaiting.Location = new System.Drawing.Point(104, 125);
            this.boxWaiting.Multiline = true;
            this.boxWaiting.Name = "boxWaiting";
            this.boxWaiting.ReadOnly = true;
            this.boxWaiting.Size = new System.Drawing.Size(44, 120);
            this.boxWaiting.TabIndex = 4;
            // 
            // boxReady
            // 
            this.boxReady.Location = new System.Drawing.Point(58, 47);
            this.boxReady.Multiline = true;
            this.boxReady.Name = "boxReady";
            this.boxReady.ReadOnly = true;
            this.boxReady.Size = new System.Drawing.Size(37, 198);
            this.boxReady.TabIndex = 5;
            // 
            // boxRunning
            // 
            this.boxRunning.Location = new System.Drawing.Point(101, 47);
            this.boxRunning.Multiline = true;
            this.boxRunning.Name = "boxRunning";
            this.boxRunning.ReadOnly = true;
            this.boxRunning.Size = new System.Drawing.Size(47, 19);
            this.boxRunning.TabIndex = 5;
            // 
            // boxFinished
            // 
            this.boxFinished.Location = new System.Drawing.Point(154, 47);
            this.boxFinished.Multiline = true;
            this.boxFinished.Name = "boxFinished";
            this.boxFinished.ReadOnly = true;
            this.boxFinished.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxFinished.Size = new System.Drawing.Size(52, 198);
            this.boxFinished.TabIndex = 5;
            // 
            // labelWaiting
            // 
            this.labelWaiting.AutoSize = true;
            this.labelWaiting.Location = new System.Drawing.Point(101, 109);
            this.labelWaiting.Name = "labelWaiting";
            this.labelWaiting.Size = new System.Drawing.Size(43, 13);
            this.labelWaiting.TabIndex = 6;
            this.labelWaiting.Text = "Waiting";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ready";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Running";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Finished";
            // 
            // boxHold
            // 
            this.boxHold.Location = new System.Drawing.Point(15, 47);
            this.boxHold.Multiline = true;
            this.boxHold.Name = "boxHold";
            this.boxHold.ReadOnly = true;
            this.boxHold.Size = new System.Drawing.Size(37, 198);
            this.boxHold.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hold";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboAlgorithm);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.ioTimeBox);
            this.groupBox1.Controls.Add(this.cpuAvgTimeBox);
            this.groupBox1.Controls.Add(this.limitWaitingIOBox);
            this.groupBox1.Controls.Add(this.limitReadyBox);
            this.groupBox1.Controls.Add(this.limitNewBox);
            this.groupBox1.Controls.Add(this.quantumBox);
            this.groupBox1.Controls.Add(this.newProcessProbBox);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(15, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 346);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // comboAlgorithm
            // 
            this.comboAlgorithm.FormattingEnabled = true;
            this.comboAlgorithm.Items.AddRange(new object[] {
            "FIFO",
            "RR"});
            this.comboAlgorithm.Location = new System.Drawing.Point(86, 69);
            this.comboAlgorithm.Name = "comboAlgorithm";
            this.comboAlgorithm.Size = new System.Drawing.Size(91, 21);
            this.comboAlgorithm.TabIndex = 3;
            this.comboAlgorithm.Text = "RR";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(129, 35);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(15, 13);
            this.label25.TabIndex = 2;
            this.label25.Text = "%";
            // 
            // ioTimeBox
            // 
            this.ioTimeBox.Location = new System.Drawing.Point(89, 292);
            this.ioTimeBox.Name = "ioTimeBox";
            this.ioTimeBox.Size = new System.Drawing.Size(31, 20);
            this.ioTimeBox.TabIndex = 1;
            this.ioTimeBox.Text = "2";
            // 
            // cpuAvgTimeBox
            // 
            this.cpuAvgTimeBox.Location = new System.Drawing.Point(89, 252);
            this.cpuAvgTimeBox.Name = "cpuAvgTimeBox";
            this.cpuAvgTimeBox.Size = new System.Drawing.Size(31, 20);
            this.cpuAvgTimeBox.TabIndex = 1;
            this.cpuAvgTimeBox.Text = "5";
            // 
            // limitWaitingIOBox
            // 
            this.limitWaitingIOBox.Location = new System.Drawing.Point(89, 218);
            this.limitWaitingIOBox.Name = "limitWaitingIOBox";
            this.limitWaitingIOBox.Size = new System.Drawing.Size(31, 20);
            this.limitWaitingIOBox.TabIndex = 1;
            this.limitWaitingIOBox.Text = "5";
            // 
            // limitReadyBox
            // 
            this.limitReadyBox.Location = new System.Drawing.Point(89, 188);
            this.limitReadyBox.Name = "limitReadyBox";
            this.limitReadyBox.Size = new System.Drawing.Size(31, 20);
            this.limitReadyBox.TabIndex = 1;
            this.limitReadyBox.Text = "5";
            // 
            // limitNewBox
            // 
            this.limitNewBox.Location = new System.Drawing.Point(89, 158);
            this.limitNewBox.Name = "limitNewBox";
            this.limitNewBox.Size = new System.Drawing.Size(31, 20);
            this.limitNewBox.TabIndex = 1;
            this.limitNewBox.Text = "5";
            // 
            // quantumBox
            // 
            this.quantumBox.Location = new System.Drawing.Point(89, 98);
            this.quantumBox.Name = "quantumBox";
            this.quantumBox.Size = new System.Drawing.Size(31, 20);
            this.quantumBox.TabIndex = 1;
            this.quantumBox.Text = "2";
            // 
            // newProcessProbBox
            // 
            this.newProcessProbBox.Location = new System.Drawing.Point(89, 32);
            this.newProcessProbBox.Name = "newProcessProbBox";
            this.newProcessProbBox.Size = new System.Drawing.Size(31, 20);
            this.newProcessProbBox.TabIndex = 1;
            this.newProcessProbBox.Text = "100";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 295);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 26);
            this.label19.TabIndex = 0;
            this.label19.Text = "I/O usage\r\ntime";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 252);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 26);
            this.label18.TabIndex = 0;
            this.label18.Text = "CPU average\r\nusage time";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 222);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Waiting I/O";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 192);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Ready";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 162);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "New";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 236);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(184, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "-----------------------------------------------------------";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(3, 120);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(184, 13);
            this.label23.TabIndex = 0;
            this.label23.Text = "-----------------------------------------------------------";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(36, 133);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "List limits";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 102);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Quantum";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Algorithm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 26);
            this.label14.TabIndex = 0;
            this.label14.Text = "Probability of\r\nnew process";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 26);
            this.label7.TabIndex = 13;
            this.label7.Text = "Arrival \r\ntime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "CPU \r\nusage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(357, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Accum. \r\n usage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(462, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 26);
            this.label10.TabIndex = 16;
            this.label10.Text = "I/O \r\nusage";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 26);
            this.label11.TabIndex = 17;
            this.label11.Text = "I/O \r\narrival";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(510, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 26);
            this.label12.TabIndex = 18;
            this.label12.Text = "End\r\ntime";
            // 
            // speedSlow
            // 
            this.speedSlow.Location = new System.Drawing.Point(216, 4);
            this.speedSlow.Name = "speedSlow";
            this.speedSlow.Size = new System.Drawing.Size(61, 23);
            this.speedSlow.TabIndex = 20;
            this.speedSlow.Text = "SLOW";
            this.speedSlow.UseVisualStyleBackColor = true;
            this.speedSlow.Click += new System.EventHandler(this.speedSlow_Click);
            // 
            // speedNormal
            // 
            this.speedNormal.Location = new System.Drawing.Point(283, 4);
            this.speedNormal.Name = "speedNormal";
            this.speedNormal.Size = new System.Drawing.Size(61, 23);
            this.speedNormal.TabIndex = 20;
            this.speedNormal.Text = "NORMAL";
            this.speedNormal.UseVisualStyleBackColor = true;
            this.speedNormal.Click += new System.EventHandler(this.speedMedium_Click);
            // 
            // speedFast
            // 
            this.speedFast.Location = new System.Drawing.Point(350, 4);
            this.speedFast.Name = "speedFast";
            this.speedFast.Size = new System.Drawing.Size(61, 23);
            this.speedFast.TabIndex = 20;
            this.speedFast.Text = "FAST";
            this.speedFast.UseVisualStyleBackColor = true;
            this.speedFast.Click += new System.EventHandler(this.speedFast_Click);
            // 
            // aTimer
            // 
            this.aTimer.Interval = 1000;
            this.aTimer.Tick += new System.EventHandler(this.aTimer_Tick);
            // 
            // boxUsingIO
            // 
            this.boxUsingIO.Location = new System.Drawing.Point(101, 87);
            this.boxUsingIO.Multiline = true;
            this.boxUsingIO.Name = "boxUsingIO";
            this.boxUsingIO.ReadOnly = true;
            this.boxUsingIO.Size = new System.Drawing.Size(47, 19);
            this.boxUsingIO.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(99, 70);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "Using I/O";
            // 
            // PCBbox
            // 
            this.PCBbox.Location = new System.Drawing.Point(228, 70);
            this.PCBbox.Multiline = true;
            this.PCBbox.Name = "PCBbox";
            this.PCBbox.ReadOnly = true;
            this.PCBbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PCBbox.Size = new System.Drawing.Size(508, 567);
            this.PCBbox.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(548, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 26);
            this.label13.TabIndex = 18;
            this.label13.Text = "Time in\r\nSystem";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(601, 43);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(38, 26);
            this.label27.TabIndex = 18;
            this.label27.Text = "Time \r\nwaited";
            // 
            // speedFlash
            // 
            this.speedFlash.Location = new System.Drawing.Point(417, 4);
            this.speedFlash.Name = "speedFlash";
            this.speedFlash.Size = new System.Drawing.Size(60, 23);
            this.speedFlash.TabIndex = 22;
            this.speedFlash.Text = "FLASH";
            this.speedFlash.UseVisualStyleBackColor = true;
            this.speedFlash.Click += new System.EventHandler(this.speedFlash_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(695, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Image = ((System.Drawing.Image)(resources.GetObject("pauseButton.Image")));
            this.pauseButton.Location = new System.Drawing.Point(122, 251);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(37, 34);
            this.pauseButton.TabIndex = 11;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // playButton
            // 
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.Location = new System.Drawing.Point(79, 251);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(37, 34);
            this.playButton.TabIndex = 11;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.Location = new System.Drawing.Point(36, 251);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(37, 34);
            this.stopButton.TabIndex = 11;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(632, 12);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(57, 23);
            this.helpButton.TabIndex = 24;
            this.helpButton.Text = "HELP";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(662, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Status";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 649);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.speedFlash);
            this.Controls.Add(this.PCBbox);
            this.Controls.Add(this.speedFast);
            this.Controls.Add(this.speedNormal);
            this.Controls.Add(this.speedSlow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWaiting);
            this.Controls.Add(this.boxUsingIO);
            this.Controls.Add(this.boxRunning);
            this.Controls.Add(this.boxFinished);
            this.Controls.Add(this.boxHold);
            this.Controls.Add(this.boxReady);
            this.Controls.Add(this.boxWaiting);
            this.Controls.Add(this.quantumNumLabel);
            this.Controls.Add(this.clockNumLabel);
            this.Controls.Add(this.quantumLabel);
            this.Controls.Add(this.clockLabel);
            this.Name = "mainMenu";
            this.Text = " Dog-OS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Label quantumLabel;
        private System.Windows.Forms.Label clockNumLabel;
        private System.Windows.Forms.Label quantumNumLabel;
        private System.Windows.Forms.TextBox boxWaiting;
        private System.Windows.Forms.TextBox boxReady;
        private System.Windows.Forms.TextBox boxRunning;
        private System.Windows.Forms.TextBox boxFinished;
        private System.Windows.Forms.Label labelWaiting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxHold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ioTimeBox;
        private System.Windows.Forms.TextBox cpuAvgTimeBox;
        private System.Windows.Forms.TextBox limitWaitingIOBox;
        private System.Windows.Forms.TextBox limitReadyBox;
        private System.Windows.Forms.TextBox limitNewBox;
        private System.Windows.Forms.TextBox quantumBox;
        private System.Windows.Forms.TextBox newProcessProbBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button speedSlow;
        private System.Windows.Forms.Button speedNormal;
        private System.Windows.Forms.Button speedFast;
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.TextBox boxUsingIO;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboAlgorithm;
        private System.Windows.Forms.TextBox PCBbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button speedFlash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label label5;
    }
}

