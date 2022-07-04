
namespace eKarton.WinUI.Pacijent
{
    partial class frmPacijent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPacijent = new System.Windows.Forms.DataGridView();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MjestoRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prebivaliste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KrvnaGrupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RhFaktor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HronicneBolesti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alergican = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Koagulopatije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OsiguranjeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPacijent);
            this.groupBox1.Location = new System.Drawing.Point(74, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista pacijenata";
            // 
            // dgvPacijent
            // 
            this.dgvPacijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ime,
            this.Prezime,
            this.Spol,
            this.DatumRodjenja,
            this.MjestoRodjenja,
            this.JMBG,
            this.Prebivaliste,
            this.Telefon,
            this.KrvnaGrupa,
            this.RhFaktor,
            this.HronicneBolesti,
            this.Alergican,
            this.Koagulopatije,
            this.OsiguranjeId});
            this.dgvPacijent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacijent.Location = new System.Drawing.Point(3, 16);
            this.dgvPacijent.Name = "dgvPacijent";
            this.dgvPacijent.Size = new System.Drawing.Size(619, 116);
            this.dgvPacijent.TabIndex = 0;
            this.dgvPacijent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacijent_CellDoubleClick);
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            // 
            // MjestoRodjenja
            // 
            this.MjestoRodjenja.DataPropertyName = "MjestoRodjenja";
            this.MjestoRodjenja.HeaderText = "Mjesto rodjenja";
            this.MjestoRodjenja.Name = "MjestoRodjenja";
            // 
            // JMBG
            // 
            this.JMBG.DataPropertyName = "JMBG";
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.Name = "JMBG";
            // 
            // Prebivaliste
            // 
            this.Prebivaliste.DataPropertyName = "Prebivaliste";
            this.Prebivaliste.HeaderText = "Prebivaliste";
            this.Prebivaliste.Name = "Prebivaliste";
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            // 
            // KrvnaGrupa
            // 
            this.KrvnaGrupa.DataPropertyName = "KrvnaGrupa";
            this.KrvnaGrupa.HeaderText = "Krvna grupa";
            this.KrvnaGrupa.Name = "KrvnaGrupa";
            // 
            // RhFaktor
            // 
            this.RhFaktor.DataPropertyName = "RhFaktor";
            this.RhFaktor.HeaderText = "RhFaktor";
            this.RhFaktor.Name = "RhFaktor";
            // 
            // HronicneBolesti
            // 
            this.HronicneBolesti.DataPropertyName = "HronicneBolesti";
            this.HronicneBolesti.HeaderText = "Hronicne bolesti";
            this.HronicneBolesti.Name = "HronicneBolesti";
            // 
            // Alergican
            // 
            this.Alergican.DataPropertyName = "Alergican";
            this.Alergican.HeaderText = "Alergican";
            this.Alergican.Name = "Alergican";
            // 
            // Koagulopatije
            // 
            this.Koagulopatije.DataPropertyName = "Koagulopatije";
            this.Koagulopatije.HeaderText = "Koagulopatije";
            this.Koagulopatije.Name = "Koagulopatije";
            // 
            // OsiguranjeId
            // 
            this.OsiguranjeId.DataPropertyName = "OsiguranjeId";
            this.OsiguranjeId.HeaderText = "Osiguranje";
            this.OsiguranjeId.Name = "OsiguranjeId";
            // 
            // frmPacijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPacijent";
            this.Text = "frmPacijent";
            this.Load += new System.EventHandler(this.frmPacijent_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPacijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn MjestoRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prebivaliste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn KrvnaGrupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn RhFaktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn HronicneBolesti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alergican;
        private System.Windows.Forms.DataGridViewTextBoxColumn Koagulopatije;
        private System.Windows.Forms.DataGridViewTextBoxColumn OsiguranjeId;
    }
}