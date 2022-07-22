using AutoUpdaterDotNET;
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
            string now = DateTime.Now.ToShortDateString();
            txtHello.Caption = "Phiên làm việc ngày " + now;
            chartControlMain.DataSource = saleController.chart();
            new ResourceController().setUser();

            // Check update
            //System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            //System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            //AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
            //string version = fvi.FileVersion;
            //AutoUpdater.DownloadPath = "update";
            //System.Timers.Timer timer = new System.Timers.Timer
            //{
            //    Interval = 15 * 60 * 1000,
            //    SynchronizingObject = this
            //};
            //timer.Elapsed += delegate
            //{
            //    AutoUpdater.Start("https://lightnovelvietsub.000webhostapp.com/update.xml");
            //};
            //timer.Start();

        }

        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args.IsUpdateAvailable)
            {
                DialogResult dialogResult;
                dialogResult =
                        MessageBox.Show(
                            $@"Bạn ơi, phần mềm của bạn có phiên bản mới {args.CurrentVersion}. Phiên bản bạn đang sử dụng hiện tại  {args.InstalledVersion}. Bạn có muốn cập nhật phần mềm không?", @"Cập nhật phần mềm",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

                if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
                {
                    try
                    {
                        if (AutoUpdater.DownloadUpdate(args))
                        {
                            Application.Exit();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Phiên bản bạn đang sử dụng đã được cập nhật mới nhất.", @"Cập nhật phần mềm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void btnChuyenDoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductController productController = new ProductController();
            if (productController.Convert())
            {
                XtraMessageBox.Show("Đã chuyển đổi dữ liệu thành công");
            }
        }
    }
}
