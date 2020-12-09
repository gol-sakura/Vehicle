using System;

namespace Vehicle_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Vehicles myvehicle = new Vehicles();

            //myvehicle.DisplayInfo();

            Car mycar = new Car("Ford Mustang", "GT", 1964, 4, "Black");
            // mycar.DisplayInfo();

            Spacecraft mySpaceCraft = new Spacecraft("Enterprise", "Galaxy-Class-Starship NCC-1701", 2245, 1012, "Warp Engine Nacelles", "Picard");
            // mySpaceCraft.DisplayInfo();


            Aircraft myAirCraft = new Aircraft("F-16", "Fighting Falcon", 1972, 1, 2414);
            // myAirCraft.DisplayInfo();

          
            bool exit = false;
            

            while (!exit)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("--- CHOOSE AN OPTION FROM THE LIST ---");
                Console.WriteLine("------------------------------------\n");

                Console.WriteLine("\t1 - Car\n");
                Console.WriteLine("\t2 - SpaceCraft\n");
                Console.WriteLine("\t3 - AirCraft\n");
                Console.WriteLine("\t4 - Exit\n");
                Console.WriteLine("\n");
                Console.WriteLine("Your option? ");


                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("--- Car Details ---\n");
                        mycar.DisplayInfo();
                        break;
                    case "2":
                        Console.WriteLine("--- Spacecraft Details ---\n");
                        mySpaceCraft.DisplayInfo();
                        break;
                    case "3":
                        Console.WriteLine("--- Aircraft Details ---\n");
                        myAirCraft.DisplayInfo();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }               
            }   

        }
    }
}
