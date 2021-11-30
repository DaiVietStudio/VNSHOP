using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class Xa
    {
        public Xa()
        {
            KhachHangs = new HashSet<KhachHang>();
        }

        public long Id { get; set; }
        public string Ten { get; set; }
        public long? Huyen { get; set; }

        public virtual Huyen HuyenNavigation { get; set; }
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
