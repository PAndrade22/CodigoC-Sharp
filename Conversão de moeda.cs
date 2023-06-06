*Escreva um progroma que lê um valor em reais e um tipo de moeda (1 - dólar, 2 - libra - 3 - euro)
*e faz conversão do valor para a moeda solicitando, sabendo que 
* 1 dólar = R$ 4,00 - 1 libra = R$ 6,15 - 1 euro = R$ 4,72
/

using System;
namespace ValorEmReais
{
    public class conversão
    {
        public static void Main(string[] args)
        {
            //Declaração de variáveis 

            int opcaoDeMoeda;
            double valorEmReais, valorConvertido,
            dolar = 4.00, euro = 4.72, libra = 6.15; 

            //Entrada e saída de dados - WriteLine e ReadLine

            Console.WriteLine("Digite um valor em reais: ");
            valorEmReais = double.Parse(Console.ReadLine());//lendo o valor do usuário

            Console.WriteLine("\n ------ ESCOLHA UMA MOEDA ABAIXO PARA FAZER A CONVERSÂO ------ \n");
            Console.WriteLine("\n 1 - Dólar");
            Console.WriteLine("\n 2 - Libra");
            Console.WriteLine("\n 3 - Euro");
            opcaoDeMoeda = int.Parse(Console.ReadLine()); //lendo a opção do usuário para converter o valor em tal moeda

            //Processamento de dados 
            
            switch(opcaoDeMoeda){
                case 1:

                valorConvertido = valorEmReais*dolar; //multiplicando o valor em real para dólar
                Console.WriteLine("O valor R$ {0} convertido para dólar é R${1}.",valorEmReais, valorConvertido);break;

                case 2:

                valorConvertido = valorEmReais*libra; //multiplicando o valor em real para libra
                Console.WriteLine("O valor R$ {0} convertido para libra é R${1}.",valorEmReais, valorConvertido);break;

                case 3:

                valorConvertido = valorEmReais*euro; //multiplicando o valor em real para euro
                Console.WriteLine("O valor R$ {0} convertido para euro é R$ {1}.",valorEmReais, valorConvertido);break;

                default:
                
                Console.WriteLine("Opção inválida!");break; 
            }
        }
    }
}
