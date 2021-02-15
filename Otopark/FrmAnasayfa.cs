using Otopark.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark
{
    public partial class FrmAnasayfa : Form
    {

        Form form = new Form();

        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        private void ToolCustomerList_Click(object sender, EventArgs e)
        {
            FrmCustomerList customerList = new FrmCustomerList();
            GetForm(customerList);
        }

        private void ToolCustomerAdd_Click(object sender, EventArgs e)
        {
            FrmAddCustomer addCustomer = new FrmAddCustomer();
            GetForm(addCustomer);
        }

        private void ToolStripMenuItemCarParkingSpaces_Click(object sender, EventArgs e)
        {
            FrmCarParkSpaces carParkSpaces = new FrmCarParkSpaces();
            GetForm(carParkSpaces);
        }

        private void ToolStripMenuItemSell_Click(object sender, EventArgs e)
        {
            FrmSell sell = new FrmSell();
            GetForm(sell);
        }

        private void ToolBrand_Click(object sender, EventArgs e)
        {
            FrmBrand brand = new FrmBrand();
            GetForm(brand);
        }

        private void ToolSerie_Click(object sender, EventArgs e)
        {
            FrmSerie serie = new FrmSerie();
            GetForm(serie);
        }

        private void ToolTariff_Click(object sender, EventArgs e)
        {
            FrmTariff tariff = new FrmTariff();
            GetForm(tariff);
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void GetForm(Form frm)
        {
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ToolStripMenuItemClock.Text = DateTime.Now.ToString();
        }
    }
}
