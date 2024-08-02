using System;
namespace InterfaceExercise 
{
	public class Car : IVehicle, ICompany 
	{
      
        public string Model { get; set; } = "Generic";
        public string Make { get; set; } = "Generic";
        public int Year { get; set; } = 2024;
        public string Logo { get; set; } = "Default";
        public string OriginCountry { get; set; } = "Default";
        public int YearFounded { get; set; } = 0;
        public double CustomerRating { get; set; } = 4.5;
        public bool HasChangedGears { get; set; } = true;

        public int NumberOfDoors { get; set; }
        public bool Automatic { get; set; } = true;

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward.");

        }

        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing.");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears.");
            }
            
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now parked.");
                
            }
            else
            {
                Console.WriteLine("Can't park until we change gears.");
            }
        }


        public Car()
		{
		}
	
		public void DisplayDetails()
        {
            Console.WriteLine($"Year: {Year}, Make:{Make}, Model:{Model}, Logo:{Logo}, Origin Country:{OriginCountry}, Year Founded:{YearFounded}, Customer Rating:{CustomerRating}, NumberOfDoors:{NumberOfDoors}, Automatic:{Automatic}");
        }


	}
}

