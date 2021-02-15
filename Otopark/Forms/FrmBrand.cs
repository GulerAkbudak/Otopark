using Otopark.Data.Entities;
using Otopark.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark.Forms
{
    public partial class FrmBrand : Form
    {
        public FrmBrand()
        {
            InitializeComponent();
        }

        CarParkDbContext db = new CarParkDbContext();

        private void BrandList()
        {
            listViewBrand.Items.Clear();
            var brandNameList = db.Brands.ToList();
            for (int i = 0; i < brandNameList.Count; i++)
            {
                ListViewItem add = new ListViewItem(brandNameList[i].Id.ToString());
                add.SubItems.Add(brandNameList[i].BrandName);
                listViewBrand.Items.Add(add);
            }
        }

        void Clean()
        {
            txtId.Text = "";
            txtBrandName.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var tbl = new Brand();
            tbl.BrandName = txtBrandName.Text;
            db.Brands.Add(tbl);
            db.SaveChanges();
            MessageBox.Show("Araç markası eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BrandList();
            Clean();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ListViewItem selectId = listViewBrand.SelectedItems[0];
            int id = int.Parse(selectId.SubItems[0].Text);
            var delete = db.Brands.FirstOrDefault(x => x.Id == id);
            db.Brands.Remove(delete);
            db.SaveChanges();
            MessageBox.Show("Araç markası silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BrandList();
            Clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var update = db.Brands.FirstOrDefault(x => x.Id == id);
            update.BrandName = txtBrandName.Text;
            db.SaveChanges();
            MessageBox.Show("Araç markası güncellendi", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BrandList();
            Clean();
        }

        private void FrmBrand_Load(object sender, EventArgs e)
        {
            BrandList();
        }

        private void listViewBrand_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem select = listViewBrand.SelectedItems[0];
            if (listViewBrand.SelectedItems.Count > 0)
            {
                txtId.Text = select.SubItems[0].Text;
                txtBrandName.Text = select.SubItems[1].Text;
            }
        }
    }
}
