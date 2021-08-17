using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using VNShop.Models;
namespace VNShop.Validator
{
    class CustomerValidator:AbstractValidator<KhachHang>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.TenKhachHang).NotNull().WithMessage("Tên khách hàng không được để trống").NotEmpty().WithMessage("Tên khách hàng không được để trống");
            RuleFor(x => x.DiaChi).NotEmpty().WithMessage("Địa chỉ không được để trống");
            RuleFor(x => x.Tinh).NotEmpty().WithMessage("Tỉnh không được để trống");
            RuleFor(x => x.Huyen).NotEmpty().WithMessage("Huyện không được để trống");
            RuleFor(x => x.Xa).NotEmpty().WithMessage("Xã không được để trống");
        }
    }
}
