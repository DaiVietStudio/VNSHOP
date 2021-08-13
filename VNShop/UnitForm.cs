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
    public partial class UnitForm : XtraForm
    {
        private Unit unitForm;

        private UnitController unitController = new UnitController();

        public UnitForm(Unit unitForm)
        {
            InitializeComponent();
            this.unitForm = unitForm;
        }

        private void UnitForm_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DonViTinh donViTinh = new DonViTinh();
            donViTinh.TenDonVi = txtName.Text.ToUpper();
            donViTinh.MoTa = txtDecription.Text.ToUpper();
            Response response = unitController.store(donViTinh);
            if (response.status == true)
            {
                XtraMessageBox.Show(response.message, response.message);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                XtraMessageBox.Show(response.message, response.message);

            }
        }
    }
}
