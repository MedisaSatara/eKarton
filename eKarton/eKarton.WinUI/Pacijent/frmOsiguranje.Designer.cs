
namespace eKarton.WinUI.Pacijent
{
    partial class frmOsiguranje
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
            this.dgvOsiguranje = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OsiguranjeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Osiguranik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vazece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsiguranje)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOsiguranje);
            this.groupBox1.Location = new System.Drawing.Point(92, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podaci o osiguranju";
            // 
            // dgvOsiguranje
            // 
            this.dgvOsiguranje.AllowUserToAddRows = false;
            this.dgvOsiguranje.AllowUserToDeleteRows = false;
            this.dgvOsiguranje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsiguranje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OsiguranjeId,
            this.Osiguranik,
            this.Datum,
            this.Vazece});
            this.dgvOsiguranje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOsiguranje.Location = new System.Drawing.Point(3, 16);
            this.dgvOsiguranje.Name = "dgvOsiguranje";
            this.dgvOsiguranje.ReadOnly = true;
            this.dgvOsiguranje.Size = new System.Drawing.Size(583, 89);
            this.dgvOsiguranje.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtImePrezime);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(95, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pacijent";
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(59, 13);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(135, 20);
            this.txtImePrezime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pacijent";
            // 
            // OsiguranjeId
            // 
            this.OsiguranjeId.DataPropertyName = "OsiguranjeId";
            this.OsiguranjeId.HeaderText = "OsiguranjeId";
            this.OsiguranjeId.Name = "OsiguranjeId";
            this.OsiguranjeId.ReadOnly = true;
            // 
            // Osiguranik
            // 
            this.Osiguranik.DataPropertyName = "Osiguranik";
            this.Osiguranik.HeaderText = "Osiguranik";
            this.Osiguranik.Name = "Osiguranik";
            this.Osiguranik.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Vazece
            // 
            this.Vazece.DataPropertyName = "Vazece";
            this.Vazece.HeaderText = "Vazece";
            this.Vazece.Name = "Vazece";
            this.Vazece.ReadOnly = true;
            // 
            // frmOsiguranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOsiguranje";
            this.Text = "frmOsiguranje";
            this.Load += new System.EventHandler(this.frmOsiguranje_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsiguranje)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOsiguranje;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OsiguranjeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Osiguranik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vazece;
    }
}