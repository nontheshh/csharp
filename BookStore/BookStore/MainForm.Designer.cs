namespace BookStore
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.listBooks = new System.Windows.Forms.ListBox();
            this.listAuthors = new System.Windows.Forms.ListBox();
            this.buttonWriteOffBook = new System.Windows.Forms.Button();
            this.cBoxSearch = new System.Windows.Forms.ComboBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPublisingHouse = new System.Windows.Forms.TextBox();
            this.textTheme = new System.Windows.Forms.TextBox();
            this.textSaleCost = new System.Windows.Forms.TextBox();
            this.textPrimeCost = new System.Windows.Forms.TextBox();
            this.textPageCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.textPart = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textSeria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonToStorage = new System.Windows.Forms.Button();
            this.listStorage = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(92, 205);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(75, 23);
            this.buttonAddBook.TabIndex = 0;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(490, 232);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(75, 23);
            this.buttonSell.TabIndex = 1;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.Location = new System.Drawing.Point(414, 9);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchBook.TabIndex = 2;
            this.buttonSearchBook.Text = "Search Book";
            this.buttonSearchBook.UseVisualStyleBackColor = true;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // listBooks
            // 
            this.listBooks.FormattingEnabled = true;
            this.listBooks.Location = new System.Drawing.Point(12, 104);
            this.listBooks.Name = "listBooks";
            this.listBooks.Size = new System.Drawing.Size(317, 95);
            this.listBooks.TabIndex = 3;
            this.listBooks.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listAuthors
            // 
            this.listAuthors.FormattingEnabled = true;
            this.listAuthors.Location = new System.Drawing.Point(335, 104);
            this.listAuthors.Name = "listAuthors";
            this.listAuthors.Size = new System.Drawing.Size(233, 95);
            this.listAuthors.TabIndex = 4;
            // 
            // buttonWriteOffBook
            // 
            this.buttonWriteOffBook.Location = new System.Drawing.Point(173, 205);
            this.buttonWriteOffBook.Name = "buttonWriteOffBook";
            this.buttonWriteOffBook.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteOffBook.TabIndex = 6;
            this.buttonWriteOffBook.Text = "Write Off";
            this.buttonWriteOffBook.UseVisualStyleBackColor = true;
            this.buttonWriteOffBook.Click += new System.EventHandler(this.buttonWriteOffBook_Click);
            // 
            // cBoxSearch
            // 
            this.cBoxSearch.FormattingEnabled = true;
            this.cBoxSearch.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Theme"});
            this.cBoxSearch.Location = new System.Drawing.Point(287, 11);
            this.cBoxSearch.Name = "cBoxSearch";
            this.cBoxSearch.Size = new System.Drawing.Size(121, 21);
            this.cBoxSearch.TabIndex = 7;
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(55, 11);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(201, 20);
            this.textSearch.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "by";
            // 
            // textPublisingHouse
            // 
            this.textPublisingHouse.Location = new System.Drawing.Point(117, 56);
            this.textPublisingHouse.Name = "textPublisingHouse";
            this.textPublisingHouse.Size = new System.Drawing.Size(100, 20);
            this.textPublisingHouse.TabIndex = 13;
            // 
            // textTheme
            // 
            this.textTheme.Location = new System.Drawing.Point(11, 56);
            this.textTheme.Name = "textTheme";
            this.textTheme.Size = new System.Drawing.Size(100, 20);
            this.textTheme.TabIndex = 14;
            // 
            // textSaleCost
            // 
            this.textSaleCost.Location = new System.Drawing.Point(223, 56);
            this.textSaleCost.Name = "textSaleCost";
            this.textSaleCost.Size = new System.Drawing.Size(49, 20);
            this.textSaleCost.TabIndex = 15;
            // 
            // textPrimeCost
            // 
            this.textPrimeCost.Location = new System.Drawing.Point(278, 56);
            this.textPrimeCost.Name = "textPrimeCost";
            this.textPrimeCost.Size = new System.Drawing.Size(49, 20);
            this.textPrimeCost.TabIndex = 16;
            // 
            // textPageCount
            // 
            this.textPageCount.Location = new System.Drawing.Point(337, 56);
            this.textPageCount.Name = "textPageCount";
            this.textPageCount.Size = new System.Drawing.Size(49, 20);
            this.textPageCount.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Publishing House";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Theme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sale Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Prime Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Pages";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Author(s)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Books";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(11, 205);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAll.TabIndex = 25;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // textPart
            // 
            this.textPart.Location = new System.Drawing.Point(476, 56);
            this.textPart.Name = "textPart";
            this.textPart.Size = new System.Drawing.Size(47, 20);
            this.textPart.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(482, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Part";
            // 
            // textSeria
            // 
            this.textSeria.Location = new System.Drawing.Point(392, 56);
            this.textSeria.Name = "textSeria";
            this.textSeria.Size = new System.Drawing.Size(78, 20);
            this.textSeria.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Seria Name";
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(490, 261);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonOrder.TabIndex = 30;
            this.buttonOrder.Text = "Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonToStorage
            // 
            this.buttonToStorage.Location = new System.Drawing.Point(254, 205);
            this.buttonToStorage.Name = "buttonToStorage";
            this.buttonToStorage.Size = new System.Drawing.Size(75, 23);
            this.buttonToStorage.TabIndex = 31;
            this.buttonToStorage.Text = "To Storage";
            this.buttonToStorage.UseVisualStyleBackColor = true;
            this.buttonToStorage.Click += new System.EventHandler(this.buttonToStorage_Click);
            // 
            // listStorage
            // 
            this.listStorage.FormattingEnabled = true;
            this.listStorage.Location = new System.Drawing.Point(12, 234);
            this.listStorage.Name = "listStorage";
            this.listStorage.Size = new System.Drawing.Size(472, 147);
            this.listStorage.TabIndex = 32;
            this.listStorage.SelectedIndexChanged += new System.EventHandler(this.listStorage_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(490, 358);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 33;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Location = new System.Drawing.Point(409, 205);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(75, 23);
            this.buttonStatistics.TabIndex = 34;
            this.buttonStatistics.Text = "Statistics";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 389);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listStorage);
            this.Controls.Add(this.buttonToStorage);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textSeria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textPart);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPageCount);
            this.Controls.Add(this.textPrimeCost);
            this.Controls.Add(this.textSaleCost);
            this.Controls.Add(this.textTheme);
            this.Controls.Add(this.textPublisingHouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.cBoxSearch);
            this.Controls.Add(this.buttonWriteOffBook);
            this.Controls.Add(this.listAuthors);
            this.Controls.Add(this.listBooks);
            this.Controls.Add(this.buttonSearchBook);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.buttonAddBook);
            this.MaximumSize = new System.Drawing.Size(593, 428);
            this.MinimumSize = new System.Drawing.Size(593, 428);
            this.Name = "MainForm";
            this.Text = "MForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.ListBox listBooks;
        private System.Windows.Forms.ListBox listAuthors;
        private System.Windows.Forms.Button buttonWriteOffBook;
        private System.Windows.Forms.ComboBox cBoxSearch;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPublisingHouse;
        private System.Windows.Forms.TextBox textTheme;
        private System.Windows.Forms.TextBox textSaleCost;
        private System.Windows.Forms.TextBox textPrimeCost;
        private System.Windows.Forms.TextBox textPageCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.TextBox textPart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textSeria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonToStorage;
        private System.Windows.Forms.ListBox listStorage;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonStatistics;
    }
}

