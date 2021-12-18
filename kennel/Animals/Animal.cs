using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennel.Animals
{
    public class Animal : IAnimal
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Owner { get; set; }
        public decimal Price { get; set; }
        public List<IExtraServices> ExtraServices { get; set; }

        public Animal()
        {
            Price = 50;
            ExtraServices = new();
        }
    }
}
