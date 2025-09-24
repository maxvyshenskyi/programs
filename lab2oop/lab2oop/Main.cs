﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2oop
{
    internal static class Main
    {
        public static List<EMotor> Motors { get; private set; }

        static Main()
        {
            Motors = new List<EMotor>
            {
                new EMotor("Siemens 1LE1001-1AA4","Асинхронний", 3, 3, 21),
                new EMotor("Tesla Model 3 Rear Drive Unit", "Синхронний", 239, 1, 80)
            };
        }
    }
}
