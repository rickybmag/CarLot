using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar (string Make, string Model, int Year, decimal Price, double Mileage) : base (Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }

        public override string ToString()
        {
            string output = $"Make: {Make}\n";
            output += $"Model: {Model}\n";
            output += $"Year: {Year}\n";
            output += $"Price: {Price}\n";
            output += $"Mileage: {Mileage}";
            return output;
        }
    }
}
