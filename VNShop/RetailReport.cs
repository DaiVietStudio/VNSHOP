using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using VNShop.Models;
using VNShop.Controllers;

namespace VNShop
{
    public partial class RetailReport : DevExpress.XtraReports.UI.XtraReport
    {
        private InfomationController infomationController = new InfomationController();

        public RetailReport(double totalQuanity, double totalPrice, string code, string date, string payment, string debit)
        {
            InitializeComponent();
            ThongTinDonVi info = infomationController.info();
            lblNameStore.Text = info.TenDonVi;
            lblAddress.Text = "Địa chỉ: " + info.DiaChi;
            lblPhone.Text = "Số điện thoại:" + info.SoDienThoai;
            lblCode.Text ="Số phiếu: "+ code;
            lblDate.Text ="Ngày: "+ date;
            lblPay.Text = payment.ToString();
            double check = double.Parse(debit);
            if(check < 0)
            {
                lblNameDebit.Text = "Nợ: ";
                lblDebit.Text = Math.Abs(check).ToString();
            }
            else
            {
                lblNameDebit.Text = "Tiền thừa: ";
                lblDebit.Text = Math.Abs(check).ToString();

            }
            
            lblTotalQuanity.Text = totalQuanity.ToString();
            lblTotal.Text = totalPrice.ToString();
        }

        private void TopMargin_AfterPrint(object sender, EventArgs e)
        {


        }
    }
}
