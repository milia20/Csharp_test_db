using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Drawing.Drawing2D;
using static System.Net.Mime.MediaTypeNames;

namespace Csharp_test_db
{
    public partial class MainForm : Form
    {
        public MainForm()
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

        private void CreateCSV_Click(object sender, EventArgs e)
        {
            try
            {

                // load from db
                conn = new SqlConnection(@"Data Source=WIN10\SQLEXPRESS;Initial Catalog=Test_C; Integrated Security=true");
                conn.Open();
                sql = "SELECT * FROM [Test_C].[dbo].[Workers]";
                var cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());


                StringBuilder sb = new StringBuilder();

                IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                                  Select(column => column.ColumnName);
                sb.AppendLine(string.Join(",", columnNames));

                foreach (DataRow row in dt.Rows)
                {
                    IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                    sb.AppendLine(string.Join(",", fields));
                }
                string userName = Environment.UserName;
                string file_path = @"C:\Users\" + userName + @"\Documents\Workers.csv";
                File.WriteAllText(file_path, sb.ToString());

                sql = "SELECT * FROM [Test_C].[dbo].[Companies]";
                cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = conn;
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());


                sb = new StringBuilder();

                columnNames = dt.Columns.Cast<DataColumn>().
                                                  Select(column => column.ColumnName);
                sb.AppendLine(string.Join(",", columnNames));

                foreach (DataRow row in dt.Rows)
                {
                    IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                    sb.AppendLine(string.Join(",", fields));
                }
                file_path = @"C:\Users\" + userName + @"\Documents\Companies.csv";
                File.WriteAllText(file_path, sb.ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "FAIL!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }

        private void AddCompanyButton_Click(object sender, EventArgs e)
        {
            var CompanyForm = new CompanyForm();
            CompanyForm.Show();
        }

        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            var WorkerForm = new WorkerForm();
            WorkerForm.Show();
        }

        private void UploadCSV_Click(object sender, EventArgs e)
        {

            string Path = "";
            using SqlConnection conn = new SqlConnection(@"Data Source=WIN10\SQLEXPRESS;Initial Catalog=Test_C; Integrated Security=true");
            conn.Open();
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Path = openFile.FileName;
                using (StreamReader reader = new StreamReader(Path))
                {
                    string[] line = reader.ReadLine().Split(',');
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine().Split(',');
                        string[] Pathlist = Path.Split('.')[0].Split('\\');
                        
                        if (Pathlist[Pathlist.Length - 1] == "Workers"){
                            sql = String.Format("INSERT INTO [Test_C].[dbo].{0}(id,MidName,FirstName,LastName,BirthDate,PasSer,PasNumber) VALUES (NEXT VALUE FOR Test.st_id,'{1}','{2}','{3}','{4}','{5}','{6}');",
                                Pathlist[Pathlist.Length - 1], line[1], line[2], line[3], line[4], line[5], line[6]);
                        }
                        else
                        {
                            sql = String.Format("INSERT INTO [Test_C].[dbo].{0}(id,name,inn,ur_adress,fac_adress) VALUES (NEXT VALUE FOR Test.st_id,'{1}','{2}','{3}','{4}');",
                                Pathlist[Pathlist.Length - 1], line[1], line[2], line[3], line[4]);
                        }
                        cmd = new SqlCommand();
                        cmd.CommandText = sql;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Connection = conn;

                        cmd.ExecuteNonQuery();


                    }
                }
                conn.Close();
            }
        }
    }
}
