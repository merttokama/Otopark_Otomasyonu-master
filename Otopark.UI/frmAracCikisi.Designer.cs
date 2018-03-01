namespace Otopark.UI
{
    partial class frmAracCikisi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.cbAboneler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtToplamHesap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Otopark Araç Çıkışı Ekranı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(64, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kaldığı Saat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(57, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Plaka Seçiniz:";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Gainsboro;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Location = new System.Drawing.Point(145, 253);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 43);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Araç Çıkışı Yap";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSure
            // 
            this.txtSure.Enabled = false;
            this.txtSure.Location = new System.Drawing.Point(145, 157);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(133, 20);
            this.txtSure.TabIndex = 1;
            this.txtSure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSure_KeyPress);
            // 
            // cbAboneler
            // 
            this.cbAboneler.FormattingEnabled = true;
            this.cbAboneler.Location = new System.Drawing.Point(145, 127);
            this.cbAboneler.Name = "cbAboneler";
            this.cbAboneler.Size = new System.Drawing.Size(133, 21);
            this.cbAboneler.TabIndex = 0;
            this.cbAboneler.SelectedIndexChanged += new System.EventHandler(this.cbAboneler_SelectedIndexChanged);
            this.cbAboneler.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbAboneler_Format);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(14, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Saatlik Ücreti Giriniz:";
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(145, 186);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(133, 20);
            this.txtUcret.TabIndex = 2;
            this.txtUcret.TextChanged += new System.EventHandler(this.txtUcret_TextChanged);
            this.txtUcret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUcret_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Otopark.UI.Properties.Resources.arac;
            this.pictureBox1.Location = new System.Drawing.Point(145, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtToplamHesap
            // 
            this.txtToplamHesap.Enabled = false;
            this.txtToplamHesap.Location = new System.Drawing.Point(145, 214);
            this.txtToplamHesap.Name = "txtToplamHesap";
            this.txtToplamHesap.Size = new System.Drawing.Size(133, 20);
            this.txtToplamHesap.TabIndex = 3;
            this.txtToplamHesap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtToplamHesap_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(51, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Toplam Hesap:";
            // 
            // frmAracCikisi
            // 
            this.AcceptButton = this.btnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 317);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtToplamHesap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.cbAboneler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAracCikisi";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAracCikisi";
            this.Load += new System.EventHandler(this.frmAracCikisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.ComboBox cbAboneler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtToplamHesap;
        private System.Windows.Forms.Label label5;
    }
}