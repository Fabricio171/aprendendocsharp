using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap02_Ex03
{
     class Program
    {
        static void Main(string[] args)
        {
            float HT, VH, PD, SB, TD, SL; // HT = horas trabalhadas, VH = valor horas PD = percentual de desconto SB = salario bruto  SL = salario liquido TD = Total desconto

            Console.Write("Horas Trabalhadas .................: ");
            HT = float.Parse(Console.ReadLine());

            Console.Write(" Valor da Hora ..............: ");
            VH = float.Parse(Console.ReadLine());

            Console.Write(" Valor do percentual de desconto .: ");
            PD = float.Parse(Console.ReadLine());

            SB = HT * VH;
            TD = (PD / 100) * SB; // ele pega o valor de percentual de desconto divide por 100 e multiplica por salario bruto. EX: (20 / 100) * 2.000
            SL = SB - TD;

            Console.WriteLine();
            Console.Write("Salario liquido .......: ");
            Console.WriteLine(SL.ToString("##,##0.00"));

            Console.WriteLine();
            Console.Write("Tecla <Enter> para encerrar...");
            Console.ReadLine();
        }
    }
}
