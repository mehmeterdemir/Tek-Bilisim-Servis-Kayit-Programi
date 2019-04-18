namespace Tek_Bilisim_Servis_Programı_v1._0._0
{
    partial class Musteri_Bilgi_Kaydi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteri_Bilgi_Kaydi));
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.txtBolge = new System.Windows.Forms.TextBox();
            this.txtMakModel = new System.Windows.Forms.TextBox();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSozBitis = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(133, 53);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(340, 21);
            this.cmbMusteri.TabIndex = 0;
            // 
            // txtBolge
            // 
            this.txtBolge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtBolge.Location = new System.Drawing.Point(133, 80);
            this.txtBolge.Multiline = true;
            this.txtBolge.Name = "txtBolge";
            this.txtBolge.Size = new System.Drawing.Size(340, 34);
            this.txtBolge.TabIndex = 1;
            // 
            // txtMakModel
            // 
            this.txtMakModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtMakModel.Location = new System.Drawing.Point(133, 120);
            this.txtMakModel.Multiline = true;
            this.txtMakModel.Name = "txtMakModel";
            this.txtMakModel.Size = new System.Drawing.Size(340, 34);
            this.txtMakModel.TabIndex = 2;
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtSeriNo.Location = new System.Drawing.Point(133, 160);
            this.txtSeriNo.Multiline = true;
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(340, 34);
            this.txtSeriNo.TabIndex = 3;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.dtpBaslangic.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpBaslangic.Location = new System.Drawing.Point(133, 234);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(340, 20);
            this.dtpBaslangic.TabIndex = 5;
            this.dtpBaslangic.Tag = "";
            this.dtpBaslangic.Value = new System.DateTime(2018, 11, 10, 0, 0, 0, 0);
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dtpBaslangic_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button1.Location = new System.Drawing.Point(133, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button2.Location = new System.Drawing.Point(331, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "İPTAL";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bölge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Makina Modeli";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seri No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Durumu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sözlşme Başlangıç";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sözlşme Başlangıç";
            // 
            // lblSozBitis
            // 
            this.lblSozBitis.AutoSize = true;
            this.lblSozBitis.Location = new System.Drawing.Point(130, 275);
            this.lblSozBitis.Name = "lblSozBitis";
            this.lblSozBitis.Size = new System.Drawing.Size(70, 13);
            this.lblSozBitis.TabIndex = 8;
            this.lblSozBitis.Text = "Sözlşme Bitişi";
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "1-Sözleşmeli",
            "2-Ücretli"});
            this.cmbDurum.Location = new System.Drawing.Point(133, 203);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(340, 21);
            this.cmbDurum.TabIndex = 4;
            // 
            // Musteri_Bilgi_Kaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 382);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.lblSozBitis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.txtMakModel);
            this.Controls.Add(this.txtBolge);
            this.Controls.Add(this.cmbMusteri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Musteri_Bilgi_Kaydi";
            this.Text = "MÜŞTERİ BİLGİLERİ KAYIT EKRANI";
            this.Load += new System.EventHandler(this.Musteri_Bilgi_Kaydi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.TextBox txtBolge;
        private System.Windows.Forms.TextBox txtMakModel;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSozBitis;
        protected System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
    }
}