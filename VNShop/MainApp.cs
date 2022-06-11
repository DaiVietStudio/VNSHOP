using DevExpress.XtraEditors;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
            backup();
            
        }



        private void btnQuote_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Quote quote = new Quote();
            quote.ShowDialog();
        }

        private void btnBackup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            backup();
        }

        private static void Backup_Completed(object sender, ServerMessageEventArgs args)
        {
            XtraMessageBox.Show("Đã sao lưu thành công", "Đã sao lưu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backup()
        {
            string server = System.Configuration.ConfigurationManager.AppSettings["server"];
            string username = System.Configuration.ConfigurationManager.AppSettings["username"];
            string password = System.Configuration.ConfigurationManager.AppSettings["password"];

            Server dbServer = new Server(new ServerConnection(server, username, password));
            Backup bkpDBFull = new Backup();
            bkpDBFull.Action = BackupActionType.Database;
            bkpDBFull.Database = "QLBH";
            bkpDBFull.Devices.AddDevice(System.Configuration.ConfigurationManager.AppSettings["pathbackup"] + @"QLBH.bak", DeviceType.File);
            bkpDBFull.BackupSetName = "QLBH database Backup";
            bkpDBFull.BackupSetDescription = "QLBH database - Full Backup";
            bkpDBFull.ExpirationDate = DateTime.Today.AddDays(20);
            bkpDBFull.Initialize = false;
            bkpDBFull.Complete += Backup_Completed;
            bkpDBFull.SqlBackup(dbServer);

       
        }
    }
}
