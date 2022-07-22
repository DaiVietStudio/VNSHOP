namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuNhapKho")]
    public partial class ChiTietPhieuNhapKho
    {
        public long id { get; set; }

        public long? Phieu { get; set; }

        public long? SanPham { get; set; }

        public double? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public virtual PhieuNhapKho PhieuNhapKho { get; set; }

        public virtual SanPham SanPham1 { get; set; }
    }
}
