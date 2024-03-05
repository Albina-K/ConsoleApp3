using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            Console.Write("Укажите возраст: ");
            var age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя {0}, и Вам {1}", name, age);
            Console.Write("Укажите дату рождения: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Ваш день рождения {0}", birthdate);
                     
            Console.ReadKey();
        }
          
    }
}

            
 