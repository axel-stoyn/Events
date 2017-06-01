using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.DAL.Entities
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

        //Many to many
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<Order> Orders { get; set; }
        public User()
        {
            Tickets = new List<Ticket>();
            Orders = new List<Order>();
        }
    }
}
