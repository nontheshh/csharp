using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using BookStore.Models;
using Dapper;

namespace BookStore
{
    public partial class MainForm : Form
    {
        public DB Db { get; set; }
        SqlConnection conn;
        string sqlString;

        public MainForm()
        {
            InitializeComponent();
            cBoxSearch.SelectedIndex = 0;
        }

        Book fillBookSet(Book book, Author author, PublishingHouse ph, Theme theme, Seria seria)
        {
            Book oBook = Db.BookSet.FirstOrDefault((bk) => bk.Id == book.Id);
            if (oBook == null)
            {
                Author oAuthor = Db.AuthorSet.FirstOrDefault((ath) => ath.Id == author.Id);
                if (oAuthor == null)
                {
                    Db.AuthorSet.Add(author);
                    book.Author.Add(Db.AuthorSet.ElementAt(Db.AuthorSet.Count - 1));
                }
                else book.Author.Add(oAuthor);

                PublishingHouse oPublishingHouse = Db.PublishingHouseSet.FirstOrDefault((nph) => nph.Id == ph.Id);
                if (oPublishingHouse == null)
                {
                    Db.PublishingHouseSet.Add(ph);
                    book.PublishingHouse = Db.PublishingHouseSet.ElementAt(Db.PublishingHouseSet.Count - 1);
                }
                else book.PublishingHouse = oPublishingHouse;

                Theme oTheme = Db.ThemeSet.FirstOrDefault((nt) => nt.Id == theme.Id);
                if (oTheme == null)
                {
                    Db.ThemeSet.Add(theme);
                    book.Theme = Db.ThemeSet.ElementAt(Db.ThemeSet.Count - 1);
                }
                else book.Theme = oTheme;

                Seria oSeria = Db.SeriaSet.FirstOrDefault((ser) => ser.Id == seria.Id);
                if (oSeria == null)
                {
                    Db.SeriaSet.Add(seria);
                    book.Part = seria.Part;
                    book.Seria = Db.SeriaSet.ElementAt(Db.SeriaSet.Count - 1);
                }
                else
                {
                    book.Seria = oSeria;
                    book.Part = seria.Part;
                }
                Db.BookSet.Add(book);
                return (Db.BookSet.ElementAt(Db.BookSet.Count - 1));
            }
            else
            {
                Author oAuthor = Db.AuthorSet.FirstOrDefault((ath) => ath.Id == author.Id);
                if (oAuthor == null)
                {
                    Db.AuthorSet.Add(author);
                    oBook.Author.Add(Db.AuthorSet.ElementAt(Db.AuthorSet.Count - 1));
                }
                else
                {
                    Author check = oBook.Author.FirstOrDefault((ath) => ath.Id == oAuthor.Id);
                    if (check == null) oBook.Author.Add(oAuthor);
                }
                return oBook;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBooks.SelectedIndex == -1) return;

            listStorage.ClearSelected();
            var item = listBooks.SelectedItem as Book;
            showBookInfo(item);
        }

