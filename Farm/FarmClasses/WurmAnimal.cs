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
        protected string branded;
        protected Species species;
        protected List<Attributes> Skills ;
        protected string caredFor;
        protected string name;
        protected Horse father;
        protected Horse mother;
        protected Dictionary<DateTime, Age> ages;
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
