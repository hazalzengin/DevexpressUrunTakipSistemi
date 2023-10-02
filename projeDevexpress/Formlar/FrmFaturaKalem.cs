using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeDevexpress.Formlar
{
    public partial class FrmFaturaKalem : Form
    {
        public FrmFaturaKalem()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmFaturaKalem_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                              u.FATURADETAYID,
                              u.URUN,
                              u.ADET,
                              u.FIYAT,
                              u.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY t = new TBLFATURADETAY();
            t.ADET = short.Parse(txtmarka.Text);
            t.URUN = textEdit2.Text;
            t.FATURAID = int.Parse(textEdit4.Text);
            t.FIYAT = Decimal.Parse(txtstok.Text);
            t.TUTAR = Decimal.Parse(textEdit3.Text);
            db.TBLFATURADETAY.Add(t);
            db.SaveChanges();
            MessageBox.Show("Faturaya Ait Kalem işlemleri Başarıyla Kaydedildi");

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.FATURAID
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
