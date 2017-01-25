namespace PractiseDue0125_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.playerState = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.computerState = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resultState = new System.Windows.Forms.Label();
            this.scissors = new System.Windows.Forms.Button();
            this.stone = new System.Windows.Forms.Button();
            this.cloth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "玩家出";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // playerState
            // 
            this.playerState.BackColor = System.Drawing.SystemColors.Control;
            this.playerState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.playerState.Location = new System.Drawing.Point(188, 80);
            this.playerState.Name = "playerState";
            this.playerState.Size = new System.Drawing.Size(46, 17);
            this.playerState.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "电脑出";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // computerState
            // 
            this.computerState.AutoSize = true;
            this.computerState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.computerState.Location = new System.Drawing.Point(684, 80);
            this.computerState.Name = "computerState";
            this.computerState.Size = new System.Drawing.Size(2, 19);
            this.computerState.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "结果";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // resultState
            // 
            this.resultState.AutoSize = true;
            this.resultState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultState.Location = new System.Drawing.Point(447, 321);
            this.resultState.Name = "resultState";
            this.resultState.Size = new System.Drawing.Size(2, 19);
            this.resultState.TabIndex = 4;
            // 
            // scissors
            // 
            this.scissors.Location = new System.Drawing.Point(65, 463);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(75, 23);
            this.scissors.TabIndex = 6;
            this.scissors.Text = "剪刀";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.button1_Click);
            // 
            // stone
            // 
            this.stone.Location = new System.Drawing.Point(373, 463);
            this.stone.Name = "stone";
            this.stone.Size = new System.Drawing.Size(75, 23);
            this.stone.TabIndex = 7;
            this.stone.Text = "石头";
            this.stone.UseVisualStyleBackColor = true;
            this.stone.Click += new System.EventHandler(this.button2_Click);
            // 
            // cloth
            // 
            this.cloth.Location = new System.Drawing.Point(673, 463);
            this.cloth.Name = "cloth";
            this.cloth.Size = new System.Drawing.Size(75, 23);
            this.cloth.TabIndex = 8;
            this.cloth.Text = "布";
            this.cloth.UseVisualStyleBackColor = true;
            this.cloth.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 600);
            this.Controls.Add(this.cloth);
            this.Controls.Add(this.stone);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultState);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.computerState);
            this.Controls.Add(this.playerState);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label computerState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label resultState;
        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Button stone;
        private System.Windows.Forms.Button cloth;
    }
}

