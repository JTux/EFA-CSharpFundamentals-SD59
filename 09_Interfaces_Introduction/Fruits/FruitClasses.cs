using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Introduction.Fruits
{
    public class Banana : IFruit
    {
        public Banana() { }
        public Banana(bool isPeeled)
        {
            Peeled = isPeeled;
        }
        public string Name
        {
            get {return "Banana";}
        }
        public bool Peeled { get; private set; }
        public string Peel()
        {
            Peeled = true;
            return "You peel the banana.";
        }

    }

    public class Orange : IFruit
    {
        public Orange() { }
        public Orange(bool isPeeled)
        {
            Peeled = isPeeled;
        }

        public string Name
        {
            get { return "Orange"; }
        }
        public bool Peeled { get; private set; }
        public string Peel()
        {
            Peeled = true;
            return "You peel the orange.";
        }

        public string Squeeze()
        {
            return "You squeeze the orange and juice comes out.";
        }
    }

    public class Grape : IFruit
    {
        public string Name
        {
            get { return "Grape"; }
        }
        public bool Peeled { get; } = false;
        public string Peel()
        {
            return "Who peels grapes?\n" +
                "Connor says \"Surgeons do!\"\n" +
                "Drew says \"Or serial killers do!\"";
        }
    }

}
