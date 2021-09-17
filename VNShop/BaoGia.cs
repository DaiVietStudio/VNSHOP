using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using VNShop.Controllers;
using VNShop.Models;

namespace VNShop
{
    public partial class BaoGia : DevExpress.XtraReports.UI.XtraReport
    {
        private InfomationController infomationController = new InfomationController();
        public BaoGia(double totalQuanity, double totalPrice, string code, string date)
        {
            InitializeComponent();
            ThongTinDonVi info = infomationController.info();
            lblNameStore.Text = info.TenDonVi;
            lblAddress.Text = "Địa chỉ: " + info.DiaChi;
            lblPhone.Text = "Số điện thoại:" + info.SoDienThoai;
            lblCode.Text = "Số phiếu: " + code;
            lblDate.Text = "Ngày: " + date;
            
            lblTotalQuanity.Text = totalQuanity.ToString();
            lblTotal.Text = totalPrice.ToString();
        }

    }
}
