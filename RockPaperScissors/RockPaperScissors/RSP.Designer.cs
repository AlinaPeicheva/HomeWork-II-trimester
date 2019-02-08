namespace RockPaperScissors
{
    partial class RSP
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
            System.Windows.Forms.PictureBox PaperChoise;
            this.label1 = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbUserWinss = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pbCompChoise = new System.Windows.Forms.PictureBox();
            this.pbUserChoise = new System.Windows.Forms.PictureBox();
            this.RockChoise = new System.Windows.Forms.PictureBox();
            this.ScissorsChoise = new System.Windows.Forms.PictureBox();
            this.lbCompWinss = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            PaperChoise = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(PaperChoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompChoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserChoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockChoise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsChoise)).BeginInit();
            this.SuspendLayout();
            // 
            // PaperChoise
            // 
            PaperChoise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            PaperChoise.Image = global::RockPaperScissors.Properties.Resources.paper;
            PaperChoise.Location = new System.Drawing.Point(273, 337);
            PaperChoise.Name = "PaperChoise";
            PaperChoise.Size = new System.Drawing.Size(131, 101);
            PaperChoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            PaperChoise.TabIndex = 13;
            PaperChoise.TabStop = false;
            PaperChoise.Click += new System.EventHandler(this.PaperChoise_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your username:";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserName.Location = new System.Drawing.Point(93, 133);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(0, 20);
            this.lbUserName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(650, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Computer";
            // 
            // lbUserWinss
            // 
            this.lbUserWinss.AutoSize = true;
            this.lbUserWinss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbUserWinss.Location = new System.Drawing.Point(288, 190);
            this.lbUserWinss.Name = "lbUserWinss";
            this.lbUserWinss.Size = new System.Drawing.Size(27, 29);
            this.lbUserWinss.TabIndex = 3;
            this.lbUserWinss.Text = "0";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(384, 29);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(380, 22);
            this.tbUserName.TabIndex = 4;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Maroon;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(348, 89);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(123, 42);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(641, 319);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 42);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(641, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 42);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(231, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Choose your picture:";
            // 
            // pbCompChoise
            // 
            this.pbCompChoise.Location = new System.Drawing.Point(617, 156);
            this.pbCompChoise.Name = "pbCompChoise";
            this.pbCompChoise.Size = new System.Drawing.Size(147, 101);
            this.pbCompChoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCompChoise.TabIndex = 9;
            this.pbCompChoise.TabStop = false;
            // 
            // pbUserChoise
            // 
            this.pbUserChoise.Location = new System.Drawing.Point(54, 156);
            this.pbUserChoise.Name = "pbUserChoise";
            this.pbUserChoise.Size = new System.Drawing.Size(140, 116);
            this.pbUserChoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserChoise.TabIndex = 10;
            this.pbUserChoise.TabStop = false;
            // 
            // RockChoise
            // 
            this.RockChoise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RockChoise.Image = global::RockPaperScissors.Properties.Resources.rock;
            this.RockChoise.Location = new System.Drawing.Point(54, 337);
            this.RockChoise.Name = "RockChoise";
            this.RockChoise.Size = new System.Drawing.Size(140, 101);
            this.RockChoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RockChoise.TabIndex = 11;
            this.RockChoise.TabStop = false;
            this.RockChoise.Click += new System.EventHandler(this.RockChoise_Click);
            // 
            // ScissorsChoise
            // 
            this.ScissorsChoise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ScissorsChoise.Image = global::RockPaperScissors.Properties.Resources.scissors;
            this.ScissorsChoise.Location = new System.Drawing.Point(461, 332);
            this.ScissorsChoise.Name = "ScissorsChoise";
            this.ScissorsChoise.Size = new System.Drawing.Size(150, 106);
            this.ScissorsChoise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ScissorsChoise.TabIndex = 12;
            this.ScissorsChoise.TabStop = false;
            this.ScissorsChoise.Click += new System.EventHandler(this.ScissorsChoise_Click);
            // 
            // lbCompWinss
            // 
            this.lbCompWinss.AutoSize = true;
            this.lbCompWinss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCompWinss.Location = new System.Drawing.Point(509, 190);
            this.lbCompWinss.Name = "lbCompWinss";
            this.lbCompWinss.Size = new System.Drawing.Size(27, 29);
            this.lbCompWinss.TabIndex = 14;
            this.lbCompWinss.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.CausesValidation = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(400, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 36);
            this.label6.TabIndex = 15;
            this.label6.Text = ":";
            // 
            // RSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCompWinss);
            this.Controls.Add(PaperChoise);
            this.Controls.Add(this.ScissorsChoise);
            this.Controls.Add(this.RockChoise);
            this.Controls.Add(this.pbUserChoise);
            this.Controls.Add(this.pbCompChoise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.lbUserWinss);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "RSP";
            this.Text = "Rock-Scissors-Paper";
            ((System.ComponentModel.ISupportInitialize)(PaperChoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompChoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserChoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RockChoise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScissorsChoise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUserWinss;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbCompChoise;
        private System.Windows.Forms.PictureBox pbUserChoise;
        private System.Windows.Forms.PictureBox ScissorsChoise;
        private System.Windows.Forms.PictureBox RockChoise;
        private System.Windows.Forms.Label lbCompWinss;
        private System.Windows.Forms.Label label6;
    }
}

