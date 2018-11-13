using System;


namespace tabuleiro {
    class Tabuleiro {

        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;
       
        //classe que cria um tabuleiro com o tamanho passado por parametro. 
        public Tabuleiro(int linhas, int colunas) {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //metodo pra imprimir a peça no tabuleiro.
        public Peca peca(int linha, int coluna) {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos) {
            return pecas[pos.linha, pos.coluna];
        }

        //metodo para testa se existe uma peca em determinada posição.
        public bool existePeca(Posicao pos) {
            validarPosicao(pos);
            return peca(pos) != null;
        }
        //metodo pra colocar a peça na matriz do tabuleiro.
        public void colocarPeca(Peca p, Posicao pos) {
            if (existePeca(pos)) {
                throw new TabuleiroException("Já existe um peça nessa posição");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos) {
            if(peca(pos)== null) {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.linha, pos.coluna] = null;
            return aux;
        }

        //metodo para testar se a posicao é valida
        public bool posicaoValida(Posicao pos) {
            if(pos.linha < 0 || pos.linha>=linhas || pos.coluna<0 || pos.coluna >= colunas) {
                return false;
            }
            return true;
        }

        //metodo para validar uma posição na matriz de pecas.
        public void validarPosicao(Posicao pos) {
            if (!posicaoValida(pos)) {
                throw new TabuleiroException("Posição invalida.");
            }
        }
    }
}
