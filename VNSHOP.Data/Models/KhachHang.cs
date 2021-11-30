using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            PhieuBanHangs = new HashSet<PhieuBanHang>();
            PhieuBaoGia = new HashSet<PhieuBaoGium>();
            PhieuNhapKhos = new HashSet<PhieuNhapKho>();
            PhieuNos = new HashSet<PhieuNo>();
        }

        public long Id { get; set; }
        public int? Loai { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public long? Tinh { get; set; }
        public long? Huyen { get; set; }
        public long? Xa { get; set; }

        public virtual Huyen HuyenNavigation { get; set; }
        public virtual Tinh TinhNavigation { get; set; }
        public virtual Xa XaNavigation { get; set; }
        public virtual ICollection<PhieuBanHang> PhieuBanHangs { get; set; }
        public virtual ICollection<PhieuBaoGium> PhieuBaoGia { get; set; }
        public virtual ICollection<PhieuNhapKho> PhieuNhapKhos { get; set; }
        public virtual ICollection<PhieuNo> PhieuNos { get; set; }
    }
}
