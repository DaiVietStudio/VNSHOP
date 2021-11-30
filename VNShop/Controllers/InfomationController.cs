using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;
namespace VNShop.Controllers
{
    class InfomationController : BaseController
    {
        public ThongTinDonVi info()
        {
            return dbContext.ThongTinDonVis.FirstOrDefault();
        }

        public Response update(ThongTinDonVi info)
        {
            ThongTinDonVi infos = dbContext.ThongTinDonVis.FirstOrDefault(x=> x.id == 6);
            infos.TenDonVi = info.TenDonVi;
            infos.DiaChi = info.DiaChi;
            infos.SoDienThoai = info.SoDienThoai.ToString();
            infos.Email = info.Email;
            infos.KyTen = info.KyTen;
            infos.Website = info.Website;
            if (dbContext.SaveChanges() > 0)
            {
                return new Response(true, "Cập nhật thông tin thành công");
            }
            return new Response(false, "Cập nhật thông tin thất bại");
        }
    }
}
