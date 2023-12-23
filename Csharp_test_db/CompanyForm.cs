using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_test_db
{
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
        }

        private SqlConnection conn;
        string connstring = String.Format("Server={0};Port={1};" +
            "User ID={2};Password={3};Database={4};",
            "localhost", "5432", "postgres",
            "A32t57", "Test_C");
        private DataTable dt;
        private SqlCommand cmd;

        private string sql = null;


        private void LoadDataGrid()
        {
            try
            {
                 
                sql = String.Format("SELECT * FROM [Test_C].[dbo].[Companies]");
                conn.Open();
                var cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;

                //cmd.ExecuteNonQuery();
                dgvData.DataSource = null;
                // load from db

                //sql = "SELECT * FROM Companies";
                //cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvData.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            //conn = new NpgsqlConnection(connstring);
            conn = new SqlConnection(@"Data Source=WIN10\SQLEXPRESS;Initial Catalog=Test_C; Integrated Security=true");
            LoadData.PerformClick();//start whis data when open
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                dgvData.DataSource = null;
                // insert into db
                conn.Open();
                sql = String.Format("INSERT INTO [Test_C].[dbo].Companies(id, Name,inn,ur_adress,fac_adress) VALUES (NEXT VALUE FOR Test.st_id,'{0}','{1}','{2}','{3}');",
                        NameBox.Text, INNBox.Text, URBox.Text, FACBox.Text);

                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;
                cmd.ExecuteReader();
                conn.Close();
                LoadDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {

        }
    }
}
