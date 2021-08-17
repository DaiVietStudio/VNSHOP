using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class Receipt : XtraForm
    {
        private SaleController saleController = new SaleController();
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

            gridControlReceipt.DataSource = saleController.receiptList();
        }

        private void gridViewReceipt_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            long id = (long)(sender as GridView).GetFocusedRowCellValue("id");

            gridControlDetail.DataSource = saleController.detailReceipt(id);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa phiếu này không", "Có muốn xóa phiếu không", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int[] row = gridViewReceipt.GetSelectedRows();
                long id = (long)gridViewReceipt.GetRowCellValue(row[0], "id");

                Response response = saleController.delete(id);

                if (response.status)
                {
                    gridControlReceipt.DataSource = saleController.receiptList();
                    gridControlDetail.DataSource = null;
                }
            }
        }
    }
}
