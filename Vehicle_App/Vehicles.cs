using System;
namespace Vehicle_App
{
    public class Vehicles
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public int Passengares { get; set; }


        
        public virtual void DisplayInfo()
        {
            
            Console.WriteLine("Vehicle Name: {0}\n\nVehicle Model: {1}\n\nProduction Year: {2}\n\nPassengsers Capacity: {3}\n", Name, Model, ProductionYear, Passengares);

        }


        
    }
}
