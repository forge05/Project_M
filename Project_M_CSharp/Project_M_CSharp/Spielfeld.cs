using System;
using System.Collections;
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
        Feld Propagierender;
        bool BlockZuSetzen = false;
        bool SomeoneWon = false;
        bool SchonGewuerfelt = false;
        Form frm_Menue;
        Form frm_Einstellungen;
        Player Player1;
        Player Player2;
        Player Player3;
        Player Player4;
        Player YourTurn;
        List<Player> AllePlayer;
        IEnumerator<Player> Iterator;
        Startfeld sf;

        public frm_Spielfeld(Form myFrm, Form myFrm_E)
        {
            frm_Menue = myFrm;
            frm_Einstellungen = myFrm_E;
            AllePlayer = new List<Player>();
            InitializeComponent();
            erstellePlayer();
            Iterator = AllePlayer.GetEnumerator();
            //InitializeComponent();
            setAttributes();
            setNeighbors();
            nextPlayer();

            //Container StartfeldContainer = new Container();   //könnte man später aus Performanzgründen einbauen
            //foreach (Feld f in frm_Einstellungen.Controls)
            //{
            //    if (f is Startfeld)
            //    {
            //        StartfeldContainer.Add(f);
            //    }
            //}
        }

        public void setAttributes()
        {
            btn_0_ziel.setAttributes(Feld.Content.GOAL, 0);
            btn_1.setAttributes(Feld.Content.BLOCK, 1);
            btn_2_1.setAttributes(Feld.Content.BLACK, 2);
            btn_2_2.setAttributes(Feld.Content.BLACK, 2);
            btn_3_1.setAttributes(Feld.Content.BLACK, 3);
            btn_3_2.setAttributes(Feld.Content.BLACK, 3);
            btn_4_1.setAttributes(Feld.Content.BLACK, 4);
            btn_4_2.setAttributes(Feld.Content.BLACK, 4);
            btn_5_1.setAttributes(Feld.Content.BLACK, 5);
            btn_5_2.setAttributes(Feld.Content.BLACK, 5);
            btn_6_1.setAttributes(Feld.Content.BLACK, 6);
            btn_6_2.setAttributes(Feld.Content.BLACK, 6);
            btn_7_1.setAttributes(Feld.Content.BLACK, 7);
            btn_7_2.setAttributes(Feld.Content.BLACK, 7);
            btn_8_1.setAttributes(Feld.Content.BLACK, 8);
            btn_8_2.setAttributes(Feld.Content.BLACK, 8);
            btn_9_1.setAttributes(Feld.Content.BLACK, 9);
            btn_9_2.setAttributes(Feld.Content.BLACK, 9);
            btn_10_1.setAttributes(Feld.Content.BLACK, 10);
            btn_10_2.setAttributes(Feld.Content.BLACK, 10);
            btn_11_1.setAttributes(Feld.Content.BLACK, 11);
            btn_11_2.setAttributes(Feld.Content.BLACK, 11);
            btn_12_1.setAttributes(Feld.Content.BLACK, 12);
            btn_12_2.setAttributes(Feld.Content.BLACK, 12);
            btn_13_1.setAttributes(Feld.Content.BLACK, 13);
            btn_13_2.setAttributes(Feld.Content.BLACK, 13);
            btn_14_1.setAttributes(Feld.Content.BLACK, 14);
            btn_14_2.setAttributes(Feld.Content.BLACK, 14);
            btn_15_1.setAttributes(Feld.Content.BLACK, 15);
            btn_15_2.setAttributes(Feld.Content.BLACK, 15);
            btn_16_1.setAttributes(Feld.Content.BLACK, 16);
            btn_16_2.setAttributes(Feld.Content.BLACK, 16);
            btn_17_1.setAttributes(Feld.Content.BLACK, 17);
            btn_17_2.setAttributes(Feld.Content.BLACK, 17);
            btn_18_1.setAttributes(Feld.Content.BLACK, 18);
            btn_18_2.setAttributes(Feld.Content.BLACK, 18);
            btn_19.setAttributes(Feld.Content.BLOCK, 19);
            btn_20.setAttributes(Feld.Content.BLOCK, 20);
            btn_21.setAttributes(Feld.Content.BLOCK, 21);
            btn_22_1.setAttributes(Feld.Content.BLACK, 22);
            btn_22_2.setAttributes(Feld.Content.BLACK, 22);
            btn_23_1.setAttributes(Feld.Content.BLACK, 23);
            btn_23_2.setAttributes(Feld.Content.BLACK, 23);
            btn_24_1.setAttributes(Feld.Content.BLACK, 24);
            btn_24_2.setAttributes(Feld.Content.BLACK, 24);
            btn_25_1.setAttributes(Feld.Content.BLOCK, 25);
            btn_25_2.setAttributes(Feld.Content.BLOCK, 25);
            btn_26_1.setAttributes(Feld.Content.BLACK, 26);
            btn_26_2.setAttributes(Feld.Content.BLACK, 26);
            btn_26_3.setAttributes(Feld.Content.BLACK, 26);
            btn_26_4.setAttributes(Feld.Content.BLACK, 26);
            btn_27_1.setAttributes(Feld.Content.BLACK, 27);
            btn_27_2.setAttributes(Feld.Content.BLACK, 27);
            btn_27_3.setAttributes(Feld.Content.BLACK, 27);
            btn_28_1.setAttributes(Feld.Content.BLACK, 28);
            btn_28_2.setAttributes(Feld.Content.BLACK, 28);
            btn_29_1.setAttributes(Feld.Content.BLACK, 29);
            btn_29_2.setAttributes(Feld.Content.BLACK, 29);
            btn_30_1.setAttributes(Feld.Content.BLACK, 30);
            btn_30_2.setAttributes(Feld.Content.BLACK, 30);
            btn_30_3.setAttributes(Feld.Content.BLACK, 30);
            btn_30_4.setAttributes(Feld.Content.BLACK, 30);
            btn_31_1.setAttributes(Feld.Content.BLACK, 31);
            btn_31_2.setAttributes(Feld.Content.BLACK, 31);
            btn_31_3.setAttributes(Feld.Content.BLACK, 31);
            btn_31_4.setAttributes(Feld.Content.BLACK, 31);
            btn_32_1.setAttributes(Feld.Content.BLACK, 32);
            btn_32_2.setAttributes(Feld.Content.BLACK, 32);
            btn_32_3.setAttributes(Feld.Content.BLACK, 32);
            btn_32_4.setAttributes(Feld.Content.BLACK, 32);
            btn_32_5.setAttributes(Feld.Content.BLACK, 32);
            btn_32_6.setAttributes(Feld.Content.BLACK, 32);
            btn_33_1.setAttributes(Feld.Content.BLACK, 33);
            btn_33_2.setAttributes(Feld.Content.BLACK, 33);
            btn_33_3.setAttributes(Feld.Content.BLACK, 33);
            btn_33_4.setAttributes(Feld.Content.BLACK, 33);
            btn_33_5.setAttributes(Feld.Content.BLACK, 33);
            btn_34_1.setAttributes(Feld.Content.BLACK, 34);
            btn_34_2.setAttributes(Feld.Content.BLACK, 34);
            btn_34_3.setAttributes(Feld.Content.BLACK, 34);
            btn_34_4.setAttributes(Feld.Content.BLACK, 34);
            btn_34_5.setAttributes(Feld.Content.BLACK, 34);
            btn_34_6.setAttributes(Feld.Content.BLACK, 34);
            btn_34_7.setAttributes(Feld.Content.BLACK, 34);
            btn_34_8.setAttributes(Feld.Content.BLACK, 34);
            btn_35_1.setAttributes(Feld.Content.BLOCK, 35);
            btn_35_2.setAttributes(Feld.Content.BLOCK, 35);
            btn_35_3.setAttributes(Feld.Content.BLOCK, 35);
            btn_35_4.setAttributes(Feld.Content.BLOCK, 35);
            btn_35_5.setAttributes(Feld.Content.BLOCK, 35);
            btn_36_1.setAttributes(Feld.Content.BLACK, 36);
            btn_36_2.setAttributes(Feld.Content.BLACK, 36);
            btn_36_3.setAttributes(Feld.Content.BLACK, 36);
            btn_36_4.setAttributes(Feld.Content.BLACK, 36);
            btn_36_5.setAttributes(Feld.Content.BLACK, 36);
            btn_37_1.setAttributes(Feld.Content.BLACK, 37);
            btn_37_2.setAttributes(Feld.Content.BLACK, 37);
            btn_37_3.setAttributes(Feld.Content.BLACK, 37);
            btn_37_4.setAttributes(Feld.Content.BLACK, 37);
            btn_37_5.setAttributes(Feld.Content.BLACK, 37);
            btn_38_1.setAttributes(Feld.Content.BLACK, 38);
            btn_38_2.setAttributes(Feld.Content.BLACK, 38);
            btn_38_3.setAttributes(Feld.Content.BLACK, 38);
            btn_38_4.setAttributes(Feld.Content.BLACK, 38);
            btn_38_5.setAttributes(Feld.Content.BLACK, 38);
            btn_38_6.setAttributes(Feld.Content.BLACK, 38);
            btn_38_7.setAttributes(Feld.Content.BLACK, 38);
            btn_38_8.setAttributes(Feld.Content.BLACK, 38);
            btn_39_1.setAttributes(Feld.Content.BLACK, 39); //wir lassen die 39er-Felder bewusst 
            btn_39_2.setAttributes(Feld.Content.BLACK, 39); //nicht ihre Startfeldnachbar
            btn_39_3.setAttributes(Feld.Content.BLACK, 39); //kennen, weil man nicht zurück in die
            btn_39_4.setAttributes(Feld.Content.BLACK, 39); //Startfelder rücken darf
            btn_red_40_1.setAttributes(Feld.Content.RED, 40);
            btn_red_40_2.setAttributes(Feld.Content.RED, 40);
            btn_red_40_3.setAttributes(Feld.Content.RED, 40);
            btn_red_40_4.setAttributes(Feld.Content.RED, 40);
            btn_red_40_5.setAttributes(Feld.Content.RED, 40);
            btn_green_40_1.setAttributes(Feld.Content.GREEN, 40);
            btn_green_40_2.setAttributes(Feld.Content.GREEN, 40);
            btn_green_40_3.setAttributes(Feld.Content.GREEN, 40);
            btn_green_40_4.setAttributes(Feld.Content.GREEN, 40);
            btn_green_40_5.setAttributes(Feld.Content.GREEN, 40);
            btn_yellow_40_1.setAttributes(Feld.Content.YELLOW, 40);
            btn_yellow_40_2.setAttributes(Feld.Content.YELLOW, 40);
            btn_yellow_40_3.setAttributes(Feld.Content.YELLOW, 40);
            btn_yellow_40_4.setAttributes(Feld.Content.YELLOW, 40);
            btn_yellow_40_5.setAttributes(Feld.Content.YELLOW, 40);
            btn_blue_40_1.setAttributes(Feld.Content.BLUE, 40);
            btn_blue_40_2.setAttributes(Feld.Content.BLUE, 40);
            btn_blue_40_3.setAttributes(Feld.Content.BLUE, 40);
            btn_blue_40_4.setAttributes(Feld.Content.BLUE, 40);
            btn_blue_40_5.setAttributes(Feld.Content.BLUE, 40);
        }

        public void setNeighbors()
        {
            btn_0_ziel.setNachbar(btn_1);
            btn_1.setNachbar(btn_0_ziel, btn_2_1, btn_2_2);
            btn_2_1.setNachbar(btn_1, btn_3_1);
            btn_2_2.setNachbar(btn_1, btn_3_2);
            btn_3_1.setNachbar(btn_2_1, btn_4_1);
            btn_3_2.setNachbar(btn_2_2, btn_4_2);
            btn_4_1.setNachbar(btn_3_1, btn_5_1);
            btn_4_2.setNachbar(btn_3_2, btn_5_2);
            btn_5_1.setNachbar(btn_4_1, btn_6_1);
            btn_5_2.setNachbar(btn_4_2, btn_6_2);
            btn_6_1.setNachbar(btn_5_1, btn_7_1);
            btn_6_2.setNachbar(btn_5_2, btn_7_2);
            btn_7_1.setNachbar(btn_6_1, btn_8_1);
            btn_7_2.setNachbar(btn_6_2, btn_8_2);
            btn_8_1.setNachbar(btn_7_1, btn_9_1);
            btn_8_2.setNachbar(btn_7_2, btn_9_2);
            btn_9_1.setNachbar(btn_8_1, btn_10_1);
            btn_9_2.setNachbar(btn_8_2, btn_10_2);
            btn_10_1.setNachbar(btn_9_1, btn_11_1);
            btn_10_2.setNachbar(btn_9_2, btn_11_2);
            btn_11_1.setNachbar(btn_10_1, btn_12_1);
            btn_11_2.setNachbar(btn_10_2, btn_12_2);
            btn_12_1.setNachbar(btn_11_1, btn_13_1);
            btn_12_2.setNachbar(btn_11_2, btn_13_2);
            btn_13_1.setNachbar(btn_12_1, btn_14_1);
            btn_13_2.setNachbar(btn_12_2, btn_14_2);
            btn_14_1.setNachbar(btn_13_1, btn_15_1);
            btn_14_2.setNachbar(btn_13_2, btn_15_2);
            btn_15_1.setNachbar(btn_14_1, btn_16_1);
            btn_15_2.setNachbar(btn_14_2, btn_16_2);
            btn_16_1.setNachbar(btn_15_1, btn_17_1);
            btn_16_2.setNachbar(btn_15_2, btn_17_2);
            btn_17_1.setNachbar(btn_16_1, btn_18_1);
            btn_17_2.setNachbar(btn_16_2, btn_18_2);
            btn_18_1.setNachbar(btn_17_1, btn_19);
            btn_18_2.setNachbar(btn_17_2, btn_19);
            btn_19.setNachbar(btn_18_1, btn_18_2, btn_20);
            btn_20.setNachbar(btn_19, btn_21);
            btn_21.setNachbar(btn_20, btn_22_1, btn_22_2);
            btn_22_1.setNachbar(btn_21, btn_23_1);
            btn_22_2.setNachbar(btn_21, btn_23_2);
            btn_23_1.setNachbar(btn_22_1, btn_24_1);
            btn_23_2.setNachbar(btn_22_2, btn_24_2);
            btn_24_1.setNachbar(btn_23_1, btn_25_1);
            btn_24_2.setNachbar(btn_23_2, btn_25_2);
            btn_25_1.setNachbar(btn_24_1, btn_26_1, btn_26_2);
            btn_25_2.setNachbar(btn_24_2, btn_26_3, btn_26_4);
            btn_26_1.setNachbar(btn_25_1, btn_27_1);
            btn_26_2.setNachbar(btn_25_1, btn_27_2);
            btn_26_3.setNachbar(btn_25_2, btn_27_2);
            btn_26_4.setNachbar(btn_25_2, btn_27_3);
            btn_27_1.setNachbar(btn_26_1, btn_28_1);
            btn_27_2.setNachbar(btn_26_2, btn_26_3);
            btn_27_3.setNachbar(btn_26_4, btn_28_2);
            btn_28_1.setNachbar(btn_27_1, btn_29_1);
            btn_28_2.setNachbar(btn_27_3, btn_29_2);
            btn_29_1.setNachbar(btn_28_1, btn_30_1, btn_30_2);
            btn_29_2.setNachbar(btn_28_2, btn_30_3, btn_30_4);
            btn_30_1.setNachbar(btn_29_1, btn_31_1);
            btn_30_2.setNachbar(btn_29_1, btn_31_2);
            btn_30_3.setNachbar(btn_29_2, btn_31_3);
            btn_30_4.setNachbar(btn_29_2, btn_31_4);
            btn_31_1.setNachbar(btn_30_1, btn_32_1);
            btn_31_2.setNachbar(btn_30_2, btn_32_2, btn_32_3);
            btn_31_3.setNachbar(btn_30_3, btn_32_4, btn_32_5);
            btn_31_4.setNachbar(btn_30_4, btn_32_6);
            btn_32_1.setNachbar(btn_31_1, btn_33_1);
            btn_32_2.setNachbar(btn_31_2, btn_33_2);
            btn_32_3.setNachbar(btn_31_2, btn_33_3);
            btn_32_4.setNachbar(btn_31_3, btn_33_3);
            btn_32_5.setNachbar(btn_31_3, btn_33_4);
            btn_32_6.setNachbar(btn_31_4, btn_33_5);
            btn_33_1.setNachbar(btn_32_1, btn_34_1, btn_34_2);
            btn_33_2.setNachbar(btn_32_2, btn_34_3, btn_34_4);
            btn_33_3.setNachbar(btn_32_3, btn_32_4);
            btn_33_4.setNachbar(btn_32_5, btn_34_5, btn_34_6);
            btn_33_5.setNachbar(btn_32_6, btn_34_7, btn_34_8);
            btn_34_1.setNachbar(btn_33_1, btn_35_1);
            btn_34_2.setNachbar(btn_33_1, btn_35_2);
            btn_34_3.setNachbar(btn_33_2, btn_35_2);
            btn_34_4.setNachbar(btn_33_2, btn_35_3);
            btn_34_5.setNachbar(btn_33_4, btn_35_3);
            btn_34_6.setNachbar(btn_33_4, btn_35_4);
            btn_34_7.setNachbar(btn_33_5, btn_35_4);
            btn_34_8.setNachbar(btn_33_5, btn_35_5);
            btn_35_1.setNachbar(btn_34_1, btn_36_1);
            btn_35_2.setNachbar(btn_34_2, btn_34_3, btn_36_2);
            btn_35_3.setNachbar(btn_34_4, btn_34_5, btn_36_3);
            btn_35_4.setNachbar(btn_34_6, btn_34_7, btn_36_4);
            btn_35_5.setNachbar(btn_34_8, btn_36_5);
            btn_36_1.setNachbar(btn_35_1, btn_37_1);
            btn_36_2.setNachbar(btn_35_2, btn_37_2);
            btn_36_3.setNachbar(btn_35_3, btn_37_3);
            btn_36_4.setNachbar(btn_35_4, btn_37_4);
            btn_36_5.setNachbar(btn_35_5, btn_37_5);
            btn_37_1.setNachbar(btn_36_1, btn_38_1);
            btn_37_2.setNachbar(btn_36_2, btn_38_2, btn_38_3);
            btn_37_3.setNachbar(btn_36_3, btn_38_4, btn_38_5);
            btn_37_4.setNachbar(btn_36_4, btn_38_6, btn_38_7);
            btn_37_5.setNachbar(btn_36_5, btn_38_8);
            btn_38_1.setNachbar(btn_37_1, btn_39_1);
            btn_38_2.setNachbar(btn_37_2, btn_39_1);
            btn_38_3.setNachbar(btn_37_2, btn_39_2);
            btn_38_4.setNachbar(btn_37_3, btn_39_2);
            btn_38_5.setNachbar(btn_37_3, btn_39_3);
            btn_38_6.setNachbar(btn_37_4, btn_39_3);
            btn_38_7.setNachbar(btn_37_4, btn_39_4);
            btn_38_8.setNachbar(btn_37_5, btn_39_4);
            btn_39_1.setNachbar(btn_38_1, btn_38_2); //wir lassen die 39er-Felder bewusst 
            btn_39_2.setNachbar(btn_38_3, btn_38_4); //nicht ihre Startfeldnachbarn
            btn_39_3.setNachbar(btn_38_5, btn_38_6); //kennen, weil man nicht zurück in die
            btn_39_4.setNachbar(btn_38_7, btn_38_8); //Startfelder rücken darf
            btn_red_40_1.setNachbar(btn_39_1);
            btn_red_40_2.setNachbar(btn_39_1);
            btn_red_40_3.setNachbar(btn_39_1);
            btn_red_40_4.setNachbar(btn_39_1);
            btn_red_40_5.setNachbar(btn_39_1);
            btn_green_40_1.setNachbar(btn_39_2);
            btn_green_40_2.setNachbar(btn_39_2);
            btn_green_40_3.setNachbar(btn_39_2);
            btn_green_40_4.setNachbar(btn_39_2);
            btn_green_40_5.setNachbar(btn_39_2);
            btn_yellow_40_1.setNachbar(btn_39_3);
            btn_yellow_40_2.setNachbar(btn_39_3);
            btn_yellow_40_3.setNachbar(btn_39_3);
            btn_yellow_40_4.setNachbar(btn_39_3);
            btn_yellow_40_5.setNachbar(btn_39_3);
            btn_blue_40_1.setNachbar(btn_39_4);
            btn_blue_40_2.setNachbar(btn_39_4);
            btn_blue_40_3.setNachbar(btn_39_4);
            btn_blue_40_4.setNachbar(btn_39_4);
            btn_blue_40_5.setNachbar(btn_39_4);
        }

        private void resetSpielfeld()
        {
            setAttributes();
            //booleans zurücksetzen
            BlockZuSetzen = false;
            SchonGewuerfelt = false;
            //neu zeichnen
            Iterator.Reset();
            nextPlayer();
            //Startfelder zurücksetzen und alle Felder mit ihrem neuen-alten Content zeichnen
            foreach (Feld feld in pnl_alleFelder.Controls)
            {
                if (feld is Startfeld)
                {
                    sf = (Startfeld)feld;
                    sf.SchonGeruecktWorden = false;
                }
                feld.BackColor = getColorFromContent(feld.Inhalt);
            }
            //Buttons disablen
            playerButtonsDisablen();
            //Actionbuttons zurücksetzen
            btn_wuerfeln.Enabled = true;
            btn_aussetzen.Enabled = false;
        }

        private void erstellePlayer()
        {
            bool CPU1 = false;
            bool CPU2 = false;
            bool CPU3 = false;
            bool CPU4 = false;

            //Startfelder außerhalb des Designers ausgrauen
            foreach(Control c in pnl_alleFelder.Controls)
            {
                if (c is Startfeld)
                {
                    c.BackColor = Color.DarkGray;
                }
            }

            foreach (Control gb in frm_Einstellungen.Controls)
            {
                if (gb is GroupBox)
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
                                    //erstelle ggf. CPU
                                    CPU1 = true;
                                }
                            }
                            else if (cb.Name == "ckb_cpu_s2")
                            {
                                if (cb.Checked)
                                {
                                    //erstelle ggf. CPU
                                    CPU2 = true;
                                }
                            }
                            else if (cb.Name == "ckb_cpu_s3")
                            {
                                if (cb.Checked && cb.Enabled)
                                {
                                    //erstelle ggf. CPU
                                    CPU3 = true;
                                }
                            }
                            else if (cb.Name == "ckb_cpu_s4")
                            {
                                if (cb.Checked && cb.Enabled)
                                {
                                    //erstelle ggf. CPU
                                    CPU4 = true;
                                }
                            }
                        }
                    }
                }
            }
            if (CPU1)
            {
                Player1 = new CPU(Playername1, Feld.Content.RED, btn_red_40_1, btn_red_40_2, btn_red_40_3, btn_red_40_4, btn_red_40_5);
            }
            else
            {
                Player1 = new Spieler(Playername1, Feld.Content.RED, btn_red_40_1, btn_red_40_2, btn_red_40_3, btn_red_40_4, btn_red_40_5);
            }
            AllePlayer.Add(Player1); //Player 1 wird der Playerliste hinzugefügt
            lbl_Player1.Text = Playername1;
            if (CPU2)
            {
                Player2 = new CPU(Playername2, Feld.Content.GREEN, btn_green_40_1, btn_green_40_2, btn_green_40_3, btn_green_40_4, btn_green_40_5);
            }
            else
            {
                Player2 = new Spieler(Playername2, Feld.Content.GREEN, btn_green_40_1, btn_green_40_2, btn_green_40_3, btn_green_40_4, btn_green_40_5);
            }
            AllePlayer.Add(Player2); //Player 2 wird der Playerliste hinzugefügt
            lbl_Player2.Text = Playername2;
            if (PlayerAnzahl > 2)
            {
                if (CPU3)
                {
                    Player3 = new CPU(Playername3, Feld.Content.YELLOW, btn_yellow_40_1, btn_yellow_40_2, btn_yellow_40_3, btn_yellow_40_4, btn_yellow_40_5);
                }
                else
                {
                    Player3 = new Spieler(Playername3, Feld.Content.YELLOW, btn_yellow_40_1, btn_yellow_40_2, btn_yellow_40_3, btn_yellow_40_4, btn_yellow_40_5);
                }
                AllePlayer.Add(Player3); //Player 3 wird der Playerliste hinzugefügt
                lbl_Player3.Text = Playername3;
                //Player3 einfärben
                foreach (Startfeld sf in Player3.StartfeldArray)
                {
                    sf.BackColor = getColorFromContent(Player3.spielerFarbe);
                }
                if (PlayerAnzahl > 3)
                {
                    if (CPU4)
                    {
                        Player4 = new CPU(Playername4, Feld.Content.BLUE, btn_blue_40_1, btn_blue_40_2, btn_blue_40_3, btn_blue_40_4, btn_blue_40_5);
                    }
                    else
                    {
                        Player4 = new Spieler(Playername4, Feld.Content.BLUE, btn_blue_40_1, btn_blue_40_2, btn_blue_40_3, btn_blue_40_4, btn_blue_40_5);
                    }
                    AllePlayer.Add(Player4); //Player 4 wird der Playerliste hinzugefügt
                    lbl_Player4.Text = Playername4;
                    //Player 4 einfärben
                    foreach (Startfeld sf in Player4.StartfeldArray)
                    {
                        sf.BackColor = getColorFromContent(Player4.spielerFarbe);
                    }
                }
            }
            //RadioButton könnte noch ausgelesen werden, um festzulegen wer anfangen soll
        }

        private void btn_wuerfeln_Click(object sender, EventArgs e)
        {
            Random Zahlenfee = new Random();
            Wurfzahl = Zahlenfee.Next(1, 7);
            lbl_Wurfzahl.Text = Wurfzahl.ToString();
            SchonGewuerfelt = true;
            btn_aussetzen.Enabled = true;
            btn_wuerfeln.Enabled = false;
            lbl_Anleitungen.Text = "Spieler " + YourTurn.name + " Sie müssen rücken. Klicken Sie dafür eine ihrer Figuren an und anschließend auf ein markiertes Feld.";
        }

        private void propagiereRueckOptionen(Feld AktuellesFeld, int Spruenge, Feld AltesFeld, Feld.Content PlayerContent)
        {

            //Blöcke berücksichtigen
            //Gegnerische Figuren berücksichtigen 
            if (Spruenge != 0)
            {
                if (AktuellesFeld.Inhalt != Feld.Content.BLOCK)
                {
                    //if(f.content != PlayerContent)                           //wird später beim Einfärben abgefangen, weil man ansonsten keine eigenen Figuren überspringen könnte
                    //{
                    foreach (Feld nachbar in AktuellesFeld.Nachbarn)
                    {
                        if (nachbar != AltesFeld)                           //Vergleiche in foreach nur zu Beginn ineffiezient
                        {
                            //if (!(nachbar is Startfeld))           //sicherstellen, dass nicht zurück in die Startfelder gesprungen wird um Endlosschleife zu vermeiden
                            //{                                     //wird allerdings bei den Nachbarschaftsbeziehungen bereits ausgeschlossen
                            propagiereRueckOptionen(nachbar, Spruenge - 1, AktuellesFeld, PlayerContent);
                            //}
                        }
                    }
                    //}
                }
            }
            else
            {
                if (AktuellesFeld.Inhalt != PlayerContent)
                {
                    AktuellesFeld.BackColor = Color.Brown;
                }
                if (AktuellesFeld.Inhalt == Feld.Content.BLOCK)
                {
                    AktuellesFeld.Text = "BLOCK";
                }
                if ((int)AktuellesFeld.Inhalt <= (PlayerAnzahl - 1) && AktuellesFeld.Inhalt != PlayerContent)
                {
                    AktuellesFeld.Text = "Gegner";
                    AktuellesFeld.ForeColor = getColorFromContent(AktuellesFeld.Inhalt);
                }
                if (AktuellesFeld.Inhalt == Feld.Content.GOAL)
                {
                    AktuellesFeld.Text = "Ziel!";
                }
            }
        }

        private void rueckOptionenZuruecksetzen()
        {
            foreach (Feld f in pnl_alleFelder.Controls)
            {
                if (!(f is Startfeld))
                {
                    f.BackColor = getColorFromContent(f.Inhalt);
                    if (f.Inhalt != Feld.Content.GOAL)
                    {
                        f.Text = "";
                        f.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void playerButtonsDisablen()
        {
            foreach (Feld f in pnl_alleFelder.Controls)
            {
                if (f is Startfeld)
                {
                    sf = (Startfeld)f;
                    if ((int)f.Inhalt <= (PlayerAnzahl - 1))
                    {
                        if (YourTurn.spielerFarbe != f.Inhalt)
                        {
                            f.Enabled = false;
                            f.BackColor = Color.DarkGray;
                        }
                        else if (!sf.SchonGeruecktWorden)
                        {
                            sf.Enabled = true;
                            sf.BackColor = getColorFromContent(f.Inhalt);
                        }
                    }
                }
            }
        }

        private Color getColorFromContent(Feld.Content c)
        {
            switch (c)
            {
                case Feld.Content.RED: return Color.Red;
                case Feld.Content.GREEN: return Color.Green;
                case Feld.Content.YELLOW: return Color.Yellow;
                case Feld.Content.BLUE: return Color.Blue;
                case Feld.Content.BLACK: return Color.Black;
                case Feld.Content.GOAL: return Color.Magenta;
                case Feld.Content.BLOCK: return Color.White;
                default: return Color.Purple;
            }
        }

        private void ruecken(Feld PropTer, Feld PropDer)
        {
            Feld.Content Ursprungscontent = PropTer.Inhalt;
            PropTer.Inhalt = PropDer.Inhalt;
            PropTer.BackColor = PropDer.BackColor;

            if (PropDer is Startfeld)
            {
                //startfelder disablen
                Startfeld sf = (Startfeld)PropDer;
                sf.Enabled = false;                                      //nachher nochmal enablen
                sf.SchonGeruecktWorden = true;
            }
            else
            {
                PropDer.Inhalt = Feld.Content.BLACK;
                PropDer.BackColor = Color.Black;
            }

            switch (Ursprungscontent)
            {
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
                case Feld.Content.BLOCK:
                    BlockZuSetzen = true;
                    lbl_Anleitungen.Text = "Spieler " + YourTurn.name + " Sie müssen einen Block setzen. Die unterste Reihe ist tabu.";
                    btn_aussetzen.Enabled = false;
                    break;
                case Feld.Content.GOAL:
                    gewinnen();
                    break;
            }

            rueckOptionenZuruecksetzen();
        }

        private void gewinnen()
        {
            SomeoneWon = true;
            btn_wuerfeln.Enabled = false;
            btn_aussetzen.Enabled = false;
            frm_Sieg siegesNachricht = new frm_Sieg(this, frm_Menue, YourTurn.name);
            siegesNachricht.Show();
            this.Hide();
        }

        private void schlagen(Feld.Content GeschlagenerInhalt)
        {
            foreach (Feld Startfeld in pnl_alleFelder.Controls)
            {
                if (Startfeld is Startfeld) //if (f.EntfernungZumZiel == 40)
                {
                    sf = (Startfeld)Startfeld;
                    if (Startfeld.Inhalt == GeschlagenerInhalt)
                    {
                        if (!Startfeld.Enabled && sf.SchonGeruecktWorden)
                        {
                            Startfeld.Enabled = true;
                            sf.SchonGeruecktWorden = false;
                            break;
                        }
                    }
                }
            }
        }

        private void blockieren(Feld WirdBlock)
        {
            WirdBlock.Inhalt = Feld.Content.BLOCK;
            WirdBlock.BackColor = Color.White;
            BlockZuSetzen = false;
        }

        private void nextPlayer()
        {
            if (!(Iterator.MoveNext()))
            {
                Iterator.Reset();
                Iterator.MoveNext();
            }
            YourTurn = Iterator.Current;
            lbl_Anleitungen.Text = "Spieler " + YourTurn.name + " Sie müssen würfeln.";
            btn_wuerfeln.Enabled = true;
            btn_aussetzen.Enabled = false;
            lbl_Wurfzahl.Text = "";
            SchonGewuerfelt = false;

            playerButtonsDisablen();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Feld myField = (Feld)sender;

            if (SchonGewuerfelt)
            {
                if (!BlockZuSetzen)
                {
                    if (myField.BackColor != Color.Brown)
                        rueckOptionenZuruecksetzen();
                    if (myField.BackColor == Color.Brown)
                    {
                        ruecken(myField, Propagierender);
                        //rueckOptionenZuruecksetzen(); //wird in ruecken gemacht
                        if (!BlockZuSetzen && !SomeoneWon)
                        {
                            nextPlayer();
                        }
                    }
                    else if (myField.Inhalt == YourTurn.spielerFarbe)
                    {
                        Propagierender = myField;
                        propagiereRueckOptionen(myField, Wurfzahl, null, myField.Inhalt);
                    }
                }
                else
                {
                    if (myField.Inhalt == Feld.Content.BLACK && myField.EntfernungZumZiel <= 36)
                    {
                        blockieren(myField);                    //blöcke dürfen nicht in die unterste reihe!!!!!  mouseOver Effekt
                        nextPlayer();
                    }
                }
            }
        }

        private void frm_Spielfeld_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Menue.Show();
        }

        private void btn_aussetzen_Click(object sender, EventArgs e)
        {
            nextPlayer();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetSpielfeld();
        }
    }
}
