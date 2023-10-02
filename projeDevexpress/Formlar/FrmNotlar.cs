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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLNOTLAR.Where(x => x.DURUM == true).ToList();
            gridControl2.DataSource = db.TBLNOTLAR.Where(y => y.DURUM == false).ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLAR t = new TBLNOTLAR();
            t.BASLIK = txtbaslik.Text;
            t.ICERIK = txticerik.Text;
            t.TARIH = Convert.ToDateTime(textEdit1.Text);
            t.DURUM = false;
            db.TBLNOTLAR.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not Başarıyla Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = db.TBLNOTLAR.Where(x => x.DURUM == true).ToList();
            gridControl2.DataSource = db.TBLNOTLAR.Where(y => y.DURUM == false).ToList();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                int id = int.Parse(txtId.Text);
                var deger = db.TBLNOTLAR.Find(id);
                deger.DURUM = true;
                db.SaveChanges();
                MessageBox.Show("Notlar değiştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString(); 
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLNOTLAR.Find(id);
            db.TBLNOTLAR.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView2.GetFocusedRowCellValue("ID").ToString();
        }
    }
}
