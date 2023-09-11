using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KALKULyaTOR
{
    internal class Class1
    {
        public  static void Z1()
        {
            Console.WriteLine();
            Console.WriteLine("ВЫБЕРИТЕ ОПЕРАЦИЮ:");
            Console.WriteLine("1 - СЛОЖЕНИЕ, 2 - ВЫЧИТАНИЕ, 3 - ДЕЛЕНИЕ, 4 - УМНОЖЕНИЕ, 5 - ВОЗВЕСТИ В СТЕПЕНЬ, \n" +
                "6 - ИЗВЛЕЧЬ КОРЕНЬ, 7 - НАЙТИ ПРОЦЕНТ ОТ ЧИСЛА, 8 - НАЙТИ log, 9 - НАЙТИ sin, 10 - НАЙТИ ctg ");
            int vibor=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (vibor)
            {
                case 1:
                    Console.WriteLine("Вы выбрали сложение: ");
                    Slogenie.slogaem();
                    break;

                case 2:
                    Console.WriteLine("Вы выбрали вычитание: ");
                    Vichitanie.Vichitaem();
                    break;

                case 3:
                    Console.WriteLine("Вы выбрали деление: ");
                    Delenie.Delim();
                    break;

                case 4:
                    Console.WriteLine("Вы выбрали умножение: ");
                    Umnogenie.Umnogaem();
                    break;

                case 5:
                    Console.WriteLine("Вы выбрали возведение в степень: ");
                    Stepeni.Stepen();
                    break;

                case 6:
                    Console.WriteLine("Вы выбрали извлечение корня: ");
                    Koreni.Koren();
                    break;

                case 7:
                    Console.WriteLine("Вы выбрали процент числа: ");
                    Procenti.Procent();
                    break;

                case 8:
                    Console.WriteLine("Вы выбрали log: ");
                    LOG.log();
                    break;

                case 9:
                    Console.WriteLine("Вы выбрали sin: ");
                    SIN.sin();
                    break;

                case 10:
                    Console.WriteLine("Вы выбрали ctg: ");
                    CTG.ctg();
                    break;

               


            }

        }
    }
}
