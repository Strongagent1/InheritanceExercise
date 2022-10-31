using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Birds : Animals
    {
        public Birds()
        {
        }
        public int NumberOfLegs { get; set; }
        public bool HasFeather { get; set; }
        public string Color { get; set; }
        public bool InAmerica { get; set; }
    }
    
}
