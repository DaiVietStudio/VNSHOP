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
        private long idEdit = 0;

        public ProductForm(long id = 0)
        {
            InitializeComponent();
            List<DonViTinh> listUnits = unitController.listUnit();
            selectUnit.DataSource = listUnits;
            gridLookUnit.Properties.DisplayMember = "TenDonVi";
            gridLookUnit.Properties.ValueMember = "id";
            gridLookUnit.Properties.DataSource = listUnits;
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
            DonViTinh unit = gridLookUnit.GetSelectedDataRow() as DonViTinh;
            if (double.Parse(txtRetailPrice.Text) <= 0)
            {
                XtraMessageBox.Show("Giá bán lẻ phải lớn hơn 0", "Giá bán lẻ phải lớn hơn 0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (double.Parse(txtWholePrice.Text) <= 0)
            {
                XtraMessageBox.Show("Giá bán sỉ phải lớn hơn 0", "Giá bán sỉ phải lớn hơn 0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (unit == null)
            {
                XtraMessageBox.Show("Chọn đơn vị tính", "Chọn đơn vị tính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SanPham product = new SanPham();
                product.MaSanPham = txtBarcode.Text;
                product.TenSanPham = txtName.Text;
                product.GiaNhap = double.Parse(txtInputPrice.Text);
                product.GiaSi = double.Parse(txtWholePrice.Text);
                product.GiaLe = double.Parse(txtRetailPrice.Text);
                
                product.DonViTinh = unit.id;
                product.ThueVAT = double.Parse(txtVAT.Text);
                product.NgaySanXuat = DateTime.Parse(txtDateOfManuFacture.EditValue.ToString());
                product.NgayHetHan = DateTime.Parse(txtDateExp.EditValue.ToString());
                product.KichHoat = chkActive.Checked;
                product.QuanLyTonKho = chkInventory.Checked ? 1 : 0;
                product.MoTa = txtDeciption.Text;
                if (picImage.EditValue != null)
                {
                    product.HinhAnh = (byte[])picImage.EditValue;

                }
                // get list unit
                int rowHandle = 0;
                List<DonViTinh_SanPham> listUnit = new List<DonViTinh_SanPham>();
                while (gridViewUnit.IsValidRowHandle(rowHandle))
                {
                    var data = gridViewUnit.GetRow(rowHandle) as DonViTinh_SanPham;
                    if (data.GiaLe > 0)
                    {
                        listUnit.Add(data);
                        rowHandle++;
                    }
                    else
                    {
                        error = true;
                        XtraMessageBox.Show("Không được để trống giá bán lẻ tại đơn vị " + data.DonViTinh1.TenDonVi, "Không được để trống giá bán lẻ vị " + data.DonViTinh1.TenDonVi, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

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
                        XtraMessageBox.Show(result.message, result.message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        XtraMessageBox.Show(result.message, result.message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
                Response result = productController.checkProductExist(txtBarcode.Text);
                if (result.status == false)
                {
                    XtraMessageBox.Show(result.message, result.message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBarcode.Text = "";
                }
            }

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (idEdit > 0)
            {
                SanPham sanPham = productController.getDetailProduct(idEdit);
                picImage.EditValue = sanPham.HinhAnh;
                txtBarcode.Text = sanPham.MaSanPham;
                txtName.Text = sanPham.TenSanPham;
                txtInputPrice.Text = sanPham.GiaNhap.ToString();
                txtWholePrice.Text = sanPham.GiaSi.ToString();
                txtRetailPrice.Text = sanPham.GiaLe.ToString();
                gridLookUnit.EditValue = sanPham.DonViTinh;
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
                gridControlUnit.DataSource = new BindingList<DonViTinh_SanPham>(listUnit);

            }
        }
    }
}
