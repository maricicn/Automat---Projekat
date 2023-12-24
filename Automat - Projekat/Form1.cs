using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automat___Projekat
{
    
    public partial class Form1 : Form
    {
        public static Form1 form1instance;
        public PictureBox smoki1; public PictureBox smoki2; public PictureBox smoki3; public PictureBox smoki4; public PictureBox smoki5;
        public PictureBox cips1; public PictureBox cips2; public PictureBox cips3; public PictureBox cips4; public PictureBox cips5;
        public PictureBox bananica1; public PictureBox bananica2; public PictureBox bananica3; public PictureBox bananica4; public PictureBox bananica5;
        public PictureBox voda1; public PictureBox voda2; public PictureBox voda3; public PictureBox voda4; public PictureBox voda5;
        public PictureBox sw1; public PictureBox sw2; public PictureBox sw3; public PictureBox sw4; public PictureBox sw5;
        public Label l1;
        public Label l; public Label l2; public Label l3; public Label l4; public Label l5;
        public Label l6; public Label l7; public Label l8; public Label l9; public Label l10;
        public Label l11; public Label l12; public Label l13; public Label l14; public Label l15;
        public Label l16; public Label l17; public Label l18; public Label l19; public Label l20;
        public Label l21; public Label l22; public Label l23; public Label l24; public Label l25;
        public int br_ar;
        int[] kusur;

        public Form1()
        {
            InitializeComponent();
            form1instance = this;
            smoki1 = pictureBox1;smoki2 = pictureBox2;smoki3 = pictureBox3; smoki4 = pictureBox4; smoki5 = pictureBox5;
            cips1 = pictureBox6; cips2 = pictureBox7; cips3 = pictureBox8; cips4 = pictureBox9; cips5 = pictureBox10;
            bananica1 = pictureBox11; bananica2 = pictureBox12; bananica3 = pictureBox13; bananica4 = pictureBox14; bananica5 = pictureBox15;
            voda1 = pictureBox16; voda2 = pictureBox17; voda3 = pictureBox18; voda4 = pictureBox19; voda5 = pictureBox20;
            sw1 = pictureBox21; sw2 = pictureBox22; sw3 = pictureBox23; sw4 = pictureBox24;sw5 = pictureBox25;
            l1 = labelND;
            l = label1; l2 = label2; l3 = label3; l4 = label4; l5 = label5; l6 = label6; l7 = label7; l8 = label8; l9 = label9; l10 = label10; l11 = label11;
            l12 = label12; l13 = label13; l14 = label14; l15 = label15; l16 = label16; l17 = label17; l18 = label18; l19 = label19; l20 = label20; l21 = label21;
            l22 = label22; l23 = label23; l24 = label24; l25 = label25;
            kusur = new int[8];
            DateTime today = DateTime.Now;
            DateTime pom = today.AddDays(5);
            for (int i = 0; i < 5; i++) 
            {
                RedSmoki.Add(new Artikal(1, "Smoki", 50, pom));
                RedCips.Add(new Artikal(2, "Cips", 100, pom));
                RedBananica.Add(new Artikal(3, "Bananica", 20, pom));
                RedVoda.Add(new Artikal(4, "Voda", 75));
                RedSchweppes.Add(new Artikal(5, "Schweppes", 110, pom));
                br_ar += 5;
                
            }
            
            for (int i = 0; i < 8; i++)
            {
                Kasa.novcanice[i] = 1;
            } 
            if (RedSmoki.Count + RedCips.Count + RedVoda.Count + RedBananica.Count + RedSchweppes.Count == 25)
            {
                btnSmokiDodaj.Enabled = false;
            }



        }
        public void btnDodaj_Disable ()
        {
            if (RedSmoki.Count + RedCips.Count + RedVoda.Count + RedBananica.Count + RedSchweppes.Count == 25)
            {
                btnSmokiDodaj.Enabled = false;
            }
        }
        public void btnDodaj_Enable()
        {
            btnSmokiDodaj.Enabled = true;
        }
        public void label1Enable()
        {
            label1.Visible = true;
        }
        public void label2Enable()
        {
            label2.Visible = true;
        }
        public void label3Enable()
        {
            label3.Visible = true;
        }
        public void label4Enable()
        {
            label4.Visible = true;
        }
        public void label5Enable()
        {
            label5.Visible = true;
        }
        public void label6Enable()
        {
            label6.Visible = true;
        }
        public void label7Enable()
        {
            label7.Visible = true;
        }
        public void label8Enable()
        {
            label8.Visible = true;
        }
        public void label9Enable()
        {
            label9.Visible = true;
        }
        public void label10Enable()
        {
            label10.Visible = true;
        }
        public void label11Enable()
        {
            label11.Visible = true;
        }
        public void label12Enable()
        {
            label12.Visible = true;
        }
        public void label13Enable()
        {
            label13.Visible = true;
        }
        public void label14Enable()
        {
            label14.Visible = true;
        }
        public void label15Enable()
        {
            label15.Visible = true;
        }
        public void label16Enable()
        {
            label16.Visible = true;
        }
        public void label17Enable()
        {
            label17.Visible = true;
        }
        public void label18Enable()
        {
            label18.Visible = true;
        }
        public void label19Enable()
        {
            label19.Visible = true;
        }
        public void label20Enable()
        {
            label20.Visible = true;
        }
        public void label21Enable()
        {
            label21.Visible = true;
        }
        public void label22Enable()
        {
            label22.Visible = true;
        }
        public void label23Enable()
        {
            label23.Visible = true;
        }
        public void label24Enable()
        {
            label24.Visible = true;
        }
        public void label25Enable()
        {
            label25.Visible = true;
        }
        bool vlasnik = false;
        public List<Artikal> RedSmoki = new List<Artikal>();
        public List<Artikal> RedCips = new List<Artikal>();
        public List<Artikal> RedBananica = new List<Artikal>();
        public List<Artikal> RedVoda = new List<Artikal>();
        public List<Artikal> RedSchweppes = new List<Artikal>();
        

        private void button1_Click(object sender, EventArgs e)
        {
            Kasa.kredit++;
            txtUnetiNovac.Text = Convert.ToString(Kasa.kredit);
            Kasa.novcanice[0] += 1;
            labelKusur.Visible = false;
            labelND.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kasa.kredit += 2;
            txtUnetiNovac.Text = Convert.ToString(Kasa.kredit);
            Kasa.novcanice[1] += 1;
            labelKusur.Visible = false;
            labelND.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kasa.kredit += 5;
            txtUnetiNovac.Text = Convert.ToString(Kasa.kredit);
            Kasa.novcanice[2] += 1;
            labelKusur.Visible = false;
            labelND.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kasa.kredit += 10;
            txtUnetiNovac.Text = Convert.ToString(Kasa.kredit);
            Kasa.novcanice[3] += 1;
            labelKusur.Visible = false;
            labelND.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kasa.kredit += 20;
            txtUnetiNovac.Text = Convert.ToString(Kasa.kredit);
            Kasa.novcanice[4] += 1;
            labelKusur.Visible = false;
            labelND.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kasa.kredit += 50;
            txtUnetiNovac.Text = Convert.ToString(Kasa.kredit);
            Kasa.novcanice[5] += 1;
            labelKusur.Visible = false;
            labelND.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Kasa.kredit += 100;
            txtUnetiNovac.Text = Convert.ToString(Kasa.kredit);
            Kasa.novcanice[6] += 1;
            labelKusur.Visible = false;
            labelND.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Kasa.kredit += 200;
            txtUnetiNovac.Text = Convert.ToString(Kasa.kredit);
            Kasa.novcanice[7] += 1;
            labelKusur.Visible = false;
            labelND.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSmokiDodaj_Click(object sender, EventArgs e)
        {
            Form2 dodaj = new Form2();
            labelND.Visible = false;
            dodaj.Show();
            if(RedSmoki.Count < 5)
            {
                Form2.form2instance.rB1_Enable();
                
            }
            if (RedCips.Count < 5)
            {
                Form2.form2instance.rB2_Enable();
            }
            if (RedBananica.Count < 5)
            {
                Form2.form2instance.rB3_Enable();
            }
            if (RedVoda.Count < 5)
            {
                Form2.form2instance.rB4_Enable();
            }
            if (RedSchweppes.Count < 5)
            {
                Form2.form2instance.rB5_Enable();
            }
            btnSmokiDodaj.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtKupovina.Text = "1";
            labelND.Visible = false;
            labelKusur.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtKupovina.Text = "2";
            labelND.Visible = false;
            labelKusur.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtKupovina.Text = "3";
            labelND.Visible = false;
            labelKusur.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtKupovina.Text = "4";
            labelND.Visible = false;
            labelKusur.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtKupovina.Text = "5";
            labelND.Visible = false;
            labelKusur.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            string broj = txtKupovina.Text;
            switch (broj)
            {
                case "1":       
                    if (RedSmoki.Count != 0)
                    {
                        if (Kasa.kredit >= RedSmoki[0].cena)
                        {
                            Kasa.kredit -= RedSmoki[0].cena;
                            txtUnetiNovac.Text = Convert.ToString(Kasa.kredit);
                            RedSmoki.RemoveAt(0); br_ar--;
                            labelND.Visible = false;
                            btnSmokiDodaj.Enabled = true;
                            pictureBox30.Visible = false; pictureBox29.Visible = false; pictureBox28.Visible = false; pictureBox27.Visible = false; pictureBox26.Visible = true;
                            label1.Text = label2.Text; label2.Text = label3.Text; label3.Text = label4.Text; label4.Text = label5.Text;
                            label1.BackColor = label2.BackColor; label2.BackColor = label3.BackColor; label3.BackColor = label4.BackColor; label4.BackColor = label5.BackColor;
                            if (pictureBox5.Visible == true)
                            {
                                pictureBox5.Visible = false;
                                label5.Visible = false;
                            }
                            else
                            {
                                if (pictureBox4.Visible == true)
                                {
                                    pictureBox4.Visible = false;
                                    label4.Visible = false;
                                }
                                else if (pictureBox3.Visible == true)
                                {
                                    pictureBox3.Visible = false;
                                    label3.Visible = false;
                                }
                                else if (pictureBox2.Visible == true)
                                {
                                    pictureBox2.Visible = false;
                                    label2.Visible = false;
                                }
                                else
                                {
                                    pictureBox1.Visible = false;
                                    label1.Visible = false;
                                }
                            }

                        }
                        else
                        {
                            labelND.Visible = true;
                            labelND.Text = "Nemate dovoljno novca za smoki!";
                        }
                    }
                    else
                    {
                        labelND.Visible = true;
                        labelND.Text = "Nemamo vise smokija na raspolaganju!"; 
                    }
                break;
                case "2":
                    if (RedCips.Count != 0)
                    {
                        if (Kasa.kredit >= RedCips[0].cena)
                        {
                            Kasa.kredit -= RedCips[0].cena;
                            txtUnetiNovac.Text = Convert.ToString(Kasa.kredit);
                            RedCips.RemoveAt(0); br_ar--;
                            labelND.Visible = false;
                            btnSmokiDodaj.Enabled = true;
                            label6.Text = label7.Text; label7.Text = label8.Text; label8.Text = label9.Text; label9.Text = label10.Text;
                            label6.BackColor = label7.BackColor; label7.BackColor = label8.BackColor; label8.BackColor = label9.BackColor; label9.BackColor = label10.BackColor;
                            pictureBox30.Visible = false; pictureBox29.Visible = false; pictureBox28.Visible = false; pictureBox27.Visible = true; pictureBox26.Visible = false;
                            if (pictureBox10.Visible == true)
                            {
                                pictureBox10.Visible = false;
                                label10.Visible = false;
                            }
                            else
                            {
                                if (pictureBox9.Visible == true)
                                {
                                    pictureBox9.Visible = false;
                                    label9.Visible = false;
                                }
                                else if (pictureBox8.Visible == true)
                                {
                                    pictureBox8.Visible = false;
                                    label8.Visible = false;
                                }
                                else if (pictureBox7.Visible == true)
                                {
                                    pictureBox7.Visible = false;
                                    label7.Visible = false;
                                }
                                else
                                {
                                    pictureBox6.Visible = false;
                                    label6.Visible = false;
                                }
                            }

                        }

                        else
                        {
                            labelND.Visible = true;
                            labelND.Text = "Nemate dovoljno novca za cips!";
                        }
                    }
                    else
                    {
                        labelND.Visible = true;
                        labelND.Text = "Nemamo vise cipsa na raspolaganju!";
                    }
                    break;
                case "3":
                    if (RedBananica.Count != 0)
                    {
                        if (Kasa.kredit >= RedBananica[0].cena)
                        {
                            Kasa.kredit -= RedBananica[0].cena;
                            txtUnetiNovac.Text = Convert.ToString(Kasa.kredit);
                            RedBananica.RemoveAt(0); br_ar--;
                            labelND.Visible = false;
                            btnSmokiDodaj.Enabled = true;
                            label11.Text = label12.Text; label12.Text = label13.Text; label13.Text = label14.Text; label14.Text = label15.Text;
                            label11.BackColor = label12.BackColor; label12.BackColor = label13.BackColor; label13.BackColor = label14.BackColor; label14.BackColor = label15.BackColor;
                            pictureBox30.Visible = false; pictureBox29.Visible = false; pictureBox28.Visible = true; pictureBox27.Visible = false; pictureBox26.Visible = false;
                            if (pictureBox15.Visible == true)
                            {
                                pictureBox15.Visible = false;
                                label15.Visible = false;
                            }
                            else
                            {
                                if (pictureBox14.Visible == true)
                                {
                                    pictureBox14.Visible = false;
                                    label14.Visible = false;
                                }
                                else if (pictureBox13.Visible == true)
                                {
                                    pictureBox13.Visible = false;
                                    label13.Visible = false;
                                }
                                else if (pictureBox12.Visible == true)
                                {
                                    pictureBox12.Visible = false;
                                    label12.Visible = false;
                                }
                                else
                                {
                                    pictureBox11.Visible = false;
                                    label11.Visible = false;
                                }
                            }

                        }
                        else
                        {
                            labelND.Visible = true;
                            labelND.Text = "Nemate dovoljno novca za bananicu!";
                        }
                    }
                    else
                    {
                        labelND.Visible = true;
                        labelND.Text = "Nemamo vise bananica na raspolaganju!";
                    }
                    break;
                case "4":
                    if (RedVoda.Count != 0)
                    {
                        if (Kasa.kredit >= RedVoda[0].cena)
                        {
                            Kasa.kredit -= RedVoda[0].cena;
                            txtUnetiNovac.Text = Convert.ToString(Kasa.kredit);
                            RedVoda.RemoveAt(0); br_ar--;
                            labelND.Visible = false;
                            btnSmokiDodaj.Enabled = true;
                            label16.Text = label17.Text; label17.Text = label18.Text; label18.Text = label19.Text; label19.Text = label20.Text;
                            label16.BackColor = label17.BackColor; label17.BackColor = label18.BackColor; label18.BackColor = label19.BackColor; label19.BackColor = label20.BackColor;
                            pictureBox30.Visible = false; pictureBox29.Visible = true; pictureBox28.Visible = false; pictureBox27.Visible = false; pictureBox26.Visible = false;
                            if (pictureBox20.Visible == true)
                            {
                                pictureBox20.Visible = false;
                                label20.Visible = false;
                            }
                            else
                            {
                                if (pictureBox19.Visible == true)
                                {
                                    pictureBox19.Visible = false;
                                    label19.Visible = false;
                                }
                                else if (pictureBox18.Visible == true)
                                {
                                    pictureBox18.Visible = false;
                                    label18.Visible = false;
                                }
                                else if (pictureBox17.Visible == true)
                                {
                                    pictureBox17.Visible = false;
                                    label17.Visible = false;
                                }
                                else
                                {
                                    pictureBox16.Visible = false;
                                    label16.Visible = false;
                                }
                            }

                        }
                        else
                        {
                            labelND.Visible = true;
                            labelND.Text = "Nemate dovoljno novca za vodu!";
                        }
                    }
                    else
                    {
                        labelND.Visible = true;
                        labelND.Text = "Nemamo vise voda na raspolaganju!";
                    }
                    break;
                case "5":
                    if (RedSchweppes.Count != 0)
                    {
                        if (Kasa.kredit >= RedSchweppes[0].cena)
                        {
                            Kasa.kredit -= RedSchweppes[0].cena;
                            txtUnetiNovac.Text = Convert.ToString(Kasa.kredit);
                            RedSchweppes.RemoveAt(0); br_ar--;
                            labelND.Visible = false;
                            btnSmokiDodaj.Enabled = true;
                            label21.Text = label22.Text; label22.Text = label23.Text; label23.Text = label24.Text; label24.Text = label25.Text;
                            label21.BackColor = label22.BackColor; label22.BackColor = label23.BackColor; label23.BackColor = label24.BackColor; label24.BackColor = label25.BackColor;
                            pictureBox30.Visible = true; pictureBox29.Visible = false; pictureBox28.Visible = false; pictureBox27.Visible = false; pictureBox26.Visible = false;
                            if (pictureBox25.Visible == true)
                            {
                                pictureBox25.Visible = false;
                                label25.Visible = false;
                            }
                            else
                            {
                                if (pictureBox24.Visible == true)
                                {
                                    pictureBox24.Visible = false;
                                    label24.Visible = false;
                                }
                                else if (pictureBox23.Visible == true)
                                {
                                    pictureBox23.Visible = false;
                                    label23.Visible = false;
                                }
                                else if (pictureBox22.Visible == true)
                                {
                                    pictureBox22.Visible = false;
                                    label22.Visible = false;
                                }
                                else
                                {
                                    pictureBox21.Visible = false;
                                    label21.Visible = false;
                                }
                            }

                        }
                        else
                        {
                            labelND.Visible = true;
                            labelND.Text = "Nemate dovoljno novca za schweppes!";
                        }
                    }
                    else
                    {
                        labelND.Visible = true;
                        labelND.Text = "Nemamo vise schweppsova na raspolaganju!";
                    }
                    break;
            }
            labelKusur.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            Form3.form3instance.l4.Text = Convert.ToString(Kasa.novcanice[0]);
            Form3.form3instance.l5.Text = Convert.ToString(Kasa.novcanice[1]);
            Form3.form3instance.l6.Text = Convert.ToString(Kasa.novcanice[2]);
            Form3.form3instance.l7.Text = Convert.ToString(Kasa.novcanice[3]);
            Form3.form3instance.l8.Text = Convert.ToString(Kasa.novcanice[4]);
            Form3.form3instance.l9.Text = Convert.ToString(Kasa.novcanice[5]);
            Form3.form3instance.l10.Text = Convert.ToString(Kasa.novcanice[6]);
            Form3.form3instance.l11.Text = Convert.ToString(Kasa.novcanice[7]);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int[] kusur = new int[Convert.ToInt32(Kasa.kredit) + 1];
            kusur[0] = -1;
            for (int i = 0; i < Kasa.novcanice.Length; i++)
            {
                for (int j = kusur.Length - 1; j >= 0; j--)
                {
                    for (int k = 1; k < Kasa.novcanice[i] + 1; k++)
                    {
                        if (kusur[j] != 0)
                        {
                            if (j + k * Kasa.dostupneNovcanice[i] >= kusur.Length) continue;
                            kusur[j + k * Kasa.dostupneNovcanice[i]] = i + 1;
                        }
                    }
                }
            }
            double iznos = Kasa.kredit;
            int current = kusur.Length - 1;
            while (kusur[current] != -1)
            {
                if (kusur[current] == 0)
                {
                    current--;
                    continue;
                }
                int pom = current;
                //MessageBox.Show(Novcanica.vrednosti[kusur[pom] - 1].ToString());
                current -= Kasa.dostupneNovcanice[kusur[pom] - 1];
                Kasa.kredit -= Kasa.dostupneNovcanice[kusur[pom] - 1];
                Kasa.novcanice[kusur[pom] - 1]--;
            }
            txtUnetiNovac.Text = Kasa.kredit.ToString();
            iznos = iznos - Kasa.kredit;
            labelND.Visible = false;
            labelKusur.Visible = true;
            labelKusur.Text = iznos.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            labelND.Visible = false;
            textBox1.Visible = true;
            labelKusur.Visible = false;
            
            
        }

        private void btnKorisnik_Click(object sender, EventArgs e)
        {
            labelKusur.Visible = false;
            textBox1.Text = "";
            textBox1.Visible = false;
            btnSmokiDodaj.Visible = false;
            btnKasa.Visible = false;
            btnKorisnik.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (s == "sifra123")
            {
                btnSmokiDodaj.Visible = true;
                btnKasa.Visible = true;
                btnKorisnik.Visible = true;
            }
        }
    }
    public class Artikal
    {
        public int id;
        public string naziv;
        public DateTime rok;
        public double cena;
        
        public Artikal(int id, string naziv,double cena, DateTime rok)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
            this.rok = rok;
        }
        public Artikal(int id, string naziv, double cena)
        {
            this.id = id;
            this.naziv = naziv;
            this.cena = cena;
        }
        public double VratiCenu()
        {
            return cena;
        }
        public double CheckDiscount()
        {
            
            DateTime today = DateTime.Now;

            
            TimeSpan difference = rok - today;

            
            if (difference <= TimeSpan.FromDays(3))
            {
                
                double discountedPrice = cena * 0.8; 
                return discountedPrice;
            }

            
            return cena;
        }

    }
    internal class Kasa
    {
        public static double kredit = 0;
        public static int[] dostupneNovcanice = new int[8] { 1, 2, 5, 10, 20, 50 , 100, 200 };
        public static int[] novcanice = new int[8];
        public Kasa()
        {

        }
        public void IsprazniKasu()
        {
            kredit = 0;
            for(int i = 0; i<8; i++)
            {
                novcanice[i] = 0;
            }
        }
        
    }

}

