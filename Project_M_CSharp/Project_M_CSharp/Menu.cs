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
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btn_beenden_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_neues_Spiel_Click(object sender, EventArgs e)
        {
            frm_Spielfeld Spiel = new frm_Spielfeld(this);
            Spiel.Show();
            this.Hide();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            //this.Show();
        }

        private void btn_einstellungen_Click(object sender, EventArgs e)
        {
            frm_Einstellungen Einstellungen = new frm_Einstellungen(this);
            Einstellungen.Show();
            this.Hide();
        }
    }
}
