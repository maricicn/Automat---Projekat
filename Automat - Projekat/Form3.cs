using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automat___Projekat
{
    public partial class Form3 : Form
    {
        public static Form3 form3instance;
        public Label l4;
        public Label l5;
        public Label l6;
        public Label l7;
        public Label l8;
        public Label l9;
        public Label l10;
        public Label l11;
        public Form3()
        {
            InitializeComponent();
            form3instance = this;
            l4 = label4; l5 = label5; l6 = label6; l7 = label7; l8 = label8; l9 = label9; l10 = label10; l11 = label11;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kasa.novcanice[0] = Kasa.novcanice[0] + 1;
            label4.Text = Convert.ToString(Kasa.novcanice[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kasa.novcanice[1] = Kasa.novcanice[1] + 1;
            label5.Text = Convert.ToString(Kasa.novcanice[1]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kasa.novcanice[2] = Kasa.novcanice[2] + 1;
            label6.Text = Convert.ToString(Kasa.novcanice[2]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kasa.novcanice[3] = Kasa.novcanice[3] + 1;
            label7.Text = Convert.ToString(Kasa.novcanice[3]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kasa.novcanice[4] = Kasa.novcanice[4] + 1;
            label8.Text = Convert.ToString(Kasa.novcanice[4]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kasa.novcanice[5] = Kasa.novcanice[5] + 1;
            label9.Text = Convert.ToString(Kasa.novcanice[5]);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kasa.novcanice[6] = Kasa.novcanice[6] + 1;
            label10.Text = Convert.ToString(Kasa.novcanice[6]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kasa.novcanice[7] = Kasa.novcanice[7] + 1;
            label11.Text = Convert.ToString(Kasa.novcanice[7]);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Kasa.novcanice[0] > 0)
            {
                Kasa.novcanice[0] = Kasa.novcanice[0] - 1;
                label4.Text = Convert.ToString(Kasa.novcanice[0]);
            }
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Kasa.novcanice[1] > 0)
            {
                Kasa.novcanice[1] = Kasa.novcanice[1] - 1;
                label5.Text = Convert.ToString(Kasa.novcanice[1]);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Kasa.novcanice[2] > 0)
            {
                Kasa.novcanice[2] = Kasa.novcanice[2] - 1;
                label6.Text = Convert.ToString(Kasa.novcanice[2]);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Kasa.novcanice[3] > 0)
            {
                Kasa.novcanice[3] = Kasa.novcanice[3] - 1;
                label7.Text = Convert.ToString(Kasa.novcanice[3]);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Kasa.novcanice[4] > 0)
            {
                Kasa.novcanice[4] = Kasa.novcanice[4] - 1;
                label8.Text = Convert.ToString(Kasa.novcanice[4]);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Kasa.novcanice[5] > 0)
            {
                Kasa.novcanice[5] = Kasa.novcanice[5] - 1;
                label9.Text = Convert.ToString(Kasa.novcanice[5]);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (Kasa.novcanice[6] > 0)
            {
                Kasa.novcanice[6] = Kasa.novcanice[6] - 1;
                label10.Text = Convert.ToString(Kasa.novcanice[6]);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Kasa.novcanice[7] > 0)
            {
                Kasa.novcanice[7] = Kasa.novcanice[7] - 1;
                label11.Text = Convert.ToString(Kasa.novcanice[7]);
            }
        }
    }
}
