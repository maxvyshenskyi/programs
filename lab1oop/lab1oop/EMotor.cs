using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

        public string GetName()
            { return $"Назва: {Name}\n"; }
        public string GetType()
            { return $"Тип: {Type}\n"; }
        public string GetPower()
        { return $"Потужність: {Power} кВт\n"; }
        public string GetPhases()
        { return $"К-сть фаз: {Phases}\n"; }
        public string GetMass()
        { return $"Вага: {Mass} кг\n"; }
    }
}
