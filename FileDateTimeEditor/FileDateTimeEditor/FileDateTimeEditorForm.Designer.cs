namespace FileDateTimeEditor
{
    partial class FileDateTimeEditorForm
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
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelFileDate = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonGetFile = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxDateTypes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(97, 21);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(10, 13);
            this.labelFileName.TabIndex = 0;
            this.labelFileName.Text = "-";
            // 
            // labelFileDate
            // 
            this.labelFileDate.AutoSize = true;
            this.labelFileDate.Location = new System.Drawing.Point(152, 57);
            this.labelFileDate.Name = "labelFileDate";
            this.labelFileDate.Size = new System.Drawing.Size(10, 13);
            this.labelFileDate.TabIndex = 1;
            this.labelFileDate.Text = "-";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(312, 137);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonGetFile
            // 
            this.buttonGetFile.Location = new System.Drawing.Point(37, 137);
            this.buttonGetFile.Name = "buttonGetFile";
            this.buttonGetFile.Size = new System.Drawing.Size(75, 23);
            this.buttonGetFile.TabIndex = 4;
            this.buttonGetFile.Text = "Open file";
            this.buttonGetFile.UseVisualStyleBackColor = true;
            this.buttonGetFile.Click += new System.EventHandler(this.buttonGetFile_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(231, 137);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "New date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "New time";
            // 
            // cboxDateTypes
            // 
            this.cboxDateTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDateTypes.FormattingEnabled = true;
            this.cboxDateTypes.Items.AddRange(new object[] {
            "Creation time",
            "Last Acces time",
            "Last Write time"});
            this.cboxDateTypes.Location = new System.Drawing.Point(12, 49);
            this.cboxDateTypes.Name = "cboxDateTypes";
            this.cboxDateTypes.Size = new System.Drawing.Size(121, 21);
            this.cboxDateTypes.TabIndex = 9;
            this.cboxDateTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxDateTypes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "File Name:";
            // 
            // FileDateTimeEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(414, 171);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboxDateTypes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonGetFile);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelFileDate);
            this.Controls.Add(this.labelFileName);
            this.MaximumSize = new System.Drawing.Size(430, 210);
            this.MinimumSize = new System.Drawing.Size(430, 210);
            this.Name = "FileDateTimeEditorForm";
            this.Text = "File DateTime Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelFileDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonGetFile;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxDateTypes;
        private System.Windows.Forms.Label label3;
    }
}

