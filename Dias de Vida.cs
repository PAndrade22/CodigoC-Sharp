/
*Escrever um programa que pergunte o nome e a idade de um idividuo e imprimir quantos dias de vida ele possui.

/

using System;
namespace Idade
{
    public class Usuário
    {
        public static void Main(string[] args)
        {
            //Declaração de variáveis 
            string nomeDoUsuario;
            int idadeDoUsuario, ano = 365, diasDeVidaDoUsuario;

            //Entrada e saída de dados - WriteLine e ReadLine
            //Solicitando o nome e a idade do usuário
            Console.WriteLine("\n ----- Olá Usuário -----\n");
            
            Console.WriteLine("Digite o seu nome: ");
            nomeDoUsuario = Console.ReadLine();
            
            Console.WriteLine("Agora digite sua idade: ");
            idadeDoUsuario = int.Parse(Console.ReadLine());

            //Processamento de dados
            //Somando a idade do usuário com a quantidade de dias que o ano possui
             diasDeVidaDoUsuario = idadeDoUsuario*ano;

             //Saída de dados
             //Imprimindo o nome e a quantidade de dias que o usuário possui
             Console.WriteLine("\n ------ CERTO ------- \n");
             Console.WriteLine("Senhor(a) {0}. Você possui {1} dias de vida", nomeDoUsuario, diasDeVidaDoUsuario);
        }
    }
}
