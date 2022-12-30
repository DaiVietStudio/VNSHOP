using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNShop.Models
{
    class JsonProduct
    {
        public long id { get; set; }
        public string TenSanPham { get; set; }
        public string MaSanPham { get; set; }
        public double GiaNhap { get; set; }
        public int TrangThai { get; set; }
        public double SoLuongTonKho { get; set; }
    }
}
