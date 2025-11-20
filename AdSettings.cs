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
    public partial class AdSettings : Form
    {
        string imgLocation;
        String randomCode;
        public AdSettings()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\Vote;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");
        private void AdSettings_Load(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FullNameT_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveB_Click(object sender, EventArgs e)
        {
           

         }
              
    
        private void BrowseB_Click(object sender, EventArgs e)
        {
           
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();

            staffId.Text = "CLU" + randomCode;
            if (staffId.Text == "StaffId")
            {
                MessageBox.Show("Please Generate Your Staff ID");

            }
        }

        private void PhoneT_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (FullNameT.Text != "" && PhoneT.Text != "")
            {


                byte[] ige = null;
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                ige = brs.ReadBytes((int)stream.Length);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand com = new SqlCommand("INSERT INTO AdminTab(AdminName, Email, ContactNo,  Position, StaffID, Image) VALUES(@AD, @EM, @PH, @PO,  @CH, @IA)", con);
                com.Parameters.AddWithValue("AD", FullNameT.Text);
                com.Parameters.AddWithValue("EM", EmailT.Text);
                com.Parameters.AddWithValue("PH", PhoneT.Text);
                com.Parameters.AddWithValue("IA", ige);
                com.Parameters.AddWithValue("PO", PositionT.Text);

                com.Parameters.AddWithValue("CH", staffId.Text);
                try
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show("New Admin Created!!");
                    Home ho = new Home();
                    ho.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }



            }

        }
    }
}
