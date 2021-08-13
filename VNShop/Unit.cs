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
    public partial class Unit : XtraForm
    {

        private UnitController unitController = new UnitController();
        private List<DonViTinh> listUpdate = new List<DonViTinh>();

        public Unit()
        {
            InitializeComponent();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UnitForm unitForm = new UnitForm(this);
            if (unitForm.ShowDialog() == DialogResult.OK)
            {
                loadData();
            }
        }

        public void loadData()
        {
            List<DonViTinh> dataSource = unitController.listUnit();
            gridControlUnit.DataSource = dataSource;
        }

        private void Unit_Load(object sender, EventArgs e)
        {
            loadData();
            btnSave.Enabled = false;
            gridUnit.OptionsBehavior.Editable = false;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridUnit.OptionsBehavior.Editable = true;
            btnSave.Enabled = true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Response response = unitController.update(listUpdate);
            if (response.status)
            {
                listUpdate.Clear();
                loadData();
                XtraMessageBox.Show(response.message, response.message, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show(response.message, response.message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gridUnit_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DonViTinh donVi = e.Row as DonViTinh;
            DonViTinh donViTinh = new DonViTinh();
            donViTinh.TenDonVi = donVi.TenDonVi;
            donViTinh.MoTa = donVi.MoTa;
            donViTinh.id = donVi.id;            
            listUpdate.Add(donViTinh);

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa những đơn vị này không?", "Xóa đơn vị", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK)
            {
                int[] row = gridUnit.GetSelectedRows();

                List<long> listDelete = new List<long>();
                foreach (int rowHandle in row)
                {
                    if (gridUnit.IsValidRowHandle(rowHandle))
                    {
                        var data = gridUnit.GetRow(rowHandle) as DonViTinh;
                        listDelete.Add(data.id);
                    }
                }

                    if (row.Length > 0)
                {
                    Response response = unitController.delete(listDelete);
                    if (response.status)
                    {
                        loadData();
                        MessageBox.Show("Đã xóa đơn vị", "Đã xóa đơn vị", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đơn vị muốn xóa?", "Chọn đơn vị", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
