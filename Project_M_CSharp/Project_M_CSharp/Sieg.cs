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
    public partial class frm_Sieg : Form
    {
        frm_Spielfeld spielfeld;
        Form menu;
        string gewinner;
        public frm_Sieg(frm_Spielfeld myFrm, Form myFrm_Menu, string sieger)
        {
            gewinner = sieger;
            spielfeld = myFrm;
            menu = myFrm_Menu;
            InitializeComponent();
            lbl_gewinner.Text = gewinner;
        }

        private void btn_okay_Click(object sender, EventArgs e)
        {
            spielfeld.Close();
            menu.Show();
            this.Close();
            
        }
    }
}
