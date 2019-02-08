namespace GameRandomNumber
{
    partial class RandomNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomNumbers));
            this.cbLevels = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tbInputByUser = new System.Windows.Forms.TextBox();
            this.lbtext = new System.Windows.Forms.Label();
            this.pbresalt = new System.Windows.Forms.PictureBox();
            this.pbUporDown = new System.Windows.Forms.PictureBox();
            this.lbtext2 = new System.Windows.Forms.Label();
            this.lblText3 = new System.Windows.Forms.Label();
            this.lbtry = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbresalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUporDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cbLevels
            // 
            this.cbLevels.FormattingEnabled = true;
            this.cbLevels.Items.AddRange(new object[] {
            "1-10",
            "1-30",
            "1-50",
            "1-100"});
            this.cbLevels.Location = new System.Drawing.Point(59, 98);
            this.cbLevels.Name = "cbLevels";
            this.cbLevels.Size = new System.Drawing.Size(308, 24);
            this.cbLevels.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Bradobrei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlay.Location = new System.Drawing.Point(402, 38);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(192, 84);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tbInputByUser
            // 
            this.tbInputByUser.Font = new System.Drawing.Font("Bradobrei", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInputByUser.Location = new System.Drawing.Point(59, 216);
            this.tbInputByUser.Multiline = true;
            this.tbInputByUser.Name = "tbInputByUser";
            this.tbInputByUser.Size = new System.Drawing.Size(122, 118);
            this.tbInputByUser.TabIndex = 2;
            // 
            // lbtext
            // 
            this.lbtext.AutoSize = true;
            this.lbtext.Font = new System.Drawing.Font("Bradobrei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtext.Location = new System.Drawing.Point(52, 38);
            this.lbtext.Name = "lbtext";
            this.lbtext.Size = new System.Drawing.Size(262, 42);
            this.lbtext.TabIndex = 5;
            this.lbtext.Text = "Choose level";
            // 
            // pbresalt
            // 
            this.pbresalt.Image = ((System.Drawing.Image)(resources.GetObject("pbresalt.Image")));
            this.pbresalt.Location = new System.Drawing.Point(402, 195);
            this.pbresalt.Name = "pbresalt";
            this.pbresalt.Size = new System.Drawing.Size(192, 139);
            this.pbresalt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbresalt.TabIndex = 4;
            this.pbresalt.TabStop = false;
            // 
            // pbUporDown
            // 
            this.pbUporDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbUporDown.Image = ((System.Drawing.Image)(resources.GetObject("pbUporDown.Image")));
            this.pbUporDown.Location = new System.Drawing.Point(220, 216);
            this.pbUporDown.Name = "pbUporDown";
            this.pbUporDown.Size = new System.Drawing.Size(147, 118);
            this.pbUporDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUporDown.TabIndex = 3;
            this.pbUporDown.TabStop = false;
            // 
            // lbtext2
            // 
            this.lbtext2.AutoSize = true;
            this.lbtext2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtext2.Location = new System.Drawing.Point(54, 155);
            this.lbtext2.Name = "lbtext2";
            this.lbtext2.Size = new System.Drawing.Size(197, 58);
            this.lbtext2.TabIndex = 6;
            this.lbtext2.Text = "Guess the Random \r\nNumber";
            // 
            // lblText3
            // 
            this.lblText3.AutoSize = true;
            this.lblText3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText3.Location = new System.Drawing.Point(54, 356);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(44, 29);
            this.lblText3.TabIndex = 7;
            this.lblText3.Text = "Try";
            // 
            // lbtry
            // 
            this.lbtry.AutoSize = true;
            this.lbtry.Font = new System.Drawing.Font("Bradobrei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbtry.Location = new System.Drawing.Point(121, 349);
            this.lbtry.Name = "lbtry";
            this.lbtry.Size = new System.Drawing.Size(36, 36);
            this.lbtry.TabIndex = 8;
            this.lbtry.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 9;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(458, 133);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(64, 27);
            this.check.TabIndex = 10;
            this.check.Text = "check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // RandomNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(651, 405);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbtry);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.lbtext2);
            this.Controls.Add(this.lbtext);
            this.Controls.Add(this.pbresalt);
            this.Controls.Add(this.pbUporDown);
            this.Controls.Add(this.tbInputByUser);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.cbLevels);
            this.MaximizeBox = false;
            this.Name = "RandomNumbers";
            this.Text = "Random Number";
            ((System.ComponentModel.ISupportInitialize)(this.pbresalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUporDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLevels;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox tbInputByUser;
        private System.Windows.Forms.PictureBox pbUporDown;
        private System.Windows.Forms.PictureBox pbresalt;
        public System.Windows.Forms.Label lbtext;
        public System.Windows.Forms.Label lbtext2;
        public System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.Label lbtry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button check;
    }
}

