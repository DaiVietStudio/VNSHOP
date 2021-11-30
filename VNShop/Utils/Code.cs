using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNShop.Utils
{
    class Code
    {
        public string genarateCode(string prefix)
        {
            DateTime current = new DateTime();
            Random random = new Random();
            return prefix + current.Millisecond+random.Next();
        }
    }
}
