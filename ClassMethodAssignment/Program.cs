using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Note to use a NON-STATIC FIELD, METHOD, OR PROPERTY, we must first create an object instance.
            //NON-STATIC METHODS attach themselves to OBJECTS and their EXISTENCE DEPENDS ON OBJECTS.

            //Instantiating the ClassMethod class (creating an object for the NON-STATIC class).
            ClassMethod MyClass = new ClassMethod();

            //Requesting the user to enter a number
            Console.WriteLine("Enter a number: ");
            MyClass.data = Convert.ToInt32(Console.ReadLine()); //the number belongs to the class object.

            //Calling the method on the number.
            //Note use of the MyClass object as a reference for the NON-STATIC method.
            MyClass.MyClassMethod(MyClass.data);

            //Displaying the OUTPUT to the screen.

            Console.WriteLine("Your number divided by 2 gives: " + MyClass.output);
            Console.ReadLine();

            
            //METHOD WITH OUT PARAMETERS.

            //Obtaining user input for the rod with a circular cross-section and a fixed length.

            Console.WriteLine("Please enter the diameter of the rod cross-section in centimeters: ");
            double Diameter = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the length of the rod in centimeters: ");
            double Length = Convert.ToDouble(Console.ReadLine());

            //CALLING THE OUTPUT PARAMETERS METHOD
            
            //Notice how there is NO NEED TO INSTANTIATE THE CLASS since the method CalculateRod() has been declared STATIC.
            //A STATIC METHOD attaches itself to CLASSES as oppsed to objects and its existence DOES NOT DEPEND ON OBJECTS.
            
            OutParameter.CalculateRod(Diameter, Length);


            //METHOD OVERLOADING.
            
            //The type and number of arguments passed determines which version of the method runs.

            //CALLING THE OUT-PARAMETER OVERLOAD METHOD

            OutParameter.CalculateRod(out Diameter, out Length);

        }
    }
}
