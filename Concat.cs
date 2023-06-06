using System;

namespace Vetor
{ 
  public class matriz
  {  
    static void Main()
    {
       string nomeSobrenome, nome = "Pablo "; //variável nome recebe o valor Pablo
       string sobrenome = "Silva"; //variável sobrenome recebe o valor Silva

       nomeSobrenome = string.Concat(nome,sobrenome); //variável nomeSobrenome recebe os valores da variáveis nome e sobrenome
       Console.WriteLine(nomeSobrenome);

    }
  }
}
