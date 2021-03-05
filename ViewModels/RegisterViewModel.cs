
using System.ComponentModel.DataAnnotations;

namespace Practise.ViewModels
{
    public class RegisterViewModel
    {
        public string Name { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}        
