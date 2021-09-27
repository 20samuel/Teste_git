using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Rei: Peca
    {
        public Rei(Tabuleiro tab, Cor cor): base(tab, cor)
        {

        }

        public override string ToString()
        {
            return "R";
        }
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(posicao.linhas -1, posicao.colunas);
            if (tab.posicaoValida(pos)&& podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;

            }
            //ne
            pos.definirValores(posicao.linhas - 1, posicao.colunas+1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;

            }
            //direita
            pos.definirValores(posicao.linhas , posicao.colunas+1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;

            }
            //se
            pos.definirValores(posicao.linhas + 1, posicao.colunas+1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;

            }
            //abaixo
            pos.definirValores(posicao.linhas + 1, posicao.colunas);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;

            }
            //so
            pos.definirValores(posicao.linhas + 1, posicao.colunas-1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;

            }
            //esquerda
            pos.definirValores(posicao.linhas, posicao.colunas-1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;

            }
            //no
            pos.definirValores(posicao.linhas - 1, posicao.colunas-1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.linhas, pos.colunas] = true;

            }
            return mat;

        }
    }
}
