using Otopark.Data.Entities;
using Otopark.Data.Models;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Otopark.Forms
{
    public partial class FrmCarParkSpaces : Form
    {
        public FrmCarParkSpaces()
        {
            InitializeComponent();
        }

        CarParkDbContext db = new CarParkDbContext();

        private void PanelParkingSpace()
        {
            int x = 1, y = 1, z = 11;

            foreach (Control item in panel1.Controls)
            {
                if (item is Label)
                {
                    item.Text = "A - " + x;
                    item.Name = x.ToString();
                    x++;
                }
            }

            foreach (Control item in panel2.Controls)
            {
                if (item is Label)
                {
                    item.Text = "B - " + y;
                    item.Name = z.ToString();
                    y++;
                    z++;
                }
            }
        }

        private void DbParkingSpace()
        {
            var parkSpaces = db.CarParkingSpaces.Select(x => new
            {
                x.Status,
                x.Id,
                x.ParkingSpaces
            }).ToList();

            foreach (var item in parkSpaces)
            {

                foreach (Control color in panel1.Controls)
                {
                    if (item.Status == false && item.ParkingSpaces == color.Text)
                    {
                        color.BackColor = Color.Green;
                    }
                    else if (item.Status == true && item.ParkingSpaces == color.Text)
                    {
                        color.BackColor = Color.Red;
                    }
                }

                foreach (Control color in panel2.Controls)
                {
                    if (item.Status == false && item.ParkingSpaces == color.Text)
                    {
                        color.BackColor = Color.Green;
                    }
                    else if (item.Status == true && item.ParkingSpaces == color.Text)
                    {
                        color.BackColor = Color.Red;
                    }
                }

            }
        }


        private void FrmCarParkSpaces_Load(object sender, EventArgs e)
        {
            PanelParkingSpace();
            DbParkingSpace();

            var showPlaque = db.Customers.Select(x => new
            {
                x.Plaque,
                x.CarParkingSpaceId
            }).ToList();

            foreach (var item in showPlaque)
            {
                foreach (Control lbl in panel1.Controls)
                {
                    if (lbl.Name == item.CarParkingSpaceId.ToString() && lbl.BackColor == Color.Red)
                    {
                        lbl.Text = item.Plaque;
                    }
                }
                foreach (Control lbl in panel2.Controls)
                {
                    if (lbl.Name == item.CarParkingSpaceId.ToString() && lbl.BackColor == Color.Red)
                    {
                        lbl.Text = item.Plaque;
                    }
                }
            }
        }
    }
}
