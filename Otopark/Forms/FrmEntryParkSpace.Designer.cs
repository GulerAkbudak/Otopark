namespace Otopark.Forms
{
    partial class FrmEntryParkSpace
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
            this.label8 = new System.Windows.Forms.Label();
            this.cmbParkSpace = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPlaque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(25, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "Park Yeri";
            // 
            // cmbParkSpace
            // 
            this.cmbParkSpace.BackColor = System.Drawing.SystemColors.Window;
            this.cmbParkSpace.DisplayMember = "ParkingSpaces";
            this.cmbParkSpace.FormattingEnabled = true;
            this.cmbParkSpace.Location = new System.Drawing.Point(96, 322);
            this.cmbParkSpace.Name = "cmbParkSpace";
            this.cmbParkSpace.Size = new System.Drawing.Size(215, 21);
            this.cmbParkSpace.TabIndex = 50;
            this.cmbParkSpace.ValueMember = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(46, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 57;
            this.label9.Text = "Plaka";
            // 
            // txtPlaque
            // 
            this.txtPlaque.Location = new System.Drawing.Point(96, 91);
            this.txtPlaque.Name = "txtPlaque";
            this.txtPlaque.ReadOnly = true;
            this.txtPlaque.Size = new System.Drawing.Size(215, 20);
            this.txtPlaque.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "Adı Soyadı";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(96, 58);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.ReadOnly = true;
            this.txtTelephone.Size = new System.Drawing.Size(215, 20);
            this.txtTelephone.TabIndex = 53;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(96, 25);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.ReadOnly = true;
            this.txtNameSurname.Size = new System.Drawing.Size(215, 20);
            this.txtNameSurname.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(23, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 63;
            this.label10.Text = "Açıklama";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(96, 254);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ReadOnly = true;
            this.txtComment.Size = new System.Drawing.Size(215, 51);
            this.txtComment.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 61;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(66, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "Yıl";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(96, 224);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(215, 20);
            this.txtColor.TabIndex = 59;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(96, 190);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(215, 20);
            this.txtYear.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "Seri";
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(96, 159);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.ReadOnly = true;
            this.txtSerie.Size = new System.Drawing.Size(215, 20);
            this.txtSerie.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(46, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "Marka";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(96, 123);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.ReadOnly = true;
            this.txtBrandName.Size = new System.Drawing.Size(215, 20);
            this.txtBrandName.TabIndex = 66;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(96, 363);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(215, 31);
            this.btnProcess.TabIndex = 68;
            this.btnProcess.Text = "button1";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // FrmEntryParkSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 434);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPlaque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbParkSpace);
            this.Name = "FrmEntryParkSpace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEntryParkSpace";
            this.Load += new System.EventHandler(this.FrmEntryParkSpace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbParkSpace;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPlaque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Button btnProcess;
    }
}