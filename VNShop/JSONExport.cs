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

namespace VNShop
{
    public partial class JSONExport : DevExpress.XtraEditors.XtraForm
    {
        private VNShop.Controllers.ExportController controller = new Controllers.ExportController();
        public JSONExport()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string result = "";
            string selected = cbJSON.EditValue.ToString();
           if(selected == "Đơn vị tính")
            {
                result = controller.exportUnit();

            }
           if(selected == "Sản phẩm")
            {
                result = controller.exportProduct();
            }
            if (selected == "Đon vị tính sản phẩm")
            {
                result = controller.exportDVT();
            }
            richTextBox1.Text = result;

        }
    }
}