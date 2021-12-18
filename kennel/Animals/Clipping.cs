using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kennel.Animals
{
    public class Clipping : IExtraServices
    {
        public decimal Price { get; set; }
        public string Name { get; set; }

        public Clipping()
        {
            Price = 30;
            Name = "Clipping";
        }
    }
}
