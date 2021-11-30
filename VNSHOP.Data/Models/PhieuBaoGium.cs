using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class PhieuBaoGium
    {
        public PhieuBaoGium()
        {
            ChiTietPhieuBaoGia = new HashSet<ChiTietPhieuBaoGium>();
        }

        public long Id { get; set; }
        public DateTime? NgayNhap { get; set; }
        public long? DonViBaoGia { get; set; }

        public virtual KhachHang DonViBaoGiaNavigation { get; set; }
        public virtual ICollection<ChiTietPhieuBaoGium> ChiTietPhieuBaoGia { get; set; }
    }
}
