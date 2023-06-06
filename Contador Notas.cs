using System;
namespace contador
{
  public class notas
  {
    public static void Main(string[] args)
    {
      int[] valoresNotas = {100,50,10,5,1};
      int montanteDeDinheiro, quantidadeDeNotas;

      Console.WriteLine("Digite o motante de dinheiro: ");
      montanteDeDinheiro = int.Parse(Console.ReadLine());
      
      foreach (int valorNota in valoresNotas){

      quantidadeDeNotas = montanteDeDinheiro / valorNota;
      montanteDeDinheiro %= valorNota;

      Console.WriteLine("Nota R${0} tem {1}", valorNota, quantidadeDeNotas);
      }


    }
  }
}
