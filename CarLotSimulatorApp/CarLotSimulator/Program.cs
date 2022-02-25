using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            //TODO

            //Create a separate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            //Instanciate the Carlot class
            CarLot cars = new CarLot();
            
            //Instantiate 2 new cars
            var wheelsOne = new Car();
            var wheelsTwo = new Car();
            
            //Set the properties for car 1
            var yearOne = wheelsOne.Year;
            yearOne = 1989;

            var makeOne = wheelsOne.Make;
            makeOne = "Ford";

            var modelOne = wheelsOne.Model;
            modelOne = "Bronco";

            var engineOne = wheelsOne.EngineNoise;
            engineOne = "GrrrrGrrrGurrrrrRrrrr";

            var honkOne = wheelsOne.HonkNoise;
            honkOne = "BurrrrrP";

            var canRunOne = wheelsOne.IsDriveable;
            canRunOne = true;

            //Create the name of the car using the CarName method
            var carOne = cars.CarName(yearOne, makeOne, modelOne);

            //Add car to the list
            cars.CarList.Add(carOne);

            //Set the properties for car 2
            wheelsTwo.Year = 2013;
            wheelsTwo.Make = "Chevy";
            wheelsTwo.Model = "Sonic";
            wheelsTwo.EngineNoise = "GuhguhguhGUHGUH";
            wheelsTwo.HonkNoise = "beepbeep";
            wheelsTwo.IsDriveable = true;

            //Create the name of the car using the CarName method
            var carTwo = cars.CarName(wheelsTwo.Year, wheelsTwo.Make, wheelsTwo.Model);

            //Add car to the list
            cars.CarList.Add(carTwo);

            //Instantiate car 3 and set the properties
            Car wheelsThree = new Car()
            {
                Year = 1908,
                Make = "Ford",
                Model = "Model T",
                EngineNoise = "Glugluglugluglug lug",
                HonkNoise = "AHOOga",
                IsDriveable = false

            };

            //Create the name of the car using the CarName method
            var carThree = cars.CarName(wheelsThree.Year, wheelsThree.Make, wheelsThree.Model);

            //Add car to the list
            cars.CarList.Add(carThree);

            //Call each of the methods for each car
            wheelsOne.MakeEngineNoise(yearOne, makeOne, modelOne, engineOne);
            wheelsOne.MakeHonkNoise(yearOne, makeOne, modelOne, honkOne);

            //add space
            Console.WriteLine("");

            wheelsTwo.MakeEngineNoise(wheelsTwo.Year, wheelsTwo.Make, wheelsTwo.Model, wheelsTwo.EngineNoise);
            wheelsTwo.MakeHonkNoise(wheelsTwo.Year, wheelsTwo.Make, wheelsTwo.Model, wheelsTwo.HonkNoise);

            //add space
            Console.WriteLine("");

            wheelsThree.MakeEngineNoise(wheelsThree.Year, wheelsThree.Make, wheelsThree.Model, wheelsThree.EngineNoise);
            wheelsThree.MakeHonkNoise(wheelsThree.Year, wheelsThree.Make, wheelsThree.Model, wheelsThree.HonkNoise);

            //Iterate through the list printing each of the cars' Year, Make, and Model to the console
            Console.WriteLine("");
            Console.WriteLine("Here's your list of cars:");
            foreach (string car in cars.CarList)
            {
                Console.WriteLine(car);
            }
        }
    }
}
