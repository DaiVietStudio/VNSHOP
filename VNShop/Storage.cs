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
    public partial class Storage : XtraForm
    {
        private StorageController storageController = new StorageController();
        private List<KhoHang> listEdit = new List<KhoHang>();
        public Storage()
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
           
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            StorageForm storageForm = new StorageForm();
            btnUpdate.Enabled = false;
            if(storageForm.ShowDialog()== DialogResult.OK)
            {
                loadData();
            }
        }

        private void Storage_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            List<KhoHang> datasource = storageController.storageList();
            gridStorage.DataSource = datasource;
            gridViewStorage.OptionsBehavior.Editable = false;

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnUpdate.Enabled = true;
            gridViewStorage.OptionsBehavior.Editable = true;

        }

        private void gridViewStorage_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            KhoHang objectKhoHang = e.Row as KhoHang;
            listEdit.Add(objectKhoHang);

        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Response res = storageController.update(listEdit);
            if (res.status)
            {
                XtraMessageBox.Show(res.message, res.message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] rows = gridViewStorage.GetSelectedRows();
            if(XtraMessageBox.Show("Bạn có chắc chắn xóa không", "Có muốn xóa không", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK)
            {
                Response response = storageController.delete(rows);
                if (response.status)
                {
                    loadData();
                }
            }
        }
    }
}
