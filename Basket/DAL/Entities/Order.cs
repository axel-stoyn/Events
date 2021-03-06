﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.DAL.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }

        [Display(Name = "Track No")]
        public string TrackNo { get; set; }

        //Many to many
        public ICollection<User> Users { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

        public Order()
        {
            Users = new List<User>();
            Tickets = new List<Ticket>();
        }
    }
}
