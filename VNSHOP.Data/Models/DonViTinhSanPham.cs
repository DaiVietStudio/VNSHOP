using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class DonViTinhSanPham
    {
        public long Id { get; set; }
        public long? DonViTinh { get; set; }
        public long? SanPham { get; set; }
        public double? GiaLe { get; set; }
        public double? GiaSi { get; set; }
        public bool Selected { get; set; }

        public virtual DonViTinh DonViTinhNavigation { get; set; }
        public virtual SanPham SanPhamNavigation { get; set; }
    }
}
