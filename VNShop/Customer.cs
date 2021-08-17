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
using VNShop.Controllers;
using VNShop.Models;

namespace VNShop
{
    public partial class Customer : XtraForm
    {
        private CustomerController CustomerController = new CustomerController();
        public Customer()
        {
            InitializeComponent();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            CustomerForm customerForm = new CustomerForm();
            if(customerForm.ShowDialog() == DialogResult.OK)
            {
                loadData();
            }
        }

        private void loadData()
        {
            gridControlCustomer.DataSource = CustomerController.customerList();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            List<TypeCustomer> typeCustomers = new List<TypeCustomer>();
            typeCustomers.Add(new TypeCustomer(0, "Khách hàng"));
            typeCustomers.Add(new TypeCustomer(1, "Nhà phân phối"));
            cbType.Properties.DataSource = typeCustomers;
            loadData();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] row = gridViewCustomer.GetSelectedRows();
            if(row.Length == 0)
            {
                XtraMessageBox.Show("Xin vui lòng chọn một khách hàng muốn sửa", "Chọn khách hàng sửa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                KhachHang khachHang = gridViewCustomer.GetRow(row[0]) as KhachHang;
                CustomerForm customerForm = new CustomerForm(khachHang.id);
                if (customerForm.ShowDialog() == DialogResult.OK)
                {
                    loadData();
                }
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(XtraMessageBox.Show("Bạn có muốn xóa khách hàng này không","Xác nhận xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int[] row = gridViewCustomer.GetSelectedRows();
                KhachHang khachHang = gridViewCustomer.GetRow(row[0]) as KhachHang;
                Response result = CustomerController.delete(khachHang.id);
                if (result.status)
                {
                    XtraMessageBox.Show("Đã xóa thành công", "Xóa thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
            }
        }
    }
}
