namespace ORM.Forms
{
    partial class ZaznamGridForm
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
            this.Částka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OdebránoBodů = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumZadání = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumExpirace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumProvedení = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Částka,
            this.OdebránoBodů,
            this.DatumZadání,
            this.DatumExpirace,
            this.DatumProvedení});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(546, 261);
            this.dataGrid.TabIndex = 2;
            // 
            // Částka
            // 
            this.Částka.DataPropertyName = "Castka";
            this.Částka.HeaderText = "Částka";
            this.Částka.Name = "Částka";
            this.Částka.ReadOnly = true;
            // 
            // OdebránoBodů
            // 
            this.OdebránoBodů.DataPropertyName = "Odebrano_bodu";
            this.OdebránoBodů.HeaderText = "OdebránoBodů";
            this.OdebránoBodů.Name = "OdebránoBodů";
            this.OdebránoBodů.ReadOnly = true;
            // 
            // DatumZadání
            // 
            this.DatumZadání.DataPropertyName = "Datum_zadani";
            this.DatumZadání.HeaderText = "DatumZadání";
            this.DatumZadání.Name = "DatumZadání";
            this.DatumZadání.ReadOnly = true;
            // 
            // DatumExpirace
            // 
            this.DatumExpirace.DataPropertyName = "Datum_expirace";
            this.DatumExpirace.HeaderText = "DatumExpirace";
            this.DatumExpirace.Name = "DatumExpirace";
            this.DatumExpirace.ReadOnly = true;
            // 
            // DatumProvedení
            // 
            this.DatumProvedení.DataPropertyName = "Datum_provedeni";
            this.DatumProvedení.HeaderText = "DatumProvedení";
            this.DatumProvedení.Name = "DatumProvedení";
            this.DatumProvedení.ReadOnly = true;
            // 
            // ZaznamGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 261);
            this.Controls.Add(this.dataGrid);
            this.Name = "ZaznamGridForm";
            this.Text = "ZaznamGridForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Částka;
        private System.Windows.Forms.DataGridViewTextBoxColumn OdebránoBodů;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumZadání;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumExpirace;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumProvedení;
    }
}