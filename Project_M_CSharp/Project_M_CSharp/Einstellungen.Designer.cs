namespace Project_M_CSharp
{
    partial class frm_Einstellungen
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
            this.rbtn_anz_s_2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_s1 = new System.Windows.Forms.TextBox();
            this.rbtn_anz_s_3 = new System.Windows.Forms.RadioButton();
            this.rbtn_anz_s_4 = new System.Windows.Forms.RadioButton();
            this.gb_s_setup = new System.Windows.Forms.GroupBox();
            this.gb_start_player = new System.Windows.Forms.GroupBox();
            this.rbtn_beginn_4 = new System.Windows.Forms.RadioButton();
            this.rbtn_beginn_3 = new System.Windows.Forms.RadioButton();
            this.rbtn_beginn_2 = new System.Windows.Forms.RadioButton();
            this.rbtn_beginn_1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckb_cpu_s4 = new System.Windows.Forms.CheckBox();
            this.ckb_cpu_s3 = new System.Windows.Forms.CheckBox();
            this.ckb_cpu_s2 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ckb_cpu_s1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_s4 = new System.Windows.Forms.TextBox();
            this.txt_s3 = new System.Windows.Forms.TextBox();
            this.txt_s2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.btn_zurueck = new System.Windows.Forms.Button();
            this.btn_spiel_starten = new System.Windows.Forms.Button();
            this.gb_s_setup.SuspendLayout();
            this.gb_start_player.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtn_anz_s_2
            // 
            this.rbtn_anz_s_2.AutoSize = true;
            this.rbtn_anz_s_2.Location = new System.Drawing.Point(181, 45);
            this.rbtn_anz_s_2.Name = "rbtn_anz_s_2";
            this.rbtn_anz_s_2.Size = new System.Drawing.Size(31, 17);
            this.rbtn_anz_s_2.TabIndex = 0;
            this.rbtn_anz_s_2.Text = "2";
            this.rbtn_anz_s_2.UseVisualStyleBackColor = true;
            this.rbtn_anz_s_2.CheckedChanged += new System.EventHandler(this.rbtn_anz_s_2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Anzahl Spieler?";
            // 
            // txt_s1
            // 
            this.txt_s1.Location = new System.Drawing.Point(92, 109);
            this.txt_s1.Name = "txt_s1";
            this.txt_s1.Size = new System.Drawing.Size(100, 20);
            this.txt_s1.TabIndex = 2;
            this.txt_s1.Text = "Red";
            // 
            // rbtn_anz_s_3
            // 
            this.rbtn_anz_s_3.AutoSize = true;
            this.rbtn_anz_s_3.Location = new System.Drawing.Point(218, 45);
            this.rbtn_anz_s_3.Name = "rbtn_anz_s_3";
            this.rbtn_anz_s_3.Size = new System.Drawing.Size(31, 17);
            this.rbtn_anz_s_3.TabIndex = 3;
            this.rbtn_anz_s_3.Text = "3";
            this.rbtn_anz_s_3.UseVisualStyleBackColor = true;
            this.rbtn_anz_s_3.CheckedChanged += new System.EventHandler(this.rbtn_anz_s_2_CheckedChanged);
            // 
            // rbtn_anz_s_4
            // 
            this.rbtn_anz_s_4.AutoSize = true;
            this.rbtn_anz_s_4.Checked = true;
            this.rbtn_anz_s_4.Location = new System.Drawing.Point(255, 45);
            this.rbtn_anz_s_4.Name = "rbtn_anz_s_4";
            this.rbtn_anz_s_4.Size = new System.Drawing.Size(31, 17);
            this.rbtn_anz_s_4.TabIndex = 4;
            this.rbtn_anz_s_4.TabStop = true;
            this.rbtn_anz_s_4.Text = "4";
            this.rbtn_anz_s_4.UseVisualStyleBackColor = true;
            this.rbtn_anz_s_4.CheckedChanged += new System.EventHandler(this.rbtn_anz_s_2_CheckedChanged);
            // 
            // gb_s_setup
            // 
            this.gb_s_setup.Controls.Add(this.gb_start_player);
            this.gb_s_setup.Controls.Add(this.label9);
            this.gb_s_setup.Controls.Add(this.label8);
            this.gb_s_setup.Controls.Add(this.label7);
            this.gb_s_setup.Controls.Add(this.label2);
            this.gb_s_setup.Controls.Add(this.ckb_cpu_s4);
            this.gb_s_setup.Controls.Add(this.ckb_cpu_s3);
            this.gb_s_setup.Controls.Add(this.ckb_cpu_s2);
            this.gb_s_setup.Controls.Add(this.rbtn_anz_s_4);
            this.gb_s_setup.Controls.Add(this.rbtn_anz_s_3);
            this.gb_s_setup.Controls.Add(this.label1);
            this.gb_s_setup.Controls.Add(this.rbtn_anz_s_2);
            this.gb_s_setup.Controls.Add(this.label6);
            this.gb_s_setup.Controls.Add(this.label5);
            this.gb_s_setup.Controls.Add(this.label4);
            this.gb_s_setup.Controls.Add(this.ckb_cpu_s1);
            this.gb_s_setup.Controls.Add(this.label3);
            this.gb_s_setup.Controls.Add(this.txt_s4);
            this.gb_s_setup.Controls.Add(this.txt_s3);
            this.gb_s_setup.Controls.Add(this.txt_s2);
            this.gb_s_setup.Controls.Add(this.txt_s1);
            this.gb_s_setup.Location = new System.Drawing.Point(33, 48);
            this.gb_s_setup.Name = "gb_s_setup";
            this.gb_s_setup.Size = new System.Drawing.Size(445, 237);
            this.gb_s_setup.TabIndex = 10;
            this.gb_s_setup.TabStop = false;
            this.gb_s_setup.Text = "Spieler-Setup";
            // 
            // gb_start_player
            // 
            this.gb_start_player.Controls.Add(this.rbtn_beginn_4);
            this.gb_start_player.Controls.Add(this.rbtn_beginn_3);
            this.gb_start_player.Controls.Add(this.rbtn_beginn_2);
            this.gb_start_player.Controls.Add(this.rbtn_beginn_1);
            this.gb_start_player.Location = new System.Drawing.Point(312, 76);
            this.gb_start_player.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_start_player.Name = "gb_start_player";
            this.gb_start_player.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_start_player.Size = new System.Drawing.Size(75, 132);
            this.gb_start_player.TabIndex = 23;
            this.gb_start_player.TabStop = false;
            this.gb_start_player.Text = "Wer soll beginnen?";
            // 
            // rbtn_beginn_4
            // 
            this.rbtn_beginn_4.AutoSize = true;
            this.rbtn_beginn_4.Location = new System.Drawing.Point(31, 110);
            this.rbtn_beginn_4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_beginn_4.Name = "rbtn_beginn_4";
            this.rbtn_beginn_4.Size = new System.Drawing.Size(14, 13);
            this.rbtn_beginn_4.TabIndex = 3;
            this.rbtn_beginn_4.UseVisualStyleBackColor = true;
            // 
            // rbtn_beginn_3
            // 
            this.rbtn_beginn_3.AutoSize = true;
            this.rbtn_beginn_3.Location = new System.Drawing.Point(31, 88);
            this.rbtn_beginn_3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_beginn_3.Name = "rbtn_beginn_3";
            this.rbtn_beginn_3.Size = new System.Drawing.Size(14, 13);
            this.rbtn_beginn_3.TabIndex = 2;
            this.rbtn_beginn_3.UseVisualStyleBackColor = true;
            // 
            // rbtn_beginn_2
            // 
            this.rbtn_beginn_2.AutoSize = true;
            this.rbtn_beginn_2.Location = new System.Drawing.Point(31, 55);
            this.rbtn_beginn_2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_beginn_2.Name = "rbtn_beginn_2";
            this.rbtn_beginn_2.Size = new System.Drawing.Size(14, 13);
            this.rbtn_beginn_2.TabIndex = 1;
            this.rbtn_beginn_2.UseVisualStyleBackColor = true;
            // 
            // rbtn_beginn_1
            // 
            this.rbtn_beginn_1.AutoSize = true;
            this.rbtn_beginn_1.Checked = true;
            this.rbtn_beginn_1.Location = new System.Drawing.Point(31, 32);
            this.rbtn_beginn_1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtn_beginn_1.Name = "rbtn_beginn_1";
            this.rbtn_beginn_1.Size = new System.Drawing.Size(14, 13);
            this.rbtn_beginn_1.TabIndex = 0;
            this.rbtn_beginn_1.TabStop = true;
            this.rbtn_beginn_1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(196, 192);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "BLUE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(196, 165);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "YELLOW";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(196, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "GREEN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(196, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "RED";
            // 
            // ckb_cpu_s4
            // 
            this.ckb_cpu_s4.AutoSize = true;
            this.ckb_cpu_s4.Location = new System.Drawing.Point(255, 191);
            this.ckb_cpu_s4.Name = "ckb_cpu_s4";
            this.ckb_cpu_s4.Size = new System.Drawing.Size(48, 17);
            this.ckb_cpu_s4.TabIndex = 18;
            this.ckb_cpu_s4.Text = "CPU";
            this.ckb_cpu_s4.UseVisualStyleBackColor = true;
            // 
            // ckb_cpu_s3
            // 
            this.ckb_cpu_s3.AutoSize = true;
            this.ckb_cpu_s3.Location = new System.Drawing.Point(255, 164);
            this.ckb_cpu_s3.Name = "ckb_cpu_s3";
            this.ckb_cpu_s3.Size = new System.Drawing.Size(48, 17);
            this.ckb_cpu_s3.TabIndex = 17;
            this.ckb_cpu_s3.Text = "CPU";
            this.ckb_cpu_s3.UseVisualStyleBackColor = true;
            // 
            // ckb_cpu_s2
            // 
            this.ckb_cpu_s2.AutoSize = true;
            this.ckb_cpu_s2.Location = new System.Drawing.Point(255, 136);
            this.ckb_cpu_s2.Name = "ckb_cpu_s2";
            this.ckb_cpu_s2.Size = new System.Drawing.Size(48, 17);
            this.ckb_cpu_s2.TabIndex = 16;
            this.ckb_cpu_s2.Text = "CPU";
            this.ckb_cpu_s2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Spieler 4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Spieler 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Spieler 2:";
            // 
            // ckb_cpu_s1
            // 
            this.ckb_cpu_s1.AutoSize = true;
            this.ckb_cpu_s1.Location = new System.Drawing.Point(255, 110);
            this.ckb_cpu_s1.Name = "ckb_cpu_s1";
            this.ckb_cpu_s1.Size = new System.Drawing.Size(48, 17);
            this.ckb_cpu_s1.TabIndex = 9;
            this.ckb_cpu_s1.Text = "CPU";
            this.ckb_cpu_s1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Spieler 1:";
            // 
            // txt_s4
            // 
            this.txt_s4.Location = new System.Drawing.Point(92, 189);
            this.txt_s4.Name = "txt_s4";
            this.txt_s4.Size = new System.Drawing.Size(100, 20);
            this.txt_s4.TabIndex = 5;
            this.txt_s4.Text = "Blue";
            // 
            // txt_s3
            // 
            this.txt_s3.Location = new System.Drawing.Point(92, 162);
            this.txt_s3.Name = "txt_s3";
            this.txt_s3.Size = new System.Drawing.Size(100, 20);
            this.txt_s3.TabIndex = 4;
            this.txt_s3.Text = "Yellow";
            // 
            // txt_s2
            // 
            this.txt_s2.Location = new System.Drawing.Point(92, 135);
            this.txt_s2.Name = "txt_s2";
            this.txt_s2.Size = new System.Drawing.Size(100, 20);
            this.txt_s2.TabIndex = 3;
            this.txt_s2.Text = "Green";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hScrollBar1);
            this.groupBox2.Location = new System.Drawing.Point(33, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio";
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(38, 46);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(80, 17);
            this.hScrollBar1.TabIndex = 0;
            // 
            // btn_zurueck
            // 
            this.btn_zurueck.Location = new System.Drawing.Point(251, 330);
            this.btn_zurueck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_zurueck.Name = "btn_zurueck";
            this.btn_zurueck.Size = new System.Drawing.Size(85, 44);
            this.btn_zurueck.TabIndex = 12;
            this.btn_zurueck.Text = "Zurück zum Menü";
            this.btn_zurueck.UseVisualStyleBackColor = true;
            this.btn_zurueck.Click += new System.EventHandler(this.btn_zurueck_Click);
            // 
            // btn_spiel_starten
            // 
            this.btn_spiel_starten.Location = new System.Drawing.Point(345, 331);
            this.btn_spiel_starten.Name = "btn_spiel_starten";
            this.btn_spiel_starten.Size = new System.Drawing.Size(86, 43);
            this.btn_spiel_starten.TabIndex = 13;
            this.btn_spiel_starten.Text = "Spiel starten";
            this.btn_spiel_starten.UseVisualStyleBackColor = true;
            this.btn_spiel_starten.Click += new System.EventHandler(this.btn_spiel_starten_Click);
            // 
            // frm_Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 444);
            this.Controls.Add(this.btn_spiel_starten);
            this.Controls.Add(this.btn_zurueck);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb_s_setup);
            this.Name = "frm_Einstellungen";
            this.Text = "Einstellungen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Einstellungen_FormClosing);
            this.Load += new System.EventHandler(this.frm_Einstellungen_Load);
            this.gb_s_setup.ResumeLayout(false);
            this.gb_s_setup.PerformLayout();
            this.gb_start_player.ResumeLayout(false);
            this.gb_start_player.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_anz_s_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_s1;
        private System.Windows.Forms.RadioButton rbtn_anz_s_3;
        private System.Windows.Forms.RadioButton rbtn_anz_s_4;
        private System.Windows.Forms.GroupBox gb_s_setup;
        private System.Windows.Forms.CheckBox ckb_cpu_s4;
        private System.Windows.Forms.CheckBox ckb_cpu_s3;
        private System.Windows.Forms.CheckBox ckb_cpu_s2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckb_cpu_s1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_s4;
        private System.Windows.Forms.TextBox txt_s3;
        private System.Windows.Forms.TextBox txt_s2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_start_player;
        private System.Windows.Forms.RadioButton rbtn_beginn_4;
        private System.Windows.Forms.RadioButton rbtn_beginn_3;
        private System.Windows.Forms.RadioButton rbtn_beginn_2;
        private System.Windows.Forms.RadioButton rbtn_beginn_1;
        private System.Windows.Forms.Button btn_zurueck;
        private System.Windows.Forms.Button btn_spiel_starten;
    }
}