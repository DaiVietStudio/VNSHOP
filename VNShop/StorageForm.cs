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
    public partial class StorageForm : XtraForm
    {
        private StorageController controller = new StorageController();
        public StorageForm()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhoHang khoHang = new KhoHang();
            khoHang.TenKho = txtName.Text;
            Response response = controller.save(khoHang);
            if (response.status)
            {
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
