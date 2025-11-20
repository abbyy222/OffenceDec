using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Offence_Decision
{
    public partial class Signup : Form
    {
        //SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\vote;Initial Catalog=OffenceSyst;Integrated Security=True");
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");
        String randomCode;
        string imgLocation;
        public static String to;
        public Signup()
        {
            InitializeComponent();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLineTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(FullnameT.Text == "" || EmailT.Text == "" || PositionT.Text == "" || DepartmentC.SelectedIndex == -1)
            {
                MessageBox.Show("Please Fill up Blank spaces");
               
            }
            else
            {
                try
                {

                    byte[] ige = null;
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    ige = brs.ReadBytes((int)stream.Length);
                    conn.Open();
                    SqlCommand oc = new SqlCommand("Insert Into SigninID(Fullname, Department, Email, Image, Position, StaffId, Date) Values(@NU, @DU, @BC, @IA, @PO, @SI, @DA)", conn);
                    oc.Parameters.AddWithValue("NU", FullnameT.Text);
                    oc.Parameters.AddWithValue("DU", DepartmentC.SelectedItem.ToString());
                    oc.Parameters.AddWithValue("BC", EmailT.Text);
                    oc.Parameters.AddWithValue("IA", ige);
                    oc.Parameters.AddWithValue("DA", DateTime.Now.Date);
                    oc.Parameters.AddWithValue("PO", PositionT.Text);
                    oc.Parameters.AddWithValue("SI", staffId.Text);

                    oc.ExecuteNonQuery();
                    MessageBox.Show("Registration Successful you will be directed to login page");
                   
                    Login lo = new Login();
                    lo.Show();
                    this.Hide();
                    conn.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();

            staffId.Text = "CLU"+randomCode;
            if (staffId.Text == "StaffId")
            {
                MessageBox.Show("Please Generate Your Staff ID");

            }
         
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                MyPicPB.ImageLocation = imgLocation;
            }
        }

        private void staffId_Click(object sender, EventArgs e)
        {

        }
    }
}
