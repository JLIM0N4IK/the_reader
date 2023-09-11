using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALKULyaTOR
{
    internal class Delenie
    {
        public static void Delim() 
        {
            Console.Write("Введите первое число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите второе число: ");
            int y = Convert.ToInt32(Console.ReadLine());
            int otvet = x / y;
            Console.Write("ОТВЕТ: " + otvet);
            Console.WriteLine();
            Class1.Z1();

        }

    }
}
