using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VNShop.Models;
namespace VNShop.Controllers
{
    class BaseController
    {
       protected QLBHEntities dbContext = new QLBHEntities();
        

    }
}
