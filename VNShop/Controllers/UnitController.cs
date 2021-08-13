using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;

namespace VNShop.Controllers
{
    class UnitController : BaseController
    {
        public List<DonViTinh> listUnit()
        {
            return dbContext.DonViTinhs.ToList();
        }

        public Response store(DonViTinh donViTinh)
        {
            dbContext.DonViTinhs.Add(donViTinh);
            if (dbContext.SaveChanges() > 0)
            {
                return new Response(true, "Lưu đơn vị tính thành công");

            }
            return new Response(false, "Lưu đơn vị tính không thành công");
        }

        public Response update(List<DonViTinh> donViTinh)
        {

            try
            {
                foreach (DonViTinh item in donViTinh)
                {
                    DonViTinh find = dbContext.DonViTinhs.Where(x => x.id == item.id).FirstOrDefault();
                    find.TenDonVi = item.TenDonVi;
                    find.MoTa = item.MoTa;
                    dbContext.SaveChanges();
                }
                return new Response(true, "Lưu đơn vị tính thành công");
            }
            catch (Exception ex)
            {
                return new Response(false, "Lưu đơn vị tính không thành công");
            }
        }

        public Response delete(List<long> id)
        {
            foreach(int item in id)
            {
                DonViTinh find = dbContext.DonViTinhs.Where(x => x.id == item).FirstOrDefault();
                dbContext.DonViTinhs.Remove(find);
                dbContext.SaveChanges();
            }
            
            return new Response(true, "Xóa đơn vị tính thành công");

        }
    }
}
