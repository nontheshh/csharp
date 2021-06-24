namespace BookStore
{
    partial class SellingOrderingForm
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
            this.listCustomer = new System.Windows.Forms.ListBox();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textMiddleName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listCustomer
            // 
            this.listCustomer.FormattingEnabled = true;
            this.listCustomer.Location = new System.Drawing.Point(12, 166);
            this.listCustomer.Name = "listCustomer";
            this.listCustomer.Size = new System.Drawing.Size(296, 121);
            this.listCustomer.TabIndex = 0;
            this.listCustomer.SelectedIndexChanged += new System.EventHandler(this.listCustomer_SelectedIndexChanged);
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(111, 311);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(75, 23);
            this.buttonSell.TabIndex = 1;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(111, 137);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(12, 74);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(295, 20);
            this.textLastName.TabIndex = 5;
            this.textLastName.TextChanged += new System.EventHandler(this.anyTextBox_TextChanged);
            // 
            // textMiddleName
            // 
            this.textMiddleName.Location = new System.Drawing.Point(12, 111);
            this.textMiddleName.Name = "textMiddleName";
            this.textMiddleName.Size = new System.Drawing.Size(295, 20);
            this.textMiddleName.TabIndex = 6;
            this.textMiddleName.TextChanged += new System.EventHandler(this.anyTextBox_TextChanged);
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(12, 30);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(295, 20);
            this.textFirstName.TabIndex = 7;
            this.textFirstName.TextChanged += new System.EventHandler(this.anyTextBox_TextChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(38, 14);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(54, 13);
            this.labelFirstName.TabIndex = 8;
            this.labelFirstName.Text = "FirstName";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(38, 58);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(55, 13);
            this.labelLastName.TabIndex = 9;
            this.labelLastName.Text = "LastName";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(38, 95);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(66, 13);
            this.labelMiddleName.TabIndex = 10;
            this.labelMiddleName.Text = "MiddleName";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 346);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.textMiddleName);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.listCustomer);
            this.MaximumSize = new System.Drawing.Size(335, 385);
            this.MinimumSize = new System.Drawing.Size(335, 385);
            this.Name = "Form3";
            this.Text = "Selling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCustomer;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textMiddleName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMiddleName;
    }
}