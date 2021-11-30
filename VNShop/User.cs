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

namespace VNShop
{
    public partial class User : XtraForm
    {
        private UserController userController = new UserController();
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            gridControlUser.DataSource = userController.userList();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserForm userForm = new UserForm();
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                loadData();
            }
        }

        private void gridViewUser_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "GioiTinh")
            {
                if(e.Value != null)
                {
                    int sex = (int)e.Value;
                    if (sex == 0)
                    {
                        e.DisplayText = "Nam";
                    }
                    else
                    {
                        e.DisplayText = "Nữ";
                    }
                }
              

            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] row = gridViewUser.GetSelectedRows();
            var user = gridViewUser.GetRow(row[0]) as NhanVien;
            UserForm userForm = new UserForm(user.id);
            if (userForm.ShowDialog() == DialogResult.OK)
            {
                loadData();
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Xác nhận xóa nhân viên", "Xóa nhân viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int[] row = gridViewUser.GetSelectedRows();
                var user = gridViewUser.GetRow(row[0]) as NhanVien;
                Response response = userController.delete(user.id);
                if (response.status)
                {
                    loadData();
                }
            }
        }
    }
}
