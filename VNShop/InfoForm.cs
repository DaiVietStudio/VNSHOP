using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNShop.Controllers;
using VNShop.Models;

namespace VNShop
{
    public partial class InfoForm : XtraForm
    {
        private InfomationController infomationController = new InfomationController();
        public InfoForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ThongTinDonVi thongTinDonVi = new ThongTinDonVi();
            thongTinDonVi.TenDonVi = txtName.Text;
            thongTinDonVi.DiaChi = txtAddress.Text;
            thongTinDonVi.SoDienThoai = txtPhone.Text;
            thongTinDonVi.Email = txtEmail.Text;
            thongTinDonVi.Website = txtWebsite.Text;
           
            Response response = infomationController.update(thongTinDonVi);
            if (response.status)
            {
                XtraMessageBox.Show(response.message, response.message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(response.message, response.message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            ThongTinDonVi thongTinDonVi = infomationController.info();
            txtName.Text = thongTinDonVi.TenDonVi;
            txtAddress.Text = thongTinDonVi.DiaChi;
            txtPhone.Text = thongTinDonVi.SoDienThoai;
            txtEmail.Text = thongTinDonVi.Email;
            txtWebsite.Text = thongTinDonVi.Website;
        }
    }
}
