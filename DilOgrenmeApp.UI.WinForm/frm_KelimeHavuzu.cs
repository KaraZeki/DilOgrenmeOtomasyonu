using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DilOgrenmeApp.BLL;
using DilOgrenmeApp.Entity;

namespace DilOgrenmeApp.UI.WinForm
{
    public partial class frm_KelimeHavuzu : Form
    {
        public frm_KelimeHavuzu()
        {
            InitializeComponent();
        }

        private void frm_KelimeHavuzu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dilOgrenmeOtomasyonDataSet1.KelimeHavuzu' table. You can move, or remove it, as needed.
            this.kelimeHavuzuTableAdapter1.Fill(this.dilOgrenmeOtomasyonDataSet1.KelimeHavuzu);
            // TODO: This line of code loads data into the 'dilOgrenmeOtomasyonDataSet.KelimeHavuzu' table. You can move, or remove it, as needed.
           
           
        }
    }
}
