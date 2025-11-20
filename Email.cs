using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Data.SqlClient;

namespace Offence_Decision
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
        }
        //static SqlConnection con = new SqlConnection(@"Data Source=(localdb)\vote;Initial Catalog=OffenceSyst;Integrated Security=True");
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");

        public static String to;

        private void SendBtn_Click(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            MailMessage message = new MailMessage();
            to = (EmailT.Text).ToString();
            from = "csharpdevelopers334@gmail.com";
            pass = "ehjq iyku ywkl mkhj";
            messageBody = BodyTF.Text;

            foreach (string filename in openFileDialog1.FileNames)
            {
                if(File.Exists(filename))
                {
                    string fname = Path.GetFileName(filename);
                    message.Attachments.Add(new Attachment(filename));
                }
            }

            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "SUSPENSION LETTER";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Message  sent successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Email_Load(object sender, EventArgs e)
        {
            string sql = "SELECT *FROM CrimeChest";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NameC.Items.Add(dr["FullName"].ToString());
              
            }
            dr.Close();
        }

        private void NameC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = NameC.SelectedItem.ToString();

            string query2 = "SELECT *FROM CrimeChest WHERE FullName = @Name";
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand com2 = new SqlCommand(query2, con);
            com2.Parameters.AddWithValue("@Name", selectedName);
            SqlDataReader dr2 = com2.ExecuteReader();
            if (dr2.Read())
            {
                EmailT.Text = dr2["ParentEmail"].ToString();
                SubT.Text = "A LETTER OF SUSPENSION FOR'" + NameC.SelectedItem.ToString() + "'";

                CrimeT.Text = dr2["CrimeA"].ToString();
                CrimeB.Text = dr2["CrimeB"].ToString();
                CrimeC.Text = dr2["CrimeD"].ToString();

                PunishA.Text = dr2["PunishmentA"].ToString();
               
                PunishB.Text = dr2["PunishmentB"].ToString();
                PunishC.Text = dr2["PunishmentC"].ToString();
                SentenceA.Text = dr2["SentenceA"].ToString();
                SentenceB.Text = dr2["SentenceB"].ToString();
                SentenceC.Text = dr2["SentenceC"].ToString();

                BodyTF.Text = "Dear Guardian, we are sorry to notify that your ward '" + NameC.SelectedItem.ToString() + "'will be given the appropriate punishment '" + PunishA.Text + "': '"+SentenceA.Text+"',\n '" + PunishB.Text + "': '"+SentenceB.Text+"'\n '" + PunishC.Text + "': '"+SentenceC.Text+"' should in case your ward does not get the physical letter to you, ";
                
                //BodyTF.Text = "Dear Guardian, We are sorry to notify that your ward '" + NameC.SelectedItem.ToString() + "'will be suspended for 2 semesters because he was caught flaunting a very serious offence. He was caught'" + dr2["CrimeA"];

            }

        }

        private void AttachID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           


        }

        private void AttachID_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            foreach (string filename in openFileDialog1.FileNames)
            {
                MessageBox.Show(filename);
                sentF.Text = filename.ToString();
            }
        }

        private void sentF_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            SendEm sendEm = new SendEm();
            sendEm.Show();
            this.Hide();
        }

        private void gunaComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PunishA_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLinkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void PunishB_TextChanged(object sender, EventArgs e)
        {

        }

        private void PunishC_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
