using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;

namespace homework02_Crud
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlDataAdapter adapter = new();

        DataTable tb = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appSettings.json");
            var config = builder.Build();

            var connString = config.GetConnectionString("Default");
            conn = new SqlConnection(connString);
            conn.Open();

            DataTable.DataSource = tb;
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            tb.Clear();
            adapter.SelectCommand = new("select * from Teachers", conn);
            adapter.Fill(tb);
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var parameters = new[]
            {
                new SqlParameter("@Name", NameTextBox.Text),
                new SqlParameter("@Surname", SurnameTextBox.Text),
                new SqlParameter("@Salary", SalaryTextBox.Text)
            };

            adapter.InsertCommand = new($"insert into Teachers(Name, Salary, Surname) values(@Name, @Salary, @Surname)", conn);
            adapter.InsertCommand.Parameters.AddRange(parameters);

            try
            {
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Wrong data, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var parameters = new[]
{
                new SqlParameter("@Name", NameTextBox.Text),
                new SqlParameter("@Surname", SurnameTextBox.Text),
                new SqlParameter("@Salary", SalaryTextBox.Text)
            };


            adapter.UpdateCommand = new($"update Teachers set Name = @Name, Surname = @Surname, Salary = @Salary where Id = {DataTable.SelectedRows[0].Cells[0].Value};", conn);
            adapter.UpdateCommand.Parameters.AddRange(parameters);

            try
            {
                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Wrong data, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            adapter.DeleteCommand = new($"delete from Teachers where Id = {DataTable.SelectedRows[0].Cells[0].Value};", conn);

            adapter.DeleteCommand.ExecuteNonQuery();
        }
    }
}
