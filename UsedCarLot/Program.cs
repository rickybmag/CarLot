using System;

namespace UsedCarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot = new CarLot();

            Console.WriteLine("Welcome to GC's Car Lot");

            lot.ListCars();
            lot.AddCar();

        }
    }
}
