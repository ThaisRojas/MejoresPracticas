using System.Collections.Generic;

namespace Best_Practices.Models
{
    public class HomeViewModel
    {
        public ICollection<Vehicle> Vehicles { get; set; }

        public HomeViewModel()
        {
            Vehicles = new List<Vehicle>();
        }
    }
}
