using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALKULyaTOR
{
    internal class Koreni
    {
        public static void Koren()
        {
            Console.Write("Введите число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double otvet =Math.Sqrt(x);
            Console.Write("ОТВЕТ: " + otvet);
            Console.WriteLine();
            Class1.Z1();
        }
    }
}
