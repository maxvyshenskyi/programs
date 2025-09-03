using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects
{
    internal class ElMotor
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }
        public int PhasesAmount { get; set; }
        public int Weight { get; set; }
        private static List<ElMotor> elMotors = new List<ElMotor>();

        public ElMotor(string Name, string Type, int Power, int PhasesAmount, int Weight)
        {
            this.Name = Name;
            this.Type = Type;
            this.Power = Power;
            this.PhasesAmount = PhasesAmount;
            this.Weight = Weight;
            elMotors.Add(this);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Характеристики моделі {Name}:");
            Console.WriteLine($"Тип двигуна: {Type}");
            Console.WriteLine($"Потужнісь двигуна: {Power} кВт");
            Console.WriteLine($"Кількість фаз двигуна: {PhasesAmount}");
            Console.WriteLine($"Маса двигуна: {Weight} кг");
            Console.WriteLine("");
        }
        public void ShowName()
        {
            Console.WriteLine($"{Name}");
        }
        public static void ShowList()
        {
            Console.WriteLine("Список збережених моделей двигунів:");
            foreach (var ElMotor in elMotors)
            {
                ElMotor.ShowName();
            }
            Console.WriteLine("");
        }
    }
}
