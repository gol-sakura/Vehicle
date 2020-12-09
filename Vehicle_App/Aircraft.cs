using System;
namespace Vehicle_App
{
    public class Aircraft : Vehicles
    {
        public int TopSpeed { get; set; }

        public Aircraft(string name, string model, int productionYear, int passengers, int topSpeed)
        {
            this.Name = name;
            this.Model = model;
            this.ProductionYear = productionYear;
            this.Passengares = passengers;
            this.TopSpeed = topSpeed;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Vehicle Speed: {0} Km/h", TopSpeed);
        }
    }
}
