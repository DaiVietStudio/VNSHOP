using DevExpress.XtraEditors;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNShop.Controllers;
using VNShop.Models;
namespace VNShop
{
    public partial class Product : XtraForm
    {
        private ProductController productController = new ProductController();
        public Product()
        {
            InitializeComponent();
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductForm productForm = new ProductForm();
            if(productForm.ShowDialog() == DialogResult.OK)
            {
                loadData();
            }
        }

        private void loadData()
        {
            List<SanPham> list = productController.productList();
            girdProduct.DataSource = list;
        }

        private void Product_Load(object sender, EventArgs e)
        {
            loadData();
           
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn xóa những sản phẩm này không", "Xóa sản phẩm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int[] row = gridView1.GetSelectedRows();
                List<long> listDelete = new List<long>() ;
                foreach(int rowHandle in row)
                {
                    if (gridView1.IsValidRowHandle(rowHandle))
                    {
                        var data = gridView1.GetRow(rowHandle) as SanPham;
                        listDelete.Add(data.id);
                    }
                }
                Response result = productController.delete(listDelete);
                if (result.status)
                {
                    XtraMessageBox.Show(result.message, result.message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    XtraMessageBox.Show(result.message, result.message, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] row = gridView1.GetSelectedRows();
            if(row.Length == 0 || row.Length > 1)
            {
                XtraMessageBox.Show("Vui lòng chọn một sản phẩm muốn sửa", "Chọn một sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var data = gridView1.GetRow(row[0]) as SanPham;
                ProductForm productForm = new ProductForm(data.id);
                if (productForm.ShowDialog() == DialogResult.OK)
                {
                    loadData();
                }
            }
           
        }

        private void btnImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file excel";
            openFileDialog.Filter = "*.xlsx";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
            }
        }

        private bool import(string fileName)
        {
            List<string> unitList = new List<string>();

            FileStream fileStream = new FileStream(fileName, FileMode.Open);
            XSSFWorkbook wb = new XSSFWorkbook(fileStream);
            // Lấy sheet đầu tiên
            ISheet sheet = wb.GetSheetAt(0);
            int enity = 1;

        
            return false;
        }
    }
}
