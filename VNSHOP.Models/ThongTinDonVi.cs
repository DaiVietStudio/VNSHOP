namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinDonVi")]
    public partial class ThongTinDonVi
    {
        public int id { get; set; }

        [StringLength(100)]
        public string TenDonVi { get; set; }

        [StringLength(1000)]
        public string DiaChi { get; set; }

        [StringLength(50)]
        public string SoDienThoai { get; set; }

        [StringLength(10)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Website { get; set; }

        [StringLength(300)]
        public string KyTen { get; set; }
    }
}
