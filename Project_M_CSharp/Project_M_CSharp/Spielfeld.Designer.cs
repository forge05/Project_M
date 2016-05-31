
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
            this.btn_8_1 = new Feld(Feld.Content.EMPTY, 8);
            this.btn_9_1 = new Feld(Feld.Content.EMPTY, 9);
            this.btn_10_1 = new Feld(Feld.Content.EMPTY, 10);
            this.btn_1 = new Feld(Feld.Content.BLOCK, 1);
            this.btn_2_1 = new Feld(Feld.Content.EMPTY, 2);
            this.btn_3_1 = new Feld(Feld.Content.EMPTY, 3);
            this.btn_4_1 = new Feld(Feld.Content.EMPTY, 4);
            this.btn_5_1 = new Feld(Feld.Content.EMPTY, 5);
            this.btn_6_1 = new Feld(Feld.Content.EMPTY, 6);
            this.btn_7_1 = new Feld(Feld.Content.EMPTY, 7);
            this.btn_17_1 = new Feld(Feld.Content.EMPTY, 17);
            this.btn_16_1 = new Feld(Feld.Content.EMPTY, 16);
            this.btn_15_1 = new Feld(Feld.Content.EMPTY, 15);
            this.btn_14_1 = new Feld(Feld.Content.EMPTY, 14);
            this.btn_13_1 = new Feld(Feld.Content.EMPTY, 13);
            this.btn_12_1 = new Feld(Feld.Content.EMPTY, 12);
            this.btn_11_1 = new Feld(Feld.Content.EMPTY, 11);
            this.btn_8_2 = new Feld(Feld.Content.EMPTY, 8);
            this.btn_7_2 = new Feld(Feld.Content.EMPTY, 7);
            this.btn_6_2 = new Feld(Feld.Content.EMPTY, 6);
            this.btn_5_2 = new Feld(Feld.Content.EMPTY, 5);
            this.btn_4_2 = new Feld(Feld.Content.EMPTY, 4);
            this.btn_3_2 = new Feld(Feld.Content.EMPTY, 3);
            this.btn_2_2 = new Feld(Feld.Content.EMPTY, 2);
            this.btn_19_1 = new Feld(Feld.Content.BLOCK, 19);
            this.btn_18_1 = new Feld(Feld.Content.EMPTY, 18);
            this.btn_15_2 = new Feld(Feld.Content.EMPTY, 15);
            this.btn_14_2 = new Feld(Feld.Content.EMPTY, 14);
            this.btn_13_2 = new Feld(Feld.Content.EMPTY, 13);
            this.btn_12_2 = new Feld(Feld.Content.EMPTY, 12);
            this.btn_11_2 = new Feld(Feld.Content.EMPTY, 11);
            this.btn_10_2 = new Feld(Feld.Content.EMPTY, 10);
            this.btn_9_2 = new Feld(Feld.Content.EMPTY, 9);
            this.btn_22_2 = new Feld(Feld.Content.EMPTY, 22);
            this.btn_23_1 = new Feld(Feld.Content.EMPTY, 23);
            this.btn_22_1 = new Feld(Feld.Content.EMPTY, 22);
            this.btn_21_1 = new Feld(Feld.Content.BLOCK, 21);
            this.btn_20_1 = new Feld(Feld.Content.BLOCK, 20);
            this.btn_18_2 = new Feld(Feld.Content.EMPTY, 18);
            this.btn_17_2 = new Feld(Feld.Content.EMPTY, 17);
            this.btn_16_2 = new Feld(Feld.Content.EMPTY, 16);
            this.btn_26_3 = new Feld(Feld.Content.EMPTY, 26);
            this.btn_27_2 = new Feld(Feld.Content.EMPTY, 27);
            this.btn_26_2 = new Feld(Feld.Content.EMPTY, 26);
            this.btn_25_1 = new Feld(Feld.Content.BLOCK, 25);
            this.btn_24_1 = new Feld(Feld.Content.EMPTY, 24);
            this.btn_24_2 = new Feld(Feld.Content.EMPTY, 24);
            this.btn_23_2 = new Feld(Feld.Content.EMPTY, 23);
            this.btn_28_1 = new Feld(Feld.Content.EMPTY, 28);
            this.btn_27_1 = new Feld(Feld.Content.EMPTY, 27);
            this.btn_26_1 = new Feld(Feld.Content.EMPTY, 26);
            this.btn_25_2 = new Feld(Feld.Content.BLOCK, 25);
            this.btn_31_2 = new Feld(Feld.Content.EMPTY, 31);
            this.btn_32_3 = new Feld(Feld.Content.EMPTY, 32);
            this.btn_33_3 = new Feld(Feld.Content.EMPTY, 33);
            this.btn_32_4 = new Feld(Feld.Content.EMPTY, 32);
            this.btn_31_3 = new Feld(Feld.Content.EMPTY, 31);
            this.btn_30_3 = new Feld(Feld.Content.EMPTY, 30);
            this.btn_29_2 = new Feld(Feld.Content.EMPTY, 29);
            this.btn_28_2 = new Feld(Feld.Content.EMPTY, 28);
            this.btn_27_3 = new Feld(Feld.Content.EMPTY, 27);
            this.btn_26_4 = new Feld(Feld.Content.EMPTY, 26);
            this.btn_29_1 = new Feld(Feld.Content.EMPTY, 29);
            this.btn_30_2 = new Feld(Feld.Content.EMPTY, 30);
            this.btn_34_3 = new Feld(Feld.Content.EMPTY, 34);
            this.btn_35_2 = new Feld(Feld.Content.BLOCK, 35);
            this.btn_34_2 = new Feld(Feld.Content.EMPTY, 34);
            this.btn_35_1 = new Feld(Feld.Content.BLOCK, 35);
            this.btn_34_1 = new Feld(Feld.Content.EMPTY, 34);
            this.btn_33_1 = new Feld(Feld.Content.EMPTY, 33);
            this.btn_32_1 = new Feld(Feld.Content.EMPTY, 32);
            this.btn_35_5 = new Feld(Feld.Content.BLOCK, 35);
            this.btn_34_8 = new Feld(Feld.Content.EMPTY, 34);
            this.btn_33_5 = new Feld(Feld.Content.EMPTY, 33);
            this.btn_32_6 = new Feld(Feld.Content.EMPTY, 32);
            this.btn_31_4 = new Feld(Feld.Content.EMPTY, 31);
            this.btn_30_4 = new Feld(Feld.Content.EMPTY, 30);
            this.btn_31_1 = new Feld(Feld.Content.EMPTY, 31);
            this.btn_30_1 = new Feld(Feld.Content.EMPTY, 30);
            this.btn_38_6 = new Feld(Feld.Content.EMPTY, 38);
            this.btn_38_7 = new Feld(Feld.Content.EMPTY, 38);
            this.btn_39_4 = new Feld(Feld.Content.EMPTY, 39);
            this.btn_38_8 = new Feld(Feld.Content.EMPTY, 38);
            this.btn_37_5 = new Feld(Feld.Content.EMPTY, 37);
            this.btn_36_5 = new Feld(Feld.Content.EMPTY, 36);
            this.btn_34_7 = new Feld(Feld.Content.EMPTY, 34);
            this.btn_35_4 = new Feld(Feld.Content.BLOCK, 35);
            this.btn_34_6 = new Feld(Feld.Content.EMPTY, 34);
            this.btn_32_5 = new Feld(Feld.Content.EMPTY, 32);
            this.btn_33_4 = new Feld(Feld.Content.EMPTY, 33);
            this.btn_34_5 = new Feld(Feld.Content.EMPTY, 34);
            this.btn_35_3 = new Feld(Feld.Content.BLOCK, 35);
            this.btn_34_4 = new Feld(Feld.Content.EMPTY, 34);
            this.btn_32_2 = new Feld(Feld.Content.EMPTY, 32);
            this.btn_33_2 = new Feld(Feld.Content.EMPTY, 33);
            this.btn_38_4 = new Feld(Feld.Content.EMPTY, 38);
            this.btn_37_3 = new Feld(Feld.Content.EMPTY, 37);
            this.btn_38_5 = new Feld(Feld.Content.EMPTY, 38);
            this.btn_39_3 = new Feld(Feld.Content.EMPTY, 39);
            this.btn_37_4 = new Feld(Feld.Content.EMPTY, 37);
            this.btn_37_1 = new Feld(Feld.Content.EMPTY, 37);
            this.btn_38_1 = new Feld(Feld.Content.EMPTY, 38);
            this.btn_39_1 = new Feld(Feld.Content.EMPTY, 39);
            this.btn_38_2 = new Feld(Feld.Content.EMPTY, 38);
            this.btn_37_2 = new Feld(Feld.Content.EMPTY, 37);
            this.btn_38_3 = new Feld(Feld.Content.EMPTY, 38);
            this.btn_39_2 = new Feld(Feld.Content.EMPTY, 39);
            this.btn_36_1 = new Feld(Feld.Content.EMPTY, 36);
            this.btn_36_4 = new Feld(Feld.Content.EMPTY, 36);
            this.btn_36_3 = new Feld(Feld.Content.EMPTY, 36);
            this.btn_36_2 = new Feld(Feld.Content.EMPTY, 36);
            this.btn_40_red_4 = new Feld(Feld.Content.RED, 40);
            this.btn_40_red_3 = new Feld(Feld.Content.RED, 40);
            this.btn_40_red_5 = new Feld(Feld.Content.RED, 40);
            this.btn_40_red_2 = new Feld(Feld.Content.RED, 40);
            this.btn_40_red_1 = new Feld(Feld.Content.RED, 40);
            this.btn_40_green_4 = new Feld(Feld.Content.GREEN, 40);
            this.btn_40_green_3 = new Feld(Feld.Content.GREEN, 40);
            this.btn_40_green_5 = new Feld(Feld.Content.GREEN, 40);
            this.btn_40_green_2 = new Feld(Feld.Content.GREEN, 40);
            this.btn_40_green_1 = new Feld(Feld.Content.GREEN, 40);
            this.btn_40_yellow_4 = new Feld(Feld.Content.YELLOW, 40);
            this.btn_40_yellow_3 = new Feld(Feld.Content.YELLOW, 40);
            this.btn_40_yellow_5 = new Feld(Feld.Content.YELLOW, 40);
            this.btn_40_yellow_2 = new Feld(Feld.Content.YELLOW, 40);
            this.btn_40_yellow_1 = new Feld(Feld.Content.YELLOW, 40);
            this.btn_40_blue_4 = new Feld(Feld.Content.BLUE, 40);
            this.btn_40_blue_3 = new Feld(Feld.Content.BLUE, 40);
            this.btn_40_blue_5 = new Feld(Feld.Content.BLUE, 40);
            this.btn_40_blue_2 = new Feld(Feld.Content.BLUE, 40);
            this.btn_40_blue_1 = new Feld(Feld.Content.BLUE, 40);
            this.btn_0_ziel = new Feld(Feld.Content.GOAL, 0);

            //weise Nachbarn zu
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
            btn_18_1.setNachbar(btn_17_1, btn_19_1);
            btn_18_2.setNachbar(btn_17_2, btn_19_1);
            btn_19_1.setNachbar(btn_18_1, btn_18_2, btn_20_1);
            btn_20_1.setNachbar(btn_19_1, btn_21_1);
            btn_21_1.setNachbar(btn_20_1, btn_22_1, btn_22_2);
            btn_22_1.setNachbar(btn_21_1, btn_23_1);
            btn_22_2.setNachbar(btn_21_1, btn_23_2);
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
            btn_39_1.setNachbar(btn_38_1, btn_38_2, btn_40_red_1, btn_40_red_2, btn_40_red_3, btn_40_red_4, btn_40_red_5);
            btn_39_2.setNachbar(btn_38_3, btn_38_4, btn_40_green_1, btn_40_green_2, btn_40_green_3, btn_40_green_4, btn_40_green_5);
            btn_39_3.setNachbar(btn_38_5, btn_38_6, btn_40_yellow_1, btn_40_yellow_2, btn_40_yellow_3, btn_40_yellow_4, btn_40_yellow_5);
            btn_39_4.setNachbar(btn_38_7, btn_38_8, btn_40_blue_1, btn_40_blue_2, btn_40_blue_3, btn_40_blue_4, btn_40_blue_5);
            btn_40_red_1.setNachbar(btn_39_1);
            btn_40_red_2.setNachbar(btn_39_1);
            btn_40_red_3.setNachbar(btn_39_1);
            btn_40_red_4.setNachbar(btn_39_1);
            btn_40_red_5.setNachbar(btn_39_1);
            btn_40_green_1.setNachbar(btn_39_2);
            btn_40_green_2.setNachbar(btn_39_2);
            btn_40_green_3.setNachbar(btn_39_2);
            btn_40_green_4.setNachbar(btn_39_2);
            btn_40_green_5.setNachbar(btn_39_2);
            btn_40_yellow_1.setNachbar(btn_39_3);
            btn_40_yellow_2.setNachbar(btn_39_3);
            btn_40_yellow_3.setNachbar(btn_39_3);
            btn_40_yellow_4.setNachbar(btn_39_3);
            btn_40_yellow_5.setNachbar(btn_39_3);
            btn_40_blue_1.setNachbar(btn_39_4);
            btn_40_blue_2.setNachbar(btn_39_4);
            btn_40_blue_3.setNachbar(btn_39_4);
            btn_40_blue_4.setNachbar(btn_39_4);
            btn_40_blue_5.setNachbar(btn_39_4);

            this.btn_wuerfeln = new System.Windows.Forms.Button();
            this.lbl_wurfzahl = new System.Windows.Forms.Label();
            this.pnl_alleFelder = new System.Windows.Forms.Panel();
            this.btn_aussetzen = new System.Windows.Forms.Button();
            this.lbl_anleitungen = new System.Windows.Forms.Label();
            this.pnl_alleFelder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_8_1
            // 
            this.btn_8_1.BackColor = System.Drawing.Color.Black;
            this.btn_8_1.Location = new System.Drawing.Point(116, 52);
            this.btn_8_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_8_1.Name = "btn_8_1";
            this.btn_8_1.Size = new System.Drawing.Size(75, 43);
            this.btn_8_1.TabIndex = 11;
            this.btn_8_1.Tag = 8;
            this.btn_8_1.UseVisualStyleBackColor = false;
            this.btn_8_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_7_1
            // 
            this.btn_7_1.BackColor = System.Drawing.Color.Black;
            this.btn_7_1.Location = new System.Drawing.Point(197, 52);
            this.btn_7_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_7_1.Name = "btn_7_1";
            this.btn_7_1.Size = new System.Drawing.Size(75, 43);
            this.btn_7_1.TabIndex = 10;
            this.btn_7_1.Tag = 7;
            this.btn_7_1.UseVisualStyleBackColor = false;
            this.btn_7_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_6_1
            // 
            this.btn_6_1.BackColor = System.Drawing.Color.Black;
            this.btn_6_1.Location = new System.Drawing.Point(277, 52);
            this.btn_6_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_6_1.Name = "btn_6_1";
            this.btn_6_1.Size = new System.Drawing.Size(75, 43);
            this.btn_6_1.TabIndex = 9;
            this.btn_6_1.Tag = 6;
            this.btn_6_1.UseVisualStyleBackColor = false;
            this.btn_6_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_5_1
            // 
            this.btn_5_1.BackColor = System.Drawing.Color.Black;
            this.btn_5_1.Location = new System.Drawing.Point(359, 52);
            this.btn_5_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_5_1.Name = "btn_5_1";
            this.btn_5_1.Size = new System.Drawing.Size(75, 43);
            this.btn_5_1.TabIndex = 8;
            this.btn_5_1.Tag = 5;
            this.btn_5_1.UseVisualStyleBackColor = false;
            this.btn_5_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_4_1
            // 
            this.btn_4_1.BackColor = System.Drawing.Color.Black;
            this.btn_4_1.Location = new System.Drawing.Point(440, 52);
            this.btn_4_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_4_1.Name = "btn_4_1";
            this.btn_4_1.Size = new System.Drawing.Size(75, 43);
            this.btn_4_1.TabIndex = 7;
            this.btn_4_1.Tag = 4;
            this.btn_4_1.UseVisualStyleBackColor = false;
            this.btn_4_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_3_1
            // 
            this.btn_3_1.BackColor = System.Drawing.Color.Black;
            this.btn_3_1.Location = new System.Drawing.Point(521, 52);
            this.btn_3_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_3_1.Name = "btn_3_1";
            this.btn_3_1.Size = new System.Drawing.Size(75, 43);
            this.btn_3_1.TabIndex = 6;
            this.btn_3_1.Tag = 3;
            this.btn_3_1.UseVisualStyleBackColor = false;
            this.btn_3_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_2_1
            // 
            this.btn_2_1.BackColor = System.Drawing.Color.Black;
            this.btn_2_1.Location = new System.Drawing.Point(603, 52);
            this.btn_2_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_2_1.Name = "btn_2_1";
            this.btn_2_1.Size = new System.Drawing.Size(75, 43);
            this.btn_2_1.TabIndex = 5;
            this.btn_2_1.Tag = 2;
            this.btn_2_1.UseVisualStyleBackColor = false;
            this.btn_2_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(683, 52);
            this.btn_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 43);
            this.btn_1.TabIndex = 4;
            this.btn_1.Tag = 1;
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_0_ziel
            // 
            this.btn_0_ziel.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_0_ziel.Location = new System.Drawing.Point(683, 2);
            this.btn_0_ziel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_0_ziel.Name = "btn_0_ziel";
            this.btn_0_ziel.Size = new System.Drawing.Size(75, 43);
            this.btn_0_ziel.TabIndex = 134;
            this.btn_0_ziel.Tag = 0;
            this.btn_0_ziel.UseVisualStyleBackColor = false;
            this.btn_0_ziel.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_2_2
            // 
            this.btn_2_2.BackColor = System.Drawing.Color.Black;
            this.btn_2_2.Location = new System.Drawing.Point(765, 52);
            this.btn_2_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_2_2.Name = "btn_2_2";
            this.btn_2_2.Size = new System.Drawing.Size(75, 43);
            this.btn_2_2.TabIndex = 26;
            this.btn_2_2.Tag = 2;
            this.btn_2_2.UseVisualStyleBackColor = false;
            this.btn_2_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_3_2
            // 
            this.btn_3_2.BackColor = System.Drawing.Color.Black;
            this.btn_3_2.Location = new System.Drawing.Point(845, 52);
            this.btn_3_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_3_2.Name = "btn_3_2";
            this.btn_3_2.Size = new System.Drawing.Size(75, 43);
            this.btn_3_2.TabIndex = 25;
            this.btn_3_2.Tag = 3;
            this.btn_3_2.UseVisualStyleBackColor = false;
            this.btn_3_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_4_2
            // 
            this.btn_4_2.BackColor = System.Drawing.Color.Black;
            this.btn_4_2.Location = new System.Drawing.Point(927, 52);
            this.btn_4_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_4_2.Name = "btn_4_2";
            this.btn_4_2.Size = new System.Drawing.Size(75, 43);
            this.btn_4_2.TabIndex = 24;
            this.btn_4_2.Tag = 4;
            this.btn_4_2.UseVisualStyleBackColor = false;
            this.btn_4_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_5_2
            // 
            this.btn_5_2.BackColor = System.Drawing.Color.Black;
            this.btn_5_2.Location = new System.Drawing.Point(1008, 52);
            this.btn_5_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_5_2.Name = "btn_5_2";
            this.btn_5_2.Size = new System.Drawing.Size(75, 43);
            this.btn_5_2.TabIndex = 23;
            this.btn_5_2.Tag = 5;
            this.btn_5_2.UseVisualStyleBackColor = false;
            this.btn_5_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_6_2
            // 
            this.btn_6_2.BackColor = System.Drawing.Color.Black;
            this.btn_6_2.Location = new System.Drawing.Point(1089, 52);
            this.btn_6_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_6_2.Name = "btn_6_2";
            this.btn_6_2.Size = new System.Drawing.Size(75, 43);
            this.btn_6_2.TabIndex = 22;
            this.btn_6_2.Tag = 6;
            this.btn_6_2.UseVisualStyleBackColor = false;
            this.btn_6_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_7_2
            // 
            this.btn_7_2.BackColor = System.Drawing.Color.Black;
            this.btn_7_2.Location = new System.Drawing.Point(1171, 52);
            this.btn_7_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_7_2.Name = "btn_7_2";
            this.btn_7_2.Size = new System.Drawing.Size(75, 43);
            this.btn_7_2.TabIndex = 21;
            this.btn_7_2.Tag = 7;
            this.btn_7_2.UseVisualStyleBackColor = false;
            this.btn_7_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_8_2
            // 
            this.btn_8_2.BackColor = System.Drawing.Color.Black;
            this.btn_8_2.Location = new System.Drawing.Point(1251, 52);
            this.btn_8_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_8_2.Name = "btn_8_2";
            this.btn_8_2.Size = new System.Drawing.Size(75, 43);
            this.btn_8_2.TabIndex = 20;
            this.btn_8_2.Tag = 8;
            this.btn_8_2.UseVisualStyleBackColor = false;
            this.btn_8_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_9_2
            // 
            this.btn_9_2.BackColor = System.Drawing.Color.Black;
            this.btn_9_2.Location = new System.Drawing.Point(1332, 52);
            this.btn_9_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_9_2.Name = "btn_9_2";
            this.btn_9_2.Size = new System.Drawing.Size(75, 43);
            this.btn_9_2.TabIndex = 35;
            this.btn_9_2.Tag = 9;
            this.btn_9_2.UseVisualStyleBackColor = false;
            this.btn_9_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_10_2
            // 
            this.btn_10_2.BackColor = System.Drawing.Color.Black;
            this.btn_10_2.Location = new System.Drawing.Point(1332, 101);
            this.btn_10_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_10_2.Name = "btn_10_2";
            this.btn_10_2.Size = new System.Drawing.Size(75, 43);
            this.btn_10_2.TabIndex = 34;
            this.btn_10_2.Tag = 10;
            this.btn_10_2.UseVisualStyleBackColor = false;
            this.btn_10_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_11_2
            // 
            this.btn_11_2.BackColor = System.Drawing.Color.Black;
            this.btn_11_2.Location = new System.Drawing.Point(1332, 150);
            this.btn_11_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_11_2.Name = "btn_11_2";
            this.btn_11_2.Size = new System.Drawing.Size(75, 43);
            this.btn_11_2.TabIndex = 33;
            this.btn_11_2.Tag = 11;
            this.btn_11_2.UseVisualStyleBackColor = false;
            this.btn_11_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_12_2
            // 
            this.btn_12_2.BackColor = System.Drawing.Color.Black;
            this.btn_12_2.Location = new System.Drawing.Point(1251, 150);
            this.btn_12_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_12_2.Name = "btn_12_2";
            this.btn_12_2.Size = new System.Drawing.Size(75, 43);
            this.btn_12_2.TabIndex = 32;
            this.btn_12_2.Tag = 12;
            this.btn_12_2.UseVisualStyleBackColor = false;
            this.btn_12_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_13_2
            // 
            this.btn_13_2.BackColor = System.Drawing.Color.Black;
            this.btn_13_2.Location = new System.Drawing.Point(1171, 150);
            this.btn_13_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_13_2.Name = "btn_13_2";
            this.btn_13_2.Size = new System.Drawing.Size(75, 43);
            this.btn_13_2.TabIndex = 31;
            this.btn_13_2.Tag = 13;
            this.btn_13_2.UseVisualStyleBackColor = false;
            this.btn_13_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_14_2
            // 
            this.btn_14_2.BackColor = System.Drawing.Color.Black;
            this.btn_14_2.Location = new System.Drawing.Point(1089, 150);
            this.btn_14_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_14_2.Name = "btn_14_2";
            this.btn_14_2.Size = new System.Drawing.Size(75, 43);
            this.btn_14_2.TabIndex = 30;
            this.btn_14_2.Tag = 14;
            this.btn_14_2.UseVisualStyleBackColor = false;
            this.btn_14_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_15_2
            // 
            this.btn_15_2.BackColor = System.Drawing.Color.Black;
            this.btn_15_2.Location = new System.Drawing.Point(1008, 150);
            this.btn_15_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_15_2.Name = "btn_15_2";
            this.btn_15_2.Size = new System.Drawing.Size(75, 43);
            this.btn_15_2.TabIndex = 29;
            this.btn_15_2.Tag = 15;
            this.btn_15_2.UseVisualStyleBackColor = false;
            this.btn_15_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_16_2
            // 
            this.btn_16_2.BackColor = System.Drawing.Color.Black;
            this.btn_16_2.Location = new System.Drawing.Point(927, 150);
            this.btn_16_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_16_2.Name = "btn_16_2";
            this.btn_16_2.Size = new System.Drawing.Size(75, 43);
            this.btn_16_2.TabIndex = 43;
            this.btn_16_2.Tag = 16;
            this.btn_16_2.UseVisualStyleBackColor = false;
            this.btn_16_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_17_2
            // 
            this.btn_17_2.BackColor = System.Drawing.Color.Black;
            this.btn_17_2.Location = new System.Drawing.Point(845, 150);
            this.btn_17_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_17_2.Name = "btn_17_2";
            this.btn_17_2.Size = new System.Drawing.Size(75, 43);
            this.btn_17_2.TabIndex = 42;
            this.btn_17_2.Tag = 17;
            this.btn_17_2.UseVisualStyleBackColor = false;
            this.btn_17_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_18_2
            // 
            this.btn_18_2.BackColor = System.Drawing.Color.Black;
            this.btn_18_2.Location = new System.Drawing.Point(765, 150);
            this.btn_18_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_18_2.Name = "btn_18_2";
            this.btn_18_2.Size = new System.Drawing.Size(75, 43);
            this.btn_18_2.TabIndex = 41;
            this.btn_18_2.Tag = 18;
            this.btn_18_2.UseVisualStyleBackColor = false;
            this.btn_18_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_19_1
            // 
            this.btn_19_1.BackColor = System.Drawing.Color.White;
            this.btn_19_1.Location = new System.Drawing.Point(683, 150);
            this.btn_19_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_19_1.Name = "btn_19_1";
            this.btn_19_1.Size = new System.Drawing.Size(75, 43);
            this.btn_19_1.TabIndex = 27;
            this.btn_19_1.Tag = 19;
            this.btn_19_1.UseVisualStyleBackColor = false;
            this.btn_19_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_18_1
            // 
            this.btn_18_1.BackColor = System.Drawing.Color.Black;
            this.btn_18_1.Location = new System.Drawing.Point(603, 150);
            this.btn_18_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_18_1.Name = "btn_18_1";
            this.btn_18_1.Size = new System.Drawing.Size(75, 43);
            this.btn_18_1.TabIndex = 28;
            this.btn_18_1.Tag = 18;
            this.btn_18_1.UseVisualStyleBackColor = false;
            this.btn_18_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_17_1
            // 
            this.btn_17_1.BackColor = System.Drawing.Color.Black;
            this.btn_17_1.Location = new System.Drawing.Point(521, 150);
            this.btn_17_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_17_1.Name = "btn_17_1";
            this.btn_17_1.Size = new System.Drawing.Size(75, 43);
            this.btn_17_1.TabIndex = 12;
            this.btn_17_1.Tag = 17;
            this.btn_17_1.UseVisualStyleBackColor = false;
            this.btn_17_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_16_1
            // 
            this.btn_16_1.BackColor = System.Drawing.Color.Black;
            this.btn_16_1.Location = new System.Drawing.Point(440, 150);
            this.btn_16_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_16_1.Name = "btn_16_1";
            this.btn_16_1.Size = new System.Drawing.Size(75, 43);
            this.btn_16_1.TabIndex = 13;
            this.btn_16_1.Tag = 16;
            this.btn_16_1.UseVisualStyleBackColor = false;
            this.btn_16_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_15_1
            // 
            this.btn_15_1.BackColor = System.Drawing.Color.Black;
            this.btn_15_1.Location = new System.Drawing.Point(359, 150);
            this.btn_15_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_15_1.Name = "btn_15_1";
            this.btn_15_1.Size = new System.Drawing.Size(75, 43);
            this.btn_15_1.TabIndex = 14;
            this.btn_15_1.Tag = 15;
            this.btn_15_1.UseVisualStyleBackColor = false;
            this.btn_15_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_14_1
            // 
            this.btn_14_1.BackColor = System.Drawing.Color.Black;
            this.btn_14_1.Location = new System.Drawing.Point(277, 150);
            this.btn_14_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_14_1.Name = "btn_14_1";
            this.btn_14_1.Size = new System.Drawing.Size(75, 43);
            this.btn_14_1.TabIndex = 15;
            this.btn_14_1.Tag = 14;
            this.btn_14_1.UseVisualStyleBackColor = false;
            this.btn_14_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_13_1
            // 
            this.btn_13_1.BackColor = System.Drawing.Color.Black;
            this.btn_13_1.Location = new System.Drawing.Point(197, 150);
            this.btn_13_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_13_1.Name = "btn_13_1";
            this.btn_13_1.Size = new System.Drawing.Size(75, 43);
            this.btn_13_1.TabIndex = 16;
            this.btn_13_1.Tag = 13;
            this.btn_13_1.UseVisualStyleBackColor = false;
            this.btn_13_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_12_1
            // 
            this.btn_12_1.BackColor = System.Drawing.Color.Black;
            this.btn_12_1.Location = new System.Drawing.Point(116, 150);
            this.btn_12_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_12_1.Name = "btn_12_1";
            this.btn_12_1.Size = new System.Drawing.Size(75, 43);
            this.btn_12_1.TabIndex = 17;
            this.btn_12_1.Tag = 12;
            this.btn_12_1.UseVisualStyleBackColor = false;
            this.btn_12_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_11_1
            // 
            this.btn_11_1.BackColor = System.Drawing.Color.Black;
            this.btn_11_1.Location = new System.Drawing.Point(35, 150);
            this.btn_11_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_11_1.Name = "btn_11_1";
            this.btn_11_1.Size = new System.Drawing.Size(75, 43);
            this.btn_11_1.TabIndex = 18;
            this.btn_11_1.Tag = 11;
            this.btn_11_1.UseVisualStyleBackColor = false;
            this.btn_11_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_10_1
            // 
            this.btn_10_1.BackColor = System.Drawing.Color.Black;
            this.btn_10_1.Location = new System.Drawing.Point(35, 101);
            this.btn_10_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_10_1.Name = "btn_10_1";
            this.btn_10_1.Size = new System.Drawing.Size(75, 43);
            this.btn_10_1.TabIndex = 19;
            this.btn_10_1.Tag = 10;
            this.btn_10_1.UseVisualStyleBackColor = false;
            this.btn_10_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_9_1
            // 
            this.btn_9_1.BackColor = System.Drawing.Color.Black;
            this.btn_9_1.Location = new System.Drawing.Point(35, 52);
            this.btn_9_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_9_1.Name = "btn_9_1";
            this.btn_9_1.Size = new System.Drawing.Size(75, 43);
            this.btn_9_1.TabIndex = 3;
            this.btn_9_1.Tag = 9;
            this.btn_9_1.UseVisualStyleBackColor = false;
            this.btn_9_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_20_1
            // 
            this.btn_20_1.BackColor = System.Drawing.Color.White;
            this.btn_20_1.Location = new System.Drawing.Point(683, 199);
            this.btn_20_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_20_1.Name = "btn_20_1";
            this.btn_20_1.Size = new System.Drawing.Size(75, 43);
            this.btn_20_1.TabIndex = 40;
            this.btn_20_1.Tag = 20;
            this.btn_20_1.UseVisualStyleBackColor = false;
            this.btn_20_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_21_1
            // 
            this.btn_21_1.BackColor = System.Drawing.Color.White;
            this.btn_21_1.Location = new System.Drawing.Point(683, 249);
            this.btn_21_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_21_1.Name = "btn_21_1";
            this.btn_21_1.Size = new System.Drawing.Size(75, 43);
            this.btn_21_1.TabIndex = 39;
            this.btn_21_1.Tag = 21;
            this.btn_21_1.UseVisualStyleBackColor = false;
            this.btn_21_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_22_1
            // 
            this.btn_22_1.BackColor = System.Drawing.Color.Black;
            this.btn_22_1.Location = new System.Drawing.Point(603, 249);
            this.btn_22_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_22_1.Name = "btn_22_1";
            this.btn_22_1.Size = new System.Drawing.Size(75, 43);
            this.btn_22_1.TabIndex = 38;
            this.btn_22_1.Tag = 22;
            this.btn_22_1.UseVisualStyleBackColor = false;
            this.btn_22_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_23_1
            // 
            this.btn_23_1.BackColor = System.Drawing.Color.Black;
            this.btn_23_1.Location = new System.Drawing.Point(521, 249);
            this.btn_23_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_23_1.Name = "btn_23_1";
            this.btn_23_1.Size = new System.Drawing.Size(75, 43);
            this.btn_23_1.TabIndex = 37;
            this.btn_23_1.Tag = 23;
            this.btn_23_1.UseVisualStyleBackColor = false;
            this.btn_23_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_24_1
            // 
            this.btn_24_1.BackColor = System.Drawing.Color.Black;
            this.btn_24_1.Location = new System.Drawing.Point(521, 297);
            this.btn_24_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_24_1.Name = "btn_24_1";
            this.btn_24_1.Size = new System.Drawing.Size(75, 43);
            this.btn_24_1.TabIndex = 48;
            this.btn_24_1.Tag = 24;
            this.btn_24_1.UseVisualStyleBackColor = false;
            this.btn_24_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_25_1
            // 
            this.btn_25_1.BackColor = System.Drawing.Color.White;
            this.btn_25_1.Location = new System.Drawing.Point(521, 346);
            this.btn_25_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_25_1.Name = "btn_25_1";
            this.btn_25_1.Size = new System.Drawing.Size(75, 43);
            this.btn_25_1.TabIndex = 47;
            this.btn_25_1.Tag = 25;
            this.btn_25_1.UseVisualStyleBackColor = false;
            this.btn_25_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_26_1
            // 
            this.btn_26_1.BackColor = System.Drawing.Color.Black;
            this.btn_26_1.Location = new System.Drawing.Point(440, 346);
            this.btn_26_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_26_1.Name = "btn_26_1";
            this.btn_26_1.Size = new System.Drawing.Size(75, 43);
            this.btn_26_1.TabIndex = 53;
            this.btn_26_1.Tag = 26;
            this.btn_26_1.UseVisualStyleBackColor = false;
            this.btn_26_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_27_1
            // 
            this.btn_27_1.BackColor = System.Drawing.Color.Black;
            this.btn_27_1.Location = new System.Drawing.Point(359, 346);
            this.btn_27_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_27_1.Name = "btn_27_1";
            this.btn_27_1.Size = new System.Drawing.Size(75, 43);
            this.btn_27_1.TabIndex = 52;
            this.btn_27_1.Tag = 27;
            this.btn_27_1.UseVisualStyleBackColor = false;
            this.btn_27_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_28_1
            // 
            this.btn_28_1.BackColor = System.Drawing.Color.Black;
            this.btn_28_1.Location = new System.Drawing.Point(359, 395);
            this.btn_28_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_28_1.Name = "btn_28_1";
            this.btn_28_1.Size = new System.Drawing.Size(75, 43);
            this.btn_28_1.TabIndex = 51;
            this.btn_28_1.Tag = 28;
            this.btn_28_1.UseVisualStyleBackColor = false;
            this.btn_28_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_29_1
            // 
            this.btn_29_1.BackColor = System.Drawing.Color.Black;
            this.btn_29_1.Location = new System.Drawing.Point(359, 444);
            this.btn_29_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_29_1.Name = "btn_29_1";
            this.btn_29_1.Size = new System.Drawing.Size(75, 43);
            this.btn_29_1.TabIndex = 65;
            this.btn_29_1.Tag = 29;
            this.btn_29_1.UseVisualStyleBackColor = false;
            this.btn_29_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_30_1
            // 
            this.btn_30_1.BackColor = System.Drawing.Color.Black;
            this.btn_30_1.Location = new System.Drawing.Point(277, 444);
            this.btn_30_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_30_1.Name = "btn_30_1";
            this.btn_30_1.Size = new System.Drawing.Size(75, 43);
            this.btn_30_1.TabIndex = 81;
            this.btn_30_1.Tag = 30;
            this.btn_30_1.UseVisualStyleBackColor = false;
            this.btn_30_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_31_1
            // 
            this.btn_31_1.BackColor = System.Drawing.Color.Black;
            this.btn_31_1.Location = new System.Drawing.Point(197, 444);
            this.btn_31_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_31_1.Name = "btn_31_1";
            this.btn_31_1.Size = new System.Drawing.Size(75, 43);
            this.btn_31_1.TabIndex = 80;
            this.btn_31_1.Tag = 31;
            this.btn_31_1.UseVisualStyleBackColor = false;
            this.btn_31_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_32_1
            // 
            this.btn_32_1.BackColor = System.Drawing.Color.Black;
            this.btn_32_1.Location = new System.Drawing.Point(197, 494);
            this.btn_32_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_32_1.Name = "btn_32_1";
            this.btn_32_1.Size = new System.Drawing.Size(75, 43);
            this.btn_32_1.TabIndex = 73;
            this.btn_32_1.Tag = 32;
            this.btn_32_1.UseVisualStyleBackColor = false;
            this.btn_32_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_33_1
            // 
            this.btn_33_1.BackColor = System.Drawing.Color.Black;
            this.btn_33_1.Location = new System.Drawing.Point(197, 542);
            this.btn_33_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_33_1.Name = "btn_33_1";
            this.btn_33_1.Size = new System.Drawing.Size(75, 43);
            this.btn_33_1.TabIndex = 72;
            this.btn_33_1.Tag = 33;
            this.btn_33_1.UseVisualStyleBackColor = false;
            this.btn_33_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_1
            // 
            this.btn_34_1.BackColor = System.Drawing.Color.Black;
            this.btn_34_1.Location = new System.Drawing.Point(116, 542);
            this.btn_34_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_34_1.Name = "btn_34_1";
            this.btn_34_1.Size = new System.Drawing.Size(75, 43);
            this.btn_34_1.TabIndex = 71;
            this.btn_34_1.Tag = 34;
            this.btn_34_1.UseVisualStyleBackColor = false;
            this.btn_34_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_35_1
            // 
            this.btn_35_1.BackColor = System.Drawing.Color.White;
            this.btn_35_1.Location = new System.Drawing.Point(35, 542);
            this.btn_35_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_35_1.Name = "btn_35_1";
            this.btn_35_1.Size = new System.Drawing.Size(75, 43);
            this.btn_35_1.TabIndex = 70;
            this.btn_35_1.Tag = 35;
            this.btn_35_1.UseVisualStyleBackColor = false;
            this.btn_35_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_36_1
            // 
            this.btn_36_1.BackColor = System.Drawing.Color.Black;
            this.btn_36_1.Location = new System.Drawing.Point(37, 591);
            this.btn_36_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_36_1.Name = "btn_36_1";
            this.btn_36_1.Size = new System.Drawing.Size(75, 43);
            this.btn_36_1.TabIndex = 110;
            this.btn_36_1.Tag = 36;
            this.btn_36_1.UseVisualStyleBackColor = false;
            this.btn_36_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_37_1
            // 
            this.btn_37_1.BackColor = System.Drawing.Color.Black;
            this.btn_37_1.Location = new System.Drawing.Point(37, 640);
            this.btn_37_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_37_1.Name = "btn_37_1";
            this.btn_37_1.Size = new System.Drawing.Size(75, 43);
            this.btn_37_1.TabIndex = 103;
            this.btn_37_1.Tag = 37;
            this.btn_37_1.UseVisualStyleBackColor = false;
            this.btn_37_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_1
            // 
            this.btn_38_1.BackColor = System.Drawing.Color.Black;
            this.btn_38_1.Location = new System.Drawing.Point(116, 640);
            this.btn_38_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_38_1.Name = "btn_38_1";
            this.btn_38_1.Size = new System.Drawing.Size(75, 43);
            this.btn_38_1.TabIndex = 104;
            this.btn_38_1.Tag = 38;
            this.btn_38_1.UseVisualStyleBackColor = false;
            this.btn_38_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_39_1
            // 
            this.btn_39_1.BackColor = System.Drawing.Color.Black;
            this.btn_39_1.Location = new System.Drawing.Point(197, 640);
            this.btn_39_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_39_1.Name = "btn_39_1";
            this.btn_39_1.Size = new System.Drawing.Size(75, 43);
            this.btn_39_1.TabIndex = 105;
            this.btn_39_1.Tag = 39;
            this.btn_39_1.UseVisualStyleBackColor = false;
            this.btn_39_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_2
            // 
            this.btn_38_2.BackColor = System.Drawing.Color.Black;
            this.btn_38_2.Location = new System.Drawing.Point(277, 640);
            this.btn_38_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_38_2.Name = "btn_38_2";
            this.btn_38_2.Size = new System.Drawing.Size(75, 43);
            this.btn_38_2.TabIndex = 106;
            this.btn_38_2.Tag = 38;
            this.btn_38_2.UseVisualStyleBackColor = false;
            this.btn_38_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_37_2
            // 
            this.btn_37_2.BackColor = System.Drawing.Color.Black;
            this.btn_37_2.Location = new System.Drawing.Point(359, 640);
            this.btn_37_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_37_2.Name = "btn_37_2";
            this.btn_37_2.Size = new System.Drawing.Size(75, 43);
            this.btn_37_2.TabIndex = 107;
            this.btn_37_2.Tag = 37;
            this.btn_37_2.UseVisualStyleBackColor = false;
            this.btn_37_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_36_2
            // 
            this.btn_36_2.BackColor = System.Drawing.Color.Black;
            this.btn_36_2.Location = new System.Drawing.Point(359, 591);
            this.btn_36_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_36_2.Name = "btn_36_2";
            this.btn_36_2.Size = new System.Drawing.Size(75, 43);
            this.btn_36_2.TabIndex = 113;
            this.btn_36_2.Tag = 36;
            this.btn_36_2.UseVisualStyleBackColor = false;
            this.btn_36_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_35_2
            // 
            this.btn_35_2.BackColor = System.Drawing.Color.White;
            this.btn_35_2.Location = new System.Drawing.Point(359, 542);
            this.btn_35_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_35_2.Name = "btn_35_2";
            this.btn_35_2.Size = new System.Drawing.Size(75, 43);
            this.btn_35_2.TabIndex = 68;
            this.btn_35_2.Tag = 35;
            this.btn_35_2.UseVisualStyleBackColor = false;
            this.btn_35_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_2
            // 
            this.btn_34_2.BackColor = System.Drawing.Color.Black;
            this.btn_34_2.Location = new System.Drawing.Point(277, 542);
            this.btn_34_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_34_2.Name = "btn_34_2";
            this.btn_34_2.Size = new System.Drawing.Size(75, 43);
            this.btn_34_2.TabIndex = 69;
            this.btn_34_2.Tag = 34;
            this.btn_34_2.UseVisualStyleBackColor = false;
            this.btn_34_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_3
            // 
            this.btn_34_3.BackColor = System.Drawing.Color.Black;
            this.btn_34_3.Location = new System.Drawing.Point(440, 542);
            this.btn_34_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_34_3.Name = "btn_34_3";
            this.btn_34_3.Size = new System.Drawing.Size(75, 43);
            this.btn_34_3.TabIndex = 67;
            this.btn_34_3.Tag = 34;
            this.btn_34_3.UseVisualStyleBackColor = false;
            this.btn_34_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_33_2
            // 
            this.btn_33_2.BackColor = System.Drawing.Color.Black;
            this.btn_33_2.Location = new System.Drawing.Point(521, 542);
            this.btn_33_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_33_2.Name = "btn_33_2";
            this.btn_33_2.Size = new System.Drawing.Size(75, 43);
            this.btn_33_2.TabIndex = 97;
            this.btn_33_2.Tag = 33;
            this.btn_33_2.UseVisualStyleBackColor = false;
            this.btn_33_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_32_2
            // 
            this.btn_32_2.BackColor = System.Drawing.Color.Black;
            this.btn_32_2.Location = new System.Drawing.Point(521, 494);
            this.btn_32_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_32_2.Name = "btn_32_2";
            this.btn_32_2.Size = new System.Drawing.Size(75, 43);
            this.btn_32_2.TabIndex = 96;
            this.btn_32_2.Tag = 32;
            this.btn_32_2.UseVisualStyleBackColor = false;
            this.btn_32_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_31_2
            // 
            this.btn_31_2.BackColor = System.Drawing.Color.Black;
            this.btn_31_2.Location = new System.Drawing.Point(521, 444);
            this.btn_31_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_31_2.Name = "btn_31_2";
            this.btn_31_2.Size = new System.Drawing.Size(75, 43);
            this.btn_31_2.TabIndex = 55;
            this.btn_31_2.Tag = 31;
            this.btn_31_2.UseVisualStyleBackColor = false;
            this.btn_31_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_30_2
            // 
            this.btn_30_2.BackColor = System.Drawing.Color.Black;
            this.btn_30_2.Location = new System.Drawing.Point(440, 444);
            this.btn_30_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_30_2.Name = "btn_30_2";
            this.btn_30_2.Size = new System.Drawing.Size(75, 43);
            this.btn_30_2.TabIndex = 66;
            this.btn_30_2.Tag = 30;
            this.btn_30_2.UseVisualStyleBackColor = false;
            this.btn_30_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_32_3
            // 
            this.btn_32_3.BackColor = System.Drawing.Color.Black;
            this.btn_32_3.Location = new System.Drawing.Point(603, 444);
            this.btn_32_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_32_3.Name = "btn_32_3";
            this.btn_32_3.Size = new System.Drawing.Size(75, 43);
            this.btn_32_3.TabIndex = 56;
            this.btn_32_3.Tag = 32;
            this.btn_32_3.UseVisualStyleBackColor = false;
            this.btn_32_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_33_3
            // 
            this.btn_33_3.BackColor = System.Drawing.Color.Black;
            this.btn_33_3.Location = new System.Drawing.Point(683, 444);
            this.btn_33_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_33_3.Name = "btn_33_3";
            this.btn_33_3.Size = new System.Drawing.Size(75, 43);
            this.btn_33_3.TabIndex = 57;
            this.btn_33_3.Tag = 33;
            this.btn_33_3.UseVisualStyleBackColor = false;
            this.btn_33_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_32_4
            // 
            this.btn_32_4.BackColor = System.Drawing.Color.Black;
            this.btn_32_4.Location = new System.Drawing.Point(765, 444);
            this.btn_32_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_32_4.Name = "btn_32_4";
            this.btn_32_4.Size = new System.Drawing.Size(75, 43);
            this.btn_32_4.TabIndex = 58;
            this.btn_32_4.Tag = 32;
            this.btn_32_4.UseVisualStyleBackColor = false;
            this.btn_32_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_31_3
            // 
            this.btn_31_3.BackColor = System.Drawing.Color.Black;
            this.btn_31_3.Location = new System.Drawing.Point(845, 444);
            this.btn_31_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_31_3.Name = "btn_31_3";
            this.btn_31_3.Size = new System.Drawing.Size(75, 43);
            this.btn_31_3.TabIndex = 59;
            this.btn_31_3.Tag = 31;
            this.btn_31_3.UseVisualStyleBackColor = false;
            this.btn_31_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_30_3
            // 
            this.btn_30_3.BackColor = System.Drawing.Color.Black;
            this.btn_30_3.Location = new System.Drawing.Point(927, 444);
            this.btn_30_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_30_3.Name = "btn_30_3";
            this.btn_30_3.Size = new System.Drawing.Size(75, 43);
            this.btn_30_3.TabIndex = 60;
            this.btn_30_3.Tag = 30;
            this.btn_30_3.UseVisualStyleBackColor = false;
            this.btn_30_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_29_2
            // 
            this.btn_29_2.BackColor = System.Drawing.Color.Black;
            this.btn_29_2.Location = new System.Drawing.Point(1008, 444);
            this.btn_29_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_29_2.Name = "btn_29_2";
            this.btn_29_2.Size = new System.Drawing.Size(75, 43);
            this.btn_29_2.TabIndex = 61;
            this.btn_29_2.Tag = 29;
            this.btn_29_2.UseVisualStyleBackColor = false;
            this.btn_29_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_28_2
            // 
            this.btn_28_2.BackColor = System.Drawing.Color.Black;
            this.btn_28_2.Location = new System.Drawing.Point(1008, 395);
            this.btn_28_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_28_2.Name = "btn_28_2";
            this.btn_28_2.Size = new System.Drawing.Size(75, 43);
            this.btn_28_2.TabIndex = 62;
            this.btn_28_2.Tag = 28;
            this.btn_28_2.UseVisualStyleBackColor = false;
            this.btn_28_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_27_3
            // 
            this.btn_27_3.BackColor = System.Drawing.Color.Black;
            this.btn_27_3.Location = new System.Drawing.Point(1008, 346);
            this.btn_27_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_27_3.Name = "btn_27_3";
            this.btn_27_3.Size = new System.Drawing.Size(75, 43);
            this.btn_27_3.TabIndex = 63;
            this.btn_27_3.Tag = 27;
            this.btn_27_3.UseVisualStyleBackColor = false;
            this.btn_27_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_26_4
            // 
            this.btn_26_4.BackColor = System.Drawing.Color.Black;
            this.btn_26_4.Location = new System.Drawing.Point(927, 346);
            this.btn_26_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_26_4.Name = "btn_26_4";
            this.btn_26_4.Size = new System.Drawing.Size(75, 43);
            this.btn_26_4.TabIndex = 64;
            this.btn_26_4.Tag = 26;
            this.btn_26_4.UseVisualStyleBackColor = false;
            this.btn_26_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_25_2
            // 
            this.btn_25_2.BackColor = System.Drawing.Color.White;
            this.btn_25_2.Location = new System.Drawing.Point(845, 346);
            this.btn_25_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_25_2.Name = "btn_25_2";
            this.btn_25_2.Size = new System.Drawing.Size(75, 43);
            this.btn_25_2.TabIndex = 54;
            this.btn_25_2.Tag = 25;
            this.btn_25_2.UseVisualStyleBackColor = false;
            this.btn_25_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_24_2
            // 
            this.btn_24_2.BackColor = System.Drawing.Color.Black;
            this.btn_24_2.Location = new System.Drawing.Point(845, 297);
            this.btn_24_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_24_2.Name = "btn_24_2";
            this.btn_24_2.Size = new System.Drawing.Size(75, 43);
            this.btn_24_2.TabIndex = 49;
            this.btn_24_2.Tag = 24;
            this.btn_24_2.UseVisualStyleBackColor = false;
            this.btn_24_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_23_2
            // 
            this.btn_23_2.BackColor = System.Drawing.Color.Black;
            this.btn_23_2.Location = new System.Drawing.Point(845, 249);
            this.btn_23_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_23_2.Name = "btn_23_2";
            this.btn_23_2.Size = new System.Drawing.Size(75, 43);
            this.btn_23_2.TabIndex = 50;
            this.btn_23_2.Tag = 23;
            this.btn_23_2.UseVisualStyleBackColor = false;
            this.btn_23_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_22_2
            // 
            this.btn_22_2.BackColor = System.Drawing.Color.Black;
            this.btn_22_2.Location = new System.Drawing.Point(765, 249);
            this.btn_22_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_22_2.Name = "btn_22_2";
            this.btn_22_2.Size = new System.Drawing.Size(75, 43);
            this.btn_22_2.TabIndex = 36;
            this.btn_22_2.Tag = 22;
            this.btn_22_2.UseVisualStyleBackColor = false;
            this.btn_22_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_26_3
            // 
            this.btn_26_3.BackColor = System.Drawing.Color.Black;
            this.btn_26_3.Location = new System.Drawing.Point(765, 346);
            this.btn_26_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_26_3.Name = "btn_26_3";
            this.btn_26_3.Size = new System.Drawing.Size(75, 43);
            this.btn_26_3.TabIndex = 44;
            this.btn_26_3.Tag = 26;
            this.btn_26_3.UseVisualStyleBackColor = false;
            this.btn_26_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_27_2
            // 
            this.btn_27_2.BackColor = System.Drawing.Color.Black;
            this.btn_27_2.Location = new System.Drawing.Point(683, 346);
            this.btn_27_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_27_2.Name = "btn_27_2";
            this.btn_27_2.Size = new System.Drawing.Size(75, 43);
            this.btn_27_2.TabIndex = 45;
            this.btn_27_2.Tag = 27;
            this.btn_27_2.UseVisualStyleBackColor = false;
            this.btn_27_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_26_2
            // 
            this.btn_26_2.BackColor = System.Drawing.Color.Black;
            this.btn_26_2.Location = new System.Drawing.Point(603, 346);
            this.btn_26_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_26_2.Name = "btn_26_2";
            this.btn_26_2.Size = new System.Drawing.Size(75, 43);
            this.btn_26_2.TabIndex = 46;
            this.btn_26_2.Tag = 26;
            this.btn_26_2.UseVisualStyleBackColor = false;
            this.btn_26_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_30_4
            // 
            this.btn_30_4.BackColor = System.Drawing.Color.Black;
            this.btn_30_4.Location = new System.Drawing.Point(1089, 444);
            this.btn_30_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_30_4.Name = "btn_30_4";
            this.btn_30_4.Size = new System.Drawing.Size(75, 43);
            this.btn_30_4.TabIndex = 79;
            this.btn_30_4.Tag = 30;
            this.btn_30_4.UseVisualStyleBackColor = false;
            this.btn_30_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_31_4
            // 
            this.btn_31_4.BackColor = System.Drawing.Color.Black;
            this.btn_31_4.Location = new System.Drawing.Point(1171, 444);
            this.btn_31_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_31_4.Name = "btn_31_4";
            this.btn_31_4.Size = new System.Drawing.Size(75, 43);
            this.btn_31_4.TabIndex = 78;
            this.btn_31_4.Tag = 31;
            this.btn_31_4.UseVisualStyleBackColor = false;
            this.btn_31_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_32_6
            // 
            this.btn_32_6.BackColor = System.Drawing.Color.Black;
            this.btn_32_6.Location = new System.Drawing.Point(1171, 494);
            this.btn_32_6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_32_6.Name = "btn_32_6";
            this.btn_32_6.Size = new System.Drawing.Size(75, 43);
            this.btn_32_6.TabIndex = 77;
            this.btn_32_6.Tag = 32;
            this.btn_32_6.UseVisualStyleBackColor = false;
            this.btn_32_6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_33_5
            // 
            this.btn_33_5.BackColor = System.Drawing.Color.Black;
            this.btn_33_5.Location = new System.Drawing.Point(1171, 542);
            this.btn_33_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_33_5.Name = "btn_33_5";
            this.btn_33_5.Size = new System.Drawing.Size(75, 43);
            this.btn_33_5.TabIndex = 76;
            this.btn_33_5.Tag = 33;
            this.btn_33_5.UseVisualStyleBackColor = false;
            this.btn_33_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_7
            // 
            this.btn_34_7.BackColor = System.Drawing.Color.Black;
            this.btn_34_7.Location = new System.Drawing.Point(1088, 542);
            this.btn_34_7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_34_7.Name = "btn_34_7";
            this.btn_34_7.Size = new System.Drawing.Size(75, 43);
            this.btn_34_7.TabIndex = 88;
            this.btn_34_7.Tag = 34;
            this.btn_34_7.UseVisualStyleBackColor = false;
            this.btn_34_7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_35_4
            // 
            this.btn_35_4.BackColor = System.Drawing.Color.White;
            this.btn_35_4.Location = new System.Drawing.Point(1007, 542);
            this.btn_35_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_35_4.Name = "btn_35_4";
            this.btn_35_4.Size = new System.Drawing.Size(75, 43);
            this.btn_35_4.TabIndex = 89;
            this.btn_35_4.Tag = 35;
            this.btn_35_4.UseVisualStyleBackColor = false;
            this.btn_35_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_6
            // 
            this.btn_34_6.BackColor = System.Drawing.Color.Black;
            this.btn_34_6.Location = new System.Drawing.Point(925, 542);
            this.btn_34_6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_34_6.Name = "btn_34_6";
            this.btn_34_6.Size = new System.Drawing.Size(75, 43);
            this.btn_34_6.TabIndex = 90;
            this.btn_34_6.Tag = 34;
            this.btn_34_6.UseVisualStyleBackColor = false;
            this.btn_34_6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_33_4
            // 
            this.btn_33_4.BackColor = System.Drawing.Color.Black;
            this.btn_33_4.Location = new System.Drawing.Point(845, 542);
            this.btn_33_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_33_4.Name = "btn_33_4";
            this.btn_33_4.Size = new System.Drawing.Size(75, 43);
            this.btn_33_4.TabIndex = 92;
            this.btn_33_4.Tag = 33;
            this.btn_33_4.UseVisualStyleBackColor = false;
            this.btn_33_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_32_5
            // 
            this.btn_32_5.BackColor = System.Drawing.Color.Black;
            this.btn_32_5.Location = new System.Drawing.Point(845, 494);
            this.btn_32_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_32_5.Name = "btn_32_5";
            this.btn_32_5.Size = new System.Drawing.Size(75, 43);
            this.btn_32_5.TabIndex = 91;
            this.btn_32_5.Tag = 32;
            this.btn_32_5.UseVisualStyleBackColor = false;
            this.btn_32_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_5
            // 
            this.btn_34_5.BackColor = System.Drawing.Color.Black;
            this.btn_34_5.Location = new System.Drawing.Point(764, 542);
            this.btn_34_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_34_5.Name = "btn_34_5";
            this.btn_34_5.Size = new System.Drawing.Size(75, 43);
            this.btn_34_5.TabIndex = 93;
            this.btn_34_5.Tag = 34;
            this.btn_34_5.UseVisualStyleBackColor = false;
            this.btn_34_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_35_3
            // 
            this.btn_35_3.BackColor = System.Drawing.Color.White;
            this.btn_35_3.Location = new System.Drawing.Point(683, 542);
            this.btn_35_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_35_3.Name = "btn_35_3";
            this.btn_35_3.Size = new System.Drawing.Size(75, 43);
            this.btn_35_3.TabIndex = 94;
            this.btn_35_3.Tag = 35;
            this.btn_35_3.UseVisualStyleBackColor = false;
            this.btn_35_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_4
            // 
            this.btn_34_4.BackColor = System.Drawing.Color.Black;
            this.btn_34_4.Location = new System.Drawing.Point(603, 542);
            this.btn_34_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_34_4.Name = "btn_34_4";
            this.btn_34_4.Size = new System.Drawing.Size(75, 43);
            this.btn_34_4.TabIndex = 95;
            this.btn_34_4.Tag = 34;
            this.btn_34_4.UseVisualStyleBackColor = false;
            this.btn_34_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_36_3
            // 
            this.btn_36_3.BackColor = System.Drawing.Color.Black;
            this.btn_36_3.Location = new System.Drawing.Point(683, 591);
            this.btn_36_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_36_3.Name = "btn_36_3";
            this.btn_36_3.Size = new System.Drawing.Size(75, 43);
            this.btn_36_3.TabIndex = 112;
            this.btn_36_3.Tag = 36;
            this.btn_36_3.UseVisualStyleBackColor = false;
            this.btn_36_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_37_3
            // 
            this.btn_37_3.BackColor = System.Drawing.Color.Black;
            this.btn_37_3.Location = new System.Drawing.Point(683, 640);
            this.btn_37_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_37_3.Name = "btn_37_3";
            this.btn_37_3.Size = new System.Drawing.Size(75, 43);
            this.btn_37_3.TabIndex = 99;
            this.btn_37_3.Tag = 37;
            this.btn_37_3.UseVisualStyleBackColor = false;
            this.btn_37_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_4
            // 
            this.btn_38_4.BackColor = System.Drawing.Color.Black;
            this.btn_38_4.Location = new System.Drawing.Point(603, 640);
            this.btn_38_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_38_4.Name = "btn_38_4";
            this.btn_38_4.Size = new System.Drawing.Size(75, 43);
            this.btn_38_4.TabIndex = 98;
            this.btn_38_4.Tag = 38;
            this.btn_38_4.UseVisualStyleBackColor = false;
            this.btn_38_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_39_2
            // 
            this.btn_39_2.BackColor = System.Drawing.Color.Black;
            this.btn_39_2.Location = new System.Drawing.Point(521, 640);
            this.btn_39_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_39_2.Name = "btn_39_2";
            this.btn_39_2.Size = new System.Drawing.Size(75, 43);
            this.btn_39_2.TabIndex = 109;
            this.btn_39_2.Tag = 39;
            this.btn_39_2.UseVisualStyleBackColor = false;
            this.btn_39_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_3
            // 
            this.btn_38_3.BackColor = System.Drawing.Color.Black;
            this.btn_38_3.Location = new System.Drawing.Point(440, 640);
            this.btn_38_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_38_3.Name = "btn_38_3";
            this.btn_38_3.Size = new System.Drawing.Size(75, 43);
            this.btn_38_3.TabIndex = 108;
            this.btn_38_3.Tag = 38;
            this.btn_38_3.UseVisualStyleBackColor = false;
            this.btn_38_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_green_1
            // 
            this.btn_40_green_1.BackColor = System.Drawing.Color.Green;
            this.btn_40_green_1.Location = new System.Drawing.Point(521, 689);
            this.btn_40_green_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_green_1.Name = "btn_40_green_1";
            this.btn_40_green_1.Size = new System.Drawing.Size(75, 43);
            this.btn_40_green_1.TabIndex = 123;
            this.btn_40_green_1.Tag = 40;
            this.btn_40_green_1.UseVisualStyleBackColor = false;
            this.btn_40_green_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_green_2
            // 
            this.btn_40_green_2.BackColor = System.Drawing.Color.Green;
            this.btn_40_green_2.Location = new System.Drawing.Point(440, 738);
            this.btn_40_green_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_green_2.Name = "btn_40_green_2";
            this.btn_40_green_2.Size = new System.Drawing.Size(75, 43);
            this.btn_40_green_2.TabIndex = 122;
            this.btn_40_green_2.Tag = 40;
            this.btn_40_green_2.UseVisualStyleBackColor = false;
            this.btn_40_green_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_green_3
            // 
            this.btn_40_green_3.BackColor = System.Drawing.Color.Green;
            this.btn_40_green_3.Location = new System.Drawing.Point(480, 788);
            this.btn_40_green_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_green_3.Name = "btn_40_green_3";
            this.btn_40_green_3.Size = new System.Drawing.Size(75, 43);
            this.btn_40_green_3.TabIndex = 120;
            this.btn_40_green_3.Tag = 40;
            this.btn_40_green_3.UseVisualStyleBackColor = false;
            this.btn_40_green_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_green_4
            // 
            this.btn_40_green_4.BackColor = System.Drawing.Color.Green;
            this.btn_40_green_4.Location = new System.Drawing.Point(565, 788);
            this.btn_40_green_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_green_4.Name = "btn_40_green_4";
            this.btn_40_green_4.Size = new System.Drawing.Size(75, 43);
            this.btn_40_green_4.TabIndex = 119;
            this.btn_40_green_4.Tag = 40;
            this.btn_40_green_4.UseVisualStyleBackColor = false;
            this.btn_40_green_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_green_5
            // 
            this.btn_40_green_5.BackColor = System.Drawing.Color.Green;
            this.btn_40_green_5.Location = new System.Drawing.Point(603, 738);
            this.btn_40_green_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_green_5.Name = "btn_40_green_5";
            this.btn_40_green_5.Size = new System.Drawing.Size(75, 43);
            this.btn_40_green_5.TabIndex = 121;
            this.btn_40_green_5.Tag = 40;
            this.btn_40_green_5.UseVisualStyleBackColor = false;
            this.btn_40_green_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_5
            // 
            this.btn_38_5.BackColor = System.Drawing.Color.Black;
            this.btn_38_5.Location = new System.Drawing.Point(765, 640);
            this.btn_38_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_38_5.Name = "btn_38_5";
            this.btn_38_5.Size = new System.Drawing.Size(75, 43);
            this.btn_38_5.TabIndex = 100;
            this.btn_38_5.Tag = 38;
            this.btn_38_5.UseVisualStyleBackColor = false;
            this.btn_38_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_39_3
            // 
            this.btn_39_3.BackColor = System.Drawing.Color.Black;
            this.btn_39_3.Location = new System.Drawing.Point(845, 640);
            this.btn_39_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_39_3.Name = "btn_39_3";
            this.btn_39_3.Size = new System.Drawing.Size(75, 43);
            this.btn_39_3.TabIndex = 101;
            this.btn_39_3.Tag = 39;
            this.btn_39_3.UseVisualStyleBackColor = false;
            this.btn_39_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_6
            // 
            this.btn_38_6.BackColor = System.Drawing.Color.Black;
            this.btn_38_6.Location = new System.Drawing.Point(925, 640);
            this.btn_38_6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_38_6.Name = "btn_38_6";
            this.btn_38_6.Size = new System.Drawing.Size(75, 43);
            this.btn_38_6.TabIndex = 82;
            this.btn_38_6.Tag = 38;
            this.btn_38_6.UseVisualStyleBackColor = false;
            this.btn_38_6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_37_4
            // 
            this.btn_37_4.BackColor = System.Drawing.Color.Black;
            this.btn_37_4.Location = new System.Drawing.Point(1007, 640);
            this.btn_37_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_37_4.Name = "btn_37_4";
            this.btn_37_4.Size = new System.Drawing.Size(75, 43);
            this.btn_37_4.TabIndex = 102;
            this.btn_37_4.Tag = 37;
            this.btn_37_4.UseVisualStyleBackColor = false;
            this.btn_37_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_36_4
            // 
            this.btn_36_4.BackColor = System.Drawing.Color.Black;
            this.btn_36_4.Location = new System.Drawing.Point(1008, 591);
            this.btn_36_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_36_4.Name = "btn_36_4";
            this.btn_36_4.Size = new System.Drawing.Size(75, 43);
            this.btn_36_4.TabIndex = 111;
            this.btn_36_4.Tag = 36;
            this.btn_36_4.UseVisualStyleBackColor = false;
            this.btn_36_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_7
            // 
            this.btn_38_7.BackColor = System.Drawing.Color.Black;
            this.btn_38_7.Location = new System.Drawing.Point(1089, 640);
            this.btn_38_7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_38_7.Name = "btn_38_7";
            this.btn_38_7.Size = new System.Drawing.Size(75, 43);
            this.btn_38_7.TabIndex = 83;
            this.btn_38_7.Tag = 38;
            this.btn_38_7.UseVisualStyleBackColor = false;
            this.btn_38_7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_39_4
            // 
            this.btn_39_4.BackColor = System.Drawing.Color.Black;
            this.btn_39_4.Location = new System.Drawing.Point(1171, 640);
            this.btn_39_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_39_4.Name = "btn_39_4";
            this.btn_39_4.Size = new System.Drawing.Size(75, 43);
            this.btn_39_4.TabIndex = 84;
            this.btn_39_4.Tag = 39;
            this.btn_39_4.UseVisualStyleBackColor = false;
            this.btn_39_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_38_8
            // 
            this.btn_38_8.BackColor = System.Drawing.Color.Black;
            this.btn_38_8.Location = new System.Drawing.Point(1251, 640);
            this.btn_38_8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_38_8.Name = "btn_38_8";
            this.btn_38_8.Size = new System.Drawing.Size(75, 43);
            this.btn_38_8.TabIndex = 85;
            this.btn_38_8.Tag = 38;
            this.btn_38_8.UseVisualStyleBackColor = false;
            this.btn_38_8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_37_5
            // 
            this.btn_37_5.BackColor = System.Drawing.Color.Black;
            this.btn_37_5.Location = new System.Drawing.Point(1332, 640);
            this.btn_37_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_37_5.Name = "btn_37_5";
            this.btn_37_5.Size = new System.Drawing.Size(75, 43);
            this.btn_37_5.TabIndex = 86;
            this.btn_37_5.Tag = 37;
            this.btn_37_5.UseVisualStyleBackColor = false;
            this.btn_37_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_36_5
            // 
            this.btn_36_5.BackColor = System.Drawing.Color.Black;
            this.btn_36_5.Location = new System.Drawing.Point(1332, 591);
            this.btn_36_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_36_5.Name = "btn_36_5";
            this.btn_36_5.Size = new System.Drawing.Size(75, 43);
            this.btn_36_5.TabIndex = 87;
            this.btn_36_5.Tag = 36;
            this.btn_36_5.UseVisualStyleBackColor = false;
            this.btn_36_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_35_5
            // 
            this.btn_35_5.BackColor = System.Drawing.Color.White;
            this.btn_35_5.Location = new System.Drawing.Point(1332, 542);
            this.btn_35_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_35_5.Name = "btn_35_5";
            this.btn_35_5.Size = new System.Drawing.Size(75, 43);
            this.btn_35_5.TabIndex = 74;
            this.btn_35_5.Tag = 35;
            this.btn_35_5.UseVisualStyleBackColor = false;
            this.btn_35_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_34_8
            // 
            this.btn_34_8.BackColor = System.Drawing.Color.Black;
            this.btn_34_8.Location = new System.Drawing.Point(1251, 542);
            this.btn_34_8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_34_8.Name = "btn_34_8";
            this.btn_34_8.Size = new System.Drawing.Size(75, 43);
            this.btn_34_8.TabIndex = 75;
            this.btn_34_8.Tag = 34;
            this.btn_34_8.UseVisualStyleBackColor = false;
            this.btn_34_8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_blue_1
            // 
            this.btn_40_blue_1.BackColor = System.Drawing.Color.Blue;
            this.btn_40_blue_1.Location = new System.Drawing.Point(1171, 689);
            this.btn_40_blue_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_blue_1.Name = "btn_40_blue_1";
            this.btn_40_blue_1.Size = new System.Drawing.Size(75, 43);
            this.btn_40_blue_1.TabIndex = 133;
            this.btn_40_blue_1.Tag = 40;
            this.btn_40_blue_1.UseVisualStyleBackColor = false;
            this.btn_40_blue_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_blue_2
            // 
            this.btn_40_blue_2.BackColor = System.Drawing.Color.Blue;
            this.btn_40_blue_2.Location = new System.Drawing.Point(1089, 738);
            this.btn_40_blue_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_blue_2.Name = "btn_40_blue_2";
            this.btn_40_blue_2.Size = new System.Drawing.Size(75, 43);
            this.btn_40_blue_2.TabIndex = 132;
            this.btn_40_blue_2.Tag = 40;
            this.btn_40_blue_2.UseVisualStyleBackColor = false;
            this.btn_40_blue_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_blue_3
            // 
            this.btn_40_blue_3.BackColor = System.Drawing.Color.Blue;
            this.btn_40_blue_3.Location = new System.Drawing.Point(1128, 788);
            this.btn_40_blue_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_blue_3.Name = "btn_40_blue_3";
            this.btn_40_blue_3.Size = new System.Drawing.Size(75, 43);
            this.btn_40_blue_3.TabIndex = 130;
            this.btn_40_blue_3.Tag = 40;
            this.btn_40_blue_3.UseVisualStyleBackColor = false;
            this.btn_40_blue_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_blue_4
            // 
            this.btn_40_blue_4.BackColor = System.Drawing.Color.Blue;
            this.btn_40_blue_4.Location = new System.Drawing.Point(1211, 788);
            this.btn_40_blue_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_blue_4.Name = "btn_40_blue_4";
            this.btn_40_blue_4.Size = new System.Drawing.Size(75, 43);
            this.btn_40_blue_4.TabIndex = 129;
            this.btn_40_blue_4.Tag = 40;
            this.btn_40_blue_4.UseVisualStyleBackColor = false;
            this.btn_40_blue_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_blue_5
            // 
            this.btn_40_blue_5.BackColor = System.Drawing.Color.Blue;
            this.btn_40_blue_5.Location = new System.Drawing.Point(1251, 738);
            this.btn_40_blue_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_blue_5.Name = "btn_40_blue_5";
            this.btn_40_blue_5.Size = new System.Drawing.Size(75, 43);
            this.btn_40_blue_5.TabIndex = 131;
            this.btn_40_blue_5.Tag = 40;
            this.btn_40_blue_5.UseVisualStyleBackColor = false;
            this.btn_40_blue_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_yellow_1
            // 
            this.btn_40_yellow_1.BackColor = System.Drawing.Color.Yellow;
            this.btn_40_yellow_1.Location = new System.Drawing.Point(845, 689);
            this.btn_40_yellow_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_yellow_1.Name = "btn_40_yellow_1";
            this.btn_40_yellow_1.Size = new System.Drawing.Size(75, 43);
            this.btn_40_yellow_1.TabIndex = 128;
            this.btn_40_yellow_1.Tag = 40;
            this.btn_40_yellow_1.UseVisualStyleBackColor = false;
            this.btn_40_yellow_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_yellow_2
            // 
            this.btn_40_yellow_2.BackColor = System.Drawing.Color.Yellow;
            this.btn_40_yellow_2.Location = new System.Drawing.Point(765, 738);
            this.btn_40_yellow_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_yellow_2.Name = "btn_40_yellow_2";
            this.btn_40_yellow_2.Size = new System.Drawing.Size(75, 43);
            this.btn_40_yellow_2.TabIndex = 127;
            this.btn_40_yellow_2.Tag = 40;
            this.btn_40_yellow_2.UseVisualStyleBackColor = false;
            this.btn_40_yellow_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_yellow_3
            // 
            this.btn_40_yellow_3.BackColor = System.Drawing.Color.Yellow;
            this.btn_40_yellow_3.Location = new System.Drawing.Point(804, 788);
            this.btn_40_yellow_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_yellow_3.Name = "btn_40_yellow_3";
            this.btn_40_yellow_3.Size = new System.Drawing.Size(75, 43);
            this.btn_40_yellow_3.TabIndex = 125;
            this.btn_40_yellow_3.Tag = 40;
            this.btn_40_yellow_3.UseVisualStyleBackColor = false;
            this.btn_40_yellow_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_yellow_4
            // 
            this.btn_40_yellow_4.BackColor = System.Drawing.Color.Yellow;
            this.btn_40_yellow_4.Location = new System.Drawing.Point(887, 788);
            this.btn_40_yellow_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_yellow_4.Name = "btn_40_yellow_4";
            this.btn_40_yellow_4.Size = new System.Drawing.Size(75, 43);
            this.btn_40_yellow_4.TabIndex = 124;
            this.btn_40_yellow_4.Tag = 40;
            this.btn_40_yellow_4.UseVisualStyleBackColor = false;
            this.btn_40_yellow_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_yellow_5
            // 
            this.btn_40_yellow_5.BackColor = System.Drawing.Color.Yellow;
            this.btn_40_yellow_5.Location = new System.Drawing.Point(927, 738);
            this.btn_40_yellow_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_yellow_5.Name = "btn_40_yellow_5";
            this.btn_40_yellow_5.Size = new System.Drawing.Size(75, 43);
            this.btn_40_yellow_5.TabIndex = 126;
            this.btn_40_yellow_5.Tag = 40;
            this.btn_40_yellow_5.UseVisualStyleBackColor = false;
            this.btn_40_yellow_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_red_1
            // 
            this.btn_40_red_1.BackColor = System.Drawing.Color.Red;
            this.btn_40_red_1.Location = new System.Drawing.Point(197, 689);
            this.btn_40_red_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_red_1.Name = "btn_40_red_1";
            this.btn_40_red_1.Size = new System.Drawing.Size(75, 43);
            this.btn_40_red_1.TabIndex = 118;
            this.btn_40_red_1.Tag = 40;
            this.btn_40_red_1.UseVisualStyleBackColor = false;
            this.btn_40_red_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_red_2
            // 
            this.btn_40_red_2.BackColor = System.Drawing.Color.Red;
            this.btn_40_red_2.Location = new System.Drawing.Point(116, 738);
            this.btn_40_red_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_red_2.Name = "btn_40_red_2";
            this.btn_40_red_2.Size = new System.Drawing.Size(75, 43);
            this.btn_40_red_2.TabIndex = 117;
            this.btn_40_red_2.Tag = 40;
            this.btn_40_red_2.UseVisualStyleBackColor = false;
            this.btn_40_red_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_red_3
            // 
            this.btn_40_red_3.BackColor = System.Drawing.Color.Red;
            this.btn_40_red_3.Location = new System.Drawing.Point(156, 788);
            this.btn_40_red_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_red_3.Name = "btn_40_red_3";
            this.btn_40_red_3.Size = new System.Drawing.Size(75, 43);
            this.btn_40_red_3.TabIndex = 115;
            this.btn_40_red_3.Tag = 40;
            this.btn_40_red_3.UseVisualStyleBackColor = false;
            this.btn_40_red_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_red_4
            // 
            this.btn_40_red_4.BackColor = System.Drawing.Color.Red;
            this.btn_40_red_4.Location = new System.Drawing.Point(239, 788);
            this.btn_40_red_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_red_4.Name = "btn_40_red_4";
            this.btn_40_red_4.Size = new System.Drawing.Size(75, 43);
            this.btn_40_red_4.TabIndex = 114;
            this.btn_40_red_4.Tag = 40;
            this.btn_40_red_4.UseVisualStyleBackColor = false;
            this.btn_40_red_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_40_red_5
            // 
            this.btn_40_red_5.BackColor = System.Drawing.Color.Red;
            this.btn_40_red_5.Location = new System.Drawing.Point(277, 738);
            this.btn_40_red_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_40_red_5.Name = "btn_40_red_5";
            this.btn_40_red_5.Size = new System.Drawing.Size(75, 43);
            this.btn_40_red_5.TabIndex = 116;
            this.btn_40_red_5.Tag = 40;
            this.btn_40_red_5.UseVisualStyleBackColor = false;
            this.btn_40_red_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_wuerfeln
            // 
            this.btn_wuerfeln.Location = new System.Drawing.Point(15, 913);
            this.btn_wuerfeln.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_wuerfeln.Name = "btn_wuerfeln";
            this.btn_wuerfeln.Size = new System.Drawing.Size(153, 46);
            this.btn_wuerfeln.TabIndex = 135;
            this.btn_wuerfeln.Text = "würfeln";
            this.btn_wuerfeln.UseVisualStyleBackColor = true;
            this.btn_wuerfeln.Click += new System.EventHandler(this.btn_wuerfeln_Click);
            // 
            // lbl_wurfzahl
            // 
            this.lbl_wurfzahl.AutoSize = true;
            this.lbl_wurfzahl.Location = new System.Drawing.Point(173, 927);
            this.lbl_wurfzahl.Name = "lbl_wurfzahl";
            this.lbl_wurfzahl.Size = new System.Drawing.Size(16, 17);
            this.lbl_wurfzahl.TabIndex = 136;
            this.lbl_wurfzahl.Text = "0";
            // 
            // pnl_alleFelder
            // 
            this.pnl_alleFelder.Controls.Add(this.btn_9_1);
            this.pnl_alleFelder.Controls.Add(this.btn_1);
            this.pnl_alleFelder.Controls.Add(this.btn_2_1);
            this.pnl_alleFelder.Controls.Add(this.btn_0_ziel);
            this.pnl_alleFelder.Controls.Add(this.btn_3_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_blue_1);
            this.pnl_alleFelder.Controls.Add(this.btn_4_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_blue_2);
            this.pnl_alleFelder.Controls.Add(this.btn_5_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_blue_5);
            this.pnl_alleFelder.Controls.Add(this.btn_6_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_blue_3);
            this.pnl_alleFelder.Controls.Add(this.btn_7_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_blue_4);
            this.pnl_alleFelder.Controls.Add(this.btn_8_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_yellow_1);
            this.pnl_alleFelder.Controls.Add(this.btn_17_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_yellow_2);
            this.pnl_alleFelder.Controls.Add(this.btn_16_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_yellow_5);
            this.pnl_alleFelder.Controls.Add(this.btn_15_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_yellow_3);
            this.pnl_alleFelder.Controls.Add(this.btn_14_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_yellow_4);
            this.pnl_alleFelder.Controls.Add(this.btn_13_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_green_1);
            this.pnl_alleFelder.Controls.Add(this.btn_12_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_green_2);
            this.pnl_alleFelder.Controls.Add(this.btn_11_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_green_5);
            this.pnl_alleFelder.Controls.Add(this.btn_10_1);
            this.pnl_alleFelder.Controls.Add(this.btn_40_green_3);
            this.pnl_alleFelder.Controls.Add(this.btn_8_2);
            this.pnl_alleFelder.Controls.Add(this.btn_40_green_4);
            this.pnl_alleFelder.Controls.Add(this.btn_7_2);
            this.pnl_alleFelder.Controls.Add(this.btn_40_red_1);
            this.pnl_alleFelder.Controls.Add(this.btn_6_2);
            this.pnl_alleFelder.Controls.Add(this.btn_40_red_2);
            this.pnl_alleFelder.Controls.Add(this.btn_5_2);
            this.pnl_alleFelder.Controls.Add(this.btn_40_red_5);
            this.pnl_alleFelder.Controls.Add(this.btn_4_2);
            this.pnl_alleFelder.Controls.Add(this.btn_40_red_3);
            this.pnl_alleFelder.Controls.Add(this.btn_3_2);
            this.pnl_alleFelder.Controls.Add(this.btn_40_red_4);
            this.pnl_alleFelder.Controls.Add(this.btn_2_2);
            this.pnl_alleFelder.Controls.Add(this.btn_36_2);
            this.pnl_alleFelder.Controls.Add(this.btn_19_1);
            this.pnl_alleFelder.Controls.Add(this.btn_36_3);
            this.pnl_alleFelder.Controls.Add(this.btn_18_1);
            this.pnl_alleFelder.Controls.Add(this.btn_36_4);
            this.pnl_alleFelder.Controls.Add(this.btn_15_2);
            this.pnl_alleFelder.Controls.Add(this.btn_36_1);
            this.pnl_alleFelder.Controls.Add(this.btn_14_2);
            this.pnl_alleFelder.Controls.Add(this.btn_39_2);
            this.pnl_alleFelder.Controls.Add(this.btn_13_2);
            this.pnl_alleFelder.Controls.Add(this.btn_38_3);
            this.pnl_alleFelder.Controls.Add(this.btn_12_2);
            this.pnl_alleFelder.Controls.Add(this.btn_37_2);
            this.pnl_alleFelder.Controls.Add(this.btn_11_2);
            this.pnl_alleFelder.Controls.Add(this.btn_38_2);
            this.pnl_alleFelder.Controls.Add(this.btn_10_2);
            this.pnl_alleFelder.Controls.Add(this.btn_39_1);
            this.pnl_alleFelder.Controls.Add(this.btn_9_2);
            this.pnl_alleFelder.Controls.Add(this.btn_38_1);
            this.pnl_alleFelder.Controls.Add(this.btn_22_2);
            this.pnl_alleFelder.Controls.Add(this.btn_37_1);
            this.pnl_alleFelder.Controls.Add(this.btn_23_1);
            this.pnl_alleFelder.Controls.Add(this.btn_37_4);
            this.pnl_alleFelder.Controls.Add(this.btn_22_1);
            this.pnl_alleFelder.Controls.Add(this.btn_39_3);
            this.pnl_alleFelder.Controls.Add(this.btn_21_1);
            this.pnl_alleFelder.Controls.Add(this.btn_38_5);
            this.pnl_alleFelder.Controls.Add(this.btn_20_1);
            this.pnl_alleFelder.Controls.Add(this.btn_37_3);
            this.pnl_alleFelder.Controls.Add(this.btn_18_2);
            this.pnl_alleFelder.Controls.Add(this.btn_38_4);
            this.pnl_alleFelder.Controls.Add(this.btn_17_2);
            this.pnl_alleFelder.Controls.Add(this.btn_33_2);
            this.pnl_alleFelder.Controls.Add(this.btn_16_2);
            this.pnl_alleFelder.Controls.Add(this.btn_32_2);
            this.pnl_alleFelder.Controls.Add(this.btn_26_3);
            this.pnl_alleFelder.Controls.Add(this.btn_34_4);
            this.pnl_alleFelder.Controls.Add(this.btn_27_2);
            this.pnl_alleFelder.Controls.Add(this.btn_35_3);
            this.pnl_alleFelder.Controls.Add(this.btn_26_2);
            this.pnl_alleFelder.Controls.Add(this.btn_34_5);
            this.pnl_alleFelder.Controls.Add(this.btn_25_1);
            this.pnl_alleFelder.Controls.Add(this.btn_33_4);
            this.pnl_alleFelder.Controls.Add(this.btn_24_1);
            this.pnl_alleFelder.Controls.Add(this.btn_32_5);
            this.pnl_alleFelder.Controls.Add(this.btn_24_2);
            this.pnl_alleFelder.Controls.Add(this.btn_34_6);
            this.pnl_alleFelder.Controls.Add(this.btn_23_2);
            this.pnl_alleFelder.Controls.Add(this.btn_35_4);
            this.pnl_alleFelder.Controls.Add(this.btn_28_1);
            this.pnl_alleFelder.Controls.Add(this.btn_34_7);
            this.pnl_alleFelder.Controls.Add(this.btn_27_1);
            this.pnl_alleFelder.Controls.Add(this.btn_36_5);
            this.pnl_alleFelder.Controls.Add(this.btn_26_1);
            this.pnl_alleFelder.Controls.Add(this.btn_37_5);
            this.pnl_alleFelder.Controls.Add(this.btn_25_2);
            this.pnl_alleFelder.Controls.Add(this.btn_38_8);
            this.pnl_alleFelder.Controls.Add(this.btn_31_2);
            this.pnl_alleFelder.Controls.Add(this.btn_39_4);
            this.pnl_alleFelder.Controls.Add(this.btn_32_3);
            this.pnl_alleFelder.Controls.Add(this.btn_38_7);
            this.pnl_alleFelder.Controls.Add(this.btn_33_3);
            this.pnl_alleFelder.Controls.Add(this.btn_38_6);
            this.pnl_alleFelder.Controls.Add(this.btn_32_4);
            this.pnl_alleFelder.Controls.Add(this.btn_30_1);
            this.pnl_alleFelder.Controls.Add(this.btn_31_3);
            this.pnl_alleFelder.Controls.Add(this.btn_31_1);
            this.pnl_alleFelder.Controls.Add(this.btn_30_3);
            this.pnl_alleFelder.Controls.Add(this.btn_30_4);
            this.pnl_alleFelder.Controls.Add(this.btn_29_2);
            this.pnl_alleFelder.Controls.Add(this.btn_31_4);
            this.pnl_alleFelder.Controls.Add(this.btn_28_2);
            this.pnl_alleFelder.Controls.Add(this.btn_32_6);
            this.pnl_alleFelder.Controls.Add(this.btn_27_3);
            this.pnl_alleFelder.Controls.Add(this.btn_33_5);
            this.pnl_alleFelder.Controls.Add(this.btn_26_4);
            this.pnl_alleFelder.Controls.Add(this.btn_34_8);
            this.pnl_alleFelder.Controls.Add(this.btn_29_1);
            this.pnl_alleFelder.Controls.Add(this.btn_35_5);
            this.pnl_alleFelder.Controls.Add(this.btn_30_2);
            this.pnl_alleFelder.Controls.Add(this.btn_32_1);
            this.pnl_alleFelder.Controls.Add(this.btn_34_3);
            this.pnl_alleFelder.Controls.Add(this.btn_33_1);
            this.pnl_alleFelder.Controls.Add(this.btn_35_2);
            this.pnl_alleFelder.Controls.Add(this.btn_34_1);
            this.pnl_alleFelder.Controls.Add(this.btn_34_2);
            this.pnl_alleFelder.Controls.Add(this.btn_35_1);
            this.pnl_alleFelder.Location = new System.Drawing.Point(12, 9);
            this.pnl_alleFelder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_alleFelder.Name = "pnl_alleFelder";
            this.pnl_alleFelder.Size = new System.Drawing.Size(1435, 855);
            this.pnl_alleFelder.TabIndex = 137;
            // 
            // btn_aussetzen
            // 
            this.btn_aussetzen.Enabled = false;
            this.btn_aussetzen.Location = new System.Drawing.Point(1183, 909);
            this.btn_aussetzen.Name = "btn_aussetzen";
            this.btn_aussetzen.Size = new System.Drawing.Size(264, 55);
            this.btn_aussetzen.TabIndex = 138;
            this.btn_aussetzen.Text = "Aussetzen";
            this.btn_aussetzen.UseVisualStyleBackColor = true;
            this.btn_aussetzen.Click += new System.EventHandler(this.btn_aussetzen_Click);
            // 
            // lbl_anleitungen
            // 
            this.lbl_anleitungen.Location = new System.Drawing.Point(248, 909);
            this.lbl_anleitungen.Name = "lbl_anleitungen";
            this.lbl_anleitungen.Size = new System.Drawing.Size(912, 50);
            this.lbl_anleitungen.TabIndex = 139;
            this.lbl_anleitungen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Spielfeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 994);
            this.Controls.Add(this.lbl_anleitungen);
            this.Controls.Add(this.btn_aussetzen);
            this.Controls.Add(this.pnl_alleFelder);
            this.Controls.Add(this.lbl_wurfzahl);
            this.Controls.Add(this.btn_wuerfeln);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Spielfeld";
            this.Text = "Projekt M";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Spielfeld_FormClosing);
            this.pnl_alleFelder.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Feld btn_1;
        private Feld btn_2_1;
        private Feld btn_3_1;
        private Feld btn_4_1;
        private Feld btn_5_1;
        private Feld btn_6_1;
        private Feld btn_7_1;
        private Feld btn_8_1;
        private Feld btn_9_1;
        private Feld btn_17_1;
        private Feld btn_16_1;
        private Feld btn_15_1;
        private Feld btn_14_1;
        private Feld btn_13_1;
        private Feld btn_12_1;
        private Feld btn_11_1;
        private Feld btn_10_1;
        private Feld btn_8_2;
        private Feld btn_7_2;
        private Feld btn_6_2;
        private Feld btn_5_2;
        private Feld btn_4_2;
        private Feld btn_3_2;
        private Feld btn_2_2;
        private Feld btn_19_1;
        private Feld btn_18_1;
        private Feld btn_15_2;
        private Feld btn_14_2;
        private Feld btn_13_2;
        private Feld btn_12_2;
        private Feld btn_11_2;
        private Feld btn_10_2;
        private Feld btn_9_2;
        private Feld btn_22_2;
        private Feld btn_23_1;
        private Feld btn_22_1;
        private Feld btn_21_1;
        private Feld btn_20_1;
        private Feld btn_18_2;
        private Feld btn_17_2;
        private Feld btn_16_2;
        private Feld btn_26_3;
        private Feld btn_27_2;
        private Feld btn_26_2;
        private Feld btn_25_1;
        private Feld btn_24_1;
        private Feld btn_24_2;
        private Feld btn_23_2;
        private Feld btn_28_1;
        private Feld btn_27_1;
        private Feld btn_26_1;
        private Feld btn_25_2;
        private Feld btn_31_2;
        private Feld btn_32_3;
        private Feld btn_33_3;
        private Feld btn_32_4;
        private Feld btn_31_3;
        private Feld btn_30_3;
        private Feld btn_29_2;
        private Feld btn_28_2;
        private Feld btn_27_3;
        private Feld btn_26_4;
        private Feld btn_29_1;
        private Feld btn_30_2;
        private Feld btn_34_3;
        private Feld btn_35_2;
        private Feld btn_34_2;
        private Feld btn_35_1;
        private Feld btn_34_1;
        private Feld btn_33_1;
        private Feld btn_32_1;
        private Feld btn_35_5;
        private Feld btn_34_8;
        private Feld btn_33_5;
        private Feld btn_32_6;
        private Feld btn_31_4;
        private Feld btn_30_4;
        private Feld btn_31_1;
        private Feld btn_30_1;
        private Feld btn_38_6;
        private Feld btn_38_7;
        private Feld btn_39_4;
        private Feld btn_38_8;
        private Feld btn_37_5;
        private Feld btn_36_5;
        private Feld btn_34_7;
        private Feld btn_35_4;
        private Feld btn_34_6;
        private Feld btn_32_5;
        private Feld btn_33_4;
        private Feld btn_34_5;
        private Feld btn_35_3;
        private Feld btn_34_4;
        private Feld btn_32_2;
        private Feld btn_33_2;
        private Feld btn_38_4;
        private Feld btn_37_3;
        private Feld btn_38_5;
        private Feld btn_39_3;
        private Feld btn_37_4;
        private Feld btn_37_1;
        private Feld btn_38_1;
        private Feld btn_39_1;
        private Feld btn_38_2;
        private Feld btn_37_2;
        private Feld btn_38_3;
        private Feld btn_39_2;
        private Feld btn_36_1;
        private Feld btn_36_4;
        private Feld btn_36_3;
        private Feld btn_36_2;
        private Feld btn_40_red_4;
        private Feld btn_40_red_3;
        private Feld btn_40_red_5;
        private Feld btn_40_red_2;
        private Feld btn_40_red_1;
        private Feld btn_40_green_4;
        private Feld btn_40_green_3;
        private Feld btn_40_green_5;
        private Feld btn_40_green_2;
        private Feld btn_40_green_1;
        private Feld btn_40_yellow_4;
        private Feld btn_40_yellow_3;
        private Feld btn_40_yellow_5;
        private Feld btn_40_yellow_2;
        private Feld btn_40_yellow_1;
        private Feld btn_40_blue_4;
        private Feld btn_40_blue_3;
        private Feld btn_40_blue_5;
        private Feld btn_40_blue_2;
        private Feld btn_40_blue_1;
        private Feld btn_0_ziel;
        private Button btn_wuerfeln;
        private Label lbl_wurfzahl;
        private Panel pnl_alleFelder;
        private Button btn_aussetzen;
        private Label lbl_anleitungen;
    }
}

