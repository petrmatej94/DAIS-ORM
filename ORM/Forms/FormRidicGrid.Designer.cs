namespace ORM.Forms
{
    partial class FormRidicGrid
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Jmeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ulice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Město = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stát = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Občanství = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumNarození = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PočetBodů = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ČísloŘP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlatnostŘP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stav = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jmeno,
            this.Ulice,
            this.Město,
            this.Stát,
            this.Občanství,
            this.DatumNarození,
            this.PočetBodů,
            this.ČísloŘP,
            this.PlatnostŘP,
            this.Stav});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 24);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(763, 237);
            this.dataGrid.TabIndex = 1;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Jmeno
            // 
            this.Jmeno.DataPropertyName = "Jmeno";
            this.Jmeno.HeaderText = "Jméno";
            this.Jmeno.Name = "Jmeno";
            this.Jmeno.ReadOnly = true;
            // 
            // Ulice
            // 
            this.Ulice.DataPropertyName = "Ulice";
            this.Ulice.HeaderText = "Ulice";
            this.Ulice.Name = "Ulice";
            this.Ulice.ReadOnly = true;
            // 
            // Město
            // 
            this.Město.DataPropertyName = "Mesto";
            this.Město.HeaderText = "Město";
            this.Město.Name = "Město";
            this.Město.ReadOnly = true;
            // 
            // Stát
            // 
            this.Stát.DataPropertyName = "Stat";
            this.Stát.HeaderText = "Stát";
            this.Stát.Name = "Stát";
            this.Stát.ReadOnly = true;
            // 
            // Občanství
            // 
            this.Občanství.DataPropertyName = "Obcanstvi";
            this.Občanství.HeaderText = "Občanství";
            this.Občanství.Name = "Občanství";
            this.Občanství.ReadOnly = true;
            // 
            // DatumNarození
            // 
            this.DatumNarození.DataPropertyName = "Datum_narozeni";
            this.DatumNarození.HeaderText = "DatumNarození";
            this.DatumNarození.Name = "DatumNarození";
            this.DatumNarození.ReadOnly = true;
            // 
            // PočetBodů
            // 
            this.PočetBodů.DataPropertyName = "Pocet_bodu";
            this.PočetBodů.HeaderText = "PočetBodů";
            this.PočetBodů.Name = "PočetBodů";
            this.PočetBodů.ReadOnly = true;
            // 
            // ČísloŘP
            // 
            this.ČísloŘP.DataPropertyName = "Cislo_rp";
            this.ČísloŘP.HeaderText = "ČísloŘP";
            this.ČísloŘP.Name = "ČísloŘP";
            this.ČísloŘP.ReadOnly = true;
            // 
            // PlatnostŘP
            // 
            this.PlatnostŘP.DataPropertyName = "Platnost_rp";
            this.PlatnostŘP.HeaderText = "PlatnostŘP";
            this.PlatnostŘP.Name = "PlatnostŘP";
            this.PlatnostŘP.ReadOnly = true;
            // 
            // Stav
            // 
            this.Stav.DataPropertyName = "Stav";
            this.Stav.HeaderText = "Stav";
            this.Stav.Name = "Stav";
            this.Stav.ReadOnly = true;
            this.Stav.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Stav.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormRidicGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 261);
            this.Controls.Add(this.dataGrid);
            this.Name = "FormRidicGrid";
            this.Text = "FormRidicGrid";
            this.Load += new System.EventHandler(this.FormRidicGrid_Load);
            this.Controls.SetChildIndex(this.dataGrid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jmeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Město;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stát;
        private System.Windows.Forms.DataGridViewTextBoxColumn Občanství;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumNarození;
        private System.Windows.Forms.DataGridViewTextBoxColumn PočetBodů;
        private System.Windows.Forms.DataGridViewTextBoxColumn ČísloŘP;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlatnostŘP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Stav;
    }
}