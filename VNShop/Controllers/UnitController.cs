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

        public long checkUnit(string name)
        {

            DonViTinh unit = dbContext.DonViTinhs.FirstOrDefault(x => x.TenDonVi == name);
            if (unit != null)
            {
                return unit.id;
            }
            return 0;
        }


        public double getPriceProduct(long product, long unit, int loai)
        {
            DonViTinh_SanPham donViTinh_SanPham = dbContext.DonViTinh_SanPham.FirstOrDefault(x => x.SanPham == product && x.DonViTinh == unit);
            if (donViTinh_SanPham != null)
            {
                if (loai == 1)
                {
                    return (double)donViTinh_SanPham.GiaLe;
                }
                else
                {
                    return (double)donViTinh_SanPham.GiaSi;

                }
            }
            else
            {
                SanPham sanPham = dbContext.SanPhams.FirstOrDefault(x => x.id == product);
                if (loai == 1)
                {
                    return (double)sanPham.GiaLe;
                }
                else
                {
                    return (double)sanPham.GiaSi;

                }
            }


        }

        public List<DonViTinh> listUnitByProduct(long product)
        {
            List<DonViTinh> listUnit = new List<DonViTinh>();
            SanPham sanPham = dbContext.SanPhams.FirstOrDefault(x => x.id == product);
            DonViTinh donViTinhprimary = dbContext.DonViTinhs.FirstOrDefault(x => x.id == sanPham.DonViTinh);
            List<DonViTinh_SanPham> listUnitSecond = dbContext.DonViTinh_SanPham.Where(x => x.SanPham == product).ToList();
            listUnit.Add(donViTinhprimary);

            foreach (DonViTinh_SanPham item in listUnitSecond)
            {
                listUnit.Add(item.DonViTinh1);
            }
            return listUnit;
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
                return new Response(false, ex.ToString());
            }
        }

        public Response delete(List<long> id)
        {
            foreach (int item in id)
            {
                DonViTinh find = dbContext.DonViTinhs.Where(x => x.id == item).FirstOrDefault();
                dbContext.DonViTinhs.Remove(find);
                dbContext.SaveChanges();
            }

            return new Response(true, "Xóa đơn vị tính thành công");

        }
    }
}
