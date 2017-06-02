using Basket.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.DAL.Entities
{
    public class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        //One to Many
        public int CityId { get; set; }
        public int? EventId { get; set; }
        public Event Event { get; set; }

        public ICollection<City> Cities { get; set; }
        public Venue()
        {
            Cities = new List<City>();
        }
    }
}
