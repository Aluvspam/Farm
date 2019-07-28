using FarmClasses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmClasses
{
    public class Horse : WurmAnimal
    {
        Color color;
        public Horse() : base(Species.horse)
        {
        }
        public string Age
        {
            get
            {
                return ""; //TO DO decide a nice format in which we return age here
            }
        }
    }
}
