using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1ый_урок;

namespace _2ое_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваш вес:");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите ваш рост в сантиметрах:");
            int height = Convert.ToInt32(Console.ReadLine());

            double a = height / 100;

            double IMT = (weight / (a * a));

            Console.Write($"Ваш Индекс массы тела равен {IMT}");

            Method.Pause();
        }
    }
}
