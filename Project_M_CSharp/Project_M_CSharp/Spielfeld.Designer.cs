
using System.Windows.Forms;

namespace Project_M_CSharp
{
    partial class frm_Spielfeld
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        //private void initFelder()
        //{
        //    this.btn_8_1 = new Feld(Feld.Content.EMPTY, 8);
        //    this.btn_9_1 = new Feld(Feld.Content.EMPTY, 9);
        //    this.btn_10_1 = new Feld(Feld.Content.EMPTY, 10);
        //    this.btn_1 = new Feld(Feld.Content.BLOCK, 1);
        //    this.btn_2_1 = new Feld(Feld.Content.EMPTY, 2);
        //    this.btn_3_1 = new Feld(Feld.Content.EMPTY, 3);
        //    this.btn_4_1 = new Feld(Feld.Content.EMPTY, 4);
        //    this.btn_5_1 = new Feld(Feld.Content.EMPTY, 5);
        //    this.btn_6_1 = new Feld(Feld.Content.EMPTY, 6);
        //    this.btn_7_1 = new Feld(Feld.Content.EMPTY, 7);
        //    this.btn_17_1 = new Feld(Feld.Content.EMPTY, 17);
        //    this.btn_16_1 = new Feld(Feld.Content.EMPTY, 16);
        //    this.btn_15_1 = new Feld(Feld.Content.EMPTY, 15);
        //    this.btn_14_1 = new Feld(Feld.Content.EMPTY, 14);
        //    this.btn_13_1 = new Feld(Feld.Content.EMPTY, 13);
        //    this.btn_12_1 = new Feld(Feld.Content.EMPTY, 12);
        //    this.btn_11_1 = new Feld(Feld.Content.EMPTY, 11);
        //    this.btn_8_2 = new Feld(Feld.Content.EMPTY, 8);
        //    this.btn_7_2 = new Feld(Feld.Content.EMPTY, 7);
        //    this.btn_6_2 = new Feld(Feld.Content.EMPTY, 6);
        //    this.btn_5_2 = new Feld(Feld.Content.EMPTY, 5);
        //    this.btn_4_2 = new Feld(Feld.Content.EMPTY, 4);
        //    this.btn_3_2 = new Feld(Feld.Content.EMPTY, 3);
        //    this.btn_2_2 = new Feld(Feld.Content.EMPTY, 2);
        //    this.btn_19_1 = new Feld(Feld.Content.BLOCK, 19);
        //    this.btn_18_1 = new Feld(Feld.Content.EMPTY, 18);
        //    this.btn_15_2 = new Feld(Feld.Content.EMPTY, 15);
        //    this.btn_14_2 = new Feld(Feld.Content.EMPTY, 14);
        //    this.btn_13_2 = new Feld(Feld.Content.EMPTY, 13);
        //    this.btn_12_2 = new Feld(Feld.Content.EMPTY, 12);
        //    this.btn_11_2 = new Feld(Feld.Content.EMPTY, 11);
        //    this.btn_10_2 = new Feld(Feld.Content.EMPTY, 10);
        //    this.btn_9_2 = new Feld(Feld.Content.EMPTY, 9);
        //    this.btn_22_2 = new Feld(Feld.Content.EMPTY, 22);
        //    this.btn_23_1 = new Feld(Feld.Content.EMPTY, 23);
        //    this.btn_22_1 = new Feld(Feld.Content.EMPTY, 22);
        //    this.btn_21_1 = new Feld(Feld.Content.BLOCK, 21);
        //    this.btn_20_1 = new Feld(Feld.Content.BLOCK, 20);
        //    this.btn_18_2 = new Feld(Feld.Content.EMPTY, 18);
        //    this.btn_17_2 = new Feld(Feld.Content.EMPTY, 17);
        //    this.btn_16_2 = new Feld(Feld.Content.EMPTY, 16);
        //    this.btn_26_3 = new Feld(Feld.Content.EMPTY, 26);
        //    this.btn_27_2 = new Feld(Feld.Content.EMPTY, 27);
        //    this.btn_26_2 = new Feld(Feld.Content.EMPTY, 26);
        //    this.btn_25_1 = new Feld(Feld.Content.BLOCK, 25);
        //    this.btn_24_1 = new Feld(Feld.Content.EMPTY, 24);
        //    this.btn_24_2 = new Feld(Feld.Content.EMPTY, 24);
        //    this.btn_23_2 = new Feld(Feld.Content.EMPTY, 23);
        //    this.btn_28_1 = new Feld(Feld.Content.EMPTY, 28);
        //    this.btn_27_1 = new Feld(Feld.Content.EMPTY, 27);
        //    this.btn_26_1 = new Feld(Feld.Content.EMPTY, 26);
        //    this.btn_25_2 = new Feld(Feld.Content.BLOCK, 25);
        //    this.btn_31_2 = new Feld(Feld.Content.EMPTY, 31);
        //    this.btn_32_3 = new Feld(Feld.Content.EMPTY, 32);
        //    this.btn_33_3 = new Feld(Feld.Content.EMPTY, 33);
        //    this.btn_32_4 = new Feld(Feld.Content.EMPTY, 32);
        //    this.btn_31_3 = new Feld(Feld.Content.EMPTY, 31);
        //    this.btn_30_3 = new Feld(Feld.Content.EMPTY, 30);
        //    this.btn_29_2 = new Feld(Feld.Content.EMPTY, 29);
        //    this.btn_28_2 = new Feld(Feld.Content.EMPTY, 28);
        //    this.btn_27_3 = new Feld(Feld.Content.EMPTY, 27);
        //    this.btn_26_4 = new Feld(Feld.Content.EMPTY, 26);
        //    this.btn_29_1 = new Feld(Feld.Content.EMPTY, 29);
        //    this.btn_30_2 = new Feld(Feld.Content.EMPTY, 30);
        //    this.btn_34_3 = new Feld(Feld.Content.EMPTY, 34);
        //    this.btn_35_2 = new Feld(Feld.Content.BLOCK, 35);
        //    this.btn_34_2 = new Feld(Feld.Content.EMPTY, 34);
        //    this.btn_35_1 = new Feld(Feld.Content.BLOCK, 35);
        //    this.btn_34_1 = new Feld(Feld.Content.EMPTY, 34);
        //    this.btn_33_1 = new Feld(Feld.Content.EMPTY, 33);
        //    this.btn_32_1 = new Feld(Feld.Content.EMPTY, 32);
        //    this.btn_35_5 = new Feld(Feld.Content.BLOCK, 35);
        //    this.btn_34_8 = new Feld(Feld.Content.EMPTY, 34);
        //    this.btn_33_5 = new Feld(Feld.Content.EMPTY, 33);
        //    this.btn_32_6 = new Feld(Feld.Content.EMPTY, 32);
        //    this.btn_31_4 = new Feld(Feld.Content.EMPTY, 31);
        //    this.btn_30_4 = new Feld(Feld.Content.EMPTY, 30);
        //    this.btn_31_1 = new Feld(Feld.Content.EMPTY, 31);
        //    this.btn_30_1 = new Feld(Feld.Content.EMPTY, 30);
        //    this.btn_38_6 = new Feld(Feld.Content.EMPTY, 38);
        //    this.btn_38_7 = new Feld(Feld.Content.EMPTY, 38);
        //    this.btn_39_4 = new Feld(Feld.Content.EMPTY, 39);
        //    this.btn_38_8 = new Feld(Feld.Content.EMPTY, 38);
        //    this.btn_37_5 = new Feld(Feld.Content.EMPTY, 37);
        //    this.btn_36_5 = new Feld(Feld.Content.EMPTY, 36);
        //    this.btn_34_7 = new Feld(Feld.Content.EMPTY, 34);
        //    this.btn_35_4 = new Feld(Feld.Content.BLOCK, 35);
        //    this.btn_34_6 = new Feld(Feld.Content.EMPTY, 34);
        //    this.btn_32_5 = new Feld(Feld.Content.EMPTY, 32);
        //    this.btn_33_4 = new Feld(Feld.Content.EMPTY, 33);
        //    this.btn_34_5 = new Feld(Feld.Content.EMPTY, 34);
        //    this.btn_35_3 = new Feld(Feld.Content.BLOCK, 35);
        //    this.btn_34_4 = new Feld(Feld.Content.EMPTY, 34);
        //    this.btn_32_2 = new Feld(Feld.Content.EMPTY, 32);
        //    this.btn_33_2 = new Feld(Feld.Content.EMPTY, 33);
        //    this.btn_38_4 = new Feld(Feld.Content.EMPTY, 38);
        //    this.btn_37_3 = new Feld(Feld.Content.EMPTY, 37);
        //    this.btn_38_5 = new Feld(Feld.Content.EMPTY, 38);
        //    this.btn_39_3 = new Feld(Feld.Content.EMPTY, 39);
        //    this.btn_37_4 = new Feld(Feld.Content.EMPTY, 37);
        //    this.btn_37_1 = new Feld(Feld.Content.EMPTY, 37);
        //    this.btn_38_1 = new Feld(Feld.Content.EMPTY, 38);
        //    this.btn_39_1 = new Feld(Feld.Content.EMPTY, 39);
        //    this.btn_38_2 = new Feld(Feld.Content.EMPTY, 38);
        //    this.btn_37_2 = new Feld(Feld.Content.EMPTY, 37);
        //    this.btn_38_3 = new Feld(Feld.Content.EMPTY, 38);
        //    this.btn_39_2 = new Feld(Feld.Content.EMPTY, 39);
        //    this.btn_36_1 = new Feld(Feld.Content.EMPTY, 36);
        //    this.btn_36_4 = new Feld(Feld.Content.EMPTY, 36);
        //    this.btn_36_3 = new Feld(Feld.Content.EMPTY, 36);
        //    this.btn_36_2 = new Feld(Feld.Content.EMPTY, 36);
        //    this.btn_40_red_4 = new Feld(Feld.Content.RED, 40);
        //    this.btn_40_red_3 = new Feld(Feld.Content.RED, 40);
        //    this.btn_40_red_5 = new Feld(Feld.Content.RED, 40);
        //    this.btn_40_red_2 = new Feld(Feld.Content.RED, 40);
        //    this.btn_40_red_1 = new Feld(Feld.Content.RED, 40);
        //    this.btn_40_green_4 = new Feld(Feld.Content.GREEN, 40);
        //    this.btn_40_green_3 = new Feld(Feld.Content.GREEN, 40);
        //    this.btn_40_green_5 = new Feld(Feld.Content.GREEN, 40);
        //    this.btn_40_green_2 = new Feld(Feld.Content.GREEN, 40);
        //    this.btn_40_green_1 = new Feld(Feld.Content.GREEN, 40);
        //    this.btn_40_yellow_4 = new Feld(Feld.Content.YELLOW, 40);
        //    this.btn_40_yellow_3 = new Feld(Feld.Content.YELLOW, 40);
        //    this.btn_40_yellow_5 = new Feld(Feld.Content.YELLOW, 40);
        //    this.btn_40_yellow_2 = new Feld(Feld.Content.YELLOW, 40);
        //    this.btn_40_yellow_1 = new Feld(Feld.Content.YELLOW, 40);
        //    this.btn_40_blue_4 = new Feld(Feld.Content.BLUE, 40);
        //    this.btn_40_blue_3 = new Feld(Feld.Content.BLUE, 40);
        //    this.btn_40_blue_5 = new Feld(Feld.Content.BLUE, 40);
        //    this.btn_40_blue_2 = new Feld(Feld.Content.BLUE, 40);
        //    this.btn_40_blue_1 = new Feld(Feld.Content.BLUE, 40);
        //    this.btn_0_ziel = new Feld(Feld.Content.GOAL, 0);

