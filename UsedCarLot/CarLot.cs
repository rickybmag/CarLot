using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class CarLot
    {
        List<Car> Cars = new List<Car>();

        public CarLot()
        {
            Cars.Add(new Car("Chevy", "Suburban", 2021, 51000));
            Console.WriteLine();
            Cars.Add(new Car("Toyota", "Tacoma", 2022, 27000));
            Console.WriteLine();
            Cars.Add(new Car("Ford", "Bronco", 2022, 29000));
            Console.WriteLine();

            Cars.Add(new UsedCar("Chevy", "Impala", 1958, 200, 175000));
            Console.WriteLine();
            Cars.Add(new UsedCar("Dodge", "Ram", 2000, 15000, 100000));
            Console.WriteLine();
            Cars.Add(new UsedCar("Honda", "CR-V", 2012, 16000, 75000));
        }

        public void ListCars()
        {
            foreach (var car in Cars)
            {
                Console.WriteLine(car);
            }
        }

        public void AddCar()
        {
            Console.WriteLine("Please input the vehicle's information");

            string vehicleInfo = GetInput("Input new or used for the vehicle");

            if (vehicleInfo.ToLower() == "new")
            {
                string make = GetInput("Make: ");
                string model = GetInput("Model: ");
                int year = 2022;
                decimal price = decimal.Parse(GetInput("Price: "));

                Car newCar = new Car(make, model, year, price);
                Cars.Add(newCar);

                Console.WriteLine("Your new vehicle has been added to the car lot");
            }

            else if (vehicleInfo.ToLower() == "used")
            {
                string make = GetInput("Make: ");
                string model = GetInput("Model: ");
                int year = GetYear("Year: ");
                decimal price = GetPrice("Price: ");
                double mileage = GetMileage("Mileage: ");

                Car usedCar = new UsedCar(make, model, year, price, mileage);

                Cars.Add(usedCar);
                Console.WriteLine("Your used vehicle has been added to the car lot");
            }

            else
            {
                Console.WriteLine("Please enter new or used to add your vehicle to the car lot");
                AddCar();
            }
        }

        public string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }

        public int GetYear(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            int yearOutput = int.Parse(output);
            return yearOutput;
        }

        public decimal GetPrice(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            decimal priceOutput = decimal.Parse(output);
            return priceOutput;
        }

        public double GetMileage(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            double mileOutput = double.Parse(output);
            return mileOutput;
        }

    }
}
