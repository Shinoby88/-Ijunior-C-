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
         byte litersPetrol = 0;
         sbyte creditFirst = -128;
         short units = 4;
         int ships = 3;
         uint goldBalance = 4000000000;
         float coordinatesAxisY = 2.0f;
         string nameHero = "Арагорн";
         long creditSecond = -900000;
         ulong metallQuantity = 345;
         char zodiakSign = 'd';
         Console.WriteLine("Количество бензина " + litersPetrol);
         Console.WriteLine("Деньги котрые должен отдать " + creditFirst);
         Console.WriteLine("Количество юнитов " + units);
         Console.WriteLine("Количество кораблей в порту " + ships);
         Console.WriteLine("Количество золота " + goldBalance);
         Console.WriteLine("Координаты хз чего " + coordinatesAxisY);
         Console.WriteLine("Как зовут героя" + nameHero);
         Console.WriteLine("Задолжность " + creditSecond);
         Console.WriteLine("Количество металла " + metallQuantity);
         Console.WriteLine("Символ " + zodiakSign);
         Console.ReadKey();
        

        }
    }
}
