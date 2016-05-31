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
        //Player[] allePlayer;
        List<Player> allePlayer;
        IEnumerator<Player> iter;

        public frm_Spielfeld(Form myFrm, Form myFrm_E)
        {
            frm = myFrm;
            frm_E = myFrm_E;
            allePlayer = new List<Player>();
            erstellePlayer();
            iter = allePlayer.GetEnumerator();
            InitializeComponent();
            setAttributes();
            setNachbarn();
            nextPlayer();
            spielerButtonsDisablen();

            //foreach(Feld f in frm_E.Controls)
            //Container buttonContainer = new Container();
            //foreach(Feld b in pnl_alleFelder.Controls)
            //{
            //    buttonContainer.Add(b);
            //}
            //spielRoutine();
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

        public void setNachbarn()
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
            btn_39_2.setNachbar(btn_38_3, btn_38_4); //nicht ihre Startfeldnachbar
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
            allePlayer.Add(s1); //Player 1 wird der Playerliste hinzugefügt
            if (CPU_GREEN)
            {
                s2 = new CPU(Playername2, Feld.Content.GREEN);
            }
            else
            {
                s2 = new Spieler(Playername2, Feld.Content.GREEN);
            }
            allePlayer.Add(s2); //Player 2 wird der Playerliste hinzugefügt
            if (PlayerAnzahl > 2)
            {
                if (CPU_YELLOW)
                {
                    s3 = new CPU(Playername3, Feld.Content.YELLOW);
                }
                else
                {
                    s3 = new Spieler(Playername3, Feld.Content.YELLOW);
                }
                allePlayer.Add(s3); //Player 3 wird der Playerliste hinzugefügt
                if (PlayerAnzahl > 3)
                {
                    if (CPU_BLUE)
                    {
                        s4 = new CPU(Playername4, Feld.Content.BLUE);
                    }
                    else
                    {
                        s4 = new Spieler(Playername4, Feld.Content.BLUE);
                    }
                    allePlayer.Add(s4); //Player 4 wird der Playerliste hinzugefügt
                }
                
            }


            //allePlayer = new Player[PlayerAnzahl];
            //allePlayer[0] = s1;
            //allePlayer[1] = s2;
            //if (s3 != null)
            //{
            //    allePlayer[2] = s3;
            //    if (s4 != null)
            //    {
            //        allePlayer[3] = s4;
            //    }
            //}
            //yourTurn = s1;                                              //radiobutton auslesen, wer anfangen soll
        }

        private void btn_wuerfeln_Click(object sender, EventArgs e)
        {
            Random Zahlenfee = new Random();
            Wurfzahl = Zahlenfee.Next(1, 7);
            lbl_wurfzahl.Text = Wurfzahl.ToString();
            schongewuerfelt = true;
            btn_aussetzen.Enabled = true;
            btn_wuerfeln.Enabled = false;
            lbl_anleitungen.Text = "Spieler " + yourTurn.name + " Sie müssen rücken. Klicken Sie dafür eine ihrer Figuren an und anschließend auf ein markiertes Feld.";
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

                    //switch (f.content)
                    //{
                    //    case Feld.Content.RED:
                    //        f.ForeColor = Color.Red;
                    //        break;
                    //    case Feld.Content.GREEN:
                    //        f.ForeColor = Color.Green;
                    //        break;
                    //    case Feld.Content.YELLOW:
                    //        f.ForeColor = Color.Yellow;
                    //        break;
                    //    case Feld.Content.BLUE:
                    //        f.ForeColor = Color.Blue;
                    //        break;
                    //}
                    f.ForeColor = getColorFromContent(f.content);
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
                if (!(f is Startfeld))
                {
                    //switch (f.content)
                    //{
                    //    case Feld.Content.RED:
                    //        f.BackColor = Color.Red;
                    //        f.Text = "";
                    //        f.ForeColor = Color.Black;
                    //        break;

                    //    case Feld.Content.GREEN:
                    //        f.BackColor = Color.Green;
                    //        f.Text = "";
                    //        f.ForeColor = Color.Black;
                    //        break;
                    //    case Feld.Content.YELLOW:
                    //        f.BackColor = Color.Yellow;
                    //        f.Text = "";
                    //        f.ForeColor = Color.Black;
                    //        break;
                    //    case Feld.Content.BLUE:
                    //        f.BackColor = Color.Blue;
                    //        f.Text = "";
                    //        f.ForeColor = Color.Black;
                    //        break;
                    //    case Feld.Content.BLACK:
                    //        f.BackColor = Color.Black;
                    //        f.Text = "";
                    //        f.ForeColor = Color.Black;
                    //        break;
                    //    case Feld.Content.BLOCK:
                    //        f.BackColor = Color.White;
                    //        f.Text = "";
                    //        f.ForeColor = Color.Black;
                    //        break;
                    //    case Feld.Content.GOAL:
                    //        f.BackColor = Color.Magenta;
                    //        break;
                    //}
                    f.BackColor = getColorFromContent(f.content);
                    if (f.content != Feld.Content.GOAL)
                    {
                        f.Text = "";
                        f.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void spielerButtonsDisablen()
        {
            foreach(Feld f in pnl_alleFelder.Controls)
            {
                if(f is Startfeld)
                {
                    if ((int)f.content <= (PlayerAnzahl - 1))
                    {
                        if (yourTurn.spielerFarbe != f.content)
                        {
                            f.Enabled = false;
                            f.BackColor = Color.DarkGray;
                        }
                        else if (!f.schonGeruecktWorden)
                        {
                            f.Enabled = true;
                            f.BackColor = getColorFromContent(f.content);
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
                s.content = Feld.Content.BLACK;
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
                    lbl_anleitungen.Text = "Spieler " + yourTurn.name + " Sie müssen einen Block setzen. Die unterste Reihe ist tabu.";
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

        private void nextPlayer()
        {
            //Player aktuellerPlayer = s1;
            if (!(iter.MoveNext()))
            {
                iter.Reset();
                iter.MoveNext();
            }
            yourTurn = iter.Current;
            //if (vorherigerPlayer != null)
            //{
            //    int i = (int)vorherigerPlayer.spielerFarbe;
            //    if((i+1) < PlayerAnzahl)
            //    {
            //        yourTurn = allePlayer[i + 1];
            //    }
            //    else
            //    {
            //        yourTurn = allePlayer[0];
            //    }
            //}
            //schongerueckt = false;
            lbl_anleitungen.Text = "Spieler " + yourTurn.name + " Sie müssen würfeln.";
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
                                nextPlayer();
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
                    if (myfield.content == Feld.Content.BLACK && myfield.Entfernung_zum_Ziel <= 36)
                    {
                        blockieren(myfield);                    //blöcke dürfen nicht in die unterste reihe!!!!!  mouseOver Effekt
                        schongewuerfelt = false;
                        btn_wuerfeln.Enabled = true;
                        nextPlayer();

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
            nextPlayer();
            btn_aussetzen.Enabled = false;
        }
    }
}
