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
        string cs = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            DataShow();
        }
       
        public void DataShow()
        {
           
            
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("selectsp", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            dgv.DataSource = dt;
            //dgv.datasource= cmd.executereader();

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("InsertSp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@Address",txtAddress.Text);
                cmd.Parameters.AddWithValue("@Country",txtCountry.Text);
                int i = cmd.ExecuteNonQuery();
                if(i>0)
                {
                    MessageBox.Show("Data has been saved suceessfully!!!");
                }
                else
                {
                    MessageBox.Show("Data not saved!!!");
                }
                DataShow();

            }
        }
    }
}
