using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Best_Practices.Repositories
{
    public class MyVehiclesRepository : IVehicleRepository
    {
        private readonly List<Vehicle> vehicles = new List<Vehicle>();


        public void AddVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }


        public Vehicle Find(Guid id)
        {
            return vehicles.FirstOrDefault(x => x.ID == id);
        }


        public IEnumerable<Vehicle> GetAll()
        {
            return vehicles;
        }
    }
}
