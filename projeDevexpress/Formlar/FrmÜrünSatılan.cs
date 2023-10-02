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
    public partial class FrmÜrünSatılan : Form
    {
        public FrmÜrünSatılan()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmÜrünSatılan_Load(object sender, EventArgs e)
        {
            var a = from x in db.TBLCARI
                    select new
                    {
                         x.ID,
                         x.AD,
                         
                    };
            var degerler = from u in db.TBLURUNHAREKET
                           select new
                           {
                               u.HAREKETID,
                              CARI = u.MUSTERI,
                               u.TBLURUN.AD,
                               u.PERSONEL,
                               u.TARIH,
                               u.URUNSERINO,
                               u.FIYAT,
                               u.ADET,              

                           };
            gridControl1.DataSource = degerler.ToList();
            gridControl2.DataSource = a.ToList();
        }
    }
}
