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
    public partial class Login : Form

    {
        static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");
        //static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\TOSHIBA\OffenceSyst.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            if (RoleC.SelectedIndex == -1)
            {
                MessageBox.Show("Select the role");
            }
            else if (RoleC.SelectedIndex == 0)
            {
                if (NameT.Text == "" || idT.Text == "")
                {
                    MessageBox.Show("Enter both Admin Name and password");

                }

                else

                {

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    SqlCommand co = new SqlCommand("Select * From AdminTab Where [AdminName] = '" + NameT.Text + "' And StaffID = '" + idT.Text + "' ", conn);
                    SqlDataReader dr = co.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Successful you are now logged in as an Administrator");
                        Home ho = new Home();
                        ho.Show();
                        this.Hide();;
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID");
                        NameT.Text = "";
                        idT.Text = "";
                    }
                    
                    

                }



            }
            else
            {
                if (RoleC.SelectedIndex == -1)
                {
                    MessageBox.Show("Select the role");
                }
                else if (RoleC.SelectedIndex == 1)
                {
                    if (NameT.Text == "" || idT.Text == "")
                    {
                        MessageBox.Show("Enter both  Name and password");
                    }
                    else
                    {

                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        SqlCommand co = new SqlCommand("Select * From SigninID Where FullName = '" + NameT.Text + "' And StaffId = '" + idT.Text + "' ", conn);
                        SqlDataReader dr = co.ExecuteReader();
                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Successful you are now logged in as an Guest");
                            Home ho = new Home();
                            ho.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid ID");
                            NameT.Text = "";
                            idT.Text = "";
                        }
                        


                    }
                }
            }



            //if(idT.Text != "" || NameT.Text != "")
            //{
            //    conn.Open();

            //    SqlCommand com = new SqlCommand("SELECT * FROM SigninID WHERE StaffId = '" + idT.Text + "'", conn);
            //        SqlDataReader dr = com.ExecuteReader();
            //    if (dr.Read())
            //    {
            //        dr.Close();
            //        MessageBox.Show("Login Successful");
            //        Home ho = new Home();
            //        ho.Show();
            //        this.Hide();
            //        conn.Close();
            //    }
            //    else
            //    {
            //        dr.Close();



            //        MessageBox.Show("Invalid Staff ID");


            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please Fill up Blank Spaces");
            //}
        }

        private void Signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup si = new Signup();
            si.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotID id = new ForgotID();
                id.Show();
            this.Hide();
        }
    }
}
