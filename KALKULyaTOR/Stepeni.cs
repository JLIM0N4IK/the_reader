using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALKULyaTOR
{
    internal class Stepeni
    {
        public static void Stepen()
        {
            Console.Write("Введите число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите степень ");
            double y = Convert.ToDouble(Console.ReadLine());
            double otvet =Math.Pow(x, y);
            Console.Write("ОТВЕТ: " + otvet);
            Console.WriteLine();
            Class1.Z1();
        }
    }
}
