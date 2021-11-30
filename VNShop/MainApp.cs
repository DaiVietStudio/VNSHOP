using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNShop.Controllers;
using VNShop.Models;

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

        private void btnUser_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            User user = new User();
            user.ShowDialog();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            SaleController saleController = new SaleController();
            txtHello.Caption = "Xin chào " + Program.nameUser;
            chartControlMain.DataSource = saleController.chart();
        }

        private void btnCustomer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Customer customer = new Customer();
            customer.ShowDialog();
        }

        private void btnRetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RetailForm retailForm = new RetailForm();
            retailForm.ShowDialog();
        }

        private void btnWhole_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WholeForm wholeForm = new WholeForm();
            wholeForm.ShowDialog();
        }

        private void btnRecpiect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.ShowDialog();
        }

        private void btnInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            InfoForm infoForm = new InfoForm();
            infoForm.ShowDialog();
        }

        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

       

        private void btnQuote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Quote quote = new Quote();
            quote.ShowDialog();
        }
    }
}
