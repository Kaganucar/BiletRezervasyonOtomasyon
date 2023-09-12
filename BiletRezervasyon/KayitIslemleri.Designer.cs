namespace BiletRezervasyon
{
    partial class KayitIslemleri
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnIptal = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.MtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtIsimSoyisim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbCinsiyet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BtnIptal);
            this.groupBox1.Controls.Add(this.BtnKaydet);
            this.groupBox1.Controls.Add(this.MtbTelefon);
            this.groupBox1.Controls.Add(this.TxtIsimSoyisim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(345, 387);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıt İşlemleri";
            // 
            // CbCinsiyet
            // 
            this.CbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCinsiyet.FormattingEnabled = true;
            this.CbCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.CbCinsiyet.Location = new System.Drawing.Point(128, 161);
            this.CbCinsiyet.Name = "CbCinsiyet";
            this.CbCinsiyet.Size = new System.Drawing.Size(185, 24);
            this.CbCinsiyet.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cinsiyet :";
            // 
            // BtnIptal
            // 
            this.BtnIptal.Location = new System.Drawing.Point(22, 284);
            this.BtnIptal.Margin = new System.Windows.Forms.Padding(4);
            this.BtnIptal.Name = "BtnIptal";
            this.BtnIptal.Size = new System.Drawing.Size(291, 46);
            this.BtnIptal.TabIndex = 9;
            this.BtnIptal.Text = "İptal";
            this.BtnIptal.UseVisualStyleBackColor = true;
            this.BtnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(22, 217);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(291, 46);
            this.BtnKaydet.TabIndex = 8;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // MtbTelefon
            // 
            this.MtbTelefon.Location = new System.Drawing.Point(128, 101);
            this.MtbTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.MtbTelefon.Mask = "(999) 000-0000";
            this.MtbTelefon.Name = "MtbTelefon";
            this.MtbTelefon.Size = new System.Drawing.Size(185, 22);
            this.MtbTelefon.TabIndex = 5;
            // 
            // TxtIsimSoyisim
            // 
            this.TxtIsimSoyisim.Location = new System.Drawing.Point(128, 49);
            this.TxtIsimSoyisim.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIsimSoyisim.Name = "TxtIsimSoyisim";
            this.TxtIsimSoyisim.Size = new System.Drawing.Size(185, 22);
            this.TxtIsimSoyisim.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim Soyisim :";
            // 
            // KayitIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 429);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KayitIslemleri";
            this.Text = "KayitIslemleri";
            this.Load += new System.EventHandler(this.KayitIslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnIptal;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox MtbTelefon;
        public System.Windows.Forms.TextBox TxtIsimSoyisim;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox CbCinsiyet;
    }
}