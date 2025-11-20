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
using System.Xml.Linq;

namespace Offence_Decision
{
    public partial class ForgotID : Form
    {
        public ForgotID()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");


        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string selectedName = NameT.Text;

            string query2 = "SELECT *FROM SigninID WHERE Fullname = @Name";
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand com2 = new SqlCommand(query2, con);
            com2.Parameters.AddWithValue("@Name", selectedName);
            SqlDataReader dr2 = com2.ExecuteReader();
            if (dr2.Read())
            {
                IdT.Text = dr2["StaffId"].ToString();
            }
            dr2.Close();

        }

        private void ForgotID_Load(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.Show();
            this.Hide();
        }
    }
}
