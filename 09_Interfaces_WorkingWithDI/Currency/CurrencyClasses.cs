using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_WorkingWithDI.Currency
{
    public class Penny : ICurrency
    {
        // '>=' != '=>'
        public string Name => "Penny";

        public decimal Value
        {
            get
            {
                return .01m;
            }
        }
    }

    public class Dime : ICurrency
    {
        public string Name
        {
            get { return "Dime"; }
        }
        public decimal Value
        {
            get { return .1m; }
        }
    }

    public class Dollar : ICurrency
    {
        public string Name => "Dollar";
        public decimal Value => 1m;
    }

    public class ElectronicPayment : ICurrency
    {
        public ElectronicPayment(decimal value)
        {
            Value = value;
        }

        public string Name
        {
            get { return "Electronic Payment"; }
        }
        
        public decimal Value { get; }
    }
}
