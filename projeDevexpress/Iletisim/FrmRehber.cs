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
    public partial class FrmRehber : Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLCARI
                           select new
                           {
                               u.AD,
                               u.SOYAD,
                               u.TELEFON,
                               u.MAIL
                           };

            gridControl1.DataSource = degerler.ToList();
        }
    }
}
