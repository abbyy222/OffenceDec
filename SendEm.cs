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
    public partial class SendEm : Form
    {
        public SendEm()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");
        private Bitmap CaptureScreen()
        {
            try
            {
                Rectangle bounds = Screen.PrimaryScreen.Bounds;
                Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height);
                using (Graphics graphics = Graphics.FromImage(screenshot))
                {
                    graphics.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size);
                }
                return screenshot;
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
                return null;
            }
        }
        private void SendEm_Load(object sender, EventArgs e)
        {
            string sql = "SELECT *FROM OffendantDet";
            SqlCommand cmd = new SqlCommand(sql, con);
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NameC.Items.Add(dr["FullName"].ToString());
            }
            dr.Close();

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmailT_TextChanged(object sender, EventArgs e)
        {

        }

        private void LevelT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Matric_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Bitmap Screenshot = CaptureScreen();
            if(Screenshot != null)
            {
                using(SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PNG Files (*.png)|*.png|All files(*.*)|*.*";
                    saveFileDialog.Title = "Save Screenshot";
                    saveFileDialog.DefaultExt = "png";
                    if(saveFileDialog.ShowDialog()==DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        try
                        {
                            Screenshot.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                            MessageBox.Show("Screenshot Saved Successfully to " + filePath, "Screenshot Captured", MessageBoxButtons.OK);

                        }
                        catch (Exception Ex)
                        {

                            MessageBox.Show("Error saving screenshot:" + Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Screenshot.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Error Capturing Screenshot", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
                }
               

            }

        }

        private void NameC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = NameC.SelectedItem.ToString();
            string query1 = "SELECT Image FROM OffendantDet WHERE FullName = @Name";

            string query2 = "SELECT *FROM CrimeChest WHERE FullName = @Name";
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand com1 = new SqlCommand(query1, con);
            com1.Parameters.AddWithValue("@Name", selectedName);

            SqlDataReader de1 = com1.ExecuteReader();
            if(de1.Read())
            {
                byte[] imageData = (byte[])de1["Image"];
                Lip.Image = Image.FromStream(new System.IO.MemoryStream(imageData));

            }
            de1.Close();
            SqlCommand com2 = new SqlCommand(query2, con);
            com2.Parameters.AddWithValue("@Name", selectedName);
            SqlDataReader dr2 = com2.ExecuteReader();
            if(dr2.Read())
            {
                CrimeT.Text = dr2["CrimeA"].ToString();
                CrimeB.Text = dr2["CrimeB"].ToString();
                CrimeC.Text = dr2["CrimeD"].ToString();

                PunishA.Text = dr2["PunishmentA"].ToString();
                PunishB.Text = dr2["PunishmentB"].ToString();
                PunishC.Text = dr2["PunishmentC"].ToString();

                LevelT.Text = dr2["Level"].ToString();
                Matric.Text = dr2["MatricNumber"].ToString();
                DepartmentT.Text = dr2["Department"].ToString();
                EmailT.Text = dr2["ParentEmail"].ToString();

                byte[] imageData = (byte[])dr2["ImageA"];
                MyPicB.Image = Image.FromStream(new System.IO.MemoryStream(imageData));

                byte[] imageBData = (byte[])dr2["ImageB"];
                MyPicC.Image = Image.FromStream(new System.IO.MemoryStream(imageBData));

                byte[] imageCData = (byte[])dr2["ImageC"];
                MyPicD.Image = Image.FromStream(new System.IO.MemoryStream(imageCData));
            }
            dr2.Close();

        }

        private void MyPicB_Click(object sender, EventArgs e)
        {

        }

        private void MyPicC_Click(object sender, EventArgs e)
        {

        }

        private void MyPicD_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentT_TextChanged(object sender, EventArgs e)
        {

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            
            Email em = new Email();
            em.Show();
            this.Hide();
        }

        private void CrimeT_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrimeB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PunishA_TextChanged(object sender, EventArgs e)
        {

        }

        private void HideBtn_Click(object sender, EventArgs e)
        {
            MyPicC.Visible = false;
            MyPicD.Visible = false;
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            Home ho = new Home();
            ho.Show();
            this.Hide();
        }
    }
    
}
