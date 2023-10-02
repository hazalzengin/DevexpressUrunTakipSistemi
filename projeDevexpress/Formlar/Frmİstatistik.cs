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
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = db.TBLKATEGORİ.Count().ToString();
            labelControl5.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            labelControl9.Text = (from x in db.TBLURUN
                                  orderby x.STOK descending
                                  select x.AD).FirstOrDefault();
            labelControl11.Text = (from x in db.TBLURUN
                                   orderby x.STOK ascending
                                   select x.AD).FirstOrDefault();
            labelControl15.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT descending
                                   select x.AD).FirstOrDefault();
            labelControl37.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYAT ascending
                                   select x.AD).FirstOrDefault();
            labelControl13.Text = (from x in db.TBLURUN
                                   orderby x.KATEGORI ascending
                                   select x.AD).FirstOrDefault();
            labelControl21.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString();
            labelControl17.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();
            labelControl33.Text = db.TBLURUN.Count(x => x.KATEGORI == 3).ToString();
            labelControl19.Text = db.TBLURUN.Count(x => x.KATEGORI == 2).ToString();
            labelControl31.Text = (from x in db.TBLURUN
                                   select x.MARKA).Distinct().Count().ToString();
            labelControl27.Text = db.TBLURUNKABUL.Count().ToString();

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }
    }
}
