using System;
namespace Vehicle_App
{
    public class Car : Vehicles
    {

        public string Color { get; set; }

        public Car(string name, string model, int productionYear, int passengers, string color) 
        {
            this.Name = name;
            this.Model = model;
            this.ProductionYear = productionYear;
            this.Passengares = passengers;
            this.Color = color;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            
            Console.WriteLine("Vehicle Color: {0}\n", Color);
        }


    }
}
