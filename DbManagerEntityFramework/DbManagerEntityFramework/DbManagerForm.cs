using System;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;
using System.ComponentModel;
using DbManagerEntityFramework.Models;

namespace DbManagerEntityFramework
{
    public partial class DbManagerForm : Form
    {
        private readonly AppDbContext _context;

        public DbManagerForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        #region form
        private void DbManagerForm_Load(object sender, EventArgs e)
        {
            // ловим ошибку на случай отсуствии базы данных
            try
            {
                // привязываем данные с базы даннх к элементам
                BindEmploeyees();
                BindDepartments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.InnerException);
                Close();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _context.Dispose();
        }
        #endregion

        #region bindings
        private void BindEmploeyees()
        {
            _context.Employees.Load();
            employeesDataGridView.DataSource = _context.Employees.Local.ToBindingList();
        }

        private void BindDepartments()
        {
            _context.Departments.Load();
            departmentComboBox.DataSource = _context.Departments.Local.ToBindingList();
            departmentsDataGridView.DataSource = _context.Departments.Local.ToBindingList();
        }
        #endregion

        #region employee
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            var employee = new Employee();

            // заполняем поля объекта введенной пользователем данными
            if (FillEmployee(employee))
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                ClearEmployeeFields();
            }
        }

        private void RemoveEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.SelectedCells.Count <= 0)
            {
                return;
            }

            // получаем id выбранного сотрудника
            var rowIndex = employeesDataGridView.SelectedCells[0].RowIndex;
            var row = employeesDataGridView.Rows[rowIndex];

            var dialogResult = AskSureWantToRemove("сотрудника", row.Cells["employeeIdColumn"].Value.ToString());

            if (dialogResult == DialogResult.Yes)
            {
                // удаляем из таблицы и из базы данных
                employeesDataGridView.Rows.Remove(row);
                _context.SaveChanges();
            }
        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.SelectedCells.Count == 0)
            {
                return;
            }

            // получаем id выбранного сотрудника
            int rowIndex = employeesDataGridView.SelectedCells[0].RowIndex;

            var row = employeesDataGridView.Rows[rowIndex];
            int id = (int)row.Cells["employeeIdColumn"].Value;

            // уточняем у пользователя сотрудника
            var dialogResult = AskSureWantToEdit("сотрудника", id.ToString());

            if (dialogResult == DialogResult.Yes)
            {
                var employee = _context.Employees.Find(id);


                if (FillEmployee(employee))
                {
                    _context.Entry(employee).State = EntityState.Modified;
                    _context.SaveChanges();

                    // обновляем строку в таблице
                    employeesDataGridView.InvalidateRow(rowIndex);
                }
            }
        }

        private void EmployeesDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            // выводим id сотрудника из выбранной строки в таблице
            var row = employeesDataGridView.Rows[e.RowIndex];
            selectedEmployeeLabel.Text = "Выбранный id - " + row.Cells["employeeIdColumn"].Value.ToString();

            // заполняем элементы управления данными о сотруднике
            firstNameTextBox.Text = row.Cells["employeeFirstNameColumn"].Value.ToString();
            lastNameTextBox.Text = row.Cells["employeeLastNameColumn"].Value.ToString();
            middleNameTextBox.Text = row.Cells["employeeMiddleNameColumn"].Value.ToString();
            aboutYourselfTextBox.Text = row.Cells["employeeAboutYourselfColumn"].Value.ToString();
            addressTextBox.Text = row.Cells["employeeAddressColumn"].Value.ToString();
            birthDateDateTimePicker.Value = (DateTime)row.Cells["employeeBirthDateColumn"].Value;
            departmentComboBox.Text = row.Cells["employeeDepartmentColumn"].Value.ToString();
        }

        private bool FillEmployee(Employee employee)
        {
            var department = _context.Departments.FirstOrDefault(d => d.Name == departmentComboBox.Text);

            if (department == null)
            {
                ShowErrorDepartmentIsNotSelected();
                return false;
            }

            employee.FirstName = firstNameTextBox.Text;
            employee.LastName = lastNameTextBox.Text;
            employee.MiddleName = middleNameTextBox.Text;
            employee.Address = addressTextBox.Text;
            employee.BirthDate = birthDateDateTimePicker.Value.Date;
            employee.Department = department;
            employee.AboutYourself = aboutYourselfTextBox.Text;

            return true;
        }

        private void ClearEmployeeFields()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            middleNameTextBox.Text = "";
            addressTextBox.Text = "";
            aboutYourselfTextBox.Text = "";
        }
        #endregion

        #region department

        private void AddDepartmentButton_Click(object sender, EventArgs e)
        {
            // проверяем существования отдела с таким названием
            if (_context.Departments.FirstOrDefault(d => d.Name == departmentNameTextBox.Text) != null)
            {
                ShowErrorDepartmentExists();
                return;
            }

            // сохраняем
            var department = new Department { Name = departmentNameTextBox.Text };
            _context.Departments.Add(department);
            _context.SaveChanges();

            departmentNameTextBox.Text = "";
        }

        private void RemoveDepartmentButton_Click(object sender, EventArgs e)
        {
            if (departmentsDataGridView.SelectedCells.Count <= 0)
            {
                return;
            }

            // получаем выбранную строку в таблице
            int rowIndex = departmentsDataGridView.SelectedCells[0].RowIndex;
            var row = departmentsDataGridView.Rows[rowIndex];

            // уточняем у пользователя отдел
            var dialogResult = AskSureWantToRemove("отдел", row.Cells["departmentIdColumn"].Value.ToString());

            if (dialogResult == DialogResult.Yes)
            {
                departmentsDataGridView.Rows.Remove(row);
                _context.SaveChanges();
            }
        }

        private void EditDepartmentButton_Click(object sender, EventArgs e)
        {
            if (departmentsDataGridView.SelectedCells.Count == 0)
            {
                return;
            }

            // проверяем существования отдела с таким названием
            if (_context.Departments.FirstOrDefault(d => d.Name == departmentNameTextBox.Text) != null)
            {
                ShowErrorDepartmentExists();
                return;
            }

            int rowIndex = departmentsDataGridView.SelectedCells[0].RowIndex;

            var row = departmentsDataGridView.Rows[rowIndex];
            int id = (int)row.Cells["departmentIdColumn"].Value;

            // уточняем у пользователя отдел
            var dialogResult = AskSureWantToEdit("отдел", id.ToString());

            if (dialogResult == DialogResult.Yes)
            {
                var department = _context.Departments.Find(id);
                department.Name = departmentNameTextBox.Text;

                _context.Entry(department).State = EntityState.Modified;
                _context.SaveChanges();

                // обновляем строку в таблице
                departmentsDataGridView.InvalidateRow(rowIndex);
            }
        }

        private void DepartmentsDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            // выводим данные об отделе из выбранной строки в таблице
            var row = departmentsDataGridView.Rows[e.RowIndex];
            selectedDepartmentLabel.Text = "Выбранный id - " + row.Cells["departmentIdColumn"].Value.ToString();

            departmentNameTextBox.Text = row.Cells["departmentNameColumn"].Value.ToString();
        }
        #endregion

        #region toolStripMenu
        private void ViewFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            departmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ViewNoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            departmentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }
        #endregion

        #region errorMessages

        private void ShowErrorDepartmentExists()
        {
            MessageBox.Show("Такой отдел уже существует");
        }

        private void ShowErrorDepartmentIsNotSelected()
        {
            MessageBox.Show("Отдел не выбран");
        }
        #endregion

        #region dialogs
        private DialogResult AskSureWantToRemove(string who, string id)
        {
            return MessageBox.Show(
                $"Вы уверены, что ухотите удалить {who} с id {id}",
                "Удаление",
                MessageBoxButtons.YesNo);
        }

        private DialogResult AskSureWantToEdit(string who, string id)
        {
            return MessageBox.Show(
                $"Вы уверены, что ухотите изменить {who} с id {id}",
                "Изменение",
                MessageBoxButtons.YesNo);
        }
        #endregion
    }
}