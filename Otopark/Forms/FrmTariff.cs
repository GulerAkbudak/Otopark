
using Otopark.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Otopark.Forms
{
    public partial class FrmTariff : Form
    {
        private readonly ITariffService tariffService;
        private int id = 0;
        public static FrmTariff frmTariff;

        public FrmTariff(ITariffService tariffService)
        {
            InitializeComponent();
            this.tariffService = tariffService;
            frmTariff = this;
        }

        private void FrmTariff_Load(object sender, EventArgs e)
        {
            TariffLoad();
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        public void TariffLoad()
        {
            dataGridTariff.DataSource = tariffService.Get();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmAddTariff frm = new FrmAddTariff(tariffService);
            frm.ShowDialog(this);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmAddTariff frm = new FrmAddTariff(tariffService, id);
            frm.ShowDialog(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {

                var result = tariffService.Delete(id);
                if (result.IsSuccess)
                {
                    MessageBox.Show("Kayıt silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TariffLoad();
                }
               
            }
        }

        private void dataGridTariff_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridTariff.Rows[e.RowIndex];
                id = Int32.Parse(row.Cells["TariffId"].Value.ToString());
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
        }

        private void dataGridTariff_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridTariff.ClearSelection();
        }
    }
}
