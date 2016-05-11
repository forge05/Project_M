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

        private void rueckOptionenPropagiere(Button b)
        {
            int Entfernung_zum_Ziel = (int)b.Tag;
            foreach (Button b_rueck in pnl_alleFelder.Controls)
            {
                if((int)b_rueck.Tag == Entfernung_zum_Ziel - Wurfzahl)
                {
                    b_rueck.BackColor = Color.Brown;
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Feld myfield = (Feld)sender;
            Console.WriteLine("ich bin " + sender);
           
            foreach(Button b in myfield.nachbarn)
            {
                if(b.BackColor == Color.Brown)
                {
                    b.BackColor = Color.Black;
                    myfield.BackColor = Color.Black;
                }
                else
                {
                    b.BackColor = Color.Brown;
                    myfield.BackColor = Color.Brown;
                }
            }
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
