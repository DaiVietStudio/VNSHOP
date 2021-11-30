using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class ChiTietPhieuNo
    {
        public long Id { get; set; }
        public long? Phieu { get; set; }
        public string SanPham { get; set; }
        public double? Gia { get; set; }
        public double? SoLuong { get; set; }
        public string DonViTinh { get; set; }

        public virtual PhieuNo PhieuNavigation { get; set; }
    }
}
