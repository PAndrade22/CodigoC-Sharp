using System;
namespace Divisor
{
    public class número
    {
        public static void Main(string[] args)
        {
            int d = 9, m = 8, n = d * m;
            int somaDaQuantidadeDeDivisores = 0;

            for (int i = 1; i <= n; i++){
                if(n % i == 0){
                    somaDaQuantidadeDeDivisores += 1;
                }
            } Console.WriteLine("O número {0} tem {1} divisores", n, somaDaQuantidadeDeDivisores);
    }
  }
}
