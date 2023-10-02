using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeDevexpress.Formlar
{
    public partial class FrmArızaListesi : Form
    {
        public FrmArızaListesi()
        {
            InitializeComponent();
        }
       
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmArızaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                              CARİ = x.TBLCARI.AD+x.TBLCARI.SOYAD,
                              x.GELISTARIHI,
                               x.CIKISTARIHI,
                               x.PERSONEL,
                               //personel = x.TBLPERSONEL.AD,x.TBLPERSONEL.SOYAD,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY,

                           };
            gridControl1.DataSource = degerler.ToList();
            labelControl11.Text = db.TBLURUN.Count().ToString();
            labelControl2.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == false).ToString();
            labelControl3.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == true).ToString();
            labelControl5.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça bekleniyor").ToString();
            labelControl13.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Mesaj bekleniyor").ToString();
            labelControl7.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İşlem İptal Edilmiştir").ToString();

            SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DBTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT URUNDURUMDETAY,COUNT(*) FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();

           // Console.WriteLine(" HAZAL BİLGİSAYARINI KİLİTLEMEYİ UNUTMA"); 
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmArızaDetay fr = new FrmArızaDetay();
            fr.urunid = gridView1.GetFocusedRowCellValue("ISLEMID").ToString();
           // fr.serino = gridView1.GetFocusedRowCellValue("SERINO").ToString();
            fr.Show();
        }
    }           
    }

