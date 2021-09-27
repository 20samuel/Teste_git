using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                Tela.ImprimirTabuleiro(partida.tab);
                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosica();

                    bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.tab,posicoesPossiveis);

                    Console.Write("Destion: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosica();

                    partida.executarMovimento(origem, destino);
                }
            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
