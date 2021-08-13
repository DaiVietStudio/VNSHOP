using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNShop.Models;
using VNShop.Controllers;
using DevExpress.XtraEditors;

namespace VNShop
{
    public partial class SignUp : DevExpress.XtraEditors.XtraForm
    {
        private SignUpController SignUpController = new SignUpController();
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ThongTinDonVi thongTinDonVi = new ThongTinDonVi();
            thongTinDonVi.TenDonVi = txtName.Text;
            thongTinDonVi.DiaChi = txtAddress.Text;
            thongTinDonVi.SoDienThoai = txtPhone.Text;
            thongTinDonVi.Email = txtEmail.Text;
            thongTinDonVi.Website = txtWebsite.Text;
            thongTinDonVi.KyTen = txtSign.Text;

            // Account

            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.TenDangNhap = txtUserName.Text;
            taiKhoan.MatKhau = txtPassword.Text;

            NhanVien nhanVien = new NhanVien();
            nhanVien.HoVaTen = txtNameUser.Text;

            Response result = SignUpController.signUp(thongTinDonVi, taiKhoan, nhanVien);
            if (result.status == true)
            {
                if(XtraMessageBox.Show(result.message, "Đăng ký thành công", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                XtraMessageBox.Show(result.message, "Xảy ra lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtName_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
            XtraMessageBox.Show("Tên đơn vị không được để trống", "Lỗi");

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            string value = (sender as TextEdit).Text;
            if (value == "")
            {
                e.Cancel = true;

            }
        }
    }
}
