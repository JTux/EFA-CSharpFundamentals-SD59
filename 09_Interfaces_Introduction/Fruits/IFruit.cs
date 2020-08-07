using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Introduction.Fruits
{
    public interface IFruit
    {
        string Name { get; }
        bool Peeled { get; }
        string Peel();
    }
}
