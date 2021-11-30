using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class PhieuNo
    {
        public PhieuNo()
        {
            ChiTietPhieuNos = new HashSet<ChiTietPhieuNo>();
        }

        public long Id { get; set; }
        public string MaSo { get; set; }
        public DateTime? NgayNhap { get; set; }
        public long? KhachHang { get; set; }
        public bool? TinhTrang { get; set; }
        public DateTime? NgayTra { get; set; }
        public double? DaTra { get; set; }
        public double? ConNo { get; set; }

        public virtual KhachHang KhachHangNavigation { get; set; }
        public virtual ICollection<ChiTietPhieuNo> ChiTietPhieuNos { get; set; }
    }
}
