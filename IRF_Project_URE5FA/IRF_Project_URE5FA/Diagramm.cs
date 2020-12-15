using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_URE5FA
{
    public partial class Diagramm : Form
    {
        public Diagramm()
        {
            InitializeComponent();
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
    }
}
