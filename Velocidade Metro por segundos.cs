using System;
namespace velocidade
{
  public class metroSegundo
  {
    public static void Main(string[] args)
    {
      double comprimenroDaPista, 
      tempoEmSegundosCarro1, tempoEmSegundosCarro2,
      velocidadeDoCarro1, velocidadeDoCarro2,
      tempoCarro1, tempoCarro2, segundo = 60;

      Console.WriteLine("Digite o comprimentro da pista: ");
      comprimenroDaPista = double.Parse(Console.ReadLine());

      Console.WriteLine("Digite quanto tempo o primeiro carro levou para pecorrer a pista: ");
      tempoCarro1= double.Parse(Console.ReadLine());

      Console.WriteLine("Digite quanto tempo o segundo carro levou para pecorrer a pista: ");
      tempoCarro2 = double.Parse(Console.ReadLine());
      
      tempoEmSegundosCarro1 = tempoCarro1 * segundo;
      tempoEmSegundosCarro2 = tempoCarro2 * segundo;

      velocidadeDoCarro1 = comprimenroDaPista / tempoEmSegundosCarro1;
      velocidadeDoCarro2 = comprimenroDaPista / tempoEmSegundosCarro2;

      if (velocidadeDoCarro1 > velocidadeDoCarro2){
        Console.WriteLine("O carro 1 foi mais rápido na pista - {0}m/s", velocidadeDoCarro1);    
      }
      else{
        Console.WriteLine("O carro 2 foi mais rápido na pista - {0}m/s", velocidadeDoCarro2);
      }



    }
  }
}
