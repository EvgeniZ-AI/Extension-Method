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

            var deliveres = new List<amountOfCoal>();//Создаю коллекцию обьектов поставок угля

            for (int i = 0; i < 10; i++)
            {
                var dev = new amountOfCoal();// обьявляю новый обьект поставок угля
                dev.createRandomDeliveris(100, 10000);// заполняю данные поставок угля
                deliveres.Add(dev);// добовляю обьект поставок угля в коллекцию
            }

            var devName = deliveres.ConvertToString(); // конвертирую всю коллекцию в строку
            Console.WriteLine(devName); // Вывожу её в консоль

            var lastDelivery = new amountOfCoal();
            lastDelivery.createRandomDeliveris(100, 10000);

            Console.WriteLine($"{lastDelivery.ToString()} Энергия в поставке - {lastDelivery.isCoal()} кВт-ч");
        }
    }
}
//*-Создать метод расширения для sealed-класса из внешней библиотеки