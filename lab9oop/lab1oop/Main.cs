using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1oop
{
    internal static class Main
    {
        public static List<EMotor> Motors { get; private set; }

        static Main()
        {
            Motors = new List<EMotor>
            {
                new EMotor("Siemens 1LE1001-1AA4","Асинхронний", 3, 3, 21, 45, 50),
                new EMotor("Tesla Model 3 Rear Drive Unit", "Синхронний", 239, 1, 80, 70, 55),
                new EMotor("Nidec Motor 4 POLE", "Синхронний", 45)
            };

            Motors.Add(new EMotor("ABB M3BP", "Асинхронний", 15, 3, 32, 400, 92));
            Motors.Add(new EMotor("General Electric 5KCP39", "Асинхронний", 4, 1, 12, 220, 88));
            Motors.Add(new EMotor("WEG W22", "Асинхронний", 22, 3, 40, 380, 93));

            Motors.Insert(0, new EMotor("YE2-90", "Асинхронний", 1, 3, 9, 220, 80));
            Motors.Insert(2, new EMotor("Hitachi SEM", "Синхронний", 75, 3, 65, 400, 92));
        }
    }
}
