using System;
using chess.Table;

namespace chess
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTable tab = new MyTable(8,8);
            GameScreen.PrintChess(tab);
        }
    }
}
