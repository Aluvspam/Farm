﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmClasses
{
    public class Action
    {
        string horseIdentifier = "Horses like this one have many uses.";

        public List<IAnimal> ReadAnimals(string text)
        {
            return new List<IAnimal>();
        }

        public List<IAnimal> ReadAnimalsFromFile(string path)
        {
            return new List<IAnimal>();
        }
    }
}
