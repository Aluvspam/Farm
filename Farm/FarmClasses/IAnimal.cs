using FarmClasses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmClasses
{
    interface IAnimal
    {
        Species Species { get; }
    }
}
