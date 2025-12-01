using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10oop
{
    internal class Unit
    {
        public string Name { get; set; }     
        public string ShortName { get; set; } 
        public double ToMeters { get; set; } 

        public Unit(string name, string shortName, double toMeters)
        {
            Name = name;
            ShortName = shortName;
            ToMeters = toMeters;
        }

        public override string ToString()
        {
            return ShortName;
        }
    }
}
