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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        private SignUpController SignUpController = new SignUpController();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            taiKhoan.TenDangNhap = txtUserName.Text;
            taiKhoan.MatKhau = txtPassword.Text;
            Response response = SignUpController.login(taiKhoan);
            if(response.status == true)
            {
                this.Hide();
                MainApp main = new MainApp();
                main.Show();
            }
            else
            {
                XtraMessageBox.Show(response.message, response.message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
