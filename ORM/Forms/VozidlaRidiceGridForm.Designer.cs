namespace ORM.Forms
{
    partial class VozidlaRidiceGridForm
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
            this.VIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Znacka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stav = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.VIN,
            this.SPZ,
            this.Znacka,
            this.Model,
            this.Typ,
            this.Barva,
            this.uID,
            this.Stav});
            this.dataGrid.Location = new System.Drawing.Point(12, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.Size = new System.Drawing.Size(595, 267);
            this.dataGrid.TabIndex = 0;
            // 
            // VIN
            // 
            this.VIN.DataPropertyName = "VIN";
            this.VIN.HeaderText = "VIN";
            this.VIN.Name = "VIN";
            this.VIN.ReadOnly = true;
            // 
            // SPZ
            // 
            this.SPZ.DataPropertyName = "SPZ";
            this.SPZ.HeaderText = "SPZ";
            this.SPZ.Name = "SPZ";
            this.SPZ.ReadOnly = true;
            // 
            // Znacka
            // 
            this.Znacka.DataPropertyName = "Znacka";
            this.Znacka.HeaderText = "Znacka";
            this.Znacka.Name = "Znacka";
            this.Znacka.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Typ
            // 
            this.Typ.DataPropertyName = "Typ";
            this.Typ.HeaderText = "Typ";
            this.Typ.Name = "Typ";
            this.Typ.ReadOnly = true;
            // 
            // Barva
            // 
            this.Barva.DataPropertyName = "Barva";
            this.Barva.HeaderText = "Barva";
            this.Barva.Name = "Barva";
            this.Barva.ReadOnly = true;
            // 
            // uID
            // 
            this.uID.DataPropertyName = "uID";
            this.uID.HeaderText = "uID";
            this.uID.Name = "uID";
            this.uID.ReadOnly = true;
            // 
            // Stav
            // 
            this.Stav.DataPropertyName = "Stav";
            this.Stav.HeaderText = "Stav";
            this.Stav.Name = "Stav";
            this.Stav.ReadOnly = true;
            // 
            // VozidlaRidiceGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 306);
            this.Controls.Add(this.dataGrid);
            this.Name = "VozidlaRidiceGridForm";
            this.Text = "VozidlaRidiceGridForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn VIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Znacka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typ;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barva;
        private System.Windows.Forms.DataGridViewTextBoxColumn uID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stav;
    }
}