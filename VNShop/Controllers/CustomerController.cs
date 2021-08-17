using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;
namespace VNShop.Controllers
{
    class CustomerController:BaseController
    {
        public List<KhachHang> customerList()
        {
            return dbContext.KhachHangs.ToList();
        }

        public Response save(KhachHang customer)
        {
            dbContext.KhachHangs.Add(customer);
            if (dbContext.SaveChanges() != 0)
            {
                return new Response(true, "Lưu khách hàng thành công");

            }
            return new Response(false, "Lưu khách hàng không thành công");
        }

        public Response update(KhachHang customer, long id)
        {
            KhachHang khachHang = dbContext.KhachHangs.FirstOrDefault(x => x.id == id);
            khachHang.TenKhachHang = customer.TenKhachHang;
            khachHang.DiaChi = customer.DiaChi;
            khachHang.SoDienThoai = customer.SoDienThoai;
            khachHang.Tinh = customer.Tinh;
            khachHang.Huyen = customer.Huyen;
            khachHang.Xa = customer.Xa;
            khachHang.Loai = customer.Loai;

            if (dbContext.SaveChanges() != 0)
            {
                return new Response(true, "Lưu khách hàng thành công");

            }
            return new Response(false, "Lưu khách hàng không thành công");
        }

        public Response delete(long id)
        {
            KhachHang khachHang = dbContext.KhachHangs.FirstOrDefault(x => x.id == id);
            dbContext.KhachHangs.Remove(khachHang);
            if (dbContext.SaveChanges() != 0)
            {
                return new Response(true, "Xóa khách hàng thành công");

            }
            return new Response(false, "Xóa khách hàng không thành công");

        }

        public KhachHang detailCustomer(long id)
        {
            return dbContext.KhachHangs.FirstOrDefault(x => x.id == id);
        }
    }
}
