using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
	{
		public Truck()
		{
		}

        public string Model { get; set; } = "Tacoma";
        public string Make { get; set; } = "Toyota";
        public int Year { get; set; } = 2024;
        public string Logo { get; set; } = "Default";
        public string CompanyName { get; set; } = "Default";
        public int YearFounded { get; set; } = 1980;
        public double CustomerRating { get; set; } = 4.5;
        public bool HasChangedGears { get; set; } = true;

        public int NumberOfWheels { get; set; } = 4;
        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
            if(HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward.");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward.");
            }      

        }

        public void Reverse()
        {
            if (HasChangedGears == true)
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
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears.");
            }
        }

        public void ChangedGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Year: {Year}, Make:{Make}, Model:{Model}, Logo:{Logo}, Company Name:{CompanyName}, Year Founded:{YearFounded}, Customer Rating:{CustomerRating}, Number Of Wheels:{NumberOfWheels}, Has Four Wheel Drive:{HasFourWheelDrive}");
        }
    }
}

