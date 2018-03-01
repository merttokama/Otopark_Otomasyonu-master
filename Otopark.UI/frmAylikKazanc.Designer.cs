namespace Otopark.UI
{
    partial class frmAylikKazanc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAylikKazanc));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeRaporTarih = new System.Windows.Forms.DateTimePicker();
            this.btnAylikKazanRapor = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "YIL ve Ay Seçiniz";
            // 
            // dateTimeRaporTarih
            // 
            this.dateTimeRaporTarih.CustomFormat = "";
            this.dateTimeRaporTarih.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dateTimeRaporTarih.Location = new System.Drawing.Point(10, 76);
            this.dateTimeRaporTarih.Name = "dateTimeRaporTarih";
            this.dateTimeRaporTarih.Size = new System.Drawing.Size(165, 23);
            this.dateTimeRaporTarih.TabIndex = 1;
            // 
            // btnAylikKazanRapor
            // 
            this.btnAylikKazanRapor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAylikKazanRapor.Location = new System.Drawing.Point(32, 117);
            this.btnAylikKazanRapor.Name = "btnAylikKazanRapor";
            this.btnAylikKazanRapor.Size = new System.Drawing.Size(120, 42);
            this.btnAylikKazanRapor.TabIndex = 2;
            this.btnAylikKazanRapor.Text = "Raporu Göster";
            this.btnAylikKazanRapor.UseVisualStyleBackColor = true;
            this.btnAylikKazanRapor.Click += new System.EventHandler(this.btnAylikKazanRapor_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmAylikKazanc
            // 
            this.AcceptButton = this.btnAylikKazanRapor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 201);
            this.Controls.Add(this.btnAylikKazanRapor);
            this.Controls.Add(this.dateTimeRaporTarih);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAylikKazanc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAylikKazanc";
            this.Load += new System.EventHandler(this.frmAylikKazanc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeRaporTarih;
        private System.Windows.Forms.Button btnAylikKazanRapor;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}