        void showBookInfo(Book book)
        {
            listAuthors.Items.Clear();
            foreach (Author auth in book.Author)
                listAuthors.Items.Add(auth);

            textPublisingHouse.Text = book.PublishingHouse.Name;
            textTheme.Text = book.Theme.Name;
            textSaleCost.Text = book.SaleCost.ToString();
            textPrimeCost.Text = book.PrimeCost.ToString();
            textPageCount.Text = book.PageCount.ToString();
            if (book.Seria == null)
            {
                textSeria.Text = "-";
                textPart.Text = "-";
            }
            else
            {
                textSeria.Text = book.Seria.Name;
                textPart.Text = book.Part.ToString();
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            AddingBookForm f2 = new AddingBookForm(sqlString);
            f2.ShowDialog();
            refleshBookSet();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            if (listStorage.SelectedIndex == -1) return;
            StorageBook storageBook = listStorage.SelectedItem as StorageBook;
            SellingOrderingForm f3 = new SellingOrderingForm(storageBook, ToGetBook.buy, sqlString);
            f3.ShowDialog();
            listStorage.Items[listStorage.SelectedIndex] = storageBook;
        }

        private void buttonSearchBook_Click(object sender, EventArgs e)
        {

            listBooks.Items.Clear();
            IEnumerable<Book> books = null;
            switch (cBoxSearch.SelectedIndex)
            {
                case 0:
                    books = from book in Db.BookSet
                            where book.Title.Contains(textSearch.Text)
                            select book;
                    break;

                case 1:
                    List<Book> bookss = new List<Book>();
                    foreach (var el in Db.BookSet)
                    {
                        foreach (var aut in el.Author)
                        {
                            if (aut.FirstName.Contains(textSearch.Text) ||
                                aut.LastName.Contains(textSearch.Text) ||
                                aut.MiddleName.Contains(textSearch.Text))
                            {
                                bookss.Add(el);
                            }
                        }
                    }
                    books = bookss;
                    break;

                case 2:
                    books = from book in Db.BookSet
                            where book.Theme.Name.Contains(textSearch.Text)
                            select book;
                    break;

            }
            foreach (var el in books)
                listBooks.Items.Add(el);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SignInForm f5 = new SignInForm();
            if (f5.ShowDialog() == DialogResult.Cancel)
            {
                Close();
                return;
            }

            sqlString = f5.sqlString;
            conn = new SqlConnection(
              sqlString);

            Db = new DB();
            refleshBookSet();
            refleshStorage();
        }

        Book fillBookSet(Book book, Author author, PublishingHouse ph, Theme theme)
        {
            Book oBook = Db.BookSet.FirstOrDefault((bk) => bk.Id == book.Id);
            if (oBook == null)
            {
                Author oAuthor = Db.AuthorSet.FirstOrDefault((ath) => ath.Id == author.Id);
                if (oAuthor == null)
                {
                    Db.AuthorSet.Add(author);
                    book.Author.Add(Db.AuthorSet.ElementAt(Db.AuthorSet.Count - 1));
                }
                else book.Author.Add(oAuthor);

                PublishingHouse oPublishingHouse = Db.PublishingHouseSet.FirstOrDefault((nph) => nph.Id == ph.Id);
                if (oPublishingHouse == null)
                {
                    Db.PublishingHouseSet.Add(ph);
                    book.PublishingHouse = Db.PublishingHouseSet.ElementAt(Db.PublishingHouseSet.Count - 1);
                }
                else book.PublishingHouse = oPublishingHouse;

                Theme oTheme = Db.ThemeSet.FirstOrDefault((nt) => nt.Id == theme.Id);
                if (oTheme == null)
                {
                    Db.ThemeSet.Add(theme);
                    book.Theme = Db.ThemeSet.ElementAt(Db.ThemeSet.Count - 1);
                }
                else book.Theme = oTheme;

                Db.BookSet.Add(book);
                return (Db.BookSet.ElementAt(Db.BookSet.Count - 1));
            }
            else
            {
                Author oAuthor = Db.AuthorSet.FirstOrDefault((ath) => ath.Id == author.Id);
                if (oAuthor == null)
                {
                    Db.AuthorSet.Add(author);
                    oBook.Author.Add(Db.AuthorSet.ElementAt(Db.AuthorSet.Count - 1));
                }
                else
                {
                    Author check = oBook.Author.FirstOrDefault((ath) => ath.Id == oAuthor.Id);
                    if (check == null) oBook.Author.Add(oAuthor);
                }
                return oBook;
            }
        }

        private void buttonWriteOffBook_Click(object sender, EventArgs e)
        {
            if (listBooks.SelectedIndex == -1) return;
            Book book = listBooks.SelectedItem as Book;

            var res = conn.ExecuteScalar(@"insert into [WrittenOffBookSet] values (
                         @title, @publishingHouseId, 
                         @pageCount, @themeId, @publishDate, @price); select @@identity",
                          new
                          {
                              title = book.Title,
                              publishingHouseId = book.PublishingHouse.Id,
                              pageCount = book.PageCount,
                              themeId = book.Theme.Id,
                              publishDate = book.PublishDate,
                              price = book.PrimeCost
                          });
            int id = Convert.ToInt32(res);

            foreach (Author el in book.Author)
            {
                conn.Execute(@"insert into [WrittenOffBookAuthorSet] values (
                             @writtenOffBookId, @authorId)",
                    new { writtenOffBookId = id, authorId = el.Id });
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            listBooks.Items.Clear();
            foreach (var el in Db.BookSet)
                listBooks.Items.Add(el);
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (listStorage.SelectedIndex == -1) return;
            StorageBook storageBook = listStorage.SelectedItem as StorageBook;
            SellingOrderingForm f3 = new SellingOrderingForm(storageBook, ToGetBook.order, sqlString);
            f3.ShowDialog();
            listStorage.Items[listStorage.SelectedIndex] = storageBook;
        }

