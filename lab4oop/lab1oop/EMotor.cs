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
        private string Name {get; set;}
        private string Type {get; set;}
        private int Power {get; set; }
        private int Phases {get; set;}
        private double Mass {get; set;}

        public int Voltage {get; set;}
        public int Efficiency {get; set;} // kkd
        public string MotorType
        {
            get { return Type; }
            set { Type = value; }
        }

        public int MotorPower
        {
            get { return Power; }
            set { Power = value; }
        }

        public double MassTon
        {
            get { return Mass / 1000; }
        }

        public string GetMotorName()
        {
            return Name;
        }

        public void IncMass(int increment)
        {
            Mass += increment;
        }
        public void ScaleEfficiency(ref int factor)
        {
            Efficiency *= factor;
            factor = Efficiency;
        }

        public EMotor(string name, string type, int power, int phases, double mass, int voltage, int efficiency)
        {
            Name = name;
            MotorType = type;
            MotorPower = power;
            Phases = phases;
            Mass = mass;
            Efficiency = efficiency;
            Voltage = voltage;
        }

        public EMotor()
        {
            Name = "Невідомий двигун";
            MotorType = "Невідомий";
            MotorPower = 0;
            Phases = 1;
            Mass = 1.0;
            Efficiency = 1;
            Voltage = 0;
        }

        public EMotor(string name, string type, int power)
        {
            Name = name;
            MotorType = type;
            MotorPower = power;
            Phases = 1;
            Mass = 1.0;
            Efficiency = 1;
            Voltage = 0;
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
                   $"Маса: {Mass} кг, або {MassTon} т\n" +
                   $"Напруга: {Voltage} кг\n" +
                   $"ККД: {Efficiency} кг\n";
        }

        public void ReplaceValues(string name, string type, int power, int phases, double mass, int voltage, int efficiency)
        {
            EMotor updated = new EMotor(name, type, power, phases, mass, voltage, efficiency);

            this.Name = updated.Name;
            this.Type = updated.Type;
            this.Power = updated.Power;
            this.Phases = updated.Phases;
            this.Mass = updated.Mass;
            this.Voltage = updated.Voltage;
            this.Efficiency = updated.Efficiency;
        }
    }
}
