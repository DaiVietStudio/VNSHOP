using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class PhieuNhapKho
    {
        public PhieuNhapKho()
        {
            ChiTietPhieuNhapKhos = new HashSet<ChiTietPhieuNhapKho>();
        }

        public long Id { get; set; }
        public string MaSo { get; set; }
        public DateTime? NgayNhap { get; set; }
        public double? TongTien { get; set; }
        public long? NhapCungCap { get; set; }

        public virtual KhachHang NhapCungCapNavigation { get; set; }
        public virtual ICollection<ChiTietPhieuNhapKho> ChiTietPhieuNhapKhos { get; set; }
    }
}
