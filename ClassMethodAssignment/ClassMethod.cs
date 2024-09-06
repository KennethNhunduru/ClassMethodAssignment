using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodAssignment
{
    class ClassMethod
    {
        //declaring the input variable for the void method
        public int data;
        //declaring the output variable for the void method
        public int output;

        //creating a VOID method that OUTPUTS an integer.

        public void MyClassMethod(int data)
        {
            //dividing the data passed to the method by 2.
            output = data / 2;            
        }        
    }
}
