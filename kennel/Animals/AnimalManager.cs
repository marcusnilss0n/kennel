using kennel.Data;
using kennel.Factories;
using System;
using System.Collections.Generic;

namespace kennel.Animals
{
    internal class AnimalManager : IAnimalManager
    {
        public IExtraServices ExtraServices { get; set; }
        public IDataRepository Db { get; set; }
        public AnimalManager(IDataRepository db)
        {
            Db = db;
            CheckedInAnimals = new();
        }
        public List<IAnimal> CheckedInAnimals { get; set; }
        public void RegisterAnimal()
        {
            IAnimal animal = AnimalFactory.Create();

            Console.WriteLine("Please enter the animals ID number");
            animal.ID = Console.ReadLine();

            Console.WriteLine("Please enter the animals name");
            animal.Name = Console.ReadLine();

            Console.WriteLine("Please enter the animals race");
            animal.Race = Console.ReadLine();

            Console.WriteLine("Please enter the Customers First Name associated with the animal");
            animal.Owner = Console.ReadLine();

            Db.AddAnimal(animal);
        }

        public void ListAnimals()
        {
            var animals = Db.GetAnimals();
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }

        public void ListCheckedInAnimals()
        {
            foreach (var animal in CheckedInAnimals)
            {
                Console.Write(animal.Name);
                Console.Write(" who belongs to ");
                Console.WriteLine(animal.Owner);
            }        
        }

        public void CheckInAnimal()
        {
            Console.WriteLine("Please choose which animal to check in");
            ListAnimals(); 
            var animalPicker = Console.ReadLine();
            var saveAnimal = Db.GetAnimal(animalPicker);
            CheckedInAnimals.Add(saveAnimal); 
        }

        public void CheckOutAnimal()
        {
            Console.WriteLine("Please choose which animal to check out");
            ListCheckedInAnimals();          
            var animalPicker = Console.ReadLine();
            var saveAnimal = Db.GetAnimal(animalPicker);
            CheckedInAnimals.Remove(saveAnimal);

            var totalPrice = saveAnimal.Price;
            saveAnimal.ExtraServices.ForEach(i => totalPrice += i.Price);
            Console.Write("The total price is ");
            Console.WriteLine(totalPrice);
        }

        public void ListOwner()
        {
            foreach (var animal in CheckedInAnimals)
            {
                Console.WriteLine(animal.Owner);
            }
        }

        public void ListAnimalAndOwner()
        {
            var animals = Db.GetAnimals();
            foreach (var animal in animals)
            {
                Console.Write(animal.Name);
                Console.Write(" who belongs to ");
                Console.WriteLine(animal.Owner);
            }
        }

        public void AddExtraServices()
        {
            Console.WriteLine("Please choose which Animal that want an extra service");
            ListCheckedInAnimals();
            var animalPicker = Console.ReadLine();
            var saveAnimal = Db.GetAnimal(animalPicker);

            var validChoice = false;
            while(!validChoice)
            {
                Console.WriteLine("Please choose an extra service");
                Console.WriteLine("1. Washing");
                Console.WriteLine("2. Clipping");
                Console.WriteLine("3. Both");
                var choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        {
                            saveAnimal.ExtraServices.Add(new Washing());
                            validChoice = true;
                            break;
                        }
                    case "2": {
                        saveAnimal.ExtraServices.Add(new Clipping());
                            validChoice = true;
                            break;
                    }
                    case "3":
                        {
                            saveAnimal.ExtraServices.Add(new Washing());
                            saveAnimal.ExtraServices.Add(new Clipping());
                            validChoice = true;
                            break;
                        }
                }
            }

        }
    }
}