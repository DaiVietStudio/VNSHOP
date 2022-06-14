using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class DonViTinh
    {
        public DonViTinh()
        {
            DonViTinhSanPhams = new HashSet<DonViTinhSanPham>();
            SanPhams = new HashSet<SanPham>();
        }

        public long Id { get; set; }
        public string TenDonVi { get; set; }
        public string MoTa { get; set; }
       

        public virtual ICollection<DonViTinhSanPham> DonViTinhSanPhams { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
