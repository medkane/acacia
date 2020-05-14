using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace acacia_web.Models
{
    public class Animal:IOmnivore
    {
        public String Name { get; set; }
        public int Age { get; set; }
        public string Regime { get; set; }
    }
}
