namespace DilOgrenmeApp.UI.WinForm
{
    partial class frm_AnaSayfa
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_TestYap = new System.Windows.Forms.Button();
            this.rdbtn_A = new System.Windows.Forms.RadioButton();
            this.rdbtn_B = new System.Windows.Forms.RadioButton();
            this.rdbtn_C = new System.Windows.Forms.RadioButton();
            this.rdbtn_D = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbbox_Aylik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbox_Yillik = new System.Windows.Forms.ComboBox();
            this.btn_İstatistlikGoster = new System.Windows.Forms.Button();
            this.grpboxTest = new System.Windows.Forms.GroupBox();
            this.rdiobtn_AylikIstatistlik = new System.Windows.Forms.RadioButton();
            this.rdiobtn_YillikIstatistlik = new System.Windows.Forms.RadioButton();
            this.listboxIstatistlik = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.grpboxTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TestYap
            // 
            this.btn_TestYap.BackColor = System.Drawing.Color.Sienna;
            this.btn_TestYap.Location = new System.Drawing.Point(20, 175);
            this.btn_TestYap.Name = "btn_TestYap";
            this.btn_TestYap.Size = new System.Drawing.Size(150, 23);
            this.btn_TestYap.TabIndex = 3;
            this.btn_TestYap.Text = "Test Yap";
            this.btn_TestYap.UseVisualStyleBackColor = false;
            this.btn_TestYap.Click += new System.EventHandler(this.btn_TestYap_Click);
            // 
            // rdbtn_A
            // 
            this.rdbtn_A.AutoSize = true;
            this.rdbtn_A.Location = new System.Drawing.Point(20, 77);
            this.rdbtn_A.Name = "rdbtn_A";
            this.rdbtn_A.Size = new System.Drawing.Size(32, 17);
            this.rdbtn_A.TabIndex = 4;
            this.rdbtn_A.TabStop = true;
            this.rdbtn_A.Text = "A";
            this.rdbtn_A.UseVisualStyleBackColor = true;
            // 
            // rdbtn_B
            // 
            this.rdbtn_B.AutoSize = true;
            this.rdbtn_B.Location = new System.Drawing.Point(156, 77);
            this.rdbtn_B.Name = "rdbtn_B";
            this.rdbtn_B.Size = new System.Drawing.Size(32, 17);
            this.rdbtn_B.TabIndex = 5;
            this.rdbtn_B.TabStop = true;
            this.rdbtn_B.Text = "B";
            this.rdbtn_B.UseVisualStyleBackColor = true;
            // 
            // rdbtn_C
            // 
            this.rdbtn_C.AutoSize = true;
            this.rdbtn_C.Location = new System.Drawing.Point(20, 120);
            this.rdbtn_C.Name = "rdbtn_C";
            this.rdbtn_C.Size = new System.Drawing.Size(32, 17);
            this.rdbtn_C.TabIndex = 6;
            this.rdbtn_C.TabStop = true;
            this.rdbtn_C.Text = "C";
            this.rdbtn_C.UseVisualStyleBackColor = true;
            // 
            // rdbtn_D
            // 
            this.rdbtn_D.AutoSize = true;
            this.rdbtn_D.Location = new System.Drawing.Point(156, 120);
            this.rdbtn_D.Name = "rdbtn_D";
            this.rdbtn_D.Size = new System.Drawing.Size(33, 17);
            this.rdbtn_D.TabIndex = 7;
            this.rdbtn_D.TabStop = true;
            this.rdbtn_D.Text = "D";
            this.rdbtn_D.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 39);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "NULL";
            // 
            // cmbbox_Aylik
            // 
            this.cmbbox_Aylik.FormattingEnabled = true;
            this.cmbbox_Aylik.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbbox_Aylik.Location = new System.Drawing.Point(558, 228);
            this.cmbbox_Aylik.Name = "cmbbox_Aylik";
            this.cmbbox_Aylik.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_Aylik.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ay seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yıl seçiniz";
            // 
            // cmbbox_Yillik
            // 
            this.cmbbox_Yillik.FormattingEnabled = true;
            this.cmbbox_Yillik.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbbox_Yillik.Location = new System.Drawing.Point(744, 228);
            this.cmbbox_Yillik.Name = "cmbbox_Yillik";
            this.cmbbox_Yillik.Size = new System.Drawing.Size(63, 21);
            this.cmbbox_Yillik.TabIndex = 11;
            // 
            // btn_İstatistlikGoster
            // 
            this.btn_İstatistlikGoster.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_İstatistlikGoster.ForeColor = System.Drawing.Color.Black;
            this.btn_İstatistlikGoster.Location = new System.Drawing.Point(544, 265);
            this.btn_İstatistlikGoster.Name = "btn_İstatistlikGoster";
            this.btn_İstatistlikGoster.Size = new System.Drawing.Size(263, 23);
            this.btn_İstatistlikGoster.TabIndex = 14;
            this.btn_İstatistlikGoster.Text = "İstatistlik Listele";
            this.btn_İstatistlikGoster.UseVisualStyleBackColor = false;
            this.btn_İstatistlikGoster.Click += new System.EventHandler(this.btn_İstatistlikGoster_Click);
            // 
            // grpboxTest
            // 
            this.grpboxTest.BackColor = System.Drawing.Color.Teal;
            this.grpboxTest.Controls.Add(this.btn_TestYap);
            this.grpboxTest.Controls.Add(this.rdbtn_A);
            this.grpboxTest.Controls.Add(this.rdbtn_B);
            this.grpboxTest.Controls.Add(this.rdbtn_C);
            this.grpboxTest.Controls.Add(this.rdbtn_D);
            this.grpboxTest.Controls.Add(this.label1);
            this.grpboxTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpboxTest.Location = new System.Drawing.Point(38, 12);
            this.grpboxTest.Name = "grpboxTest";
            this.grpboxTest.Size = new System.Drawing.Size(292, 204);
            this.grpboxTest.TabIndex = 15;
            this.grpboxTest.TabStop = false;
            this.grpboxTest.Text = "Bugün Test Soruları";
            // 
            // rdiobtn_AylikIstatistlik
            // 
            this.rdiobtn_AylikIstatistlik.AutoSize = true;
            this.rdiobtn_AylikIstatistlik.Location = new System.Drawing.Point(504, 205);
            this.rdiobtn_AylikIstatistlik.Name = "rdiobtn_AylikIstatistlik";
            this.rdiobtn_AylikIstatistlik.Size = new System.Drawing.Size(90, 17);
            this.rdiobtn_AylikIstatistlik.TabIndex = 16;
            this.rdiobtn_AylikIstatistlik.TabStop = true;
            this.rdiobtn_AylikIstatistlik.Text = "Aylık İstatistlik";
            this.rdiobtn_AylikIstatistlik.UseVisualStyleBackColor = true;
            this.rdiobtn_AylikIstatistlik.CheckedChanged += new System.EventHandler(this.rdiobtn_AylikIstatistlik_CheckedChanged);
            // 
            // rdiobtn_YillikIstatistlik
            // 
            this.rdiobtn_YillikIstatistlik.AutoSize = true;
            this.rdiobtn_YillikIstatistlik.Location = new System.Drawing.Point(688, 205);
            this.rdiobtn_YillikIstatistlik.Name = "rdiobtn_YillikIstatistlik";
            this.rdiobtn_YillikIstatistlik.Size = new System.Drawing.Size(92, 17);
            this.rdiobtn_YillikIstatistlik.TabIndex = 17;
            this.rdiobtn_YillikIstatistlik.TabStop = true;
            this.rdiobtn_YillikIstatistlik.Text = "Yıllık İstatistlik ";
            this.rdiobtn_YillikIstatistlik.UseVisualStyleBackColor = true;
            this.rdiobtn_YillikIstatistlik.CheckedChanged += new System.EventHandler(this.rdiobtn_YillikIstatistlik_CheckedChanged);
            // 
            // listboxIstatistlik
            // 
            this.listboxIstatistlik.BackColor = System.Drawing.Color.Teal;
            this.listboxIstatistlik.FormattingEnabled = true;
            this.listboxIstatistlik.Location = new System.Drawing.Point(350, 15);
            this.listboxIstatistlik.Name = "listboxIstatistlik";
            this.listboxIstatistlik.Size = new System.Drawing.Size(551, 173);
            this.listboxIstatistlik.TabIndex = 18;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Teal;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(38, 228);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Yıllık";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(401, 149);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(350, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Yıllık İstatistik";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(942, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.listboxIstatistlik);
            this.Controls.Add(this.rdiobtn_YillikIstatistlik);
            this.Controls.Add(this.rdiobtn_AylikIstatistlik);
            this.Controls.Add(this.grpboxTest);
            this.Controls.Add(this.btn_İstatistlikGoster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbbox_Yillik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbbox_Aylik);
            this.Name = "frm_AnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frm_AnaSayfa_Load);
            this.grpboxTest.ResumeLayout(false);
            this.grpboxTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_TestYap;
        private System.Windows.Forms.RadioButton rdbtn_A;
        private System.Windows.Forms.RadioButton rdbtn_B;
        private System.Windows.Forms.RadioButton rdbtn_C;
        private System.Windows.Forms.RadioButton rdbtn_D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbbox_Aylik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbox_Yillik;
        private System.Windows.Forms.Button btn_İstatistlikGoster;
        private System.Windows.Forms.GroupBox grpboxTest;
        private System.Windows.Forms.RadioButton rdiobtn_AylikIstatistlik;
        private System.Windows.Forms.RadioButton rdiobtn_YillikIstatistlik;
        private System.Windows.Forms.ListBox listboxIstatistlik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}