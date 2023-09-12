using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletRezervasyon
{
    public partial class Seferler : Form
    {
        public Seferler()
        {
            InitializeComponent();
        }
        BiletSatisOtomasyonuEntities db = new BiletSatisOtomasyonuEntities();

        void Doldur()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("Firma");
            dt.Columns.Add("Müşteri");
            dt.Columns.Add("Telefon");
            dt.Columns.Add("Cinsiyet");
            dt.Columns.Add("Nereden");
            dt.Columns.Add("Nereye");
            dt.Columns.Add("Tarih");
            dt.Columns.Add("KoltukNo");
            dt.Columns.Add("Fiyat");
            


            foreach (var item in db.TblSeferler.ToList())
            {
                dt.Rows.Add(item.id,item.OtobusFirma,item.IsimSoyisim,item.TelefonNo,item.Cinsiyet,item.Nereden,item.Nereye,item.Tarih,item.KoltukNo,item.Fiyat);
            }
            DgvListele.DataSource = dt;
        }

        private void Seferler_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void CbOtobusSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CbOtobusSec.Text)
            {
                case "Metro": KoltukDoldur(8, false); break;

                case "KamilKoç": KoltukDoldur(10, true); break;

                case "Truva": KoltukDoldur(11, false); break;
            }

        void KoltukDoldur(int sira,bool arkaBesliMi)
            {
                yavaslat:
                foreach (Control ctrl in Panel.Controls)
                {
                    if (ctrl is Button)
                    {
                        Button btn = ctrl as Button;
                        if (btn.Text == "Kaydet")
                        {
                            continue;
                        }
                        else
                        {
                            Panel.Controls.Remove(ctrl);
                            goto yavaslat;
                        }
                    }
                }
                int koltukNo = 1;
                for (int i = 0; i < sira; i++)
                {
                    
                    for (int j = 0; j < 5; j++)
                    {
                        if (arkaBesliMi == true)
                        {
                            if (i !=sira-1 && j== 2)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            if (j == 2)
                            {
                                continue;
                            }
                        }
                        DateTime SecilenTarih = Convert.ToDateTime(Convert.ToDateTime(DtpTarih.Text.ToString()).ToString("dd.MM.yyyy"));
                        var data = db.TblSeferler.Where(x => x.KoltukNo == koltukNo && x.OtobusFirma == CbOtobusSec.Text && x.Tarih == SecilenTarih).FirstOrDefault();
                        
                        if (data != null)
                        {
                            Button koltuk = new Button();
                            koltuk.Height = koltuk.Width = 40;
                            koltuk.Top = 30 + (i * 45);
                            koltuk.BackColor = (data.Cinsiyet == "Bay") ? Color.Blue : Color.Red;
                            koltuk.Left = 5 + (j * 45);
                            koltuk.Text = koltukNo.ToString();
                            koltukNo++;
                            koltuk.ContextMenuStrip = contextMenuStrip1;
                            koltuk.MouseDown += Koltuk_MouseDown;
                            Panel.Controls.Add(koltuk);
                        }
                        else
                        {
                            Button koltuk = new Button();
                            koltuk.Height = koltuk.Width = 40;
                            koltuk.Top = 30 + (i * 45);
                            koltuk.Left = 5 + (j * 45);
                            koltuk.Text = koltukNo.ToString();
                            koltukNo++;
                            koltuk.ContextMenuStrip = contextMenuStrip1;
                            koltuk.MouseDown += Koltuk_MouseDown;
                            Panel.Controls.Add(koltuk);
                        }
                    }
                }
            }
        }
        Button tiklanan;
        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CbOtobusSec.SelectedIndex == -1 || CbNereden.SelectedIndex == -1 || CbNereye.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Önce Gerekli Alanları Doldurunuz");
                return;
            }
            KayitIslemleri kf = new KayitIslemleri();
            DialogResult Sonuc = kf.ShowDialog();
            if (Sonuc == DialogResult.OK)
            {
                TblSeferler model = new TblSeferler();
                model.IsimSoyisim = kf.TxtIsimSoyisim.Text;
                model.TelefonNo = kf.MtbTelefon.Text;
                if (kf.CbCinsiyet.SelectedItem.ToString() == "Bay")
                {
                    model.Cinsiyet = "Bay";
                    tiklanan.BackColor = Color.Blue;
                }
                else if (kf.CbCinsiyet.SelectedItem.ToString() == "Bayan")
                {
                    model.Cinsiyet = "Bayan";
                    tiklanan.BackColor = Color.Red;
                }

                model.OtobusFirma = CbOtobusSec.Text;
                model.Nereden = CbNereden.Text;
                model.Nereye = CbNereye.Text;
                model.Tarih = Convert.ToDateTime(DtpTarih.Text);
                model.Fiyat = int.Parse(TxtFiyat.Text);
                model.KoltukNo = int.Parse(tiklanan.Text);
                db.TblSeferler.Add(model);
                db.SaveChanges();
                Doldur();
                
            }
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuncelemeIslemleri gi = new GuncelemeIslemleri();
            DialogResult Sonuc = gi.ShowDialog();
            
        }
    }
}
