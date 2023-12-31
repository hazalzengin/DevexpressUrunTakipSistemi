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
    public partial class FrmYeniPersonel : Form
    {
        public FrmYeniPersonel()
        {
            InitializeComponent();

            // This line of code is generated by Data Source Configuration Wizard
            tbldepartmanTableAdapter2.Fill(dbTeknikServisDataSet321.TBLDEPARTMAN);
        }
        DBTeknikServisEntities1 db = new DBTeknikServisEntities1();
        private void FrmYeniPersonel_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = txtad.Text;
            t.SOYAD = txtsoyad.Text;
            t.MAIL = txtmail.Text;
            t.TELEFON = txttelefon.Text;
            t.DEPARTMAN = byte.Parse(lookUpEdit1.EditValue.ToString());
            t.MAIL = textEdit3.Text;
            t.TELEFON = textEdit4.Text;
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni Personel  Başarıyla Kaydedildi");
        }
    }
}
