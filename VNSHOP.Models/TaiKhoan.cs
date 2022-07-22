namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        public long id { get; set; }

        [StringLength(50)]
        public string TenDangNhap { get; set; }

        [StringLength(600)]
        public string MatKhau { get; set; }

        public long? NhanVien { get; set; }

        public virtual NhanVien NhanVien1 { get; set; }
    }
}
