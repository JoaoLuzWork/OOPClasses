using System;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
           List<Car> cars = new List<Car>();

            cars.Add(new Car("Red", "4", 120.5));
            cars.Add(new Car("Blue", "2", 150.0));

            Console.WriteLine("\n\n---- List of Cars ----");
        
            foreach (var car in cars)
            {
                car.DisplayInfo();
            }
            Console.WriteLine("--------------------------\n\n");
        }
    }

    class Car
    {
        private string Colour { get; set; }
        private string NumberOfDoors { get; set; }
        private double Speed { get; set; }

        public Car(string colour, string numberOfDoors, double speed)
        {
            Colour = colour;
            NumberOfDoors = numberOfDoors;
            Speed = speed;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Colour: {Colour}, Number of Doors: {NumberOfDoors}, Speed: {Speed}");
        }
        
    }
}