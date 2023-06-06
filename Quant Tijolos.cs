*Escrever um programa que calcule a quantidade aproximada de tijolos que vão ser usados para a construção de uma sala.
*Solicite a altura e a largura do tijolo, solicite a altura, largura da sala, solicite as dimensões da janela e da porta. 
*Considere que a sala é retangular, que possui apenas uma porta e uma janela
/

using System;
namespace TijolosParaSala
{
    public class construção 
    {
        public static void Main(string[] args)
        {
            //Declaração de variáveis 
            double alturaDaSala, larguraDaSala, 
            alturaDoTijolo, larguraDoTijolo,
            alturaDaJanela, larguraDaJanela,
            alturaDaPorta, larguraDaPorta,
            areaDaSala, areaDajanela, areaDaPorta,
            areaTotalDaSala, areaDoTijolo,
            quantidadeDeTijolos;

            //Entrada e saída de dados - WriteLine e ReadLine

            Console.WriteLine("Digite a altura da sala: \n");
            alturaDaSala = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura da sala: \n");
            larguraDaSala = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do tijolo: \n");
            alturaDoTijolo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura do tijolo: \n");
            larguraDoTijolo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da janela: \n");
            alturaDaJanela = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura da da janela: \n");
            larguraDaJanela = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura da porta: \n");
            alturaDaPorta = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura da porta \n");
            larguraDaPorta = double.Parse(Console.ReadLine());


            //Processamento de dados 
            areaDaSala = larguraDaSala * alturaDaSala;
            areaDajanela = larguraDaJanela * alturaDaJanela;
            areaDaPorta = larguraDaPorta * alturaDaPorta;
            areaTotalDaSala = areaDaSala - areaDajanela - areaDaPorta;
            areaDoTijolo = larguraDoTijolo * alturaDoTijolo;
            quantidadeDeTijolos = areaTotalDaSala * areaDoTijolo;

            //Saída de dados
            Console.WriteLine("A área total da sala é {0}.\n", areaTotalDaSala);
            Console.WriteLine("A área do tijolo é {0}.\n", areaDoTijolo);
            Console.WriteLine(
                "A quantidade de tijolos para sala é {0}.\n", 
            quantidadeDeTijolos
            );

        }
    }
}
