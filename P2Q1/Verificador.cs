using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2Q1
{
    internal class Verificador
    {
        public static bool VerificarExpressao(string expressao)
        {
            //metodo para cria uma pilha
            Stack<char> pilha = new Stack<char>();

           //Ira iterar sobre cada caractere da expressao 
            foreach (char expre in expressao)
            {
                //verifica se o caractere eh uma abertura e o coloca na pilha
                if (Abertura(expre))
                {
                    pilha.Push(expre);
                }
                //Verifica se o caractere eh um fechamento
                else if (Fechamento(expre))
                {
                    //Caso a pilha esteja vazia ou nao tiver uma abertura e fechamento retorna false
                    if (pilha.Count == 0 || !AberturaEFechamento(pilha.Pop(), expre))
                    {
                        return false;
                    }
                }
            }
            //Quando tem abertura adiciona na pilha e quando tem fechamento retira, se o resultado der 0, expressao valida
            return pilha.Count == 0;
        }

        private static bool AberturaEFechamento(char abre, char fecha)
        {
            return (abre == '{' && fecha == '}') || (abre == '[' && fecha == ']') || (abre == '(' && fecha == ')');
        }

        private static bool Abertura(char carac)
        {
            return carac == '{' || carac == '[' || carac == '(';
        }

        private static bool Fechamento(char carac)
        {
            return carac == '}' || carac == ']' || carac == ')';
        }
    }
}

