using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmClasses.Enums;

namespace FarmClasses
{
    public class Unicorn : WurmAnimal
    {
        string SpecialAttribute;
        public Unicorn() : base(Species.unicorn)
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
