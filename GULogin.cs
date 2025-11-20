using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Offence_Decision
{
  
    public partial class GULogin : Form
    {
        string imgLocation;
        ////static SqlConnection con = new SqlConnection(@"Data Source=(localdb)\vote;Initial Catalog=OffenceSyst;Integrated Security=True");
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");
        public GULogin()
        {
            InitializeComponent();
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            if(MatricT.Text == "" || FullNameT.Text == "" ||  DepartmentC.SelectedIndex == -1 || LevelC.SelectedIndex == -1 || RoomT.Text == "" || ParEmT.Text == "")
            {
                MessageBox.Show("Please key in the student's data");
            }
            else
            {
                try
                {
                    byte[] ige = null;
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    ige = brs.ReadBytes((int)stream.Length);
                    con.Open();
                    
                    SqlCommand com = new SqlCommand("Insert Into OffendantDet(MatricNumber, Fullname, Department, Hostel, Image,  Level, RoomNumber, ParentEmail,  Date) Values(@MU, @FU, @DE, @HO, @IM, @LE, @RM, @PE, @DA)", con);
                    com.Parameters.AddWithValue("MU", MatricT.Text);
                    com.Parameters.AddWithValue("FU", FullNameT.Text);
                    com.Parameters.AddWithValue("DE", DepartmentC.SelectedItem.ToString());
                    com.Parameters.AddWithValue("HO", HostelT.SelectedItem.ToString());
                    com.Parameters.AddWithValue("IM", ige);
                    com.Parameters.AddWithValue("LE", LevelC.SelectedItem.ToString());
                    com.Parameters.AddWithValue("RM", RoomT.Text);
                    com.Parameters.AddWithValue("PE", ParEmT.Text);
                    com.Parameters.AddWithValue("DA", DateTime.Now.Date);


                    
                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Account Created!!");
                        Home ho = new Home();
                        ho.Show();
                        this.Hide();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Failed to register");
                    }

                    con.Close();
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Failed to connect to the database");
                }
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                MyPic.ImageLocation = imgLocation;
            }
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            Home Ho = new Home();
            Ho.Show();
            this.Hide();
        }

        private void GULogin_Load(object sender, EventArgs e)
        {

        }
    }
}
