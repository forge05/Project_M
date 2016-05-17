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
        int PlayerAnzahl;
        string Playername1;
        string Playername2;
        string Playername3;
        string Playername4;
        Feld start;
        bool schonBlockGesetzt = false;
        //bool someoneWon = false;
        bool schongewuerfelt = false;
        //bool schongerueckt = false;
        Form frm;
        Form frm_E;
        Player s1;
        Player s2;
        Player s3;
        Player s4;
        Player yourTurn;
        Player sieger;
        Player[] allePlayer;

        public frm_Spielfeld(Form myFrm, Form myFrm_E)
        {
            frm = myFrm;
            frm_E = myFrm_E;
            erstellePlayer();
            InitializeComponent();
            spielerButtonsDisablen();
            //Container buttonContainer = new Container();
            //foreach(Feld b in pnl_alleFelder.Controls)
            //{
            //    buttonContainer.Add(b);
            //}
            //spielRoutine();
        }

        //private void spielRoutine()
        //{
            
        //}

        private void erstellePlayer()
        {
            bool CPU_RED = false;
            bool CPU_GREEN = false;
            bool CPU_YELLOW = false;
            bool CPU_BLUE = false;

            foreach(Control gb in frm_E.Controls)
            {
                if(gb is GroupBox)
                {
                    foreach (Control c in gb.Controls)
                    {
                        if (c is RadioButton)
                        {
                            RadioButton r = (RadioButton)c;
                            if (r.Checked)
                            {
                                PlayerAnzahl = Int32.Parse(r.Text);
                            }

                        }
                        else if (c is TextBox)
                        {
                            TextBox t = (TextBox)c;
                            if (t.Name == "txt_s1")
                            {
                                Playername1 = t.Text;
                            }
                            else if (t.Name == "txt_s2")
                            {
                                Playername2 = t.Text;
                            }
                            else if (t.Name == "txt_s3")
                            {
                                Playername3 = t.Text;
                            }
                            else if (t.Name == "txt_s4")
                            {
                                Playername4 = t.Text;
                            }
                        }
                        else if (c is CheckBox)
                        {
                            CheckBox cb = (CheckBox)c;
                            if (cb.Name == "ckb_cpu_s1")
                            {
                                if (cb.Checked)
                                {
                                    //erstelle CPU
                                    //s1 = new CPU(Playername1, Feld.Content.RED);
                                    CPU_RED = true;
                                }
                                //else
                                //{
                                //    //erstelle Spieler
                                //    //s1 = new Spieler(Playername1, Feld.Content.RED);
                                //}
                            }
                            else if (cb.Name == "ckb_cpu_s2")
                            {
                                if (cb.Checked)
                                {
                                    //erstelle CPU
                                    //s2 = new CPU(Playername2, Feld.Content.GREEN);
                                    CPU_GREEN = true;
                                }
                                //else
                                //{
                                //    //erstelle Spieler
                                //    //s2 = new Spieler(Playername2, Feld.Content.GREEN);
                                //}
                            }
                            else if (cb.Name == "ckb_cpu_s3")
                            {
                                if (cb.Checked && cb.Enabled)
                                {
                                    //erstelle CPU
                                    //s3 = new CPU(Playername3, Feld.Content.YELLOW);
                                    CPU_YELLOW = true;
                                }
                                //else if(cb.Enabled)
                                //{
                                //    //erstelle Spieler
                                //    //s3 = new Spieler(Playername3, Feld.Content.YELLOW);
                                //}
                            }
                            else if (cb.Name == "ckb_cpu_s4")
                            {
                                if (cb.Checked && cb.Enabled)
                                {
                                    //erstelle CPU
                                    //s4 = new CPU(Playername4, Feld.Content.BLUE);
                                    CPU_BLUE = true;
                                }
                                //else if(cb.Enabled)
                                //{
                                //    //erstelle Spieler
                                //    //s4 = new Spieler(Playername4, Feld.Content.BLUE);
                                //}
                            }

                        }
                    }
                }
                
                
            }
            if (CPU_RED)
            {
                s1 = new CPU(Playername1, Feld.Content.RED);
            }
            else
            {
                s1 = new Spieler(Playername1, Feld.Content.RED);
            }
            if (CPU_GREEN)
            {
                s2 = new CPU(Playername2, Feld.Content.GREEN);
            }
            else
            {
                s2 = new Spieler(Playername2, Feld.Content.GREEN);
            }
            if(PlayerAnzahl > 2)
            {
                if (CPU_YELLOW)
                {
                    s3 = new CPU(Playername3, Feld.Content.YELLOW);
                }
                else
                {
                    s3 = new Spieler(Playername3, Feld.Content.YELLOW);
                }
                if(PlayerAnzahl > 3)
                {
                    if (CPU_BLUE)
                    {
                        s4 = new CPU(Playername4, Feld.Content.BLUE);
                    }
                    else
                    {
                        s4 = new Spieler(Playername4, Feld.Content.BLUE);
                    }
                }
                
            }
            

            allePlayer = new Player[PlayerAnzahl];
            allePlayer[0] = s1;
            allePlayer[1] = s2;
            if (s3 != null)
            {
                allePlayer[2] = s3;
                if (s4 != null)
                {
                    allePlayer[3] = s4;
                }
            }
            yourTurn = s1;                                              //radiobutton auslesen, wer anfangen soll
        }

        private void btn_wuerfeln_Click(object sender, EventArgs e)
        {
            Random Zahlenfee = new Random();
            Wurfzahl = Zahlenfee.Next(1, 7);
            lbl_wurfzahl.Text = Wurfzahl.ToString();
            schongewuerfelt = true;
            btn_aussetzen.Enabled = true;
            btn_wuerfeln.Enabled = false;
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
                if ((int)f.content <= (PlayerAnzahl - 1) && f.content != spielerContent)
                {
                    f.Text = "Gegner";

                    switch (f.content)
                    {
                        case Feld.Content.RED:
                            f.ForeColor = Color.Red;
                            break;
                        case Feld.Content.GREEN:
                            f.ForeColor = Color.Green;
                            break;
                        case Feld.Content.YELLOW:
                            f.ForeColor = Color.Yellow;
                            break;
                        case Feld.Content.BLUE:
                            f.ForeColor = Color.Blue;
                            break;
                    }
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
                        f.ForeColor = Color.Black;
                        break;
                        
                    case Feld.Content.GREEN:
                        f.BackColor = Color.Green;
                        f.Text = "";
                        f.ForeColor = Color.Black;
                        break;
                    case Feld.Content.YELLOW:
                        f.BackColor = Color.Yellow;
                        f.Text = "";
                        f.ForeColor = Color.Black;
                        break;
                    case Feld.Content.BLUE:
                        f.BackColor = Color.Blue;
                        f.Text = "";
                        f.ForeColor = Color.Black;
                        break;
                    case Feld.Content.EMPTY:
                        f.BackColor = Color.Black;
                        f.Text = "";
                        f.ForeColor = Color.Black;
                        break;
                    case Feld.Content.BLOCK:
                        f.BackColor = Color.White;
                        f.Text = "";
                        f.ForeColor = Color.Black;
                        break;
                    case Feld.Content.GOAL:
                        f.BackColor= Color.Fuchsia;
                        break;
                }
            }
        }

        private void spielerButtonsDisablen()
        {
            foreach(Feld f in pnl_alleFelder.Controls)
            {
                if((int)f.content <= (PlayerAnzahl - 1) && f.Entfernung_zum_Ziel == 40)
                {
                    if(yourTurn.spielerFarbe != f.content)
                    {
                        f.Enabled = false;
                    }
                    else if(!f.schonGeruecktWorden)
                    {
                        f.Enabled = true;
                    }
                }
            }
        }

        private void ruecken(Feld ziel, Feld s)
        {
            Feld.Content Ursprungscontent = ziel.content;
            ziel.content = s.content;
            ziel.BackColor = s.BackColor;

            if (s.Entfernung_zum_Ziel == 40)
            {
                                                                        //startfelder disablen
                s.Enabled = false;                                      //nachher nochmal enablen
                s.schonGeruecktWorden = true;
            }
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
                    schonBlockGesetzt = true;
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
            //schongerueckt = true;
            //falls auf ziel gerückt wird, neues form öffnen mit nachricht; form schließen und menü öffnen
            if (btn_0_ziel.content != Feld.Content.GOAL)
            {
                //sieger = ziel.content;
                string gewinner = "";
                    for(int i = 0; i < allePlayer.Count() ; i++)
                {
                    if (allePlayer[i].spielerFarbe == ziel.content)
                       gewinner = allePlayer[i].name;
                }
                //if(s.content == s1.spielerFarbe)
                //{
                //    string gewinner = s1.name;
                //}
                //else if (s.content == s2.spielerFarbe)
                //{
                //    string gewinner = s2.name;
                //}
                //else if (s.content == s3.spielerFarbe)
                //{
                //    string gewinner = s3.name;
                //}
                //else if (s.content == s4.spielerFarbe)
                //{
                //    string gewinner = s4.name;
                //}

                frm_Sieg siegesNachricht = new frm_Sieg(this, frm, gewinner);
                siegesNachricht.Show();
                this.Hide();
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
                        if(!f.Enabled && f.schonGeruecktWorden)
                        {
                            f.Enabled = true;
                            f.schonGeruecktWorden = false;
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
            schonBlockGesetzt = false;
        }

        private void nextPlayer(Player vorherigerPlayer)
        {
            //Player aktuellerPlayer = s1;
            if(vorherigerPlayer != null)
            {
                int i = (int)vorherigerPlayer.spielerFarbe;
                if((i+1) < PlayerAnzahl)
                {
                    yourTurn = allePlayer[i + 1];
                }
                else
                {
                    yourTurn = allePlayer[0];
                }
                //switch (vorherigerPlayer.spielerFarbe)
                //{
                //    case Feld.Content.RED:
                //        yourTurn = s2;
                //        break;
                //    case Feld.Content.GREEN:
                //        yourTurn = s3;
                //        break;
                //    case Feld.Content.YELLOW:
                //        yourTurn = s4;
                //        break;
                //    case Feld.Content.BLUE:
                //        yourTurn = s1;
                //        break;
                //}
            }
            //schongerueckt = false;
            spielerButtonsDisablen();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Feld myfield = (Feld)sender;
            
            int rueckzahl = Wurfzahl;

            //while (!someoneWon)
            //{
            if (schongewuerfelt)
            {

                if (!schonBlockGesetzt)
                {
                    //if (myfield.content == yourTurn.spielerFarbe || !schongerueckt)
                    //{
                        if (myfield.BackColor != Color.Brown)
                            rueckOptionenZuruecksetzen();
                        if (myfield.BackColor == Color.Brown)
                        {
                            ruecken(myfield, start);
                            //rueckOptionenZuruecksetzen();
                            if (!schonBlockGesetzt)
                            {
                                schongewuerfelt = false;
                                btn_wuerfeln.Enabled = true;
                                nextPlayer(yourTurn);
                            }
                        }
                        else if (myfield.content == yourTurn.spielerFarbe)
                        {
                            start = myfield;
                            rueckOptionenPropagiere(myfield, rueckzahl, null, myfield.content);
                        }

                    //}
                }
                else
                {
                    if (myfield.content == Feld.Content.EMPTY && myfield.Entfernung_zum_Ziel <= 36)
                    {
                        blockieren(myfield);                    //blöcke dürfen nicht in die unterste reihe!!!!!  mouseOver Effekt
                        schongewuerfelt = false;
                        btn_wuerfeln.Enabled = true;
                        nextPlayer(yourTurn);

                    }
                }

                //}
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

        private void btn_aussetzen_Click(object sender, EventArgs e)
        {
            schongewuerfelt = false;
            btn_wuerfeln.Enabled = true;
            nextPlayer(yourTurn);
            btn_aussetzen.Enabled = false;
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
