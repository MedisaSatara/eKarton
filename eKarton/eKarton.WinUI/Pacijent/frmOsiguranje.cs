using eKarton.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKarton.WinUI.Pacijent
{
    public partial class frmOsiguranje : Form
    {
        private Model.Pacijent pacijent;
        ApiService _serviceOsiguranje = new ApiService("Osiguranje");
        private Osiguranje osiguranje;
        public frmOsiguranje()
        {
            InitializeComponent();
            dgvOsiguranje.AutoGenerateColumns = false;
        }

        public frmOsiguranje(Model.Pacijent pacijent)
        {
            this.pacijent = pacijent;
        }
        public frmOsiguranje(Osiguranje osiguranje)
        {
            this.osiguranje = osiguranje;
        }
        private async void frmOsiguranje_Load(object sender, EventArgs e)
        {
            
                txtImePrezime.Text = pacijent.Ime + " " + pacijent.Prezime;
                dgvOsiguranje.DataSource = await _serviceOsiguranje.GetById<List<Model.Osiguranje>>(osiguranje);
            

        }
    }
}
