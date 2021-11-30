using System;
using System.Collections.Generic;

#nullable disable

namespace VNSHOP.Data.Models
{
    public partial class ThongTinDonVi
    {
        public int Id { get; set; }
        public string TenDonVi { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string KyTen { get; set; }
    }
}
