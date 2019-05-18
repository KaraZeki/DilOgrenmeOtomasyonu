using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DilOgrenmeApp.UI.WinForm
{
    public partial class frm_GenelSayfa : Form
    {
        public frm_GenelSayfa()
        {
            InitializeComponent();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_KelimeHavuzu KelimeHavuzu = new frm_KelimeHavuzu();
            KelimeHavuzu.MdiParent = this;
            KelimeHavuzu.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_AnaSayfa AnaSayfa = new frm_AnaSayfa();
            AnaSayfa.MdiParent = this;
            AnaSayfa.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_KelimeOgren KelimeOgren = new frm_KelimeOgren();
            KelimeOgren.MdiParent = this;
            KelimeOgren.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Kelimeİslemleri Kelimeİslemleri = new frm_Kelimeİslemleri();
            Kelimeİslemleri.MdiParent = this;
            Kelimeİslemleri.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_OgrenilecekKelimeler OgrenilecekKelimeler = new frm_OgrenilecekKelimeler();
            OgrenilecekKelimeler.MdiParent = this;
            OgrenilecekKelimeler.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_OgrendigimKelimeler OgrendigimKelimeler = new frm_OgrendigimKelimeler();
            OgrendigimKelimeler.MdiParent = this;
            OgrendigimKelimeler.Show();
        }
    }
}
