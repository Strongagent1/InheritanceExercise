using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptiles : Animals
    {

        public Reptiles()
        {
        }
            public int NumberOfLegs { get; set; }
            public bool HasScales { get; set; } 
            public bool IsNocturnal { get; set; }   
            public string Color { get; set; }

           
    }
}
