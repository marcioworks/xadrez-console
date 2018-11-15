﻿using System;

namespace tabuleiro {
   abstract class Peca {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        //construtor da classe peça.
        public Peca( Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtdMovimentos = 0;
        }

        public void incrementarQtdMovimentos() {
            qtdMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
    }
}
