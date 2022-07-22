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

namespace VNShop
{
    public partial class SelectProduct : DevExpress.XtraEditors.XtraForm
    {
        private List<Models.SanPham> listProduct;
        public delegate void addCart(dynamic barcode, int type);
        public delegate void refreshSource();

        public addCart callBack;
        public refreshSource refresh = null;

        public SelectProduct(List<Models.SanPham> sanPhams)
        {
            InitializeComponent();
            listProduct = sanPhams;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshList()
        {
            VNShop.Controllers.ProductController productController = new Controllers.ProductController();
            listProduct = productController.productList();
            lookProduct.Properties.DataSource = listProduct;
            if(refresh != null)
            {
                refresh();
            }
        }

        private void SelectProduct_Load(object sender, EventArgs e)
        {
            lookProduct.Properties.DataSource = listProduct;
            lookProduct.Properties.DisplayMember = "TenSanPham";
            lookProduct.Properties.ValueMember = "id";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string barcode = lookProduct.EditValue.ToString();
            callBack(barcode, 1);
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.callback = refreshList;
            product.ShowDialog();
        }
    }
}