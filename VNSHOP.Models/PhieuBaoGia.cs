namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuBaoGia")]
    public partial class PhieuBaoGia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuBaoGia()
        {
            ChiTietPhieuBaoGias = new HashSet<ChiTietPhieuBaoGia>();
        }

        public long id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhap { get; set; }

        public long? DonViBaoGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuBaoGia> ChiTietPhieuBaoGias { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
