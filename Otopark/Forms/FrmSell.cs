using Otopark.Data.Entities;
using Otopark.Data.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Otopark.Forms
{
    public partial class FrmSell : Form
    {
        public FrmSell()
        {
            InitializeComponent();
        }

        CarParkDbContext db = new CarParkDbContext();
        Tariff tariff = new Tariff();
        double hour = 0;

        private void FrmSell_Load(object sender, EventArgs e)
        {
            PlaqueLoad();
        }

        private void PlaqueLoad()
        {
            var bringPlaque = db.Customers
               .Where(x => x.CarParkingSpaceId != null).ToList();

            if (bringPlaque.Any())
            {
                cmbPlaque.DataSource = bringPlaque;
            }
            else
            {
                CleanForm();
            }
        }

        private void cmbPlaque_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var customer = db.Customers
                    .Include(x => x.Brand)
                    .Include(x => x.Serie)
                    .Include(x => x.CarParkingSpaces)
                    .FirstOrDefault(x => x.Plaque == cmbPlaque.Text);

                if (customer != null)
                {
                    txtNameSurname.Text = customer.NameSurname;
                    txtTelephone.Text = customer.Telephone;
                    txtBrand.Text = customer.Brand.BrandName;
                    txtSerie.Text = customer.Serie.SerieName;
                    txtColor.Text = customer.Color;
                    txtYear.Text = customer.Year;
                    txtParkSpace.Text = customer.CarParkingSpaces == null ? "" : customer.CarParkingSpaces.ParkingSpaces;

                    lblEntryDate.Text = customer.EntryDate.HasValue ? customer.EntryDate.Value.ToString("dd.MM.yyyy HH:mm") : "";

                    lblExitDate.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                    var minute = (DateTime.Now - customer.EntryDate.Value).TotalMinutes;

                    hour = minute / 60;

                    tariff = db.Tariffs
                        .FirstOrDefault(x => x.StartHour < hour && x.EndHour >= hour);

                    if (tariff != null)
                    {
                        lblPrice.Text = tariff.Amount.ToString();

                        int intHour = (int)((minute + 1) / 60);
                        int remainMinute = (int)(minute - intHour * 60);
                        lblHour.Text = intHour > 0 ? (intHour.ToString() + " saat " + remainMinute.ToString() + " dakika") : (remainMinute.ToString() + " dakika");
                    }

                    if (string.IsNullOrEmpty(cmbPlaque.SelectedValue.ToString()))
                    {
                        CleanForm();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void CleanForm()
        {
            txtNameSurname.Text = "";
            txtTelephone.Text = "";
            txtParkSpace.Text = "";
            txtBrand.Text = "";
            txtSerie.Text = "";
            txtColor.Text = "";
            txtYear.Text = "";
            lblEntryDate.Text = "-";
            lblExitDate.Text = "-";
            lblHour.Text = "-";
            lblPrice.Text = "-";
            cmbPlaque.DataSource = null;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var customer = db.Customers
                .Include(x => x.CarParkingSpaces)
                .FirstOrDefault(x => x.Plaque == cmbPlaque.Text);

            if (customer != null)
            {
                if (tariff != null)
                {
                    var sell = new Sell
                    {
                        Amount = tariff.Amount,
                        CarParkingSpaceId = customer.CarParkingSpaceId.Value,
                        CustomerId = customer.Id,
                        EntryDate = customer.EntryDate.Value,
                        ExitDate = DateTime.Now,
                        Time = (decimal)hour
                    };
                    db.Sells.Add(sell);
                }

                customer.CarParkingSpaceId = null;
                customer.EntryDate = null;
                customer.CarParkingSpaces.Status = false;
                db.SaveChanges();

                PlaqueLoad();

                MessageBox.Show("Ödeme işlemi başarılı", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
