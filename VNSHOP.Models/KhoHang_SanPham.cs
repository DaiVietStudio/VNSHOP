namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhoHang_SanPham
    {
        public long id { get; set; }

        public long? KhoHang { get; set; }

        public long? SanPham { get; set; }

        public double? SoLuong { get; set; }

        public virtual KhoHang KhoHang1 { get; set; }

        public virtual SanPham SanPham1 { get; set; }
    }
}
