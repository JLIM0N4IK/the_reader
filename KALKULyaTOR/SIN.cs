using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALKULyaTOR
{
    internal class SIN
    {
        public static void sin()
        {
            Console.Write("Введите число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double otvet = Math.Sin(x);
            Console.Write("ОТВЕТ: " + otvet);
            Console.WriteLine();
            Class1.Z1();
        }
            

    }
}
