using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class OutParameter
    {
        //The C# "Out" parameter is used when a METHOD RETURNS MULTIPLE VALUES.
        //The Out keyword signifies a REFERENCE parameter.
        //The Out keyword enables the passing of parameters whose changes are realised WITHIN their calling methods.
        //The Out arguments MUST be assigned IN THE METHOD before the method returns.
        //The Out parameter can pass without its declaration and initialisation (contrast with the Ref parameter)

        //CREATING A METHOD WITH OUTPUT PARAMETERS.

        //For my METHOD WITH OUTPUT PARAMETERS, I will look at calculating the volume of a rod with a circular cross section.
        
        //declaring the diameter input variable for the method
        public double Diameter { get; set; }
        //declaring the length input variable for the method
        public double Length { get; set; }
        
        public static double CalculateRod(double Diameter, double Length)
        {
            double Area = Math.PI * Math.Pow((Diameter/2), 2); //calculating the cross-sectional area.
            double Volume = Area * Length; //calculating the volume of the rod.
            
            Console.WriteLine($"The rod's cross-sectional Area is {Area} square centimeters");
            Console.WriteLine(); //Inserting a blank line in the output
            Console.WriteLine($"The volume of the rod is {Volume} cubic centimeters");
            Console.ReadLine();
            return Volume;
        }

        //OVERLOADING THE METHOD.
        //Method overloading is a way of achieving POLYMORPHISM in C#.
        /*It is a way of defining multiple versions of a method, each tailored for
          different parameter types or number of parameters*/
        //With method overloading, multiple methods can have the same name BUT with different parameters (method signature).
        //A Method can be overloaded based on Out parameters.

        public static double CalculateRod(out double Diameter, out double Length)
        {
            Diameter = 8; //assigning the rod Diameter argument IN THE METHOD before the method returns.
            Length = 100; //assigning the rod Length argument IN THE METHOD before the method returns.

            double Area = Math.PI * Math.Pow((Diameter / 2), 2); //Calculating the cross-sectional area of the rod.
            double Volume = Area * Length; //Calculating the volume of the rod.
            
            Console.WriteLine($"The rod's cross-sectional Area is {Area} square centimeters");
            Console.WriteLine($"The volume of the rod is {Volume} cubic centimeters");
            Console.ReadLine();
            return Volume;
        }      
    }
}
