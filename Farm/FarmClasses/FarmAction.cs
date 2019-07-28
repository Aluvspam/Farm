using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmClasses
{
    public class FarmAction
    {
        public List<IAnimal> ReadAnimals(string text)
        {
            List<string> Lines = new List<string>();
            string[] line = text.Split('\n');
            for (int i = 0; i < line.Length; i++)
            {
                Lines.Add(line[i]);
            }

            return new List<IAnimal>();
        }
    }
}
