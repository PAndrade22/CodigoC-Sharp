/
*Escreva um programa para ler 2 números e imprimi-los em ordem ascendente
/

using System;
namespace OrdemDescendente
{
    public class numero
    {
        public static void Main(string[] args)
        {
            //Declaração de variáveis
            
             float numero1, numero2;
            
            //Entrada e saída de dados - WriteLine e ReadLine

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = float.Parse(Console.ReadLine()); //lendo o primeiro número

            Console.WriteLine("Digite o segundo número:");
            numero2 =  float.Parse(Console.ReadLine()); //lendo o segundo número

            if (numero1 <= numero2){ 
                Console.WriteLine("\n{0}, {1}.", numero1, numero2); //se o número 1 for menor que número 2, o código irá executar essa linha
            }else{
                Console.WriteLine("\n{0}, {1}.", numero2, numero1); //se o número 2 for menor que número 1, o código irá executar essa linha
            }

        }
    }
}
