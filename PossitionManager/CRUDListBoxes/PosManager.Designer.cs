namespace CRUDListBoxes
{
    partial class PosManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosManager));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEnter = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnBottom, "btnBottom");
            this.btnBottom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.UseVisualStyleBackColor = false;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnDown, "btnDown");
            this.btnDown.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDown.Name = "btnDown";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click_1);
            // 
            // btnUP
            // 
            this.btnUP.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnUP, "btnUP");
            this.btnUP.Name = "btnUP";
            this.btnUP.UseVisualStyleBackColor = false;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click_1);
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.SystemColors.Highlight;
            resources.ApplyResources(this.btnTop, "btnTop");
            this.btnTop.Name = "btnTop";
            this.btnTop.UseVisualStyleBackColor = false;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbEnter
            // 
            resources.ApplyResources(this.tbEnter, "tbEnter");
            this.tbEnter.Name = "tbEnter";
            this.tbEnter.TextChanged += new System.EventHandler(this.tbEnter_TextChanged);
            // 
            // lbResult
            // 
            resources.ApplyResources(this.lbResult, "lbResult");
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Name = "lbResult";
            // 
            // PosManager
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEnter);
            this.Controls.Add(this.lbResult);
            this.MaximizeBox = false;
            this.Name = "PosManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBottom;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEnter;
        private System.Windows.Forms.ListBox lbResult;
    }
}

