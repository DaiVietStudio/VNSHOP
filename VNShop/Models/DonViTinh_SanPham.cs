//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VNShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DonViTinh_SanPham
    {
        public long id { get; set; }
        public Nullable<long> DonViTinh { get; set; }
        public Nullable<long> SanPham { get; set; }
        public Nullable<double> GiaLe { get; set; }
        public Nullable<double> GiaSi { get; set; }
        public bool Selected { get; set; }

        public virtual DonViTinh DonViTinh1 { get; set; }
        public virtual SanPham SanPham1 { get; set; }
    }
}
