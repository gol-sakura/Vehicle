using System;
namespace Vehicle_App
{
    public class Spacecraft : Vehicles
    {
        public string EngineType { get; set; }
        public string Captain { get; set; }

        public Spacecraft(string name, string model, int productionYear, int passengers, string engineType, string captain)
        {
            this.Name = name;
            this.Model = model;
            this.ProductionYear = productionYear;
            this.Passengares = passengers;
            this.EngineType = engineType;
            this.Captain = captain;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Vehicle Engine Type: {0}\n\nVehicle Captain: {1}\n", EngineType, Captain);
        }
    }
}
