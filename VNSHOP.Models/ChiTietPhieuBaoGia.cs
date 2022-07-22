namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuBaoGia")]
    public partial class ChiTietPhieuBaoGia
    {
        public long id { get; set; }

        public long? Phieu { get; set; }

        public int? SanPham { get; set; }

        public double? Gia { get; set; }

        [StringLength(10)]
        public string SoLuong { get; set; }

        public virtual PhieuBaoGia PhieuBaoGia { get; set; }
    }
}
