using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal-DONE
            // give this class 4 members that all Animals have in common-DONE


            // Create a class Bird-DONE
            // give this class 4 members that are specific to Bird-DONE
            // Set this class to inherit from your Animal Class-DONE

            // Create a class Reptile-DONE
            // give this class 4 members that are specific to Reptile-DONE
            // Set this class to inherit from your Animal Class-DONE

            var cardinal = new Birds();
            cardinal.NumberOfLegs = 2;
            cardinal.HasFeather = true;
            cardinal.Color = "red";
            cardinal.InAmerica = true;

            Console.WriteLine($" The cardinal has some pretty interesting" +
                $" characteristics. It has {cardinal.NumberOfLegs} legs, " +
                $"and it's {cardinal.HasFeather} - they have {cardinal.Color} feathers! " +
                $"They typically can be seen from far away.");



            {

            }


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var iguana = new Reptiles();
            iguana.NumberOfLegs = 4;
            iguana.HasScales = true;
            iguana.IsNocturnal = false;
            iguana.Color = "green";
            Console.WriteLine(iguana.HasScales);
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values - DONE
             */
        }
    }
}
