

namespace tabuleiro {
    class Posicao {
        int linha { get; set; }
        int coluna { get; set; }

        public Posicao(int linha, int coluna) {
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
