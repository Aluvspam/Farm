using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmClasses.Enums;

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
                    var caredFor = "";
                    Gender gender = Gender.He;
                    var colour = "";
                    List<Attributes> Skills = new List<Attributes>();
                    while (true)
                    {
                        if(Lines[j].Contains("It has been branded by"))
                        {
                            branded = Lines[j].Substring(67).Trim('.');
                            j++;
                        }
                        if (Lines[j].Contains("It is being taken care of"))
                        {
                            caredFor = Lines[j].Substring(40).Trim('.');
                            j++;
                        }
                        if (Lines[j].Contains("She"))
                        {
                            gender = Gender.She;                            
                        }
                        if (Lines[j].Contains("strong"))
                        {
                            Skills.Add(Attributes.strongBody);                           
                        }
                        if (Lines[j].Contains("Its colour"))
                        {
                            colour = Lines[j].Substring(25).Trim('.');
                            j++;
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
