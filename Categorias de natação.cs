/
*Utilizando a estrutura condicionais if - else e switch
/

/
*Escreva um algoritmo que, dada a idade de um nadador, classifique-o uma das seguintes categorias:
*infantil B = 8 - 10 anos
*juvenil A = 11 - 13 anos
*juvenil B = 14 - 17 anos
* sênior = maiores de 18 anos
/

using System;
namespace Categoria 
{
    public class nadador
    {
        public static void Main(string[] args)
        {
            //Declaração de variáveis 
            
            int idadeDoUsuario;
            string nomeDoUsuario;


            //Entrada e saída de dados - WriteLine e ReadLine

           Console.WriteLine("Digite seu nome: ");
           nomeDoUsuario = Console.ReadLine(); //lendo o nome do usuário

           Console.WriteLine("Agora digite sua idade:");
           idadeDoUsuario = int.Parse(Console.ReadLine()); //lendo a idade do usuário

           Console.WriteLine("\n --------- AS CATEGORIAS --------- \n");
           Console.WriteLine("\n INFATIL B = 8 - 10 ANOS \n");
           Console.WriteLine("\n JUVENIL A = 11 - 13 ANOS \n");
           Console.WriteLine("\n IUVENIL B = 14 - 17 ANOS \n");
           Console.WriteLine("\n SÊNIOR = MAIORES QUE 18 ANOS \n");

           if (idadeDoUsuario >= 8 && idadeDoUsuario <= 10){ //Se a idade do usuário for entre 8 e 10 anos, irá ler esta linha
            Console.WriteLine("{0}, sua categoria é infantil B", nomeDoUsuario);
           }
           if (idadeDoUsuario >= 11 && idadeDoUsuario <= 13){ //Se a idade do usuário for entre 11 e 13 anos, irá ler esta linha
            Console.WriteLine("{0}, sua categoria é juvenil A.", nomeDoUsuario);
           }
           if (idadeDoUsuario >= 14 && idadeDoUsuario <= 17){ //Se a idade do usuário for entre 14 e 17 anos, irá ler esta linha
            Console.WriteLine("{0}, sua categoria é juvenil B", nomeDoUsuario);
           }
           if (idadeDoUsuario >= 18){ //Se a idade do usuário for maior que 18 anos, irá ler esta linha
            Console.WriteLine("{0}, sua categoria é sênior.", nomeDoUsuario);
           }

        }
    }
}
