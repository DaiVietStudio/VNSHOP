using System;
using System.Collections.Generic;
using System.Text;

namespace VNSHOP.Data.Requests
{
    class ResponseRequest<T>
    {
        public T data { get; set; }
        public string message { get; set; }
    }
}
