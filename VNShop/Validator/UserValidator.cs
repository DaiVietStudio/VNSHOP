using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;

namespace VNShop.Validator
{
    class UserValidator : AbstractValidator<NhanVien>
    {
        public UserValidator()
        {
            RuleFor(x => x.HoVaTen).NotEmpty().WithMessage("Họ tên không được để trống");
        }
    }
}
