using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1ый_урок;

namespace _3е_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r = (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            Console.Write("Рсстояние между точками x1,y1 и x2,y2 = {0:F}", r);

            Method.Pause();

        }
    }
}
