using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennel.Animals
{
    public class Washing : IExtraServices
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Washing()
        {
            Price = 20;
            Name = "Washing";
        }
    }
}
