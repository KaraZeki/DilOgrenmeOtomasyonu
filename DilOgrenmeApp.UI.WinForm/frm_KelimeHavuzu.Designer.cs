namespace DilOgrenmeApp.UI.WinForm
{
    partial class frm_KelimeHavuzu
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
            this.grid_KelimeHavuzu = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingilizceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turkceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.icumleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcumleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sozcukturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoyoluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asamaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelimeHavuzuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dilOgrenmeOtomasyonDataSet = new DilOgrenmeApp.UI.WinForm.DilOgrenmeOtomasyonDataSet();
            this.kelimeHavuzuTableAdapter = new DilOgrenmeApp.UI.WinForm.DilOgrenmeOtomasyonDataSetTableAdapters.KelimeHavuzuTableAdapter();
            this.dilOgrenmeOtomasyonDataSet1 = new DilOgrenmeApp.UI.WinForm.DilOgrenmeOtomasyonDataSet1();
            this.kelimeHavuzuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kelimeHavuzuTableAdapter1 = new DilOgrenmeApp.UI.WinForm.DilOgrenmeOtomasyonDataSet1TableAdapters.KelimeHavuzuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KelimeHavuzu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeHavuzuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilOgrenmeOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilOgrenmeOtomasyonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeHavuzuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_KelimeHavuzu
            // 
            this.grid_KelimeHavuzu.AutoGenerateColumns = false;
            this.grid_KelimeHavuzu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_KelimeHavuzu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.ingilizceDataGridViewTextBoxColumn,
            this.turkceDataGridViewTextBoxColumn,
            this.icumleDataGridViewTextBoxColumn,
            this.tcumleDataGridViewTextBoxColumn,
            this.sozcukturuDataGridViewTextBoxColumn,
            this.fotoyoluDataGridViewTextBoxColumn,
            this.kategoriDataGridViewTextBoxColumn,
            this.asamaNoDataGridViewTextBoxColumn});
            this.grid_KelimeHavuzu.DataSource = this.kelimeHavuzuBindingSource1;
            this.grid_KelimeHavuzu.Location = new System.Drawing.Point(3, 2);
            this.grid_KelimeHavuzu.Name = "grid_KelimeHavuzu";
            this.grid_KelimeHavuzu.Size = new System.Drawing.Size(1000, 500);
            this.grid_KelimeHavuzu.TabIndex = 0;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingilizceDataGridViewTextBoxColumn
            // 
            this.ingilizceDataGridViewTextBoxColumn.DataPropertyName = "ingilizce";
            this.ingilizceDataGridViewTextBoxColumn.HeaderText = "ingilizce";
            this.ingilizceDataGridViewTextBoxColumn.Name = "ingilizceDataGridViewTextBoxColumn";
            // 
            // turkceDataGridViewTextBoxColumn
            // 
            this.turkceDataGridViewTextBoxColumn.DataPropertyName = "turkce";
            this.turkceDataGridViewTextBoxColumn.HeaderText = "turkce";
            this.turkceDataGridViewTextBoxColumn.Name = "turkceDataGridViewTextBoxColumn";
            // 
            // icumleDataGridViewTextBoxColumn
            // 
            this.icumleDataGridViewTextBoxColumn.DataPropertyName = "icumle";
            this.icumleDataGridViewTextBoxColumn.HeaderText = "icumle";
            this.icumleDataGridViewTextBoxColumn.Name = "icumleDataGridViewTextBoxColumn";
            // 
            // tcumleDataGridViewTextBoxColumn
            // 
            this.tcumleDataGridViewTextBoxColumn.DataPropertyName = "tcumle";
            this.tcumleDataGridViewTextBoxColumn.HeaderText = "tcumle";
            this.tcumleDataGridViewTextBoxColumn.Name = "tcumleDataGridViewTextBoxColumn";
            // 
            // sozcukturuDataGridViewTextBoxColumn
            // 
            this.sozcukturuDataGridViewTextBoxColumn.DataPropertyName = "sozcukturu";
            this.sozcukturuDataGridViewTextBoxColumn.HeaderText = "sozcukturu";
            this.sozcukturuDataGridViewTextBoxColumn.Name = "sozcukturuDataGridViewTextBoxColumn";
            // 
            // fotoyoluDataGridViewTextBoxColumn
            // 
            this.fotoyoluDataGridViewTextBoxColumn.DataPropertyName = "fotoyolu";
            this.fotoyoluDataGridViewTextBoxColumn.HeaderText = "fotoyolu";
            this.fotoyoluDataGridViewTextBoxColumn.Name = "fotoyoluDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // asamaNoDataGridViewTextBoxColumn
            // 
            this.asamaNoDataGridViewTextBoxColumn.DataPropertyName = "asamaNo";
            this.asamaNoDataGridViewTextBoxColumn.HeaderText = "asamaNo";
            this.asamaNoDataGridViewTextBoxColumn.Name = "asamaNoDataGridViewTextBoxColumn";
            // 
            // kelimeHavuzuBindingSource
            // 
            this.kelimeHavuzuBindingSource.DataMember = "KelimeHavuzu";
            this.kelimeHavuzuBindingSource.DataSource = this.dilOgrenmeOtomasyonDataSet;
            // 
            // dilOgrenmeOtomasyonDataSet
            // 
            this.dilOgrenmeOtomasyonDataSet.DataSetName = "DilOgrenmeOtomasyonDataSet";
            this.dilOgrenmeOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kelimeHavuzuTableAdapter
            // 
            this.kelimeHavuzuTableAdapter.ClearBeforeFill = true;
            // 
            // dilOgrenmeOtomasyonDataSet1
            // 
            this.dilOgrenmeOtomasyonDataSet1.DataSetName = "DilOgrenmeOtomasyonDataSet1";
            this.dilOgrenmeOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kelimeHavuzuBindingSource1
            // 
            this.kelimeHavuzuBindingSource1.DataMember = "KelimeHavuzu";
            this.kelimeHavuzuBindingSource1.DataSource = this.dilOgrenmeOtomasyonDataSet1;
            // 
            // kelimeHavuzuTableAdapter1
            // 
            this.kelimeHavuzuTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_KelimeHavuzu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.grid_KelimeHavuzu);
            this.Name = "frm_KelimeHavuzu";
            this.Text = "frm_KelimeHavuzu";
            this.Load += new System.EventHandler(this.frm_KelimeHavuzu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KelimeHavuzu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeHavuzuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilOgrenmeOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dilOgrenmeOtomasyonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kelimeHavuzuBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_KelimeHavuzu;
        private DilOgrenmeOtomasyonDataSet dilOgrenmeOtomasyonDataSet;
        private System.Windows.Forms.BindingSource kelimeHavuzuBindingSource;
        private DilOgrenmeOtomasyonDataSetTableAdapters.KelimeHavuzuTableAdapter kelimeHavuzuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingilizceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turkceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn icumleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcumleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sozcukturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fotoyoluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asamaNoDataGridViewTextBoxColumn;
        private DilOgrenmeOtomasyonDataSet1 dilOgrenmeOtomasyonDataSet1;
        private System.Windows.Forms.BindingSource kelimeHavuzuBindingSource1;
        private DilOgrenmeOtomasyonDataSet1TableAdapters.KelimeHavuzuTableAdapter kelimeHavuzuTableAdapter1;
    }
}