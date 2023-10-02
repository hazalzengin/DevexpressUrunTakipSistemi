
namespace projeDevexpress.Formlar
{
    partial class FrmYeniPersonel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniPersonel));
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl30 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.txttelefon = new DevExpress.XtraEditors.LabelControl();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.txtmail = new DevExpress.XtraEditors.LabelControl();
            this.txtsoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.Z = new DevExpress.XtraEditors.LabelControl();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txtad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.tBLDEPARTMANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTeknikServisDataSet51 = new projeDevexpress.DBTeknikServisDataSet5();
            this.tbldepartmanTableAdapter1 = new projeDevexpress.DBTeknikServisDataSet7TableAdapters.TBLDEPARTMANTableAdapter();
            this.tBLDEPARTMANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbTeknikServisDataSet321 = new projeDevexpress.DBTeknikServisDataSet32();
            this.tbldepartmanTableAdapter2 = new projeDevexpress.DBTeknikServisDataSet32TableAdapters.TBLDEPARTMANTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDEPARTMANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDEPARTMANBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet321)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(197, 212);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AD", "AD", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit1.Properties.DataSource = this.tBLDEPARTMANBindingSource1;
            this.lookUpEdit1.Properties.DisplayMember = "AD";
            this.lookUpEdit1.Properties.NullText = "DEPARTMAN";
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(183, 22);
            this.lookUpEdit1.TabIndex = 45;
            // 
            // labelControl30
            // 
            this.labelControl30.Location = new System.Drawing.Point(88, 215);
            this.labelControl30.Name = "labelControl30";
            this.labelControl30.Size = new System.Drawing.Size(77, 16);
            this.labelControl30.TabIndex = 44;
            this.labelControl30.Text = "DEPARTMAN:";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(190, 293);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(190, 22);
            this.textEdit4.TabIndex = 43;
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(88, 300);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(57, 16);
            this.txttelefon.TabIndex = 42;
            this.txttelefon.Text = "TELEFON:";
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(190, 250);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(190, 22);
            this.textEdit3.TabIndex = 41;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(88, 260);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(33, 16);
            this.txtmail.TabIndex = 40;
            this.txtmail.Text = "MAİL:";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(190, 184);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(190, 22);
            this.txtsoyad.TabIndex = 39;
            // 
            // labelControl27
            // 
            this.labelControl27.Location = new System.Drawing.Point(88, 190);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(49, 16);
            this.labelControl27.TabIndex = 38;
            this.labelControl27.Text = "SOYADI:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(190, 116);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(190, 22);
            this.txtId.TabIndex = 37;
            // 
            // Z
            // 
            this.Z.Location = new System.Drawing.Point(88, 122);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(81, 16);
            this.Z.TabIndex = 36;
            this.Z.Text = "PERSONEL ID:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnKaydet.Appearance.Options.UseBackColor = true;
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.Appearance.Options.UseForeColor = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(140, 358);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(183, 70);
            this.BtnKaydet.TabIndex = 32;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(190, 148);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(190, 22);
            this.txtad.TabIndex = 31;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(88, 187);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(25, 16);
            this.labelControl1.TabIndex = 30;
            this.labelControl1.Text = "ADI:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(114, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(354, 31);
            this.labelControl2.TabIndex = 46;
            this.labelControl2.Text = "YENİ PERSONEL EKLEME ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(96, 154);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 16);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "ADI:";
            // 
            // tBLDEPARTMANBindingSource
            // 
            this.tBLDEPARTMANBindingSource.DataMember = "TBLDEPARTMAN";
            this.tBLDEPARTMANBindingSource.DataSource = this.dbTeknikServisDataSet51;
            this.tBLDEPARTMANBindingSource.Sort = "";
            // 
            // dbTeknikServisDataSet51
            // 
            this.dbTeknikServisDataSet51.DataSetName = "DBTeknikServisDataSet5";
            this.dbTeknikServisDataSet51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbldepartmanTableAdapter1
            // 
            this.tbldepartmanTableAdapter1.ClearBeforeFill = true;
            // 
            // tBLDEPARTMANBindingSource1
            // 
            this.tBLDEPARTMANBindingSource1.DataMember = "TBLDEPARTMAN";
            this.tBLDEPARTMANBindingSource1.DataSource = this.dbTeknikServisDataSet321;
            this.tBLDEPARTMANBindingSource1.Sort = "";
            // 
            // dbTeknikServisDataSet321
            // 
            this.dbTeknikServisDataSet321.DataSetName = "DBTeknikServisDataSet32";
            this.dbTeknikServisDataSet321.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbldepartmanTableAdapter2
            // 
            this.tbldepartmanTableAdapter2.ClearBeforeFill = true;
            // 
            // FrmYeniPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(571, 890);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.labelControl30);
            this.Controls.Add(this.textEdit4);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.textEdit3);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.labelControl27);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmYeniPersonel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Personel ekleme alanı";
            this.Load += new System.EventHandler(this.FrmYeniPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDEPARTMANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDEPARTMANBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet321)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl30;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.LabelControl txttelefon;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl txtmail;
        private DevExpress.XtraEditors.TextEdit txtsoyad;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.LabelControl Z;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit txtad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.BindingSource tBLDEPARTMANBindingSource;
        private DBTeknikServisDataSet5 dbTeknikServisDataSet51;
        private DBTeknikServisDataSet7TableAdapters.TBLDEPARTMANTableAdapter tbldepartmanTableAdapter1;
        private System.Windows.Forms.BindingSource tBLDEPARTMANBindingSource1;
        private DBTeknikServisDataSet32 dbTeknikServisDataSet321;
        private DBTeknikServisDataSet32TableAdapters.TBLDEPARTMANTableAdapter tbldepartmanTableAdapter2;
    }
}