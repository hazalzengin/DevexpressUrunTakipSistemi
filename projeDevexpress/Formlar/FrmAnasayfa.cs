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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TBLURUN select new
            {
                x.AD,
                x.STOK,
            }).Where(x=>x.STOK<30).ToList();


            gridControl2.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.AD,
                                           x.SOYAD,
                                           x.IL
                                       }).ToList();

            DateTime bugun = DateTime.Today;
            var deger = (from x in db.TBLNOTLAR.OrderBy(y => y.ID)
                         where (x.TARIH == bugun)
                         select new { x.BASLIK, x.ICERIK });
            gridControl3.DataSource = deger.ToList();


            string konu1, ad1,konu2,ad2, konu3,ad3, konu4,ad4, konu5,ad5,konu6,ad6,konu7,ad7,konu8,ad8;
            konu1 = db.TBLILETISIM.First(x => x.ID==1).KONU;
            ad1 = db.TBLILETISIM.First(x => x.ID == 1).ADSOYAD;
            labelControl1.Text = konu1;
            labelControl9.Text = ad1;

            konu2 = db.TBLILETISIM.First(x => x.ID == 2).KONU;
            ad2 = db.TBLILETISIM.First(x => x.ID == 2).ADSOYAD;
            labelControl2.Text = konu2;
            labelControl10.Text = ad2;

            konu3 = db.TBLILETISIM.First(x => x.ID == 3).KONU;
            ad3 = db.TBLILETISIM.First(x => x.ID == 3).ADSOYAD;
            labelControl3.Text = konu3;
            labelControl11.Text = ad3;

            konu4 = db.TBLILETISIM.First(x => x.ID == 1002).KONU;
            ad4 = db.TBLILETISIM.First(x => x.ID == 1002).ADSOYAD;
            labelControl4.Text = konu4;
            labelControl12.Text = ad4;

            konu5 = db.TBLILETISIM.First(x => x.ID == 1003).KONU;
            ad5 = db.TBLILETISIM.First(x => x.ID == 1003).ADSOYAD;
            labelControl5.Text = konu5;
            labelControl13.Text = ad5;

            konu6 = db.TBLILETISIM.First(x => x.ID == 1004).KONU;
            ad6 = db.TBLILETISIM.First(x => x.ID == 1004).ADSOYAD;
            labelControl6.Text = konu6;
            labelControl14.Text = ad6;

            konu7 = db.TBLILETISIM.First(x => x.ID == 1005).KONU;
            ad7 = db.TBLILETISIM.First(x => x.ID == 1005).ADSOYAD;
            labelControl7.Text = konu7;
            labelControl15.Text = ad7;

            konu8 = db.TBLILETISIM.First(x => x.ID == 1006).KONU;
            ad8 = db.TBLILETISIM.First(x => x.ID == 1006).ADSOYAD;
            labelControl8.Text = konu8;
            labelControl16.Text = ad8;


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void ımageSlider1_Click(object sender, EventArgs e)
        {

        }
    }
}
