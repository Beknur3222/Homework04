using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04
{


    using System;

    public partial class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;
        private bool isRunning;
        private static int numberOfCars;
        private static string carCategory = "Седан";

        public Car()
        {
            make = "Unknown";
            model = "Unknown";
            year = DateTime.Now.Year;
            price = 0.0;
            isRunning = false;
            numberOfCars++;
        }

        public Car(string make, string model, int year, double price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            isRunning = false;
            numberOfCars++;
        }

        public Car(string make, string model, int year, double price, bool isRunning)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.isRunning = isRunning;
            numberOfCars++;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool IsRunning
        {
            get { return isRunning; }
            set { isRunning = value; }
        }

        public void StartEngine()
        {
            isRunning = true;
        }

        public void StopEngine()
        {
            isRunning = false;
        }

        public void ModifyPrice(ref double newPrice)
        {
            price = newPrice;
        }

        public static int NumberOfCars
        {
            get { return numberOfCars; }
        }

        public static string CarCategory
        {
            get { return carCategory; }
            set { carCategory = value; }
        }
    }

    public partial class Car
    {
        public void Accelerate()
        {
            if (isRunning)
            {
                Console.WriteLine("The car is accelerating.");
            }
            else
            {
                Console.WriteLine("Start the engine first.");
            }
        }
    }





}
