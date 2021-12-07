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

            Console.WriteLine($"Получится {coalFuel.isCoal()} кВт-ч ");
        }
    }
}
//Создать метот расширения для стандартного типа данных
//Создать метот расширения для интерфейса
//*-Создать метод расширения для sealed-класса из внешней библиотеки