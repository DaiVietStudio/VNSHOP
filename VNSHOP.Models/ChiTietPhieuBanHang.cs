namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuBanHang")]
    public partial class ChiTietPhieuBanHang
    {
        public long id { get; set; }

        public long? Phieu { get; set; }

        public long? SanPham { get; set; }

        public double? SoLuong { get; set; }

        public double? GiaBan { get; set; }

        public double? GiamGia { get; set; }

        [Column(TypeName = "text")]
        public string DonViTinh { get; set; }

        public virtual PhieuBanHang PhieuBanHang { get; set; }

        public virtual SanPham SanPham1 { get; set; }
    }
}
