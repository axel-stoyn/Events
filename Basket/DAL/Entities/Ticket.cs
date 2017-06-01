using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.DAL.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Price { get; set; }

        //Many to many
        public ICollection<Event> Events { get; set; }
        public ICollection<User> Users { get; set; }

        public Ticket()
        {
            Events = new List<Event>();
            Users = new List<User>();
        }
    }
}
