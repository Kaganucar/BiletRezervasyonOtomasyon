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
    public partial class KayitIslemleri : Form
    {
        public KayitIslemleri()
        {
            InitializeComponent();
        }
        
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();

            
        }

        private void KayitIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}
