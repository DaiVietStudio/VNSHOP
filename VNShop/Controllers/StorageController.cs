using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;
namespace VNShop.Controllers
{
    class StorageController : BaseController
    {

        public List<KhoHang> storageList()
        {
            return dbContext.KhoHangs.ToList();
        }

        public Response save(KhoHang khoHang)
        {
            dbContext.KhoHangs.Add(khoHang);
            if (dbContext.SaveChanges() > 0)
            {
                return new Response(true, "Lưu phòng ban thành công");

            }
            return new Response(false, "Lưu phòng ban không thành công");
        }

        public Response update(List<KhoHang> khoHangs)
        {
            try
            {
                foreach (KhoHang item in khoHangs)
                {
                    KhoHang find = dbContext.KhoHangs.Where(x => x.id == item.id).FirstOrDefault();
                    find.TenKho = item.TenKho; dbContext.SaveChanges();
                }
                return new Response(true, "Lưu kho hàng thành công");
            }
            catch(Exception ex)
            {
                return new Response(false, "Lưu kho hàng không thành công");
            }
        }

        public Response delete(List<long> khoHangs)
        {
            foreach (int item in khoHangs)
            {
                KhoHang find = dbContext.KhoHangs.Where(x => x.id == item).FirstOrDefault();
                dbContext.KhoHangs.Remove(find);
                dbContext.SaveChanges();
            }
            return new Response(true, "Xóa thành công");
        }
    }
}
