using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Automat___Projekat
{
    internal partial class Form2 : Form
    {
        internal static Form2 form2instance;
        DateTime tvreme = DateTime.Now;
        public Form2()
        {
            InitializeComponent();
            form2instance = this;
            
        }
        private void Form2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Determine if text has changed in the textbox by comparing to original text.
            Form1.form1instance.btnDodaj_Enable();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        internal void rB1_Enable()
        {
            radioButton1.Enabled = true;
            pictureBox1.Enabled = true;
        }
        internal void rB2_Enable()
        {
            radioButton2.Enabled = true;
            pictureBox6.Enabled = true;
        }
        internal void rB3_Enable()
        {
            radioButton3.Enabled = true;
            pictureBox11.Enabled = true;
        }
        internal void rB4_Enable()
        {
            radioButton4.Enabled = true;
            pictureBox16.Enabled = true;
        }
        internal void rB5_Enable()
        {
            radioButton5.Enabled = true;
            pictureBox21.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = true;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = true;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            DateTime rok = dateTimePicker1.Value;
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked || radioButton4.Checked || radioButton5.Checked)
            {
                if (rok >= tvreme)
                {
                    if (radioButton1.Checked)
                    {
                        Artikal artikal = new Artikal(1, "smoki", 50, rok);
                        artikal.cena = artikal.CheckDiscount();
                        Artikal _artikal = new Artikal(1, "smoki", artikal.cena, rok);
                        Form1.form1instance.RedSmoki.Add(_artikal); Form1.form1instance.br_ar++;
                        if (Form1.form1instance.smoki1.Visible == false)
                        {
                            Form1.form1instance.smoki1.Visible = true;
                            Form1.form1instance.label1Enable();
                            Form1.form1instance.l.Text = Convert.ToString(artikal.cena);
                            if(artikal.cena != 50) Form1.form1instance.l.BackColor = Color.Red;

                        }
                        else
                        {
                            if (Form1.form1instance.smoki2.Visible == false)
                            {
                                Form1.form1instance.smoki2.Visible = true;
                                Form1.form1instance.label2Enable();
                                Form1.form1instance.l2.Text = Convert.ToString(artikal.cena);
                                if(artikal.cena != 50) Form1.form1instance.l2.BackColor = Color.Red;

                            }
                            else if (Form1.form1instance.smoki3.Visible == false)
                            {
                                Form1.form1instance.smoki3.Visible = true;
                                Form1.form1instance.label3Enable();
                                Form1.form1instance.l3.Text = Convert.ToString(artikal.cena);
                                if (artikal.cena != 50) Form1.form1instance.l3.BackColor = Color.Red;

                            }
                            else if (Form1.form1instance.smoki4.Visible == false)
                            {
                                Form1.form1instance.smoki4.Visible = true;
                                Form1.form1instance.label4Enable();
                                Form1.form1instance.l4.Text = Convert.ToString(artikal.cena);
                                if (artikal.cena != 50) Form1.form1instance.l4.BackColor = Color.Red;

                            }
                            else
                            {
                                Form1.form1instance.smoki5.Visible = true;
                                Form1.form1instance.label5Enable();
                                Form1.form1instance.l5.Text = Convert.ToString(artikal.cena);
                                if (artikal.cena != 50)  Form1.form1instance.l5.BackColor = Color.Red;

                            }
                        }
                        if (Form1.form1instance.br_ar == 25)
                        {
                            Form1.form1instance.btnDodaj_Disable();
                        }

                    }
                    else if (radioButton2.Checked)
                    {

                        Artikal artikal1 = new Artikal(2, "cips", 100, rok);
                        artikal1.cena = artikal1.CheckDiscount();
                        Artikal _artikal1 = new Artikal(2, "cips", artikal1.cena , rok);

                        Form1.form1instance.RedCips.Add(_artikal1); Form1.form1instance.br_ar++;
                        if (Form1.form1instance.cips1.Visible == false)
                        {
                            Form1.form1instance.cips1.Visible = true;
                            Form1.form1instance.label6Enable();
                            Form1.form1instance.l6.Text = Convert.ToString(artikal1.cena);
                            if (artikal1.cena != 100) Form1.form1instance.l6.BackColor = Color.Red;
                        }
                        else
                        {
                            if (Form1.form1instance.cips2.Visible == false)
                            {
                                Form1.form1instance.cips2.Visible = true;
                                Form1.form1instance.label7Enable();
                                Form1.form1instance.l7.Text = Convert.ToString(artikal1.cena);
                                if (artikal1.cena != 100) Form1.form1instance.l7.BackColor = Color.Red;

                            }
                            else if (Form1.form1instance.cips3.Visible == false)
                            {
                                Form1.form1instance.cips3.Visible = true;
                                Form1.form1instance.label8Enable();
                                Form1.form1instance.l8.Text = Convert.ToString(artikal1.cena);
                                if (artikal1.cena != 100) Form1.form1instance.l8.BackColor = Color.Red;
                            }
                            else if (Form1.form1instance.cips4.Visible == false)
                            {
                                Form1.form1instance.cips4.Visible = true;
                                Form1.form1instance.label9Enable();
                                Form1.form1instance.l9.Text = Convert.ToString(artikal1.cena);
                                if (artikal1.cena != 100) Form1.form1instance.l9.BackColor = Color.Red;
                            }
                            else
                            {
                                Form1.form1instance.cips5.Visible = true;
                                Form1.form1instance.label10Enable();
                                Form1.form1instance.l10.Text = Convert.ToString(artikal1.cena);
                                if (artikal1.cena != 100) Form1.form1instance.l10.BackColor = Color.Red;
                            }
                        }
                        if (Form1.form1instance.br_ar == 25)
                        {
                            Form1.form1instance.btnDodaj_Disable();
                        }


                    }
                    else if (radioButton3.Checked)
                    {
                        Artikal artikal2 = new Artikal(3, "bananica", 20, rok);
                        artikal2.cena = artikal2.CheckDiscount();
                        Artikal _artikal2 = new Artikal(3, "bananica", artikal2.cena, rok);
                        Form1.form1instance.RedBananica.Add(_artikal2); Form1.form1instance.br_ar++;
                        if (Form1.form1instance.bananica1.Visible == false)
                        {
                            Form1.form1instance.bananica1.Visible = true;
                            Form1.form1instance.label11Enable();
                            Form1.form1instance.l11.Text = Convert.ToString(artikal2.cena);
                            if (artikal2.cena != 20) Form1.form1instance.l11.BackColor = Color.Red;
                        }
                        else
                        {
                            if (Form1.form1instance.bananica2.Visible == false)
                            {
                                Form1.form1instance.bananica2.Visible = true;
                                Form1.form1instance.label12Enable();
                                Form1.form1instance.l12.Text = Convert.ToString(artikal2.cena);
                                if (artikal2.cena != 20) Form1.form1instance.l12.BackColor = Color.Red;
                            }
                            else if (Form1.form1instance.bananica3.Visible == false)
                            {
                                Form1.form1instance.bananica3.Visible = true;
                                Form1.form1instance.label13Enable();
                                Form1.form1instance.l13.Text = Convert.ToString(artikal2.cena);
                                if (artikal2.cena != 20) Form1.form1instance.l13.BackColor = Color.Red;
                            }
                            else if (Form1.form1instance.bananica4.Visible == false)
                            {
                                Form1.form1instance.bananica4.Visible = true;
                                Form1.form1instance.label14Enable();
                                Form1.form1instance.l14.Text = Convert.ToString(artikal2.cena);
                                if (artikal2.cena != 20) Form1.form1instance.l14.BackColor = Color.Red;
                            }
                            else
                            {
                                Form1.form1instance.bananica5.Visible = true;
                                Form1.form1instance.label15Enable();
                                Form1.form1instance.l15.Text = Convert.ToString(artikal2.cena);
                                if (artikal2.cena != 20) Form1.form1instance.l15.BackColor = Color.Red;
                            }
                        }
                        if (Form1.form1instance.br_ar == 25)
                        {
                            Form1.form1instance.btnDodaj_Disable();
                        }

                    }
                    else if (radioButton4.Checked)
                    {
                        Artikal artikal3 = new Artikal(4, "voda", 75, rok);
                        artikal3.cena = artikal3.CheckDiscount();
                        Artikal _artikal3 = new Artikal(4, "voda", artikal3.cena, rok);
                        Form1.form1instance.RedVoda.Add(_artikal3); Form1.form1instance.br_ar++;
                        if (Form1.form1instance.voda1.Visible == false)
                        {
                            Form1.form1instance.voda1.Visible = true;
                            Form1.form1instance.label16Enable();
                            Form1.form1instance.l16.Text = Convert.ToString(artikal3.cena);
                            if (artikal3.cena != 75) Form1.form1instance.l16.BackColor = Color.Red;
                        }
                        else
                        {
                            if (Form1.form1instance.voda2.Visible == false)
                            {
                                Form1.form1instance.voda2.Visible = true;
                                Form1.form1instance.label17Enable();
                                Form1.form1instance.l17.Text = Convert.ToString(artikal3.cena);
                                if (artikal3.cena != 75) Form1.form1instance.l17.BackColor = Color.Red;
                            }
                            else if (Form1.form1instance.voda3.Visible == false)
                            {
                                Form1.form1instance.voda3.Visible = true;
                                Form1.form1instance.label18Enable();
                                Form1.form1instance.l18.Text = Convert.ToString(artikal3.cena);
                                if (artikal3.cena != 75) Form1.form1instance.l18.BackColor = Color.Red;

                            }
                            else if (Form1.form1instance.voda4.Visible == false)
                            {
                                Form1.form1instance.voda4.Visible = true;
                                Form1.form1instance.label19Enable();
                                Form1.form1instance.l19.Text = Convert.ToString(artikal3.cena);
                                if (artikal3.cena != 75) Form1.form1instance.l19.BackColor = Color.Red;
                            }
                            else
                            {
                                Form1.form1instance.voda5.Visible = true;
                                Form1.form1instance.label20Enable();
                                Form1.form1instance.l20.Text = Convert.ToString(artikal3.cena);
                                if (artikal3.cena != 75) Form1.form1instance.l20.BackColor = Color.Red;
                            }
                        }
                        if (Form1.form1instance.br_ar == 25)
                        {
                            Form1.form1instance.btnDodaj_Disable();
                        }

                    }
                    else if (radioButton5.Checked)
                    {
                        Artikal artikal4 = new Artikal(5, "schweppes", 110, rok);
                        artikal4.cena = artikal4.CheckDiscount();
                        Artikal _artikal4 = new Artikal(5, "schweppes", artikal4.cena, rok);

                        Form1.form1instance.RedSchweppes.Add(_artikal4); Form1.form1instance.br_ar++;
                        if (Form1.form1instance.sw1.Visible == false)
                        {
                            Form1.form1instance.sw1.Visible = true;
                            Form1.form1instance.label21Enable();
                            Form1.form1instance.l21.Text = Convert.ToString(artikal4.cena);
                            if (artikal4.cena != 110) Form1.form1instance.l21.BackColor = Color.Red;
                        }
                        else
                        {
                            if (Form1.form1instance.sw2.Visible == false)
                            {
                                Form1.form1instance.sw2.Visible = true;
                                Form1.form1instance.label22Enable();
                                Form1.form1instance.l22.Text = Convert.ToString(artikal4.cena);
                                if (artikal4.cena != 110) Form1.form1instance.l22.BackColor = Color.Red;
                            }
                            else if (Form1.form1instance.sw3.Visible == false)
                            {
                                Form1.form1instance.sw3.Visible = true;
                                Form1.form1instance.label23Enable();
                                Form1.form1instance.l23.Text = Convert.ToString(artikal4.cena);
                                if (artikal4.cena != 110) Form1.form1instance.l23.BackColor = Color.Red;
                            }
                            else if (Form1.form1instance.sw4.Visible == false)
                            {
                                Form1.form1instance.sw4.Visible = true;
                                Form1.form1instance.label24Enable();
                                Form1.form1instance.l24.Text = Convert.ToString(artikal4.cena);
                                if (artikal4.cena != 110) Form1.form1instance.l24.BackColor = Color.Red;
                            }
                            else
                            {
                                Form1.form1instance.sw5.Visible = true;
                                Form1.form1instance.label25Enable();
                                Form1.form1instance.l25.Text = Convert.ToString(artikal4.cena);
                                if (artikal4.cena != 110) Form1.form1instance.l25.BackColor = Color.Red;
                            }
                        }
                        if (Form1.form1instance.br_ar == 25)
                        {
                            Form1.form1instance.btnDodaj_Disable();
                        }

                    }
                    if (Form1.form1instance.br_ar < 25) Form1.form1instance.btnDodaj_Enable();
                    Form1.form1instance.l1.Visible = false;
                    form2instance.Close();
                }
                else
                {
                    label3.Text = "Ne smete izabrati datum koji je prosao!";
                }
            }
            
        }
    }
}
