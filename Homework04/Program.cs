using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{

    

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объекты класса Car с использованием разных конструкторов
            Car car1 = new Car("Toyota", "Camry", 2022, 25000.0, false);
            Car car2 = new Car("Honda", "Civic", 2023, 22000.0);

            // Взаимодействие с объектами
            Console.WriteLine("Car 1: Make = " + car1.Make + ", Model = " + car1.Model + ", Year = " + car1.Year);
            Console.WriteLine("Car 2: Make = " + car2.Make + ", Model = " + car2.Model + ", Year = " + car2.Year);

            car1.StartEngine();
            car1.Accelerate();

            car2.StartEngine();
            car2.Accelerate();

            // Изменение цены по ссылке
            double newPrice = 27000.0;
            car1.ModifyPrice(ref newPrice);
            Console.WriteLine("New price of Car 1: " + car1.Price);

            // Статические поля
            Console.WriteLine("Number of Cars: " + Car.NumberOfCars);
            Console.WriteLine("Car Category: " + Car.CarCategory);
        }
    }



}
