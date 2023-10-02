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
    public partial class FrmArızadetayı : Form
    {
        public FrmArızadetayı()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmArızadetayı_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLURUNTAKIP
                           select new
                           {
                               u.TAKIPID,
                               u.TARIH,
                               u.SERİNO,
                               u.AÇIKLAMA
                           };
          gridControl1.DataSource= degerler.ToList();
        }
    }
}
