using System;

namespace ProjetoXadrez.tabuleiro
{
    internal class TabuleiroException : ApplicationException
    {
        public TabuleiroException(string msg) : base(msg) { }
    }
}
