using System.Windows.Forms;

namespace Project_M_CSharp
{
    partial class frm_Sieg : Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nachricht = new System.Windows.Forms.Label();
            this.lbl_gewinner = new System.Windows.Forms.Label();
            this.btn_okay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nachricht
            // 
            this.lbl_nachricht.AutoSize = true;
            this.lbl_nachricht.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nachricht.Location = new System.Drawing.Point(12, 9);
            this.lbl_nachricht.Name = "lbl_nachricht";
            this.lbl_nachricht.Size = new System.Drawing.Size(291, 32);
            this.lbl_nachricht.TabIndex = 0;
            this.lbl_nachricht.Text = "Sie haben gewonnen:";
            // 
            // lbl_gewinner
            // 
            this.lbl_gewinner.AutoSize = true;
            this.lbl_gewinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gewinner.Location = new System.Drawing.Point(111, 60);
            this.lbl_gewinner.Name = "lbl_gewinner";
            this.lbl_gewinner.Size = new System.Drawing.Size(93, 20);
            this.lbl_gewinner.TabIndex = 1;
            this.lbl_gewinner.Text = "TESTTEXT";
            // 
            // btn_okay
            // 
            this.btn_okay.Location = new System.Drawing.Point(18, 110);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Size = new System.Drawing.Size(285, 53);
            this.btn_okay.TabIndex = 2;
            this.btn_okay.Text = "Okay";
            this.btn_okay.UseVisualStyleBackColor = true;
            this.btn_okay.Click += new System.EventHandler(this.btn_okay_Click);
            // 
            // frm_Sieg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 190);
            this.Controls.Add(this.btn_okay);
            this.Controls.Add(this.lbl_gewinner);
            this.Controls.Add(this.lbl_nachricht);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_Sieg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sieg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nachricht;
        private System.Windows.Forms.Label lbl_gewinner;
        private Button btn_okay;
    }
}