using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.DAL.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //One to many
        public int? VenueId { get; set; }
        public Venue Venue { get; set; }
    }
}
