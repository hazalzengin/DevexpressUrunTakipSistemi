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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (txtad.Text != "" && txtad.Text.Length <= 30)
            {
                TBLKATEGORİ t = new TBLKATEGORİ();
                t.AD = txtad.Text;
                db.TBLKATEGORİ.Add(t);
                db.SaveChanges();
                MessageBox.Show("Yeni Kategori Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori adı boş geçilemez. Lütfen bir kategori isim giriniz.Kategori ismi 30 karakterden uzun olamaz.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void FrmYeniKategori_Load(object sender, EventArgs e)
        {
            txtad.Text = "";
            
        }
    }
}
