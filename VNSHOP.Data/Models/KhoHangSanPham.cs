using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class KhoHangSanPham
    {
        public long Id { get; set; }
        public long? KhoHang { get; set; }
        public long? SanPham { get; set; }
        public double? SoLuong { get; set; }

        public virtual SanPham KhoHang1 { get; set; }
        public virtual KhoHang KhoHangNavigation { get; set; }
    }
}
