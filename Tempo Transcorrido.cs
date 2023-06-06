*Escrever um programa que pergunte qual o tempo transcorrido em um cronômetro em horas, minutos esegundos, 
*e tranforme todo este tempo em segundo.

using System;
namespace Tempo
{
    public class segundos
    {
        public static void Main (string[] args)
        {
            //Declaração de variáveis 
            int horasPecorrido, minutosPecorrido, segundosPecorrido,
            tempoEmSegundos,horasEmSegundos, minutosEmSegundos, 
            segundosEmSegundos, umaHora = 3600, umMinuto = 60, umSegundo = 1;


            //Entrada de saída de dados - WriteLine e ReadLine

            Console.WriteLine("\n ------ VAMOS LÁ -------- \n");
            Console.WriteLine("Digite o tempo transcorrido abaixo: ");
            Console.WriteLine("Em horas: ");
            horasPecorrido = int.Parse(Console.ReadLine());

            Console.WriteLine("Em minutos: ");
            minutosPecorrido = int.Parse(Console.ReadLine());

            Console.WriteLine("Em segundos: ");
            segundosPecorrido = int.Parse(Console.ReadLine());

            //Processamento de dados 

            horasEmSegundos = horasPecorrido*umaHora;
            minutosEmSegundos = minutosPecorrido*umMinuto;
            segundosEmSegundos = segundosPecorrido*umSegundo;
            tempoEmSegundos = horasEmSegundos+minutosEmSegundos+segundosEmSegundos;

            //Saída de dados 
            Console.WriteLine(
                "O seu tempo pecorrido foi {0} horas e {1} minutos e {2} segundos"
            , horasPecorrido, minutosPecorrido, segundosPecorrido 
            );
            Console.WriteLine("O tempo transcorrido transformado em segundos é {0} segundos", tempoEmSegundos);

        }
    }
}
