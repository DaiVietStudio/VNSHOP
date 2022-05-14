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

namespace VNShop
{
    public partial class SelectProduct : DevExpress.XtraEditors.XtraForm
    {
        private List<Models.SanPham> listProduct;
        public delegate void addCart(dynamic barcode);

        public addCart callBack;
        public SelectProduct(List<Models.SanPham> sanPhams)
        {
            InitializeComponent();
            listProduct = sanPhams;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectProduct_Load(object sender, EventArgs e)
        {
            lookProduct.Properties.DataSource = listProduct;
            lookProduct.Properties.DisplayMember = "TenSanPham";
            lookProduct.Properties.ValueMember = "MaSanPham";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string barcode = lookProduct.EditValue.ToString();
            callBack(barcode);
            this.Close();
        }
    }
}