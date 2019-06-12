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
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private string cs = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            DataShow();
        }
       
        public void DataShow()
        {
            using (con = new SqlConnection(cs))
            {
                string command = "select * from demo";
                using (cmd = new SqlCommand(command, con))
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    dgv.DataSource = dt;
                }
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string cmdtext = "insert into demo(NAME,FATHERNAME,AGE,ADDRESS,COUNTRY,PINCODE)VALUES(@NAME,@FATHERNAME,@AGE,@ADDRESS,@COUNTRY,@PINCODE)";
                    using (cmd = new SqlCommand(cmdtext, con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Age",Convert.ToInt32(txtAge.Text));
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                    cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                    cmd.Parameters.AddWithValue("@PinCode",Convert.ToInt32(txtPinCode.Text));
                    con.Open();
                    int response = cmd.ExecuteNonQuery();
                    con.Close();
                    if(response>0)
                    {
                        MessageBox.Show("Data Inserted");
                        DataShow();
                    }
                }
            }
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        
    }
}
