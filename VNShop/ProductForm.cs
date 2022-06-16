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
    public partial class ProductForm : XtraForm
    {
        
        UnitController unitController = new UnitController();
        ProductController productController = new ProductController();
        public delegate void reload();
        public reload callback;
        private long idEdit = 0;
        private List<UnitList> unitLists = new List<UnitList>();
        private bool same = false;

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(string barcode = null)
        {
            InitializeComponent();
            if (barcode != null)
            {
                txtBarcode.Text = barcode;
            }
           
        }
        public ProductForm(long id = 0, string barcode = null)
        {
            InitializeComponent();
            if (barcode != null)
            {
                txtBarcode.Text = barcode;
            }
            

            if (id > 0)
            {
                idEdit = id;
            }
            else
            {
                List<DonViTinh_SanPham> donViTinh_SanPhams = new List<DonViTinh_SanPham>();
                gridControlUnit.DataSource = new BindingList<DonViTinh_SanPham>(donViTinh_SanPhams);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {

            picImage.LoadImage();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (double.Parse(txtRetailPrice.Text) <= 0)
            {
                XtraMessageBox.Show("Giá bán lẻ phải lớn hơn 0", "Giá bán lẻ phải lớn hơn 0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (double.Parse(txtWholePrice.Text) <= 0)
            {
                XtraMessageBox.Show("Giá bán sỉ phải lớn hơn 0", "Giá bán sỉ phải lớn hơn 0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (unitLists.Count == 0)
            {
                XtraMessageBox.Show("Thêm đơn vị tính", "Thêm đơn vị tính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(same == false)
                {
                    SanPham product = new SanPham();
                    product.MaSanPham = txtBarcode.Text;
                    product.TenSanPham = txtName.Text.ToUpper();
                    if (txtInputPrice.Text != "")
                    {
                        product.GiaNhap = double.Parse(txtInputPrice.Text);
                    }
                    product.GiaSi = double.Parse(txtWholePrice.Text);
                    product.GiaLe = double.Parse(txtRetailPrice.Text);

                    //product.DonViTinh = unit.id;
                    if (txtVAT.Text != "")
                    {
                        product.ThueVAT = double.Parse(txtVAT.Text);

                    }
                    if (txtDateOfManuFacture.EditValue != null)
                    {
                        product.NgaySanXuat = DateTime.Parse(txtDateOfManuFacture.EditValue.ToString());

                    }
                    if (txtDateExp.EditValue != null)
                    {
                        product.NgayHetHan = DateTime.Parse(txtDateExp.EditValue.ToString());
                    }

                    product.KichHoat = chkActive.Checked;
                    product.QuanLyTonKho = chkInventory.Checked ? 1 : 0;
                    product.MoTa = txtDeciption.Text;
                    if (picImage.EditValue != null)
                    {
                        product.HinhAnh = (byte[])picImage.EditValue;

                    }
                    // get list unit

                    List<DonViTinh_SanPham> listUnit = new List<DonViTinh_SanPham>();
                    foreach (UnitList item in unitLists)
                    {
                        listUnit.Add(new DonViTinh_SanPham()
                        {
                            DonViTinh = item.id,
                            GiaLe = item.GiaLe,
                            GiaSi = item.GiaSi,
                            Selected = item.Chinh
                        });
                    }
                    Response result;
                    if (error == false)
                    {
                        if (idEdit == 0)
                        {
                            result = productController.save(product, listUnit);
                        }
                        else
                        {
                            result = productController.update(product, idEdit, listUnit);
                        }

                        if (result.status)
                        {
                            DialogResult dialogResult = XtraMessageBox.Show(result.message, result.message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if(dialogResult == DialogResult.OK)
                            {
                                if (callback != null)
                                {
                                    callback();
                                }

                                this.Close();
                            }
                            
                            

                        }
                        else
                        {
                            XtraMessageBox.Show(result.message, result.message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                            XtraMessageBox.Show("Không thể thêm hai sản phẩm trùng nhau", "Không thể thêm hai sản phẩm trùng nhau", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void gridViewUnit_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

        }

        private void txtBarcode_EditValueChanged(object sender, EventArgs e)
        {

            if (idEdit == 0)
            {
                bool result = productController.checkProductExist(txtBarcode.Text);
                if (result == true)
                {
                    same = true;
                    XtraMessageBox.Show("Sản phẩm cùng mã vạch đã tồn tại trong hệ thống", "Sản phẩm cùng mã vạch đã tồn tại trong hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            gridControlUnit.DataSource = unitLists;
            if (idEdit > 0)
            {
                SanPham sanPham = productController.getDetailProduct(idEdit);
                picImage.EditValue = sanPham.HinhAnh;
                txtBarcode.Text = sanPham.MaSanPham;
                txtName.Text = sanPham.TenSanPham;
                txtInputPrice.Text = sanPham.GiaNhap.ToString();
                txtWholePrice.Text = sanPham.GiaSi.ToString();
                txtRetailPrice.Text = sanPham.GiaLe.ToString();
                txtVAT.Text = sanPham.ThueVAT.ToString();
                txtDateOfManuFacture.EditValue = sanPham.NgaySanXuat;
                txtDateExp.EditValue = sanPham.NgayHetHan;
                if (sanPham.KichHoat == true)
                {
                    chkActive.Checked = true;
                }
                else
                {
                    chkActive.Checked = false;

                }
                if (sanPham.QuanLyTonKho == 1)
                {
                    chkInventory.Checked = true;
                }
                else
                {
                    chkInventory.Checked = false;

                }
                txtDeciption.Text = sanPham.MoTa;

                List<DonViTinh_SanPham> listUnit = sanPham.DonViTinh_SanPham.ToList();
                listUnit.ForEach(item =>
                {
                    unitLists.Add(new UnitList()
                    {
                        id = item.DonViTinh != null ? (long)item.DonViTinh: 0,
                        TenDonVi = item.DonViTinh1 != null?  item.DonViTinh1.TenDonVi:"", 
                        GiaLe = (double) item.GiaLe, 
                        GiaSi =(double) item.GiaSi, Chinh = item.Selected
                        
                    });
                });
                gridViewUnit.RefreshData();

            }
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            AddUnit addUnit = new AddUnit();
            addUnit.callBack = addUnitList;
            addUnit.ShowDialog();
        }

        private void addUnitList(Models.UnitList unitList, bool edit = false, long unitId = 0)
        {
            if(unitList.Chinh == true)
            {
                int oldPorimary = unitLists.FindIndex(s => s.Chinh == true);
                if(oldPorimary != -1)
                {
                    unitLists[oldPorimary].Chinh = false;
                }
                
            }
            if (edit == false)
            {
                unitLists.Add(unitList);
            }
            else
            {
                Models.UnitList find = unitLists.Find(s => s.id == unitId);
                unitLists.Remove(find);
                unitLists.Add(unitList);

            }
            gridViewUnit.RefreshData();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            UnitList unitList = (UnitList)gridViewUnit.GetFocusedRow();
            unitLists.Remove(unitList);
            gridViewUnit.RefreshData();
        }

        private void btnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            UnitList unitList = (UnitList)gridViewUnit.GetFocusedRow();
            AddUnit addUnit = new AddUnit(unitList);
            addUnit.callBack = addUnitList;
            addUnit.ShowDialog();
        }
    }
}
