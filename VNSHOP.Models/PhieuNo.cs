namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNo")]
    public partial class PhieuNo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNo()
        {
            ChiTietPhieuNoes = new HashSet<ChiTietPhieuNo>();
        }

        public long id { get; set; }

        [StringLength(50)]
        public string MaSo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhap { get; set; }

        public long? KhachHang { get; set; }

        public bool? TinhTrang { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTra { get; set; }

        public double? DaTra { get; set; }

        public double? ConNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNo> ChiTietPhieuNoes { get; set; }

        public virtual KhachHang KhachHang1 { get; set; }
    }
}
