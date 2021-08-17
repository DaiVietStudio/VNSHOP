using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;
namespace VNShop.Controllers
{
    class SaleController : BaseController
    {

        public List<PhieuBanHang> receiptList()
        {
            return dbContext.PhieuBanHangs.OrderByDescending(x => x.NgayNhap).ToList();
        }


        public List<ChiTietPhieuBanHang> detailReceipt(long id)
        {
            return dbContext.ChiTietPhieuBanHangs.Where(x => x.Phieu == id).ToList();
        }


        public List<ChartItem> chart()
        {
            List<ChartItem> listChartItem = new List<ChartItem>();
            DateTime now = DateTime.Now;
            var startDate = new DateTime(now.Year, now.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            List<PhieuBanHang> listReceipt = dbContext.PhieuBanHangs.Where(x => x.NgayNhap >= startDate && x.NgayNhap <= endDate).ToList();

            foreach (PhieuBanHang item in listReceipt)
            {
                ChartItem chartItem = new ChartItem();
                chartItem.date = (DateTime)item.NgayNhap;
                double total = 0;
                foreach (ChiTietPhieuBanHang itemDetail in item.ChiTietPhieuBanHangs)
                {
                    total += Math.Round((double)itemDetail.GiaBan * (double)itemDetail.SoLuong);
                }
                chartItem.value = total;
                listChartItem.Add(chartItem);
            }

            return listChartItem;
        }

        public Response delete(long id)
        {
            PhieuBanHang phieu = dbContext.PhieuBanHangs.FirstOrDefault(x => x.id == id);

            dbContext.PhieuBanHangs.Remove(phieu);

            if (dbContext.SaveChanges() > 0)
            {
                return new Response(true, "Đã xóa phiếu");
            }
            else
            {
                return new Response(false, "Xóa phiếu không thành công");

            }
        }

        public Response save(PhieuBanHang phieuBanHang, List<ChiTietPhieuBanHang> chiTietPhieuBanHangs)
        {
            DbContextTransaction transaction = dbContext.Database.BeginTransaction();

            try
            {
                dbContext.PhieuBanHangs.Add(phieuBanHang);
                foreach (ChiTietPhieuBanHang item in chiTietPhieuBanHangs)
                {
                    item.Phieu = phieuBanHang.id;
                    dbContext.ChiTietPhieuBanHangs.Add(item);
                }
                dbContext.SaveChanges();
                transaction.Commit();
                return new Response(true, "Lưu phiếu thành công");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return new Response(false, ex.ToString());
            }


        }
    }
}
