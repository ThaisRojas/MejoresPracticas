using System;

namespace Best_Practices.Models
{
    public abstract class Vehicle : IVehicle
    {
        #region Private properties

        private bool _isEngineOn { get; set; }

        #endregion


        #region Properties

        public readonly Guid ID;

        public virtual int Tires { get; set; }

        public string Color { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public double Gas { get; set; }

        public double FuelLimit { get; set; }

        public int Year { get; set; }

        public bool IsActive { get; set; }

        public bool RequiresMaintenance { get; set; }

        #endregion


        #region Constructors

        // Constructor para Builder
        protected Vehicle()
        {
            ID = Guid.NewGuid();
            FuelLimit = 10;
            Gas = 0;
            IsActive = true;
        }


        // Constructor original
        protected Vehicle(
            string color,
            string brand,
            string model,
            double fuelLimit = 10)
        {
            ID = Guid.NewGuid();

            Color = color;
            Brand = brand;
            Model = model;

            FuelLimit = fuelLimit;
            Gas = 0;
            IsActive = true;
        }

        #endregion


        #region Methods


        // Llena el tanque poco a poco
        public void AddGas()
        {
            if (Gas >= FuelLimit)
            {
                throw new Exception("Gas Full");
            }

            Gas += 0.1;

            if (Gas > FuelLimit)
            {
                Gas = FuelLimit;
            }
        }



        public void StartEngine()
        {
            if (_isEngineOn)
            {
                throw new Exception("Engine is already on");
            }


            if (NeedsGas())
            {
                throw new Exception(
                    "No enough gas. You need to go to Gas Station");
            }


            _isEngineOn = true;
        }



        public bool NeedsGas()
        {
            return Gas <= 0;
        }



        public bool IsEngineOn()
        {
            return _isEngineOn;
        }



        public void StopEngine()
        {
            if (!_isEngineOn)
            {
                throw new Exception("Engine already stopped");
            }

            _isEngineOn = false;
        }


        #endregion
    }
}