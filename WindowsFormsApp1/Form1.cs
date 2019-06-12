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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private String cs = ConfigurationManager.ConnectionStrings["Data"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            DataShow();
        }
        public void DataShow()
        {
            using (con = new SqlConnection(cs))
            {
                string command = "select* from demo";
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                string cmdtext = "insert into demo(NAME,FATHERNAME,AGE,ADDRESS,COUNTRY,PINCODE)VALUES('@NAME','@FATHERNAME',@AGE,'@ADDRESS','@COUNTRY',@PINCODE);"
                using (cmd = new SqlCommand(cmdtext, con))
                {
                    cmd.Parameters.AddWithValue("@Name",txtName.Text);
                    cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                    cmd.Parameters.AddWithValue("@Age",Convert.ToInt32(txtAge.Text));
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                    cmd.Parameters.AddWithValue("@PinCode",Convert.ToInt32(txtPinCode.Text));
                    con.Open();
                    int response = cmd.ExecuteNonQuery();
                    con.Close();
                    if (response>0)
                    {
                        MessageBox.Show("Data Inserted");
                        DataShow();
                    }
                }
                     
           }

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
