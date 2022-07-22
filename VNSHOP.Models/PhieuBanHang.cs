namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuBanHang")]
    public partial class PhieuBanHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuBanHang()
        {
            ChiTietPhieuBanHangs = new HashSet<ChiTietPhieuBanHang>();
        }

        public long id { get; set; }

        [StringLength(50)]
        public string MaSo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhap { get; set; }

        public long? KhachHang { get; set; }

        public long? NhanVien { get; set; }

        public int? Loai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuBanHang> ChiTietPhieuBanHangs { get; set; }

        public virtual KhachHang KhachHang1 { get; set; }
    }
}
