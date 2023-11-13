using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a expressão: ");
            string expressao = Console.ReadLine();

            if (Verificador.VerificarExpressao(expressao))
            {
                Console.WriteLine("A expressão está sintaticamente correta.");
            }
            else
            {
                Console.WriteLine("A expressão está sintáticamente errada.");
            }

        }
    }
}


