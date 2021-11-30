using DevExpress.XtraEditors;
using FluentValidation.Results;
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
using VNShop.Validator;
using VNShop.Utils;

namespace VNShop
{
    public partial class CustomerForm : XtraForm
    {
        private long id;
        private CustomerController customerController = new CustomerController();
       

        public CustomerForm(long id = 0)
        {
            InitializeComponent();
            this.id = id;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.TenKhachHang = txtName.Text;
            khachHang.DiaChi = txtAddress.Text;
            khachHang.SoDienThoai = txtPhone.Text;
            if (cbProvince.EditValue != null)
            {
                khachHang.Tinh = (long)cbProvince.EditValue;
            }
            if (cbDistrict.EditValue != null)
            {
                khachHang.Huyen = (long)cbDistrict.EditValue;
            }

            if (cbWard.EditValue != null)
            {
                khachHang.Xa = (long)cbWard.EditValue;

            }

            khachHang.Loai = (int)cbType.EditValue;
            if (id == 0)
            {
                
                CustomerValidator validationRules = new CustomerValidator();
                ValidationResult validationResult = validationRules.Validate(khachHang);
                if (!validationResult.IsValid)
                {
                    string errorstr = MakeError.makeStrError(validationResult);
                    XtraMessageBox.Show(errorstr, "Đã xảy ra lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Response response = customerController.save(khachHang);
                    if (response.status)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }

            }
            else
            {
                CustomerValidator validationRules = new CustomerValidator();
                ValidationResult validationResult = validationRules.Validate(khachHang);
                if (!validationResult.IsValid)
                {
                    string errorstr = MakeError.makeStrError(validationResult);
                    XtraMessageBox.Show(errorstr, "Đã xảy ra lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Response response = customerController.update(khachHang, id);
                    if (response.status)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            List<TypeCustomer> typeCustomers = new List<TypeCustomer>();
            typeCustomers.Add(new TypeCustomer(0, "Khách hàng"));
            typeCustomers.Add(new TypeCustomer(1, "Nhà phân phối"));
            cbType.Properties.DataSource = typeCustomers;
            ResourceController resourceController = new ResourceController();
            List<Tinh> listProvince = resourceController.provinceList();
            cbProvince.Properties.DataSource = listProvince;
            if (id == 0)
            {
                cbType.EditValue = 0;
            }
            else
            {
                KhachHang  KhachHang = customerController.detailCustomer(id);
                txtName.Text = KhachHang.TenKhachHang;
                txtAddress.Text = KhachHang.DiaChi;
                txtPhone.Text = KhachHang.SoDienThoai;
                cbProvince.EditValue = KhachHang.Tinh;
                loadDistrict((long)KhachHang.Tinh);
                cbDistrict.EditValue = KhachHang.Huyen;
                loadWard((long)KhachHang.Huyen);
                cbWard.EditValue = KhachHang.Xa;
                cbType.EditValue = KhachHang.Loai;

            }
        }

        private void loadDistrict(long province)
        {
            List<Huyen> districtList = new ResourceController().districtList((long)cbProvince.EditValue);
            cbDistrict.Properties.DataSource = districtList;
        }

        private void loadWard(long district)
        {
            List<Xa> wardList = new ResourceController().wardList(district);
            cbWard.Properties.DataSource = wardList;
        }

        private void cbProvince_EditValueChanged(object sender, EventArgs e)
        {
            loadDistrict((long)cbProvince.EditValue);
        }

        private void cbDistrict_EditValueChanged(object sender, EventArgs e)
        {
            loadWard((long)cbDistrict.EditValue);
        }
    }
}
