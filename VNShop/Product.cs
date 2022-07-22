using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using NPOI.HSSF.UserModel;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VNShop.Controllers;
using VNShop.Models;
namespace VNShop
{
    public partial class Product : XtraForm
    {
        private ProductController productController = new ProductController();
        private UnitController unitController = new UnitController();
        private List<SanPham> list = new List<SanPham>();
        private List<ProductGrid> grid = new List<ProductGrid>();
        public Product()
        {
            InitializeComponent();
            
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.callback = loadData;
            productForm.ShowDialog();
        }

        private void loadData()
        {
            list = productController.productList();
            grid.Clear();
            list.ForEach(item =>
            {
                DonViTinh_SanPham donViTinh = item.DonViTinh_SanPham.FirstOrDefault(s => s.Selected == true);
                if (donViTinh != null)
                {
                    grid.Add(new ProductGrid()
                    {
                        id = item.id,
                        TenSanPham = item.TenSanPham,
                        MaSanPham = item.MaSanPham,
                        DonVi = (donViTinh.DonViTinh1 != null) ? donViTinh.DonViTinh1.TenDonVi : "",
                        GiaLe = (double)donViTinh.GiaLe,
                        GiaSi = (double)donViTinh.GiaSi,
                    });
                }
                else
                {
                    grid.Add(new ProductGrid()
                    {
                        id = item.id,
                        TenSanPham = item.TenSanPham,
                        MaSanPham = item.MaSanPham,
                        DonVi = "",
                        GiaLe = 0,
                        GiaSi = 0,
                    });
                }
                
            });
           
            girdProduct.RefreshDataSource();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            girdProduct.DataSource = grid;
            loadData();

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa những sản phẩm này không", "Xóa sản phẩm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int[] row = gridView1.GetSelectedRows();
                List<long> listDelete = new List<long>();
                foreach (int rowHandle in row)
                {
                    if (gridView1.IsValidRowHandle(rowHandle))
                    {
                        var data = gridView1.GetRow(rowHandle) as ProductGrid;
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
            

        }

        private void btnImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file excel";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Thread t = new Thread(() =>
                {
                    bool success = import(openFileDialog.FileName);

                });
                t.Start();
                loadData();
            }
        }

        private bool import(string fileName)
        {
            List<string> unitList = new List<string>();

            FileStream fileStream = new FileStream(fileName, FileMode.Open);
            HSSFWorkbook wb = new HSSFWorkbook(fileStream);
            // Lấy sheet đầu tiên
            ISheet sheet = wb.GetSheetAt(0);
            int row = 2;
            int enity = 0;
            MethodInvoker methodInvoker = new MethodInvoker(() =>
      labelControlStatus.Text = "Đang nhập " + enity + " Sản phẩm");
            while (sheet.GetRow(row).GetCell(0).StringCellValue.ToUpper() != "END")
            {
                var nowRow = sheet.GetRow(row);
                SanPham product = new SanPham();
                product.MaSanPham = sheet.GetRow(row).GetCell(0).StringCellValue;
                product.TenSanPham = sheet.GetRow(row).GetCell(1).StringCellValue.ToUpper();
                // Check unit exist in db or unit list
                string nameUnit = nowRow.GetCell(2).StringCellValue.ToUpper();

                long unit = unitController.checkUnit(nameUnit);
                if (unit != 0)
                {
                    product.DonViTinh = unit;
                }
                else
                {
                    // Check unit exist in unit list
                    if (!unitList.Contains(nameUnit))
                    {
                        DonViTinh DVT = new DonViTinh();
                        DVT.TenDonVi = nameUnit.ToUpper();
                        DVT.MoTa = nameUnit.ToUpper();
                        Response response = unitController.store(DVT);
                        if (response.status)
                        {
                            product.DonViTinh = DVT.id;
                        }
                    }
                }

                product.KichHoat = true;
               
                product.QuanLyTonKho = 0;
                productController.save(product);
                enity++;
                row++;
                labelControlStatus.Invoke(methodInvoker);
            }
            return true;
        }

        private void labelControlStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //string folder = "";
            //FolderBrowserDialog dialog = new FolderBrowserDialog();
            //DialogResult result = dialog.ShowDialog();
            //if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
            //{
            //    folder = dialog.SelectedPath;
            //    //Response export = productController.exportExcel(folder);
            //    //if (export.status)
            //    //{
            //    //    XtraMessageBox.Show(export.message);
            //    //}
            //    //else
            //    //{
            //    //    XtraMessageBox.Show(export.message);

            //    //}


            //}

            ExportAll exportAll = new ExportAll();
            ReportPrintTool tool = new ReportPrintTool(exportAll);
            tool.ShowPreview();



        }

        private void btnItemEdit_Click(object sender, EventArgs e)
        {
            ProductGrid obj =(ProductGrid) gridView1.GetFocusedRow();
            ProductForm productForm = new ProductForm(obj.id);
            productForm.callback = loadData;
            productForm.ShowDialog();

        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
    }
}
