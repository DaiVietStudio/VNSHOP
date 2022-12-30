using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraReports.UI;
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
using VNShop.Utils;
namespace VNShop
{
    public partial class RetailForm : XtraForm
    {

        private Code code = new Code();
        private CustomerController customerController = new CustomerController();
        private ProductController productController = new ProductController();
        private UnitController unitController = new UnitController();
        private List<DetailCart> detailCarts = new List<DetailCart>();
        private SaleController saleController = new SaleController();

        private List<SanPham> sanPhams;

        private QLBHEntities context = new QLBHEntities();
        public RetailForm()
        {
            InitializeComponent();
        }



        private void RetailForm_Load(object sender, EventArgs e)
        {
            
            getCode();
            lookupCustomer.Properties.DataSource = customerController.customerList();
            lookupCustomer.EditValue = (long)1;
            loadProduct();
            gridControlCart.DataSource = detailCarts;
        }
        private void getCode()
        {
            txtCode.Text = code.genarateCode("BL");
        }

        private void loadProduct()
        {
            sanPhams = productController.productList();

        }

        private void gridViewCart_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {

            if (e.Column.FieldName == "id")
            {
                RepositoryItemLookUpEdit lookUpEditProducts = new RepositoryItemLookUpEdit();
                int rowHandle = e.RowHandle;
                lookUpEditProducts.DisplayMember = "TenSanPham";
                lookUpEditProducts.ValueMember = "id";
                lookUpEditProducts.DataSource = sanPhams;
                e.RepositoryItem = lookUpEditProducts;
            }


            if (e.Column.FieldName == "DonViTinh")
            {
                RepositoryItemLookUpEdit lookUpEditUnits = new RepositoryItemLookUpEdit();
                int rowHandle = e.RowHandle;

                long idProduct = (long)gridViewCart.GetRowCellValue(rowHandle, "id");
                List<DonViTinh> listUnit = unitController.listUnitByProduct(idProduct);
                lookUpEditUnits.DataSource = listUnit;
                lookUpEditUnits.DisplayMember = "TenDonVi";
                lookUpEditUnits.ValueMember = "id";
                // Colum Name
                DevExpress.XtraEditors.Controls.LookUpColumnInfo colName = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
                colName.Caption = "Tên đơn vị";
                colName.Visible = true;
                colName.FieldName = "TenDonVi";
                // column id

                DevExpress.XtraEditors.Controls.LookUpColumnInfo colId = new DevExpress.XtraEditors.Controls.LookUpColumnInfo();
                colId.Caption = "id";
                colId.Visible = false;
                colId.FieldName = "id";

                lookUpEditUnits.Columns.Add(colId);
                lookUpEditUnits.Columns.Add(colName);
                e.RepositoryItem = lookUpEditUnits;

                lookUpEditUnits.EditValueChanged += LookUpEditUnits_EditValueChanged;

            }
        }

        private void LookUpEditUnits_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit repositoryItemLookUpEdit = (LookUpEdit)sender;
            int[] row = gridViewCart.GetSelectedRows();
            long product = (long)gridViewCart.GetRowCellValue(row[0], "id");
            double quanity = (double)gridViewCart.GetRowCellValue(row[0], "SoLuong");
            long unit = (long)repositoryItemLookUpEdit.EditValue;
            double price = unitController.getPriceProduct(product, unit, 1);
            int position = detailCarts.FindIndex(x => x.id == product);
            detailCarts[position].GiaBan = price;
            detailCarts[position].ThanhTien = price * quanity;
            detailCarts[position].TenDonVi = repositoryItemLookUpEdit.Text;
            gridControlCart.RefreshDataSource();
            calcTotal();
        }

