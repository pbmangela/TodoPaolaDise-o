using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class arrays
    {
        string[] alumno = new string[3] { "Paola", "Katherine", "Carlos" };
        string[] Profesor = new string[] { "Gilber", "Daniel", "melisa" };



        int[] aula = new int[4] { 2, 4, 6, 8 };
        int[] mesas = new int[] { 2, 4, 6, 8 };
        int[] sillas = { 2, 4, 6, 8 };



        public void Imprime()
        {

            for (int x = 0; x < alumno.Length; x++)
            {

                Console.WriteLine(alumno[x]);
                

            }



        }
    }
}

