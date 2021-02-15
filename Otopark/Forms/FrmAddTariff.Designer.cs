namespace Otopark.Forms
{
    partial class FrmAddTariff
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartHour = new System.Windows.Forms.NumericUpDown();
            this.txtEndHour = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Başlangıç Saati";
            // 
            // txtStartHour
            // 
            this.txtStartHour.Location = new System.Drawing.Point(131, 35);
            this.txtStartHour.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtStartHour.Name = "txtStartHour";
            this.txtStartHour.Size = new System.Drawing.Size(215, 20);
            this.txtStartHour.TabIndex = 39;
            // 
            // txtEndHour
            // 
            this.txtEndHour.Location = new System.Drawing.Point(131, 71);
            this.txtEndHour.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtEndHour.Name = "txtEndHour";
            this.txtEndHour.Size = new System.Drawing.Size(215, 20);
            this.txtEndHour.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Bitiş Saati";
            // 
            // txtAmount
            // 
            this.txtAmount.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtAmount.Location = new System.Drawing.Point(131, 107);
            this.txtAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(215, 20);
            this.txtAmount.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 42;
            this.label3.Text = "Fiyatı";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(263, 148);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(83, 27);
            this.btnProcess.TabIndex = 44;
            this.btnProcess.Text = "button1";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // FrmAddTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 187);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStartHour);
            this.Controls.Add(this.label2);
            this.Name = "FrmAddTariff";
            this.Text = "FrmAddTariff";
            this.Load += new System.EventHandler(this.FrmAddTariff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtStartHour;
        private System.Windows.Forms.NumericUpDown txtEndHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProcess;
    }
}