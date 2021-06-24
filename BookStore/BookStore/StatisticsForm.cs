using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dapper;

namespace BookStore
{
    public partial class StatisticsForm : Form
    {
        SqlConnection conn;
        DateTime date1;
        DateTime date2;
        public StatisticsForm(string sqlString)
        {
            InitializeComponent();
            conn = new SqlConnection(sqlString);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    date1 = new DateTime(
                        DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    date2 = new DateTime(
                        DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    break;

                case 1:
                    date1 = new DateTime(
                        DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    date2 = new DateTime(
                        DateTime.Now.Year, DateTime.Now.Month - 1, DateTime.Now.Day);
                    break;

                case 2:
                    date1 = new DateTime(
                        DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                    date2 = new DateTime(
                        DateTime.Now.Year - 1, DateTime.Now.Month, DateTime.Now.Day);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    var res1 = conn.Query(@"
                        select [BookSet].[Title], count([SaleSet].[BookId]) as [cnt] 
                        from [SaleSet]
                        join [BookSet] on [BookSet].[Id] = [SaleSet].[BookId]
                        where [SaleDate] between @date2 and @date1
                        group by [SaleSet].[BookId], [BookSet].[Title]
                        order by [cnt] desc", new
                    {
                        date1,
                        date2
                    });
                    foreach (var el in res1)
                        listBox1.Items.Add($"Title: {el.Title}; Count; {el.cnt}");
                    break;

                case 1:
                    var res2 = conn.Query(@"
                     select ([AuthorSet].[FirstName] + ' ' + 
                     [AuthorSet].[MiddleName] + ' ' + 
                     [AuthorSet].[LastName]) as [FullName], 
                     count(SaleSet.BookId) as [cnt] 
                     from [AuthorSet]
                     join [BookAuthorSet] on [BookAuthorSet].[AuthorId] = [AuthorSet].[Id]
			         join [SaleSet] on [SaleSet].[BookId] = [BookAuthorSet].[BookId]
                     where [SaleSet].[SaleDate] between @date2 and @date1
                     group by ([AuthorSet].[FirstName] + ' ' + 
                     [AuthorSet].[MiddleName] + ' ' + [AuthorSet].[LastName])
                     order by [cnt] desc", new { date1, date2 });

                    foreach (var el in res2)
                        listBox1.Items.Add($"Author: {el.FullName}; Count: {el.cnt}");
                    break;

                case 2:
                    var res3 = conn.Query(@"
                        select [ThemeSet].[Name], count([SaleSet].[BookId]) as [cnt] 
                        from [SaleSet]
                        join [BookSet] on [BookSet].[Id] = [SaleSet].[BookId]
						join ThemeSet on ThemeSet.Id = [BookSet].[ThemeId]
                        where [SaleSet].[SaleDate] between @date2 and @date1
                        group by [SaleSet].[BookId], [ThemeSet].[Name]
                        order by [cnt] desc", new { date1, date2 });

                    foreach (var el in res3)
                        listBox1.Items.Add($"Theme: {el.Name}; Count: {el.cnt}");
                    break;
            }
        }
    }
}
