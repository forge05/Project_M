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


        public frm_Spielfeld()
        {
            InitializeComponent();
            Container buttonContainer = new Container();
            foreach(Button b in pnl_alleFelder.Controls)
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
                }
                

            }
            else
            {
                f.BackColor = Color.Brown;
                if(f.content == Feld.Content.BLOCK)
                f.Text = "BLOCK";
                if ((int)f.content <= 3 && f.content != spielerContent)
                {
                    f.Text = "Gegner";
                }
                if (f.content == Feld.Content.GOAL)
                    f.Text = "Ziel!";
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
                        break;
                    case Feld.Content.GREEN:
                        f.BackColor = Color.Green;
                        break;
                    case Feld.Content.YELLOW:
                        f.BackColor = Color.Yellow;
                        break;
                    case Feld.Content.BLUE:
                        f.BackColor = Color.Blue;
                        break;
                    case Feld.Content.EMPTY:
                        f.BackColor = Color.Black;
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
            ziel.content = s.content;
            ziel.BackColor = s.BackColor;


            //if()                                      //startfelder disablen
            //s.Enabled = false;
            //else
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Feld myfield = (Feld)sender;
            int rueckzahl = Wurfzahl;
            if(myfield.BackColor != Color.Brown)
            rueckOptionenZuruecksetzen();
            if((int)myfield.content <= 3)
            {
                start = myfield;
                rueckOptionenPropagiere(myfield, rueckzahl, myfield, myfield.content);
            }
            if(myfield.BackColor == Color.Brown)
            {
                ruecken(myfield, start);
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
