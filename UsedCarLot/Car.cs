using System;
using System.Collections.Generic;
using System.Text;

namespace UsedCarLot
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public Car (string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }

        public override string ToString()
        {
            string output = $"Make: {Make}\n";
            output += $"Model: {Model}\n";
            output += $"Year: {Year}\n";
            output += $"Price: {Price}";
            return output;
        }                
    }
}