        //    //weise Nachbarn zu
        //    btn_0_ziel.setNachbar(btn_1);
        //    btn_1.setNachbar(btn_0_ziel, btn_2_1, btn_2_2);
        //    btn_2_1.setNachbar(btn_1, btn_3_1);
        //    btn_2_2.setNachbar(btn_1, btn_3_2);
        //    btn_3_1.setNachbar(btn_2_1, btn_4_1);
        //    btn_3_2.setNachbar(btn_2_2, btn_4_2);
        //    btn_4_1.setNachbar(btn_3_1, btn_5_1);
        //    btn_4_2.setNachbar(btn_3_2, btn_5_2);
        //    btn_5_1.setNachbar(btn_4_1, btn_6_1);
        //    btn_5_2.setNachbar(btn_4_2, btn_6_2);
        //    btn_6_1.setNachbar(btn_5_1, btn_7_1);
        //    btn_6_2.setNachbar(btn_5_2, btn_7_2);
        //    btn_7_1.setNachbar(btn_6_1, btn_8_1);
        //    btn_7_2.setNachbar(btn_6_2, btn_8_2);
        //    btn_8_1.setNachbar(btn_7_1, btn_9_1);
        //    btn_8_2.setNachbar(btn_7_2, btn_9_2);
        //    btn_9_1.setNachbar(btn_8_1, btn_10_1);
        //    btn_9_2.setNachbar(btn_8_2, btn_10_2);
        //    btn_10_1.setNachbar(btn_9_1, btn_11_1);
        //    btn_10_2.setNachbar(btn_9_2, btn_11_2);
        //    btn_11_1.setNachbar(btn_10_1, btn_12_1);
        //    btn_11_2.setNachbar(btn_10_2, btn_12_2);
        //    btn_12_1.setNachbar(btn_11_1, btn_13_1);
        //    btn_12_2.setNachbar(btn_11_2, btn_13_2);
        //    btn_13_1.setNachbar(btn_12_1, btn_14_1);
        //    btn_13_2.setNachbar(btn_12_2, btn_14_2);
        //    btn_14_1.setNachbar(btn_13_1, btn_15_1);
        //    btn_14_2.setNachbar(btn_13_2, btn_15_2);
        //    btn_15_1.setNachbar(btn_14_1, btn_16_1);
        //    btn_15_2.setNachbar(btn_14_2, btn_16_2);
        //    btn_16_1.setNachbar(btn_15_1, btn_17_1);
        //    btn_16_2.setNachbar(btn_15_2, btn_17_2);
        //    btn_17_1.setNachbar(btn_16_1, btn_18_1);
        //    btn_17_2.setNachbar(btn_16_2, btn_18_2);
        //    btn_18_1.setNachbar(btn_17_1, btn_19_1);
        //    btn_18_2.setNachbar(btn_17_2, btn_19_1);
        //    btn_19_1.setNachbar(btn_18_1, btn_18_2, btn_20_1);
        //    btn_20_1.setNachbar(btn_19_1, btn_21_1);
        //    btn_21_1.setNachbar(btn_20_1, btn_22_1, btn_22_2);
        //    btn_22_1.setNachbar(btn_21_1, btn_23_1);
        //    btn_22_2.setNachbar(btn_21_1, btn_23_2);
        //    btn_23_1.setNachbar(btn_22_1, btn_24_1);
        //    btn_23_2.setNachbar(btn_22_2, btn_24_2);
        //    btn_24_1.setNachbar(btn_23_1, btn_25_1);
        //    btn_24_2.setNachbar(btn_23_2, btn_25_2);
        //    btn_25_1.setNachbar(btn_24_1, btn_26_1, btn_26_2);
        //    btn_25_2.setNachbar(btn_24_2, btn_26_3, btn_26_4);
        //    btn_26_1.setNachbar(btn_25_1, btn_27_1);
        //    btn_26_2.setNachbar(btn_25_1, btn_27_2);
        //    btn_26_3.setNachbar(btn_25_2, btn_27_2);
        //    btn_26_4.setNachbar(btn_25_2, btn_27_3);
        //    btn_27_1.setNachbar(btn_26_1, btn_28_1);
        //    btn_27_2.setNachbar(btn_26_2, btn_26_3);
        //    btn_27_3.setNachbar(btn_26_4, btn_28_2);
        //    btn_28_1.setNachbar(btn_27_1, btn_29_1);
        //    btn_28_2.setNachbar(btn_27_3, btn_29_2);
        //    btn_29_1.setNachbar(btn_28_1, btn_30_1, btn_30_2);
        //    btn_29_2.setNachbar(btn_28_2, btn_30_3, btn_30_4);
        //    btn_30_1.setNachbar(btn_29_1, btn_31_1);
        //    btn_30_2.setNachbar(btn_29_1, btn_31_2);
        //    btn_30_3.setNachbar(btn_29_2, btn_31_3);
        //    btn_30_4.setNachbar(btn_29_2, btn_31_4);
        //    btn_31_1.setNachbar(btn_30_1, btn_32_1);
        //    btn_31_2.setNachbar(btn_30_2, btn_32_2, btn_32_3);
        //    btn_31_3.setNachbar(btn_30_3, btn_32_4, btn_32_5);
        //    btn_31_4.setNachbar(btn_30_4, btn_32_6);
        //    btn_32_1.setNachbar(btn_31_1, btn_33_1);
        //    btn_32_2.setNachbar(btn_31_2, btn_33_2);
        //    btn_32_3.setNachbar(btn_31_2, btn_33_3);
        //    btn_32_4.setNachbar(btn_31_3, btn_33_3);
        //    btn_32_5.setNachbar(btn_31_3, btn_33_4);
        //    btn_32_6.setNachbar(btn_31_4, btn_33_5);
        //    btn_33_1.setNachbar(btn_32_1, btn_34_1, btn_34_2);
        //    btn_33_2.setNachbar(btn_32_2, btn_34_3, btn_34_4);
        //    btn_33_3.setNachbar(btn_32_3, btn_32_4);
        //    btn_33_4.setNachbar(btn_32_5, btn_34_5, btn_34_6);
        //    btn_33_5.setNachbar(btn_32_6, btn_34_7, btn_34_8);
        //    btn_34_1.setNachbar(btn_33_1, btn_35_1);
        //    btn_34_2.setNachbar(btn_33_1, btn_35_2);
        //    btn_34_3.setNachbar(btn_33_2, btn_35_2);
        //    btn_34_4.setNachbar(btn_33_2, btn_35_3);
        //    btn_34_5.setNachbar(btn_33_4, btn_35_3);
        //    btn_34_6.setNachbar(btn_33_4, btn_35_4);
        //    btn_34_7.setNachbar(btn_33_5, btn_35_4);
        //    btn_34_8.setNachbar(btn_33_5, btn_35_5);
        //    btn_35_1.setNachbar(btn_34_1, btn_36_1);
        //    btn_35_2.setNachbar(btn_34_2, btn_34_3, btn_36_2);
        //    btn_35_3.setNachbar(btn_34_4, btn_34_5, btn_36_3);
        //    btn_35_4.setNachbar(btn_34_6, btn_34_7, btn_36_4);
        //    btn_35_5.setNachbar(btn_34_8, btn_36_5);
        //    btn_36_1.setNachbar(btn_35_1, btn_37_1);
        //    btn_36_2.setNachbar(btn_35_2, btn_37_2);
        //    btn_36_3.setNachbar(btn_35_3, btn_37_3);
        //    btn_36_4.setNachbar(btn_35_4, btn_37_4);
        //    btn_36_5.setNachbar(btn_35_5, btn_37_5);
        //    btn_37_1.setNachbar(btn_36_1, btn_38_1);
        //    btn_37_2.setNachbar(btn_36_2, btn_38_2, btn_38_3);
        //    btn_37_3.setNachbar(btn_36_3, btn_38_4, btn_38_5);
        //    btn_37_4.setNachbar(btn_36_4, btn_38_6, btn_38_7);
        //    btn_37_5.setNachbar(btn_36_5, btn_38_8);
        //    btn_38_1.setNachbar(btn_37_1, btn_39_1);
        //    btn_38_2.setNachbar(btn_37_2, btn_39_1);
        //    btn_38_3.setNachbar(btn_37_2, btn_39_2);
        //    btn_38_4.setNachbar(btn_37_3, btn_39_2);
        //    btn_38_5.setNachbar(btn_37_3, btn_39_3);
        //    btn_38_6.setNachbar(btn_37_4, btn_39_3);
        //    btn_38_7.setNachbar(btn_37_4, btn_39_4);
        //    btn_38_8.setNachbar(btn_37_5, btn_39_4);
        //    btn_39_1.setNachbar(btn_38_1, btn_38_2, btn_40_red_1, btn_40_red_2, btn_40_red_3, btn_40_red_4, btn_40_red_5);
        //    btn_39_2.setNachbar(btn_38_3, btn_38_4, btn_40_green_1, btn_40_green_2, btn_40_green_3, btn_40_green_4, btn_40_green_5);
        //    btn_39_3.setNachbar(btn_38_5, btn_38_6, btn_40_yellow_1, btn_40_yellow_2, btn_40_yellow_3, btn_40_yellow_4, btn_40_yellow_5);
        //    btn_39_4.setNachbar(btn_38_7, btn_38_8, btn_40_blue_1, btn_40_blue_2, btn_40_blue_3, btn_40_blue_4, btn_40_blue_5);
        //    btn_40_red_1.setNachbar(btn_39_1);
        //    btn_40_red_2.setNachbar(btn_39_1);
        //    btn_40_red_3.setNachbar(btn_39_1);
        //    btn_40_red_4.setNachbar(btn_39_1);
        //    btn_40_red_5.setNachbar(btn_39_1);
        //    btn_40_green_1.setNachbar(btn_39_2);
        //    btn_40_green_2.setNachbar(btn_39_2);
        //    btn_40_green_3.setNachbar(btn_39_2);
        //    btn_40_green_4.setNachbar(btn_39_2);
        //    btn_40_green_5.setNachbar(btn_39_2);
        //    btn_40_yellow_1.setNachbar(btn_39_3);
        //    btn_40_yellow_2.setNachbar(btn_39_3);
        //    btn_40_yellow_3.setNachbar(btn_39_3);
        //    btn_40_yellow_4.setNachbar(btn_39_3);
        //    btn_40_yellow_5.setNachbar(btn_39_3);
        //    btn_40_blue_1.setNachbar(btn_39_4);
        //    btn_40_blue_2.setNachbar(btn_39_4);
        //    btn_40_blue_3.setNachbar(btn_39_4);
        //    btn_40_blue_4.setNachbar(btn_39_4);
        //    btn_40_blue_5.setNachbar(btn_39_4);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_wuerfeln = new System.Windows.Forms.Button();
            this.lbl_Wurfzahl = new System.Windows.Forms.Label();
            this.pnl_alleFelder = new System.Windows.Forms.Panel();
            this.btn_blue_40_2 = new Project_M_CSharp.Startfeld();
            this.btn_blue_40_3 = new Project_M_CSharp.Startfeld();
            this.btn_blue_40_4 = new Project_M_CSharp.Startfeld();
            this.btn_blue_40_5 = new Project_M_CSharp.Startfeld();
            this.btn_blue_40_1 = new Project_M_CSharp.Startfeld();
            this.btn_yellow_40_2 = new Project_M_CSharp.Startfeld();
            this.btn_yellow_40_3 = new Project_M_CSharp.Startfeld();
            this.btn_yellow_40_4 = new Project_M_CSharp.Startfeld();
            this.btn_yellow_40_5 = new Project_M_CSharp.Startfeld();
            this.btn_yellow_40_1 = new Project_M_CSharp.Startfeld();
            this.btn_green_40_2 = new Project_M_CSharp.Startfeld();
            this.btn_green_40_3 = new Project_M_CSharp.Startfeld();
            this.btn_green_40_4 = new Project_M_CSharp.Startfeld();
            this.btn_green_40_5 = new Project_M_CSharp.Startfeld();
            this.btn_green_40_1 = new Project_M_CSharp.Startfeld();
            this.btn_red_40_2 = new Project_M_CSharp.Startfeld();
            this.btn_red_40_3 = new Project_M_CSharp.Startfeld();
            this.btn_red_40_4 = new Project_M_CSharp.Startfeld();
            this.btn_red_40_5 = new Project_M_CSharp.Startfeld();
            this.btn_red_40_1 = new Project_M_CSharp.Startfeld();
            this.btn_32_5 = new Project_M_CSharp.Feld();
            this.btn_32_2 = new Project_M_CSharp.Feld();
            this.btn_36_3 = new Project_M_CSharp.Feld();
            this.btn_36_4 = new Project_M_CSharp.Feld();
            this.btn_36_2 = new Project_M_CSharp.Feld();
            this.btn_37_5 = new Project_M_CSharp.Feld();
            this.btn_38_8 = new Project_M_CSharp.Feld();
            this.btn_39_4 = new Project_M_CSharp.Feld();
            this.btn_38_7 = new Project_M_CSharp.Feld();
            this.btn_37_4 = new Project_M_CSharp.Feld();
            this.btn_38_6 = new Project_M_CSharp.Feld();
            this.btn_39_3 = new Project_M_CSharp.Feld();
            this.btn_38_5 = new Project_M_CSharp.Feld();
            this.btn_37_3 = new Project_M_CSharp.Feld();
            this.btn_38_4 = new Project_M_CSharp.Feld();
            this.btn_39_2 = new Project_M_CSharp.Feld();
            this.btn_38_3 = new Project_M_CSharp.Feld();
            this.btn_37_2 = new Project_M_CSharp.Feld();
            this.btn_38_2 = new Project_M_CSharp.Feld();
            this.btn_39_1 = new Project_M_CSharp.Feld();
            this.btn_38_1 = new Project_M_CSharp.Feld();
            this.btn_37_1 = new Project_M_CSharp.Feld();
            this.btn_36_5 = new Project_M_CSharp.Feld();
            this.btn_36_1 = new Project_M_CSharp.Feld();
            this.btn_34_1 = new Project_M_CSharp.Feld();
            this.btn_35_1 = new Project_M_CSharp.Feld();
            this.btn_35_5 = new Project_M_CSharp.Feld();
            this.btn_34_8 = new Project_M_CSharp.Feld();
            this.btn_34_6 = new Project_M_CSharp.Feld();
            this.btn_34_3 = new Project_M_CSharp.Feld();
            this.btn_33_4 = new Project_M_CSharp.Feld();
            this.btn_34_5 = new Project_M_CSharp.Feld();
            this.btn_35_3 = new Project_M_CSharp.Feld();
            this.btn_34_4 = new Project_M_CSharp.Feld();
            this.btn_33_2 = new Project_M_CSharp.Feld();
            this.btn_33_5 = new Project_M_CSharp.Feld();
            this.btn_35_2 = new Project_M_CSharp.Feld();
            this.btn_34_2 = new Project_M_CSharp.Feld();
            this.btn_33_1 = new Project_M_CSharp.Feld();
            this.btn_34_7 = new Project_M_CSharp.Feld();
            this.btn_35_4 = new Project_M_CSharp.Feld();
            this.btn_32_6 = new Project_M_CSharp.Feld();
            this.btn_30_3 = new Project_M_CSharp.Feld();
            this.btn_30_2 = new Project_M_CSharp.Feld();
            this.btn_31_3 = new Project_M_CSharp.Feld();
            this.btn_32_4 = new Project_M_CSharp.Feld();
            this.btn_33_3 = new Project_M_CSharp.Feld();
            this.btn_32_3 = new Project_M_CSharp.Feld();
            this.btn_31_2 = new Project_M_CSharp.Feld();
            this.btn_31_4 = new Project_M_CSharp.Feld();
            this.btn_32_1 = new Project_M_CSharp.Feld();
            this.btn_29_1 = new Project_M_CSharp.Feld();
            this.btn_30_1 = new Project_M_CSharp.Feld();
            this.btn_31_1 = new Project_M_CSharp.Feld();
            this.btn_30_4 = new Project_M_CSharp.Feld();
            this.btn_29_2 = new Project_M_CSharp.Feld();
            this.btn_28_2 = new Project_M_CSharp.Feld();
            this.btn_28_1 = new Project_M_CSharp.Feld();
            this.btn_27_3 = new Project_M_CSharp.Feld();
            this.btn_26_4 = new Project_M_CSharp.Feld();
            this.btn_26_1 = new Project_M_CSharp.Feld();
            this.btn_27_1 = new Project_M_CSharp.Feld();
            this.btn_25_2 = new Project_M_CSharp.Feld();
            this.btn_26_3 = new Project_M_CSharp.Feld();
            this.btn_27_2 = new Project_M_CSharp.Feld();
            this.btn_26_2 = new Project_M_CSharp.Feld();
            this.btn_25_1 = new Project_M_CSharp.Feld();
            this.btn_24_2 = new Project_M_CSharp.Feld();
            this.btn_24_1 = new Project_M_CSharp.Feld();
            this.btn_23_2 = new Project_M_CSharp.Feld();
            this.btn_22_2 = new Project_M_CSharp.Feld();
            this.btn_22_1 = new Project_M_CSharp.Feld();
            this.btn_23_1 = new Project_M_CSharp.Feld();
            this.btn_21 = new Project_M_CSharp.Feld();
            this.btn_20 = new Project_M_CSharp.Feld();
            this.btn_11_2 = new Project_M_CSharp.Feld();
            this.btn_12_2 = new Project_M_CSharp.Feld();
            this.btn_13_2 = new Project_M_CSharp.Feld();
            this.btn_14_2 = new Project_M_CSharp.Feld();
            this.btn_15_2 = new Project_M_CSharp.Feld();
            this.btn_16_2 = new Project_M_CSharp.Feld();
            this.btn_17_2 = new Project_M_CSharp.Feld();
            this.btn_18_2 = new Project_M_CSharp.Feld();
            this.btn_19 = new Project_M_CSharp.Feld();
            this.btn_18_1 = new Project_M_CSharp.Feld();
            this.btn_17_1 = new Project_M_CSharp.Feld();
            this.btn_16_1 = new Project_M_CSharp.Feld();
            this.btn_15_1 = new Project_M_CSharp.Feld();
            this.btn_14_1 = new Project_M_CSharp.Feld();
            this.btn_13_1 = new Project_M_CSharp.Feld();
            this.btn_12_1 = new Project_M_CSharp.Feld();
            this.btn_11_1 = new Project_M_CSharp.Feld();
            this.btn_10_2 = new Project_M_CSharp.Feld();
            this.btn_10_1 = new Project_M_CSharp.Feld();
            this.btn_0_ziel = new Project_M_CSharp.Feld();
            this.btn_9_2 = new Project_M_CSharp.Feld();
            this.btn_8_2 = new Project_M_CSharp.Feld();
            this.btn_7_2 = new Project_M_CSharp.Feld();
            this.btn_6_2 = new Project_M_CSharp.Feld();
            this.btn_5_2 = new Project_M_CSharp.Feld();
            this.btn_4_2 = new Project_M_CSharp.Feld();
            this.btn_3_2 = new Project_M_CSharp.Feld();
            this.btn_2_2 = new Project_M_CSharp.Feld();
            this.btn_1 = new Project_M_CSharp.Feld();
            this.btn_2_1 = new Project_M_CSharp.Feld();
            this.btn_3_1 = new Project_M_CSharp.Feld();
            this.btn_4_1 = new Project_M_CSharp.Feld();
            this.btn_5_1 = new Project_M_CSharp.Feld();
            this.btn_6_1 = new Project_M_CSharp.Feld();
            this.btn_7_1 = new Project_M_CSharp.Feld();
            this.btn_8_1 = new Project_M_CSharp.Feld();
            this.btn_9_1 = new Project_M_CSharp.Feld();
            this.btn_aussetzen = new System.Windows.Forms.Button();
            this.lbl_Anleitungen = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.pnl_alleFelder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_wuerfeln
            // 
            this.btn_wuerfeln.Location = new System.Drawing.Point(11, 741);
            this.btn_wuerfeln.Margin = new System.Windows.Forms.Padding(2);
            this.btn_wuerfeln.Name = "btn_wuerfeln";
            this.btn_wuerfeln.Size = new System.Drawing.Size(115, 37);
            this.btn_wuerfeln.TabIndex = 135;
            this.btn_wuerfeln.Text = "würfeln";
            this.btn_wuerfeln.UseVisualStyleBackColor = true;
            this.btn_wuerfeln.Click += new System.EventHandler(this.btn_wuerfeln_Click);
            // 
            // lbl_Wurfzahl
            // 
            this.lbl_Wurfzahl.AutoSize = true;
            this.lbl_Wurfzahl.Location = new System.Drawing.Point(130, 753);
            this.lbl_Wurfzahl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Wurfzahl.Name = "lbl_Wurfzahl";
            this.lbl_Wurfzahl.Size = new System.Drawing.Size(13, 13);
            this.lbl_Wurfzahl.TabIndex = 136;
            this.lbl_Wurfzahl.Text = "0";
            // 
            // pnl_alleFelder
            // 
            this.pnl_alleFelder.Controls.Add(this.btn_blue_40_2);
            this.pnl_alleFelder.Controls.Add(this.btn_blue_40_3);
            this.pnl_alleFelder.Controls.Add(this.btn_blue_40_4);
            this.pnl_alleFelder.Controls.Add(this.btn_blue_40_5);
            this.pnl_alleFelder.Controls.Add(this.btn_blue_40_1);
            this.pnl_alleFelder.Controls.Add(this.btn_yellow_40_2);
            this.pnl_alleFelder.Controls.Add(this.btn_yellow_40_3);
            this.pnl_alleFelder.Controls.Add(this.btn_yellow_40_4);
            this.pnl_alleFelder.Controls.Add(this.btn_yellow_40_5);
            this.pnl_alleFelder.Controls.Add(this.btn_yellow_40_1);
            this.pnl_alleFelder.Controls.Add(this.btn_green_40_2);
            this.pnl_alleFelder.Controls.Add(this.btn_green_40_3);
            this.pnl_alleFelder.Controls.Add(this.btn_green_40_4);
            this.pnl_alleFelder.Controls.Add(this.btn_green_40_5);
            this.pnl_alleFelder.Controls.Add(this.btn_green_40_1);
            this.pnl_alleFelder.Controls.Add(this.btn_red_40_2);
            this.pnl_alleFelder.Controls.Add(this.btn_red_40_3);
            this.pnl_alleFelder.Controls.Add(this.btn_red_40_4);
            this.pnl_alleFelder.Controls.Add(this.btn_red_40_5);
            this.pnl_alleFelder.Controls.Add(this.btn_red_40_1);
            this.pnl_alleFelder.Controls.Add(this.btn_32_5);
            this.pnl_alleFelder.Controls.Add(this.btn_32_2);
            this.pnl_alleFelder.Controls.Add(this.btn_36_3);
            this.pnl_alleFelder.Controls.Add(this.btn_36_4);
            this.pnl_alleFelder.Controls.Add(this.btn_36_2);
            this.pnl_alleFelder.Controls.Add(this.btn_37_5);
            this.pnl_alleFelder.Controls.Add(this.btn_38_8);
            this.pnl_alleFelder.Controls.Add(this.btn_39_4);
            this.pnl_alleFelder.Controls.Add(this.btn_38_7);
            this.pnl_alleFelder.Controls.Add(this.btn_37_4);
            this.pnl_alleFelder.Controls.Add(this.btn_38_6);
            this.pnl_alleFelder.Controls.Add(this.btn_39_3);
            this.pnl_alleFelder.Controls.Add(this.btn_38_5);
            this.pnl_alleFelder.Controls.Add(this.btn_37_3);
            this.pnl_alleFelder.Controls.Add(this.btn_38_4);
            this.pnl_alleFelder.Controls.Add(this.btn_39_2);
            this.pnl_alleFelder.Controls.Add(this.btn_38_3);
            this.pnl_alleFelder.Controls.Add(this.btn_37_2);
            this.pnl_alleFelder.Controls.Add(this.btn_38_2);
            this.pnl_alleFelder.Controls.Add(this.btn_39_1);
            this.pnl_alleFelder.Controls.Add(this.btn_38_1);
            this.pnl_alleFelder.Controls.Add(this.btn_37_1);
            this.pnl_alleFelder.Controls.Add(this.btn_36_5);
            this.pnl_alleFelder.Controls.Add(this.btn_36_1);
            this.pnl_alleFelder.Controls.Add(this.btn_34_1);
            this.pnl_alleFelder.Controls.Add(this.btn_35_1);
            this.pnl_alleFelder.Controls.Add(this.btn_35_5);
            this.pnl_alleFelder.Controls.Add(this.btn_34_8);
            this.pnl_alleFelder.Controls.Add(this.btn_34_6);
            this.pnl_alleFelder.Controls.Add(this.btn_34_3);
            this.pnl_alleFelder.Controls.Add(this.btn_33_4);
            this.pnl_alleFelder.Controls.Add(this.btn_34_5);
            this.pnl_alleFelder.Controls.Add(this.btn_35_3);
            this.pnl_alleFelder.Controls.Add(this.btn_34_4);
            this.pnl_alleFelder.Controls.Add(this.btn_33_2);
            this.pnl_alleFelder.Controls.Add(this.btn_33_5);
            this.pnl_alleFelder.Controls.Add(this.btn_35_2);
            this.pnl_alleFelder.Controls.Add(this.btn_34_2);
            this.pnl_alleFelder.Controls.Add(this.btn_33_1);
            this.pnl_alleFelder.Controls.Add(this.btn_34_7);
            this.pnl_alleFelder.Controls.Add(this.btn_35_4);
            this.pnl_alleFelder.Controls.Add(this.btn_32_6);
            this.pnl_alleFelder.Controls.Add(this.btn_30_3);
            this.pnl_alleFelder.Controls.Add(this.btn_30_2);
            this.pnl_alleFelder.Controls.Add(this.btn_31_3);
            this.pnl_alleFelder.Controls.Add(this.btn_32_4);
            this.pnl_alleFelder.Controls.Add(this.btn_33_3);
            this.pnl_alleFelder.Controls.Add(this.btn_32_3);
            this.pnl_alleFelder.Controls.Add(this.btn_31_2);
            this.pnl_alleFelder.Controls.Add(this.btn_31_4);
            this.pnl_alleFelder.Controls.Add(this.btn_32_1);
            this.pnl_alleFelder.Controls.Add(this.btn_29_1);
            this.pnl_alleFelder.Controls.Add(this.btn_30_1);
            this.pnl_alleFelder.Controls.Add(this.btn_31_1);
            this.pnl_alleFelder.Controls.Add(this.btn_30_4);
            this.pnl_alleFelder.Controls.Add(this.btn_29_2);
            this.pnl_alleFelder.Controls.Add(this.btn_28_2);
            this.pnl_alleFelder.Controls.Add(this.btn_28_1);
            this.pnl_alleFelder.Controls.Add(this.btn_27_3);
            this.pnl_alleFelder.Controls.Add(this.btn_26_4);
            this.pnl_alleFelder.Controls.Add(this.btn_26_1);
            this.pnl_alleFelder.Controls.Add(this.btn_27_1);
            this.pnl_alleFelder.Controls.Add(this.btn_25_2);
            this.pnl_alleFelder.Controls.Add(this.btn_26_3);
            this.pnl_alleFelder.Controls.Add(this.btn_27_2);
            this.pnl_alleFelder.Controls.Add(this.btn_26_2);
            this.pnl_alleFelder.Controls.Add(this.btn_25_1);
            this.pnl_alleFelder.Controls.Add(this.btn_24_2);
            this.pnl_alleFelder.Controls.Add(this.btn_24_1);
            this.pnl_alleFelder.Controls.Add(this.btn_23_2);
            this.pnl_alleFelder.Controls.Add(this.btn_22_2);
            this.pnl_alleFelder.Controls.Add(this.btn_22_1);
            this.pnl_alleFelder.Controls.Add(this.btn_23_1);
            this.pnl_alleFelder.Controls.Add(this.btn_21);
            this.pnl_alleFelder.Controls.Add(this.btn_20);
            this.pnl_alleFelder.Controls.Add(this.btn_11_2);
            this.pnl_alleFelder.Controls.Add(this.btn_12_2);
            this.pnl_alleFelder.Controls.Add(this.btn_13_2);
            this.pnl_alleFelder.Controls.Add(this.btn_14_2);
            this.pnl_alleFelder.Controls.Add(this.btn_15_2);
            this.pnl_alleFelder.Controls.Add(this.btn_16_2);
            this.pnl_alleFelder.Controls.Add(this.btn_17_2);
            this.pnl_alleFelder.Controls.Add(this.btn_18_2);
            this.pnl_alleFelder.Controls.Add(this.btn_19);
            this.pnl_alleFelder.Controls.Add(this.btn_18_1);
            this.pnl_alleFelder.Controls.Add(this.btn_17_1);
            this.pnl_alleFelder.Controls.Add(this.btn_16_1);
            this.pnl_alleFelder.Controls.Add(this.btn_15_1);
            this.pnl_alleFelder.Controls.Add(this.btn_14_1);
            this.pnl_alleFelder.Controls.Add(this.btn_13_1);
            this.pnl_alleFelder.Controls.Add(this.btn_12_1);
            this.pnl_alleFelder.Controls.Add(this.btn_11_1);
            this.pnl_alleFelder.Controls.Add(this.btn_10_2);
            this.pnl_alleFelder.Controls.Add(this.btn_10_1);
            this.pnl_alleFelder.Controls.Add(this.btn_0_ziel);
            this.pnl_alleFelder.Controls.Add(this.btn_9_2);
            this.pnl_alleFelder.Controls.Add(this.btn_8_2);
            this.pnl_alleFelder.Controls.Add(this.btn_7_2);
            this.pnl_alleFelder.Controls.Add(this.btn_6_2);
            this.pnl_alleFelder.Controls.Add(this.btn_5_2);
            this.pnl_alleFelder.Controls.Add(this.btn_4_2);
            this.pnl_alleFelder.Controls.Add(this.btn_3_2);
            this.pnl_alleFelder.Controls.Add(this.btn_2_2);
            this.pnl_alleFelder.Controls.Add(this.btn_1);
            this.pnl_alleFelder.Controls.Add(this.btn_2_1);
            this.pnl_alleFelder.Controls.Add(this.btn_3_1);
            this.pnl_alleFelder.Controls.Add(this.btn_4_1);
            this.pnl_alleFelder.Controls.Add(this.btn_5_1);
            this.pnl_alleFelder.Controls.Add(this.btn_6_1);
            this.pnl_alleFelder.Controls.Add(this.btn_7_1);
            this.pnl_alleFelder.Controls.Add(this.btn_8_1);
            this.pnl_alleFelder.Controls.Add(this.btn_9_1);
            this.pnl_alleFelder.Location = new System.Drawing.Point(11, 7);
            this.pnl_alleFelder.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_alleFelder.Name = "pnl_alleFelder";
            this.pnl_alleFelder.Size = new System.Drawing.Size(1055, 695);
            this.pnl_alleFelder.TabIndex = 137;
            // 
            // btn_blue_40_2
            // 
            this.btn_blue_40_2.BackColor = System.Drawing.Color.Blue;
            this.btn_blue_40_2.Location = new System.Drawing.Point(809, 611);
            this.btn_blue_40_2.Name = "btn_blue_40_2";
            this.btn_blue_40_2.Size = new System.Drawing.Size(56, 35);
            this.btn_blue_40_2.TabIndex = 266;
            this.btn_blue_40_2.UseVisualStyleBackColor = false;
            this.btn_blue_40_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_blue_40_3
            // 
            this.btn_blue_40_3.BackColor = System.Drawing.Color.Blue;
            this.btn_blue_40_3.Location = new System.Drawing.Point(933, 611);
            this.btn_blue_40_3.Name = "btn_blue_40_3";
            this.btn_blue_40_3.Size = new System.Drawing.Size(56, 35);
            this.btn_blue_40_3.TabIndex = 265;
            this.btn_blue_40_3.UseVisualStyleBackColor = false;
            this.btn_blue_40_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_blue_40_4
            // 
            this.btn_blue_40_4.BackColor = System.Drawing.Color.Blue;
            this.btn_blue_40_4.Location = new System.Drawing.Point(840, 652);
            this.btn_blue_40_4.Name = "btn_blue_40_4";
            this.btn_blue_40_4.Size = new System.Drawing.Size(56, 35);
            this.btn_blue_40_4.TabIndex = 264;
            this.btn_blue_40_4.UseVisualStyleBackColor = false;
            this.btn_blue_40_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_blue_40_5
            // 
            this.btn_blue_40_5.BackColor = System.Drawing.Color.Blue;
            this.btn_blue_40_5.Location = new System.Drawing.Point(902, 652);
            this.btn_blue_40_5.Name = "btn_blue_40_5";
            this.btn_blue_40_5.Size = new System.Drawing.Size(56, 35);
            this.btn_blue_40_5.TabIndex = 263;
            this.btn_blue_40_5.UseVisualStyleBackColor = false;
            this.btn_blue_40_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_blue_40_1
            // 
            this.btn_blue_40_1.BackColor = System.Drawing.Color.Blue;
            this.btn_blue_40_1.Location = new System.Drawing.Point(871, 577);
            this.btn_blue_40_1.Name = "btn_blue_40_1";
            this.btn_blue_40_1.Size = new System.Drawing.Size(56, 35);
            this.btn_blue_40_1.TabIndex = 262;
            this.btn_blue_40_1.UseVisualStyleBackColor = false;
            this.btn_blue_40_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_yellow_40_2
            // 
            this.btn_yellow_40_2.BackColor = System.Drawing.Color.Yellow;
            this.btn_yellow_40_2.Location = new System.Drawing.Point(561, 611);
            this.btn_yellow_40_2.Name = "btn_yellow_40_2";
            this.btn_yellow_40_2.Size = new System.Drawing.Size(56, 35);
            this.btn_yellow_40_2.TabIndex = 261;
            this.btn_yellow_40_2.UseVisualStyleBackColor = false;
            this.btn_yellow_40_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_yellow_40_3
            // 
            this.btn_yellow_40_3.BackColor = System.Drawing.Color.Yellow;
            this.btn_yellow_40_3.Location = new System.Drawing.Point(685, 611);
            this.btn_yellow_40_3.Name = "btn_yellow_40_3";
            this.btn_yellow_40_3.Size = new System.Drawing.Size(56, 35);
            this.btn_yellow_40_3.TabIndex = 260;
            this.btn_yellow_40_3.UseVisualStyleBackColor = false;
            this.btn_yellow_40_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_yellow_40_4
            // 
            this.btn_yellow_40_4.BackColor = System.Drawing.Color.Yellow;
            this.btn_yellow_40_4.Location = new System.Drawing.Point(592, 652);
            this.btn_yellow_40_4.Name = "btn_yellow_40_4";
            this.btn_yellow_40_4.Size = new System.Drawing.Size(56, 35);
            this.btn_yellow_40_4.TabIndex = 259;
            this.btn_yellow_40_4.UseVisualStyleBackColor = false;
            this.btn_yellow_40_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_yellow_40_5
            // 
            this.btn_yellow_40_5.BackColor = System.Drawing.Color.Yellow;
            this.btn_yellow_40_5.Location = new System.Drawing.Point(654, 652);
            this.btn_yellow_40_5.Name = "btn_yellow_40_5";
            this.btn_yellow_40_5.Size = new System.Drawing.Size(56, 35);
            this.btn_yellow_40_5.TabIndex = 258;
            this.btn_yellow_40_5.UseVisualStyleBackColor = false;
            this.btn_yellow_40_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_yellow_40_1
            // 
            this.btn_yellow_40_1.BackColor = System.Drawing.Color.Yellow;
            this.btn_yellow_40_1.Location = new System.Drawing.Point(623, 577);
            this.btn_yellow_40_1.Name = "btn_yellow_40_1";
            this.btn_yellow_40_1.Size = new System.Drawing.Size(56, 35);
            this.btn_yellow_40_1.TabIndex = 257;
            this.btn_yellow_40_1.UseVisualStyleBackColor = false;
            this.btn_yellow_40_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_green_40_2
            // 
            this.btn_green_40_2.BackColor = System.Drawing.Color.Green;
            this.btn_green_40_2.Location = new System.Drawing.Point(313, 611);
            this.btn_green_40_2.Name = "btn_green_40_2";
            this.btn_green_40_2.Size = new System.Drawing.Size(56, 35);
            this.btn_green_40_2.TabIndex = 256;
            this.btn_green_40_2.UseVisualStyleBackColor = false;
            this.btn_green_40_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_green_40_3
            // 
            this.btn_green_40_3.BackColor = System.Drawing.Color.Green;
            this.btn_green_40_3.Location = new System.Drawing.Point(437, 611);
            this.btn_green_40_3.Name = "btn_green_40_3";
            this.btn_green_40_3.Size = new System.Drawing.Size(56, 35);
            this.btn_green_40_3.TabIndex = 255;
            this.btn_green_40_3.UseVisualStyleBackColor = false;
            this.btn_green_40_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_green_40_4
            // 
            this.btn_green_40_4.BackColor = System.Drawing.Color.Green;
            this.btn_green_40_4.Location = new System.Drawing.Point(344, 652);
            this.btn_green_40_4.Name = "btn_green_40_4";
            this.btn_green_40_4.Size = new System.Drawing.Size(56, 35);
            this.btn_green_40_4.TabIndex = 254;
            this.btn_green_40_4.UseVisualStyleBackColor = false;
            this.btn_green_40_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_green_40_5
            // 
            this.btn_green_40_5.BackColor = System.Drawing.Color.Green;
            this.btn_green_40_5.Location = new System.Drawing.Point(406, 652);
            this.btn_green_40_5.Name = "btn_green_40_5";
            this.btn_green_40_5.Size = new System.Drawing.Size(56, 35);
            this.btn_green_40_5.TabIndex = 253;
            this.btn_green_40_5.UseVisualStyleBackColor = false;
            this.btn_green_40_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_green_40_1
            // 
            this.btn_green_40_1.BackColor = System.Drawing.Color.Green;
            this.btn_green_40_1.Location = new System.Drawing.Point(375, 577);
            this.btn_green_40_1.Name = "btn_green_40_1";
            this.btn_green_40_1.Size = new System.Drawing.Size(56, 35);
            this.btn_green_40_1.TabIndex = 252;
            this.btn_green_40_1.UseVisualStyleBackColor = false;
            this.btn_green_40_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_red_40_2
            // 
            this.btn_red_40_2.BackColor = System.Drawing.Color.Red;
            this.btn_red_40_2.Location = new System.Drawing.Point(65, 611);
            this.btn_red_40_2.Name = "btn_red_40_2";
            this.btn_red_40_2.Size = new System.Drawing.Size(56, 35);
            this.btn_red_40_2.TabIndex = 251;
            this.btn_red_40_2.UseVisualStyleBackColor = false;
            this.btn_red_40_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_red_40_3
            // 
            this.btn_red_40_3.BackColor = System.Drawing.Color.Red;
            this.btn_red_40_3.Location = new System.Drawing.Point(189, 611);
            this.btn_red_40_3.Name = "btn_red_40_3";
            this.btn_red_40_3.Size = new System.Drawing.Size(56, 35);
            this.btn_red_40_3.TabIndex = 250;
            this.btn_red_40_3.UseVisualStyleBackColor = false;
            this.btn_red_40_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_red_40_4
            // 
            this.btn_red_40_4.BackColor = System.Drawing.Color.Red;
            this.btn_red_40_4.Location = new System.Drawing.Point(96, 652);
            this.btn_red_40_4.Name = "btn_red_40_4";
            this.btn_red_40_4.Size = new System.Drawing.Size(56, 35);
            this.btn_red_40_4.TabIndex = 249;
            this.btn_red_40_4.UseVisualStyleBackColor = false;
            this.btn_red_40_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_red_40_5
            // 
            this.btn_red_40_5.BackColor = System.Drawing.Color.Red;
            this.btn_red_40_5.Location = new System.Drawing.Point(158, 652);
            this.btn_red_40_5.Name = "btn_red_40_5";
            this.btn_red_40_5.Size = new System.Drawing.Size(56, 35);
            this.btn_red_40_5.TabIndex = 248;
            this.btn_red_40_5.UseVisualStyleBackColor = false;
            this.btn_red_40_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_red_40_1
            // 
            this.btn_red_40_1.BackColor = System.Drawing.Color.Red;
            this.btn_red_40_1.Location = new System.Drawing.Point(127, 577);
            this.btn_red_40_1.Name = "btn_red_40_1";
            this.btn_red_40_1.Size = new System.Drawing.Size(56, 35);
            this.btn_red_40_1.TabIndex = 247;
            this.btn_red_40_1.UseVisualStyleBackColor = false;
            this.btn_red_40_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_32_5
            // 
            this.btn_32_5.BackColor = System.Drawing.Color.Black;
            this.btn_32_5.Location = new System.Drawing.Point(623, 413);
            this.btn_32_5.Name = "btn_32_5";
            this.btn_32_5.Size = new System.Drawing.Size(56, 35);
            this.btn_32_5.TabIndex = 246;
            this.btn_32_5.UseVisualStyleBackColor = false;
            this.btn_32_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_32_2
            // 
            this.btn_32_2.BackColor = System.Drawing.Color.Black;
            this.btn_32_2.Location = new System.Drawing.Point(375, 413);
            this.btn_32_2.Name = "btn_32_2";
            this.btn_32_2.Size = new System.Drawing.Size(56, 35);
            this.btn_32_2.TabIndex = 245;
            this.btn_32_2.UseVisualStyleBackColor = false;
            this.btn_32_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_36_3
            // 
            this.btn_36_3.BackColor = System.Drawing.Color.Black;
            this.btn_36_3.Location = new System.Drawing.Point(499, 495);
            this.btn_36_3.Name = "btn_36_3";
            this.btn_36_3.Size = new System.Drawing.Size(56, 35);
            this.btn_36_3.TabIndex = 244;
            this.btn_36_3.UseVisualStyleBackColor = false;
            this.btn_36_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_36_4
            // 
            this.btn_36_4.BackColor = System.Drawing.Color.Black;
            this.btn_36_4.Location = new System.Drawing.Point(747, 495);
            this.btn_36_4.Name = "btn_36_4";
            this.btn_36_4.Size = new System.Drawing.Size(56, 35);
            this.btn_36_4.TabIndex = 243;
            this.btn_36_4.UseVisualStyleBackColor = false;
            this.btn_36_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_36_2
            // 
            this.btn_36_2.BackColor = System.Drawing.Color.Black;
            this.btn_36_2.Location = new System.Drawing.Point(251, 495);
            this.btn_36_2.Name = "btn_36_2";
            this.btn_36_2.Size = new System.Drawing.Size(56, 35);
            this.btn_36_2.TabIndex = 242;
            this.btn_36_2.UseVisualStyleBackColor = false;
            this.btn_36_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_37_5
            // 
            this.btn_37_5.BackColor = System.Drawing.Color.Black;
            this.btn_37_5.Location = new System.Drawing.Point(995, 536);
            this.btn_37_5.Name = "btn_37_5";
            this.btn_37_5.Size = new System.Drawing.Size(56, 35);
            this.btn_37_5.TabIndex = 241;
            this.btn_37_5.UseVisualStyleBackColor = false;
            this.btn_37_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_8
            // 
            this.btn_38_8.BackColor = System.Drawing.Color.Black;
            this.btn_38_8.Location = new System.Drawing.Point(933, 536);
            this.btn_38_8.Name = "btn_38_8";
            this.btn_38_8.Size = new System.Drawing.Size(56, 35);
            this.btn_38_8.TabIndex = 240;
            this.btn_38_8.UseVisualStyleBackColor = false;
            this.btn_38_8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_39_4
            // 
            this.btn_39_4.BackColor = System.Drawing.Color.Black;
            this.btn_39_4.Location = new System.Drawing.Point(871, 536);
            this.btn_39_4.Name = "btn_39_4";
            this.btn_39_4.Size = new System.Drawing.Size(56, 35);
            this.btn_39_4.TabIndex = 239;
            this.btn_39_4.UseVisualStyleBackColor = false;
            this.btn_39_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_7
            // 
            this.btn_38_7.BackColor = System.Drawing.Color.Black;
            this.btn_38_7.Location = new System.Drawing.Point(809, 536);
            this.btn_38_7.Name = "btn_38_7";
            this.btn_38_7.Size = new System.Drawing.Size(56, 35);
            this.btn_38_7.TabIndex = 238;
            this.btn_38_7.UseVisualStyleBackColor = false;
            this.btn_38_7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_37_4
            // 
            this.btn_37_4.BackColor = System.Drawing.Color.Black;
            this.btn_37_4.Location = new System.Drawing.Point(747, 536);
            this.btn_37_4.Name = "btn_37_4";
            this.btn_37_4.Size = new System.Drawing.Size(56, 35);
            this.btn_37_4.TabIndex = 237;
            this.btn_37_4.UseVisualStyleBackColor = false;
            this.btn_37_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_6
            // 
            this.btn_38_6.BackColor = System.Drawing.Color.Black;
            this.btn_38_6.Location = new System.Drawing.Point(685, 536);
            this.btn_38_6.Name = "btn_38_6";
            this.btn_38_6.Size = new System.Drawing.Size(56, 35);
            this.btn_38_6.TabIndex = 236;
            this.btn_38_6.UseVisualStyleBackColor = false;
            this.btn_38_6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_39_3
            // 
            this.btn_39_3.BackColor = System.Drawing.Color.Black;
            this.btn_39_3.Location = new System.Drawing.Point(623, 536);
            this.btn_39_3.Name = "btn_39_3";
            this.btn_39_3.Size = new System.Drawing.Size(56, 35);
            this.btn_39_3.TabIndex = 235;
            this.btn_39_3.UseVisualStyleBackColor = false;
            this.btn_39_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_5
            // 
            this.btn_38_5.BackColor = System.Drawing.Color.Black;
            this.btn_38_5.Location = new System.Drawing.Point(561, 536);
            this.btn_38_5.Name = "btn_38_5";
            this.btn_38_5.Size = new System.Drawing.Size(56, 35);
            this.btn_38_5.TabIndex = 234;
            this.btn_38_5.UseVisualStyleBackColor = false;
            this.btn_38_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_37_3
            // 
            this.btn_37_3.BackColor = System.Drawing.Color.Black;
            this.btn_37_3.Location = new System.Drawing.Point(499, 536);
            this.btn_37_3.Name = "btn_37_3";
            this.btn_37_3.Size = new System.Drawing.Size(56, 35);
            this.btn_37_3.TabIndex = 233;
            this.btn_37_3.UseVisualStyleBackColor = false;
            this.btn_37_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_4
            // 
            this.btn_38_4.BackColor = System.Drawing.Color.Black;
            this.btn_38_4.Location = new System.Drawing.Point(437, 536);
            this.btn_38_4.Name = "btn_38_4";
            this.btn_38_4.Size = new System.Drawing.Size(56, 35);
            this.btn_38_4.TabIndex = 232;
            this.btn_38_4.UseVisualStyleBackColor = false;
            this.btn_38_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_39_2
            // 
            this.btn_39_2.BackColor = System.Drawing.Color.Black;
            this.btn_39_2.Location = new System.Drawing.Point(375, 536);
            this.btn_39_2.Name = "btn_39_2";
            this.btn_39_2.Size = new System.Drawing.Size(56, 35);
            this.btn_39_2.TabIndex = 231;
            this.btn_39_2.UseVisualStyleBackColor = false;
            this.btn_39_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_3
            // 
            this.btn_38_3.BackColor = System.Drawing.Color.Black;
            this.btn_38_3.Location = new System.Drawing.Point(313, 536);
            this.btn_38_3.Name = "btn_38_3";
            this.btn_38_3.Size = new System.Drawing.Size(56, 35);
            this.btn_38_3.TabIndex = 230;
            this.btn_38_3.UseVisualStyleBackColor = false;
            this.btn_38_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_37_2
            // 
            this.btn_37_2.BackColor = System.Drawing.Color.Black;
            this.btn_37_2.Location = new System.Drawing.Point(251, 536);
            this.btn_37_2.Name = "btn_37_2";
            this.btn_37_2.Size = new System.Drawing.Size(56, 35);
            this.btn_37_2.TabIndex = 229;
            this.btn_37_2.UseVisualStyleBackColor = false;
            this.btn_37_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_2
            // 
            this.btn_38_2.BackColor = System.Drawing.Color.Black;
            this.btn_38_2.Location = new System.Drawing.Point(189, 536);
            this.btn_38_2.Name = "btn_38_2";
            this.btn_38_2.Size = new System.Drawing.Size(56, 35);
            this.btn_38_2.TabIndex = 228;
            this.btn_38_2.UseVisualStyleBackColor = false;
            this.btn_38_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_39_1
            // 
            this.btn_39_1.BackColor = System.Drawing.Color.Black;
            this.btn_39_1.Location = new System.Drawing.Point(127, 536);
            this.btn_39_1.Name = "btn_39_1";
            this.btn_39_1.Size = new System.Drawing.Size(56, 35);
            this.btn_39_1.TabIndex = 227;
            this.btn_39_1.UseVisualStyleBackColor = false;
            this.btn_39_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_1
            // 
            this.btn_38_1.BackColor = System.Drawing.Color.Black;
            this.btn_38_1.Location = new System.Drawing.Point(65, 536);
            this.btn_38_1.Name = "btn_38_1";
            this.btn_38_1.Size = new System.Drawing.Size(56, 35);
            this.btn_38_1.TabIndex = 226;
            this.btn_38_1.UseVisualStyleBackColor = false;
            this.btn_38_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_37_1
            // 
            this.btn_37_1.BackColor = System.Drawing.Color.Black;
            this.btn_37_1.Location = new System.Drawing.Point(3, 536);
            this.btn_37_1.Name = "btn_37_1";
            this.btn_37_1.Size = new System.Drawing.Size(56, 35);
            this.btn_37_1.TabIndex = 225;
            this.btn_37_1.UseVisualStyleBackColor = false;
            this.btn_37_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_36_5
            // 
            this.btn_36_5.BackColor = System.Drawing.Color.Black;
            this.btn_36_5.Location = new System.Drawing.Point(995, 495);
            this.btn_36_5.Name = "btn_36_5";
            this.btn_36_5.Size = new System.Drawing.Size(56, 35);
            this.btn_36_5.TabIndex = 224;
            this.btn_36_5.UseVisualStyleBackColor = false;
            this.btn_36_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_36_1
            // 
            this.btn_36_1.BackColor = System.Drawing.Color.Black;
            this.btn_36_1.Location = new System.Drawing.Point(3, 495);
            this.btn_36_1.Name = "btn_36_1";
            this.btn_36_1.Size = new System.Drawing.Size(56, 35);
            this.btn_36_1.TabIndex = 223;
            this.btn_36_1.UseVisualStyleBackColor = false;
            this.btn_36_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_1
            // 
            this.btn_34_1.BackColor = System.Drawing.Color.Black;
            this.btn_34_1.Location = new System.Drawing.Point(65, 454);
            this.btn_34_1.Name = "btn_34_1";
            this.btn_34_1.Size = new System.Drawing.Size(56, 35);
            this.btn_34_1.TabIndex = 222;
            this.btn_34_1.UseVisualStyleBackColor = false;
            this.btn_34_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_35_1
            // 
            this.btn_35_1.BackColor = System.Drawing.Color.White;
            this.btn_35_1.Location = new System.Drawing.Point(3, 454);
            this.btn_35_1.Name = "btn_35_1";
            this.btn_35_1.Size = new System.Drawing.Size(56, 35);
            this.btn_35_1.TabIndex = 221;
            this.btn_35_1.UseVisualStyleBackColor = false;
            this.btn_35_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_35_5
            // 
            this.btn_35_5.BackColor = System.Drawing.Color.White;
            this.btn_35_5.Location = new System.Drawing.Point(995, 454);
            this.btn_35_5.Name = "btn_35_5";
            this.btn_35_5.Size = new System.Drawing.Size(56, 35);
            this.btn_35_5.TabIndex = 220;
            this.btn_35_5.UseVisualStyleBackColor = false;
            this.btn_35_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_8
            // 
            this.btn_34_8.BackColor = System.Drawing.Color.Black;
            this.btn_34_8.Location = new System.Drawing.Point(933, 454);
            this.btn_34_8.Name = "btn_34_8";
            this.btn_34_8.Size = new System.Drawing.Size(56, 35);
            this.btn_34_8.TabIndex = 219;
            this.btn_34_8.UseVisualStyleBackColor = false;
            this.btn_34_8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_6
            // 
            this.btn_34_6.BackColor = System.Drawing.Color.Black;
            this.btn_34_6.Location = new System.Drawing.Point(685, 454);
            this.btn_34_6.Name = "btn_34_6";
            this.btn_34_6.Size = new System.Drawing.Size(56, 35);
            this.btn_34_6.TabIndex = 218;
            this.btn_34_6.UseVisualStyleBackColor = false;
            this.btn_34_6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_3
            // 
            this.btn_34_3.BackColor = System.Drawing.Color.Black;
            this.btn_34_3.Location = new System.Drawing.Point(313, 454);
            this.btn_34_3.Name = "btn_34_3";
            this.btn_34_3.Size = new System.Drawing.Size(56, 35);
            this.btn_34_3.TabIndex = 217;
            this.btn_34_3.UseVisualStyleBackColor = false;
            this.btn_34_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_33_4
            // 
            this.btn_33_4.BackColor = System.Drawing.Color.Black;
            this.btn_33_4.Location = new System.Drawing.Point(623, 454);
            this.btn_33_4.Name = "btn_33_4";
            this.btn_33_4.Size = new System.Drawing.Size(56, 35);
            this.btn_33_4.TabIndex = 216;
            this.btn_33_4.UseVisualStyleBackColor = false;
            this.btn_33_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_5
            // 
            this.btn_34_5.BackColor = System.Drawing.Color.Black;
            this.btn_34_5.Location = new System.Drawing.Point(561, 454);
            this.btn_34_5.Name = "btn_34_5";
            this.btn_34_5.Size = new System.Drawing.Size(56, 35);
            this.btn_34_5.TabIndex = 215;
            this.btn_34_5.UseVisualStyleBackColor = false;
            this.btn_34_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_35_3
            // 
            this.btn_35_3.BackColor = System.Drawing.Color.White;
            this.btn_35_3.Location = new System.Drawing.Point(499, 454);
            this.btn_35_3.Name = "btn_35_3";
            this.btn_35_3.Size = new System.Drawing.Size(56, 35);
            this.btn_35_3.TabIndex = 214;
            this.btn_35_3.UseVisualStyleBackColor = false;
            this.btn_35_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_4
            // 
            this.btn_34_4.BackColor = System.Drawing.Color.Black;
            this.btn_34_4.Location = new System.Drawing.Point(437, 454);
            this.btn_34_4.Name = "btn_34_4";
            this.btn_34_4.Size = new System.Drawing.Size(56, 35);
            this.btn_34_4.TabIndex = 213;
            this.btn_34_4.UseVisualStyleBackColor = false;
            this.btn_34_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_33_2
            // 
            this.btn_33_2.BackColor = System.Drawing.Color.Black;
            this.btn_33_2.Location = new System.Drawing.Point(375, 454);
            this.btn_33_2.Name = "btn_33_2";
            this.btn_33_2.Size = new System.Drawing.Size(56, 35);
            this.btn_33_2.TabIndex = 212;
            this.btn_33_2.UseVisualStyleBackColor = false;
            this.btn_33_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_33_5
            // 
            this.btn_33_5.BackColor = System.Drawing.Color.Black;
            this.btn_33_5.Location = new System.Drawing.Point(871, 454);
            this.btn_33_5.Name = "btn_33_5";
            this.btn_33_5.Size = new System.Drawing.Size(56, 35);
            this.btn_33_5.TabIndex = 211;
            this.btn_33_5.UseVisualStyleBackColor = false;
            this.btn_33_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_35_2
            // 
            this.btn_35_2.BackColor = System.Drawing.Color.White;
            this.btn_35_2.Location = new System.Drawing.Point(251, 454);
            this.btn_35_2.Name = "btn_35_2";
            this.btn_35_2.Size = new System.Drawing.Size(56, 35);
            this.btn_35_2.TabIndex = 210;
            this.btn_35_2.UseVisualStyleBackColor = false;
            this.btn_35_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_2
            // 
            this.btn_34_2.BackColor = System.Drawing.Color.Black;
            this.btn_34_2.Location = new System.Drawing.Point(189, 454);
            this.btn_34_2.Name = "btn_34_2";
            this.btn_34_2.Size = new System.Drawing.Size(56, 35);
            this.btn_34_2.TabIndex = 209;
            this.btn_34_2.UseVisualStyleBackColor = false;
            this.btn_34_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_33_1
            // 
            this.btn_33_1.BackColor = System.Drawing.Color.Black;
            this.btn_33_1.Location = new System.Drawing.Point(127, 454);
            this.btn_33_1.Name = "btn_33_1";
            this.btn_33_1.Size = new System.Drawing.Size(56, 35);
            this.btn_33_1.TabIndex = 208;
            this.btn_33_1.UseVisualStyleBackColor = false;
            this.btn_33_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_7
            // 
            this.btn_34_7.BackColor = System.Drawing.Color.Black;
            this.btn_34_7.Location = new System.Drawing.Point(809, 454);
            this.btn_34_7.Name = "btn_34_7";
            this.btn_34_7.Size = new System.Drawing.Size(56, 35);
            this.btn_34_7.TabIndex = 207;
            this.btn_34_7.UseVisualStyleBackColor = false;
            this.btn_34_7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_35_4
            // 
            this.btn_35_4.BackColor = System.Drawing.Color.White;
            this.btn_35_4.Location = new System.Drawing.Point(747, 454);
            this.btn_35_4.Name = "btn_35_4";
            this.btn_35_4.Size = new System.Drawing.Size(56, 35);
            this.btn_35_4.TabIndex = 206;
            this.btn_35_4.UseVisualStyleBackColor = false;
            this.btn_35_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_32_6
            // 
            this.btn_32_6.BackColor = System.Drawing.Color.Black;
            this.btn_32_6.Location = new System.Drawing.Point(871, 413);
            this.btn_32_6.Name = "btn_32_6";
            this.btn_32_6.Size = new System.Drawing.Size(56, 35);
            this.btn_32_6.TabIndex = 205;
            this.btn_32_6.UseVisualStyleBackColor = false;
            this.btn_32_6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_30_3
            // 
            this.btn_30_3.BackColor = System.Drawing.Color.Black;
            this.btn_30_3.Location = new System.Drawing.Point(685, 372);
            this.btn_30_3.Name = "btn_30_3";
            this.btn_30_3.Size = new System.Drawing.Size(56, 35);
            this.btn_30_3.TabIndex = 204;
            this.btn_30_3.UseVisualStyleBackColor = false;
            this.btn_30_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_30_2
            // 
            this.btn_30_2.BackColor = System.Drawing.Color.Black;
            this.btn_30_2.Location = new System.Drawing.Point(313, 372);
            this.btn_30_2.Name = "btn_30_2";
            this.btn_30_2.Size = new System.Drawing.Size(56, 35);
            this.btn_30_2.TabIndex = 203;
            this.btn_30_2.UseVisualStyleBackColor = false;
            this.btn_30_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_31_3
            // 
            this.btn_31_3.BackColor = System.Drawing.Color.Black;
            this.btn_31_3.Location = new System.Drawing.Point(623, 372);
            this.btn_31_3.Name = "btn_31_3";
            this.btn_31_3.Size = new System.Drawing.Size(56, 35);
            this.btn_31_3.TabIndex = 202;
            this.btn_31_3.UseVisualStyleBackColor = false;
            this.btn_31_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_32_4
            // 
            this.btn_32_4.BackColor = System.Drawing.Color.Black;
            this.btn_32_4.Location = new System.Drawing.Point(561, 372);
            this.btn_32_4.Name = "btn_32_4";
            this.btn_32_4.Size = new System.Drawing.Size(56, 35);
            this.btn_32_4.TabIndex = 201;
            this.btn_32_4.UseVisualStyleBackColor = false;
            this.btn_32_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_33_3
            // 
            this.btn_33_3.BackColor = System.Drawing.Color.Black;
            this.btn_33_3.Location = new System.Drawing.Point(499, 372);
            this.btn_33_3.Name = "btn_33_3";
            this.btn_33_3.Size = new System.Drawing.Size(56, 35);
            this.btn_33_3.TabIndex = 200;
            this.btn_33_3.UseVisualStyleBackColor = false;
            this.btn_33_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_32_3
            // 
            this.btn_32_3.BackColor = System.Drawing.Color.Black;
            this.btn_32_3.Location = new System.Drawing.Point(437, 372);
            this.btn_32_3.Name = "btn_32_3";
            this.btn_32_3.Size = new System.Drawing.Size(56, 35);
            this.btn_32_3.TabIndex = 199;
            this.btn_32_3.UseVisualStyleBackColor = false;
            this.btn_32_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_31_2
            // 
            this.btn_31_2.BackColor = System.Drawing.Color.Black;
            this.btn_31_2.Location = new System.Drawing.Point(375, 372);
            this.btn_31_2.Name = "btn_31_2";
            this.btn_31_2.Size = new System.Drawing.Size(56, 35);
            this.btn_31_2.TabIndex = 198;
            this.btn_31_2.UseVisualStyleBackColor = false;
            this.btn_31_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_31_4
            // 
            this.btn_31_4.BackColor = System.Drawing.Color.Black;
            this.btn_31_4.Location = new System.Drawing.Point(871, 372);
            this.btn_31_4.Name = "btn_31_4";
            this.btn_31_4.Size = new System.Drawing.Size(56, 35);
            this.btn_31_4.TabIndex = 197;
            this.btn_31_4.UseVisualStyleBackColor = false;
            this.btn_31_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_32_1
            // 
            this.btn_32_1.BackColor = System.Drawing.Color.Black;
            this.btn_32_1.Location = new System.Drawing.Point(127, 413);
            this.btn_32_1.Name = "btn_32_1";
            this.btn_32_1.Size = new System.Drawing.Size(56, 35);
            this.btn_32_1.TabIndex = 196;
            this.btn_32_1.UseVisualStyleBackColor = false;
            this.btn_32_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_29_1
            // 
            this.btn_29_1.BackColor = System.Drawing.Color.Black;
            this.btn_29_1.Location = new System.Drawing.Point(251, 372);
            this.btn_29_1.Name = "btn_29_1";
            this.btn_29_1.Size = new System.Drawing.Size(56, 35);
            this.btn_29_1.TabIndex = 195;
            this.btn_29_1.UseVisualStyleBackColor = false;
            this.btn_29_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_30_1
            // 
            this.btn_30_1.BackColor = System.Drawing.Color.Black;
            this.btn_30_1.Location = new System.Drawing.Point(189, 372);
            this.btn_30_1.Name = "btn_30_1";
            this.btn_30_1.Size = new System.Drawing.Size(56, 35);
            this.btn_30_1.TabIndex = 194;
            this.btn_30_1.UseVisualStyleBackColor = false;
            this.btn_30_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_31_1
            // 
            this.btn_31_1.BackColor = System.Drawing.Color.Black;
            this.btn_31_1.Location = new System.Drawing.Point(127, 372);
            this.btn_31_1.Name = "btn_31_1";
            this.btn_31_1.Size = new System.Drawing.Size(56, 35);
            this.btn_31_1.TabIndex = 193;
            this.btn_31_1.UseVisualStyleBackColor = false;
            this.btn_31_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_30_4
            // 
            this.btn_30_4.BackColor = System.Drawing.Color.Black;
            this.btn_30_4.Location = new System.Drawing.Point(809, 372);
            this.btn_30_4.Name = "btn_30_4";
            this.btn_30_4.Size = new System.Drawing.Size(56, 35);
            this.btn_30_4.TabIndex = 192;
            this.btn_30_4.UseVisualStyleBackColor = false;
            this.btn_30_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_29_2
            // 
            this.btn_29_2.BackColor = System.Drawing.Color.Black;
            this.btn_29_2.Location = new System.Drawing.Point(747, 372);
            this.btn_29_2.Name = "btn_29_2";
            this.btn_29_2.Size = new System.Drawing.Size(56, 35);
            this.btn_29_2.TabIndex = 191;
            this.btn_29_2.UseVisualStyleBackColor = false;
            this.btn_29_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_28_2
            // 
            this.btn_28_2.BackColor = System.Drawing.Color.Black;
            this.btn_28_2.Location = new System.Drawing.Point(747, 331);
            this.btn_28_2.Name = "btn_28_2";
            this.btn_28_2.Size = new System.Drawing.Size(56, 35);
            this.btn_28_2.TabIndex = 190;
            this.btn_28_2.UseVisualStyleBackColor = false;
            this.btn_28_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_28_1
            // 
            this.btn_28_1.BackColor = System.Drawing.Color.Black;
            this.btn_28_1.Location = new System.Drawing.Point(251, 331);
            this.btn_28_1.Name = "btn_28_1";
            this.btn_28_1.Size = new System.Drawing.Size(56, 35);
            this.btn_28_1.TabIndex = 189;
            this.btn_28_1.UseVisualStyleBackColor = false;
            this.btn_28_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_27_3
            // 
            this.btn_27_3.BackColor = System.Drawing.Color.Black;
            this.btn_27_3.Location = new System.Drawing.Point(747, 290);
            this.btn_27_3.Name = "btn_27_3";
            this.btn_27_3.Size = new System.Drawing.Size(56, 35);
            this.btn_27_3.TabIndex = 188;
            this.btn_27_3.UseVisualStyleBackColor = false;
            this.btn_27_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_26_4
            // 
            this.btn_26_4.BackColor = System.Drawing.Color.Black;
            this.btn_26_4.Location = new System.Drawing.Point(685, 290);
            this.btn_26_4.Name = "btn_26_4";
            this.btn_26_4.Size = new System.Drawing.Size(56, 35);
            this.btn_26_4.TabIndex = 187;
            this.btn_26_4.UseVisualStyleBackColor = false;
            this.btn_26_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_26_1
            // 
            this.btn_26_1.BackColor = System.Drawing.Color.Black;
            this.btn_26_1.Location = new System.Drawing.Point(313, 290);
            this.btn_26_1.Name = "btn_26_1";
            this.btn_26_1.Size = new System.Drawing.Size(56, 35);
            this.btn_26_1.TabIndex = 186;
            this.btn_26_1.UseVisualStyleBackColor = false;
            this.btn_26_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_27_1
            // 
            this.btn_27_1.BackColor = System.Drawing.Color.Black;
            this.btn_27_1.Location = new System.Drawing.Point(251, 290);
            this.btn_27_1.Name = "btn_27_1";
            this.btn_27_1.Size = new System.Drawing.Size(56, 35);
            this.btn_27_1.TabIndex = 185;
            this.btn_27_1.UseVisualStyleBackColor = false;
            this.btn_27_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_25_2
            // 
            this.btn_25_2.BackColor = System.Drawing.Color.White;
            this.btn_25_2.Location = new System.Drawing.Point(623, 290);
            this.btn_25_2.Name = "btn_25_2";
            this.btn_25_2.Size = new System.Drawing.Size(56, 35);
            this.btn_25_2.TabIndex = 184;
            this.btn_25_2.UseVisualStyleBackColor = false;
            this.btn_25_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_26_3
            // 
            this.btn_26_3.BackColor = System.Drawing.Color.Black;
            this.btn_26_3.Location = new System.Drawing.Point(561, 290);
            this.btn_26_3.Name = "btn_26_3";
            this.btn_26_3.Size = new System.Drawing.Size(56, 35);
            this.btn_26_3.TabIndex = 183;
            this.btn_26_3.UseVisualStyleBackColor = false;
            this.btn_26_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_27_2
            // 
            this.btn_27_2.BackColor = System.Drawing.Color.Black;
            this.btn_27_2.Location = new System.Drawing.Point(499, 290);
            this.btn_27_2.Name = "btn_27_2";
            this.btn_27_2.Size = new System.Drawing.Size(56, 35);
            this.btn_27_2.TabIndex = 182;
            this.btn_27_2.UseVisualStyleBackColor = false;
            this.btn_27_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_26_2
            // 
            this.btn_26_2.BackColor = System.Drawing.Color.Black;
            this.btn_26_2.Location = new System.Drawing.Point(437, 290);
            this.btn_26_2.Name = "btn_26_2";
            this.btn_26_2.Size = new System.Drawing.Size(56, 35);
            this.btn_26_2.TabIndex = 181;
            this.btn_26_2.UseVisualStyleBackColor = false;
            this.btn_26_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_25_1
            // 
            this.btn_25_1.BackColor = System.Drawing.Color.White;
            this.btn_25_1.Location = new System.Drawing.Point(375, 290);
            this.btn_25_1.Name = "btn_25_1";
            this.btn_25_1.Size = new System.Drawing.Size(56, 35);
            this.btn_25_1.TabIndex = 180;
            this.btn_25_1.UseVisualStyleBackColor = false;
            this.btn_25_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_24_2
            // 
            this.btn_24_2.BackColor = System.Drawing.Color.Black;
            this.btn_24_2.Location = new System.Drawing.Point(623, 249);
            this.btn_24_2.Name = "btn_24_2";
            this.btn_24_2.Size = new System.Drawing.Size(56, 35);
            this.btn_24_2.TabIndex = 179;
            this.btn_24_2.UseVisualStyleBackColor = false;
            this.btn_24_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_24_1
            // 
            this.btn_24_1.BackColor = System.Drawing.Color.Black;
            this.btn_24_1.Location = new System.Drawing.Point(375, 249);
            this.btn_24_1.Name = "btn_24_1";
            this.btn_24_1.Size = new System.Drawing.Size(56, 35);
            this.btn_24_1.TabIndex = 178;
            this.btn_24_1.UseVisualStyleBackColor = false;
            this.btn_24_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_23_2
            // 
            this.btn_23_2.BackColor = System.Drawing.Color.Black;
            this.btn_23_2.Location = new System.Drawing.Point(623, 208);
            this.btn_23_2.Name = "btn_23_2";
            this.btn_23_2.Size = new System.Drawing.Size(56, 35);
            this.btn_23_2.TabIndex = 177;
            this.btn_23_2.UseVisualStyleBackColor = false;
            this.btn_23_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_22_2
            // 
            this.btn_22_2.BackColor = System.Drawing.Color.Black;
            this.btn_22_2.Location = new System.Drawing.Point(561, 208);
            this.btn_22_2.Name = "btn_22_2";
            this.btn_22_2.Size = new System.Drawing.Size(56, 35);
            this.btn_22_2.TabIndex = 176;
            this.btn_22_2.UseVisualStyleBackColor = false;
            this.btn_22_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_22_1
            // 
            this.btn_22_1.BackColor = System.Drawing.Color.Black;
            this.btn_22_1.Location = new System.Drawing.Point(437, 208);
            this.btn_22_1.Name = "btn_22_1";
            this.btn_22_1.Size = new System.Drawing.Size(56, 35);
            this.btn_22_1.TabIndex = 175;
            this.btn_22_1.UseVisualStyleBackColor = false;
            this.btn_22_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_23_1
            // 
            this.btn_23_1.BackColor = System.Drawing.Color.Black;
            this.btn_23_1.Location = new System.Drawing.Point(375, 208);
            this.btn_23_1.Name = "btn_23_1";
            this.btn_23_1.Size = new System.Drawing.Size(56, 35);
            this.btn_23_1.TabIndex = 174;
            this.btn_23_1.UseVisualStyleBackColor = false;
            this.btn_23_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_21
            // 
            this.btn_21.BackColor = System.Drawing.Color.White;
            this.btn_21.Location = new System.Drawing.Point(499, 208);
            this.btn_21.Name = "btn_21";
            this.btn_21.Size = new System.Drawing.Size(56, 35);
            this.btn_21.TabIndex = 173;
            this.btn_21.UseVisualStyleBackColor = false;
            this.btn_21.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_20
            // 
            this.btn_20.BackColor = System.Drawing.Color.White;
            this.btn_20.Location = new System.Drawing.Point(499, 167);
            this.btn_20.Name = "btn_20";
            this.btn_20.Size = new System.Drawing.Size(56, 35);
            this.btn_20.TabIndex = 172;
            this.btn_20.UseVisualStyleBackColor = false;
            this.btn_20.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_11_2
            // 
            this.btn_11_2.BackColor = System.Drawing.Color.Black;
            this.btn_11_2.Location = new System.Drawing.Point(995, 126);
            this.btn_11_2.Name = "btn_11_2";
            this.btn_11_2.Size = new System.Drawing.Size(56, 35);
            this.btn_11_2.TabIndex = 171;
            this.btn_11_2.UseVisualStyleBackColor = false;
            this.btn_11_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_12_2
            // 
            this.btn_12_2.BackColor = System.Drawing.Color.Black;
            this.btn_12_2.Location = new System.Drawing.Point(933, 126);
            this.btn_12_2.Name = "btn_12_2";
            this.btn_12_2.Size = new System.Drawing.Size(56, 35);
            this.btn_12_2.TabIndex = 170;
            this.btn_12_2.UseVisualStyleBackColor = false;
            this.btn_12_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_13_2
            // 
            this.btn_13_2.BackColor = System.Drawing.Color.Black;
            this.btn_13_2.Location = new System.Drawing.Point(871, 126);
            this.btn_13_2.Name = "btn_13_2";
            this.btn_13_2.Size = new System.Drawing.Size(56, 35);
            this.btn_13_2.TabIndex = 169;
            this.btn_13_2.UseVisualStyleBackColor = false;
            this.btn_13_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_14_2
            // 
            this.btn_14_2.BackColor = System.Drawing.Color.Black;
            this.btn_14_2.Location = new System.Drawing.Point(809, 126);
            this.btn_14_2.Name = "btn_14_2";
            this.btn_14_2.Size = new System.Drawing.Size(56, 35);
            this.btn_14_2.TabIndex = 168;
            this.btn_14_2.UseVisualStyleBackColor = false;
            this.btn_14_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_15_2
            // 
            this.btn_15_2.BackColor = System.Drawing.Color.Black;
            this.btn_15_2.Location = new System.Drawing.Point(747, 126);
            this.btn_15_2.Name = "btn_15_2";
            this.btn_15_2.Size = new System.Drawing.Size(56, 35);
            this.btn_15_2.TabIndex = 167;
            this.btn_15_2.UseVisualStyleBackColor = false;
            this.btn_15_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_16_2
            // 
            this.btn_16_2.BackColor = System.Drawing.Color.Black;
            this.btn_16_2.Location = new System.Drawing.Point(685, 126);
            this.btn_16_2.Name = "btn_16_2";
            this.btn_16_2.Size = new System.Drawing.Size(56, 35);
            this.btn_16_2.TabIndex = 166;
            this.btn_16_2.UseVisualStyleBackColor = false;
            this.btn_16_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_17_2
            // 
            this.btn_17_2.BackColor = System.Drawing.Color.Black;
            this.btn_17_2.Location = new System.Drawing.Point(623, 126);
            this.btn_17_2.Name = "btn_17_2";
            this.btn_17_2.Size = new System.Drawing.Size(56, 35);
            this.btn_17_2.TabIndex = 165;
            this.btn_17_2.UseVisualStyleBackColor = false;
            this.btn_17_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_18_2
            // 
            this.btn_18_2.BackColor = System.Drawing.Color.Black;
            this.btn_18_2.Location = new System.Drawing.Point(561, 126);
            this.btn_18_2.Name = "btn_18_2";
            this.btn_18_2.Size = new System.Drawing.Size(56, 35);
            this.btn_18_2.TabIndex = 164;
            this.btn_18_2.UseVisualStyleBackColor = false;
            this.btn_18_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_19
            // 
            this.btn_19.BackColor = System.Drawing.Color.White;
            this.btn_19.Location = new System.Drawing.Point(499, 126);
            this.btn_19.Name = "btn_19";
            this.btn_19.Size = new System.Drawing.Size(56, 35);
            this.btn_19.TabIndex = 163;
            this.btn_19.UseVisualStyleBackColor = false;
            this.btn_19.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_18_1
            // 
            this.btn_18_1.BackColor = System.Drawing.Color.Black;
            this.btn_18_1.Location = new System.Drawing.Point(437, 126);
            this.btn_18_1.Name = "btn_18_1";
            this.btn_18_1.Size = new System.Drawing.Size(56, 35);
            this.btn_18_1.TabIndex = 162;
            this.btn_18_1.UseVisualStyleBackColor = false;
            this.btn_18_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_17_1
            // 
            this.btn_17_1.BackColor = System.Drawing.Color.Black;
            this.btn_17_1.Location = new System.Drawing.Point(375, 126);
            this.btn_17_1.Name = "btn_17_1";
            this.btn_17_1.Size = new System.Drawing.Size(56, 35);
            this.btn_17_1.TabIndex = 161;
            this.btn_17_1.UseVisualStyleBackColor = false;
            this.btn_17_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_16_1
            // 
            this.btn_16_1.BackColor = System.Drawing.Color.Black;
            this.btn_16_1.Location = new System.Drawing.Point(313, 126);
            this.btn_16_1.Name = "btn_16_1";
            this.btn_16_1.Size = new System.Drawing.Size(56, 35);
            this.btn_16_1.TabIndex = 160;
            this.btn_16_1.UseVisualStyleBackColor = false;
            this.btn_16_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_15_1
            // 
            this.btn_15_1.BackColor = System.Drawing.Color.Black;
            this.btn_15_1.Location = new System.Drawing.Point(251, 126);
            this.btn_15_1.Name = "btn_15_1";
            this.btn_15_1.Size = new System.Drawing.Size(56, 35);
            this.btn_15_1.TabIndex = 159;
            this.btn_15_1.UseVisualStyleBackColor = false;
            this.btn_15_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_14_1
            // 
            this.btn_14_1.BackColor = System.Drawing.Color.Black;
            this.btn_14_1.Location = new System.Drawing.Point(189, 126);
            this.btn_14_1.Name = "btn_14_1";
            this.btn_14_1.Size = new System.Drawing.Size(56, 35);
            this.btn_14_1.TabIndex = 158;
            this.btn_14_1.UseVisualStyleBackColor = false;
            this.btn_14_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_13_1
            // 
            this.btn_13_1.BackColor = System.Drawing.Color.Black;
            this.btn_13_1.Location = new System.Drawing.Point(127, 126);
            this.btn_13_1.Name = "btn_13_1";
            this.btn_13_1.Size = new System.Drawing.Size(56, 35);
            this.btn_13_1.TabIndex = 157;
            this.btn_13_1.UseVisualStyleBackColor = false;
            this.btn_13_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_12_1
            // 
            this.btn_12_1.BackColor = System.Drawing.Color.Black;
            this.btn_12_1.Location = new System.Drawing.Point(65, 126);
            this.btn_12_1.Name = "btn_12_1";
            this.btn_12_1.Size = new System.Drawing.Size(56, 35);
            this.btn_12_1.TabIndex = 156;
            this.btn_12_1.UseVisualStyleBackColor = false;
            this.btn_12_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_11_1
            // 
            this.btn_11_1.BackColor = System.Drawing.Color.Black;
            this.btn_11_1.Location = new System.Drawing.Point(3, 126);
            this.btn_11_1.Name = "btn_11_1";
            this.btn_11_1.Size = new System.Drawing.Size(56, 35);
            this.btn_11_1.TabIndex = 155;
            this.btn_11_1.UseVisualStyleBackColor = false;
            this.btn_11_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_10_2
            // 
            this.btn_10_2.BackColor = System.Drawing.Color.Black;
            this.btn_10_2.Location = new System.Drawing.Point(995, 85);
            this.btn_10_2.Name = "btn_10_2";
            this.btn_10_2.Size = new System.Drawing.Size(56, 35);
            this.btn_10_2.TabIndex = 154;
            this.btn_10_2.UseVisualStyleBackColor = false;
            this.btn_10_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_10_1
            // 
            this.btn_10_1.BackColor = System.Drawing.Color.Black;
            this.btn_10_1.Location = new System.Drawing.Point(3, 85);
            this.btn_10_1.Name = "btn_10_1";
            this.btn_10_1.Size = new System.Drawing.Size(56, 35);
            this.btn_10_1.TabIndex = 153;
            this.btn_10_1.UseVisualStyleBackColor = false;
            this.btn_10_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_0_ziel
            // 
            this.btn_0_ziel.BackColor = System.Drawing.Color.Magenta;
            this.btn_0_ziel.Location = new System.Drawing.Point(499, 3);
            this.btn_0_ziel.Name = "btn_0_ziel";
            this.btn_0_ziel.Size = new System.Drawing.Size(56, 35);
            this.btn_0_ziel.TabIndex = 152;
            this.btn_0_ziel.UseVisualStyleBackColor = false;
            this.btn_0_ziel.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_9_2
            // 
            this.btn_9_2.BackColor = System.Drawing.Color.Black;
            this.btn_9_2.Location = new System.Drawing.Point(995, 44);
            this.btn_9_2.Name = "btn_9_2";
            this.btn_9_2.Size = new System.Drawing.Size(56, 35);
            this.btn_9_2.TabIndex = 151;
            this.btn_9_2.UseVisualStyleBackColor = false;
            this.btn_9_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_8_2
            // 
            this.btn_8_2.BackColor = System.Drawing.Color.Black;
            this.btn_8_2.Location = new System.Drawing.Point(933, 44);
            this.btn_8_2.Name = "btn_8_2";
            this.btn_8_2.Size = new System.Drawing.Size(56, 35);
            this.btn_8_2.TabIndex = 150;
            this.btn_8_2.UseVisualStyleBackColor = false;
            this.btn_8_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_7_2
            // 
            this.btn_7_2.BackColor = System.Drawing.Color.Black;
            this.btn_7_2.Location = new System.Drawing.Point(871, 44);
            this.btn_7_2.Name = "btn_7_2";
            this.btn_7_2.Size = new System.Drawing.Size(56, 35);
            this.btn_7_2.TabIndex = 149;
            this.btn_7_2.UseVisualStyleBackColor = false;
            this.btn_7_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_6_2
            // 
            this.btn_6_2.BackColor = System.Drawing.Color.Black;
            this.btn_6_2.Location = new System.Drawing.Point(809, 44);
            this.btn_6_2.Name = "btn_6_2";
            this.btn_6_2.Size = new System.Drawing.Size(56, 35);
            this.btn_6_2.TabIndex = 148;
            this.btn_6_2.UseVisualStyleBackColor = false;
            this.btn_6_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_5_2
            // 
            this.btn_5_2.BackColor = System.Drawing.Color.Black;
            this.btn_5_2.Location = new System.Drawing.Point(747, 44);
            this.btn_5_2.Name = "btn_5_2";
            this.btn_5_2.Size = new System.Drawing.Size(56, 35);
            this.btn_5_2.TabIndex = 147;
            this.btn_5_2.UseVisualStyleBackColor = false;
            this.btn_5_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_4_2
            // 
            this.btn_4_2.BackColor = System.Drawing.Color.Black;
            this.btn_4_2.Location = new System.Drawing.Point(685, 44);
            this.btn_4_2.Name = "btn_4_2";
            this.btn_4_2.Size = new System.Drawing.Size(56, 35);
            this.btn_4_2.TabIndex = 146;
            this.btn_4_2.UseVisualStyleBackColor = false;
            this.btn_4_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_3_2
            // 
            this.btn_3_2.BackColor = System.Drawing.Color.Black;
            this.btn_3_2.Location = new System.Drawing.Point(623, 44);
            this.btn_3_2.Name = "btn_3_2";
            this.btn_3_2.Size = new System.Drawing.Size(56, 35);
            this.btn_3_2.TabIndex = 145;
            this.btn_3_2.UseVisualStyleBackColor = false;
            this.btn_3_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_2_2
            // 
            this.btn_2_2.BackColor = System.Drawing.Color.Black;
            this.btn_2_2.Location = new System.Drawing.Point(561, 44);
            this.btn_2_2.Name = "btn_2_2";
            this.btn_2_2.Size = new System.Drawing.Size(56, 35);
            this.btn_2_2.TabIndex = 144;
            this.btn_2_2.UseVisualStyleBackColor = false;
            this.btn_2_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(499, 44);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(56, 35);
            this.btn_1.TabIndex = 143;
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_2_1
            // 
            this.btn_2_1.BackColor = System.Drawing.Color.Black;
            this.btn_2_1.Location = new System.Drawing.Point(437, 44);
            this.btn_2_1.Name = "btn_2_1";
            this.btn_2_1.Size = new System.Drawing.Size(56, 35);
            this.btn_2_1.TabIndex = 142;
            this.btn_2_1.UseVisualStyleBackColor = false;
            this.btn_2_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_3_1
            // 
            this.btn_3_1.BackColor = System.Drawing.Color.Black;
            this.btn_3_1.Location = new System.Drawing.Point(375, 44);
            this.btn_3_1.Name = "btn_3_1";
            this.btn_3_1.Size = new System.Drawing.Size(56, 35);
            this.btn_3_1.TabIndex = 141;
            this.btn_3_1.UseVisualStyleBackColor = false;
            this.btn_3_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_4_1
            // 
            this.btn_4_1.BackColor = System.Drawing.Color.Black;
            this.btn_4_1.Location = new System.Drawing.Point(313, 44);
            this.btn_4_1.Name = "btn_4_1";
            this.btn_4_1.Size = new System.Drawing.Size(56, 35);
            this.btn_4_1.TabIndex = 140;
            this.btn_4_1.UseVisualStyleBackColor = false;
            this.btn_4_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_5_1
            // 
            this.btn_5_1.BackColor = System.Drawing.Color.Black;
            this.btn_5_1.Location = new System.Drawing.Point(251, 44);
            this.btn_5_1.Name = "btn_5_1";
            this.btn_5_1.Size = new System.Drawing.Size(56, 35);
            this.btn_5_1.TabIndex = 139;
            this.btn_5_1.UseVisualStyleBackColor = false;
            this.btn_5_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_6_1
            // 
            this.btn_6_1.BackColor = System.Drawing.Color.Black;
            this.btn_6_1.Location = new System.Drawing.Point(189, 44);
            this.btn_6_1.Name = "btn_6_1";
            this.btn_6_1.Size = new System.Drawing.Size(56, 35);
            this.btn_6_1.TabIndex = 138;
            this.btn_6_1.UseVisualStyleBackColor = false;
            this.btn_6_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_7_1
            // 
            this.btn_7_1.BackColor = System.Drawing.Color.Black;
            this.btn_7_1.Location = new System.Drawing.Point(127, 44);
            this.btn_7_1.Name = "btn_7_1";
            this.btn_7_1.Size = new System.Drawing.Size(56, 35);
            this.btn_7_1.TabIndex = 137;
            this.btn_7_1.UseVisualStyleBackColor = false;
            this.btn_7_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_8_1
            // 
            this.btn_8_1.BackColor = System.Drawing.Color.Black;
            this.btn_8_1.Location = new System.Drawing.Point(65, 44);
            this.btn_8_1.Name = "btn_8_1";
            this.btn_8_1.Size = new System.Drawing.Size(56, 35);
            this.btn_8_1.TabIndex = 136;
            this.btn_8_1.UseVisualStyleBackColor = false;
            this.btn_8_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_9_1
            // 
            this.btn_9_1.BackColor = System.Drawing.Color.Black;
            this.btn_9_1.Location = new System.Drawing.Point(3, 44);
            this.btn_9_1.Name = "btn_9_1";
            this.btn_9_1.Size = new System.Drawing.Size(56, 35);
            this.btn_9_1.TabIndex = 135;
            this.btn_9_1.UseVisualStyleBackColor = false;
            this.btn_9_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_aussetzen
            // 
            this.btn_aussetzen.Enabled = false;
            this.btn_aussetzen.Location = new System.Drawing.Point(951, 706);
            this.btn_aussetzen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_aussetzen.Name = "btn_aussetzen";
            this.btn_aussetzen.Size = new System.Drawing.Size(115, 37);
            this.btn_aussetzen.TabIndex = 138;
            this.btn_aussetzen.Text = "Aussetzen";
            this.btn_aussetzen.UseVisualStyleBackColor = true;
            this.btn_aussetzen.Click += new System.EventHandler(this.btn_aussetzen_Click);
            // 
            // lbl_Anleitungen
            // 
            this.lbl_Anleitungen.Location = new System.Drawing.Point(186, 739);
            this.lbl_Anleitungen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Anleitungen.Name = "lbl_Anleitungen";
            this.lbl_Anleitungen.Size = new System.Drawing.Size(684, 41);
            this.lbl_Anleitungen.TabIndex = 139;
            this.lbl_Anleitungen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(951, 747);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(115, 37);
            this.btn_reset.TabIndex = 140;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // frm_Spielfeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 808);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_Anleitungen);
            this.Controls.Add(this.btn_aussetzen);
            this.Controls.Add(this.pnl_alleFelder);
            this.Controls.Add(this.lbl_Wurfzahl);
            this.Controls.Add(this.btn_wuerfeln);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Spielfeld";
            this.Text = "Projekt M";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Spielfeld_FormClosing);
            this.pnl_alleFelder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_wuerfeln;
        private Label lbl_Wurfzahl;
        private Panel pnl_alleFelder;
        private Button btn_aussetzen;
        private Label lbl_Anleitungen;
        private Feld btn_9_1;
        private Feld btn_11_2;
        private Feld btn_12_2;
        private Feld btn_13_2;
        private Feld btn_14_2;
        private Feld btn_15_2;
        private Feld btn_16_2;
        private Feld btn_17_2;
        private Feld btn_18_2;
        private Feld btn_19;
        private Feld btn_18_1;
        private Feld btn_17_1;
        private Feld btn_16_1;
        private Feld btn_15_1;
        private Feld btn_14_1;
        private Feld btn_13_1;
        private Feld btn_12_1;
        private Feld btn_11_1;
        private Feld btn_10_2;
        private Feld btn_10_1;
        private Feld btn_0_ziel;
        private Feld btn_9_2;
        private Feld btn_8_2;
        private Feld btn_7_2;
        private Feld btn_6_2;
        private Feld btn_5_2;
        private Feld btn_4_2;
        private Feld btn_3_2;
        private Feld btn_2_2;
        private Feld btn_1;
        private Feld btn_2_1;
        private Feld btn_3_1;
        private Feld btn_4_1;
        private Feld btn_5_1;
        private Feld btn_6_1;
        private Feld btn_7_1;
        private Feld btn_8_1;
        private Feld btn_32_5;
        private Feld btn_32_2;
        private Feld btn_36_3;
        private Feld btn_36_4;
        private Feld btn_36_2;
        private Feld btn_37_5;
        private Feld btn_38_8;
        private Feld btn_39_4;
        private Feld btn_38_7;
        private Feld btn_37_4;
        private Feld btn_38_6;
        private Feld btn_39_3;
        private Feld btn_38_5;
        private Feld btn_37_3;
        private Feld btn_38_4;
        private Feld btn_39_2;
        private Feld btn_38_3;
        private Feld btn_37_2;
        private Feld btn_38_2;
        private Feld btn_39_1;
        private Feld btn_38_1;
        private Feld btn_37_1;
        private Feld btn_36_5;
        private Feld btn_36_1;
        private Feld btn_34_1;
        private Feld btn_35_1;
        private Feld btn_35_5;
        private Feld btn_34_8;
        private Feld btn_34_6;
        private Feld btn_34_3;
        private Feld btn_33_4;
        private Feld btn_34_5;
        private Feld btn_35_3;
        private Feld btn_34_4;
        private Feld btn_33_2;
        private Feld btn_33_5;
        private Feld btn_35_2;
        private Feld btn_34_2;
        private Feld btn_33_1;
        private Feld btn_34_7;
        private Feld btn_35_4;
        private Feld btn_32_6;
        private Feld btn_30_3;
        private Feld btn_30_2;
        private Feld btn_31_3;
        private Feld btn_32_4;
        private Feld btn_33_3;
        private Feld btn_32_3;
        private Feld btn_31_2;
        private Feld btn_31_4;
        private Feld btn_32_1;
        private Feld btn_29_1;
        private Feld btn_30_1;
        private Feld btn_31_1;
        private Feld btn_30_4;
        private Feld btn_29_2;
        private Feld btn_28_2;
        private Feld btn_28_1;
        private Feld btn_27_3;
        private Feld btn_26_4;
        private Feld btn_26_1;
        private Feld btn_27_1;
        private Feld btn_25_2;
        private Feld btn_26_3;
        private Feld btn_27_2;
        private Feld btn_26_2;
        private Feld btn_25_1;
        private Feld btn_24_2;
        private Feld btn_24_1;
        private Feld btn_23_2;
        private Feld btn_22_2;
        private Feld btn_22_1;
        private Feld btn_23_1;
        private Feld btn_21;
        private Feld btn_20;
        private Startfeld btn_green_40_2;
        private Startfeld btn_green_40_3;
        private Startfeld btn_green_40_4;
        private Startfeld btn_green_40_5;
        private Startfeld btn_green_40_1;
        private Startfeld btn_red_40_2;
        private Startfeld btn_red_40_3;
        private Startfeld btn_red_40_4;
        private Startfeld btn_red_40_5;
        private Startfeld btn_red_40_1;
        private Startfeld btn_blue_40_2;
        private Startfeld btn_blue_40_3;
        private Startfeld btn_blue_40_4;
        private Startfeld btn_blue_40_5;
        private Startfeld btn_blue_40_1;
        private Startfeld btn_yellow_40_2;
        private Startfeld btn_yellow_40_3;
        private Startfeld btn_yellow_40_4;
        private Startfeld btn_yellow_40_5;
        private Startfeld btn_yellow_40_1;
        private Button btn_reset;
    }
}

