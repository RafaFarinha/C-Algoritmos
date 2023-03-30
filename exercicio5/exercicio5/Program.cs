using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5. Escrever um programa fonte na Linguagem C# que leia dois valores inteiros e informe se eles são iguais. 
            Caso sejam diferentes, o programa deverá informar o maior dos valores entrados. */

            double valor1;
            double valor2;

            Console.WriteLine("Digite o 1° valor!");
            valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° valor!");
            valor2 = double.Parse(Console.ReadLine());

            if(valor1 > valor2)
            {
                Console.WriteLine("O valor 1 é maior que o valor 2, VALOR1:  " + valor1);
            }
            else if(valor2 > valor1)
            {
                Console.WriteLine("o valor 2 é maior que o valor 1, VALOR2: " + valor2);
            }
            else
            {
                Console.WriteLine("os valores são iguais!");
            }

            Console.ReadLine();
        }
    }
}
