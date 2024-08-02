using System;
namespace InterfaceExercise
{
    public interface IVehicle 
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public bool HasChangedGears { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        

        public void DisplayDetails();
    }
}

