using System;
namespace Modularização
{
    public class tabuada
    {
        public static void TabuadaZero(double numero){
        
        double tabuada;   
    //Tabuada de Multiplicação
    Console.WriteLine("\n");
    Console.WriteLine(" ------ Tabuada de Multiplicação {0} ------ \n", numero);
    for(int i = 0; i <= 10; i++){
      tabuada = i * numero;
      Console.WriteLine("{0} x {1} : {2}",numero,i,tabuada);
      }
      //Tabuada de Adição
       Console.WriteLine("\n");
       Console.WriteLine(" ------ Tabuada de Adição {0} ------ \n", numero);
       for(int i = 0; i <= 10; i++){
          tabuada = i + numero;
          Console.WriteLine("{0} + {1} : {2}",numero,i,tabuada);
         }
         //Tabuada de Subtração 
         Console.WriteLine("\n");
         Console.WriteLine(" ------ Tabuada de Subtração {0} ------ \n", numero);
         for(int i = 0; i <= 10; i++){
           tabuada = i - numero;
           Console.WriteLine("{0} - {1} : {2}",numero,i,tabuada);
          }
          //Tabuada de Divisão
           Console.WriteLine("\n");
           Console.WriteLine(" ------ Tabuada de Divisão {0} ------ \n", numero);
           for(int i = 1; i <= 10; i++){
              tabuada = i / numero;
              Console.WriteLine("{0} / {1} : {2}",numero,i,tabuada);
            }
        }
        public static void Main(string[] args)
        {
            double numero;
            Console.WriteLine("Digite um número: ");
            numero = double.Parse(Console.ReadLine());
            TabuadaZero(numero);


        }
    }
}
