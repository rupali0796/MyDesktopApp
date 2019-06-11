using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            DataShow();
        }

        public void DataShow()
        {
            using (con = new SqlConnection(cs))
            {
                string command = "select * from [dbo].[Addmission]";
                using (cmd = new SqlCommand(command, con))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                string cmdText = "insert into Addmission(FirstName,LastName,Address,Country,PinCode) values (@FirstName,@LastName,@Address,@Country,@PinCode);";
                using (cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@Country", txtCountry.Text.Trim());
                    cmd.Parameters.AddWithValue("@PinCode", Convert.ToInt32(txtPinCode.Text));

                    con.Open();
                    int response = cmd.ExecuteNonQuery();
                    con.Close();

                    if (response > 0)
                    {
                        MessageBox.Show("Data Inserted.");
                        DataShow();
                    }
                }
            }
        }
    }
}
