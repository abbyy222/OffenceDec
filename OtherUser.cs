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
using System.Runtime.Remoting;

namespace Offence_Decision
{
    public partial class OtherUser : Form
    {
        public OtherUser()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");
        String randomCode;
        string imgLocation;
        public static String to;
        private Image GetImageFromDatabase(object imageData)
        {
            try
            {
                byte[] bytes = (byte[])imageData;
                Image image = Image.FromStream(new System.IO.MemoryStream(bytes));
                return image;
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
                return null;
            }
        }
        private void LoadData()
        {
            string Query = "SELECT *FROM SigninID";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            GuestDGV.DataSource = ds.Tables[0];
        }
        private void OtherUser_Load(object sender, EventArgs e)
        {

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            LoadData();
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GuestDGV.Rows[e.RowIndex];
            FullnameT.Text = row.Cells[1].Value.ToString();
            DepartmentCo.Text = row.Cells[2].Value.ToString();
            EmailT.Text = row.Cells[3].Value.ToString();
            Image image = GetImageFromDatabase(row.Cells[4].Value);
            MyPicB.Image = image;

            PositionT.Text = row.Cells[5].Value.ToString();

            if (FullnameT.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }

        }

        private void PositionT_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void MyPicB_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (FullnameT.Text == "" && EmailT.Text == "" && DepartmentCo.Text == " " && PositionT.Text == "")
            {
                MessageBox.Show("Please fill in the blank boxes");
            }
            else
            {

                try
                {

                    byte[] ige = null;
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(stream);
                    ige = brs.ReadBytes((int)stream.Length);


                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand oc = new SqlCommand("Insert Into SigninID(Fullname, Department, Email, Image, Position, StaffId, Date) Values(@NU, @DU, @BC, @IA, @PO, @SI, @DA)", con);
                    oc.Parameters.AddWithValue("NU", FullnameT.Text);
                    oc.Parameters.AddWithValue("DU", DepartmentCo.Text);
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
                    con.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void staffId_Click(object sender, EventArgs e)
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
        int Key = 0;
        private void EditBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand commm = new SqlCommand("Update SigninID set Fullname=@AP, Department=@AY, Email=@EM, Position=@PO, DateModified=@DA Where UserID=@ACKey ", con);
                commm.Parameters.AddWithValue("@AP", FullnameT.Text);
                commm.Parameters.AddWithValue("@AY", DepartmentCo.Text);
                commm.Parameters.AddWithValue("@EM", EmailT.Text);
                commm.Parameters.AddWithValue("@PO", PositionT.Text);
                commm.Parameters.AddWithValue("@DA", DateTime.Now.Date);

                commm.Parameters.AddWithValue("@ACKey", Key);
                commm.ExecuteNonQuery();
                MessageBox.Show("Guest Account Updated");

                LoadData();
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                MyPicB.ImageLocation = imgLocation;
            }
        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            Home Ho = new Home();
            Ho.Show();
            this.Hide();
        }
    }
}
