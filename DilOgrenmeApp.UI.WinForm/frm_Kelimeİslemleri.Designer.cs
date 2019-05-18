namespace DilOgrenmeApp.UI.WinForm
{
    partial class frm_Kelimeİslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_KelimeSilId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_KEFotoYolu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_KelimeEkle = new System.Windows.Forms.Button();
            this.txt_Kategori = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_KESozcukTuru = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_KETurkceCumle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_KEİngilizceCumle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_KETurkce = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_KEİngilizce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.kelimeHavuzuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dilOgrenmeOtomasyonDataSet2 = new DilOgrenmeApp.UI.WinForm.DilOgrenmeOtomasyonDataSet2();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colingilizce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colturkce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colicumle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltcumle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsozcukturu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfotoyolu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkategori = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colasamaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsormaTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbugunTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kelimeHavuzuTableAdapter = new DilOgrenmeApp.UI.WinForm.DilOgrenmeOtomasyonDataSet2TableAdapters.KelimeHavuzuTableAdapter();
            this.dilOgrenmeOtomasyonDataSet = new DilOgrenmeApp.UI.WinForm.DilOgrenmeOtomasyonDataSet();
            this.kelimeHavuzuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kelimeHavuzuTableAdapter1 = new DilOgrenmeApp.UI.WinForm.DilOgrenmeOtomasyonDataSetTableAdapters.KelimeHavuzuTableAdapter();
            this.dilOgrenmeOtomasyonDataSet3 = new DilOgrenmeApp.UI.WinForm.DilOgrenmeOtomasyonDataSet3();
            this.kelimeHavuzuBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kelimeHavuzuTableAdapter2 = new DilOgrenmeApp.UI.WinForm.DilOgrenmeOtomasyonDataSet3TableAdapters.KelimeHavuzuTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeHavuzuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilOgrenmeOtomasyonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilOgrenmeOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeHavuzuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilOgrenmeOtomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeHavuzuBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Kelime ID Giriniz";
            // 
            // txt_KelimeSilId
            // 
            this.txt_KelimeSilId.Location = new System.Drawing.Point(132, 19);
            this.txt_KelimeSilId.Name = "txt_KelimeSilId";
            this.txt_KelimeSilId.Size = new System.Drawing.Size(64, 20);
            this.txt_KelimeSilId.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kelime Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_KelimeSilId);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(406, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kelime Sil";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_KEFotoYolu);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_KelimeEkle);
            this.groupBox2.Controls.Add(this.txt_Kategori);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_KESozcukTuru);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_KETurkceCumle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_KEİngilizceCumle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_KETurkce);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_KEİngilizce);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(-2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 278);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kelime Ekle";
            // 
            // txt_KEFotoYolu
            // 
            this.txt_KEFotoYolu.Location = new System.Drawing.Point(161, 169);
            this.txt_KEFotoYolu.Name = "txt_KEFotoYolu";
            this.txt_KEFotoYolu.Size = new System.Drawing.Size(150, 20);
            this.txt_KEFotoYolu.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Lütfen Fotoğraf Yolu Giriniz";
            // 
            // btn_KelimeEkle
            // 
            this.btn_KelimeEkle.Location = new System.Drawing.Point(12, 220);
            this.btn_KelimeEkle.Name = "btn_KelimeEkle";
            this.btn_KelimeEkle.Size = new System.Drawing.Size(106, 23);
            this.btn_KelimeEkle.TabIndex = 16;
            this.btn_KelimeEkle.Text = "Kelime Ekle";
            this.btn_KelimeEkle.UseVisualStyleBackColor = true;
            this.btn_KelimeEkle.Click += new System.EventHandler(this.btn_KelimeEkle_Click);
            // 
            // txt_Kategori
            // 
            this.txt_Kategori.Location = new System.Drawing.Point(161, 192);
            this.txt_Kategori.Name = "txt_Kategori";
            this.txt_Kategori.Size = new System.Drawing.Size(150, 20);
            this.txt_Kategori.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Lütfen Kategori Giriniz";
            // 
            // txt_KESozcukTuru
            // 
            this.txt_KESozcukTuru.Location = new System.Drawing.Point(161, 141);
            this.txt_KESozcukTuru.Name = "txt_KESozcukTuru";
            this.txt_KESozcukTuru.Size = new System.Drawing.Size(150, 20);
            this.txt_KESozcukTuru.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lütfen Sözcük Türü Giriniz";
            // 
            // txt_KETurkceCumle
            // 
            this.txt_KETurkceCumle.Location = new System.Drawing.Point(161, 115);
            this.txt_KETurkceCumle.Name = "txt_KETurkceCumle";
            this.txt_KETurkceCumle.Size = new System.Drawing.Size(150, 20);
            this.txt_KETurkceCumle.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lütfen Türkçe Cümle Giriniz";
            // 
            // txt_KEİngilizceCumle
            // 
            this.txt_KEİngilizceCumle.Location = new System.Drawing.Point(161, 83);
            this.txt_KEİngilizceCumle.Name = "txt_KEİngilizceCumle";
            this.txt_KEİngilizceCumle.Size = new System.Drawing.Size(150, 20);
            this.txt_KEİngilizceCumle.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lütfen İngilizce Cümle Giriniz";
            // 
            // txt_KETurkce
            // 
            this.txt_KETurkce.Location = new System.Drawing.Point(161, 48);
            this.txt_KETurkce.Name = "txt_KETurkce";
            this.txt_KETurkce.Size = new System.Drawing.Size(150, 20);
            this.txt_KETurkce.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lütfen Türkçe Kelime  Giriniz";
            // 
            // txt_KEİngilizce
            // 
            this.txt_KEİngilizce.Location = new System.Drawing.Point(161, 21);
            this.txt_KEİngilizce.Name = "txt_KEİngilizce";
            this.txt_KEİngilizce.Size = new System.Drawing.Size(150, 20);
            this.txt_KEİngilizce.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lütfen İngilizce Kelime  Giriniz";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kelimeHavuzuBindingSource2;
            this.gridControl1.Location = new System.Drawing.Point(406, 117);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(402, 161);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // kelimeHavuzuBindingSource
            // 
            this.kelimeHavuzuBindingSource.DataMember = "KelimeHavuzu";
            this.kelimeHavuzuBindingSource.DataSource = this.dilOgrenmeOtomasyonDataSet2;
            // 
            // dilOgrenmeOtomasyonDataSet2
            // 
            this.dilOgrenmeOtomasyonDataSet2.DataSetName = "DilOgrenmeOtomasyonDataSet2";
            this.dilOgrenmeOtomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.DarkSalmon;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Brown;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colingilizce,
            this.colturkce,
            this.colicumle,
            this.coltcumle,
            this.colsozcukturu,
            this.colfotoyolu,
            this.colkategori,
            this.colasamaNo,
            this.colsormaTarihi,
            this.colbugunTarihi,
            this.gridColumn1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colingilizce
            // 
            this.colingilizce.FieldName = "ingilizce";
            this.colingilizce.Name = "colingilizce";
            this.colingilizce.Visible = true;
            this.colingilizce.VisibleIndex = 1;
            // 
            // colturkce
            // 
            this.colturkce.FieldName = "turkce";
            this.colturkce.Name = "colturkce";
            this.colturkce.Visible = true;
            this.colturkce.VisibleIndex = 2;
            // 
            // colicumle
            // 
            this.colicumle.FieldName = "icumle";
            this.colicumle.Name = "colicumle";
            this.colicumle.Visible = true;
            this.colicumle.VisibleIndex = 3;
            // 
            // coltcumle
            // 
            this.coltcumle.FieldName = "tcumle";
            this.coltcumle.Name = "coltcumle";
            this.coltcumle.Visible = true;
            this.coltcumle.VisibleIndex = 4;
            // 
            // colsozcukturu
            // 
            this.colsozcukturu.FieldName = "sozcukturu";
            this.colsozcukturu.Name = "colsozcukturu";
            this.colsozcukturu.Visible = true;
            this.colsozcukturu.VisibleIndex = 5;
            // 
            // colfotoyolu
            // 
            this.colfotoyolu.FieldName = "fotoyolu";
            this.colfotoyolu.Name = "colfotoyolu";
            this.colfotoyolu.Visible = true;
            this.colfotoyolu.VisibleIndex = 6;
            // 
            // colkategori
            // 
            this.colkategori.FieldName = "kategori";
            this.colkategori.Name = "colkategori";
            this.colkategori.Visible = true;
            this.colkategori.VisibleIndex = 7;
            // 
            // colasamaNo
            // 
            this.colasamaNo.FieldName = "asamaNo";
            this.colasamaNo.Name = "colasamaNo";
            this.colasamaNo.Visible = true;
            this.colasamaNo.VisibleIndex = 8;
            // 
            // colsormaTarihi
            // 
            this.colsormaTarihi.FieldName = "sormaTarihi";
            this.colsormaTarihi.Name = "colsormaTarihi";
            this.colsormaTarihi.Visible = true;
            this.colsormaTarihi.VisibleIndex = 9;
            // 
            // colbugunTarihi
            // 
            this.colbugunTarihi.FieldName = "bugunTarihi";
            this.colbugunTarihi.Name = "colbugunTarihi";
            this.colbugunTarihi.Visible = true;
            this.colbugunTarihi.VisibleIndex = 10;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            // 
            // kelimeHavuzuTableAdapter
            // 
            this.kelimeHavuzuTableAdapter.ClearBeforeFill = true;
            // 
            // dilOgrenmeOtomasyonDataSet
            // 
            this.dilOgrenmeOtomasyonDataSet.DataSetName = "DilOgrenmeOtomasyonDataSet";
            this.dilOgrenmeOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kelimeHavuzuBindingSource1
            // 
            this.kelimeHavuzuBindingSource1.DataMember = "KelimeHavuzu";
            this.kelimeHavuzuBindingSource1.DataSource = this.dilOgrenmeOtomasyonDataSet;
            // 
            // kelimeHavuzuTableAdapter1
            // 
            this.kelimeHavuzuTableAdapter1.ClearBeforeFill = true;
            // 
            // dilOgrenmeOtomasyonDataSet3
            // 
            this.dilOgrenmeOtomasyonDataSet3.DataSetName = "DilOgrenmeOtomasyonDataSet3";
            this.dilOgrenmeOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kelimeHavuzuBindingSource2
            // 
            this.kelimeHavuzuBindingSource2.DataMember = "KelimeHavuzu";
            this.kelimeHavuzuBindingSource2.DataSource = this.dilOgrenmeOtomasyonDataSet3;
            // 
            // kelimeHavuzuTableAdapter2
            // 
            this.kelimeHavuzuTableAdapter2.ClearBeforeFill = true;
            // 
            // frm_Kelimeİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(860, 271);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Kelimeİslemleri";
            this.Text = "Kelime İslemleri";
            this.Load += new System.EventHandler(this.frm_Kelimeİslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeHavuzuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilOgrenmeOtomasyonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilOgrenmeOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeHavuzuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilOgrenmeOtomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeHavuzuBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_KelimeSilId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_KelimeEkle;
        private System.Windows.Forms.TextBox txt_Kategori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_KESozcukTuru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_KETurkceCumle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_KEİngilizceCumle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_KETurkce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_KEİngilizce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_KEFotoYolu;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DilOgrenmeOtomasyonDataSet2 dilOgrenmeOtomasyonDataSet2;
        private System.Windows.Forms.BindingSource kelimeHavuzuBindingSource;
        private DilOgrenmeOtomasyonDataSet2TableAdapters.KelimeHavuzuTableAdapter kelimeHavuzuTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colingilizce;
        private DevExpress.XtraGrid.Columns.GridColumn colturkce;
        private DevExpress.XtraGrid.Columns.GridColumn colicumle;
        private DevExpress.XtraGrid.Columns.GridColumn coltcumle;
        private DevExpress.XtraGrid.Columns.GridColumn colsozcukturu;
        private DevExpress.XtraGrid.Columns.GridColumn colfotoyolu;
        private DevExpress.XtraGrid.Columns.GridColumn colkategori;
        private DevExpress.XtraGrid.Columns.GridColumn colasamaNo;
        private DevExpress.XtraGrid.Columns.GridColumn colsormaTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colbugunTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DilOgrenmeOtomasyonDataSet dilOgrenmeOtomasyonDataSet;
        private System.Windows.Forms.BindingSource kelimeHavuzuBindingSource1;
        private DilOgrenmeOtomasyonDataSetTableAdapters.KelimeHavuzuTableAdapter kelimeHavuzuTableAdapter1;
        private DilOgrenmeOtomasyonDataSet3 dilOgrenmeOtomasyonDataSet3;
        private System.Windows.Forms.BindingSource kelimeHavuzuBindingSource2;
        private DilOgrenmeOtomasyonDataSet3TableAdapters.KelimeHavuzuTableAdapter kelimeHavuzuTableAdapter2;
    }
}