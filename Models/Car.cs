using System;

namespace Best_Practices.Models
{
    public class Car : Vehicle
    {
        public override int Tires
        {
            get { return 4; }
            set { }
        }

        public Car(string color, string brand, string model)
            : base(color, brand, model)
        {
        }
    }
}