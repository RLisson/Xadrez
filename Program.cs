using ProjetoXadrez.tabuleiro;
using ProjetoXadrez.xadrez;

namespace ProjetoXadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 0));

            Tela.ImprimirTabuleiro(tab);
        }
    }
}
