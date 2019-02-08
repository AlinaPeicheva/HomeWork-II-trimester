namespace GoshaCalculator
{
    partial class GoshaCalcul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoshaCalcul));
            this.tbFirstNum = new System.Windows.Forms.TextBox();
            this.tbSecondNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAllNumbers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnGenerateNumbers = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbmin = new System.Windows.Forms.Label();
            this.lbmax = new System.Windows.Forms.Label();
            this.lbaverage = new System.Windows.Forms.Label();
            this.lbsum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFirstNum
            // 
            this.tbFirstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFirstNum.Location = new System.Drawing.Point(32, 74);
            this.tbFirstNum.Multiline = true;
            this.tbFirstNum.Name = "tbFirstNum";
            this.tbFirstNum.Size = new System.Drawing.Size(108, 50);
            this.tbFirstNum.TabIndex = 0;
            // 
            // tbSecondNum
            // 
            this.tbSecondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSecondNum.Location = new System.Drawing.Point(186, 74);
            this.tbSecondNum.Multiline = true;
            this.tbSecondNum.Name = "tbSecondNum";
            this.tbSecondNum.Size = new System.Drawing.Size(116, 50);
            this.tbSecondNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input interval boundaries:";
            // 
            // lbAllNumbers
            // 
            this.lbAllNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAllNumbers.FormattingEnabled = true;
            this.lbAllNumbers.ItemHeight = 25;
            this.lbAllNumbers.Location = new System.Drawing.Point(32, 210);
            this.lbAllNumbers.Name = "lbAllNumbers";
            this.lbAllNumbers.Size = new System.Drawing.Size(302, 229);
            this.lbAllNumbers.TabIndex = 3;
            this.lbAllNumbers.SelectedIndexChanged += new System.EventHandler(this.lbAllNumbers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(28, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "20 Random Numbers:";
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMin.ForeColor = System.Drawing.Color.Orange;
            this.btnMin.Location = new System.Drawing.Point(502, 24);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(111, 56);
            this.btnMin.TabIndex = 5;
            this.btnMin.Text = "MIN";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMax.ForeColor = System.Drawing.Color.Orange;
            this.btnMax.Location = new System.Drawing.Point(502, 86);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(111, 56);
            this.btnMax.TabIndex = 6;
            this.btnMax.Text = "MAX";
            this.btnMax.UseVisualStyleBackColor = false;
            // 
            // btnAverage
            // 
            this.btnAverage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAverage.ForeColor = System.Drawing.Color.Orange;
            this.btnAverage.Location = new System.Drawing.Point(502, 148);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(111, 56);
            this.btnAverage.TabIndex = 7;
            this.btnAverage.Text = "AVERAGE";
            this.btnAverage.UseVisualStyleBackColor = false;
            // 
            // btnGenerateNumbers
            // 
            this.btnGenerateNumbers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerateNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerateNumbers.ForeColor = System.Drawing.Color.Orange;
            this.btnGenerateNumbers.Location = new System.Drawing.Point(261, 155);
            this.btnGenerateNumbers.Name = "btnGenerateNumbers";
            this.btnGenerateNumbers.Size = new System.Drawing.Size(139, 38);
            this.btnGenerateNumbers.TabIndex = 8;
            this.btnGenerateNumbers.Text = "Generate";
            this.btnGenerateNumbers.UseVisualStyleBackColor = false;
            this.btnGenerateNumbers.Click += new System.EventHandler(this.btnGenerateNumbers_Click);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSum.ForeColor = System.Drawing.Color.Orange;
            this.btnSum.Location = new System.Drawing.Point(502, 210);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(111, 56);
            this.btnSum.TabIndex = 9;
            this.btnSum.Text = "SUM";
            this.btnSum.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.Orange;
            this.btnDelete.Location = new System.Drawing.Point(502, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 56);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.ForeColor = System.Drawing.Color.Orange;
            this.btnReset.Location = new System.Drawing.Point(502, 339);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 56);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.Orange;
            this.btnClose.Location = new System.Drawing.Point(502, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 56);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbmin
            // 
            this.lbmin.AutoSize = true;
            this.lbmin.Location = new System.Drawing.Point(664, 45);
            this.lbmin.Name = "lbmin";
            this.lbmin.Size = new System.Drawing.Size(16, 17);
            this.lbmin.TabIndex = 13;
            this.lbmin.Text = "0";
            // 
            // lbmax
            // 
            this.lbmax.AutoSize = true;
            this.lbmax.Location = new System.Drawing.Point(664, 97);
            this.lbmax.Name = "lbmax";
            this.lbmax.Size = new System.Drawing.Size(16, 17);
            this.lbmax.TabIndex = 14;
            this.lbmax.Text = "0";
            // 
            // lbaverage
            // 
            this.lbaverage.AutoSize = true;
            this.lbaverage.Location = new System.Drawing.Point(664, 167);
            this.lbaverage.Name = "lbaverage";
            this.lbaverage.Size = new System.Drawing.Size(16, 17);
            this.lbaverage.TabIndex = 15;
            this.lbaverage.Text = "0";
            // 
            // lbsum
            // 
            this.lbsum.AutoSize = true;
            this.lbsum.Location = new System.Drawing.Point(664, 231);
            this.lbsum.Name = "lbsum";
            this.lbsum.Size = new System.Drawing.Size(16, 17);
            this.lbsum.TabIndex = 16;
            this.lbsum.Text = "0";
            // 
            // GoshaCalcul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(801, 457);
            this.Controls.Add(this.lbsum);
            this.Controls.Add(this.lbaverage);
            this.Controls.Add(this.lbmax);
            this.Controls.Add(this.lbmin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnGenerateNumbers);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAllNumbers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSecondNum);
            this.Controls.Add(this.tbFirstNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GoshaCalcul";
            this.Text = "Gosha Calculator Pro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstNum;
        private System.Windows.Forms.TextBox tbSecondNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAllNumbers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Button btnGenerateNumbers;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbmin;
        private System.Windows.Forms.Label lbmax;
        private System.Windows.Forms.Label lbaverage;
        private System.Windows.Forms.Label lbsum;
    }
}

