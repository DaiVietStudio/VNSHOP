using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNShop.Models
{
    class TypeCustomer
    {
        public TypeCustomer(int id, string ten)
        {
            this.id = id;
            Ten = ten;
        }

        public int id { get; set; }
        public string Ten { get; set; }
    }
}
