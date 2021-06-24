namespace DbManagerEntityFramework
{
    partial class DbManagerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.employeesDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFirstNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeMiddleNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDepartmentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBirthDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeAboutYourselfColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDepartmentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectedEmployeeLabel = new System.Windows.Forms.Label();
            this.editEmployeeButton = new System.Windows.Forms.Button();
            this.aboutYourselfLabel = new System.Windows.Forms.Label();
            this.aboutYourselfTextBox = new System.Windows.Forms.TextBox();
            this.removeEmployeeButton = new System.Windows.Forms.Button();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressLabel = new System.Windows.Forms.Label();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.departmentsDataGridView = new System.Windows.Forms.DataGridView();
            this.departmentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.selectedDepartmentLabel = new System.Windows.Forms.Label();
            this.editDepartmentButton = new System.Windows.Forms.Button();
            this.removeDepartmentButton = new System.Windows.Forms.Button();
            this.addDepartmentButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillToolStripMenuItem,
            this.noneToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.viewToolStripMenuItem.Text = "Вид";
            // 
            // fillToolStripMenuItem
            // 
            this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
            this.fillToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.fillToolStripMenuItem.Text = "Заполнить";
            this.fillToolStripMenuItem.Click += new System.EventHandler(this.ViewFillToolStripMenuItem_Click);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.noneToolStripMenuItem.Text = "Стандартный";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.ViewNoneToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 495);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.employeesDataGridView);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сотрудники";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // employeesDataGridView
            // 
            this.employeesDataGridView.AllowUserToAddRows = false;
            this.employeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIdColumn,
            this.employeeFirstNameColumn,
            this.employeeLastNameColumn,
            this.employeeMiddleNameColumn,
            this.employeeDepartmentColumn,
            this.employeeAddressColumn,
            this.employeeBirthDateColumn,
            this.employeeAboutYourselfColumn,
            this.employeeDepartmentIdColumn});
            this.employeesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesDataGridView.Location = new System.Drawing.Point(256, 3);
            this.employeesDataGridView.Name = "employeesDataGridView";
            this.employeesDataGridView.Size = new System.Drawing.Size(533, 463);
            this.employeesDataGridView.TabIndex = 20;
            this.employeesDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EmployeesDataGridView_CellMouseClick);
            // 
            // employeeIdColumn
            // 
            this.employeeIdColumn.DataPropertyName = "Id";
            this.employeeIdColumn.HeaderText = "Id";
            this.employeeIdColumn.Name = "employeeIdColumn";
            this.employeeIdColumn.ReadOnly = true;
            // 
            // employeeFirstNameColumn
            // 
            this.employeeFirstNameColumn.DataPropertyName = "FirstName";
            this.employeeFirstNameColumn.HeaderText = "Имя";
            this.employeeFirstNameColumn.Name = "employeeFirstNameColumn";
            this.employeeFirstNameColumn.ReadOnly = true;
            // 
            // employeeLastNameColumn
            // 
            this.employeeLastNameColumn.DataPropertyName = "LastName";
            this.employeeLastNameColumn.HeaderText = "Фамилия";
            this.employeeLastNameColumn.Name = "employeeLastNameColumn";
            this.employeeLastNameColumn.ReadOnly = true;
            // 
            // employeeMiddleNameColumn
            // 
            this.employeeMiddleNameColumn.DataPropertyName = "MiddleName";
            this.employeeMiddleNameColumn.HeaderText = "Отчество";
            this.employeeMiddleNameColumn.Name = "employeeMiddleNameColumn";
            this.employeeMiddleNameColumn.ReadOnly = true;
            // 
            // employeeDepartmentColumn
            // 
            this.employeeDepartmentColumn.DataPropertyName = "Department";
            this.employeeDepartmentColumn.HeaderText = "Отдел";
            this.employeeDepartmentColumn.Name = "employeeDepartmentColumn";
            this.employeeDepartmentColumn.ReadOnly = true;
            // 
            // employeeAddressColumn
            // 
            this.employeeAddressColumn.DataPropertyName = "Address";
            this.employeeAddressColumn.HeaderText = "Адрес";
            this.employeeAddressColumn.Name = "employeeAddressColumn";
            this.employeeAddressColumn.ReadOnly = true;
            // 
            // employeeBirthDateColumn
            // 
            this.employeeBirthDateColumn.DataPropertyName = "BirthDate";
            this.employeeBirthDateColumn.HeaderText = "Дата рождения";
            this.employeeBirthDateColumn.Name = "employeeBirthDateColumn";
            this.employeeBirthDateColumn.ReadOnly = true;
            // 
            // employeeAboutYourselfColumn
            // 
            this.employeeAboutYourselfColumn.DataPropertyName = "AboutYourself";
            this.employeeAboutYourselfColumn.HeaderText = "О себе";
            this.employeeAboutYourselfColumn.Name = "employeeAboutYourselfColumn";
            this.employeeAboutYourselfColumn.ReadOnly = true;
            // 
            // employeeDepartmentIdColumn
            // 
            this.employeeDepartmentIdColumn.DataPropertyName = "DepartmentId";
            this.employeeDepartmentIdColumn.HeaderText = "Id отдела";
            this.employeeDepartmentIdColumn.Name = "employeeDepartmentIdColumn";
            this.employeeDepartmentIdColumn.ReadOnly = true;
            this.employeeDepartmentIdColumn.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectedEmployeeLabel);
            this.panel1.Controls.Add(this.editEmployeeButton);
            this.panel1.Controls.Add(this.aboutYourselfLabel);
            this.panel1.Controls.Add(this.aboutYourselfTextBox);
            this.panel1.Controls.Add(this.removeEmployeeButton);
            this.panel1.Controls.Add(this.addEmployeeButton);
            this.panel1.Controls.Add(this.departmentLabel);
            this.panel1.Controls.Add(this.departmentComboBox);
            this.panel1.Controls.Add(this.birthDateLabel);
            this.panel1.Controls.Add(this.birthDateDateTimePicker);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.middleNameLabel);
            this.panel1.Controls.Add(this.lastNameLabel);
            this.panel1.Controls.Add(this.firstNameLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(this.middleNameTextBox);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 463);
            this.panel1.TabIndex = 5;
            // 
            // selectedEmployeeLabel
            // 
            this.selectedEmployeeLabel.AutoSize = true;
            this.selectedEmployeeLabel.Location = new System.Drawing.Point(12, 384);
            this.selectedEmployeeLabel.Name = "selectedEmployeeLabel";
            this.selectedEmployeeLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedEmployeeLabel.TabIndex = 21;
            // 
            // editEmployeeButton
            // 
            this.editEmployeeButton.Location = new System.Drawing.Point(5, 425);
            this.editEmployeeButton.Name = "editEmployeeButton";
            this.editEmployeeButton.Size = new System.Drawing.Size(244, 23);
            this.editEmployeeButton.TabIndex = 20;
            this.editEmployeeButton.Text = "Изменить выбранного сотрудника";
            this.editEmployeeButton.UseVisualStyleBackColor = true;
            this.editEmployeeButton.Click += new System.EventHandler(this.EditEmployeeButton_Click);
            // 
            // aboutYourselfLabel
            // 
            this.aboutYourselfLabel.AutoSize = true;
            this.aboutYourselfLabel.Location = new System.Drawing.Point(12, 286);
            this.aboutYourselfLabel.Name = "aboutYourselfLabel";
            this.aboutYourselfLabel.Size = new System.Drawing.Size(42, 13);
            this.aboutYourselfLabel.TabIndex = 19;
            this.aboutYourselfLabel.Text = "О себе";
            // 
            // aboutYourselfTextBox
            // 
            this.aboutYourselfTextBox.Location = new System.Drawing.Point(3, 302);
            this.aboutYourselfTextBox.Multiline = true;
            this.aboutYourselfTextBox.Name = "aboutYourselfTextBox";
            this.aboutYourselfTextBox.Size = new System.Drawing.Size(244, 45);
            this.aboutYourselfTextBox.TabIndex = 18;
            // 
            // removeEmployeeButton
            // 
            this.removeEmployeeButton.Location = new System.Drawing.Point(5, 400);
            this.removeEmployeeButton.Name = "removeEmployeeButton";
            this.removeEmployeeButton.Size = new System.Drawing.Size(244, 23);
            this.removeEmployeeButton.TabIndex = 17;
            this.removeEmployeeButton.Text = "Удалить выбранного сотрудника";
            this.removeEmployeeButton.UseVisualStyleBackColor = true;
            this.removeEmployeeButton.Click += new System.EventHandler(this.RemoveEmployeeButton_Click);
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(27, 353);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(202, 23);
            this.addEmployeeButton.TabIndex = 16;
            this.addEmployeeButton.Text = "Добавить сотрудника";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Location = new System.Drawing.Point(12, 236);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(38, 13);
            this.departmentLabel.TabIndex = 15;
            this.departmentLabel.Text = "Отдел";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(3, 252);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(244, 21);
            this.departmentComboBox.TabIndex = 14;
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(12, 187);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(86, 13);
            this.birthDateLabel.TabIndex = 13;
            this.birthDateLabel.Text = "Дата рождения";
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(6, 203);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(244, 20);
            this.birthDateDateTimePicker.TabIndex = 12;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 148);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(38, 13);
            this.addressLabel.TabIndex = 11;
            this.addressLabel.Text = "Адрес";
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(12, 105);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(54, 13);
            this.middleNameLabel.TabIndex = 10;
            this.middleNameLabel.Text = "Отчество";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 57);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Фамилия";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 8);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.firstNameLabel.TabIndex = 8;
            this.firstNameLabel.Text = "Имя";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(3, 164);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(244, 20);
            this.addressTextBox.TabIndex = 6;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Location = new System.Drawing.Point(3, 121);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(244, 20);
            this.middleNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(3, 73);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(244, 20);
            this.lastNameTextBox.TabIndex = 4;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(3, 24);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(244, 20);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.departmentsDataGridView);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Отделы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // departmentsDataGridView
            // 
            this.departmentsDataGridView.AllowUserToAddRows = false;
            this.departmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentIdColumn,
            this.Employees,
            this.departmentNameColumn});
            this.departmentsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentsDataGridView.Location = new System.Drawing.Point(256, 3);
            this.departmentsDataGridView.Name = "departmentsDataGridView";
            this.departmentsDataGridView.ReadOnly = true;
            this.departmentsDataGridView.Size = new System.Drawing.Size(533, 463);
            this.departmentsDataGridView.TabIndex = 21;
            this.departmentsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DepartmentsDataGridView_CellMouseClick);
            // 
            // departmentIdColumn
            // 
            this.departmentIdColumn.DataPropertyName = "Id";
            this.departmentIdColumn.HeaderText = "Id";
            this.departmentIdColumn.Name = "departmentIdColumn";
            this.departmentIdColumn.ReadOnly = true;
            // 
            // Employees
            // 
            this.Employees.DataPropertyName = "Employees";
            this.Employees.HeaderText = "";
            this.Employees.Name = "Employees";
            this.Employees.ReadOnly = true;
            this.Employees.Visible = false;
            // 
            // departmentNameColumn
            // 
            this.departmentNameColumn.DataPropertyName = "Name";
            this.departmentNameColumn.HeaderText = "Название";
            this.departmentNameColumn.Name = "departmentNameColumn";
            this.departmentNameColumn.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.selectedDepartmentLabel);
            this.panel2.Controls.Add(this.editDepartmentButton);
            this.panel2.Controls.Add(this.removeDepartmentButton);
            this.panel2.Controls.Add(this.addDepartmentButton);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.departmentNameTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 463);
            this.panel2.TabIndex = 6;
            // 
            // selectedDepartmentLabel
            // 
            this.selectedDepartmentLabel.AutoSize = true;
            this.selectedDepartmentLabel.Location = new System.Drawing.Point(12, 94);
            this.selectedDepartmentLabel.Name = "selectedDepartmentLabel";
            this.selectedDepartmentLabel.Size = new System.Drawing.Size(98, 13);
            this.selectedDepartmentLabel.TabIndex = 20;
            this.selectedDepartmentLabel.Text = "Выбранный отдел";
            // 
            // editDepartmentButton
            // 
            this.editDepartmentButton.Location = new System.Drawing.Point(15, 110);
            this.editDepartmentButton.Name = "editDepartmentButton";
            this.editDepartmentButton.Size = new System.Drawing.Size(219, 23);
            this.editDepartmentButton.TabIndex = 19;
            this.editDepartmentButton.Text = "Изменить выбранный отдел";
            this.editDepartmentButton.UseVisualStyleBackColor = true;
            this.editDepartmentButton.Click += new System.EventHandler(this.EditDepartmentButton_Click);
            // 
            // removeDepartmentButton
            // 
            this.removeDepartmentButton.Location = new System.Drawing.Point(15, 139);
            this.removeDepartmentButton.Name = "removeDepartmentButton";
            this.removeDepartmentButton.Size = new System.Drawing.Size(219, 23);
            this.removeDepartmentButton.TabIndex = 18;
            this.removeDepartmentButton.Text = "Удалить выбранный отдел";
            this.removeDepartmentButton.UseVisualStyleBackColor = true;
            this.removeDepartmentButton.Click += new System.EventHandler(this.RemoveDepartmentButton_Click);
            // 
            // addDepartmentButton
            // 
            this.addDepartmentButton.Location = new System.Drawing.Point(15, 59);
            this.addDepartmentButton.Name = "addDepartmentButton";
            this.addDepartmentButton.Size = new System.Drawing.Size(219, 23);
            this.addDepartmentButton.TabIndex = 16;
            this.addDepartmentButton.Text = "Добавить отдел";
            this.addDepartmentButton.UseVisualStyleBackColor = true;
            this.addDepartmentButton.Click += new System.EventHandler(this.AddDepartmentButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Название";
            // 
            // departmentNameTextBox
            // 
            this.departmentNameTextBox.Location = new System.Drawing.Point(3, 24);
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(244, 20);
            this.departmentNameTextBox.TabIndex = 3;
            // 
            // DbManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 558);
            this.Name = "DbManagerForm";
            this.Text = "DbManager";
            this.Load += new System.EventHandler(this.DbManagerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView employeesDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label aboutYourselfLabel;
        private System.Windows.Forms.TextBox aboutYourselfTextBox;
        private System.Windows.Forms.Button removeEmployeeButton;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView departmentsDataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addDepartmentButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox departmentNameTextBox;
        private System.Windows.Forms.Button removeDepartmentButton;
        private System.Windows.Forms.Button editEmployeeButton;
        private System.Windows.Forms.Button editDepartmentButton;
        private System.Windows.Forms.Label selectedEmployeeLabel;
        private System.Windows.Forms.Label selectedDepartmentLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirstNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeMiddleNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDepartmentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeAddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeBirthDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeAboutYourselfColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeDepartmentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employees;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameColumn;
    }
}

