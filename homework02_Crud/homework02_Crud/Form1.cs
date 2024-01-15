using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace homework02_Crud
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter = new();

        private DataTable tb;
        public Form1()
        {
            InitializeComponent();

            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appSettings.json");
            var config = builder.Build();

            var connString = config.GetConnectionString("Default");
            conn = new SqlConnection(connString);
            conn.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using SqlCommand cmd = new("select [name] from sys.tables", conn);
            using SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                DataTablesBox.Items.Add(reader["name"]);
            }

        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            tb = new DataTable();
            if (DataTablesBox.SelectedItem != null)
            {
            adapter.SelectCommand = new($"select * from { DataTablesBox.SelectedItem.ToString() }", conn);
            adapter.Fill(tb);
            }

            DataTable.DataSource = tb;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using SqlCommandBuilder builder = new(adapter);
            DataTable table = (DataTable)DataTable.DataSource;
            adapter.Update(table);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DataTable.SelectedRows.Count; i++)
            {
                adapter.DeleteCommand = new($"delete from {DataTablesBox.SelectedItem.ToString()} where Id = {DataTable.SelectedRows[i].Cells[0].Value};", conn);
                adapter.DeleteCommand.ExecuteNonQuery();
                ReadButton.PerformClick();
            }
        }
    }
}
