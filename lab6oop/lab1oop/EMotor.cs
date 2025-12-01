using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab1oop
{
    internal class EMotor : IMotor, IComparable<EMotor>
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }
        public int Phases { get; set; }
        public double Mass { get; set; }

        public int Voltage { get; set; }
        public int Efficiency { get; set; } // kkd
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

        public int CompareTo(EMotor other)
        {
            if (other == null) return 1;
            return this.Power.CompareTo(other.Power);
        }
    }
}
