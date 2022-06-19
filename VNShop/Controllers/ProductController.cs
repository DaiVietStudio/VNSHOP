using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;
using System.Data.Entity;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System.IO;

namespace VNShop.Controllers
{
    class ProductController : BaseController
    {
        public List<SanPham> retailProductList()
        {
            List<SanPham> productList = new List<SanPham>();
            var list = dbContext.SanPhams.Include("DonViTinh_SanPham").ToList();
            foreach (var item in list)
            {
                SanPham itemProduct = new SanPham();
                itemProduct.id = item.id;
                itemProduct.MaSanPham = item.MaSanPham;
                itemProduct.TenSanPham = item.TenSanPham;
                itemProduct.DonViTinh = item.DonViTinh;
                productList.Add(itemProduct);
            }
            return productList;

        }

        public bool Convert()
        {
            var trans = dbContext.Database.BeginTransaction();
            try
            {
                //List<SanPham> sanPhams = dbContext.SanPhams.ToList();
                //List<DonViTinh_SanPham> donViTinh_SanPhams = dbContext.DonViTinh_SanPham.Where(s => s.Selected == true).ToList();
                //if (donViTinh_SanPhams.Count > 0)
                //{
                //    dbContext.DonViTinh_SanPham.RemoveRange(donViTinh_SanPhams);
                //    dbContext.SaveChanges();
                //}
                //foreach (SanPham item in sanPhams)
                //{
                //    DonViTinh_SanPham _donvi = new DonViTinh_SanPham();
                //    _donvi.SanPham = item.id;
                //    _donvi.DonViTinh = item.DonViTinh;
                //    _donvi.Selected = true;
                //    dbContext.DonViTinh_SanPham.Add(_donvi);
                //    dbContext.SaveChanges();
                //}

                List<DonViTinh_SanPham> donViTinh_SanPhams = dbContext.DonViTinh_SanPham.Where(s => s.DonViTinh == null).ToList();
                donViTinh_SanPhams.ForEach(item =>
                {
                    item.DonViTinh = 14;
                    dbContext.SaveChanges();
                });

                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw ex;
            }

            return false;
        }

        public List<SanPham> productList()
        {
            return dbContext.SanPhams.ToList();
        }

        public Response exportExcel(string path)
        {
            try
            {
                List<SanPham> products = dbContext.SanPhams.ToList();
                XSSFWorkbook wb = new XSSFWorkbook();

                ISheet sheet = wb.CreateSheet();
                // Tạo row
                var rowHeader = sheet.CreateRow(0);
                // Merge lại row đầu 3 cột
                rowHeader.CreateCell(0); // tạo ra cell trc khi merge
                CellRangeAddress cellMerge = new CellRangeAddress(0, 0, 0, 2);
                sheet.AddMergedRegion(cellMerge);
                rowHeader.GetCell(0).SetCellValue("DANH SÁCH SẢN PHẨM");

                // Ghi tên cột ở row 1
                var row1 = sheet.CreateRow(1);
                row1.CreateCell(0).SetCellValue("Mã sản phẩm");
                row1.CreateCell(1).SetCellValue("Tên sản phẩm");
                row1.CreateCell(2).SetCellValue("Mô tả");
                row1.CreateCell(3).SetCellValue("Giá nhập");
                row1.CreateCell(4).SetCellValue("Giá lẻ");
                row1.CreateCell(5).SetCellValue("Giá sỉ");
                row1.CreateCell(6).SetCellValue("Thuế VAT");
                row1.CreateCell(7).SetCellValue("Đơn vị tính");

                int rowIndex = 3;
                foreach (var item in products)
                {
                    var newRow = sheet.CreateRow(rowIndex);

                    newRow.CreateCell(0).SetCellValue(item.MaSanPham);
                    newRow.CreateCell(1).SetCellValue(item.TenSanPham);
                    newRow.CreateCell(2).SetCellValue(item.MoTa != null ? item.MoTa : "");
                    newRow.CreateCell(3).SetCellValue(item.GiaNhap != null ? (double)item.GiaNhap : 0);
                 
                    newRow.CreateCell(6).SetCellValue(item.ThueVAT != null ? (double)item.ThueVAT : 0);
                    newRow.CreateCell(7).SetCellValue(item.DonViTinh1.TenDonVi);
                    if (item.DonViTinh_SanPham.Count > 0)
                    {
                        rowIndex++;
                        // Luu cac don vi phu

                        foreach (var itemUnit in item.DonViTinh_SanPham)
                        {
                            var newRowUnit = sheet.CreateRow(rowIndex);

                            newRow.CreateCell(0).SetCellValue(item.MaSanPham);
                            newRow.CreateCell(1).SetCellValue(item.TenSanPham);
                            newRow.CreateCell(2).SetCellValue(item.MoTa != null ? item.MoTa : "");
                            newRow.CreateCell(4).SetCellValue(itemUnit.GiaLe != null ? (double)itemUnit.GiaLe : 0);
                            newRow.CreateCell(5).SetCellValue(itemUnit.GiaSi != null ? (double)itemUnit.GiaSi : 0);
                            newRow.CreateCell(7).SetCellValue(itemUnit.DonViTinh1.TenDonVi);
                        }
                    }

                    rowIndex++;
                }

                FileStream fs = new FileStream(path + @"danhsachsanpham.xlsx", FileMode.CreateNew);
                wb.Write(fs);
                return new Response(true, "Xuất file Excel thành công");
            }
            catch (Exception ex)
            {
                return new Response(false, ex.Message);
            }



        }

        public SanPham getDetailProduct(long id)
        {
            return dbContext.SanPhams.Where(x => x.id == id).FirstOrDefault();
        }

        public bool checkProductExist(string barcode)
        {
            SanPham check = dbContext.SanPhams.Where(x => x.MaSanPham == barcode).FirstOrDefault();
            if (check != null)
            {
                return true;

            }

            return false;

        }


        public Response save(SanPham sanPham, List<DonViTinh_SanPham> donViTinh_SanPhams = null)
        {
            DbContextTransaction transaction = dbContext.Database.BeginTransaction();
            try
            {
                dbContext.SanPhams.Add(sanPham);
                if (dbContext.SaveChanges() > 0)
                {
                    if (donViTinh_SanPhams != null)
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
                transaction.Rollback();
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
            int unDelete = 0;
            int delete = 0;
            foreach (int item in products)
            {
                SanPham find = dbContext.SanPhams.Where(x => x.id == item).FirstOrDefault();
                if (find.ChiTietPhieuBanHangs.Count == 0)
                {
                    dbContext.SanPhams.Remove(find);
                    dbContext.SaveChanges();
                    delete++;
                }
                else
                {
                    unDelete++;
                }


            }
            return new Response(true, "Đã xóa " + delete + " sản phẩm và không thể xóa " + unDelete + " do sản phẩm đã phát sinh dữ liệu");

        }
    }
}
