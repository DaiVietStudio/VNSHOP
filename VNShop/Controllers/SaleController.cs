using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;
namespace VNShop.Controllers
{
    class SaleController:BaseController
    {
        public Response save(PhieuBanHang phieuBanHang, List<ChiTietPhieuBanHang> chiTietPhieuBanHangs)
        {
            DbContextTransaction transaction = dbContext.Database.BeginTransaction();

            try
            {
                dbContext.PhieuBanHangs.Add(phieuBanHang);
                foreach(ChiTietPhieuBanHang item in chiTietPhieuBanHangs)
                {
                    item.Phieu = phieuBanHang.id;
                    dbContext.ChiTietPhieuBanHangs.Add(item);
                }
                dbContext.SaveChanges();
                transaction.Commit();
                return new Response(true, "Lưu phiếu không thành công");
            }
            catch(Exception ex)
            {
                transaction.Rollback();
                return new Response(false, ex.ToString());
            } 

           
        }
    }
}
