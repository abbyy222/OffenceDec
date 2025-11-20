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

namespace Offence_Decision
{
    public partial class Auth2 : Form
    {
        public Auth2()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");
        private void Auth2_Load(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        private void Proceed_Click(object sender, EventArgs e)
        {
            if (StaffT.Text == "")
            {
                MessageBox.Show("Please Enter an AdminID");

            }

            else

            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand co = new SqlCommand("Select * From AdminTab Where StaffID = '" + StaffT.Text + "' ", con);
                SqlDataReader dr = co.ExecuteReader();
                if (dr.Read())
                {
                 
                    MessageBox.Show("Successful you are now logged in as an Administrator");
                    Matching va = new Matching();
                    va.Show();
                    this.Hide();
                  
                }
              
               
                else
                {
                    MessageBox.Show("Invalid ID");
                    StaffT.Text = "";
                    dr.Close();
                }
                

            }
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {

            Home ki = new Home();
            ki.Show();
            this.Hide();
        }
    }
}
