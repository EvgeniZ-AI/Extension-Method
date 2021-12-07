using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колличество угля");
            int coalFuel = int.Parse(Console.ReadLine());

            int Energy = coalFuel.isCoal();
            Console.WriteLine($"Получится {Energy} кВт-ч ");

            var deliveres = new List<amountOfCoal>();

            for (int i = 0; i < 10; i++)
            {
                var dev = new amountOfCoal();
                dev.createRandomDeliveris(100, 10000);
                deliveres.Add(dev);
            }

            var devName = deliveres.ConvertToString();
            Console.WriteLine(devName);
        }
    }
}
//*-Создать метод расширения для sealed-класса из внешней библиотеки