using System;
using System.Collections.Generic;
using System.Text;
using VNSHOP.Data.Applications.Interfaces;
using VNSHOP.Data.Requests;
using VNSHOP.Data.Models;
namespace VNSHOP.Data.Applications.Services
{
    class LoginService : ILogin
    {
        private QLBHContext dbContext = new QLBHContext();

        public ResponseRequest<Dictionary<string, string>> Login(LoginRequest request)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            return new ResponseRequest<Dictionary<string, string>>() { data = result, message = "Login thành công" };
        }
    }
}
