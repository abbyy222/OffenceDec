using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Offence_Decision
{
    public partial class Matching : Form
    {
        public Matching()
        {
            InitializeComponent();
        }
        private byte[] ImageToByteArray(Image imageIn)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
            string imgLocation;
        //static SqlConnection con = new SqlConnection(@"Data Source=(localdb)\vote;Initial Catalog=OffenceSyst;Integrated Security=True");
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");
        private string GetRandomSpecificPunishment()
        {
    
            
                string selectedPunishment = PunishmentA.SelectedItem.ToString();

                string query = $"SELECT TOP 1 [{selectedPunishment}] FROM SentencePo ORDER BY NEWID()";
                string SpecificPunishment = "";
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlDataReader dh = com.ExecuteReader();
                    if (dh.Read())
                    {
                        SpecificPunishment = dh[selectedPunishment].ToString();
                    }

                    dh.Close();


                }

                catch (Exception Ex)
                {
                    MessageBox.Show("Error retrieving specific Punishment " + Ex.Message);

                }

                return SpecificPunishment;

            


        }



        private string GetRandomSpecificPunishmentB()
        {


            string selectedPunishment = PunishmentB.SelectedItem.ToString();

            string query = $"SELECT TOP 1 [{selectedPunishment}] FROM SentencePo ORDER BY NEWID()";
            string SpecificPunishment = "";
            SqlCommand com = new SqlCommand(query, con);
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader dh = com.ExecuteReader();
                if (dh.Read())
                {
                    SpecificPunishment = dh[selectedPunishment].ToString();
                }

                dh.Close();


            }

            catch (Exception Ex)
            {
                MessageBox.Show("Error retrieving specific Punishment " + Ex.Message);

            }

            return SpecificPunishment;




        }

        private string GetRandomSpecificPunishmentC()
        {


            string selectedPunishment = PunishmentC.SelectedItem.ToString();

            string query = $"SELECT TOP 1 [{selectedPunishment}] FROM SentencePo ORDER BY NEWID()";
            string SpecificPunishment = "";
            SqlCommand com = new SqlCommand(query, con);
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                SqlDataReader dh = com.ExecuteReader();
                if (dh.Read())
                {
                    SpecificPunishment = dh[selectedPunishment].ToString();
                }

                dh.Close();


            }

            catch (Exception Ex)
            {
                MessageBox.Show("Error retrieving specific Punishment " + Ex.Message);

            }

            return SpecificPunishment;




        }



       

       


        private void FirstCombobox()
        {
            string selectedTable = DataT.SelectedItem.ToString();
            string selectedMisconduct = CrimeA.SelectedItem.ToString();
            string selectedMisconductColumn = CrimeC.SelectedItem.ToString();

            string query = $"SELECT Punishment FROM {selectedTable} WHERE [{selectedMisconductColumn}] =@SelectedMisconduct";

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cop = new SqlCommand(query, con);
            cop.Parameters.AddWithValue("@SelectedMisconduct", CrimeA.SelectedItem.ToString());

            SqlDataReader du = cop.ExecuteReader();
            if (du.HasRows)
            {
                du.Read();
                string punishmentt = du.GetString(0);
                PunishmentA.Items.Add(punishmentt).ToString();
                PunishmentA.SelectedItem = punishmentt;
                MessageBox.Show("Dear '" + NameC.SelectedItem.ToString() + "' due to the offences that you have been given " + punishmentt, "PUNISHMENT", MessageBoxButtons.OK);
            }
            du.Close();
        }

        private void FirstSecondCombobox()
        {
            string selectedTable = DataT.SelectedItem.ToString();
            string selectedMisconductB = CrimeB.SelectedItem.ToString();
            string selectedMisconductColumn = CrimeC.SelectedItem.ToString();

            string query = $"SELECT Punishment FROM {selectedTable} WHERE [{selectedMisconductColumn}]= @SelectedMisconductB";

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cop = new SqlCommand(query, con);
            cop.Parameters.AddWithValue("@SelectedMisconductB", selectedMisconductB);
            SqlDataReader du = cop.ExecuteReader();
            if (du.HasRows)
            {
                du.Read();

                string punishmenta = du.GetString(0);

                PunishmentB.Items.Add(punishmenta).ToString();

                PunishmentB.SelectedItem = punishmenta;

                MessageBox.Show("Dear '" + NameC.SelectedItem.ToString() + "' due to the offences that you have been given " + punishmenta, "Double", MessageBoxButtons.OK);

            }
            du.Close();
        }

        private void FirstSecondThirdCombobox()
        {

            string selectedTable = DataT.SelectedItem.ToString();
            string selectedMisconductA = CrimeA.SelectedItem.ToString();
            string selectedMisconductB = CrimeB.SelectedItem.ToString();
            string selectedMisconductD = CrimeD.SelectedItem.ToString();
            string selectedMisconductColumn = CrimeC.SelectedItem.ToString();

            string query = $"SELECT Punishment FROM {selectedTable} WHERE [{selectedMisconductColumn}] = @SelectedMisconductD";

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cop = new SqlCommand(query, con);
            cop.Parameters.AddWithValue("@SelectedMisconductA", selectedMisconductA);
            cop.Parameters.AddWithValue("@SelectedMisconductB", selectedMisconductB);
            cop.Parameters.AddWithValue("@SelectedMisconductD", selectedMisconductD);

            SqlDataReader du = cop.ExecuteReader();
            if (du.HasRows)
            {
                du.Read();
                string punishmento = du.GetString(0);
                PunishmentC.Items.Add(punishmento).ToString();

                PunishmentC.SelectedItem = punishmento;
                MessageBox.Show("Dear '" + NameC.SelectedItem.ToString() + "' due to the offences that you have been given " + punishmento, "Warning", MessageBoxButtons.OK);
            }
            du.Close();
        }


        private void PopulateOtherComboBoxes()
        {
            string query = "";
            if (CrimeC.SelectedItem.ToString() == "FIRST CATEGORY MISCONDUCT")
            {

                CrimeB.Items.Clear();
                CrimeA.Items.Clear();
                CrimeD.Items.Clear();
                query = "SELECT [FIRST CATEGORY MISCONDUCT] FROM [FirstCat]";
            }

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand comm = new SqlCommand(query, con);
            SqlDataReader de = comm.ExecuteReader();
            while (de.Read())
            {
                string item = de.GetString(0);
                CrimeA.Items.Add(item);
                CrimeB.Items.Add(item);
                CrimeD.Items.Add(item);

            }
            de.Close();

        }

        private void PopulateSecondData()
        {
            CrimeB.Items.Clear();
            CrimeA.Items.Clear();
            CrimeD.Items.Clear();
            string query = "SELECT [SECOND CATEGORY] FROM [SECONDTAB]";
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cop = new SqlCommand(query, con);
            SqlDataReader du = cop.ExecuteReader();
            while (du.Read())
            {
                string item = du.GetString(0);
                CrimeA.Items.Add(item);
                CrimeB.Items.Add(item);
                CrimeD.Items.Add(item);

            }
            du.Close();

        }

        private void PopulateThirdData()
        {
            CrimeB.Items.Clear();
            CrimeA.Items.Clear();
            CrimeD.Items.Clear();
            string query = "SELECT [THIRD CATEGORY] FROM [THIRDTAB]";
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cop = new SqlCommand(query, con);
            SqlDataReader du = cop.ExecuteReader();
            while (du.Read())
            {
                string item = du.GetString(0);
                CrimeA.Items.Add(item);
                CrimeB.Items.Add(item);
                CrimeD.Items.Add(item);

            }
            du.Close();
        }

        private void PopulateOthers()
        {
            CrimeB.Items.Clear();
            CrimeA.Items.Clear();
            CrimeD.Items.Clear();
            string query = "SELECT [SevereMisconduct] FROM [OtherMisconduct]";
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }
            SqlCommand cop = new SqlCommand(query, con);
            SqlDataReader du = cop.ExecuteReader();
            while (du.Read())
            {
                string item = du.GetString(0);
                CrimeA.Items.Add(item);
                CrimeB.Items.Add(item);
                CrimeD.Items.Add(item);

            }
            du.Close();
        }




        private void Matching_Load(object sender, EventArgs e)
        {
            AcpT.Visible = false;
            AcBT.Visible = false;
            NameT.Visible = false;
            PositionT.Visible = false;
            EyeL.Visible = false;
            PositionL.Visible = false;

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

        private void YesCH_CheckedChanged(object sender, EventArgs e)
        {
            EyeL.Visible = YesCH.Checked;
            NameT.Visible = YesCH.Checked;
            PositionT.Visible = YesCH.Checked;
            PositionL.Visible = YesCH.Checked;
            if (YesCH.Checked == true)
            {
                NoCh.Checked = false;
            }
        }

        private void NameC_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (NameC.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in the blank space");

            }
            else
            {
                try
                {

                    SqlCommand co = new SqlCommand("Select * From OffendantDet Where FullName = '" + NameC.SelectedItem.ToString() + "'", con);
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    SqlDataReader dr = co.ExecuteReader();
                    if (dr.Read())
                    {
                        Matric.Text = dr["MatricNumber"].ToString();
                        DepartmentT.Text = dr["Department"].ToString();
                        LevelT.Text = dr["Level"].ToString();
                        byte[] imageData = (byte[])dr["Image"];

                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            MyPicB.Image = Image.FromStream(ms);

                        }
                        EmailT.Text = dr["ParentEmail"].ToString();




                    }
                    dr.Close();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CrimeC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CrimeC.SelectedItem.ToString() == "FIRST CATEGORY MISCONDUCT")
            {

                PopulateOtherComboBoxes();




                DataT.SelectedItem = "[FirstCat]";


            }
            else if (CrimeC.SelectedItem.ToString() == "SECOND CATEGORY")
            {


                PopulateSecondData();
                DataT.SelectedItem = "SECONDTAB";
            }
            if (CrimeC.SelectedItem.ToString() == "THIRD CATEGORY")
            {
                PopulateThirdData();
                DataT.SelectedItem = "THIRDTAB";
            }
            if (CrimeC.SelectedItem.ToString() == "SevereMisconduct")
            {
                PopulateOthers();
                DataT.SelectedItem = "OtherMisconduct";
            }

        }

        private void CrimeA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CrimeA.SelectedItem.ToString() != "")
            {
                CrimeB.SelectedItem = "None";
                CrimeD.SelectedItem = "None";
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                Evi1.ImageLocation = imgLocation;
            }
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                Evi2.ImageLocation = imgLocation;
            }
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg| All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                Evi3.ImageLocation = imgLocation;
            }
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            if (CrimeA.SelectedIndex != -1 && CrimeB.SelectedItem.ToString() == "None" && CrimeD.SelectedItem.ToString() == "None")
            {

                FirstCombobox();



            }



            else if (CrimeA.SelectedIndex != -1 && CrimeB.SelectedIndex != -1 && CrimeD.SelectedItem.ToString() == "None")
            {
                FirstSecondCombobox();


                MessageBox.Show("This student ('" + NameC.SelectedItem.ToString() + "') has committed more than one offence from '" + CrimeC.SelectedItem.ToString() + "' and should be given appropriate punishment for the crimes committed by the hall Administrators or any member of the student services");

            }

            else if (CrimeA.SelectedIndex != -1 && CrimeB.SelectedIndex != -1 && CrimeD.SelectedIndex != -1)
            {
                FirstSecondThirdCombobox();
            }


            string selectedPunishment = PunishmentA.SelectedItem.ToString();
            if (selectedPunishment != "")
            {
                string ramdomSpecificPunishment = GetRandomSpecificPunishment();
                AcpT.Text = ramdomSpecificPunishment;

            }

            string selectedPunishmenta = PunishmentB.SelectedItem.ToString();
            if (selectedPunishmenta != "")
            {
                string ramdomSpecificPunishment = GetRandomSpecificPunishmentB();
                AcBT.Text = ramdomSpecificPunishment;

            }

            string selectedPunishmentab = PunishmentB.SelectedItem.ToString();
            if (selectedPunishmentab != "")
            {
                string ramdomSpecificPunishment = GetRandomSpecificPunishmentC();
                AcDT.Text = ramdomSpecificPunishment;

            }


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

                SqlCommand com = new SqlCommand("Insert Into CrimeChest( Fullname, MatricNumber, Level,  Department, CrimeA, CrimeB, CrimeD, ImageA, ImageB, ImageC, EyeWitnessName, WithessPosition, PunishmentA, PunishmentB, PunishmentC, SentenceA, SentenceB, SentenceC, ParentEmail,  Date) Values( @FU, @MU,  @LE, @DE, @CA, @CB, @CD, @IM, @IB, @IC, @EN, @EP, @PA, @PB, @PC, @SA, @SB, @SC, @PE, @DA )", con);
                com.Parameters.AddWithValue("FU", NameC.SelectedItem.ToString());
                com.Parameters.AddWithValue("MU", Matric.Text);
                com.Parameters.AddWithValue("LE", LevelT.Text);
                com.Parameters.AddWithValue("DE", DepartmentT.Text);
                com.Parameters.AddWithValue("CA", CrimeA.SelectedItem.ToString());
                com.Parameters.AddWithValue("CB", CrimeB.SelectedItem.ToString());
                com.Parameters.AddWithValue("CD", CrimeD.SelectedItem.ToString());
                com.Parameters.AddWithValue("IM", ige);
                com.Parameters.AddWithValue("IB", ige);
                com.Parameters.AddWithValue("IC", ige);
                com.Parameters.AddWithValue("EN", NameT.Text);
                com.Parameters.AddWithValue("EP", PositionT.Text);
                com.Parameters.AddWithValue("PA", PunishmentA.SelectedItem.ToString());
                com.Parameters.AddWithValue("PB", PunishmentB.SelectedItem.ToString());
                com.Parameters.AddWithValue("PC", PunishmentC.SelectedItem.ToString());
                com.Parameters.AddWithValue("SA", AcpT.Text);
                com.Parameters.AddWithValue("SB", AcBT.Text);
                com.Parameters.AddWithValue("SC", AcDT.Text);
                com.Parameters.AddWithValue("PE", EmailT.Text);
                com.Parameters.AddWithValue("DA", DateTime.Now.Date);



                try
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show("Crime Sucessfully Added to the database!!");
                 

                    Email Email = new Email();
                    Email.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {

                    MessageBox.Show(Ex.Message);
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Failed to connect to the database");
            }


           





        }
    
        private void DataT_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataT.Enabled = false;
        }

        private void PunishmentB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PunishmentB.SelectedItem.ToString() != "")
            {
                PunishmentC.SelectedItem = "None";
            }
        }

        private void PunishmentA_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                ////string selectedPunishment = PunishmentA.SelectedItem.ToString();
                ////if (selectedPunishment == "5 points Demerit")
                ////{
                ////    string ramdomSpecificPunishment = GetRandomSpecificPunishment();
                ////    AcpT.Text = ramdomSpecificPunishment;
                ////}
            
        
          
            if (PunishmentA.SelectedItem.ToString() != "")
            {
                PunishmentB.SelectedItem = "None";
                PunishmentC.SelectedItem = "None";
            }


        }
      
        private void NoCh_CheckedChanged(object sender, EventArgs e)
        {
            if(NoCh.Checked == true )
            {
                YesCH.Checked = false;
            }
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            Home hi = new Home();
            hi.Show();
            this.Hide();
        }

        private void AcpT_TextChanged(object sender, EventArgs e)
        {
            if(AcpT.Text != "")
            {
                AcpT.Visible = true;
            }
            else if(AcBT.Text == "" && AcDT.Text == "")
            {
              
                AcDT.Text = "No sentence";
            }
            AcpT.Enabled = false;
         

        }

        private void AcBT_TextChanged(object sender, EventArgs e)
        {
            if (AcBT.Text != "")
            {
                AcBT.Visible = true;
            }
            AcBT.Enabled = false;
        }

        private void AcDT_TextChanged(object sender, EventArgs e)
        {
            if (AcDT.Text != "")
            {
                AcDT.Visible = true;
            }
            AcDT.Enabled = false;
        }
    }
}
