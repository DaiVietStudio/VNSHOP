using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class KhoHang
    {
        public KhoHang()
        {
            KhoHangSanPhams = new HashSet<KhoHangSanPham>();
        }

        public long Id { get; set; }
        public string TenKho { get; set; }

        public virtual ICollection<KhoHangSanPham> KhoHangSanPhams { get; set; }
    }
}
