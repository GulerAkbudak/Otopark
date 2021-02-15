using Otopark.Data.Entities;
using Otopark.Data.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Otopark.Forms
{
    public partial class FrmEntryParkSpace : Form
    {
        CarParkDbContext db = new CarParkDbContext();

        private int id;

        public FrmEntryParkSpace(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void FrmEntryParkSpace_Load(object sender, EventArgs e)
        {
            ParkSpaceLoad();
            CustomerLoad();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var emptyParking = db.CarParkingSpaces
                       .FirstOrDefault(x => x.ParkingSpaces == cmbParkSpace.Text);

            emptyParking.Status = true;

            var customer = db.Customers
                .Include(x => x.CarParkingSpaces)
                .FirstOrDefault(x => x.Id == id);

            // mevcutta otoparkta başka bir yerde ise yeri değiştiriliyor
            if (customer.CarParkingSpaceId != null)
            {
                customer.CarParkingSpaces.Status = false;
            }

            if (customer != null)
            {
                customer.EntryDate = DateTime.Now;
                customer.CarParkingSpaceId = (int)cmbParkSpace.SelectedValue;
            }         

            db.SaveChanges();
            this.Close();
            FrmCustomerList.frmCustomerList.GridFill();
            MessageBox.Show("Park yeri kaydedildi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CustomerLoad()
        {
            var customer = db.Customers
                   .Include(x => x.Brand)
                   .Include(x => x.Serie)
                   .FirstOrDefault(x => x.Id == id);

            if (customer != null)
            {
                if (customer.CarParkingSpaceId != null)
                {
                    btnProcess.Text = "Park Yeri Güncelle";
                    this.Text = "Park Yeri Güncelle";
                }
                else
                {
                    btnProcess.Text = "Park Yeri Kaydet";
                    this.Text = "Park Yeri Kaydet";
                }

                txtPlaque.Text = customer.Plaque;
                txtNameSurname.Text = customer.NameSurname;
                txtTelephone.Text = customer.Telephone;
                txtBrandName.Text = customer.Brand.BrandName;
                txtSerie.Text = customer.Serie.SerieName;
                txtYear.Text = customer.Year;
                txtColor.Text = customer.Color;
                txtComment.Text = customer.Comment;
            }
        }
        private void ParkSpaceLoad()
        {
            var bringPark = db.CarParkingSpaces.Where(x => x.Status == false).ToList();
            cmbParkSpace.DataSource = bringPark;
        }

    }
}
