using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace projeDevexpress.Formlar
{
    public partial class FrmMarkalar : Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            gridControl1.DataSource = degerler.ToList();
            labelControl2.Text = db.TBLURUN.Count().ToString();
            labelControl3.Text = (from x in db.TBLURUN
                                  select x.MARKA).Distinct().Count().ToString();
            labelControl7.Text = (from x in db.TBLURUN
                                  orderby x.SATISFIYAT descending
                                  select x.MARKA).FirstOrDefault();
            
            //chartControl1.Series["Series 1"].Points.AddPoint("BOSCH",2);
            //chartControl1.Series["Series 1"].Points.AddPoint("ARÇELİK", 3);
            //chartControl1.Series["Series 1"].Points.AddPoint("APPLE", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("SAMSUNG", 5);


            SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DBTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT MARKA,COUNT(*) FROM TBLURUN GROUP BY MARKA", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();

            SqlConnection baglanti2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DBTeknikServis;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT TBLKATEGORİ.AD,COUNT(*)FROM TBLURUN INNER JOIN TBLKATEGORİ ON TBLKATEGORİ.ID=TBLURUN.KATEGORI GROUP BY TBLKATEGORİ.AD", baglanti2);
            SqlDataReader dr2 = komut.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            baglanti.Close();
            
        }

       
    }
}
