
using Otopark.Data.Entities;
using Otopark.Service;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Otopark.Forms
{
    public partial class FrmSerie : Form
    {
        private readonly ISerieService serieService;
        int id = 0;
        public FrmSerie(ISerieService serieService, int id = 0)
        {
            this.serieService = serieService;
            InitializeComponent();
            this.id = id;
        }

        private void SerieList()
        {
            listViewSerie.Items.Clear();

            var list = serieService.Get()
                .Select(x => new
                {
                    Id = x.Id,
                    BrandName = x.Brand.BrandName,
                    SerieName = x.SerieName
                }).ToList();

            foreach (var item in list)
            {
                ListViewItem viewItem = new ListViewItem(item.Id.ToString());
                viewItem.SubItems.Add(item.BrandName);
                viewItem.SubItems.Add(item.SerieName);
                listViewSerie.Items.Add(viewItem);
            }
        }

        void Clean()
        {
            txtId.Text = "";
            txtSerie.Text = "";
            cmbBrand.Text = "";
        }

        private void FrmSerie_Load(object sender, EventArgs e)
        {
            SerieList();
            var list = db.Brands.ToList();
            cmbBrand.DataSource = list;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int brandId = (int)cmbBrand.SelectedValue;
            var model = new Serie()
            {
                BrandId = brandId,
                SerieName = txtSerie.Text
            };
            var result = serieService.Post(model);
            if (result.IsSuccess)
            {
                Clean();
                SerieList();

                MessageBox.Show("Araca yeni seri eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListViewItem selectId = listViewSerie.SelectedItems[0];
            int id = int.Parse(selectId.SubItems[0].Text);
            var result = serieService.Delete(id);
            if (result.IsSuccess)
            {
                MessageBox.Show("Araç serisi silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SerieList();
                Clean();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var model = new Serie
            {
                Id = id,
                BrandId = (int)cmbBrand.SelectedValue,
                SerieName = txtSerie.Text
            };
            var result = serieService.Put(model);
            if (result.IsSuccess)
            {
                MessageBox.Show("Araç serisi güncellendi", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SerieList();
                Clean();
            }
        }

        private void listViewSerie_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem select = listViewSerie.SelectedItems[0];
            if (listViewSerie.SelectedItems.Count > 0)
            {
                txtId.Text = select.SubItems[0].Text;
                cmbBrand.Text = select.SubItems[1].Text;
                txtSerie.Text = select.SubItems[2].Text;
            }
        }
    }
}
