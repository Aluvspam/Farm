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

        public Horse(string branded, List<Attributes> Skills, string caredFor, Horse father, Horse mother, KeyValuePair<DateTime, Age> age, Color color) : base(Species.horse)
        {
            this.branded = branded;
            this.Skills = Skills;
            this.caredFor = caredFor;
            //this.name = name;
            this.father = father;
            this.mother = mother;
            this.ages = new Dictionary<DateTime, Age>();
            this.ages.Add(age.Key, age.Value);
            this.color = color;
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
