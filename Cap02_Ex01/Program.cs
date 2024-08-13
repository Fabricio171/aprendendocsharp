using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NOME; //literal

            Console.Write("Entre seu nome: ");
            NOME = Console.ReadLine();
            Console.WriteLine("Ola, " + NOME); // mostra o nome 

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar... ");
            Console.ReadLine();

        }
    }
}
