using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte petrol = 0;
            sbyte credit = -128;
            short unit = 4;
            int ships = 3;
            uint gold = 4000000000;
            float coordinates = 2.0f;
            string str1 = "Всем Привет";
            long credit2 = -900000;
            ulong metall = 345;
            char simbol = 'd';
            Console.WriteLine("Количество бензина " + petrol);
            Console.WriteLine("Деньги котрые должен отдать " + credit);
            Console.WriteLine("Количество юнитов " + unit);
            Console.WriteLine("Количество кораблей в порту " + ships);
            Console.WriteLine("Количество золота " + gold);
            Console.WriteLine("Координаты хз чего " + coordinates);
            Console.WriteLine("Строка приветствия " + str1);
            Console.WriteLine("Задолжность " + credit2);
            Console.WriteLine("Количество металла " + metall);
            Console.WriteLine("Символ " + simbol);
            Console.ReadKey();
        }
    }
}
