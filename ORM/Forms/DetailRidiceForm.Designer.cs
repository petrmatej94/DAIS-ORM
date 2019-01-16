namespace ORM.Forms
{
    partial class DetailRidiceForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NovyZaznam = new System.Windows.Forms.Button();
            this.ZobrazVozidla = new System.Windows.Forms.Button();
            this.ZobrazZaznamy = new System.Windows.Forms.Button();
            this.PlatnostLabel = new System.Windows.Forms.Label();
            this.CisloLabel = new System.Windows.Forms.Label();
            this.StavLabel = new System.Windows.Forms.Label();
            this.PocetLabel = new System.Windows.Forms.Label();
            this.DatumLabel = new System.Windows.Forms.Label();
            this.ObcanstviLabel = new System.Windows.Forms.Label();
            this.StatLabel = new System.Windows.Forms.Label();
            this.MestoLabel = new System.Windows.Forms.Label();
            this.UliceLabel = new System.Windows.Forms.Label();
            this.JmenoLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.BoxUlice = new System.Windows.Forms.TextBox();
            this.BoxMesto = new System.Windows.Forms.TextBox();
            this.BoxStat = new System.Windows.Forms.TextBox();
            this.BoxObcanstvi = new System.Windows.Forms.TextBox();
            this.BoxDatum = new System.Windows.Forms.TextBox();
            this.BoxCislo = new System.Windows.Forms.TextBox();
            this.BoxPlatnost = new System.Windows.Forms.TextBox();
            this.BoxPocet = new System.Windows.Forms.TextBox();
            this.CheckAktivni = new System.Windows.Forms.CheckBox();
            this.Aktualizace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(14, 282);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(565, 90);
            this.listBox1.TabIndex = 36;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(10, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 24);
            this.label13.TabIndex = 35;
            this.label13.Text = "Skupiny řidiče";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(10, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 24);
            this.label12.TabIndex = 34;
            this.label12.Text = "Detailní informace o řidiči";
            // 
            // NovyZaznam
            // 
            this.NovyZaznam.Location = new System.Drawing.Point(14, 434);
            this.NovyZaznam.Name = "NovyZaznam";
            this.NovyZaznam.Size = new System.Drawing.Size(565, 36);
            this.NovyZaznam.TabIndex = 29;
            this.NovyZaznam.Text = "Vytvořit nový záznam";
            this.NovyZaznam.UseVisualStyleBackColor = true;
            this.NovyZaznam.Click += new System.EventHandler(this.NovyZaznam_Click);
            // 
            // ZobrazVozidla
            // 
            this.ZobrazVozidla.Location = new System.Drawing.Point(14, 392);
            this.ZobrazVozidla.Name = "ZobrazVozidla";
            this.ZobrazVozidla.Size = new System.Drawing.Size(266, 36);
            this.ZobrazVozidla.TabIndex = 30;
            this.ZobrazVozidla.Text = "Zobrazit přihlášená vozidla";
            this.ZobrazVozidla.UseVisualStyleBackColor = true;
            this.ZobrazVozidla.Click += new System.EventHandler(this.ZobrazVozidla_Click);
            // 
            // ZobrazZaznamy
            // 
            this.ZobrazZaznamy.Location = new System.Drawing.Point(301, 392);
            this.ZobrazZaznamy.Name = "ZobrazZaznamy";
            this.ZobrazZaznamy.Size = new System.Drawing.Size(278, 36);
            this.ZobrazZaznamy.TabIndex = 31;
            this.ZobrazZaznamy.Text = "Zobrazit záznamy řidiče";
            this.ZobrazZaznamy.UseVisualStyleBackColor = true;
            this.ZobrazZaznamy.Click += new System.EventHandler(this.ZobrazZaznamy_Click);
            // 
            // PlatnostLabel
            // 
            this.PlatnostLabel.AutoSize = true;
            this.PlatnostLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PlatnostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlatnostLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlatnostLabel.Location = new System.Drawing.Point(168, 168);
            this.PlatnostLabel.Name = "PlatnostLabel";
            this.PlatnostLabel.Size = new System.Drawing.Size(112, 18);
            this.PlatnostLabel.TabIndex = 23;
            this.PlatnostLabel.Text = "Platnost ŘP do:";
            // 
            // CisloLabel
            // 
            this.CisloLabel.AutoSize = true;
            this.CisloLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CisloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CisloLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CisloLabel.Location = new System.Drawing.Point(168, 148);
            this.CisloLabel.Name = "CisloLabel";
            this.CisloLabel.Size = new System.Drawing.Size(71, 18);
            this.CisloLabel.TabIndex = 19;
            this.CisloLabel.Text = "Číslo ŘP:";
            // 
            // StavLabel
            // 
            this.StavLabel.AutoSize = true;
            this.StavLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.StavLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StavLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StavLabel.Location = new System.Drawing.Point(168, 208);
            this.StavLabel.Name = "StavLabel";
            this.StavLabel.Size = new System.Drawing.Size(80, 18);
            this.StavLabel.TabIndex = 24;
            this.StavLabel.Text = "Stav řidiče:";
            // 
            // PocetLabel
            // 
            this.PocetLabel.AutoSize = true;
            this.PocetLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PocetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PocetLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PocetLabel.Location = new System.Drawing.Point(168, 188);
            this.PocetLabel.Name = "PocetLabel";
            this.PocetLabel.Size = new System.Drawing.Size(88, 18);
            this.PocetLabel.TabIndex = 25;
            this.PocetLabel.Text = "Počet bodů:";
            // 
            // DatumLabel
            // 
            this.DatumLabel.AutoSize = true;
            this.DatumLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.DatumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DatumLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DatumLabel.Location = new System.Drawing.Point(168, 128);
            this.DatumLabel.Name = "DatumLabel";
            this.DatumLabel.Size = new System.Drawing.Size(117, 18);
            this.DatumLabel.TabIndex = 26;
            this.DatumLabel.Text = "Datum narození:";
            // 
            // ObcanstviLabel
            // 
            this.ObcanstviLabel.AutoSize = true;
            this.ObcanstviLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ObcanstviLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ObcanstviLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ObcanstviLabel.Location = new System.Drawing.Point(168, 108);
            this.ObcanstviLabel.Name = "ObcanstviLabel";
            this.ObcanstviLabel.Size = new System.Drawing.Size(78, 18);
            this.ObcanstviLabel.TabIndex = 27;
            this.ObcanstviLabel.Text = "Občanství:";
            // 
            // StatLabel
            // 
            this.StatLabel.AutoSize = true;
            this.StatLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.StatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StatLabel.Location = new System.Drawing.Point(168, 88);
            this.StatLabel.Name = "StatLabel";
            this.StatLabel.Size = new System.Drawing.Size(38, 18);
            this.StatLabel.TabIndex = 28;
            this.StatLabel.Text = "Stát:";
            // 
            // MestoLabel
            // 
            this.MestoLabel.AutoSize = true;
            this.MestoLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MestoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MestoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MestoLabel.Location = new System.Drawing.Point(168, 68);
            this.MestoLabel.Name = "MestoLabel";
            this.MestoLabel.Size = new System.Drawing.Size(54, 18);
            this.MestoLabel.TabIndex = 22;
            this.MestoLabel.Text = "Město:";
            // 
            // UliceLabel
            // 
            this.UliceLabel.AutoSize = true;
            this.UliceLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UliceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UliceLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UliceLabel.Location = new System.Drawing.Point(168, 48);
            this.UliceLabel.Name = "UliceLabel";
            this.UliceLabel.Size = new System.Drawing.Size(45, 18);
            this.UliceLabel.TabIndex = 21;
            this.UliceLabel.Text = "Ulice:";
            // 
            // JmenoLabel
            // 
            this.JmenoLabel.AutoSize = true;
            this.JmenoLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.JmenoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.JmenoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.JmenoLabel.Location = new System.Drawing.Point(30, 47);
            this.JmenoLabel.Name = "JmenoLabel";
            this.JmenoLabel.Size = new System.Drawing.Size(103, 24);
            this.JmenoLabel.TabIndex = 20;
            this.JmenoLabel.Text = "Petr Matěj";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(34, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 120);
            this.textBox1.TabIndex = 18;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Location = new System.Drawing.Point(14, 37);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(565, 202);
            this.button5.TabIndex = 33;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // BoxUlice
            // 
            this.BoxUlice.Location = new System.Drawing.Point(289, 51);
            this.BoxUlice.Name = "BoxUlice";
            this.BoxUlice.ReadOnly = true;
            this.BoxUlice.Size = new System.Drawing.Size(278, 20);
            this.BoxUlice.TabIndex = 84;
            // 
            // BoxMesto
            // 
            this.BoxMesto.Location = new System.Drawing.Point(289, 69);
            this.BoxMesto.Name = "BoxMesto";
            this.BoxMesto.ReadOnly = true;
            this.BoxMesto.Size = new System.Drawing.Size(278, 20);
            this.BoxMesto.TabIndex = 85;
            // 
            // BoxStat
            // 
            this.BoxStat.Location = new System.Drawing.Point(289, 89);
            this.BoxStat.Name = "BoxStat";
            this.BoxStat.ReadOnly = true;
            this.BoxStat.Size = new System.Drawing.Size(278, 20);
            this.BoxStat.TabIndex = 86;
            // 
            // BoxObcanstvi
            // 
            this.BoxObcanstvi.Location = new System.Drawing.Point(289, 108);
            this.BoxObcanstvi.Name = "BoxObcanstvi";
            this.BoxObcanstvi.ReadOnly = true;
            this.BoxObcanstvi.Size = new System.Drawing.Size(278, 20);
            this.BoxObcanstvi.TabIndex = 87;
            // 
            // BoxDatum
            // 
            this.BoxDatum.Location = new System.Drawing.Point(289, 128);
            this.BoxDatum.Name = "BoxDatum";
            this.BoxDatum.ReadOnly = true;
            this.BoxDatum.Size = new System.Drawing.Size(278, 20);
            this.BoxDatum.TabIndex = 88;
            // 
            // BoxCislo
            // 
            this.BoxCislo.Location = new System.Drawing.Point(289, 146);
            this.BoxCislo.Name = "BoxCislo";
            this.BoxCislo.ReadOnly = true;
            this.BoxCislo.Size = new System.Drawing.Size(278, 20);
            this.BoxCislo.TabIndex = 89;
            // 
            // BoxPlatnost
            // 
            this.BoxPlatnost.Location = new System.Drawing.Point(289, 166);
            this.BoxPlatnost.Name = "BoxPlatnost";
            this.BoxPlatnost.ReadOnly = true;
            this.BoxPlatnost.Size = new System.Drawing.Size(278, 20);
            this.BoxPlatnost.TabIndex = 90;
            // 
            // BoxPocet
            // 
            this.BoxPocet.Location = new System.Drawing.Point(289, 186);
            this.BoxPocet.Name = "BoxPocet";
            this.BoxPocet.ReadOnly = true;
            this.BoxPocet.Size = new System.Drawing.Size(278, 20);
            this.BoxPocet.TabIndex = 91;
            // 
            // CheckAktivni
            // 
            this.CheckAktivni.AutoSize = true;
            this.CheckAktivni.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.CheckAktivni.Checked = true;
            this.CheckAktivni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckAktivni.Enabled = false;
            this.CheckAktivni.Location = new System.Drawing.Point(289, 211);
            this.CheckAktivni.Name = "CheckAktivni";
            this.CheckAktivni.Size = new System.Drawing.Size(60, 17);
            this.CheckAktivni.TabIndex = 92;
            this.CheckAktivni.Text = "Aktivní";
            this.CheckAktivni.UseVisualStyleBackColor = false;
            // 
            // Aktualizace
            // 
            this.Aktualizace.Location = new System.Drawing.Point(445, 7);
            this.Aktualizace.Name = "Aktualizace";
            this.Aktualizace.Size = new System.Drawing.Size(134, 24);
            this.Aktualizace.TabIndex = 93;
            this.Aktualizace.Text = "Aktualizace údajů";
            this.Aktualizace.UseVisualStyleBackColor = true;
            this.Aktualizace.Click += new System.EventHandler(this.Aktualizace_Click);
            // 
            // DetailRidiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 481);
            this.Controls.Add(this.Aktualizace);
            this.Controls.Add(this.CheckAktivni);
            this.Controls.Add(this.BoxPocet);
            this.Controls.Add(this.BoxPlatnost);
            this.Controls.Add(this.BoxCislo);
            this.Controls.Add(this.BoxDatum);
            this.Controls.Add(this.BoxObcanstvi);
            this.Controls.Add(this.BoxStat);
            this.Controls.Add(this.BoxMesto);
            this.Controls.Add(this.BoxUlice);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NovyZaznam);
            this.Controls.Add(this.ZobrazVozidla);
            this.Controls.Add(this.ZobrazZaznamy);
            this.Controls.Add(this.PlatnostLabel);
            this.Controls.Add(this.CisloLabel);
            this.Controls.Add(this.StavLabel);
            this.Controls.Add(this.PocetLabel);
            this.Controls.Add(this.DatumLabel);
            this.Controls.Add(this.ObcanstviLabel);
            this.Controls.Add(this.StatLabel);
            this.Controls.Add(this.MestoLabel);
            this.Controls.Add(this.UliceLabel);
            this.Controls.Add(this.JmenoLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Name = "DetailRidiceForm";
            this.Text = "DetailRidiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button NovyZaznam;
        private System.Windows.Forms.Button ZobrazVozidla;
        private System.Windows.Forms.Button ZobrazZaznamy;
        private System.Windows.Forms.Label PlatnostLabel;
        private System.Windows.Forms.Label CisloLabel;
        private System.Windows.Forms.Label StavLabel;
        private System.Windows.Forms.Label PocetLabel;
        private System.Windows.Forms.Label DatumLabel;
        private System.Windows.Forms.Label ObcanstviLabel;
        private System.Windows.Forms.Label StatLabel;
        private System.Windows.Forms.Label MestoLabel;
        private System.Windows.Forms.Label UliceLabel;
        private System.Windows.Forms.Label JmenoLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.TextBox BoxUlice;
        public System.Windows.Forms.TextBox BoxMesto;
        public System.Windows.Forms.TextBox BoxStat;
        public System.Windows.Forms.TextBox BoxObcanstvi;
        public System.Windows.Forms.TextBox BoxDatum;
        public System.Windows.Forms.TextBox BoxCislo;
        public System.Windows.Forms.TextBox BoxPlatnost;
        public System.Windows.Forms.TextBox BoxPocet;
        private System.Windows.Forms.CheckBox CheckAktivni;
        private System.Windows.Forms.Button Aktualizace;
    }
}