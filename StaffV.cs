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

namespace Offence_Decision
{
    public partial class StaffV : Form
    {
        public StaffV()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\vote;Initial Catalog=OffenceSyst;Integrated Security=True");
        private void Proceed_Click(object sender, EventArgs e)
        {
            if (StaffT.Text == "")
            {
                MessageBox.Show("Enter both Admin Name and password");

            }

            else

            {
                conn.Open();
                SqlCommand co = new SqlCommand("Select * From AdminTab Where StaffID = '" + StaffT.Text + "' ", conn);
                SqlDataReader dr = co.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Successful you are now logged in as an Administrator");
                    DataVal va = new DataVal();
                    va.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid ID");
                    StaffT.Text = "";
                    
                }
                conn.Close();

            }
        }
}
