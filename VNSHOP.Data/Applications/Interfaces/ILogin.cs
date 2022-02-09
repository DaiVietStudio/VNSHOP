using System;
using System.Collections.Generic;
using System.Text;
using VNSHOP.Data.Requests;
namespace VNSHOP.Data.Applications.Interfaces
{
    interface ILogin
    {
        Dictionary<string, dynamic> Login(string username, string password);


    }
}
