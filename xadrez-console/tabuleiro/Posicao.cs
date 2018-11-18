

namespace tabuleiro {
    class Posicao {
        private Peca peca;

        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }

        public Posicao(Peca peca) {
            this.peca = peca;
        }

        public void definirValores(int linha, int coluna) {
            this.linha = linha;
            this.coluna = coluna;
        }
        public override string ToString() {
            return linha
                + ", "
                + coluna;
        }
    }
}
