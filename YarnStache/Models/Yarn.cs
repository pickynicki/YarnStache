using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YarnStache.Models
{
    public class Yarn
    {   
        public Guid Id { get; set; }
        public string ColorFamily { get; set; }
        public string ColorName { get; set; }
        public string Brand { get; set; }
        public string Weight { get; set; }
        public string DyeLot { get; set; }
        public string FiberType { get; set; }
        public int Quantity { get; set; }
    }
}