        private void txtQuanity_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            if (textEdit.EditValue.ToString() != "")
            {
                int[] row = gridViewCart.GetSelectedRows();
                double price = (double)gridViewCart.GetRowCellValue(row[0], "GiaBan");
                double quanity = double.Parse(textEdit.EditValue.ToString());
                long product = (long)gridViewCart.GetRowCellValue(row[0], "id");
                int position = detailCarts.FindIndex(x => x.id == product);
                detailCarts[position].SoLuong = quanity;
                detailCarts[position].ThanhTien = quanity * price;
                gridControlCart.RefreshDataSource();
                calcTotal();
            }

        }

        private void calcTotal()
        {
            double totalQuanity = 0;
            double totalPrice = 0;
            foreach (DetailCart item in detailCarts)
            {
                totalQuanity += (double)item.SoLuong;
                totalPrice += (double)item.GiaBan * (double)item.SoLuong;
            }
            txtTotalQuanity.Text = totalQuanity.ToString();
            txtTotal.Text = totalPrice.ToString();
            txtMoneyReciver.Text = totalPrice.ToString();
        }

        private void txtPrice_EditValueChanged(object sender, EventArgs e)
        {
          

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int[] row = gridViewCart.GetSelectedRows();
            long product = (long)gridViewCart.GetRowCellValue(row[0], "id");
            int position = detailCarts.FindIndex(x => x.id == product);
            detailCarts.Remove(detailCarts[position]);
            gridControlCart.RefreshDataSource();
            calcTotal();
        }

        private void btnPaymentWithoutPrint_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            PhieuBanHang phieuBanHang = new PhieuBanHang();
            phieuBanHang.KhachHang = long.Parse(lookupCustomer.EditValue.ToString());
            phieuBanHang.MaSo = txtCode.Text;
            phieuBanHang.NgayNhap = current;
            phieuBanHang.NhanVien = Program.idUser;
            phieuBanHang.Loai = 1;

            List<ChiTietPhieuBanHang> chiTietPhieuBanHangs = new List<ChiTietPhieuBanHang>();
            foreach (DetailCart item in detailCarts)
            {
                ChiTietPhieuBanHang detail = new ChiTietPhieuBanHang();
                detail.DonViTinh = item.TenDonVi;
                detail.SanPham = item.id;
                detail.SoLuong = item.SoLuong;
                detail.GiaBan = item.GiaBan;
                chiTietPhieuBanHangs.Add(detail);
            }

            ChiTietPhieuBanHang check = chiTietPhieuBanHangs.FirstOrDefault(s => s.GiaBan == 0);
            if (check == null)
            {
                Response response = saleController.save(phieuBanHang, chiTietPhieuBanHangs);

                if (response.status)
                {
                    txtCode.Text = code.genarateCode("BL");
                    txtTotalQuanity.Text = "0";
                    txtTotal.Text = "0";
                    detailCarts.Clear();
                    gridControlCart.RefreshDataSource();
                    txtMoneyReciver.Text = "0";
                    txtExcessCash.Text = "0";
                    txtProduct.EditValue = null;
                    XtraMessageBox.Show("Đã thanh toán hoàn tất hóa đơn", "Thanh toán hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                XtraMessageBox.Show("Đơn hàng có sản phẩm chưa tính tiền vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void txtMoneyReciver_EditValueChanged(object sender, EventArgs e)
        {
            if (txtMoneyReciver.Text != "" && txtTotal.Text != "")
                txtExcessCash.Text = (double.Parse(txtMoneyReciver.Text) - double.Parse(txtTotal.Text)).ToString();
        }

        private void btnPaymentPrint_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            PhieuBanHang phieuBanHang = new PhieuBanHang();
            phieuBanHang.KhachHang = long.Parse(lookupCustomer.EditValue.ToString());
            phieuBanHang.MaSo = txtCode.Text;
            phieuBanHang.NgayNhap = current;
            phieuBanHang.NhanVien = Program.idUser;
            phieuBanHang.Loai = 1;

            List<ChiTietPhieuBanHang> chiTietPhieuBanHangs = new List<ChiTietPhieuBanHang>();
            foreach (DetailCart item in detailCarts)
            {
                ChiTietPhieuBanHang detail = new ChiTietPhieuBanHang();
                detail.DonViTinh = item.TenDonVi;
                detail.SanPham = item.id;
                detail.SoLuong = item.SoLuong;
                detail.GiaBan = item.GiaBan;
                chiTietPhieuBanHangs.Add(detail);
            }
            ChiTietPhieuBanHang check = chiTietPhieuBanHangs.Where(s => s.GiaBan == 0).FirstOrDefault();
            if (check == null)
            {
                Response response = saleController.save(phieuBanHang, chiTietPhieuBanHangs);

                if (response.status)
                {
                    double totalQuanity = 0, totalPrice = 0;
                    foreach (DetailCart item in detailCarts)
                    {

                        totalQuanity += (double)item.SoLuong;
                        totalPrice += (double)item.ThanhTien;
                    }

                    HoaDon retailReport = new HoaDon(totalQuanity, totalPrice, txtCode.Text, DateTime.Now.ToShortDateString(), txtMoneyReciver.Text, txtExcessCash.Text);

                    retailReport.DataSource = createData();

                    ReportPrintTool tool = new ReportPrintTool(retailReport);
                    tool.ShowPreview();
                    txtCode.Text = code.genarateCode("BL");
                    txtTotalQuanity.Text = "0";
                    txtTotal.Text = "0";
                    detailCarts.Clear();
                    gridControlCart.RefreshDataSource();
                    txtMoneyReciver.Text = "0";
                    txtExcessCash.Text = "0";
                    txtProduct.EditValue = null;

                }
            }
            else
            {
                XtraMessageBox.Show("Đơn hàng có sản phẩm chưa có giá bán vui lòng kiểm tra lại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private List<DetailPrint> createData()
        {
            List<DetailPrint> detailPrints = new List<DetailPrint>();
            foreach (DetailCart item in detailCarts)
            {
                DetailPrint itemPrint = new DetailPrint();
                itemPrint.Name = item.TenSanPham;
                itemPrint.Unit = item.TenDonVi;
                itemPrint.Quanity = (double)item.SoLuong;
                itemPrint.Price = (double)item.GiaBan;
                itemPrint.Total = (double)item.ThanhTien;
                detailPrints.Add(itemPrint);
            }
            return detailPrints;
        }



        private void gridViewCart_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "GiaBan")
            {
                if (e.Value.ToString() != "")
                {
                    int[] row = gridViewCart.GetSelectedRows();
                    double quanity = (double)gridViewCart.GetRowCellValue(row[0], "SoLuong");

                    double price = double.Parse(e.Value.ToString());
                    long product = (long)gridViewCart.GetRowCellValue(row[0], "id");
                    int position = detailCarts.FindIndex(x => x.id == product);
                    detailCarts[position].SoLuong = quanity;
                    detailCarts[position].ThanhTien = quanity * price;
                    gridControlCart.RefreshDataSource();
                    calcTotal();
                }

            }

        }

        private void txtProduct_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
           
        }

        private void txtProduct_EditValueChanged(object sender, EventArgs e)
        {

        }
        // tham so kieu nhap la type neu type = 0 thi la nhap barcode con la 1 thi la chon san pham
        private void addCart(dynamic barCode,int type = 0)
        {
            if (barCode != null)
            {
                bool checkExist = false;
                if(type == 0)
                {
                  checkExist =   detailCarts.Exists(x => x.MaSanPham == (string)barCode);
                }
                else
                {
                    checkExist = detailCarts.Exists(x => x.id == long.Parse(barCode));

                }

                if (checkExist)
                {
                    int position = detailCarts.FindIndex(x => x.MaSanPham == barCode || x.id == long.Parse(barCode));
                    if (position != -1)
                    {
                        detailCarts[position].SoLuong++;
                        detailCarts[position].ThanhTien = detailCarts[position].SoLuong * detailCarts[position].GiaBan;
                    }

                }
                else
                {
                    //loadProduct();
                   
                    SanPham checkId = null;
                   
                    if (type == 1)
                    {
                        checkId = sanPhams.Where(s => s.id == long.Parse(barCode)).FirstOrDefault();
                    }
                    else
                    {
                        checkId = sanPhams.Where(s => s.MaSanPham == barCode).FirstOrDefault();
                    }
                   

                    if (checkId != null)
                    {
                        addItemCart(barCode, type);
                    }
                    else
                    {
                        ProductForm productForm = new ProductForm(barCode);
                        DialogResult result = productForm.ShowDialog();
                    }

                }

                gridControlCart.RefreshDataSource();
                calcTotal();
                txtProduct.EditValue = null;
            }
        }

        private void addItemCart(string barCode, int type = 0)
        {
            SanPham sanPham = null;
            //loadProduct();
            if (type == 1)
            {
                sanPham = sanPhams.Where(x => x.id == long.Parse(barCode)).FirstOrDefault();

            }
            else if(type == 0)
            {
                sanPham = sanPhams.Where(x => x.MaSanPham == barCode).FirstOrDefault();
            }
            
            if (sanPham != null)
            {
                DonViTinh_SanPham unit = sanPham.DonViTinh_SanPham.Where(s => s.Selected == true).FirstOrDefault();

                DetailCart itemCart = new DetailCart();
                itemCart.id = sanPham.id;
                itemCart.MaSanPham = sanPham.MaSanPham;
                itemCart.DonViTinh = (long)unit.DonViTinh;
                itemCart.TenDonVi = unit.DonViTinh1.TenDonVi;
                itemCart.TenSanPham = sanPham.TenSanPham;
                itemCart.SoLuong = 1;
                itemCart.GiaBan = unit.GiaLe;
                itemCart.ThanhTien = 1 * unit.GiaLe;
                detailCarts.Add(itemCart);
            }
            else
            {
                XtraMessageBox.Show("Không tìm thấy sản phẩm", "Không tìm thấy sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<SanPham> sanPhams = saleController.checkQuanityInStore(txtProduct.EditValue.ToString());
                if (sanPhams.Count == 1)
                {
                    var value = txtProduct.EditValue.ToString();
                    addCart(value, 0);
                }
                else
                {
                    SelectProduct selectProduct = new SelectProduct(sanPhams);
                    selectProduct.Text = "Sản phẩm có nhiều hơn 1 sản phẩm vui lòng chọn sản phẩm";
                    selectProduct.callBack = addCart;
                    selectProduct.ShowDialog();
                }

            }
        }

        private void RetailForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                List<SanPham> product = productController.productList();
                SelectProduct selectProduct = new SelectProduct(sanPhams);
                selectProduct.Text = "Chọn sản phẩm & Thêm mới sản phẩm";
                selectProduct.callBack = addCart;
                selectProduct.refresh = loadProduct;
                selectProduct.ShowDialog();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
