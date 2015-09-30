namespace OSSIM
{
    partial class Form1
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
            this.boxNew = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.pcbBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.clockNumLabel.Size = new System.Drawing.Size(13, 13);
            this.clockNumLabel.TabIndex = 2;
            this.clockNumLabel.Text = "0";
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
            this.boxWaiting.Location = new System.Drawing.Point(104, 86);
            this.boxWaiting.Multiline = true;
            this.boxWaiting.Name = "boxWaiting";
            this.boxWaiting.ReadOnly = true;
            this.boxWaiting.Size = new System.Drawing.Size(44, 159);
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
            this.boxFinished.Size = new System.Drawing.Size(46, 198);
            this.boxFinished.TabIndex = 5;
            // 
            // labelWaiting
            // 
            this.labelWaiting.AutoSize = true;
            this.labelWaiting.Location = new System.Drawing.Point(101, 70);
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
            // boxNew
            // 
            this.boxNew.Location = new System.Drawing.Point(15, 47);
            this.boxNew.Multiline = true;
            this.boxNew.Name = "boxNew";
            this.boxNew.ReadOnly = true;
            this.boxNew.Size = new System.Drawing.Size(37, 198);
            this.boxNew.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "New";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(15, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 204);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(36, 251);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(37, 34);
            this.stopButton.TabIndex = 11;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(79, 251);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(37, 34);
            this.playButton.TabIndex = 11;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(122, 251);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(37, 34);
            this.pauseButton.TabIndex = 11;
            this.pauseButton.Text = "PAUSE";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // pcbBox
            // 
            this.pcbBox.Location = new System.Drawing.Point(225, 70);
            this.pcbBox.Multiline = true;
            this.pcbBox.Name = "pcbBox";
            this.pcbBox.ReadOnly = true;
            this.pcbBox.Size = new System.Drawing.Size(705, 425);
            this.pcbBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PCB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Arrival time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "CPU usage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(482, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Accum. CPU usage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(622, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "I/O usage";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(717, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "I/O arrival";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(811, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "End time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(899, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 506);
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
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWaiting);
            this.Controls.Add(this.boxRunning);
            this.Controls.Add(this.pcbBox);
            this.Controls.Add(this.boxFinished);
            this.Controls.Add(this.boxNew);
            this.Controls.Add(this.boxReady);
            this.Controls.Add(this.boxWaiting);
            this.Controls.Add(this.quantumNumLabel);
            this.Controls.Add(this.clockNumLabel);
            this.Controls.Add(this.quantumLabel);
            this.Controls.Add(this.clockLabel);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox boxNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.TextBox pcbBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

