using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program

    {
        Fibonacci fibo = new Fibonacci();

        static void Main(string[] args)

        {

            arrays tarea2 = new arrays();
            Fibonacci fibo = new Fibonacci();
            fibo.operacion(2);
            Console.WriteLine(fibo.operacion(1));//1
            Console.WriteLine(fibo.operacion(2));//1
            Console.WriteLine(fibo.operacion(3));//2


            tarea2.Imprime();
            System.Console.ReadLine();
           
        }
    }
}
