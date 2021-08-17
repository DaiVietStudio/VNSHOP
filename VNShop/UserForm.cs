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
using VNShop.Models;
using VNShop.Controllers;
using VNShop.Validator;
using FluentValidation.Results;

namespace VNShop
{
    public partial class UserForm : XtraForm
    {
        UserController userController = new UserController();
        private long userId;
        public UserForm(long userId = 0)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NhanVien user = new NhanVien();
            user.HoVaTen = txtName.Text;
            user.GioiTinh = chkMale.Checked ? 0 : 1;
            user.SoDienThoai = txtPhone.Text;
            user.DiaChi = txtAddress.Text;
            UserValidator userValidator = new UserValidator();
            ValidationResult validationResult = userValidator.Validate(user);
            if (!validationResult.IsValid)
            {
                foreach (var failer in validationResult.Errors)
                {
                    XtraMessageBox.Show(failer.ErrorMessage, failer.ErrorMessage, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                if(userId == 0)
                {
                    Response response = userController.save(user);

                    if (response.status)
                    {
                        XtraMessageBox.Show(response.message, response.message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;

                    }
                    else
                    {

                        XtraMessageBox.Show(response.message, response.message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Response response = userController.update(user, userId);
                    if (response.status)
                    {
                        XtraMessageBox.Show(response.message, response.message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        XtraMessageBox.Show(response.message, response.message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if(userId > 0)
            {
                NhanVien user = userController.userDetail(userId);
                txtName.Text = user.HoVaTen;
                txtAddress.Text = user.DiaChi;
                txtPhone.Text = user.SoDienThoai;
                if(user.GioiTinh == 0)
                {
                    chkMale.Checked = true;
                }
                else
                {
                    chkMale.Checked = false;

                }
            }
        }
    }
}
