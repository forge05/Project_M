namespace Project_M_CSharp
{
    partial class frm_Menu
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
            this.btn_neues_Spiel = new System.Windows.Forms.Button();
            this.btn_beenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_neues_Spiel
            // 
            this.btn_neues_Spiel.Location = new System.Drawing.Point(40, 38);
            this.btn_neues_Spiel.Name = "btn_neues_Spiel";
            this.btn_neues_Spiel.Size = new System.Drawing.Size(118, 38);
            this.btn_neues_Spiel.TabIndex = 0;
            this.btn_neues_Spiel.Text = "Neues Spiel";
            this.btn_neues_Spiel.UseVisualStyleBackColor = true;
            this.btn_neues_Spiel.Click += new System.EventHandler(this.btn_neues_Spiel_Click);
            // 
            // btn_beenden
            // 
            this.btn_beenden.Location = new System.Drawing.Point(40, 82);
            this.btn_beenden.Name = "btn_beenden";
            this.btn_beenden.Size = new System.Drawing.Size(118, 38);
            this.btn_beenden.TabIndex = 2;
            this.btn_beenden.Text = "Beenden";
            this.btn_beenden.UseVisualStyleBackColor = true;
            this.btn_beenden.Click += new System.EventHandler(this.btn_beenden_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 162);
            this.Controls.Add(this.btn_beenden);
            this.Controls.Add(this.btn_neues_Spiel);
            this.Name = "frm_Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_neues_Spiel;
        private System.Windows.Forms.Button btn_beenden;
    }
}