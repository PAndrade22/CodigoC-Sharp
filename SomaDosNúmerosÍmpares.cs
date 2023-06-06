using System;
namespace números
{
  public class ímpares
  {
    public static void Main(string[] args)
    {
      
     int intervaloInicio, intervaloFim;
     double somaDosNumeroImpares = 0;

     Console.WriteLine("Digite o primeiro número do intervalo: ");
     intervaloInicio = int.Parse(Console.ReadLine());

     Console.WriteLine("Digite o último número do intervalo: ");
     intervaloFim = int.Parse(Console.ReadLine());


     for (int i = intervaloInicio; i < intervaloFim; i++){
      if (i % 2 != 0){
        somaDosNumeroImpares += i;
      }
     }  
       Console.WriteLine("A soma de todos o números ímpares do intervalo A é igual a {0}", somaDosNumeroImpares);
    }
  }
}
