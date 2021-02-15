namespace Otopark.Forms
{
    partial class FrmSell
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
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.cmbPlaque = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.asddasdas = new System.Windows.Forms.Label();
            this.asdsa = new System.Windows.Forms.Label();
            this.asdasdas = new System.Windows.Forms.Label();
            this.sfsdf = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.lblExitDate = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtParkSpace = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(122, 62);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.ReadOnly = true;
            this.txtNameSurname.Size = new System.Drawing.Size(205, 20);
            this.txtNameSurname.TabIndex = 0;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(122, 94);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.ReadOnly = true;
            this.txtTelephone.Size = new System.Drawing.Size(205, 20);
            this.txtTelephone.TabIndex = 1;
            // 
            // cmbPlaque
            // 
            this.cmbPlaque.DisplayMember = "Plaque";
            this.cmbPlaque.FormattingEnabled = true;
            this.cmbPlaque.Location = new System.Drawing.Point(122, 29);
            this.cmbPlaque.Name = "cmbPlaque";
            this.cmbPlaque.Size = new System.Drawing.Size(205, 21);
            this.cmbPlaque.TabIndex = 2;
            this.cmbPlaque.ValueMember = "Id";
            this.cmbPlaque.SelectedIndexChanged += new System.EventHandler(this.cmbPlaque_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(62, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Park Yeri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Plaka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(55, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adı Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(69, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(378, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Seri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Marka";
            // 
            // asddasdas
            // 
            this.asddasdas.BackColor = System.Drawing.Color.White;
            this.asddasdas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.asddasdas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asddasdas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.asddasdas.Location = new System.Drawing.Point(18, 184);
            this.asddasdas.Name = "asddasdas";
            this.asddasdas.Size = new System.Drawing.Size(144, 39);
            this.asddasdas.TabIndex = 14;
            this.asddasdas.Text = "GİRİŞ TARİHİ";
            this.asddasdas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // asdsa
            // 
            this.asdsa.BackColor = System.Drawing.Color.White;
            this.asdsa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.asdsa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asdsa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.asdsa.Location = new System.Drawing.Point(181, 184);
            this.asdsa.Name = "asdsa";
            this.asdsa.Size = new System.Drawing.Size(144, 39);
            this.asdsa.TabIndex = 15;
            this.asdsa.Text = "ÇIKIŞ TARİHİ";
            this.asdsa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // asdasdas
            // 
            this.asdasdas.BackColor = System.Drawing.Color.White;
            this.asdasdas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.asdasdas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.asdasdas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.asdasdas.Location = new System.Drawing.Point(344, 184);
            this.asdasdas.Name = "asdasdas";
            this.asdasdas.Size = new System.Drawing.Size(144, 39);
            this.asdasdas.TabIndex = 16;
            this.asdasdas.Text = "SÜRE";
            this.asdasdas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sfsdf
            // 
            this.sfsdf.BackColor = System.Drawing.Color.White;
            this.sfsdf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sfsdf.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sfsdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sfsdf.Location = new System.Drawing.Point(507, 184);
            this.sfsdf.Name = "sfsdf";
            this.sfsdf.Size = new System.Drawing.Size(144, 39);
            this.sfsdf.TabIndex = 17;
            this.sfsdf.Text = "ÜCRET";
            this.sfsdf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.BackColor = System.Drawing.Color.White;
            this.lblEntryDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEntryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblEntryDate.Location = new System.Drawing.Point(18, 236);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(144, 31);
            this.lblEntryDate.TabIndex = 18;
            this.lblEntryDate.Text = "-";
            this.lblEntryDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExitDate
            // 
            this.lblExitDate.BackColor = System.Drawing.Color.White;
            this.lblExitDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblExitDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblExitDate.Location = new System.Drawing.Point(181, 236);
            this.lblExitDate.Name = "lblExitDate";
            this.lblExitDate.Size = new System.Drawing.Size(143, 31);
            this.lblExitDate.TabIndex = 19;
            this.lblExitDate.Text = "-";
            this.lblExitDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHour
            // 
            this.lblHour.BackColor = System.Drawing.Color.White;
            this.lblHour.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHour.Location = new System.Drawing.Point(344, 235);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(144, 31);
            this.lblHour.TabIndex = 20;
            this.lblHour.Text = "-";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPrice.Location = new System.Drawing.Point(507, 235);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(144, 31);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "-";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(513, 295);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(138, 50);
            this.btnPay.TabIndex = 23;
            this.btnPay.Text = "ÖDEME YAP";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(409, 61);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(205, 20);
            this.txtSerie.TabIndex = 25;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(409, 29);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.ReadOnly = true;
            this.txtBrand.Size = new System.Drawing.Size(205, 20);
            this.txtBrand.TabIndex = 26;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(409, 125);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(205, 20);
            this.txtYear.TabIndex = 28;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(409, 93);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(205, 20);
            this.txtColor.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(385, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Yıl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(370, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Renk";
            // 
            // txtParkSpace
            // 
            this.txtParkSpace.Location = new System.Drawing.Point(122, 125);
            this.txtParkSpace.Name = "txtParkSpace";
            this.txtParkSpace.ReadOnly = true;
            this.txtParkSpace.Size = new System.Drawing.Size(205, 20);
            this.txtParkSpace.TabIndex = 32;
            // 
            // FrmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 445);
            this.Controls.Add(this.txtParkSpace);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblExitDate);
            this.Controls.Add(this.lblEntryDate);
            this.Controls.Add(this.sfsdf);
            this.Controls.Add(this.asdasdas);
            this.Controls.Add(this.asdsa);
            this.Controls.Add(this.asddasdas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPlaque);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtNameSurname);
            this.Name = "FrmSell";
            this.Text = "Ödeme Sayfası";
            this.Load += new System.EventHandler(this.FrmSell_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.ComboBox cmbPlaque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label asddasdas;
        private System.Windows.Forms.Label asdsa;
        private System.Windows.Forms.Label asdasdas;
        private System.Windows.Forms.Label sfsdf;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Label lblExitDate;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtParkSpace;
    }
}