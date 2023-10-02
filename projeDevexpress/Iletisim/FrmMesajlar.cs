using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeDevexpress.Iletisim
{
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLILETISIM
                           select new
                           {
                              u.KONU,
                              u.MAIL,
                              u.MESAJ
                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl17.Text = db.TBLILETISIM.Count().ToString();
            labelControl15.Text = db.TBLILETISIM.Where(x => x.KONU == "Teşekkür").Count().ToString();
            labelControl13.Text = db.TBLILETISIM.Where(x => x.KONU == "ürün takibi").Count().ToString();
            labelControl11.Text = db.TBLILETISIM.Where(x => x.KONU == "ariza giderilmistir").Count().ToString();
            labelControl1.Text = db.TBLILETISIM.Where(x => x.KONU == "şikayet").Count().ToString();
            labelControl3.Text = db.TBLPERSONEL.Count().ToString();
            labelControl5.Text = db.TBLKATEGORİ.Count().ToString();
        }
    }
}
