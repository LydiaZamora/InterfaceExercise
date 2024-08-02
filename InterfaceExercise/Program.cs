using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           
     

            var myCar = new Car()
            {
                Make = "Toyota",
                Model = "Yaris IA",
                Year = 2017,
                Logo = "Toyota Logo",
                OriginCountry = "Japan",
                YearFounded = 1928,
                CustomerRating = 4.5,
                HasChangedGears = true,
                NumberOfDoors = 4
                
            };

            var newTruck = new Truck();
            newTruck.YearFounded = 1903;
            newTruck.OriginCountry = "USA";
            newTruck.HasChangedGears = true;
            newTruck.Make = "Ford";
            newTruck.Model = "Soemthing";
            newTruck.NumberOfWheels = 4;
            newTruck.Year = 1999;
            newTruck.Logo = "Ford logo";

            var usedSUV = new SUV();
            usedSUV.YearFounded = 1916;
            usedSUV.OriginCountry = "Germany";
            usedSUV.Year = 2018;
            usedSUV.HasChangedGears = false;
            usedSUV.HasTV = true;
            usedSUV.Logo = "BMW logo";
            usedSUV.LuxurySUV = true;
            usedSUV.Make = "BMW";
            usedSUV.Model = "older model";
           

            myCar.DisplayDetails();
            myCar.Drive();
            myCar.Reverse();
            myCar.Park();

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------");

            newTruck.DisplayDetails();
            newTruck.Drive();
            newTruck.Reverse();
            newTruck.Park();

            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            
            usedSUV.DisplayDetails();
            usedSUV.Drive();
            usedSUV.Reverse();
            usedSUV.Park();
            
        }
    }
}
