
namespace tabuleiro
{
    class Posicao
    {
        public int linhas { get; set; }
        public int colunas { get; set; }

        public Posicao(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;

        }

        public void definirValores(int linha,int coluna)
        {
            this.linhas = linhas;
            this.colunas = colunas;
        }

        public override string ToString()
        {
            return linhas
                +", "
                +colunas;
        }
    }
}
