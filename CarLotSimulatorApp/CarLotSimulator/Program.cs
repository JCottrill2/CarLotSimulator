using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            CarLot carlot=new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //dot notation:
            var instance = new Car();
            carlot.CarList.Add(instance);
            

            instance.Make = "Kia";
            instance.Model = "EV6";
            instance.Year = 2022;
            instance.IsDriveable = true;

            //object initializer syntax:
            var instance2 = new Car()
            { Make = "Chevrolet", Model = "Camaro", EngineNoise = "loud", IsDriveable = true };
            carlot.CarList.Add(instance2);

            //custom constructor
            var instance3 = new Car("Tesla", "Model 3", 2020);
            carlot.CarList.Add(instance3);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            Console.WriteLine($"Number of cars created:{CarLot.numberOfCars}");
            Console.WriteLine();

            foreach (var item in carlot.CarList)
            {
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                Console.WriteLine();
                item.MakeEngineNoise("vroom");
                item.MakeHonkNoise();
            }


        }
    }
}
