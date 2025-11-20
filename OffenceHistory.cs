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
    public partial class OffenceHistory : Form
    {
        public OffenceHistory()
        {
            InitializeComponent();
        }
        //static SqlConnection con = new SqlConnection(@"Data Source=(localdb)\vote;Initial Catalog=OffenceSyst;Integrated Security=True");
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");
        private void OffenceHistory_Load(object sender, EventArgs e)
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string Query = "SELECT *FROM CrimeChest";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            HistoryDGV.DataSource = ds.Tables[0];

        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            Home bo = new Home();
            bo.Show();
            this.Hide();
        }
    }
}
