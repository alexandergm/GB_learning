﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1ый_урок;

namespace _4е_задание_без_3ей_переменной
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1ое число:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите 2ое число:");
            int b = Convert.ToInt32(Console.ReadLine());

            a = a + b;

            b = a - b;

            a = a - b;

            Console.Write("a = " + a + ", b = " + b);

            Method.Pause();
        }
    }
}
