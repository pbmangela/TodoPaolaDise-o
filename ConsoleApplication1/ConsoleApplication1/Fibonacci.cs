using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

  

  


    class Fibonacci
    {

      public  ArrayList entrada = new ArrayList();
      public ArrayList salida = new ArrayList();    
        
public  void fibo(){
            entrada.Add(4);
            entrada.Add(6);
            entrada.Add(20);
            entrada.Add(1);
           entrada.Add(11);
           entrada.Add(25);

           foreach (int obj in entrada)
           Console.Write("   {0}", obj);
           Console.WriteLine();

        
        }


public int operacion(int F1)
{


    if (F1 == 0)
        return 0;

    if (F1 == 1)
        return 1;

    return operacion(F1 - 1) + operacion(F1 - 2);



}


    }
}
