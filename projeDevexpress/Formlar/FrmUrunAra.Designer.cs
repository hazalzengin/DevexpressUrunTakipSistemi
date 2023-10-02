
namespace projeDevexpress.Formlar
{
    partial class FrmUrunAra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunAra));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tBLURUNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTeknikServisDataSet291 = new projeDevexpress.DBTeknikServisDataSet29();
            this.tBLFATURADETAYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTeknikServisDataSet131 = new projeDevexpress.DBTeknikServisDataSet13();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tblfaturadetayTableAdapter1 = new projeDevexpress.DBTeknikServisDataSet13TableAdapters.TBLFATURADETAYTableAdapter();
            this.tblurunTableAdapter1 = new projeDevexpress.DBTeknikServisDataSet29TableAdapters.TBLURUNTableAdapter();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.tBLURUNBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbTeknikServisDataSet292 = new projeDevexpress.DBTeknikServisDataSet29();
            this.tblurunTableAdapter2 = new projeDevexpress.DBTeknikServisDataSet29TableAdapters.TBLURUNTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet291)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFATURADETAYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet131)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet292)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 90);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1705, 681);
            this.gridControl1.TabIndex = 33;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Red;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // tBLURUNBindingSource
            // 
            this.tBLURUNBindingSource.DataMember = "TBLURUN";
            this.tBLURUNBindingSource.DataSource = this.dbTeknikServisDataSet291;
            this.tBLURUNBindingSource.Sort = "";
            // 
            // dbTeknikServisDataSet291
            // 
            this.dbTeknikServisDataSet291.DataSetName = "DBTeknikServisDataSet29";
            this.dbTeknikServisDataSet291.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLFATURADETAYBindingSource
            // 
            this.tBLFATURADETAYBindingSource.DataMember = "TBLFATURADETAY";
            this.tBLFATURADETAYBindingSource.DataSource = this.dbTeknikServisDataSet131;
            this.tBLFATURADETAYBindingSource.Sort = "";
            // 
            // dbTeknikServisDataSet131
            // 
            this.dbTeknikServisDataSet131.DataSetName = "DBTeknikServisDataSet13";
            this.dbTeknikServisDataSet131.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseBackColor = true;
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(322, 10);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(136, 72);
            this.BtnKaydet.TabIndex = 35;
            this.BtnKaydet.Text = "ARA";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(72, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(51, 21);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "ÜRÜN";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // tblfaturadetayTableAdapter1
            // 
            this.tblfaturadetayTableAdapter1.ClearBeforeFill = true;
            // 
            // tblurunTableAdapter1
            // 
            this.tblurunTableAdapter1.ClearBeforeFill = true;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(142, 39);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 35, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AD", "AD", 26, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit1.Properties.DataSource = this.tBLURUNBindingSource1;
            this.lookUpEdit1.Properties.DisplayMember = "AD";
            this.lookUpEdit1.Properties.NullText = "ÜRÜN";
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(125, 22);
            this.lookUpEdit1.TabIndex = 36;
            // 
            // tBLURUNBindingSource1
            // 
            this.tBLURUNBindingSource1.DataMember = "TBLURUN";
            this.tBLURUNBindingSource1.DataSource = this.dbTeknikServisDataSet292;
            this.tBLURUNBindingSource1.Sort = "";
            // 
            // dbTeknikServisDataSet292
            // 
            this.dbTeknikServisDataSet292.DataSetName = "DBTeknikServisDataSet29";
            this.dbTeknikServisDataSet292.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblurunTableAdapter2
            // 
            this.tblurunTableAdapter2.ClearBeforeFill = true;
            // 
            // FrmUrunAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 771);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmUrunAra";
            this.Text = "FrmUrunAra";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet291)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLFATURADETAYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet131)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTeknikServisDataSet292)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource tBLFATURADETAYBindingSource;
        private DBTeknikServisDataSet13 dbTeknikServisDataSet131;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DBTeknikServisDataSet13TableAdapters.TBLFATURADETAYTableAdapter tblfaturadetayTableAdapter1;
        private System.Windows.Forms.BindingSource tBLURUNBindingSource;
        private DBTeknikServisDataSet29 dbTeknikServisDataSet291;
        private DBTeknikServisDataSet29TableAdapters.TBLURUNTableAdapter tblurunTableAdapter1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.BindingSource tBLURUNBindingSource1;
        private DBTeknikServisDataSet29 dbTeknikServisDataSet292;
        private DBTeknikServisDataSet29TableAdapters.TBLURUNTableAdapter tblurunTableAdapter2;
    }
}