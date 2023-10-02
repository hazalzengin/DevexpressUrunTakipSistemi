
namespace projeDevexpress.Formlar
{
    partial class FrmQR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQR));
            this.Z = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.tBLURUNHAREKETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTeknikServisDataSet31 = new projeDevexpress.DBTeknikServisDataSet3();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.tblurunhareketTableAdapter1 = new projeDevexpress.DBTeknikServisDataSet3TableAdapters.TBLURUNHAREKETTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tBLURUNHAREKETBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbTeknikServisDataSet191 = new projeDevexpress.DBTeknikServisDataSet19();
            this.tblurunhareketTableAdapter2 = new projeDevexpress.DBTeknikServisDataSet3TableAdapters.TBLURUNHAREKETTableAdapter();
            this.tBLURUNHAREKETBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dbTeknikServisDataSet201 = new projeDevexpress.DBTeknikServisDataSet20();
            this.tblurunhareketTableAdapter3 = new projeDevexpress.DBTeknikServisDataSet20TableAdapters.TBLURUNHAREKETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNHAREKETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNHAREKETBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet191)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNHAREKETBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet201)).BeginInit();
            this.SuspendLayout();
            // 
            // Z
            // 
            this.Z.Location = new System.Drawing.Point(138, 107);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(53, 16);
            this.Z.TabIndex = 18;
            this.Z.Text = "SERİ NO:";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(231, 101);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HAREKETID", "HAREKETID", 88, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("URUNSERINO", "URUNSERINO", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit1.Properties.DataSource = this.tBLURUNHAREKETBindingSource2;
            this.lookUpEdit1.Properties.DisplayMember = "HAREKETID";
            this.lookUpEdit1.Properties.NullText = "ÜRÜN SERİ NO ";
            this.lookUpEdit1.Properties.ValueMember = "URUNSERINO";
            this.lookUpEdit1.Size = new System.Drawing.Size(190, 22);
            this.lookUpEdit1.TabIndex = 19;
            // 
            // tBLURUNHAREKETBindingSource
            // 
            this.tBLURUNHAREKETBindingSource.DataMember = "TBLURUNHAREKET";
            this.tBLURUNHAREKETBindingSource.DataSource = this.dbTeknikServisDataSet31;
            this.tBLURUNHAREKETBindingSource.Sort = "";
            // 
            // dbTeknikServisDataSet31
            // 
            this.dbTeknikServisDataSet31.DataSetName = "DBTeknikServisDataSet3";
            this.dbTeknikServisDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(186, 161);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(163, 50);
            this.BtnKaydet.TabIndex = 20;
            this.BtnKaydet.Text = "QR KOD OLUŞTUR";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(186, 275);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(235, 147);
            this.pictureEdit1.TabIndex = 21;
            // 
            // tblurunhareketTableAdapter1
            // 
            this.tblurunhareketTableAdapter1.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(186, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(312, 23);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "SERİ NO İÇİN QR KOD OLUŞTUR";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(375, 161);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(163, 50);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "IPTAL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tBLURUNHAREKETBindingSource1
            // 
            this.tBLURUNHAREKETBindingSource1.DataMember = "TBLURUNHAREKET";
            this.tBLURUNHAREKETBindingSource1.DataSource = this.dbTeknikServisDataSet191;
            this.tBLURUNHAREKETBindingSource1.Sort = "";
            // 
            // dbTeknikServisDataSet191
            // 
            this.dbTeknikServisDataSet191.DataSetName = "DBTeknikServisDataSet19";
            this.dbTeknikServisDataSet191.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblurunhareketTableAdapter2
            // 
            this.tblurunhareketTableAdapter2.ClearBeforeFill = true;
            // 
            // tBLURUNHAREKETBindingSource2
            // 
            this.tBLURUNHAREKETBindingSource2.DataMember = "TBLURUNHAREKET";
            this.tBLURUNHAREKETBindingSource2.DataSource = this.dbTeknikServisDataSet201;
            this.tBLURUNHAREKETBindingSource2.Sort = "";
            // 
            // dbTeknikServisDataSet201
            // 
            this.dbTeknikServisDataSet201.DataSetName = "DBTeknikServisDataSet20";
            this.dbTeknikServisDataSet201.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblurunhareketTableAdapter3
            // 
            this.tblurunhareketTableAdapter3.ClearBeforeFill = true;
            // 
            // FrmQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.Z);
            this.Name = "FrmQR";
            this.Text = "FrmQR";
            this.Load += new System.EventHandler(this.FrmQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNHAREKETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNHAREKETBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet191)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNHAREKETBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet201)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Z;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.BindingSource tBLURUNHAREKETBindingSource;
        private DBTeknikServisDataSet3 dbTeknikServisDataSet31;
        private DBTeknikServisDataSet3TableAdapters.TBLURUNHAREKETTableAdapter tblurunhareketTableAdapter1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.BindingSource tBLURUNHAREKETBindingSource1;
        private DBTeknikServisDataSet19 dbTeknikServisDataSet191;
        private DBTeknikServisDataSet3TableAdapters.TBLURUNHAREKETTableAdapter tblurunhareketTableAdapter2;
        private System.Windows.Forms.BindingSource tBLURUNHAREKETBindingSource2;
        private DBTeknikServisDataSet20 dbTeknikServisDataSet201;
        private DBTeknikServisDataSet20TableAdapters.TBLURUNHAREKETTableAdapter tblurunhareketTableAdapter3;
    }
}