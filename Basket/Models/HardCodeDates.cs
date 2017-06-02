using Basket.DAL.EF;
using Basket.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.Models
{
    public static class HardCodeDates
    {
        public static void Initialize(EventBasketContext context)
        {
            var city1 = new City
            {
                Id = 1,
                Name = "Los Angeles"
            };
            var city2 = new City
            {
                Id = 2,
                Name = "Detroid"
            };
            var city3 = new City
            {
                Id = 3,
                Name = "Manhattan"
            };
            var city4 = new City
            {
                Id = 4,
                Name = "New York"
            };
            var city5 = new City
            {
                Id = 5,
                Name = "National City"
            };
            var city6 = new City
            {
                Id = 6,
                Name = "Central City"
            };

            context.Cities.AddRange(city1, city2, city3, city4, city5, city6);

            //Vanues for first city
            var venue1 = new Venue
            {
                Id = 1,
                Name = "National Hall",
                Address = "La Plaza",
                CityId = city1.Id
            };
            var venue2 = new Venue
            {
                Id = 2,
                Name = "La Plaza",
                Address = "Sanset street",
                CityId = city1.Id
            };

            //Venues for second city
            var venue3 = new Venue
            {
                Id = 3,
                Name = "Ford Field",
                Address = "Madison street",
                CityId = city2.Id
            };
            var venue4 = new Venue
            {
                Id = 4,
                Name = "DTE Plaza",
                Address = "Bagly avenues",
                CityId = city2.Id
            };

            //Venues for thirth city
            var venue5 = new Venue
            {
                Id = 5,
                Name = "Park Place",
                Address = "Barkly street",
                CityId = city3.Id
            };
            var venue6 = new Venue
            {
                Id = 6,
                Name = "Broodway",
                Address = "Biver street",
                CityId = city3.Id
            };

            //Venues for fourth city
            var venue7 = new Venue
            {
                Id = 7,
                Name = "Ambasador",
                Address = "7 avenues",
                CityId = city4.Id
            };
            var venue8 = new Venue
            {
                Id = 8,
                Name = "Times Square",
                Address = "11 avenues",
                CityId = city4.Id
            };

            //Venues for fifth city
            var venue9 = new Venue
            {
                Id = 9,
                Name = "Matthew's",
                Address = "12th street Lofts",
                CityId = city5.Id
            };
            var venue10 = new Venue
            {
                Id = 10,
                Name = "West Hall",
                Address = "12th street Barber",
                CityId = city5.Id
            };

            //Venues for sixth city
            var venue11 = new Venue
            {
                Id = 11,
                Name = "Hilton",
                Address = "Charles Avenue",
                CityId = city6.Id
            };
            var venue12 = new Venue
            {
                Id = 12,
                Name = "St. Pierre",
                Address = "Royal Street",
                CityId = city6.Id
            };

            context.Venues.AddRange(venue1, venue2, venue3, venue4, venue5, venue6, venue7, venue8, venue9, venue10, venue11, venue12);
        }
    }
}
