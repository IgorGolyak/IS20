using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет Мир!!");
          
            Console.WriteLine("Как твое имя, человек?");
            string myName = Console.ReadLine();
            

            int age, weight, height;

            Console.WriteLine("Какой ваш возраст?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваш вес кг?");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваш рост см?");
            height = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Ваше имя: " + myName);
            Console.WriteLine("Ваш возраст: " + age+" лет");
            Console.WriteLine("Ваш рост: " + height/100.0+" метров");
            Console.WriteLine("Ваш вес: " + weight*1000+" грамм");
            Console.ReadKey(); 
            // my comment
            /* написать программу, которая спарашивает ваше имя, возраст, рост, вес в см,
             * вес в кг выводит сообщение
             * Ваше имя: ...
             * Ваш возраст: ...
             * Ваш рост: ...
             * Ваш вес: ...
             */
            
        }
    }
}
