using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

  

  


    class Fibonacci
    {
        
        public int operacion(int F1){


            if ( F1 == 0)
                return 0;

            if (F1 == 1)
                return 1;

            return operacion(F1 - 1) + operacion(F1 - 2);
        
        
        
        }


    }
}
