using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO 
            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

            var myCar = new Car();

            var newTruck = new Truck();

            var usedSUV = new SUV();

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
