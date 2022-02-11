using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNShop.Models
{
    class DetailCart
    {
        public long id { get; set; }
        public Nullable<double> SoLuong { get; set; }
        public Nullable<double> GiaBan { get; set; }
        public long DonViTinh { get; set; }
        public string TenDonVi { get; set; }
        public string TenSanPham { get; set; }
        public string MaSanPham { get; set; }
        public Nullable<double> ThanhTien { get; set; }
    }
}
