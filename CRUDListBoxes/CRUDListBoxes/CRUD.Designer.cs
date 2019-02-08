namespace CRUDListBoxes
{
    partial class CRUD
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnRemoveElement = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSearch.Location = new System.Drawing.Point(508, 11);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(172, 38);
            this.tbSearch.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter elements here:";
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(29, 38);
            this.tbInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(433, 30);
            this.tbInput.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(356, 335);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 39);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Element";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.BackColor = System.Drawing.Color.OliveDrab;
            this.btnRemoveAll.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveAll.Location = new System.Drawing.Point(632, 333);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(187, 39);
            this.btnRemoveAll.TabIndex = 7;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = false;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnRemoveElement
            // 
            this.btnRemoveElement.BackColor = System.Drawing.Color.OliveDrab;
            this.btnRemoveElement.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemoveElement.Location = new System.Drawing.Point(183, 333);
            this.btnRemoveElement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveElement.Name = "btnRemoveElement";
            this.btnRemoveElement.Size = new System.Drawing.Size(145, 41);
            this.btnRemoveElement.TabIndex = 8;
            this.btnRemoveElement.Text = "Remove Element";
            this.btnRemoveElement.UseVisualStyleBackColor = false;
            this.btnRemoveElement.Click += new System.EventHandler(this.btnRemoveElement_Click);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSort.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSort.Location = new System.Drawing.Point(507, 334);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(119, 38);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(686, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 42);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAdd.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(29, 332);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 41);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Element";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 29;
            this.lbResult.Location = new System.Drawing.Point(29, 89);
            this.lbResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(790, 236);
            this.lbResult.TabIndex = 5;
            this.lbResult.SelectedIndexChanged += new System.EventHandler(this.lbResult_SelectedIndexChanged);
            // 
            // CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 398);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemoveElement);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbResult);
            this.MinimizeBox = false;
            this.Name = "CRUD";
            this.Text = "CRUD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnRemoveElement;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbResult;
    }
}

