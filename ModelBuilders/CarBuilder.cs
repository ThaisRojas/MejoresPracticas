using Best_Practices.Models;
using System;

namespace Best_Practices.ModelBuilders
{
    public class CarBuilder
    {
        private string Brand = "Ford";
        private string Model = "Mustang";
        private string Color = "Red";
        private int Year = DateTime.Now.Year;


        public CarBuilder SetBrand(string brand)
        {
            Brand = brand;
            return this;
        }


        public CarBuilder SetModel(string model)
        {
            Model = model;
            return this;
        }


        public CarBuilder SetColor(string color)
        {
            Color = color;
            return this;
        }


        public CarBuilder SetYear(int year)
        {
            Year = year;
            return this;
        }


        public Car Build()
        {
            var car = new Car(Color, Brand, Model);

            car.Year = Year;
            car.IsActive = true;
            car.RequiresMaintenance = false;

            return car;
        }
    }
}