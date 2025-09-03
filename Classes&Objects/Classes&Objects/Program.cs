using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ElMotor emotor1 = new ElMotor("1PH7137-2NG03-0BC0", "Синхронний", 28, 3, 130);
            ElMotor emotor2 = new ElMotor("АІР 100 L4", "Асинхронний", 4, 3, 39);

            ElMotor.ShowList();
            emotor1.ShowInfo();
            emotor2.ShowInfo();
        }
    }
}