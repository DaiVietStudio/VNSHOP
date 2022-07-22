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

namespace VNShop
{
    public partial class AddUnit : DevExpress.XtraEditors.XtraForm
    {
        public delegate void refresh(Models.UnitList unitList, bool edit = false, long unitId = 0);
        public refresh callBack;
        private Models.UnitList UnitListEdit;

        public AddUnit(Models.UnitList unitList = null)
        {
            InitializeComponent();
            UnitListEdit = unitList;
            List<Models.DonViTinh> donViTinhs = new Controllers.UnitController().listUnit();
            cbUnit.Properties.DisplayMember = "TenDonVi";
            cbUnit.Properties.ValueMember = "id";
            cbUnit.Properties.KeyMember = "id";
            cbUnit.Properties.DataSource = donViTinhs;

            if (UnitListEdit != null)
            {
                cbUnit.EditValue = UnitListEdit.id;
                txtRetail.EditValue = UnitListEdit.GiaLe;
                txtWhole.EditValue = UnitListEdit.GiaSi;
                chkPrimary.Checked = UnitListEdit.Chinh;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(txtRetail.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Hãy nhập giá bán lẻ", "Nhập giá bán lẻ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (txtWhole.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Hãy nhập giá bán sỉ", "Nhập giá bán sỉ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (cbUnit.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Chọn đơn vị tính", "Chọn đơn vị tính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                VNShop.Models.UnitList unitList = new Models.UnitList();
                unitList.TenDonVi = cbUnit.Text;
                unitList.id = int.Parse(cbUnit.EditValue.ToString());
                unitList.GiaLe = double.Parse(txtRetail.EditValue.ToString());
                unitList.GiaSi = double.Parse(txtWhole.EditValue.ToString());
                unitList.Chinh = chkPrimary.Checked;
                callBack(unitList, (UnitListEdit == null ? false : true), (UnitListEdit != null ? UnitListEdit.id : 0));
                this.Close();
            }
            
        }

        private void AddUnit_Load(object sender, EventArgs e)
        {
        }
    }
}