        private void buttonToStorage_Click(object sender, EventArgs e)
        {
            if (listBooks.SelectedIndex == -1) return;
            Book item = listBooks.SelectedItem as Book;
            conn.Execute("insert into [Storage] values (@bookId, @quantity)",
                new { bookId = item.Id, quantity = 100 });
            listStorage.Items.Add(new StorageBook { Book = item, Quantity = 100 });
        }

        void refleshBookSet()
        {
            listBooks.Items.Clear();
            conn.Query<Book, Author, PublishingHouse, Theme, Seria, Book>(
                   @"select * from [BookSet]
                             join [BookAuthorSet] on [BookAuthorSet].[BookId] = [BookSet].[Id]
                             join [AuthorSet] on [AuthorSet].[Id] = [BookAuthorSet].[AuthorId]
                             join [PublishingHouseSet] on [PublishingHouseSet].[Id] = [BookSet].[PublishingHouseId]
                             join [ThemeSet] on [BookSet].[ThemeId] = [ThemeSet].[Id]
                             join [SeriaBookSet] on [BookSet].[Id] = [SeriaBookSet].[BookId]
                             join [SeriaSet] on [SeriaBookSet].[SeriaId] = [SeriaSet].[Id]",
                       fillBookSet, splitOn: "Id, BookId");


            conn.Query<Book, Author, PublishingHouse, Theme, Book>(
                    @"select * from [BookSet]
                             join [BookAuthorSet] on [BookAuthorSet].[BookId] = [BookSet].[Id]
                             join [AuthorSet] on [AuthorSet].[Id] = [BookAuthorSet].[AuthorId]
                             join [PublishingHouseSet] on [PublishingHouseSet].[Id] = [BookSet].[PublishingHouseId]
                             join [ThemeSet] on [BookSet].[ThemeId] = [ThemeSet].[Id]",
                        fillBookSet);

            foreach (Book el in Db.BookSet)
            {
                listBooks.Items.Add(el);
            }
        }

        void refleshStorage()
        {
            listStorage.Items.Clear();
            var res = conn.Query("select * from [Storage]");
            if (res.Count() == 0) return;

            foreach (var el in res)
            {
                Book book =
                Db.BookSet.FirstOrDefault((b) => b.Id == el.BookId);
                if (book != null)
                {
                    listStorage.Items.Add(
                        new StorageBook { Book = book, Quantity = el.Quantity });
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listStorage.SelectedIndex == -1) return;
            StorageBook item = listStorage.SelectedItem as StorageBook;

            conn.Execute("delete [Storage] where [BookId] = @id",
                new { id = item.Book.Id });

            listStorage.Items.RemoveAt(listStorage.SelectedIndex);
        }

        private void listStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listStorage.SelectedIndex == -1) return;
            listBooks.ClearSelected();
            Book item = (listStorage.SelectedItem as StorageBook).Book;
            showBookInfo(item);
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm f4 = new StatisticsForm(sqlString);
            f4.ShowDialog();
        }
    }

    public enum ToGetBook { buy, order }
}