using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2oop
{
    internal class EMotor
    {
        public string Name { get; set; }
        private string Type;
        private int Power;
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

        public void SetType(string type) { Type = type; }
        public string GetType(string type) { return Type; }

        public void SetPower(int power) { Power = power; }
        public int GetPower() { return Power; }


        public override string ToString()
        {
            return $"Двигун {Name}\n" +
                   $"Тип: {Type}\n" +
                   $"Потужність: {Power} кВт\n" +
                   $"Фази: {Phases}\n" +
                   $"Маса: {Mass} кг";
        }
    }
}
