using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using BookStore.Models;
using Dapper;

namespace BookStore
{
    public partial class SellingOrderingForm : Form
    {
        ToGetBook mode;
        SqlConnection conn;
        int selectedCustomerId = -1;
        StorageBook storageBook;
        public SellingOrderingForm(StorageBook book, ToGetBook mode, string sqlString)
        {
            InitializeComponent();

            conn = new SqlConnection(sqlString);
            this.storageBook = book;
            if (mode == ToGetBook.order) buttonSell.Text = "Order";
            if (mode == ToGetBook.buy) buttonSell.Text = "Sell";
            this.mode = mode;
        }

        void createCustomer()
        {
            var res = conn.ExecuteScalar(@"insert into [CustomerSet] values 
                                (@firstName, @lastName, @middleName); select @@identity",
                   new
                   {
                       firstName = textFirstName.Text,
                       lastName = textLastName.Text,
                       middleName = textMiddleName.Text
                   }
                  );
            selectedCustomerId = Convert.ToInt32(res);
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
                createCustomer();

            if (mode == ToGetBook.buy)
            {
                conn.Execute(@"insert into [SaleSet] values (
                         @bookId, @customerId, @price, @saleDate)",
                                new
                                {
                                    bookId = storageBook.Book.Id,
                                    customerId = selectedCustomerId,
                                    price = storageBook.Book.SaleCost,
                                    saleDate = DateTime.Now
                                });
            }
            if (mode == ToGetBook.order)
            {
                conn.Execute("insert into [OrderSet] values (@customerId, @bookId)",
                    new { customerId = selectedCustomerId, bookId = storageBook.Book.Id });
            }
            conn.Execute(@"update [Storage] 
                        set [Quantity] = [Quantity] - 1 
                        where [BookId] = @id",
                        new { id = storageBook.Book.Id });
            storageBook.Quantity--;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
           var res = conn.Query<Customer>(@"select * from [CustomerSet] where 
                [FirstName] like @firstName and 
                [LastName] like @lastName and
                [MiddleName] like @middleName",
                new
                {
                    firstName = $"%{textFirstName.Text}%",
                    lastName = $"%{textLastName.Text}%",
                    middleName = $"%{textMiddleName.Text}%"
                }
                );

            foreach (Customer el in res)
                listCustomer.Items.Add(el);
        }

        private void listCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCustomer.SelectedIndex == -1) return;
            selectedCustomerId = (listCustomer.SelectedItem as Customer).Id;
        }

        private void anyTextBox_TextChanged(object sender, EventArgs e)
        {
            listCustomer.ClearSelected();
            selectedCustomerId = -1;
        }
    }
}