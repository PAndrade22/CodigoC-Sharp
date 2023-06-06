using System;
namespace Área
{
    public class Círuclo
    {
        public static double calculaArea(double raio)
        { 
            double pi = 3.14;
            double area = pi * raio * raio;
            return area;
        }
        
            public static void Main(string[] args)
            {
                double raio;
                Console.WriteLine("Digite o raio do círculo: ");
                raio = double.Parse(Console.ReadLine());
                double retorno = calculaArea(raio);
                Console.WriteLine("Área é igual a {0}", retorno);
            }
        
    }
}
