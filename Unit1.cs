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
        // объявление и инициализация переменных
        int integerValue = 10;
        float floatValue = 2.5F;
        double doubleValue = 3.14;
        char charValue = 'A';
        string stringValue = "Hello, World!";
        bool booleanValue = true;
        decimal decimalValue = 1234567890.987654321M;
        byte byteValue = 255;
        short shortValue = -32768;
        long longValue = 9223372036854775807;

        // вывод значений переменных в консоль
        Console.WriteLine("int integerValue = " + integerValue);
        Console.WriteLine("float floatValue = " + floatValue);
        Console.WriteLine("double doubleValue = " + doubleValue);
        Console.WriteLine("char charValue = " + charValue);
        Console.WriteLine("string stringValue = " + stringValue);
        Console.WriteLine("bool booleanValue = " + booleanValue);
        Console.WriteLine("decimal decimalValue = " + decimalValue);
        Console.WriteLine("byte byteValue = " + byteValue);
        Console.WriteLine("short shortValue = " + shortValue);
        Console.WriteLine("long longValue = " + longValue);

        }
    }
}
