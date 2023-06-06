/
*Códigos de entrada e saída de dados simples

*-Escrever um programa capaz de calcular o preço médio da gasolina cnsiderando três
*postos de combustível. Solicitando ao usuário que informe o nome e o valor da gasolina
*em casa um dos três.
/

using System;
namespace PreçoMédio
{
    public class Gasolina
    {
        public static void Main(string[] args)
        {
            //Declaração de variáveis 
            string postoDeGasolina_1, postoDeGasolina_2, postoDeGasolina_3;
            double precoMedioDaGasolina,valorDaGasolina_1, valorDaGasolina_2, valorDaGasolina_3;

            //Entrada e saída de dados - WriteLine e ReadLine
            //Solicitando o nome do posto e o preço da gasoliona dos postos de gasolina
            Console.WriteLine("Digite o nome do primeiro posto de gasoline: ");
            postoDeGasolina_1 = Console.ReadLine();

            Console.WriteLine("Digite o segundo nome do posto de gasolina: ");
            postoDeGasolina_2 = Console.ReadLine();

            Console.WriteLine("Digite o terceiro nome do posto de gasolina: ");
            postoDeGasolina_3 = Console.ReadLine();

            Console.WriteLine("\n ----- AGORA DIGITE O VALOR DO DA GASOLINA ABAIXO ----- \n");
            Console.WriteLine("Valor da gasolina do Posto "+postoDeGasolina_1);
            valorDaGasolina_1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor da gasolina do Posto "+postoDeGasolina_2);
            valorDaGasolina_2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor da gasolina do Posto "+postoDeGasolina_3);
            valorDaGasolina_3 = double.Parse(Console.ReadLine());

            //Processamento de dados
            //Tirando a média dos preços da gasolina dos três postos
            precoMedioDaGasolina = (valorDaGasolina_1+valorDaGasolina_2+valorDaGasolina_3)/3;

            //Saída de dados
            //Imprimindo nome dos postos, valores da gasolina e a média
            Console.WriteLine("Posto   Valor");
            Console.WriteLine("{0}    {1}", postoDeGasolina_1, valorDaGasolina_1);
            Console.WriteLine("{0}    {1}", postoDeGasolina_2, valorDaGasolina_2);
            Console.WriteLine("{0}    {1}", postoDeGasolina_3, valorDaGasolina_3);
            Console.WriteLine("O valor médio da gasolina é {0}", precoMedioDaGasolina);
        }
    }
}
