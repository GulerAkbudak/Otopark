namespace Otopark.Forms
{
    partial class FrmCustomerList
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
            this.btnNewAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridCustomerList = new System.Windows.Forms.DataGridView();
            this.btnEntryParkSpace = new System.Windows.Forms.Button();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plaka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewAdd
            // 
            this.btnNewAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNewAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewAdd.ForeColor = System.Drawing.Color.Black;
            this.btnNewAdd.Location = new System.Drawing.Point(771, 100);
            this.btnNewAdd.Name = "btnNewAdd";
            this.btnNewAdd.Size = new System.Drawing.Size(117, 34);
            this.btnNewAdd.TabIndex = 42;
            this.btnNewAdd.Text = "Yeni Ekle";
            this.btnNewAdd.UseVisualStyleBackColor = false;
            this.btnNewAdd.Click += new System.EventHandler(this.btnNewAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(482, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Ara (Plaka Giriniz...)";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(587, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(173, 20);
            this.txtSearch.TabIndex = 40;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(771, 141);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 34);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(771, 223);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 34);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridCustomerList
            // 
            this.dataGridCustomerList.AllowUserToAddRows = false;
            this.dataGridCustomerList.AllowUserToDeleteRows = false;
            this.dataGridCustomerList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.Plaka,
            this.NameSurname,
            this.Telephone,
            this.Year,
            this.Color,
            this.EntryDate,
            this.Comment,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridCustomerList.Location = new System.Drawing.Point(12, 60);
            this.dataGridCustomerList.MultiSelect = false;
            this.dataGridCustomerList.Name = "dataGridCustomerList";
            this.dataGridCustomerList.ReadOnly = true;
            this.dataGridCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCustomerList.Size = new System.Drawing.Size(748, 265);
            this.dataGridCustomerList.TabIndex = 37;
            this.dataGridCustomerList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCustomerList_CellMouseClick);
            this.dataGridCustomerList.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridCustomerList_DataBindingComplete);
            // 
            // btnEntryParkSpace
            // 
            this.btnEntryParkSpace.BackColor = System.Drawing.SystemColors.Control;
            this.btnEntryParkSpace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntryParkSpace.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEntryParkSpace.ForeColor = System.Drawing.Color.Black;
            this.btnEntryParkSpace.Location = new System.Drawing.Point(771, 182);
            this.btnEntryParkSpace.Name = "btnEntryParkSpace";
            this.btnEntryParkSpace.Size = new System.Drawing.Size(117, 34);
            this.btnEntryParkSpace.TabIndex = 43;
            this.btnEntryParkSpace.Text = "Park Giriş";
            this.btnEntryParkSpace.UseVisualStyleBackColor = false;
            this.btnEntryParkSpace.Click += new System.EventHandler(this.btnEntryParkSpace_Click);
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "Id";
            this.CustomerId.HeaderText = "Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // Plaka
            // 
            this.Plaka.DataPropertyName = "Plaque";
            this.Plaka.HeaderText = "Plaka";
            this.Plaka.Name = "Plaka";
            this.Plaka.ReadOnly = true;
            // 
            // NameSurname
            // 
            this.NameSurname.DataPropertyName = "NameSurname";
            this.NameSurname.HeaderText = "Adı Soyadı";
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "Telefon";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.DataPropertyName = "Year";
            this.Year.HeaderText = "Yıl";
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Renk";
            this.Color.Name = "Color";
            this.Color.ReadOnly = true;
            // 
            // EntryDate
            // 
            this.EntryDate.DataPropertyName = "EntryDate";
            this.EntryDate.HeaderText = "Giriş Tarihi";
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.DataPropertyName = "Comment";
            this.Comment.HeaderText = "Açıklama";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SerieName";
            this.Column2.HeaderText = "Seri";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "BrandName";
            this.Column3.HeaderText = "Marka";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ParkingSpaces";
            this.Column4.HeaderText = "Park Yeri";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Location = new System.Drawing.Point(771, 60);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 34);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.Text = "Listeyi Yenile";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 405);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEntryParkSpace);
            this.Controls.Add(this.btnNewAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridCustomerList);
            this.Name = "FrmCustomerList";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.FrmCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridCustomerList;
        private System.Windows.Forms.Button btnEntryParkSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plaka;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnRefresh;
    }
}