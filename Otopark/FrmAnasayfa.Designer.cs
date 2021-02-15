namespace Otopark
{
    partial class FrmAnasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolCustomerList = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolCustomerAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCarParkingSpaces = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSell = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBrand = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolSerie = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClock = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ToolTariff = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemCustomer,
            this.ToolStripMenuItemCarParkingSpaces,
            this.ToolStripMenuItemSell,
            this.ToolStripMenuItemSetting,
            this.ToolStripMenuItemClock});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemCustomer
            // 
            this.ToolStripMenuItemCustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolCustomerList,
            this.ToolCustomerAdd});
            this.ToolStripMenuItemCustomer.Name = "ToolStripMenuItemCustomer";
            this.ToolStripMenuItemCustomer.Size = new System.Drawing.Size(72, 20);
            this.ToolStripMenuItemCustomer.Text = "Müşteriler";
            // 
            // ToolCustomerList
            // 
            this.ToolCustomerList.Name = "ToolCustomerList";
            this.ToolCustomerList.Size = new System.Drawing.Size(150, 22);
            this.ToolCustomerList.Text = "Müşteri Listele";
            this.ToolCustomerList.Click += new System.EventHandler(this.ToolCustomerList_Click);
            // 
            // ToolCustomerAdd
            // 
            this.ToolCustomerAdd.Name = "ToolCustomerAdd";
            this.ToolCustomerAdd.Size = new System.Drawing.Size(150, 22);
            this.ToolCustomerAdd.Text = "Müşteri Ekle";
            this.ToolCustomerAdd.Click += new System.EventHandler(this.ToolCustomerAdd_Click);
            // 
            // ToolStripMenuItemCarParkingSpaces
            // 
            this.ToolStripMenuItemCarParkingSpaces.Name = "ToolStripMenuItemCarParkingSpaces";
            this.ToolStripMenuItemCarParkingSpaces.Size = new System.Drawing.Size(97, 20);
            this.ToolStripMenuItemCarParkingSpaces.Text = "Otopark Yerleri";
            this.ToolStripMenuItemCarParkingSpaces.Click += new System.EventHandler(this.ToolStripMenuItemCarParkingSpaces_Click);
            // 
            // ToolStripMenuItemSell
            // 
            this.ToolStripMenuItemSell.Name = "ToolStripMenuItemSell";
            this.ToolStripMenuItemSell.Size = new System.Drawing.Size(43, 20);
            this.ToolStripMenuItemSell.Text = "Satış";
            this.ToolStripMenuItemSell.Click += new System.EventHandler(this.ToolStripMenuItemSell_Click);
            // 
            // ToolStripMenuItemSetting
            // 
            this.ToolStripMenuItemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBrand,
            this.ToolSerie,
            this.ToolTariff});
            this.ToolStripMenuItemSetting.Name = "ToolStripMenuItemSetting";
            this.ToolStripMenuItemSetting.Size = new System.Drawing.Size(56, 20);
            this.ToolStripMenuItemSetting.Text = "Ayarlar";
            // 
            // ToolBrand
            // 
            this.ToolBrand.Name = "ToolBrand";
            this.ToolBrand.Size = new System.Drawing.Size(180, 22);
            this.ToolBrand.Text = "Marka";
            this.ToolBrand.Click += new System.EventHandler(this.ToolBrand_Click);
            // 
            // ToolSerie
            // 
            this.ToolSerie.Name = "ToolSerie";
            this.ToolSerie.Size = new System.Drawing.Size(180, 22);
            this.ToolSerie.Text = "Seri";
            this.ToolSerie.Click += new System.EventHandler(this.ToolSerie_Click);
            // 
            // ToolStripMenuItemClock
            // 
            this.ToolStripMenuItemClock.Margin = new System.Windows.Forms.Padding(450, 0, 0, 0);
            this.ToolStripMenuItemClock.Name = "ToolStripMenuItemClock";
            this.ToolStripMenuItemClock.Padding = new System.Windows.Forms.Padding(2, 0, 4, 0);
            this.ToolStripMenuItemClock.Size = new System.Drawing.Size(39, 20);
            this.ToolStripMenuItemClock.Text = "Saat";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ToolTariff
            // 
            this.ToolTariff.Name = "ToolTariff";
            this.ToolTariff.Size = new System.Drawing.Size(180, 22);
            this.ToolTariff.Text = "Tarifeler";
            this.ToolTariff.Click += new System.EventHandler(this.ToolTariff_Click);
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otopark Otomasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCustomer;
        private System.Windows.Forms.ToolStripMenuItem ToolCustomerList;
        private System.Windows.Forms.ToolStripMenuItem ToolCustomerAdd;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCarParkingSpaces;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSell;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSetting;
        private System.Windows.Forms.ToolStripMenuItem ToolBrand;
        private System.Windows.Forms.ToolStripMenuItem ToolSerie;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ToolTariff;
    }
}

