using FarmClasses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmClasses
{
    class Horse : WurmAnimal
    {
        Color color;
        public Horse() : base(Species.horse)
        {
        }
    }
}
