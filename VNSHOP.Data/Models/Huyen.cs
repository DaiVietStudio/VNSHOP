using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class Huyen
    {
        public Huyen()
        {
            KhachHangs = new HashSet<KhachHang>();
            Xas = new HashSet<Xa>();
        }

        public long Id { get; set; }
        public string Ten { get; set; }
        public long? Tinh { get; set; }

        public virtual Tinh TinhNavigation { get; set; }
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
        public virtual ICollection<Xa> Xas { get; set; }
    }
}
