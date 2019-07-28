using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmClasses
{
    public class FarmAction
    {
        const string horseIdentifier = "Horses like this one have many uses.";
        const string unicornIdentifier = "A bright white unicorn with a slender twisted horn.";
        public List<IAnimal> ReadAnimals(string text)
        {
            List<string> Lines = new List<string>();
            text.Replace(Environment.NewLine, "\n");
            Lines = text.Split('\n').ToList();
            //TO DO: finish this method
            return new List<IAnimal>();
        }

        public List<IAnimal> ReadAnimalsFromFile(string path)
        {
            return new List<IAnimal>();
        }
    }
}
