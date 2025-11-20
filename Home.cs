using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Offence_Decision
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void aDMINPROFILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oFFENCEREVIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nEWDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GULogin lu = new GULogin();
            lu.Show();
            this.Hide();
        }

        private void aCCOUNTSETTINGSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordUser us = new PasswordUser();
            us.Show();
            this.Hide();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Auth au = new Auth();
            au.Show();
            this.Hide();

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sETTINGSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            Auth3 au = new Auth3();
            au.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OffenceHistory hi = new OffenceHistory();
            hi.Show();
            this.Hide();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Auth5 at = new Auth5();
            at.Show();
        }

        private void bunifuButton1_Click_2(object sender, EventArgs e)
        {
            Auth4 fo = new Auth4();
              fo.Show();
        }

        private void ChestB_Click(object sender, EventArgs e)
        {
            Auth2 au = new Auth2();
            au.Show();
            
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Chart ca = new Chart();
            ca.Show();
            this.Hide();
        }
    } 
}
