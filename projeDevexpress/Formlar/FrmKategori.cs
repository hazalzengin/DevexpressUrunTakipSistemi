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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKATEGORİ
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtad.Text.Length <= 30)
            {
                TBLKATEGORİ t = new TBLKATEGORİ();
                t.AD = txtad.Text;
                db.TBLKATEGORİ.Add(t);
                db.SaveChanges();
                MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show("Kategori adı boş geçilemez. Lütfen bir kategori isim giriniz.Kategori ismi 30 karakterden uzun olamaz.");
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKATEGORİ
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txtad.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLKATEGORİ.Find(id);
            db.TBLKATEGORİ.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Kategori Silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLKATEGORİ.Find(id);
            deger.AD = txtad.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txtad.Text = "";
            txtId.Text = "";

        }
    }
}
