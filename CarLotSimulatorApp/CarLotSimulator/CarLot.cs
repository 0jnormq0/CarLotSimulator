using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    //Create a CarLot class
    //It should have at least one property: a List of cars
    public class CarLot
    {
        public List<string> CarList { get; set; }

        public CarLot()
        {
            CarList = new List<string>();
        }
        public string CarName(int year, string make, string model)
        {
            var name = year.ToString() + " " + " " + make + " " + model;
            return name;
        }
    } 
}
