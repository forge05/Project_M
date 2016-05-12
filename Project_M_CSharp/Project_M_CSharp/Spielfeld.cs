using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_M_CSharp
{
    public partial class frm_Spielfeld : Form
    {
        int Wurfzahl;
        Feld start;
        Boolean blockSetzen = false;
        Form frm;

        public frm_Spielfeld(Form myFrm)
        {
            frm = myFrm;
            InitializeComponent();
            Container buttonContainer = new Container();
            foreach(Feld b in pnl_alleFelder.Controls)
            {
                buttonContainer.Add(b);
            }
        }

        private void btn_wuerfeln_Click(object sender, EventArgs e)
        {
            Random Zahlenfee = new Random();
            Wurfzahl = Zahlenfee.Next(1, 7);
            lbl_wurfzahl.Text = Wurfzahl.ToString();
        }

        //private void btn_40_red_1_Click(object sender, EventArgs e)
        //{
        //    int GewuerfelteZahl = Wurfzahl;
        //    rueckOptionenPropagiere(btn_40_red_1);

        //}

        private void rueckOptionenPropagiere(Feld f, int spruenge, Feld altesFeld, Feld.Content spielerContent)
        {
            
            //Blöcke berücksichtigen
            //Gegnerische Figuren berücksichtigen 
            if(spruenge != 0)
            {
                if(f.content != Feld.Content.BLOCK)
                {
                    //if(f.content != spielerContent)                           //wird später beim Einfärben abgefangen, weil man ansonsten keine eigenen Figuren überspringen könnte
                    //{
                        foreach (Feld nachbar in f.nachbarn)
                        {
                            if (nachbar != altesFeld)                           //Vergleiche in foreach nur zu Beginn ineffiezient
                            {
                                if (nachbar.Entfernung_zum_Ziel < 40)           //sicherstellen, dass nicht zurück in die Startfelder gesprungen wird um Endlosschleife zu vermeiden
                                {
                                    rueckOptionenPropagiere(nachbar, spruenge - 1, f, spielerContent);
                                }
                            }

                        }
                    //}
                }
            }
            else
            {
                if(f.content != spielerContent)
                {
                    f.BackColor = Color.Brown;
                }
                if(f.content == Feld.Content.BLOCK)
                {
                    f.Text = "BLOCK";
                }
                if ((int)f.content <= 3 && f.content != spielerContent)
                {
                    f.Text = "Gegner";
                }
                if (f.content == Feld.Content.GOAL)
                {
                    f.Text = "Ziel!";
                }
            }
            //int Entfernung_zum_Ziel = f.Entfern_zum_Ziel;
            //foreach (Feld f_rueck in pnl_alleFelder.Controls)
            //{
            //    if((int)f_rueck.Tag == Entfernung_zum_Ziel - Wurfzahl)
            //    {
            //        f_rueck.BackColor = Color.Brown;
            //    }
            //}
        }
        private void rueckOptionenZuruecksetzen()
        {
            foreach (Feld f in pnl_alleFelder.Controls)
            {

                switch (f.content)
                {
                    case Feld.Content.RED:
                        f.BackColor = Color.Red;
                        f.Text = "";
                        break;
                    case Feld.Content.GREEN:
                        f.BackColor = Color.Green;
                        f.Text = "";
                        break;
                    case Feld.Content.YELLOW:
                        f.BackColor = Color.Yellow;
                        f.Text = "";
                        break;
                    case Feld.Content.BLUE:
                        f.BackColor = Color.Blue;
                        f.Text = "";
                        break;
                    case Feld.Content.EMPTY:
                        f.BackColor = Color.Black;
                        f.Text = "";
                        break;
                    case Feld.Content.BLOCK:
                        f.BackColor = Color.White;
                        f.Text = "";
                        break;
                    case Feld.Content.GOAL:
                        f.BackColor= Color.Fuchsia;
                        break;
                }
            }
        }

        private void ruecken(Feld ziel, Feld s)
        {
            Feld.Content Ursprungscontent = ziel.content;
            ziel.content = s.content;
            ziel.BackColor = s.BackColor;

            if (s.Entfernung_zum_Ziel == 40)                                      //startfelder disablen
                s.Enabled = false;                                                  //nachher nochmal enablen
            else
            {
                s.content = Feld.Content.EMPTY;
                s.BackColor = Color.Black;
            }

            rueckOptionenZuruecksetzen();

            //if(Ursprungscontent == Feld.Content.BLOCK)
            //{
                
            //}

            switch(Ursprungscontent)
            {
                case Feld.Content.BLOCK:
                    blockSetzen = true;
                    break;
                case Feld.Content.RED:
                    schlagen(Ursprungscontent);
                    break;
                case Feld.Content.GREEN:
                    schlagen(Ursprungscontent);
                    break;
                case Feld.Content.YELLOW:
                    schlagen(Ursprungscontent);
                    break;
                case Feld.Content.BLUE:
                    schlagen(Ursprungscontent);
                    break;
            }
        }

        private void schlagen(Feld.Content c)
        {
            foreach(Feld f in pnl_alleFelder.Controls)
            {
                if(f.Entfernung_zum_Ziel == 40)
                {
                    if(f.content == c)
                    {
                        if(!f.Enabled)
                        {
                            f.Enabled = true;
                            break;
                        }
                    }
                }
            }
        }

        private void blockieren(Feld f)
        {
            f.content = Feld.Content.BLOCK;
            f.BackColor = Color.White;
            blockSetzen = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Feld myfield = (Feld)sender;
            
            int rueckzahl = Wurfzahl;

            if(!blockSetzen)
            {
                if (myfield.BackColor != Color.Brown)
                    rueckOptionenZuruecksetzen();
                if (myfield.BackColor == Color.Brown)
                {
                    ruecken(myfield, start);
                    //rueckOptionenZuruecksetzen();
                }
                else if ((int)myfield.content <= 3)
                {
                    start = myfield;
                    rueckOptionenPropagiere(myfield, rueckzahl, null, myfield.content);
                }
                
            }
            else
            {
                if(myfield.content == Feld.Content.EMPTY)
                {
                    blockieren(myfield);
                }
            }
            



            //foreach(Button b in myfield.nachbarn)
            //{
            //    if(b.BackColor == Color.Brown)
            //    {
            //        b.BackColor = Color.Black;
            //        myfield.BackColor = Color.Black;
            //    }
            //    else
            //    {
            //        b.BackColor = Color.Brown;
            //        myfield.BackColor = Color.Brown;
            //    }
            //}
        }

        private void frm_Spielfeld_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }





        //private void btn_24_1_Click(object sender, EventArgs e)
        //{
        //    btn_24_1.BackColor = Color.Brown;
        //    foreach (Button b in btn_24_1.nachbarn)
        //    {
        //        b.BackColor = Color.Brown;
        //    }
        //}

        //private void btn_0_ziel_Click(object sender, EventArgs e)
        //{
        //    btn_0_ziel.BackColor = Color.Brown;
        //    foreach (Button b in btn_0_ziel.nachbarn)
        //    {
        //        b.BackColor = Color.Brown;
        //    }
        //}

        //private void btn_1_Click(object sender, EventArgs e)
        //{
        //    btn_1.BackColor = Color.Brown;
        //    foreach (Button b in btn_1.nachbarn)
        //    {
        //        b.BackColor = Color.Brown;
        //    }
        //}

        //private void btn_2_1_Click(object sender, EventArgs e)
        //{
        //    btn_2_1.BackColor = Color.Brown;
        //    foreach (Button b in btn_2_1.nachbarn)
        //    {
        //        b.BackColor = Color.Brown;
        //    }
        //}

        //private void btn_2_2_Click(object sender, EventArgs e)
        //{
        //    btn_2_2.BackColor = Color.Brown;
        //    foreach (Button b in btn_2_2.nachbarn)
        //    {
        //        b.BackColor = Color.Brown;
        //    }
        //}

        //private void btn_3_1_Click(object sender, EventArgs e)
        //{
        //    btn_3_1.BackColor = Color.Brown;
        //    foreach (Button b in btn_3_1.nachbarn)
        //    {
        //        b.BackColor = Color.Brown;
        //    }
        //}
    }
}
