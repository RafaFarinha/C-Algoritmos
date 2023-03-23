using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2. Escrever um programa fonte na Linguagem C# que exiba a soma, a subtração, 
             a multiplicação e a divisão de dois números inteiros fornecidos pelo usuário. */

            double a;
            double b;

            double soma;
            double sub;
            double multi;
            double divi;


            Console.WriteLine("Digite o primeiro valor");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            b = double.Parse(Console.ReadLine());

            soma = a + b;
            sub = a - b;
            multi = a * b;
            divi = a / b;

            Console.WriteLine();
            Console.WriteLine("Os resultados são:");
            Console.WriteLine("Soma = {0}", soma);
            Console.WriteLine("Subtração = {0}", sub);
            Console.WriteLine("Multiplicação = {0}", multi);
            Console.WriteLine("Divisão = {0}", divi);

            Console.ReadKey();
        }
    }
}
