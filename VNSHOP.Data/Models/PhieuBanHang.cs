using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class PhieuBanHang
    {
        public PhieuBanHang()
        {
            ChiTietPhieuBanHangs = new HashSet<ChiTietPhieuBanHang>();
        }

        public long Id { get; set; }
        public string MaSo { get; set; }
        public DateTime? NgayNhap { get; set; }
        public long? KhachHang { get; set; }
        public long? NhanVien { get; set; }
        public int? Loai { get; set; }

        public virtual KhachHang KhachHangNavigation { get; set; }
        public virtual ICollection<ChiTietPhieuBanHang> ChiTietPhieuBanHangs { get; set; }
    }
}
