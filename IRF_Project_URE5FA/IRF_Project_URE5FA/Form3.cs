using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_Project_URE5FA
{
    public partial class Form3 : Form
    {
        public Form3()
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

        private void BtnSubmit_Click(object sender, EventArgs e)
        {


            if (txtAnswer.Text == lblTotalNumber.Text)
            {
                lblMessage.Text = "Gratulálok! A megoldás valóban " + lblTotalNumber.Text + " volt.";
                timer1.Stop();
                btnRefresh.Visible = true;

            }

            else
            {
                lblMessage.Text = "Ezt sajnos elrontottad! A megoldás valójában " + lblTotalNumber.Text + " volt...";
                timer1.Stop();
                btnRefresh.Visible = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Random R = new Random();
            Random P = new Random();

            int maxR = 100;
            int maxP = 100;

            int numR = R.Next(2, maxR);
            int numP = P.Next(2, maxP);

            int numT = (numR + numP);

            lblFirstNumber.Text = numR.ToString();

            lblSecondNumber.Text = numP.ToString();

            lblTotalNumber.Text = numT.ToString();
            lblTotalNumber.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();

        }
        int TimeLeft = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeLeft > 0)
            {
                BtnSubmit.Enabled = true;
                TimeLeft = TimeLeft - 1;
                lblTime.Text = TimeLeft + " másodperc";
                btnRefresh.Visible = false;
            }
            else
            {
                BtnSubmit.Enabled = false;
                btnRefresh.Visible = true;
                lblMessage.Text = "Sajnálom, de lejárt az időd!";

            }
        }

       

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void txtAnswer_Validating(object sender, CancelEventArgs e)
        {
            Regex r = new Regex("^[0-9]{1,3}$");
            if (r.IsMatch(txtAnswer.Text))
            {
                errorProvider1.SetError(txtAnswer, "");
                e.Cancel = false;
                txtAnswer.BackColor = Color.Green;
            }
            else
            {
                errorProvider1.SetError(txtAnswer, "Max háromjegyű szám!");
                e.Cancel = true;
                txtAnswer.BackColor = Color.Red;
            }
        }
    }
}
