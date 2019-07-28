using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmClasses.Enums;

namespace FarmClasses
{
    public class WurmAnimal : IAnimal
    {
        Species species;
        List<Attributes> Skills ;
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
            Skills = new List<Attributes>();
        }
    }
}
