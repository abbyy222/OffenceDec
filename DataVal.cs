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
    public partial class DataVal : Form
    {
        public DataVal()
        {
            InitializeComponent();
        }
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");

       
        private void FirstCategory()
        {

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand commm = new SqlCommand("Update FirstCat set [FIRST CATEGORY MISCONDUCT]=@AP, Punishment=@AY Where FirstID=@ACKey ", con);
                commm.Parameters.AddWithValue("@AP", NewCrimeT.Text);
                commm.Parameters.AddWithValue("@AY", PunishmentT.Text);

                commm.Parameters.AddWithValue("@ACKey", Key);
                commm.ExecuteNonQuery();
                MessageBox.Show("Account Updated");

                DisplayOffence();








            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void SecondOffence()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlCommand commm = new SqlCommand("Update SECONDTAB set [SECOND CATEGORY]=@AP, Punishment=@AY Where SecondID=@ACKey ", con);
                commm.Parameters.AddWithValue("@AP", NewCrimeT.Text);
                commm.Parameters.AddWithValue("@AY", PunishmentT.Text);

                commm.Parameters.AddWithValue("@ACKey", Key);
                commm.ExecuteNonQuery();
                MessageBox.Show("Account Updated");

                DisplayOffence();








            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }
        private void DisplayOffence()
        {
            string selectedTable = DataM.SelectedItem.ToString();
            string selectedMisconductColumn = CrimeC.SelectedItem.ToString();
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            string Query = $"SELECT *FROM {selectedTable}";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MisconductDGV.DataSource = ds.Tables[0];
         
        }
       
        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //[FIRST CATEGORY MISCONDUCT] FROM[FirstCat]"
        }

        private void NameC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CrimeC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CrimeC.SelectedItem.ToString() == "FIRST CATEGORY MISCONDUCT")
            {

                




                DataM.SelectedItem = "[FirstCat]";
                ViewT.Text = "FirstID";

                DisplayOffence();


            }
          else  if (CrimeC.SelectedItem.ToString() == "SECOND CATEGORY MISCONDUCT")
            {






                DataM.SelectedItem = "[SECONDTAB]";
                DisplayOffence();


            }

            else if (CrimeC.SelectedItem.ToString() == "THIRD CATEGORY MISCONDUCT")
            {






                DataM.SelectedItem = "[THIRDTAB]";
                DisplayOffence();


            }

        }

        private void gunaLinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataM_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataM.Enabled = false;
        }

        private void MisconductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = MisconductDGV.Rows[e.RowIndex];
            NewCrimeT.Text = row.Cells[1].Value.ToString();
            PunishmentT.Text = row.Cells[2].Value.ToString();
            
            if (NewCrimeT.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(row.Cells[0].Value.ToString());
            }

        }

        private void DataVal_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                //MessageBox.Show("Connection Sucess");
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }

            CrimeC.Visible = false;
            NewCrimeT.Visible = false;
            PunishmentT.Visible = false;
            NatureL.Visible = false;
            PunishmentL.Visible = false;
            MisconductDGV.Visible = false;
            AddBtn.Visible = false;
            EditBtn.Visible = false;
            DeleteBtn.Visible = false;
            NewCrimeL.Visible = false;


        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {




                MessageBox.Show("Missing Information");
            }
            else if(CrimeC.SelectedItem.ToString()== "FIRST CATEGORY MISCONDUCT")
            {
                FirstCategory();

            }

            else if (CrimeC.SelectedItem.ToString() == "SECOND CATEGORY MISCONDUCT")
            {
                SecondOffence();

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            string selectedTable = DataM.SelectedItem.ToString();

            if (NewCrimeT.Text == "" && PunishmentT.Text == "")
            {
                MessageBox.Show("Please Fill up the blank boxes to add offences to its designated database");
            }
            else
            {
                try
                {
                    string query = $"INSERT INTO {selectedTable} VALUES('" + NewCrimeT.Text + "', '" + PunishmentT.Text + "')";
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand com = new SqlCommand(query, con);
                    try
                    {
                        
                        
                            com.ExecuteNonQuery();
                            MessageBox.Show("New Offence added!!");
                            DisplayOffence();

                        

                    }
                    catch (Exception Ex)
                    {

                        MessageBox.Show(Ex.Message);
                    }

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);


                }

                //SqlCommand com = new SqlCommand("Insert Into CrimeChest( Fullname, MatricNumber, Level,  Department, CrimeA, CrimeB, CrimeD, ImageA, ImageB, ImageC, EyeWitnessName, WithessPosition, PunishmentA, PunishmentB, PunishmentC,  Date) Values( @FU, @MU,  @LE, @DE, @CA, @CB, @CD, @IM, @IB, @IC, @EN, @EP, @PA, @PB, @PC, @DA )", con);
                //com.Parameters.AddWithValue("FU", NameC.SelectedItem.ToString());
            }
        }

        private void gunaLinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
       
        
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string selectedTable = DataM.SelectedItem.ToString();
            string selectedID = ViewT.Text.ToString();

            if (Key == 0)
            {
                MessageBox.Show("Select the Account you wish to delete");
            }
            else
            {
                try
                {
                    string query = $"DELETE FROM {selectedTable} WHERE {selectedID} = @ACKey";
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlCommand comm = new SqlCommand(query, con);
                    comm.Parameters.AddWithValue("@ACKEY", Key);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Account Deleted");
                    con.Close();

                    DisplayOffence();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }

            }

        }
          int Key = 0;

        private void PunishmentT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewT_TextChanged(object sender, EventArgs e)
        {

        }

        private void StaffT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProBtn_Click(object sender, EventArgs e)
        {
            if (StaffT.Text != "")
            {
                try
                {

                    SqlCommand co = new SqlCommand("SELECT * FROM AdminTab WHERE [StaffID] = '" + StaffT.Text + "'", con);
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlDataReader dr = co.ExecuteReader();
                    if (dr.Read())
                    {

                        MessageBox.Show("Welcome to the Add Offence Session"  + dr["AdminName"], "Success", MessageBoxButtons.OK);

                        CrimeC.Visible = true;
                        NewCrimeT.Visible = true;
                        PunishmentT.Visible = true;
                        NatureL.Visible = true;
                        PunishmentL.Visible = true;
                        MisconductDGV.Visible = true;
                        AddBtn.Visible = true;
                        EditBtn.Visible = true;
                        DeleteBtn.Visible = true;
                        NewCrimeL.Visible = true;

                    }
                    dr.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Error");
            }




        }

        private void NatureL_Click(object sender, EventArgs e)
        {

        }

        private void PunishmentL_Click(object sender, EventArgs e)
        {

        }

        private void HomeB_Click(object sender, EventArgs e)
        {
            Home Ho = new Home();
            Ho.Show();
            this.Hide();
        }
    }
}
