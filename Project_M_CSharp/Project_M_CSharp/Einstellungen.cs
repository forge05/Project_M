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
    public partial class frm_Einstellungen : Form
    {
        Form frm_Menue;

        public frm_Einstellungen(Form myFrm)
        {
            frm_Menue = myFrm;
            InitializeComponent();
        }

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Menue.Show();
        }
        
        private void btn_spiel_starten_Click(object sender, EventArgs e)
        {
            frm_Spielfeld Spiel = new frm_Spielfeld(frm_Menue, this);
            Spiel.Show();
            this.Hide();
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_anz_s_2.Checked)
            {
                txt_s3.Enabled = false;
                txt_s3.Text = "Yellow";
                //ckb_cpu_s3.Enabled = false;
                txt_s4.Enabled = false;
                txt_s4.Text = "Blue";
                //ckb_cpu_s4.Enabled = false;
            }
            else if(rbtn_anz_s_3.Checked)
            {
                txt_s3.Enabled = true;
                //ckb_cpu_s3.Enabled = true;
                txt_s4.Enabled = false;
                txt_s4.Text = "Blue";
                //ckb_cpu_s4.Enabled = false;
            }
            else
            {
                txt_s3.Enabled = true;
                //ckb_cpu_s3.Enabled = true;
                txt_s4.Enabled = true;
                //ckb_cpu_s4.Enabled = true;
            }
        }
        
        private void frm_Einstellungen_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm_Menue.Dispose();
            this.Dispose();
        }
    }
}
