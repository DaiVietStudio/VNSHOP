using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class Tinh
    {
        public Tinh()
        {
            Huyens = new HashSet<Huyen>();
            KhachHangs = new HashSet<KhachHang>();
        }

        public long Id { get; set; }
        public string Ten { get; set; }

        public virtual ICollection<Huyen> Huyens { get; set; }
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
