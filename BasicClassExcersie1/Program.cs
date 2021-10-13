using System;
using System.Collections.Generic;

namespace BasicClassExcersie1
{
    class Program
    {

        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "Accord";
            myCar.Year = 2021;


            var nissan = new Car()
            {
                Make = "Nissan",
                Model = "Altima",
                Year = 2020

            };


            var toyota = new Car("Toyota", "Camry", 2022);

            var carList = new List<Car>(){myCar,nissan,toyota};
            Console.WriteLine(carList.Capacity);
            Console.WriteLine($"This car dealer have  following cars in stock for this month :");

            foreach (var item in carList)
            {
               
                Console.WriteLine($"{item.Make} {item.Model} {item.Year}");
            }
        }


    }
}
