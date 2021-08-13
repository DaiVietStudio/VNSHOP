using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VNShop
{
    public partial class MainApp : DevExpress.XtraEditors.XtraForm
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void MainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUnit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Unit unit = new Unit();
           
            unit.ShowDialog();
        }

        public void loadData()
        {

        }

        private void btnStorage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Storage frmStorage = new Storage();
            frmStorage.ShowDialog();
        }

        private void btnProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Product product = new Product();
            product.ShowDialog();
        }
    }
}
