using System;

namespace tabuleiro {
   abstract class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        //construtor da classe peça.
        public Peca( Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }
        public bool existeMovimentosPossiveis() {
            bool [,] mat = movimentosPossiveis();
            for(int i = 0; i < tab.linhas; i++) {
                for(int j = 0; j < tab.colunas; j++) {
                    if(mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public void incrementarQtdMovimentos() {
            qteMovimentos++;
        }
        public void decrementarQtdMovimentos() {
            qteMovimentos--;
        }

        public bool movimentoPossivel(Posicao pos) {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }
        public abstract bool[,] movimentosPossiveis();
    }
}
