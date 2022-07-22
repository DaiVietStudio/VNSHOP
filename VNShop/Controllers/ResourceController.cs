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

        public void setUser()
        {
            TaiKhoan account = dbContext.TaiKhoans.FirstOrDefault();
            Program.idUser = account.NhanVien1.id;
        }
    }
}
