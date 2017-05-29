using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.Models
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Localization { get; set; }
        public string Address { get; set; }

        [Display(Name = "Phone Namber")]
        public string PhoneNamber { get; set; }
    }
}
