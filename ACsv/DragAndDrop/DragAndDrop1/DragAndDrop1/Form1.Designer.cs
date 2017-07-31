namespace DragAndDrop1
{
    partial class AutoAnalysis
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
            this.filesBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeFiles = new System.Windows.Forms.Button();
            this.diagnosis = new System.Windows.Forms.Button();
            this.engineRpm = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.engineOilPre = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TransOilPreLL = new System.Windows.Forms.TextBox();
            this.TransOilPreHL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.highLimit = new System.Windows.Forms.Label();
            this.lowerLimit = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.transOilPreCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filesBox
            // 
            this.filesBox.AllowDrop = true;
            this.filesBox.FormattingEnabled = true;
            this.filesBox.ItemHeight = 16;
            this.filesBox.Location = new System.Drawing.Point(46, 40);
            this.filesBox.Name = "filesBox";
            this.filesBox.Size = new System.Drawing.Size(526, 500);
            this.filesBox.TabIndex = 0;
            this.filesBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.filesBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.filesBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // removeFiles
            // 
            this.removeFiles.Location = new System.Drawing.Point(33, 634);
            this.removeFiles.Name = "removeFiles";
            this.removeFiles.Size = new System.Drawing.Size(128, 42);
            this.removeFiles.TabIndex = 2;
            this.removeFiles.Text = "Remove Files";
            this.removeFiles.UseVisualStyleBackColor = true;
            this.removeFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // diagnosis
            // 
            this.diagnosis.Location = new System.Drawing.Point(185, 634);
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Size = new System.Drawing.Size(123, 42);
            this.diagnosis.TabIndex = 4;
            this.diagnosis.Text = "Diagnosis";
            this.diagnosis.UseVisualStyleBackColor = true;
            this.diagnosis.Click += new System.EventHandler(this.diagnosis_Click);
            // 
            // engineRpm
            // 
            this.engineRpm.AutoSize = true;
            this.engineRpm.Location = new System.Drawing.Point(602, 92);
            this.engineRpm.Name = "engineRpm";
            this.engineRpm.Size = new System.Drawing.Size(86, 17);
            this.engineRpm.TabIndex = 5;
            this.engineRpm.Text = "Engine RPM";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(782, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(913, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(913, 145);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(782, 145);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 9;
            // 
            // engineOilPre
            // 
            this.engineOilPre.AutoSize = true;
            this.engineOilPre.Location = new System.Drawing.Point(602, 145);
            this.engineOilPre.Name = "engineOilPre";
            this.engineOilPre.Size = new System.Drawing.Size(134, 17);
            this.engineOilPre.TabIndex = 8;
            this.engineOilPre.Text = "Engine Oil Pressure";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(913, 248);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(782, 248);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(913, 195);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(782, 195);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(602, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Engine";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(913, 451);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 28;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(782, 451);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(713, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "label6";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(913, 398);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 25;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(782, 398);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(713, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "label7";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(913, 348);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 22;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(782, 348);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(713, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "label8";
            // 
            // TransOilPreLL
            // 
            this.TransOilPreLL.Location = new System.Drawing.Point(913, 295);
            this.TransOilPreLL.Name = "TransOilPreLL";
            this.TransOilPreLL.Size = new System.Drawing.Size(100, 22);
            this.TransOilPreLL.TabIndex = 19;
            this.TransOilPreLL.Text = "100";
            // 
            // TransOilPreHL
            // 
            this.TransOilPreHL.Location = new System.Drawing.Point(782, 295);
            this.TransOilPreHL.Name = "TransOilPreHL";
            this.TransOilPreHL.Size = new System.Drawing.Size(100, 22);
            this.TransOilPreHL.TabIndex = 18;
            this.TransOilPreHL.Text = "270";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(602, 300);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Transmission Oil Pressure";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(913, 659);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 22);
            this.textBox17.TabIndex = 40;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(782, 659);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 22);
            this.textBox18.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(713, 659);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "label10";
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(913, 606);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 22);
            this.textBox19.TabIndex = 37;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(782, 606);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 22);
            this.textBox20.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(713, 606);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "label11";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(913, 556);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 22);
            this.textBox21.TabIndex = 34;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(782, 556);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 22);
            this.textBox22.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(713, 556);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "label12";
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(913, 503);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 22);
            this.textBox23.TabIndex = 31;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(782, 503);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(100, 22);
            this.textBox24.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(713, 503);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "label13";
            // 
            // highLimit
            // 
            this.highLimit.AutoSize = true;
            this.highLimit.Location = new System.Drawing.Point(779, 50);
            this.highLimit.Name = "highLimit";
            this.highLimit.Size = new System.Drawing.Size(70, 17);
            this.highLimit.TabIndex = 41;
            this.highLimit.Text = "High Limit";
            // 
            // lowerLimit
            // 
            this.lowerLimit.AutoSize = true;
            this.lowerLimit.Location = new System.Drawing.Point(910, 50);
            this.lowerLimit.Name = "lowerLimit";
            this.lowerLimit.Size = new System.Drawing.Size(79, 17);
            this.lowerLimit.TabIndex = 42;
            this.lowerLimit.Text = "Lower Limit";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(95, 556);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 17);
            this.label14.TabIndex = 43;
            this.label14.Text = "files";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1036, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 17);
            this.label15.TabIndex = 56;
            this.label15.Text = "Alarms(minutes)";
            // 
            // transOilPreCount
            // 
            this.transOilPreCount.AutoSize = true;
            this.transOilPreCount.Location = new System.Drawing.Point(1045, 295);
            this.transOilPreCount.Name = "transOilPreCount";
            this.transOilPreCount.Size = new System.Drawing.Size(16, 17);
            this.transOilPreCount.TabIndex = 57;
            this.transOilPreCount.Text = "0";
            // 
            // AutoAnalysis
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 834);
            this.Controls.Add(this.transOilPreCount);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lowerLimit);
            this.Controls.Add(this.highLimit);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TransOilPreLL);
            this.Controls.Add(this.TransOilPreHL);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.engineOilPre);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.engineRpm);
            this.Controls.Add(this.diagnosis);
            this.Controls.Add(this.removeFiles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filesBox);
            this.Name = "AutoAnalysis";
            this.Text = "Auto Analysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox filesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeFiles;
        private System.Windows.Forms.Button diagnosis;
        private System.Windows.Forms.Label engineRpm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label engineOilPre;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TransOilPreLL;
        private System.Windows.Forms.TextBox TransOilPreHL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label highLimit;
        private System.Windows.Forms.Label lowerLimit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label transOilPreCount;
    }
}

