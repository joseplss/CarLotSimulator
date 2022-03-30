using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//
            var carLot = new CarLot();

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            var mazda = new Car();
            mazda.Make = "Mazda";
            mazda.Model = "CX-5";
            mazda.Year = 2016;
            mazda.IsDrivable = true;
            mazda.EngineNoise = "Zoom zoom";
            mazda.HonkNoise = "beeeep!";

            carLot.ParkingLot.Add(mazda);

            //object initializer syntax
            var ford = new Car()
            {
                Make = "Ford",
                Model = "Focus",
                Year = 2005,
                IsDrivable = false,
                EngineNoise = "shake shake shake die",
                HonkNoise = "beep"
            };
            carLot.ParkingLot.Add(ford);

            //custome constructor
            var jeep = new Car(2020, "Jeep", "Wrangler Unlimited", "vroom!", "HONK!", true);
            carLot.ParkingLot.Add(jeep);
            
            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars - done
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list. - done
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach (var eachCar in carLot.ParkingLot)
            {
                Console.WriteLine($"{eachCar.Year} {eachCar.Make} {eachCar.Model}");
                eachCar.MakeEngineNoise();
                eachCar.MakeHonkNoise();
                Console.WriteLine("-------------");
            }
        }
    }
}
