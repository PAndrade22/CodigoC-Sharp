/
*Escrever um programa para ler 3 números inteiros e imprimir o maior deles
/

using System;
namespace maiorDeTodos
{
    public class número
    {
        public static void Main(string[] args)
        {
            //Declaração de variáveis 
             
             float primeiroNumero, segundoNumero, terceiroNumero;

            //Entrada e saída de dados - WriteLine e ReadLine

            Console.WriteLine("Digite o primero número:");
            primeiroNumero = float.Parse(Console.ReadLine()); // lendo o primeiro número

            Console.WriteLine("Digite o segundo número: ");
            segundoNumero = float.Parse(Console.ReadLine()); // lendo o segundo número

            Console.WriteLine("Digite o terceiro número;");
            terceiroNumero = float.Parse(Console.ReadLine()); // lendo o terceiro número

            //Processamento de dados 

            if (primeiroNumero > segundoNumero && primeiroNumero > terceiroNumero){se primeiro número for maior que o segundo e terceiro número
              Console.WriteLine("O maior número é {0}.", primeiroNumero);
            }
            if (segundoNumero > primeiroNumero && segundoNumero > terceiroNumero){se segundo número for maior que o primeiro e terceiro número
                Console.WriteLine("O maior número é {0}.", segundoNumero); 
            }
            if (terceiroNumero > primeiroNumero && terceiroNumero > segundoNumero){se o terceiro número for maior que o primeiro e segundo número
                Console.WriteLine("O maior número é {0}.", terceiroNumero);
            }
        }
    }
}
