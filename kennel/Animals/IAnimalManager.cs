namespace kennel.Animals
{
    internal interface IAnimalManager
    {
        public void RegisterAnimal();
        public void ListAnimals();
        public void ListCheckedInAnimals();
        public void CheckInAnimal();
        public void CheckOutAnimal();
        public void ListOwner();
        public void ListAnimalAndOwner();
        public void AddExtraServices();
    }
}