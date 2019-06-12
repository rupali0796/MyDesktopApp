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
        int ID = 0;
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
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                    cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                    cmd.Parameters.AddWithValue("@PinCode", Convert.ToInt32(txtPinCode.Text));
                    con.Open();
                    int response = cmd.ExecuteNonQuery();
                    con.Close();
                    if (response > 0)
                    {
                        MessageBox.Show("Data Inserted");
                        DataShow();
                    }
                }
            }
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtName.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFatherName.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAge.Text = dgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtAddress.Text = dgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCountry.Text = dgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPinCode.Text = dgv.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(cs))
            {
                string query = "Update demo set NAME = @name,FATHERNAME = @fname, AGE = @age," +
                    "ADDRESS = @address, COUNTRY = @country,PINCODE = @pincode where demo_id = @id";
                using (cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@fname", txtFatherName.Text.Trim());
                    cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text.Trim()));
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@country", txtCountry.Text.Trim());
                    cmd.Parameters.AddWithValue("@pincode", Convert.ToInt32(txtPinCode.Text.Trim()));

                    cmd.Parameters.AddWithValue("@id", ID);
                    con.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Updated.");
                        DataShow();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            using (con = new SqlConnection(cs))
            {
                string query = "Delete from demo where demo_id = @id";
                using (cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    con.Open();
                    int rowAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Delete.");
                        DataShow();
                    }
                }
            }
        }
    }
}

