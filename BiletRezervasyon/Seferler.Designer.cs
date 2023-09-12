namespace BiletRezervasyon
{
    partial class Seferler
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
            this.components = new System.ComponentModel.Container();
            this.Panel = new System.Windows.Forms.Panel();
            this.CbOtobusSec = new System.Windows.Forms.ComboBox();
            this.CbNereden = new System.Windows.Forms.ComboBox();
            this.CbNereye = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvListele = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListele)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Location = new System.Drawing.Point(16, 15);
            this.Panel.Margin = new System.Windows.Forms.Padding(4);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(269, 718);
            this.Panel.TabIndex = 0;
            // 
            // CbOtobusSec
            // 
            this.CbOtobusSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOtobusSec.Items.AddRange(new object[] {
            "Metro",
            "KamilKoç",
            "Truva"});
            this.CbOtobusSec.Location = new System.Drawing.Point(135, 38);
            this.CbOtobusSec.Margin = new System.Windows.Forms.Padding(4);
            this.CbOtobusSec.Name = "CbOtobusSec";
            this.CbOtobusSec.Size = new System.Drawing.Size(160, 24);
            this.CbOtobusSec.TabIndex = 1;
            this.CbOtobusSec.SelectedIndexChanged += new System.EventHandler(this.CbOtobusSec_SelectedIndexChanged);
            // 
            // CbNereden
            // 
            this.CbNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbNereden.FormattingEnabled = true;
            this.CbNereden.Items.AddRange(new object[] {
            "Ankara",
            "Adana",
            "Bursa",
            "Bolu",
            "İstanbul",
            "İzmir"});
            this.CbNereden.Location = new System.Drawing.Point(135, 89);
            this.CbNereden.Margin = new System.Windows.Forms.Padding(4);
            this.CbNereden.Name = "CbNereden";
            this.CbNereden.Size = new System.Drawing.Size(160, 24);
            this.CbNereden.TabIndex = 2;
            // 
            // CbNereye
            // 
            this.CbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbNereye.FormattingEnabled = true;
            this.CbNereye.Items.AddRange(new object[] {
            "Ankara",
            "Adana",
            "Bursa",
            "Bolu",
            "İstanbul",
            "İzmir"});
            this.CbNereye.Location = new System.Drawing.Point(135, 142);
            this.CbNereye.Margin = new System.Windows.Forms.Padding(4);
            this.CbNereye.Name = "CbNereye";
            this.CbNereye.Size = new System.Drawing.Size(160, 24);
            this.CbNereye.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGuncelle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtFiyat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.DtpTarih);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CbOtobusSec);
            this.groupBox1.Controls.Add(this.CbNereye);
            this.groupBox1.Controls.Add(this.CbNereden);
            this.groupBox1.Location = new System.Drawing.Point(311, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(319, 718);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilet Rezervasyon İşlemleri";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(11, 317);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(284, 77);
            this.BtnGuncelle.TabIndex = 12;
            this.BtnGuncelle.Text = "Guncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fiyat";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(135, 249);
            this.TxtFiyat.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(160, 22);
            this.TxtFiyat.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tarih";
            // 
            // DtpTarih
            // 
            this.DtpTarih.Location = new System.Drawing.Point(135, 193);
            this.DtpTarih.Margin = new System.Windows.Forms.Padding(4);
            this.DtpTarih.Name = "DtpTarih";
            this.DtpTarih.Size = new System.Drawing.Size(160, 22);
            this.DtpTarih.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nereye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nereden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Otobüs Seçiniz";
            // 
            // DgvListele
            // 
            this.DgvListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListele.Location = new System.Drawing.Point(654, 15);
            this.DgvListele.Margin = new System.Windows.Forms.Padding(4);
            this.DgvListele.Name = "DgvListele";
            this.DgvListele.Size = new System.Drawing.Size(1051, 718);
            this.DgvListele.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kaydetToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 26);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // Seferler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 746);
            this.Controls.Add(this.DgvListele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Seferler";
            this.Text = "Seferler";
            this.Load += new System.EventHandler(this.Seferler_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListele)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.ComboBox CbOtobusSec;
        private System.Windows.Forms.ComboBox CbNereden;
        private System.Windows.Forms.ComboBox CbNereye;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtpTarih;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgvListele;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
    }
}