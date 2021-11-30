using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public long Id { get; set; }
        public string HoVaTen { get; set; }
        public int? GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }

        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
