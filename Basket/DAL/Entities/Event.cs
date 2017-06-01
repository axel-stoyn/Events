using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.DAL.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Venue { get; set; }
        public byte[] Banner { get; set; }
        public string Description { get; set; }

        //One to many
        public ICollection<Venue> Venues { get; set; }

        public Event()
        {
            Venues = new List<Venue>();

            //Many to many
            Tickets = new List<Ticket>();
        }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
