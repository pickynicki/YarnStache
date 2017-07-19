using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YarnStache.Models
{
    public class Yarn
    {   
        public Guid Id { get; set; }
        [Display(Name ="Color Family")]
        public string ColorFamily { get; set; }
        [Display(Name = "Color Name")]
        public string ColorName { get; set; }
        public string Brand { get; set; }
        public string Weight { get; set; }
        [Display(Name = "Dye Lot")]
        public string DyeLot { get; set; }
        [Display(Name = "Fiber Type")]
        public string FiberType { get; set; }
        public int Quantity { get; set; }
    }
}