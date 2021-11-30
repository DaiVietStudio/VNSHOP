using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;
using BCrypt;
namespace VNShop.Controllers
{
    class SignUpController : BaseController
    {
        public Response signUp(ThongTinDonVi thongTinDonVi, TaiKhoan taiKhoan, NhanVien nhanVien)
        {
            dbContext.ThongTinDonVis.Add(thongTinDonVi);
            if (dbContext.SaveChanges() > 0)
            {
                NhanVien saveNhanVien = dbContext.NhanViens.Add(nhanVien);
                if (dbContext.SaveChanges() > 0)
                {
                    taiKhoan.NhanVien = saveNhanVien.id;
                    taiKhoan.MatKhau = BCrypt.Net.BCrypt.HashPassword(taiKhoan.MatKhau);
                    dbContext.TaiKhoans.Add(taiKhoan);
                    if (dbContext.SaveChanges() > 0)
                    {
                        return new Response(true, "Đăng ký thành công");
                    }
                }
            }

            return new Response(false, "Đăng ký thất bại");
        }

        public Response login(TaiKhoan taiKhoan)
        {
           TaiKhoan account = dbContext.TaiKhoans.Where(x => x.TenDangNhap == taiKhoan.TenDangNhap).FirstOrDefault();
            if(account != null)
            {
                bool check = BCrypt.Net.BCrypt.Verify(taiKhoan.MatKhau, account.MatKhau);
                if (check)
                {

                    Program.nameUser = account.NhanVien1.HoVaTen;
                    Program.idUser = account.NhanVien1.id;
                    return new Response(true, "Đăng nhập thành công");

                }
            }

            return new Response(false, "Đăng nhập thất bại");
        }
    }
}
