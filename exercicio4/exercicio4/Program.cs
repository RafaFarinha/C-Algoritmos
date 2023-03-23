using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4.Escrever um programa fonte na Linguagem C# que leia o nome de um aluno e as notas 
                das três provas que ele obteve no semestre, com pesos 2, 4 e 6. Ao final, 
                o programa deverá exibir informar o nome do aluno e a sua média ponderada. */

            string nome;
            double nota1;
            double nota2;
            double nota3;
            double media;

            Console.WriteLine("Digite seu nome!");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a 1° nota!");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 2° nota!");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 3° nota!");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 * 2 + nota2 * 4 + nota3 * 6) / 12;

            Console.WriteLine(nome + ", sua media final ponderada é: {0}", media);
            Console.ReadKey();
        }
        
    }
}

