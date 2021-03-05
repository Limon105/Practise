using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practise.ViewModels
{
    public class LoginViewModel
    {
        public string Name { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
