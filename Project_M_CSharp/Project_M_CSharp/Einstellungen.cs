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
        public Form frm;

        public frm_Einstellungen(Form myFrm)
        {
            frm = myFrm;
            InitializeComponent();
        }

        private void frm_Einstellungen_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }

        private void frm_Einstellungen_Load(object sender, EventArgs e)
        {
            
            
        }

        private void rbtn_anz_s_2_CheckedChanged(object sender, EventArgs e)
        {
            //RadioButton myRbtn;
            //foreach(Control rbtn in gb_s_setup.Controls)
            //{
            //    if(rbtn is RadioButton)
            //    {
            //        myRbtn = (RadioButton)rbtn;
            //        if(myRbtn.Checked)
            //        {

            //            break;
            //        }
            //    }
            //}
            if(rbtn_anz_s_2.Checked)
            {
                txt_s3.Enabled = false;
                txt_s3.Text = "Yellow";
                //cmb_s3.Enabled = false;
                ckb_cpu_s3.Enabled = false;
                txt_s4.Enabled = false;
                txt_s4.Text = "Blue";
                //cmb_s4.Enabled = false;
                ckb_cpu_s4.Enabled = false;
            }
            else if(rbtn_anz_s_3.Checked)
            {
                txt_s3.Enabled = true;
                //cmb_s3.Enabled = true;
                ckb_cpu_s3.Enabled = true;
                txt_s4.Enabled = false;
                txt_s4.Text = "Blue";
                //cmb_s4.Enabled = false;
                ckb_cpu_s4.Enabled = false;
            }
            else
            {
                txt_s3.Enabled = true;
                //cmb_s3.Enabled = true;
                ckb_cpu_s3.Enabled = true;
                txt_s4.Enabled = true;
                //cmb_s4.Enabled = true;
                ckb_cpu_s4.Enabled = true;
            }
        }

        private void btn_zurueck_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }
    }
}
