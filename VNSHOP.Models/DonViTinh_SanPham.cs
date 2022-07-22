namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DonViTinh_SanPham
    {
        public long id { get; set; }

        public long? DonViTinh { get; set; }

        public long? SanPham { get; set; }

        public double? GiaLe { get; set; }

        public double? GiaSi { get; set; }

        public bool Selected { get; set; }

        public virtual DonViTinh DonViTinh1 { get; set; }

        public virtual SanPham SanPham1 { get; set; }
    }
}
