/
*Escrever um programa para ler um número inteiro e identificar se ele é par ou impar,
*escrevendo a mensagem correspondente.
/

using System;
namespace numero
{
    public class ParImpar
    {
        public static void Main(string[] args)
        {
            //Declaração de variáveis 
            int numero;
            //Entrada e saída de dados

            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine()); // lendo o número do usuário

            //Processamento de dados
           
           if ((numero%2) ==0){ //se o resto da divisão for igual a zero (0), o código entrará nesta linha
            Console.WriteLine("O número {0} é par", numero);
           }
           else{  //se o resto da divisão não for igual a zero (0), o código entrará nesta linha
            Console.WriteLine("O número é impar");
           }
        }
    }
}
