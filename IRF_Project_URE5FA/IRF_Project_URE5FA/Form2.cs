using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace IRF_Project_URE5FA
{
    public partial class Form2 : Form
    {
        Database1Entities context = new Database1Entities();
        public Form2()
        {
            InitializeComponent();
            EmberListBox.DisplayMember = "Nev";
        }
        private void Emberlistazas()
        {
            var fog = from x in context.Ember
                      where x.Nev.Contains(EmberTextBox.Text)
                      select x;
            EmberListBox.DataSource = fog.ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet11.Etelek' table. You can move, or remove it, as needed.
            this.etelekTableAdapter.Fill(this.database1DataSet11.Etelek);
            // TODO: This line of code loads data into the 'database1DataSet10.Ember' table. You can move, or remove it, as needed.
            this.emberTableAdapter.Fill(this.database1DataSet10.Ember);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnergiaAB f1 = new EnergiaAB();
            f1.Show();
            this.Hide();
        }

        private void EmberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tartalom = from x in context.EmberEtel
                           where x.EmberFK == ((Ember)EmberListBox.SelectedItem).EmberID
                           select new
                           {
                               x.Etelek.EtelId,
                               x.Etelek.KategoriaFK,
                               x.Etelek.EnergiaFK,
                               x.Etelek.Nev,
                               x.Etelek.Szarmazas,
                               x.Etelek.Ar,

                           };
            dataGridView1.DataSource = tartalom.ToList();
            var összeg = (from x in tartalom select x.Ar).Sum();
            label2.Text = "A kiválasztot személy a héten " + összeg.ToString() + " Ft értékű összeget költött elemózsiára.";
            var ö = (from x in tartalom select x.EtelId).Count();
            label3.Text = "A kiválasztot személy a héten " + ö.ToString() + " fajta ételt evett";

            chart1.DataSource = dataGridView1.DataSource;
            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Nev";
            series.YValueMembers = "Ar";
            series.BorderWidth = 2;
            var legend = chart1.Legends[0];
            legend.Enabled = false;

            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = true;
            chartArea.AxisY.IsStartedFromZero = true;

        }



        private void EmberTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
            Emberlistazas();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() != DialogResult.OK) return;

            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {

                foreach (var s in context.Etelek)
                {

                    sw.Write(s.EtelId.ToString());
                    sw.Write(";");
                    sw.Write(s.KategoriaFK.ToString());
                    sw.Write(";");
                    sw.Write(s.EnergiaFK.ToString());
                    sw.Write(";");
                    sw.Write(s.Nev);
                    sw.Write(";");
                    sw.Write(s.Szarmazas);
                    sw.Write(";");
                    sw.Write(s.Ar.ToString());
                    sw.WriteLine();
                }
            }
        }

        private void EmberTextBox_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex("^[A-Za-z]{1,}(| [A-Za-z]{1,})$");
            if (r.IsMatch(EmberTextBox.Text))
            {
                e.Cancel = false;
                EmberTextBox.BackColor = Color.Green;
                errorProvider1.SetError(EmberTextBox, "");
            }
            else
            {
                errorProvider1.SetError(EmberTextBox, "A név mező nem tartalmazhat számot!");
                e.Cancel = true;
                EmberTextBox.BackColor = Color.Red;
            }
        }
    }
}
