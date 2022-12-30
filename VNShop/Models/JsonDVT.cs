using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNShop.Models
{
    class JsonDVT
    {
        public long sanphamId { get; set; }
        public long donvitinhId { get; set; }

        public double GiaLe { get; set; }
        public double GiaSi { get; set; }
        public bool Primary { get; set; }
    }
}
