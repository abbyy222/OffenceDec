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
using System.Windows.Forms.DataVisualization.Charting;

namespace Offence_Decision
{
    public partial class Chart : Form
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + System.IO.Path.GetFullPath("OffenceSyst.mdf") + ";Integrated Security=True;");
        public Chart()
        {
            InitializeComponent();
            LoadChartData();
        }

        private void Chart_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void LoadChartData()
        {
            DataTable offencedata = GetCombinedOffenceData();
            DisplayChart(offencedata);

        }
        private DataTable GetCombinedOffenceData()
        {
            DataTable da = new DataTable();
            string Query = @"SELECT Offence, COUNT(*) AS OffenceCount FROM(SELECT CrimeA AS Offence FROM CrimeChest WHERE CrimeA <> 'None' UNION ALL SELECT CrimeB AS Offence FROM CrimeChest WHERE CrimeB <> 'None' UNION ALL SELECT CrimeD AS Offence FROM CrimeChest WHERE CrimeD <> 'None') As CombinedOffences GROUP BY Offence ";

            if (con.State != ConnectionState.Open)
            {
                 con.Open();
            }
            SqlCommand co = new SqlCommand(Query, con);
            SqlDataAdapter ad = new SqlDataAdapter(co);
            ad.Fill(da);
            return da;
        }
        private void DisplayChart(DataTable offenceData)
        {
            OffenceCh.Series.Clear();

            Series OffenceSeries = new Series("Offences")
            {
                XValueMember = "Offence",
                YValueMembers = "OffenceCount",
                ChartType = SeriesChartType.Column
            };
            OffenceCh.DataSource= offenceData;
            OffenceCh.Series.Add(OffenceSeries);

        }

    }
}
