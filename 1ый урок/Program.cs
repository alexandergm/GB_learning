using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _1ый_урок
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя:");
            string Fname = Console.ReadLine();

            Console.Write("Введите свою фамилию:");
            string Sname = Console.ReadLine();

            Console.Write("Введите свой возраст:");
            string age = Console.ReadLine();

            Console.Write("Введите свой рост:");
            string high = Console.ReadLine();

            Console.Write("Введите свой вес:");
            string weight = Console.ReadLine();

            Console.WriteLine("Товарищ " +Fname + " " + Sname + "! Вам "+ age + " лет, Ваш рост равен " + high + " см, А ваш вес равняется " + weight + " кг");
            Console.WriteLine($"Товарищ {Fname} {Sname} , Вам {age} лет, Ваш рост = {high}, А ваш вес равняется {weight} кг.  ");
            
            Method.Pause();


        }

      
    }
}
