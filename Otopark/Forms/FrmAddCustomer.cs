using Otopark.Data.Entities;
using Otopark.Data.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Otopark.Forms
{
    public partial class FrmAddCustomer : Form
    {
        int id = 0;
        public FrmAddCustomer(int id = 0)
        {
            InitializeComponent();
            this.id = id;
        }

        CarParkDbContext db = new CarParkDbContext();

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            var bringBrand = db.Brands.ToList();
            cmbBrand.DataSource = bringBrand;
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "Id";


            if (id != 0)
            {
                var customer = db.Customers.FirstOrDefault(x => x.Id == id);
                if (customer != null)
                {
                    txtPlaque.Text = customer.Plaque;
                    txtNameSurname.Text = customer.NameSurname;
                    txtTelephone.Text = customer.Telephone;
                    txtYear.Text = customer.Year;
                    txtColor.Text = customer.Color;
                    txtComment.Text = customer.Comment;
                    cmbBrand.SelectedValue = customer.BrandId;
                    SeriLoad((int)cmbBrand.SelectedValue);
                    cmbSerie.SelectedValue = customer.SerieId;

                    btnSave.Text = "Güncelle";
                    this.Text = "Müşteri Güncelle";
                }
            }
            else
            {
                btnSave.Text = "Yeni Ekle";
                this.Text = "Yeni Müşteri Ekle";
            }
        }

        void Clean()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbBrand.SelectedValue != null)
                {
                    SeriLoad((int)cmbBrand.SelectedValue);
                }
            }
            catch (Exception)
            {

            }
        }

        private void SeriLoad(int brandId)
        {
            var bringSerie = db.Series.Where(x => x.BrandId == brandId).ToList();
            cmbSerie.DataSource = bringSerie;
            cmbSerie.DisplayMember = "SerieName";
            cmbSerie.ValueMember = "Id";
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                var isExist = db.Customers
                    .Any(x => x.Plaque.ToUpper() == txtPlaque.Text.ToUpper() && !x.Deleted);

                if (isExist)
                {
                    MessageBox.Show("Plaka ile daha önce kayıt mevcuttur", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var add = new Customer();
                    add.Plaque = txtPlaque.Text;
                    add.NameSurname = txtNameSurname.Text;
                    add.Telephone = txtTelephone.Text;
                    add.BrandId = (int)cmbBrand.SelectedValue;
                    add.SerieId = (int)cmbSerie.SelectedValue;
                    add.Year = txtYear.Text;
                    add.Color = txtColor.Text;
                    add.Comment = txtComment.Text;
                    db.Customers.Add(add);

                    db.SaveChanges();

                    MessageBox.Show("Ekleme işlemi başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClean.PerformClick();
                }
            }
            else
            {
                var customer = db.Customers
                    .FirstOrDefault(x => x.Id == id);

                if (customer != null)
                {                  
                    customer.Plaque = txtPlaque.Text;
                    customer.NameSurname = txtNameSurname.Text;
                    customer.Telephone = txtTelephone.Text;
                    customer.BrandId = (int)cmbBrand.SelectedValue;
                    customer.SerieId = (int)cmbSerie.SelectedValue;
                    customer.Year = txtYear.Text;
                    customer.Color = txtColor.Text;
                    customer.Comment = txtComment.Text;

                    db.SaveChanges();

                    MessageBox.Show("Güncelleme işlemi başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Müşteri bulunamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            FrmCustomerList.frmCustomerList.GridFill();
            this.Close();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }
    }
}
