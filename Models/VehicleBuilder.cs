using Best_Practices.Models;

namespace Best_Practices.Models
{
    public class VehicleBuilder
    {
        private Vehicle vehicle = new Car("", "", "");

        public VehicleBuilder SetBrand(string brand)
        {
            vehicle.Brand = brand;
            return this;
        }

        public VehicleBuilder SetModel(string model)
        {
            vehicle.Model = model;
            return this;
        }

        public VehicleBuilder SetColor(string color)
        {
            vehicle.Color = color;
            return this;
        }

        public Vehicle Build()
        {
            return vehicle;
        }
    }
}