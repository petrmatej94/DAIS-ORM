namespace ORM.Forms
{
    partial class AktualizaceRidiceForm
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
            this.CheckAktivni = new System.Windows.Forms.CheckBox();
            this.BoxObcanstvi = new System.Windows.Forms.TextBox();
            this.BoxStat = new System.Windows.Forms.TextBox();
            this.BoxMesto = new System.Windows.Forms.TextBox();
            this.BoxUlice = new System.Windows.Forms.TextBox();
            this.Button_zadat = new System.Windows.Forms.Button();
            this.Button_Aktualizovat = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.BoxExpirace = new System.Windows.Forms.TextBox();
            this.comboKategorie = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BoxCislo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BoxCastka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CheckAktivni
            // 
            this.CheckAktivni.AutoSize = true;
            this.CheckAktivni.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CheckAktivni.Checked = true;
            this.CheckAktivni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckAktivni.Location = new System.Drawing.Point(173, 206);
            this.CheckAktivni.Name = "CheckAktivni";
            this.CheckAktivni.Size = new System.Drawing.Size(60, 17);
            this.CheckAktivni.TabIndex = 81;
            this.CheckAktivni.Text = "Aktivní";
            this.CheckAktivni.UseVisualStyleBackColor = false;
            // 
            // BoxObcanstvi
            // 
            this.BoxObcanstvi.Location = new System.Drawing.Point(130, 176);
            this.BoxObcanstvi.Name = "BoxObcanstvi";
            this.BoxObcanstvi.Size = new System.Drawing.Size(315, 20);
            this.BoxObcanstvi.TabIndex = 80;
            // 
            // BoxStat
            // 
            this.BoxStat.Location = new System.Drawing.Point(130, 145);
            this.BoxStat.Name = "BoxStat";
            this.BoxStat.Size = new System.Drawing.Size(315, 20);
            this.BoxStat.TabIndex = 79;
            // 
            // BoxMesto
            // 
            this.BoxMesto.Location = new System.Drawing.Point(130, 112);
            this.BoxMesto.Name = "BoxMesto";
            this.BoxMesto.Size = new System.Drawing.Size(315, 20);
            this.BoxMesto.TabIndex = 78;
            // 
            // BoxUlice
            // 
            this.BoxUlice.Location = new System.Drawing.Point(130, 83);
            this.BoxUlice.Name = "BoxUlice";
            this.BoxUlice.Size = new System.Drawing.Size(315, 20);
            this.BoxUlice.TabIndex = 77;
            this.BoxUlice.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Button_zadat
            // 
            this.Button_zadat.Location = new System.Drawing.Point(295, 441);
            this.Button_zadat.Name = "Button_zadat";
            this.Button_zadat.Size = new System.Drawing.Size(159, 30);
            this.Button_zadat.TabIndex = 76;
            this.Button_zadat.Text = "Zadat do systému";
            this.Button_zadat.UseVisualStyleBackColor = true;
            this.Button_zadat.Click += new System.EventHandler(this.Button_zadat_Click_1);
            // 
            // Button_Aktualizovat
            // 
            this.Button_Aktualizovat.Location = new System.Drawing.Point(295, 245);
            this.Button_Aktualizovat.Name = "Button_Aktualizovat";
            this.Button_Aktualizovat.Size = new System.Drawing.Size(159, 30);
            this.Button_Aktualizovat.TabIndex = 75;
            this.Button_Aktualizovat.Text = "Aktualizovat";
            this.Button_Aktualizovat.UseVisualStyleBackColor = true;
            this.Button_Aktualizovat.Click += new System.EventHandler(this.Button_Aktualizovat_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(10, 291);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(263, 24);
            this.label16.TabIndex = 74;
            this.label16.Text = "Vytvoření nového záznamu";
            // 
            // BoxExpirace
            // 
            this.BoxExpirace.Location = new System.Drawing.Point(182, 367);
            this.BoxExpirace.Name = "BoxExpirace";
            this.BoxExpirace.Size = new System.Drawing.Size(263, 20);
            this.BoxExpirace.TabIndex = 70;
            // 
            // comboKategorie
            // 
            this.comboKategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKategorie.FormattingEnabled = true;
            this.comboKategorie.Items.AddRange(new object[] {
            "Jedna",
            "Dva",
            "Tři"});
            this.comboKategorie.Location = new System.Drawing.Point(182, 334);
            this.comboKategorie.Name = "comboKategorie";
            this.comboKategorie.Size = new System.Drawing.Size(263, 21);
            this.comboKategorie.TabIndex = 69;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(29, 367);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 18);
            this.label13.TabIndex = 67;
            this.label13.Text = "Expirace dní:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(29, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 18);
            this.label14.TabIndex = 68;
            this.label14.Text = "Kategorie přestupku:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(28, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 60;
            this.label8.Text = "Číslo ŘP:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(28, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 18);
            this.label11.TabIndex = 61;
            this.label11.Text = "Stav řidiče:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(28, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Občanství:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(28, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 18);
            this.label4.TabIndex = 63;
            this.label4.Text = "Stát:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(29, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 64;
            this.label3.Text = "Město:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(28, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 18);
            this.label10.TabIndex = 65;
            this.label10.Text = "Ulice:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Location = new System.Drawing.Point(14, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(440, 202);
            this.button5.TabIndex = 66;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(169, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 24);
            this.label1.TabIndex = 59;
            this.label1.Text = "Vytvoření nového záznamu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(10, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 24);
            this.label9.TabIndex = 58;
            this.label9.Text = "Aktualizace údajů řidiče";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(14, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(440, 117);
            this.button1.TabIndex = 73;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BoxCislo
            // 
            this.BoxCislo.Location = new System.Drawing.Point(130, 52);
            this.BoxCislo.Name = "BoxCislo";
            this.BoxCislo.ReadOnly = true;
            this.BoxCislo.Size = new System.Drawing.Size(315, 20);
            this.BoxCislo.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(368, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 84;
            this.label2.Text = "label2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(29, 402);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 18);
            this.label12.TabIndex = 71;
            this.label12.Text = "Částka:";
            // 
            // BoxCastka
            // 
            this.BoxCastka.Location = new System.Drawing.Point(182, 402);
            this.BoxCastka.Name = "BoxCastka";
            this.BoxCastka.Size = new System.Drawing.Size(263, 20);
            this.BoxCastka.TabIndex = 72;
            // 
            // DetailRidiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxCislo);
            this.Controls.Add(this.CheckAktivni);
            this.Controls.Add(this.BoxObcanstvi);
            this.Controls.Add(this.BoxStat);
            this.Controls.Add(this.BoxMesto);
            this.Controls.Add(this.BoxUlice);
            this.Controls.Add(this.Button_zadat);
            this.Controls.Add(this.Button_Aktualizovat);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BoxCastka);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BoxExpirace);
            this.Controls.Add(this.comboKategorie);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Name = "DetailRidiceForm";
            this.Text = "DetailRidiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox CheckAktivni;
        private System.Windows.Forms.TextBox BoxObcanstvi;
        private System.Windows.Forms.TextBox BoxStat;
        private System.Windows.Forms.TextBox BoxMesto;
        private System.Windows.Forms.TextBox BoxUlice;
        private System.Windows.Forms.Button Button_zadat;
        private System.Windows.Forms.Button Button_Aktualizovat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox BoxExpirace;
        private System.Windows.Forms.ComboBox comboKategorie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox BoxCislo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox BoxCastka;
    }
}