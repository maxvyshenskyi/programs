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
        private string Name { get; set; }
        private string Type { get; set; }
        private int Power { get; set; }
        private int Phases { get; set; }
        private double Mass { get; set; }

        public string GetMotorName()
        {
            return Name;
        }

        public EMotor(string name, string type, int power, int phases, double mass)
        {
            Name = name;
            Type = type;
            Power = power;
            Phases = phases;
            Mass = mass;
        }

        public EMotor()
        {
            Name = "Невідомий двигун";
            Type = "Невідомий";
            Power = 0;
            Phases = 1;
            Mass = 1.0;
        }

        public EMotor(string name, string type, int power)
        {
            Name = name;
            Type = type;
            Power = power;
            Phases = 1;
            Mass = 1.0;
        }

        public string GetName()
            { return $"{Name}"; }
        public string GetType()
            { return $"{Type}"; }
        public string GetPower()
        { return $"{Power}"; }
        public string GetPhases()
        { return $"{Phases}"; }
        public string GetMass()
        { return $"{Mass}"; }

        public void SetType(string type)
        { 
            Type = type;
        }
        public void SetPower(int power)
        {
            Power = power;
        }

        public override string ToString()
        {
            return $"Двигун {Name}\n" +
                   $"Тип: {Type}\n" +
                   $"Потужність: {Power} кВт\n" +
                   $"К-сть фаз: {Phases}\n" +
                   $"Маса: {Mass} кг\n";
        }

        public void ReplaceValues(string name, string type, int power, int phases, double mass)
        {
            EMotor updated = new EMotor(name, type, power, phases, mass);

            this.Name = updated.Name;
            this.Type = updated.Type;
            this.Power = updated.Power;
            this.Phases = updated.Phases;
            this.Mass = updated.Mass;
        }
    }
}
