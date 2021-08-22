using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;
using VNShop.Controllers;
using Newtonsoft.Json;
using System.IO;
using Leaf.xNet;

namespace VNShop
{
    class ResourceController : BaseController
    {
        public List<Tinh> provinceList()
        {
            return dbContext.Tinhs.ToList();
        }
        public List<Huyen> districtList(long province)
        {
            return dbContext.Huyens.Where(x => x.Tinh == province).ToList();
        }

        public List<Xa> wardList(long district)
        {
            return dbContext.Xas.Where(x => x.Huyen == district).ToList();
        }

        public void backUp()
        {
            JsonSerializerSettings jss = new JsonSerializerSettings();
            jss.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            List<SanPham> listProduct = dbContext.SanPhams.ToList();
            List<DonViTinh> unitList = dbContext.DonViTinhs.ToList();
            List<DonViTinh_SanPham> unitProductList = dbContext.DonViTinh_SanPham.ToList();
            string jsonProduct = JsonConvert.SerializeObject(listProduct, jss);
            string jsonUnit = JsonConvert.SerializeObject(unitList, jss);
            string jsonUnitProduct = JsonConvert.SerializeObject(unitProductList, jss);

            string path = @"C:\";
            File.WriteAllText(path + "product_bk.json", jsonProduct);
            File.WriteAllText(path + "unit_bk.json", jsonUnit);
            File.WriteAllText(path + "unitproduct_bk.json", jsonUnitProduct);

            HttpRequest httpRequest = new HttpRequest();
            //httpRequest.AddHeader("UserAgent", "VNSHOP-CZU5A6");
            httpRequest.UserAgent = "VNSHOP-CZU5A6";
            var paramLogin = new RequestParams();
            paramLogin["user_email"] = "{{hacker11357@gmail.com}}";
            paramLogin["password"] = "{{ipwX9ebQDzHu-d-}}";
            paramLogin["app_key"] = "{{dMnqMMZMUnN5YpvKENaEhdQQ5jxDqddt}}";

            HttpResponse httpResponse = httpRequest.Post(@"https://api.fshare.vn/api/user/login", paramLogin);



        }
    }
}
