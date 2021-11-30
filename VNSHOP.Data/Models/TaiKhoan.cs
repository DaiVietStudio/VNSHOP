using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class TaiKhoan
    {
        public long Id { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public long? NhanVien { get; set; }

        public virtual NhanVien NhanVienNavigation { get; set; }
    }
}
