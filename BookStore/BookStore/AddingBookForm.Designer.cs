namespace BookStore
{
    partial class AddingBookForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelSaleCost = new System.Windows.Forms.Label();
            this.labelPrimeCost = new System.Windows.Forms.Label();
            this.numericSaleCost = new System.Windows.Forms.NumericUpDown();
            this.numericPrimeCost = new System.Windows.Forms.NumericUpDown();
            this.numericPageCount = new System.Windows.Forms.NumericUpDown();
            this.labelPublishDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelPageCount = new System.Windows.Forms.Label();
            this.buttonSearchTheme = new System.Windows.Forms.Button();
            this.listThemes = new System.Windows.Forms.ListBox();
            this.labelTheme = new System.Windows.Forms.Label();
            this.textTheme = new System.Windows.Forms.TextBox();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelPartOfSeria = new System.Windows.Forms.Label();
            this.numericSeriaPart = new System.Windows.Forms.NumericUpDown();
            this.buttonSearchSeria = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listSeria = new System.Windows.Forms.ListBox();
            this.labelSeria = new System.Windows.Forms.Label();
            this.textSeria = new System.Windows.Forms.TextBox();
            this.checkIsSeria = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.listSelectedAuthors = new System.Windows.Forms.ListBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSearchAuthor = new System.Windows.Forms.Button();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textMiddleName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listAuthors = new System.Windows.Forms.ListBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonSearchPublishingHouse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.listPublishingHouses = new System.Windows.Forms.ListBox();
            this.textPublishingHouse = new System.Windows.Forms.TextBox();
            this.labelPublishingHouse = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaleCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrimeCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPageCount)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeriaPart)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(389, 351);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.CausesValidation = false;
            this.tabPage1.Controls.Add(this.labelSaleCost);
            this.tabPage1.Controls.Add(this.labelPrimeCost);
            this.tabPage1.Controls.Add(this.numericSaleCost);
            this.tabPage1.Controls.Add(this.numericPrimeCost);
            this.tabPage1.Controls.Add(this.numericPageCount);
            this.tabPage1.Controls.Add(this.labelPublishDate);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.labelPageCount);
            this.tabPage1.Controls.Add(this.buttonSearchTheme);
            this.tabPage1.Controls.Add(this.listThemes);
            this.tabPage1.Controls.Add(this.labelTheme);
            this.tabPage1.Controls.Add(this.textTheme);
            this.tabPage1.Controls.Add(this.buttonNext1);
            this.tabPage1.Controls.Add(this.labelTitle);
            this.tabPage1.Controls.Add(this.textTitle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(381, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelSaleCost
            // 
            this.labelSaleCost.AutoSize = true;
            this.labelSaleCost.Location = new System.Drawing.Point(282, 48);
            this.labelSaleCost.Name = "labelSaleCost";
            this.labelSaleCost.Size = new System.Drawing.Size(52, 13);
            this.labelSaleCost.TabIndex = 18;
            this.labelSaleCost.Text = "Sale Cost";
            // 
            // labelPrimeCost
            // 
            this.labelPrimeCost.AutoSize = true;
            this.labelPrimeCost.Location = new System.Drawing.Point(183, 48);
            this.labelPrimeCost.Name = "labelPrimeCost";
            this.labelPrimeCost.Size = new System.Drawing.Size(57, 13);
            this.labelPrimeCost.TabIndex = 17;
            this.labelPrimeCost.Text = "Prime Cost";
            // 
            // numericSaleCost
            // 
            this.numericSaleCost.Location = new System.Drawing.Point(265, 64);
            this.numericSaleCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericSaleCost.Name = "numericSaleCost";
            this.numericSaleCost.Size = new System.Drawing.Size(92, 20);
            this.numericSaleCost.TabIndex = 16;
            // 
            // numericPrimeCost
            // 
            this.numericPrimeCost.Location = new System.Drawing.Point(163, 64);
            this.numericPrimeCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPrimeCost.Name = "numericPrimeCost";
            this.numericPrimeCost.Size = new System.Drawing.Size(96, 20);
            this.numericPrimeCost.TabIndex = 15;
            // 
            // numericPageCount
            // 
            this.numericPageCount.Location = new System.Drawing.Point(8, 64);
            this.numericPageCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericPageCount.Name = "numericPageCount";
            this.numericPageCount.Size = new System.Drawing.Size(149, 20);
            this.numericPageCount.TabIndex = 14;
            // 
            // labelPublishDate
            // 
            this.labelPublishDate.AutoSize = true;
            this.labelPublishDate.Location = new System.Drawing.Point(94, 128);
            this.labelPublishDate.Name = "labelPublishDate";
            this.labelPublishDate.Size = new System.Drawing.Size(67, 13);
            this.labelPublishDate.TabIndex = 13;
            this.labelPublishDate.Text = "Publish Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(365, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // labelPageCount
            // 
            this.labelPageCount.AutoSize = true;
            this.labelPageCount.Location = new System.Drawing.Point(94, 48);
            this.labelPageCount.Name = "labelPageCount";
            this.labelPageCount.Size = new System.Drawing.Size(37, 13);
            this.labelPageCount.TabIndex = 11;
            this.labelPageCount.Text = "Pages";
            // 
            // buttonSearchTheme
            // 
            this.buttonSearchTheme.Location = new System.Drawing.Point(298, 103);
            this.buttonSearchTheme.Name = "buttonSearchTheme";
            this.buttonSearchTheme.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchTheme.TabIndex = 9;
            this.buttonSearchTheme.Text = "Search";
            this.buttonSearchTheme.UseVisualStyleBackColor = true;
            this.buttonSearchTheme.Click += new System.EventHandler(this.buttonSearchTheme_Click);
            // 
            // listThemes
            // 
            this.listThemes.FormattingEnabled = true;
            this.listThemes.Location = new System.Drawing.Point(6, 195);
            this.listThemes.Name = "listThemes";
            this.listThemes.Size = new System.Drawing.Size(369, 95);
            this.listThemes.TabIndex = 8;
            this.listThemes.SelectedIndexChanged += new System.EventHandler(this.listThemes_SelectedIndexChanged);
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Location = new System.Drawing.Point(94, 87);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(40, 13);
            this.labelTheme.TabIndex = 7;
            this.labelTheme.Text = "Theme";
            // 
            // textTheme
            // 
            this.textTheme.Location = new System.Drawing.Point(8, 105);
            this.textTheme.Name = "textTheme";
            this.textTheme.Size = new System.Drawing.Size(289, 20);
            this.textTheme.TabIndex = 6;
            this.textTheme.TextChanged += new System.EventHandler(this.textTheme_TextChanged);
            // 
            // buttonNext1
            // 
            this.buttonNext1.Location = new System.Drawing.Point(232, 296);
            this.buttonNext1.Name = "buttonNext1";
            this.buttonNext1.Size = new System.Drawing.Size(75, 23);
            this.buttonNext1.TabIndex = 5;
            this.buttonNext1.Text = "Next";
            this.buttonNext1.UseVisualStyleBackColor = true;
            this.buttonNext1.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(94, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Title";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(8, 25);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(365, 20);
            this.textTitle.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelPartOfSeria);
            this.tabPage4.Controls.Add(this.numericSeriaPart);
            this.tabPage4.Controls.Add(this.buttonSearchSeria);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.listSeria);
            this.tabPage4.Controls.Add(this.labelSeria);
            this.tabPage4.Controls.Add(this.textSeria);
            this.tabPage4.Controls.Add(this.checkIsSeria);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(381, 325);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Seria";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelPartOfSeria
            // 
            this.labelPartOfSeria.AutoSize = true;
            this.labelPartOfSeria.Location = new System.Drawing.Point(63, 88);
            this.labelPartOfSeria.Name = "labelPartOfSeria";
            this.labelPartOfSeria.Size = new System.Drawing.Size(65, 13);
            this.labelPartOfSeria.TabIndex = 21;
            this.labelPartOfSeria.Text = "Part of Seria";
            // 
            // numericSeriaPart
            // 
            this.numericSeriaPart.Enabled = false;
            this.numericSeriaPart.Location = new System.Drawing.Point(8, 104);
            this.numericSeriaPart.Name = "numericSeriaPart";
            this.numericSeriaPart.Size = new System.Drawing.Size(120, 20);
            this.numericSeriaPart.TabIndex = 20;
            // 
            // buttonSearchSeria
            // 
            this.buttonSearchSeria.Enabled = false;
            this.buttonSearchSeria.Location = new System.Drawing.Point(303, 58);
            this.buttonSearchSeria.Name = "buttonSearchSeria";
            this.buttonSearchSeria.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchSeria.TabIndex = 19;
            this.buttonSearchSeria.Text = "Search";
            this.buttonSearchSeria.UseVisualStyleBackColor = true;
            this.buttonSearchSeria.Click += new System.EventHandler(this.buttonSearchSeria_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(234, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Next";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // listSeria
            // 
            this.listSeria.Enabled = false;
            this.listSeria.FormattingEnabled = true;
            this.listSeria.Location = new System.Drawing.Point(8, 155);
            this.listSeria.Name = "listSeria";
            this.listSeria.Size = new System.Drawing.Size(365, 121);
            this.listSeria.TabIndex = 3;
            this.listSeria.SelectedIndexChanged += new System.EventHandler(this.listSeria_SelectedIndexChanged);
            // 
            // labelSeria
            // 
            this.labelSeria.AutoSize = true;
            this.labelSeria.Enabled = false;
            this.labelSeria.Location = new System.Drawing.Point(63, 34);
            this.labelSeria.Name = "labelSeria";
            this.labelSeria.Size = new System.Drawing.Size(35, 13);
            this.labelSeria.TabIndex = 2;
            this.labelSeria.Text = "Name";
            // 
            // textSeria
            // 
            this.textSeria.Enabled = false;
            this.textSeria.Location = new System.Drawing.Point(8, 60);
            this.textSeria.Name = "textSeria";
            this.textSeria.Size = new System.Drawing.Size(292, 20);
            this.textSeria.TabIndex = 1;
            this.textSeria.TextChanged += new System.EventHandler(this.textSeria_TextChanged);
            // 
            // checkIsSeria
            // 
            this.checkIsSeria.AutoSize = true;
            this.checkIsSeria.Location = new System.Drawing.Point(171, 30);
            this.checkIsSeria.Name = "checkIsSeria";
            this.checkIsSeria.Size = new System.Drawing.Size(61, 17);
            this.checkIsSeria.TabIndex = 0;
            this.checkIsSeria.Text = "Is Seria";
            this.checkIsSeria.UseVisualStyleBackColor = true;
            this.checkIsSeria.CheckedChanged += new System.EventHandler(this.checkIsSeria_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAddAuthor);
            this.tabPage2.Controls.Add(this.listSelectedAuthors);
            this.tabPage2.Controls.Add(this.buttonBack);
            this.tabPage2.Controls.Add(this.buttonSearchAuthor);
            this.tabPage2.Controls.Add(this.labelMiddleName);
            this.tabPage2.Controls.Add(this.textMiddleName);
            this.tabPage2.Controls.Add(this.labelLastName);
            this.tabPage2.Controls.Add(this.textLastName);
            this.tabPage2.Controls.Add(this.labelFirstName);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.listAuthors);
            this.tabPage2.Controls.Add(this.textFirstName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(381, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Author";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(151, 223);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAuthor.TabIndex = 18;
            this.buttonAddAuthor.Text = "Add";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // listSelectedAuthors
            // 
            this.listSelectedAuthors.FormattingEnabled = true;
            this.listSelectedAuthors.Location = new System.Drawing.Point(11, 245);
            this.listSelectedAuthors.Name = "listSelectedAuthors";
            this.listSelectedAuthors.Size = new System.Drawing.Size(370, 43);
            this.listSelectedAuthors.TabIndex = 17;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(53, 294);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSearchAuthor
            // 
            this.buttonSearchAuthor.Location = new System.Drawing.Point(3, 131);
            this.buttonSearchAuthor.Name = "buttonSearchAuthor";
            this.buttonSearchAuthor.Size = new System.Drawing.Size(372, 23);
            this.buttonSearchAuthor.TabIndex = 15;
            this.buttonSearchAuthor.Text = "Search";
            this.buttonSearchAuthor.UseVisualStyleBackColor = true;
            this.buttonSearchAuthor.Click += new System.EventHandler(this.buttonSearchAuthor_Click);
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(95, 89);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(69, 13);
            this.labelMiddleName.TabIndex = 14;
            this.labelMiddleName.Text = "Middle Name";
            // 
            // textMiddleName
            // 
            this.textMiddleName.Location = new System.Drawing.Point(3, 105);
            this.textMiddleName.Name = "textMiddleName";
            this.textMiddleName.Size = new System.Drawing.Size(370, 20);
            this.textMiddleName.TabIndex = 13;
            this.textMiddleName.TextChanged += new System.EventHandler(this.anyTextBoxAuthor_TextChanged);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(95, 52);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 12;
            this.labelLastName.Text = "Last Name";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(3, 68);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(370, 20);
            this.textLastName.TabIndex = 11;
            this.textLastName.TextChanged += new System.EventHandler(this.anyTextBoxAuthor_TextChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(95, 13);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "First Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // listAuthors
            // 
            this.listAuthors.FormattingEnabled = true;
            this.listAuthors.Location = new System.Drawing.Point(8, 161);
            this.listAuthors.Name = "listAuthors";
            this.listAuthors.Size = new System.Drawing.Size(370, 56);
            this.listAuthors.TabIndex = 8;
            this.listAuthors.SelectedIndexChanged += new System.EventHandler(this.listAuthors_SelectedIndexChanged);
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(3, 29);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(370, 20);
            this.textFirstName.TabIndex = 6;
            this.textFirstName.TextChanged += new System.EventHandler(this.anyTextBoxAuthor_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonSearchPublishingHouse);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.buttonAddBook);
            this.tabPage3.Controls.Add(this.listPublishingHouses);
            this.tabPage3.Controls.Add(this.textPublishingHouse);
            this.tabPage3.Controls.Add(this.labelPublishingHouse);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(381, 325);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Publishing House";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonSearchPublishingHouse
            // 
            this.buttonSearchPublishingHouse.Location = new System.Drawing.Point(3, 88);
            this.buttonSearchPublishingHouse.Name = "buttonSearchPublishingHouse";
            this.buttonSearchPublishingHouse.Size = new System.Drawing.Size(370, 23);
            this.buttonSearchPublishingHouse.TabIndex = 5;
            this.buttonSearchPublishingHouse.Text = "Search";
            this.buttonSearchPublishingHouse.UseVisualStyleBackColor = true;
            this.buttonSearchPublishingHouse.Click += new System.EventHandler(this.buttonSearchPublishingHouse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(0, 299);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(381, 23);
            this.buttonAddBook.TabIndex = 3;
            this.buttonAddBook.Text = "Add the Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // listPublishingHouses
            // 
            this.listPublishingHouses.FormattingEnabled = true;
            this.listPublishingHouses.Location = new System.Drawing.Point(0, 117);
            this.listPublishingHouses.Name = "listPublishingHouses";
            this.listPublishingHouses.Size = new System.Drawing.Size(373, 134);
            this.listPublishingHouses.TabIndex = 2;
            this.listPublishingHouses.SelectedIndexChanged += new System.EventHandler(this.listPublishingHouses_SelectedIndexChanged);
            // 
            // textPublishingHouse
            // 
            this.textPublishingHouse.Location = new System.Drawing.Point(8, 50);
            this.textPublishingHouse.Name = "textPublishingHouse";
            this.textPublishingHouse.Size = new System.Drawing.Size(365, 20);
            this.textPublishingHouse.TabIndex = 1;
            this.textPublishingHouse.TextChanged += new System.EventHandler(this.textPublishingHouse_TextChanged);
            // 
            // labelPublishingHouse
            // 
            this.labelPublishingHouse.AutoSize = true;
            this.labelPublishingHouse.Location = new System.Drawing.Point(109, 29);
            this.labelPublishingHouse.Name = "labelPublishingHouse";
            this.labelPublishingHouse.Size = new System.Drawing.Size(35, 13);
            this.labelPublishingHouse.TabIndex = 0;
            this.labelPublishingHouse.Text = "Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 351);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(405, 390);
            this.MinimumSize = new System.Drawing.Size(405, 390);
            this.Name = "Form2";
            this.Text = "BookAdding";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaleCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrimeCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPageCount)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSeriaPart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSearchAuthor;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textMiddleName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listAuthors;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.ListBox listPublishingHouses;
        private System.Windows.Forms.TextBox textPublishingHouse;
        private System.Windows.Forms.Label labelPublishingHouse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSearchPublishingHouse;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.ListBox listSelectedAuthors;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox listSeria;
        private System.Windows.Forms.Label labelSeria;
        private System.Windows.Forms.TextBox textSeria;
        private System.Windows.Forms.CheckBox checkIsSeria;
        private System.Windows.Forms.Button buttonSearchSeria;
        private System.Windows.Forms.NumericUpDown numericSeriaPart;
        private System.Windows.Forms.Label labelPartOfSeria;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelSaleCost;
        private System.Windows.Forms.Label labelPrimeCost;
        private System.Windows.Forms.NumericUpDown numericSaleCost;
        private System.Windows.Forms.NumericUpDown numericPrimeCost;
        private System.Windows.Forms.NumericUpDown numericPageCount;
        private System.Windows.Forms.Label labelPublishDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelPageCount;
        private System.Windows.Forms.Button buttonSearchTheme;
        private System.Windows.Forms.ListBox listThemes;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.TextBox textTheme;
        private System.Windows.Forms.Button buttonNext1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textTitle;
        
    }
}