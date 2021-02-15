
using Otopark.Data.Entities;
using Otopark.Service;
using System;
using System.Windows.Forms;

namespace Otopark.Forms
{
    public partial class FrmAddTariff : Form
    {
        private readonly ITariffService tariffService;
        private int? id;

        public FrmAddTariff(ITariffService tariffService, int? id = null)
        {
            InitializeComponent();
            this.tariffService = tariffService;
            this.id = id;
        }

        private void FrmAddTariff_Load(object sender, EventArgs e)
        {
            if (id == null)
            {
                this.Text = "Yeni Tarife Ekle";
                btnProcess.Text = "Kaydet";
            }
            else
            {
                this.Text = "Tarife Güncelle";
                btnProcess.Text = "Güncelle";

                var tariff = tariffService.GetById(id.Value);
                if (tariff != null)
                {
                    txtAmount.Value = tariff.Amount;
                    txtEndHour.Value = tariff.EndHour;
                    txtStartHour.Value = tariff.StartHour;
                }

            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {

            if (txtEndHour.Value < txtStartHour.Value)
            {
                MessageBox.Show("Başlangıç saati bitiş saatinden küçük olmalıdır.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var tariff = new Tariff
                {
                    Amount = txtAmount.Value,
                    EndHour = (int)txtEndHour.Value,
                    StartHour = (int)txtStartHour.Value
                };

                if (id == null)
                {
                    var result = tariffService.Post(tariff);
                    if (result.IsSuccess)
                    {
                        MessageBox.Show("Ekleme işlemi başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    tariff.Id = (int)id;
                    var result = tariffService.Put(tariff);
                    if (result.IsSuccess)
                    {
                        MessageBox.Show("Güncelleme işlemi başarılı", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.Close();
                FrmTariff.frmTariff.TariffLoad();
            }

        }
    }
}
