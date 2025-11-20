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
    public partial class PasswordUser : Form
    {

        public PasswordUser()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");
        private void Reset()
        {
            FullNameT.Text = "";
            DepartmentC.SelectedIndex = -1;
            EmailT.Text = "";
            PositionT.Text = "";
        }
        private byte[] ImageToByteArray(Image imageIn)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void GenerateData()
        {

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand co = new SqlCommand("Select * From SigninID Where StaffId = '" + IDT.Text + "'", con);
            SqlDataReader dr = co.ExecuteReader();
            if (dr.Read())
            {
                FullNameT.Text =  dr["FullName"].ToString();
                PositionT.Text = dr["Position"].ToString();
                DepartmentC.SelectedItem = dr["Department"].ToString();
                EmailT.Text = dr["Email"].ToString();
                ID.Text = dr["UserID"].ToString();
               if (dr.HasRows)
                    {
                    byte[] img = (byte[])(dr[4]);
                    if (img == null)
                    {
                        Mypic.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        Mypic.Image = Image.FromStream(ms);
                    }
                }


                //Balance = Convert.ToInt32(dr["AcBalance"].ToString());

            }
            else
            {
                MessageBox.Show("Invalid StaffID");
            }

            con.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                  MessageBox.Show("Missing Information");
            }
            else
            {


                try
                {



                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand commm = new SqlCommand("Update SigninID Set FullName=@FN,Department=@DP,Email=@EM,image=@IA, Position=@PO, StaffId=@SI,Date=@DA Where UserID = @id ", con);
                    commm.Parameters.AddWithValue("@FN",FullNameT.Text);
                    commm.Parameters.AddWithValue("@DP", DepartmentC.SelectedItem.ToString());
                    commm.Parameters.AddWithValue("@PO", PositionT.Text);
                    commm.Parameters.AddWithValue("@EM", EmailT.Text);
                    byte[] imageData = ImageToByteArray(Mypic.Image);
                    commm.Parameters.AddWithValue("@IA", imageData);
                    commm.Parameters.AddWithValue("@SI", IDT.Text);
                    commm.Parameters.AddWithValue("@DA",DateTime.Now.Date);
                    commm.Parameters.AddWithValue("@id", Convert.ToInt32(ID.Text));

                    commm.ExecuteNonQuery();
                    MessageBox.Show("Account Updated");
                    
                    Reset();



                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
  
        private void Proceedbtn_Click(object sender, EventArgs e)
        {
            if (IDT.Text != "")
            {
                GenerateData();
            }
            else
            {
                MessageBox.Show("Please enter your staffID to proceed");
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Home ho = new Home();
            ho.Show();
            this.Hide();
        }

        private void PasswordUser_Load(object sender, EventArgs e)
        {

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
    }
}
