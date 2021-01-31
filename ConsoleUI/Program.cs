using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
            private static object car;

        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("Güncel Araba Kataloğu");
            Console.WriteLine("----------------------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " " + car.DailyPrice + " TL");
                Console.WriteLine("----------------------------");
            }

        }
    }
    
}


