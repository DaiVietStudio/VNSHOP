using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNShop.Models
{
   public class ProductGrid
    {
        public long id { get; set; }
        public string TenSanPham { get; set; }
        public string MaSanPham { get; set; }
        public string DonVi { get; set; }
        public double GiaLe { get; set; }
        public double GiaSi { get; set; }
    }
}
