/
*Escrever um programa que calcule a quantidade necessária de latas de tinta para pintar uma parede.
*O programa pergunta medida delargura e altura da parede em metros e imprima o resultado (em latas de tintas).
*Considere que o consumo de tinra é de 300 ml por metro quadrado e a quantidade de tinra por lata é de 2 litros
/

using System;
namespace QuantidadeDeLatas
{
    public class PintandoParede
    {
        public static void Main(string[] args)
        {
            //Declaração de variáveis 
            double alturaDaParede, larguraDaParede, 
            quantidadeDeLatas, quantidadeGaloes, 
            areaDaParede;

            //Entrada de saída de dados - WriteLine e ReadLine
            Console.WriteLine("Digite a altura da parede: ");
            alturaDaParede = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura da parede: ");
            larguraDaParede = double.Parse(Console.ReadLine());

            //Processamento de dados
            areaDaParede = alturaDaParede*larguraDaParede;
            quantidadeDeLatas = areaDaParede/0.3;
            quantidadeGaloes = areaDaParede/2;

            //Saída de dados 
            Console.WriteLine("Quantidade de latas necessária é {0}", quantidadeDeLatas);
            Console.WriteLine("Quantidade de galões necessário é {0}", quantidadeGaloes);

        }
    }
}
