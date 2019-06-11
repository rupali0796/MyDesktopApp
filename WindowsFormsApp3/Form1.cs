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
        private string cs = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            DataShow();
        }
        public void DataShow()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open()

            }
        }
    }
}
