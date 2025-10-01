using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Carpet_Shop.Models
{
    public class carpet
    {
        public double length { get; set; }
        public double width { get; set; }
        public double price { get; set; }

        public double area()
        {
            return (length * width);
        }
        public double calcCost()
        {
            return (area() * price);
        }
        public double disc()
        {
            double d = 0.0;
            if(calcCost() > 2000)
            {
                d = calcCost()*(10/100.0);
            }
            return d;
        }
        public double final()
        {
            return(calcCost()-disc());
        }
    }
}