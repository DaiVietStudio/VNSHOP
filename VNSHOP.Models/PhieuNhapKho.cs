namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhapKho")]
    public partial class PhieuNhapKho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNhapKho()
        {
            ChiTietPhieuNhapKhoes = new HashSet<ChiTietPhieuNhapKho>();
        }

        public long id { get; set; }

        [StringLength(50)]
        public string MaSo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayNhap { get; set; }

        public double? TongTien { get; set; }

        public long? NhapCungCap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhapKho> ChiTietPhieuNhapKhoes { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
