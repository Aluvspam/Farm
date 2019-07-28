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
            var result = new List<IAnimal>();
            List<string> Lines = new List<string>();
            text.Replace(Environment.NewLine, "\n");
            Lines = text.Split('\n').ToList();
            for (int i = 0; i < Lines.Count; i++)
            {
                if (Lines[i].Contains(horseIdentifier))
                {
                    var j = i + 1;
                    var branded = "";
                    while (true)
                    {
                        if(Lines[j].Contains("It has been branded by"))
                        {
                            branded = Lines[j].Substring(68).Trim('.');
                            
                        }
                    }
                    //TO DO: finish this method
                    
                }
                else if (Lines[i].Contains(unicornIdentifier))
                {
                   
                    //TO DO: finish this method
                }
            }

            return result;
        }

        public List<IAnimal> ReadAnimalsFromFile(string path)
        {
            return new List<IAnimal>();
        }
    }
}
