using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain
{
    public class Chemicals : Product
    {
        //public string City { get; set; }
        
        public string LabName { get; set; }

        public Address MyAddress { get; set; }

        // public string StreetAdress { get; set; }

        public override void GetMyType()
        {
            Console.WriteLine("CHEMICAL");
        }
    }
}
