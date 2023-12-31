﻿using System;
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
    public partial class FrmCariListesi : Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            illerTableAdapter1.Fill(dbTeknikServisDataSet231.iller);
            // This line of code is generated by Data Source Configuration Wizard
            ilcelerTableAdapter1.Fill(dbTeknikServisDataSet241.ilceler);
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            var degerler= from x in db.TBLCARI
                                      select new
                                      {
                                          x.ID,
                                          x.AD,
                                          x.SOYAD,
                           
                                          x.IL,
                                          x.ILCE,
                                      };
            gridControl1.DataSource = degerler.ToList();
            labelControl17.Text = db.TBLCARI.Count().ToString();
            labelControl13.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();
            labelControl11.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();
            labelControl15.Text = (from x in db.TBLCARI
                                   orderby x.IL ascending
                                   select x.IL).FirstOrDefault();

        }

        private void FirstOrDefault()
        {
            throw new NotImplementedException();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (txturun.Text != ""&txtmarka.Text!="")
            {
                TBLCARI t = new TBLCARI();
                t.AD = txturun.Text;
                t.SOYAD = txtmarka.Text;
                t.IL = lookUpEdit1.EditValue.ToString();
                t.ILCE = lookUpEdit2.EditValue.ToString();
                db.TBLCARI.Add(t);

                db.SaveChanges();
                MessageBox.Show("Yeni Cari Başarıyla Eklenmiştir.", "Bilgi", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ YAPILDI.");
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLCARI.Find(id);
            db.TBLCARI.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Cari Silinmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deger = db.TBLCARI.Find(id);
            deger.AD = txturun.Text;
            deger.SOYAD = txtmarka.Text;
            deger.IL = lookUpEdit1.EditValue.ToString();
            deger.ILCE = lookUpEdit2.EditValue.ToString();
            
         
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            txturun.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            txtmarka.Text = gridView1.GetFocusedRowCellValue("SOYAD").ToString();
           
            //textEdit3.Text= gridView1.GetFocusedRowCellValue("BANKA").ToString();
            //textEdit1.Text= gridView1.GetFocusedRowCellValue("ADRES").ToString();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {

            var degerler = from x in db.TBLCARI
                           select new
                           {
                               x.ID,
                               x.AD,
                               x.SOYAD,
                             
                               x.IL,
                               x.ILCE,
                           };
            gridControl1.DataSource = degerler.ToList();
        }
    }
}
