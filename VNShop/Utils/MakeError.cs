using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VNShop.Utils
{
    class MakeError
    {
        public static string makeStrError(ValidationResult validationResult)
        {
            string str = "";
            foreach (var failer in validationResult.Errors)
            {
                str += failer.ErrorMessage+"\n";
            }
            return str;
        }
    }
}
