using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }

        [Display(Name = "Track No")]
        public string TrackNo { get; set; }
    }
}
