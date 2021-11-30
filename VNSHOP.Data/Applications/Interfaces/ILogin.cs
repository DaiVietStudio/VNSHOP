using System;
using System.Collections.Generic;
using System.Text;
using VNSHOP.Data.Requests;
namespace VNSHOP.Data.Applications.Interfaces
{
    interface ILogin
    {
        ResponseRequest<Dictionary<string, string>> Login(LoginRequest loginRequest);


    }
}
