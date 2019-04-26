using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmClasses.Enums;

namespace FarmClasses
{
    class WurmAnimal : IAnimal
    {
        Species species;
        Attributes attribute;
        public Species Species
        {
            get
            {
                return species;
            }
        }
        public WurmAnimal(Species species)
        {
            this.species = species;
        }
    }
}
