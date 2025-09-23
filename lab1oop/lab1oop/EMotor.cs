using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1oop
{
    internal class EMotor
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }
        public int Phases { get; set; }
        public double Mass { get; set; }

        public EMotor(string name, string type, int power, int phases, double mass)
        {
            Name = name;
            Type = type;
            Power = power;
            Phases = phases;
            Mass = mass;
        }

        public string GetInfo()
        {
            return $"Двигун {Name}\n" +
                   $"Тип: {Type}\n" +
                   $"Потужність: {Power} кВт\n" +
                   $"Фази: {Phases}\n" +
                   $"Маса: {Mass} кг";
        }
    }
}
