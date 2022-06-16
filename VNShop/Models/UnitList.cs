using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNShop.Models
{
    public class UnitList
    {
        public long id { get; set; }
        public string TenDonVi { get; set; }
        public double GiaLe { get; set; }
        public double GiaSi { get; set; }
        public bool Chinh { get; set; }
    }
}
