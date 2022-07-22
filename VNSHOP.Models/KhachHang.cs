namespace VNSHOP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            PhieuBanHangs = new HashSet<PhieuBanHang>();
            PhieuBaoGias = new HashSet<PhieuBaoGia>();
            PhieuNhapKhoes = new HashSet<PhieuNhapKho>();
            PhieuNoes = new HashSet<PhieuNo>();
        }

        public long id { get; set; }

        public int? Loai { get; set; }

        [StringLength(1000)]
        public string TenKhachHang { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(10)]
        public string SoDienThoai { get; set; }

        public long? Tinh { get; set; }

        public long? Huyen { get; set; }

        public long? Xa { get; set; }

        public virtual Huyen Huyen1 { get; set; }

        public virtual Tinh Tinh1 { get; set; }

        public virtual Xa Xa1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuBanHang> PhieuBanHangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuBaoGia> PhieuBaoGias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhapKho> PhieuNhapKhoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNo> PhieuNoes { get; set; }
    }
}
