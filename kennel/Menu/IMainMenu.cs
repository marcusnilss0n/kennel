using kennel.Animals;
using kennel.Customers;

namespace kennel.Menu
{
    interface IMainMenu
    {
        IAnimalManager AnimalManager { get; set; }
        ICustomerManager CustomerManager { get; set; }

        void GetInput();
        void Show();
    }
}