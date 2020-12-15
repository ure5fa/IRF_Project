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

namespace IRF_Project_URE5FA
{
    public partial class Form1 : Form
    {
        Database1Entities context = new Database1Entities();
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
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
    }
}
