namespace ProjetoXadrez.tabuleiro
{
    internal abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QntdMovimentos {  get; protected set; }
        public Tabuleiro Tab {  get; protected set; }

        public Peca(Cor cor, Tabuleiro tabuleiro)
        {
            Posicao = null;
            Tab = tabuleiro;
            Cor = cor;
            QntdMovimentos = 0;
        }

        public void IncrementarQntdMovimentos()
        {
            QntdMovimentos++;
        }

        public void DecrementarQntdMovimentos()
        {
            QntdMovimentos--;
        }
        protected bool PodeMover(Posicao pos)
        {
            Peca p = Tab.Peca(pos.Linha, pos.Coluna);
            return p == null || p.Cor != Cor;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool MovimentoPossivel(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
