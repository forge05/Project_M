﻿using System;
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
        frm_Einstellungen frm_Einstellungen;
        public frm_Menu()
        {
            InitializeComponent();
            frm_Einstellungen = new frm_Einstellungen(this);
        }

        private void btn_beenden_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_neues_Spiel_Click(object sender, EventArgs e)
        {
            frm_Einstellungen.Show();
            this.Hide();
        }
    }
}
