using Otopark.Data.Entities;
using Otopark.Data.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Otopark.Forms
{
    public partial class FrmCustomerList : Form
    {
        public static FrmCustomerList frmCustomerList;
        int id = 0;

        public FrmCustomerList()
        {
            InitializeComponent();
            frmCustomerList = this;
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

        public void GridFill()
        {
            using (CarParkDbContext db = new CarParkDbContext())
            {
                dataGridCustomerList.DataSource = db.Customers
                    .Include(x => x.Brand)
                    .Include(x => x.Serie)
                    .Include(x => x.CarParkingSpaces)
                    .Where(x => !x.Deleted)
                    .Select(x => new
                    {
                        x.Id,
                        x.NameSurname,
                        x.Plaque,
                        SerieName = x.Serie.SerieName,
                        BrandName = x.Brand.BrandName,
                        ParkingSpaces = x.CarParkingSpaces.ParkingSpaces,
                        x.Color,
                        x.Comment,
                        x.EntryDate,
                        x.Telephone,
                        x.Year
                    }).ToList();
            }
        }

        private void FrmCustomerList_Load(object sender, EventArgs e)
        {
            GridFill();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnEntryParkSpace.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frmAddCustomer = new FrmAddCustomer(id);
            frmAddCustomer.ShowDialog(this);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silmek istiyor musunuz?", "Silme Onayı", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (CarParkDbContext db = new CarParkDbContext())
                {
                    int id = int.Parse(dataGridCustomerList.CurrentRow.Cells[0].Value.ToString());

                    var customer = db.Customers
                        .Include(x => x.CarParkingSpaces)
                        .FirstOrDefault(x => x.Id == id);

                    if (customer != null)
                    {
                        customer.Deleted = true;
                        customer.CarParkingSpaces.Status = false;

                        db.SaveChanges();
                        MessageBox.Show("Kayıt silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clean();
                        GridFill();
                    }
                    else
                    {
                        MessageBox.Show("Müşteri bulunamadı", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridCustomerList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridCustomerList.Rows[e.RowIndex];
                id = Int32.Parse(row.Cells["CustomerId"].Value.ToString());
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                btnEntryParkSpace.Visible = true;
            }
        }

        private void dataGridCustomerList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridCustomerList.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (CarParkDbContext db = new CarParkDbContext())
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    dataGridCustomerList.DataSource = db.Customers.Where(x => x.Plaque.Contains(txtSearch.Text)).ToList();
                }
                else
                {
                    GridFill();
                }
            }
        }

        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            FrmAddCustomer frmAddCustomer = new FrmAddCustomer();
            frmAddCustomer.ShowDialog(this);
        }

        private void btnEntryParkSpace_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                FrmEntryParkSpace frm = new FrmEntryParkSpace(id);
                frm.ShowDialog(this);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GridFill();
        }
    }
}
