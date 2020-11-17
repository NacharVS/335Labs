using System;
using System.Collections.Generic;
using System.Text;

namespace _335Labs.Garipova
{
    class metods
    {
        static void division(double a, int b, int c)
        {
            double result = 0;
            for (int i = b; i <= c; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Cannot be divided by null");
                    i = i + 1;
                }
                result = a / i;
                    Console.WriteLine(result);
            }
        
            
                
            
        }
        
    }

}

                    





    

