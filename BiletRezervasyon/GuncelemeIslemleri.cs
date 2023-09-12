using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiletRezervasyon
{
    public partial class GuncelemeIslemleri : Form
    {
        public GuncelemeIslemleri()
        {
            InitializeComponent();
        }
        BiletSatisOtomasyonuEntities db = new BiletSatisOtomasyonuEntities();

        private void Doldur()
        {
            DgvListele.DataSource = db.TblSeferler.ToList();
        }

        private void BtnKayitislemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seferler s = new Seferler();
            DialogResult Sonuc = s.ShowDialog();
            
        }

        private void GuncelemeIslemleri_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void DgvListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int TiklananSatir = int.Parse(DgvListele.Rows[e.RowIndex].Cells[0].Value.ToString());


            TblSeferler model = db.TblSeferler.Find(TiklananSatir);
            TxtIsimSoyisim.Text = model.IsimSoyisim;
            MtbTelefon.Text =  model.TelefonNo;
            CbCinsiyet.Text = model.Cinsiyet;            
            CbOtobusSec.Text = model.OtobusFirma;
            CbNereden.Text = model.Nereden;
            CbNereye.Text = model.Nereye;
            DtpTarih.Text = model.Tarih.ToString();
            TxtKoltukNo.Text = model.KoltukNo.ToString();
            TxtFiyat.Text = model.Fiyat.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int TiklananSatir = int.Parse(DgvListele.CurrentRow.Index.ToString());

            int AlinanID = int.Parse(DgvListele.Rows[TiklananSatir].Cells[0].Value.ToString());

            TblSeferler model = db.TblSeferler.Find(AlinanID);
            model.IsimSoyisim = TxtIsimSoyisim.Text;
            model.TelefonNo = MtbTelefon.Text;
            model.Cinsiyet = CbCinsiyet.Text;
            model.OtobusFirma = CbOtobusSec.Text;
            model.Nereden = CbNereden.Text;
            model.Nereye = CbNereye.Text;
            model.Tarih = Convert.ToDateTime(DtpTarih.Text);
            model.KoltukNo = Convert.ToInt16(TxtKoltukNo.Text);
            model.Fiyat = Convert.ToDecimal(TxtFiyat.Text);
            db.SaveChanges();
            MessageBox.Show("Güncelleme Başarılı");
            Doldur();

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int TiklananSatir = int.Parse(DgvListele.CurrentRow.Index.ToString());

            int AlinanID = int.Parse(DgvListele.Rows[TiklananSatir].Cells[0].Value.ToString());

            TblSeferler model = db.TblSeferler.Find(AlinanID);
            db.TblSeferler.Remove(model);
            db.SaveChanges();
            MessageBox.Show("Kayıt Silinmiştir.");
            Doldur();
        }
        
    }
}
