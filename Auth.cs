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
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");
        private void Proceed_Click(object sender, EventArgs e)
        {
            if (StaffT.Text == "")
            {
                MessageBox.Show("Enter both Admin Name and password");

            }

            else

            {
                con.Open();
                SqlCommand co = new SqlCommand("Select * From AdminTab Where StaffID = '" + StaffT.Text + "' ", con);
                SqlDataReader dr = co.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Successful you are now logged in as an Administrator");
                    DataVal va = new DataVal();
                    va.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Invalid ID");
                    StaffT.Text = "";

                }
                con.Close();

            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Home Ho = new Home();
            Ho.Show();
            this.Hide();

        }
    }
}
