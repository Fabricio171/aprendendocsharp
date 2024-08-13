using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, R;

            Console.Write("Entre o 1o. valor ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Entre o 2o. valor ");
            B = int.Parse(Console.ReadLine());

            R = A + B; //soma 

            Console.WriteLine();
            Console.WriteLine("Resultado = " + R); // mostra o valor da vareavel
            
            Console.WriteLine();
            Console.Write("Tecla <Enter> para continuar... ");
            Console.ReadLine();
        }
    }
}
