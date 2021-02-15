namespace Otopark.Forms
{
    partial class FrmTariff
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
            this.dataGridTariff = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TariffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTariff)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTariff
            // 
            this.dataGridTariff.AllowUserToAddRows = false;
            this.dataGridTariff.AllowUserToDeleteRows = false;
            this.dataGridTariff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTariff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TariffId,
            this.StartHour,
            this.EndHour,
            this.Amount});
            this.dataGridTariff.Location = new System.Drawing.Point(12, 34);
            this.dataGridTariff.MultiSelect = false;
            this.dataGridTariff.Name = "dataGridTariff";
            this.dataGridTariff.ReadOnly = true;
            this.dataGridTariff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTariff.Size = new System.Drawing.Size(644, 298);
            this.dataGridTariff.TabIndex = 0;
            this.dataGridTariff.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridTariff_CellMouseClick);
            this.dataGridTariff.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridTariff_DataBindingComplete);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(672, 34);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(91, 28);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Yeni Ekle";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(672, 68);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(672, 102);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TariffId
            // 
            this.TariffId.DataPropertyName = "Id";
            this.TariffId.HeaderText = "Id";
            this.TariffId.Name = "TariffId";
            this.TariffId.ReadOnly = true;
            // 
            // StartHour
            // 
            this.StartHour.DataPropertyName = "StartHour";
            this.StartHour.HeaderText = "Başlangıç Saati";
            this.StartHour.Name = "StartHour";
            this.StartHour.ReadOnly = true;
            // 
            // EndHour
            // 
            this.EndHour.DataPropertyName = "EndHour";
            this.EndHour.HeaderText = "Bitiş Saati";
            this.EndHour.Name = "EndHour";
            this.EndHour.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Fiyat";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // FrmTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridTariff);
            this.Name = "FrmTariff";
            this.Text = "Tarifeler";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTariff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTariff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTariff;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn TariffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}