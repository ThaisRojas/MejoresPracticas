using Best_Practices.Models;
using System;
using System.Collections.Generic;

namespace Best_Practices.Repositories
{
    public interface IVehicleRepository
    {
        void AddVehicle(Vehicle vehicle);

        Vehicle Find(Guid id);

        IEnumerable<Vehicle> GetAll();
    }
}