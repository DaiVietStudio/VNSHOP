namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuNo")]
    public partial class ChiTietPhieuNo
    {
        public long id { get; set; }

        public long? Phieu { get; set; }

        [StringLength(1000)]
        public string SanPham { get; set; }

        public double? Gia { get; set; }

        public double? SoLuong { get; set; }

        [StringLength(50)]
        public string DonViTinh { get; set; }

        public virtual PhieuNo PhieuNo { get; set; }
    }
}
