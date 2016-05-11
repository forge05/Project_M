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
            //foreach (Button b in frm_Spielfeld)
            //{

            //}
            Container buttonContainer = new Container();
            //buttonContainer.Add(btn_0_ziel);
            foreach(Button b in pnl_alleFelder.Controls)
            {
                buttonContainer.Add(b);
            }

            btn_17_1.Tag = 8;
            int schniedel = (int)btn_17_1.Tag;
            Console.WriteLine(schniedel);
        }

        private void btn_wuerfeln_Click(object sender, EventArgs e)
        {
            Random Zahlenfee = new Random();
            Wurfzahl = Zahlenfee.Next(1, 7);
            lbl_wurfzahl.Text = Wurfzahl.ToString();
        }

        private void btn_40_red_1_Click(object sender, EventArgs e)
        {
            int GewuerfelteZahl = Wurfzahl;
            rueckOptionenPropagiere(btn_40_red_1);

        }

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

        private void btn_9_1_Click(object sender, EventArgs e)
        {
            btn_9_1.BackColor = Color.Brown;
            foreach(Button b in btn_9_1.nachbarn)
            {
                b.BackColor = Color.Brown;
            }
        }
    }
}
