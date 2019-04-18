namespace Tek_Bilisim_Servis_Programı_v1._0._0
{
    partial class bilgi_ekrani_sozlesme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bilgi_ekrani_sozlesme));
            this.dtgBilgi = new System.Windows.Forms.DataGridView();
            this.btnAnasayfa = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBilgi
            // 
            this.dtgBilgi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgBilgi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBilgi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgBilgi.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtgBilgi.Location = new System.Drawing.Point(2, 52);
            this.dtgBilgi.Name = "dtgBilgi";
            this.dtgBilgi.Size = new System.Drawing.Size(1197, 37);
            this.dtgBilgi.TabIndex = 0;
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.btnAnasayfa.BackgroundImage = global::Tek_Bilisim_Servis_Programı_v1._0._0.Properties.Resources.anasayfa;
            this.btnAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnasayfa.Location = new System.Drawing.Point(2, 1);
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.Size = new System.Drawing.Size(50, 45);
            this.btnAnasayfa.TabIndex = 1;
            this.btnAnasayfa.UseVisualStyleBackColor = false;
            this.btnAnasayfa.Click += new System.EventHandler(this.btnAnasayfa_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(288, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(691, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // bilgi_ekrani_sozlesme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 99);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.dtgBilgi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bilgi_ekrani_sozlesme";
            this.Text = "SÖZLEŞME BİLGİ EKRANI";
            this.Load += new System.EventHandler(this.bilgi_ekrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBilgi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBilgi;
        private System.Windows.Forms.Button btnAnasayfa;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}