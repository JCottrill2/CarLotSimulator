using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
        }
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            CarLot.numberOfCars++;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; } = 2023;
        public string EngineNoise { get; set; } 
        public string HonkNoise { get; set; } = "Beep! Beep!";
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine($"My cars engine sounds like this {noise}");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"My cars honk sounds like this {HonkNoise}");
        }
        
    }
}
