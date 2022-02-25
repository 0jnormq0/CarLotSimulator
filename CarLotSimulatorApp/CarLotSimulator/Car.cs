using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }
                
        public void MakeEngineNoise(int year, string make, string model, string engineNoise)
        {
            Console.WriteLine($"Your {year} {make} {model} goes {engineNoise} when you rev the engine.");
        }

        public void MakeHonkNoise(int year, string make, string model, string honkNoise)
        {
            Console.WriteLine($"Press the horn on the {year} {make} {model} to hear a loud {honkNoise}!");
        }
    }
}
