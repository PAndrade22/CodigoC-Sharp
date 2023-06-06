using System;
namespace Quadras
{
    public class Jogadores
    {
        public static void calculaQuantidadeDeJogadores(int quantidadeDeJogadores, int quantidadeDeQuadras){
            int capacidadePorQuadra = 2;
            int quadrasCompletas = quantidadeDeJogadores / capacidadePorQuadra;
            int jogadoresSemQuadra = quantidadeDeJogadores % capacidadePorQuadra;
            int quadrasIncompletas = quantidadeDeQuadras - quadrasCompletas;
            int jogadoresSimultaneamente = quadrasCompletas * capacidadePorQuadra;
            Console.WriteLine(
                "{0} quadra(s) ter(á)ão jogos simultaneamente e {1} jogador(es) ficará(ão) na espera, {2} quadras sem jogos e {3} jogadores jogarão simultanemente", 
                quadrasCompletas, jogadoresSemQuadra, quadrasIncompletas, jogadoresSimultaneamente);
        }

        public static void Main(string[] args)
        {
            int quantidadeDeJogadores, quantidadeDeQuadras;

            Console.WriteLine("Digite a quantidade de jogadores: ");
            quantidadeDeJogadores = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite quantidade de quadras do clube E-Sporte: ");
            quantidadeDeQuadras = int.Parse(Console.ReadLine());
            if (quantidadeDeJogadores < 2){
                Console.WriteLine("Não há jogadores suficiente");
            }
            else{
            calculaQuantidadeDeJogadores(quantidadeDeJogadores,quantidadeDeQuadras);
                }



        }
    }
}
