using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNShop.Models
{
    class Response
    {
        public bool status { get; set; }
        public string message { get; set; }

        public Response(bool status, string message)
        {
            this.status = status;
            this.message = message;
        }
    }
}
