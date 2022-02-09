using System;
using System.Collections.Generic;
using System.Text;
using VNSHOP.Data.Applications.Interfaces;
using VNSHOP.Data.Requests;
using VNSHOP.Data.Models;
using System.Linq;

namespace VNSHOP.Data.Applications.Services
{
   public class LoginService : ILogin
    {
        private QLBHContext dbContext = new QLBHContext();

        public Dictionary<string, dynamic> Login(string username, string password)
        {
            Dictionary<string, dynamic> result = new Dictionary<string, dynamic>();
            TaiKhoan user = dbContext.TaiKhoans.FirstOrDefault(s => s.TenDangNhap == username);
            if (user != null)
            {
                if (BCrypt.Net.BCrypt.Verify(password.Trim(), user.MatKhau))
                {
                    result["status"] = true;
                    result["user"] = user.Id;
                    result["name"] = user.TenDangNhap;
                   
                }
                else
                {
                    result["status"] = false;
                    result["error"] = "Sai mật khẩu";
                }
            }
            else
            {
                result["status"] = false;
                result["error"] = "Tài khoản không tồn tại";
            }
            return result;
        }
    }
}
