using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;
using VNShop.Controllers;
namespace VNShop
{
    class ResourceController:BaseController
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
    }
}
