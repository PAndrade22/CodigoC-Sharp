using System;
namespace Calculadora
{
  public class Program
  {
    public static void Main(string [] args)
    {
      Menu();
    }

    public static void Menu()
    {
      Console.WriteLine("1 - Adição");
      Console.WriteLine("2 - Divisão");
      Console.WriteLine("3 - Subtração");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("0 - Sair");

      int opcao_Operacao = Convert.ToInt32(Console.ReadLine());

      switch (opcao_Operacao)
      {
        case 1:
        Adicao(); break;

        case 2:
        Divisao(); break;

        case 3:
        Subtracao(); break;

        case 4:
        Multiplicacao(); break;

        case 0:
        break;
        
        default:
        Menu(); break;
        }
      }

      static void Adicao()
      {
        double numero_1, numero_2;

        Console.WriteLine("Digite o primeiro número:");
        numero_1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        numero_2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Adição: {numero_1} + {numero_2} = {numero_1 + numero_2}");
        Console.ReadLine();
        Menu();

    }
     static void Divisao()
      {
        double numero_1, numero_2;

        Console.WriteLine("Digite o primeiro número:");
        numero_1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        numero_2 = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine($"Divisão: {numero_1} / {numero_2} = {numero_1 / numero_2}");
        Console.ReadLine();
        Menu();

    }
       static void Subtracao()
      {
        double numero_1, numero_2;

        Console.WriteLine("Digite o primeiro número:");
        numero_1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        numero_2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Subtraçaõ: {numero_1} - {numero_2} = {numero_1 - numero_2}");
        Console.ReadLine();
        Menu();

    }
     static void Multiplicacao()
      {
        double numero_1, numero_2;

        Console.WriteLine("Digite o primeiro número:");
        numero_1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        numero_2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Multiplicação: {numero_1} x {numero_2} = {numero_1 * numero_2}");
        Console.ReadLine();
        Menu();

    }
  }
}
