using System;
using tabuleiro;
namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get;private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branco;
            colocarPeca();
            terminada = false;
        }
        public void executarMovimento(Posicao origem,Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQteMovimento();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.ColocarPeca(p, destino);
        }

        private void colocarPeca()
        {
            tab.ColocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('c',1).toPosica());
            tab.ColocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('c', 2).toPosica());
            tab.ColocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('d', 2).toPosica());
            tab.ColocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('e', 2).toPosica());
            tab.ColocarPeca(new Torre(tab, Cor.Branco), new PosicaoXadrez('e', 1).toPosica());
            tab.ColocarPeca(new Rei(tab, Cor.Branco), new PosicaoXadrez('d', 1).toPosica());

            tab.ColocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('c', 7).toPosica());
            tab.ColocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('c', 8).toPosica());
            tab.ColocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('d', 7).toPosica());
            tab.ColocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('e', 7).toPosica());
            tab.ColocarPeca(new Torre(tab, Cor.Preto), new PosicaoXadrez('e', 8).toPosica());
            tab.ColocarPeca(new Rei(tab, Cor.Preto), new PosicaoXadrez('d', 8).toPosica());
        }
    }
}
