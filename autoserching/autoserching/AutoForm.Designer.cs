namespace autoserching
{
    partial class AutoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoForm));
            this.rbTesla = new System.Windows.Forms.RadioButton();
            this.rbAudi = new System.Windows.Forms.RadioButton();
            this.rbMercedes = new System.Windows.Forms.RadioButton();
            this.picAuto = new System.Windows.Forms.PictureBox();
            this.lbModel = new System.Windows.Forms.Label();
            this.lbAdds = new System.Windows.Forms.Label();
            this.cbAbs = new System.Windows.Forms.CheckBox();
            this.cbExtra = new System.Windows.Forms.CheckBox();
            this.cbAlarma = new System.Windows.Forms.CheckBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbPaymethod = new System.Windows.Forms.Label();
            this.numOfPrice = new System.Windows.Forms.Label();
            this.numOfDiscount = new System.Windows.Forms.Label();
            this.numOfTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnGetDiscount = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbPriceModel = new System.Windows.Forms.Label();
            this.lbPrice2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.paybycash = new System.Windows.Forms.CheckBox();
            this.paybycheck = new System.Windows.Forms.CheckBox();
            this.paybycreditcard = new System.Windows.Forms.CheckBox();
            this.btnTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // rbTesla
            // 
            this.rbTesla.AutoSize = true;
            this.rbTesla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.rbTesla.Location = new System.Drawing.Point(34, 104);
            this.rbTesla.Name = "rbTesla";
            this.rbTesla.Size = new System.Drawing.Size(150, 24);
            this.rbTesla.TabIndex = 1;
            this.rbTesla.TabStop = true;
            this.rbTesla.Text = "Tesla Model X";
            this.rbTesla.UseVisualStyleBackColor = true;
            this.rbTesla.CheckedChanged += new System.EventHandler(this.rbTesla_CheckedChanged);
            // 
            // rbAudi
            // 
            this.rbAudi.AutoSize = true;
            this.rbAudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.rbAudi.Location = new System.Drawing.Point(34, 131);
            this.rbAudi.Name = "rbAudi";
            this.rbAudi.Size = new System.Drawing.Size(107, 24);
            this.rbAudi.TabIndex = 2;
            this.rbAudi.TabStop = true;
            this.rbAudi.Text = "Audio Q8";
            this.rbAudi.UseVisualStyleBackColor = true;
            this.rbAudi.CheckedChanged += new System.EventHandler(this.rbAudi_CheckedChanged);
            // 
            // rbMercedes
            // 
            this.rbMercedes.AutoSize = true;
            this.rbMercedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.rbMercedes.Location = new System.Drawing.Point(34, 77);
            this.rbMercedes.Name = "rbMercedes";
            this.rbMercedes.Size = new System.Drawing.Size(235, 24);
            this.rbMercedes.TabIndex = 3;
            this.rbMercedes.TabStop = true;
            this.rbMercedes.Text = "Mercedes Benz C-Class";
            this.rbMercedes.UseVisualStyleBackColor = true;
            this.rbMercedes.CheckedChanged += new System.EventHandler(this.rbMercedes_CheckedChanged);
            // 
            // picAuto
            // 
            this.picAuto.Image = global::autoserching.Properties.Resources._2017_tesla;
            this.picAuto.Location = new System.Drawing.Point(467, 29);
            this.picAuto.Name = "picAuto";
            this.picAuto.Size = new System.Drawing.Size(506, 328);
            this.picAuto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAuto.TabIndex = 4;
            this.picAuto.TabStop = false;
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbModel.ForeColor = System.Drawing.Color.Maroon;
            this.lbModel.Location = new System.Drawing.Point(31, 29);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(175, 32);
            this.lbModel.TabIndex = 5;
            this.lbModel.Text = "Choose model:";
            // 
            // lbAdds
            // 
            this.lbAdds.AutoSize = true;
            this.lbAdds.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbAdds.ForeColor = System.Drawing.Color.Maroon;
            this.lbAdds.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbAdds.Location = new System.Drawing.Point(31, 230);
            this.lbAdds.Name = "lbAdds";
            this.lbAdds.Size = new System.Drawing.Size(140, 32);
            this.lbAdds.TabIndex = 6;
            this.lbAdds.Text = "Extra Adds:";
            // 
            // cbAbs
            // 
            this.cbAbs.AutoSize = true;
            this.cbAbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbAbs.Location = new System.Drawing.Point(37, 279);
            this.cbAbs.Name = "cbAbs";
            this.cbAbs.Size = new System.Drawing.Size(68, 24);
            this.cbAbs.TabIndex = 7;
            this.cbAbs.Text = "ABS";
            this.cbAbs.UseVisualStyleBackColor = true;
            this.cbAbs.CheckedChanged += new System.EventHandler(this.cbAbs_CheckedChanged);
            // 
            // cbExtra
            // 
            this.cbExtra.AutoSize = true;
            this.cbExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbExtra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbExtra.Location = new System.Drawing.Point(37, 306);
            this.cbExtra.Name = "cbExtra";
            this.cbExtra.Size = new System.Drawing.Size(169, 24);
            this.cbExtra.TabIndex = 8;
            this.cbExtra.Text = "Etra light for fog";
            this.cbExtra.UseVisualStyleBackColor = true;
            this.cbExtra.CheckedChanged += new System.EventHandler(this.cbExtra_CheckedChanged);
            // 
            // cbAlarma
            // 
            this.cbAlarma.AutoSize = true;
            this.cbAlarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.cbAlarma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbAlarma.Location = new System.Drawing.Point(37, 333);
            this.cbAlarma.Name = "cbAlarma";
            this.cbAlarma.Size = new System.Drawing.Size(90, 24);
            this.cbAlarma.TabIndex = 9;
            this.cbAlarma.Text = "Alarma";
            this.cbAlarma.UseVisualStyleBackColor = true;
            this.cbAlarma.CheckedChanged += new System.EventHandler(this.cbAlarma_CheckedChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lbPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPrice.Location = new System.Drawing.Point(538, 407);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(75, 32);
            this.lbPrice.TabIndex = 10;
            this.lbPrice.Text = "Price:";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbDiscount.ForeColor = System.Drawing.Color.Maroon;
            this.lbDiscount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDiscount.Location = new System.Drawing.Point(538, 439);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(174, 32);
            this.lbDiscount.TabIndex = 11;
            this.lbDiscount.Text = "With discount:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lbTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTotal.Location = new System.Drawing.Point(538, 471);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(137, 32);
            this.lbTotal.TabIndex = 12;
            this.lbTotal.Text = "Total Price:";
            // 
            // lbPaymethod
            // 
            this.lbPaymethod.AutoSize = true;
            this.lbPaymethod.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbPaymethod.ForeColor = System.Drawing.Color.Maroon;
            this.lbPaymethod.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPaymethod.Location = new System.Drawing.Point(27, 378);
            this.lbPaymethod.Name = "lbPaymethod";
            this.lbPaymethod.Size = new System.Drawing.Size(205, 32);
            this.lbPaymethod.TabIndex = 13;
            this.lbPaymethod.Text = "Payment method:";
            // 
            // numOfPrice
            // 
            this.numOfPrice.AutoSize = true;
            this.numOfPrice.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.numOfPrice.Location = new System.Drawing.Point(651, 407);
            this.numOfPrice.Name = "numOfPrice";
            this.numOfPrice.Size = new System.Drawing.Size(24, 26);
            this.numOfPrice.TabIndex = 17;
            this.numOfPrice.Text = "0";
            // 
            // numOfDiscount
            // 
            this.numOfDiscount.AutoSize = true;
            this.numOfDiscount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.numOfDiscount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numOfDiscount.Location = new System.Drawing.Point(718, 439);
            this.numOfDiscount.Name = "numOfDiscount";
            this.numOfDiscount.Size = new System.Drawing.Size(24, 26);
            this.numOfDiscount.TabIndex = 18;
            this.numOfDiscount.Text = "0";
            // 
            // numOfTotal
            // 
            this.numOfTotal.AutoSize = true;
            this.numOfTotal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.numOfTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numOfTotal.Location = new System.Drawing.Point(770, 471);
            this.numOfTotal.Name = "numOfTotal";
            this.numOfTotal.Size = new System.Drawing.Size(24, 26);
            this.numOfTotal.TabIndex = 19;
            this.numOfTotal.Text = "0";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCalculate.Location = new System.Drawing.Point(41, 574);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(154, 33);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnGetDiscount
            // 
            this.btnGetDiscount.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnGetDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGetDiscount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGetDiscount.Location = new System.Drawing.Point(236, 574);
            this.btnGetDiscount.Name = "btnGetDiscount";
            this.btnGetDiscount.Size = new System.Drawing.Size(154, 33);
            this.btnGetDiscount.TabIndex = 21;
            this.btnGetDiscount.Text = "Get Discount";
            this.btnGetDiscount.UseVisualStyleBackColor = true;
            this.btnGetDiscount.Click += new System.EventHandler(this.btnGetDiscount_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReset.Location = new System.Drawing.Point(612, 574);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 33);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(819, 574);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(154, 33);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbPriceModel
            // 
            this.lbPriceModel.AutoSize = true;
            this.lbPriceModel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.lbPriceModel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPriceModel.Location = new System.Drawing.Point(231, 177);
            this.lbPriceModel.Name = "lbPriceModel";
            this.lbPriceModel.Size = new System.Drawing.Size(24, 26);
            this.lbPriceModel.TabIndex = 25;
            this.lbPriceModel.Text = "0";
            // 
            // lbPrice2
            // 
            this.lbPrice2.AutoSize = true;
            this.lbPrice2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbPrice2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPrice2.Location = new System.Drawing.Point(32, 177);
            this.lbPrice2.Name = "lbPrice2";
            this.lbPrice2.Size = new System.Drawing.Size(62, 27);
            this.lbPrice2.TabIndex = 24;
            this.lbPrice2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 26;
            // 
            // paybycash
            // 
            this.paybycash.AutoSize = true;
            this.paybycash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.paybycash.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.paybycash.Location = new System.Drawing.Point(37, 493);
            this.paybycash.Name = "paybycash";
            this.paybycash.Size = new System.Drawing.Size(99, 24);
            this.paybycash.TabIndex = 32;
            this.paybycash.Text = "by Cach";
            this.paybycash.UseVisualStyleBackColor = true;
            this.paybycash.CheckedChanged += new System.EventHandler(this.paybycash_CheckedChanged);
            // 
            // paybycheck
            // 
            this.paybycheck.AutoSize = true;
            this.paybycheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.paybycheck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.paybycheck.Location = new System.Drawing.Point(37, 466);
            this.paybycheck.Name = "paybycheck";
            this.paybycheck.Size = new System.Drawing.Size(108, 24);
            this.paybycheck.TabIndex = 31;
            this.paybycheck.Text = "by Check";
            this.paybycheck.UseVisualStyleBackColor = true;
            this.paybycheck.CheckedChanged += new System.EventHandler(this.paybycheck_CheckedChanged);
            // 
            // paybycreditcard
            // 
            this.paybycreditcard.AutoSize = true;
            this.paybycreditcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.paybycreditcard.Location = new System.Drawing.Point(37, 439);
            this.paybycreditcard.Name = "paybycreditcard";
            this.paybycreditcard.Size = new System.Drawing.Size(153, 24);
            this.paybycreditcard.TabIndex = 30;
            this.paybycreditcard.Text = "by Credit Card";
            this.paybycreditcard.UseVisualStyleBackColor = true;
            this.paybycreditcard.CheckedChanged += new System.EventHandler(this.paybycreditcard_CheckedChanged);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnTotal.Location = new System.Drawing.Point(421, 574);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(154, 33);
            this.btnTotal.TabIndex = 33;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // AutoForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1044, 634);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.paybycash);
            this.Controls.Add(this.paybycheck);
            this.Controls.Add(this.paybycreditcard);
            this.Controls.Add(this.lbPriceModel);
            this.Controls.Add(this.lbPrice2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGetDiscount);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numOfTotal);
            this.Controls.Add(this.numOfDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numOfPrice);
            this.Controls.Add(this.lbPaymethod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.cbAlarma);
            this.Controls.Add(this.cbExtra);
            this.Controls.Add(this.cbAbs);
            this.Controls.Add(this.lbAdds);
            this.Controls.Add(this.lbModel);
            this.Controls.Add(this.picAuto);
            this.Controls.Add(this.rbMercedes);
            this.Controls.Add(this.rbAudi);
            this.Controls.Add(this.rbTesla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Search Auto";
            ((System.ComponentModel.ISupportInitialize)(this.picAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbTesla;
        private System.Windows.Forms.RadioButton rbAudi;
        private System.Windows.Forms.RadioButton rbMercedes;
        private System.Windows.Forms.PictureBox picAuto;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label lbAdds;
        private System.Windows.Forms.CheckBox cbAbs;
        private System.Windows.Forms.CheckBox cbExtra;
        private System.Windows.Forms.CheckBox cbAlarma;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbPaymethod;
        private System.Windows.Forms.Label numOfPrice;
        private System.Windows.Forms.Label numOfDiscount;
        private System.Windows.Forms.Label numOfTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnGetDiscount;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbPriceModel;
        private System.Windows.Forms.Label lbPrice2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox paybycash;
        private System.Windows.Forms.CheckBox paybycheck;
        private System.Windows.Forms.CheckBox paybycreditcard;
        private System.Windows.Forms.Button btnTotal;
    }
}

