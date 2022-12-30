using Newtonsoft.Json;
using System.Collections.Generic;
using VNShop.Models;
using VNShop.Models;
using System.Linq;
namespace VNShop.Controllers
{
     class ExportController:BaseController
    {
        public string exportUnit()
        {
            List<DonViTinh> unit = dbContext.DonViTinhs.ToList();

            List<VNShop.Models.JsonUnit> result = new List<JsonUnit>();
            foreach (DonViTinh unitItem in unit)
            {
                JsonUnit jsonUnit = new JsonUnit();
                jsonUnit.id = unitItem.id;
                jsonUnit.TenDonVi = unitItem.TenDonVi;
                result.Add(jsonUnit);
            }
            return JsonConvert.SerializeObject(result, Formatting.Indented);
        }

        public string exportProduct()
        {
            List<SanPham> product = dbContext.SanPhams.ToList();
            List<JsonProduct> result = new List<JsonProduct>();
            foreach(SanPham item in product)
            {
                JsonProduct productItem = new JsonProduct();
                productItem.id = item.id;
                productItem.TenSanPham = item.TenSanPham;
                productItem.MaSanPham = item.MaSanPham;
                productItem.GiaNhap = item.GiaNhap != null? (double)item.GiaNhap: 0;
                result.Add(productItem);
            }
            return JsonConvert.SerializeObject(result, Formatting.Indented);
        }
        public string exportDVT()
        {
            List<DonViTinh_SanPham> product = dbContext.DonViTinh_SanPham.ToList();
            List<JsonDVT> result = new List<JsonDVT>();
            foreach (DonViTinh_SanPham item in product)
            {
                JsonDVT productItem = new JsonDVT();
                productItem.sanphamId = (long)item.SanPham;
                productItem.donvitinhId = (long)item.DonViTinh;
                productItem.GiaLe = (double)item.GiaLe;
                productItem.GiaSi = (double)item.GiaSi;
                productItem.Primary = (bool)item.Selected;
                result.Add(productItem);
            }
            return JsonConvert.SerializeObject(result, Formatting.Indented);
        }
    }
}