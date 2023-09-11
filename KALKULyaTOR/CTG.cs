using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALKULyaTOR
{
    internal class CTG
    {
        public static void ctg()
        {
            Console.Write("Введите число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double otvet = 1/Math.Tan(x);
            Console.Write("ОТВЕТ: " + otvet);
            Console.WriteLine();
            Class1.Z1();
        }
    }
}
