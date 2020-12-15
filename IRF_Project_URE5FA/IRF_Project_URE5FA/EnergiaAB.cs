using IRF_Project_URE5FA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IRF_Project_URE5FA
{
    public partial class EnergiaAB : Form
    {
        
        Database1Entities context = new Database1Entities();
        public EnergiaAB()
        {
            InitializeComponent();
            EtelListbox.DisplayMember = "Nev";
        }
        private void Etellistazas()
        {
            var fog = from x in context.Etelek
                      where x.Nev.Contains(EtelTextBox.Text)
                      select x;
            EtelListbox.DataSource = fog.ToList();
        }

       
        private void EnergiaAB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet4.Energia' table. You can move, or remove it, as needed.
            this.energiaTableAdapter.Fill(this.database1DataSet4.Energia);

        }

        private void EtelListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tartalom = from x in context.Energia
                           where x.EnergiaID == ((Etelek)EtelListbox.SelectedItem).EnergiaFK
                           select new
                           {
                               x.EnergiaID,
                               x.KCAL,
                               x.telitett_zsirsav,
                               x.szenhidrat,
                               x.cukor,
                               x.feherje,
                               x.so,
                               x.zsir
                           };
            dataGridView1.DataSource = tartalom.ToList();

            

            chart1.DataSource = dataGridView1.DataSource;
            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Bar;
            series.XValueMember = "EnergiaID";
            series.YValueMembers = "Szenhidrat";
            series.BorderWidth = 2;
            var legend = chart1.Legends[0];
            legend.Enabled = false;

            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = true;
            chartArea.AxisY.IsStartedFromZero = true;

            chart2.DataSource = dataGridView1.DataSource;
            var series2 = chart2.Series[0];
            series2.ChartType = SeriesChartType.Bar;
            series2.XValueMember = "EnergiaID";
            series2.YValueMembers = "zsir";
            series2.BorderWidth = 2;
            var legend2 = chart2.Legends[0];
            legend2.Enabled = false;

            var chartArea2 = chart2.ChartAreas[0];
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = true;
            chartArea2.AxisY.IsStartedFromZero = true;

        }
        private void chart()
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Etellistazas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {

                foreach (var s in context.Energia)
                {

                    sw.Write(s.KCAL.ToString());
                    sw.Write(";");
                    sw.Write(s.telitett_zsirsav.ToString());
                    sw.Write(";");
                    sw.Write(s.szenhidrat.ToString());
                    sw.Write(";");
                    sw.Write(s.cukor.ToString());
                    sw.Write(";");
                    sw.Write(s.feherje.ToString());
                    sw.Write(";");
                    sw.Write(s.so.ToString());
                    sw.Write(";");
                    sw.Write(s.zsir.ToString());
                    sw.WriteLine();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Diagramm f2 = new Diagramm();
            f2.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
