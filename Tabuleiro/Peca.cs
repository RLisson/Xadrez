namespace ProjetoXadrez.tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QntdMovimentos {  get; protected set; }
        public Tabuleiro Tab {  get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Tab = tabuleiro;
            Cor = cor;
            QntdMovimentos = 0;
        }

    }
}
