using kennel.Animals;
using kennel.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennel.Menu
{
    class MainMenu : IMainMenu
    {
        public IExtraServices ExtraServices { get; set; }
        public ICustomerManager CustomerManager { get; set; }
        public IAnimalManager AnimalManager { get; set; }
        public MainMenu(ICustomerManager customerManager, IAnimalManager animalManager, IExtraServices extraServices)
        {
            CustomerManager = customerManager;
            AnimalManager = animalManager;
            ExtraServices = extraServices;
        }
        public void Show()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("     Welcome to the Kennel    ");
            Console.WriteLine("******************************");
            Console.WriteLine("1: Register new Customer");
            Console.WriteLine("2: Register new Animal");
            Console.WriteLine("3: List registered Customers");
            Console.WriteLine("4: List registered Animals");
            Console.WriteLine("5: List registered Animals with their Owners");
            Console.WriteLine("6: Check in Animal");
            Console.WriteLine("7: Check out Animal");
            Console.WriteLine("8: List checked in Animals and their Owners");
            Console.WriteLine("9: Add extra services");
        }

        public void GetInput()
        {
            var userInput = Console.ReadKey(true).Key;
            switch (userInput)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    CustomerManager.RegisterCustomer();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    AnimalManager.RegisterAnimal();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.Clear();
                    CustomerManager.ListCustomers();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Console.Clear();
                    AnimalManager.ListAnimals();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Console.Clear();
                    AnimalManager.ListAnimalAndOwner();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Console.Clear();
                    AnimalManager.CheckInAnimal();
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    Console.Clear();
                    AnimalManager.CheckOutAnimal();
                    break;
                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    Console.Clear();
                    AnimalManager.ListCheckedInAnimals();
                    break;
                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    Console.Clear();
                    AnimalManager.AddExtraServices();
                    break;
                default:
                    Console.WriteLine("Unknown Command");
                    break;
            }
        }
    } 
}
