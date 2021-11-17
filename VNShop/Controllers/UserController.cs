using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;
namespace VNShop.Controllers
{
    class UserController:BaseController
    {
        public List<NhanVien> userList()
        {
            return dbContext.NhanViens.ToList();
        }
        public Response save(NhanVien user)
        {
            dbContext.NhanViens.Add(user);
            if (dbContext.SaveChanges()> 0)
            {
                return new Response(true, "Đã lưu nhân viên");
            }
            return new Response(false, "Xảy ra lỗi");

        }
        public Response update(NhanVien user, long id)
        {
            NhanVien userFind = dbContext.NhanViens.FirstOrDefault(x => x.id == id);
            userFind.HoVaTen = user.HoVaTen;
            userFind.GioiTinh = user.GioiTinh;
            userFind.SoDienThoai = user.SoDienThoai;
            userFind.DiaChi = user.DiaChi;
            if (dbContext.SaveChanges() > 0)
            {
                return new Response(true, "Đã lưu nhân viên");
            }
            return new Response(false, "Xảy ra lỗi");

        }

        public NhanVien userDetail(long id)
        {
            return dbContext.NhanViens.FirstOrDefault(x => x.id == id);

        }
        public Response delete(long userId)
        {
            NhanVien user = dbContext.NhanViens.FirstOrDefault(x => x.id == userId);
            TaiKhoan taiKhoan = dbContext.TaiKhoans.FirstOrDefault(x => x.NhanVien == userId);
            if(taiKhoan != null)
            {
                dbContext.TaiKhoans.Remove(taiKhoan);
            }
            dbContext.NhanViens.Remove(user);
            dbContext.SaveChanges();
            return new Response(true, "Đã xóa nhân viên");

        }
    }
}
