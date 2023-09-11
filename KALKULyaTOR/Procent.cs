using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALKULyaTOR
{
    internal class Procenti
    {
        public static void Procent()
        {
            Console.Write("Введите число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите процент:  ");
            double y = Convert.ToDouble(Console.ReadLine());
            double otvet = (x / 100) * y;
            Console.Write("ОТВЕТ: " + otvet);
            Console.WriteLine();
            Class1.Z1();
        }
    }
}
