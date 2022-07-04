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
    public partial class frmPacijent : Form
    {
        ApiService _servicePacijenti = new ApiService("Pacijent");
        ApiService _serviceOsiguranje = new ApiService("Osiguranje");

        private Model.Osiguranje osiguranje;
        public frmPacijent()
        {
            InitializeComponent();
            dgvPacijent.AutoGenerateColumns = false;
        }

        private async void frmPacijent_Load(object sender, EventArgs e)
        {
            await LoadPacijenti();
        }
        private async Task LoadPacijenti()
        {
            var listaPacijenata = await _servicePacijenti.Get<List<Model.Pacijent>>();
            dgvPacijent.DataSource = listaPacijenata;
        }



        private void dgvPacijent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*var pacijent = dgvPacijent.SelectedRows[0].DataBoundItem as Model.Pacijent;
            var senderGrid = (DataGridView)sender;
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&e.RowIndex>=0)
            {
                var x = dgvPacijent.Rows[e.RowIndex].Cells[3].Value.ToString();
                frmOsiguranje forma = new frmOsiguranje();
                forma.OsiguranjeId = (int)x;
                forma.Show();
            }*/
        }

        private void dgvPacijent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvPacijent.SelectedRows[0].DataBoundItem;
            frmOsiguranje forma = new frmOsiguranje(item as Osiguranje);
            forma.ShowDialog();
        }
    }
}
