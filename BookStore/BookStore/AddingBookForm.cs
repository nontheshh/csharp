using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using BookStore.Models;
using Dapper;

namespace BookStore
{
    public partial class AddingBookForm : Form
    {
        SqlConnection conn;
        int currentPage = 0;
        int selectedPublishingHouseId = -1;
        int selectedThemeId = -1;
        int selectedSeriaId = -1;
        AuthorSelect authorSelect;


        public AddingBookForm(string sqlString)
        {
            InitializeComponent();

            conn = new SqlConnection(sqlString);
            authorSelect = new AuthorSelect();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            tabControl1.DeselectTab(currentPage++);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(--currentPage);
        }

        void createAuthor(Author author)
        {
            int id;
            try
            {
                var res =
                        conn.ExecuteScalar(@"insert into [AuthorSet] values 
                        (@firstName, @lastName, @middleName); select @@identity;",
                    new
                    {
                        firstName = author.FirstName,
                        lastName = author.LastName,
                        middleName = author.MiddleName
                    });
                id = Convert.ToInt32(res);
                authorSelect.selectedAuthorsId.Add(id);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        void createTheme()
        {
            try
            {
                var res =
                    conn.ExecuteScalar(@"insert into [ThemeSet] values (@name); 
                                    select @@identity;",
                     new { name = textTheme.Text });
                selectedThemeId = Convert.ToInt32(res);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        void createPublishingHouse()
        {
            try
            {
                var res =
                    conn.ExecuteScalar(@"insert into [PublishingHouseSet] values (@name);
                                    select @@identity;",
                    new { name = textPublishingHouse.Text });
                selectedPublishingHouseId = Convert.ToInt32(res);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        void createSeria()
        {
            try
            {
                var res =
                    conn.ExecuteScalar(@"insert into [SeriaSet] values (@name);
                                    select @@identity;",
                    new { name = textSeria.Text });
                selectedSeriaId = Convert.ToInt32(res);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            foreach (Author el in listSelectedAuthors.Items)
            {
                if (el.Id == -1) createAuthor(el);
            }

            if (selectedThemeId == -1)
                createTheme();

            if (selectedPublishingHouseId == -1)
                createPublishingHouse();

            if (selectedSeriaId == -1 && checkIsSeria.Checked)
                createSeria();

            var res = conn.ExecuteScalar(@"insert into [BookSet] values 
                        (@title, @publishingHouseId, 
                         @pageCount, @themeId, @publishDate, 
                         @primeCost, @saleCost); select @@identity;",
                         new
                         {
                             title = textTitle.Text,
                             publishingHouseId = selectedPublishingHouseId,
                             pageCount = numericPageCount.Value,
                             themeId = selectedThemeId,
                             publishDate = dateTimePicker1.Value,
                             primeCost = numericPrimeCost.Value,
                             saleCost = numericSaleCost.Value
                         }
                );

            int createdBookId = Convert.ToInt32(res);

            foreach (int el in authorSelect.selectedAuthorsId)
            {
                conn.Execute("insert into [BookAuthorSet] values (@bookId, @authorId)",
                    new { bookId = createdBookId, authorId = el });
            }

            if (checkIsSeria.Checked)
            {
                bindingBookSeria(createdBookId);
            }
        }

        void bindingBookSeria(int bookId)
        {
            conn.Execute("insert into [SeriaBookSet] values (@bookId, @seriaId, @part)",
                new { bookId, seriaId = selectedSeriaId, part = numericSeriaPart.Value });
        }

        private void listThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listThemes.SelectedIndex == -1) return;
            selectedThemeId =
                (listThemes.SelectedItem as Theme).Id;
        }

        private void listAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAuthors.SelectedIndex == -1) return;
            authorSelect.currentSelectedAuthorId =
                (listAuthors.SelectedItem as Author).Id;
        }

        private void listPublishingHouses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPublishingHouses.SelectedIndex == -1) return;
            selectedPublishingHouseId =
                (listPublishingHouses.SelectedItem as PublishingHouse).Id;
        }

        private void buttonSearchTheme_Click(object sender, EventArgs e)
        {
            var res = conn.Query<Theme>("select * from [ThemeSet] where [Name] like @theme",
                new { theme = $"%{textTheme.Text}%" });

            foreach (Theme el in res)
                listThemes.Items.Add(el);
        }

        private void buttonSearchAuthor_Click(object sender, EventArgs e)
        {
            var res =
                conn.Query<Author>(@"select * from [AuthorSet] where 
                                    [FirstName] like @first and 
                                    [LastName] like @last and 
                                    [MiddleName] like @middle",
                new
                {
                    first = $"%{textFirstName.Text}%",
                    last = $"%{textLastName.Text}%",
                    middle = $"%{textMiddleName.Text}%"
                });

            foreach (Author el in res)
                listAuthors.Items.Add(el);
        }

        private void buttonSearchSeria_Click(object sender, EventArgs e)
        {
            var res =
                conn.Query<Seria>(@"select * from [SeriaSet] where [Name] like @name",
                new { name = $"%{textSeria.Text}%" });

            foreach (Seria el in res)
                listSeria.Items.Add(el);
        }

        private void buttonSearchPublishingHouse_Click(object sender, EventArgs e)
        {
            var res =
                conn.Query<PublishingHouse>(
                    @"select * from [PublishingHouseSet] 
                    where [Name] like @name",
                new { name = $"%{textPublishingHouse.Text}%" });

            foreach (PublishingHouse el in res)
                listPublishingHouses.Items.Add(el);
        }

        private void textTheme_TextChanged(object sender, EventArgs e)
        {
            listThemes.ClearSelected();
            selectedThemeId = -1;
        }

        private void anyTextBoxAuthor_TextChanged(object sender, EventArgs e)
        {
            listAuthors.ClearSelected();
            authorSelect.currentSelectedAuthorId = -1;
        }

        private void textPublishingHouse_TextChanged(object sender, EventArgs e)
        {
            listPublishingHouses.ClearSelected();
            selectedPublishingHouseId = -1;
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            if (authorSelect.currentSelectedAuthorId == -1)
            {
                listSelectedAuthors.Items.Add(new Author
                {
                    Id = -1,
                    FirstName = textFirstName.Text,
                    LastName = textLastName.Text,
                    MiddleName = textMiddleName.Text
                });
            }
            else
            {
                authorSelect.selectedAuthorsId.Add((listAuthors.SelectedItem as Author).Id);
                listSelectedAuthors.Items.Add(listAuthors.SelectedItem);
                authorSelect.currentSelectedAuthorId  = -1;
            }
        }

        private void checkIsSeria_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIsSeria.Checked)
            {
                textSeria.Enabled = true;
                listSeria.Enabled = true;
                labelSeria.Enabled = true;
                numericSeriaPart.Enabled = true;
                buttonSearchSeria.Enabled = true;
            }
            else
            {
                textSeria.Enabled = false;
                listSeria.Enabled = false;
                labelSeria.Enabled = false;
                numericSeriaPart.Value = 0;
                numericSeriaPart.Enabled = false;
                buttonSearchSeria.Enabled = false;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = tabControl1.SelectedIndex;
        }

        private void listSeria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSeria.SelectedIndex == -1) return;
            selectedSeriaId = (listSeria.SelectedItem as Seria).Id;
        }

        private void textSeria_TextChanged(object sender, EventArgs e)
        {
            listSeria.ClearSelected();
            selectedSeriaId = -1;
        }
    }
    class AuthorSelect
    {
        public AuthorSelect()
        {
            currentSelectedAuthorId = 0;
            selectedAuthorsId = new List<int>();
        }

        public int currentSelectedAuthorId { get; set; }
        public List<int> selectedAuthorsId { get; set; }
    }
}