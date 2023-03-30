using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 6. Escrever um programa fonte na Linguagem C# que receba um número e informe se o
             número entrado 
             está ou não no intervalo entre 200 e 300.  */

            double Valor1;

            Console.WriteLine("Digite um número qualquer");
            Valor1 = double.Parse(Console.ReadLine());

            if (Valor1 >= 200 && Valor1 <= 300)
            {
                Console.WriteLine("O número informado esta DENTRO do intervalo entre 200 e 300");
            }
            else
            {
                Console.WriteLine("O número informado esta FORA do intervalo entre 200 e 300");
            }
            Console.ReadLine();
        }

    }
}
