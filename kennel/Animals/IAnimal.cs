using System.Collections.Generic;

namespace kennel.Animals
{
    public interface IAnimal
    {
        string ID { get; set; }
        string Name { get; set; }
        string Race { get; set; }
        public string Owner { get; set; }
        public decimal Price { get; set; }
        public List<IExtraServices> ExtraServices {get; set;}
    }
}