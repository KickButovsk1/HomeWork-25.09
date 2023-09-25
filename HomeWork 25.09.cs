using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdfasdfasdf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y: ");
            double y = double.Parse(Console.ReadLine());
            bool result = ((y <= 4) && ((Math.Pow(x, 2) + Math.Pow(y, 2) >= 16) && (y >= -x)) || ((y <= 4) && (Math.Pow(x, 2) + Math.Pow(y, 2) >= 16) && (y <= x)));
            if (result == true)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.ReadKey();

        }
    }
}
