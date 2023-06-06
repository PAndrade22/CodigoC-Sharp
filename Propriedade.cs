*O número 3025 tem uma propriedade interessente:
*30 + 25 = 55 e (55)² = 3025.
*Escreva um programa que lê um número inteiro e determinar se 
*ele possui ou não essa propriedade 
/
using System;
namespace Propriedade
{
    public class numero
    {
        public static void Main(string[] args)
        {
            //Declaração de variáveis 
             
            int numeroInteiro;

            //Entrada e saída de dados - WriteLine e ReadLine

            Console.WriteLine("Digite um número: ");
            numeroInteiro = int.Parse(Console.ReadLine()); //lendo o número do usuário

            if (numeroInteiro >= 1000 && numeroInteiro <= 9999){ //se o número que o usuário digitar for entre 1000 e 9999, entrará nesta linha.
                if (numeroInteiro == 
                ((( numeroInteiro/100 ) + ( numeroInteiro % 100 )) * (( numeroInteiro / 100 ) + ( numeroInteiro % 100 )))){ //se o número do usuário tiver esta propriedade, o código vai entrar nesta linha.
                                                                                                                             
                 Console.WriteLine (numeroInteiro +" : "+ ( numeroInteiro / 100 ) +" + "+ ( numeroInteiro ) +
                 " = "+(( numeroInteiro / 100 )+ (numeroInteiro % 100 )) +" ----> "
                 +(( numeroInteiro / 100) + (numeroInteiro % 100))+"² = "+ numeroInteiro);//esta linha vai printar na tela a propriedade. Ex: 3025: 30 + 25 = 55 ---> (55)²=3025
                }
                else{
                    Console.WriteLine("O número {0} não tem tal propriedade.", numeroInteiro); //se o número do usuário não tiver a propriedade, o código irá printar esta linha.
                }
            }
            else{
                Console.WriteLine("O número {0} é inválido para tal propriedade.", numeroInteiro); //se o código não atender a expecificação da linha 29, o código irá ler esta linha.
            }
        }
    }
}
