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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MyPro.Value < 100)
            {
                MyPro.Value += 1;
                Perlbl.Text = MyPro.Value.ToString() + "%";

            }
            else
            {
                timer1.Stop();
                Login lo = new Login();
                lo.Show();
                this.Hide();
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {

            timer1.Start();
        }
    }
}
