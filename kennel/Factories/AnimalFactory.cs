using kennel.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennel.Factories
{
    public static class AnimalFactory
    {
        public static IAnimal Create()
        {
            return new Animal();
        }
    }
}
