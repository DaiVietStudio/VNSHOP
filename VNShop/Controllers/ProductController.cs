using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;
using System.Data.Entity;

namespace VNShop.Controllers
{
    class ProductController : BaseController
    {
        public List<SanPham> retailProductList()
        {
            List<SanPham> productList = new List<SanPham>();
            var list = (from p in dbContext.SanPhams select new { p.id, p.MaSanPham, p.TenSanPham, p.DonViTinh, p.GiaLe, p.DonViTinh1 }).ToList();
            foreach(var item in list)
            {
                SanPham itemProduct = new SanPham();
                itemProduct.id = item.id;
                itemProduct.MaSanPham = item.MaSanPham;
                itemProduct.TenSanPham = item.TenSanPham;
                itemProduct.GiaLe = item.GiaLe;
                itemProduct.DonViTinh = item.DonViTinh;
                productList.Add(itemProduct);
            }
            return productList;

        }

        public List<SanPham> productList()
        {
            return dbContext.SanPhams.ToList();
        }

        public SanPham getDetailProduct(long id)
        {
            return dbContext.SanPhams.Where(x => x.id == id).FirstOrDefault();
        }

        public Response checkProductExist(string barcode)
        {
            SanPham check = dbContext.SanPhams.Where(x => x.MaSanPham == barcode).FirstOrDefault();
            if (check == null)
            {
                return new Response(true, "Sản phẩm chưa tồn tại");

            }

            return new Response(false, "Sản phẩm đã tồn tại");

        }


        public Response save(SanPham sanPham, List<DonViTinh_SanPham> donViTinh_SanPhams = null)
        {
            DbContextTransaction transaction = dbContext.Database.BeginTransaction();
            try
            {
                dbContext.SanPhams.Add(sanPham);
                if (dbContext.SaveChanges() > 0)
                {
                    if(donViTinh_SanPhams != null)
                    {
                        foreach (DonViTinh_SanPham item in donViTinh_SanPhams)
                        {
                            item.SanPham = sanPham.id;
                            dbContext.DonViTinh_SanPham.Add(item);
                            dbContext.SaveChanges();
                        }
                    }
                    transaction.Commit();
                    return new Response(true, "Lưu sản phẩm thành công");

                }
                return new Response(false, "Lưu sản phẩm không thành công");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return new Response(false, ex.ToString());

            }
        }

        public Response update(SanPham sanPham, long id, List<DonViTinh_SanPham> donViTinh_SanPhams)
        {
            DbContextTransaction transaction = dbContext.Database.BeginTransaction();
            try
            {
                SanPham find = dbContext.SanPhams.Where(x => x.id == id).FirstOrDefault();
                find.TenSanPham = sanPham.TenSanPham;
                find.MaSanPham = sanPham.MaSanPham;
                find.GiaNhap = sanPham.GiaNhap;
                find.GiaSi = sanPham.GiaSi;
                find.GiaLe = sanPham.GiaLe;
                find.DonViTinh = sanPham.DonViTinh;
                find.ThueVAT = sanPham.ThueVAT;
                find.NgaySanXuat = sanPham.NgaySanXuat;
                find.NgayHetHan = sanPham.NgayHetHan;
                find.KichHoat = sanPham.KichHoat;
                find.QuanLyTonKho = sanPham.QuanLyTonKho;
                find.MoTa = sanPham.MoTa;
                find.HinhAnh = sanPham.HinhAnh;
                dbContext.SaveChanges();
                if (donViTinh_SanPhams.Count > 0)
                {

                    List<DonViTinh_SanPham> old = dbContext.DonViTinh_SanPham.Where(x => x.SanPham == id).ToList();
                    // Delete old
                    foreach (DonViTinh_SanPham item in old)
                    {
                       
                        dbContext.DonViTinh_SanPham.Remove(item);
                        dbContext.SaveChanges();
                    }
                    // Insert new
                    foreach (DonViTinh_SanPham item in donViTinh_SanPhams)
                    {
                        item.SanPham = id;
                        dbContext.DonViTinh_SanPham.Add(item);
                        dbContext.SaveChanges();
                    }

                }
                transaction.Commit();
                return new Response(true, "Lưu sản phẩm thành công");

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return new Response(false, ex.ToString());

            }
        }

        public Response delete(List<long> products)
        {
            foreach (int item in products)
            {
                SanPham find = dbContext.SanPhams.Where(x => x.id == item).FirstOrDefault();

                dbContext.SanPhams.Remove(find);
                dbContext.SaveChanges();
            }
            return new Response(true, "Đã xóa sản phẩm");

        }
    }
}
