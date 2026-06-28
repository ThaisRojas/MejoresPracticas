using Best_Practices.Infraestructure.Singletons;
using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Best_Practices.Repositories
{
    // SRP (Single Responsibility): Este repositorio es la única clase
    // responsable de gestionar la persistencia en memoria.
    public class InMemoryVehicleRepository : IVehicleRepository
    {
        private readonly VehicleCollection collection;

        public InMemoryVehicleRepository()
        {
            collection = VehicleCollection.Instance;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            collection.Vehicles.Add(vehicle);
        }

        public Vehicle Find(Guid id)
        {
            return collection.Vehicles.FirstOrDefault(v => v.ID == id);
        }

        public IEnumerable<Vehicle> GetAll()
        {
            return collection.Vehicles;
        }
    }
}