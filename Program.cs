using System;
using chess.Table;
using chess.ChessGame;

namespace chess
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTable tab = new MyTable(8, 8);
            tab.AddPiece(new Tower(tab, Color.Black), new Position(0, 0));
            tab.AddPiece(new Tower(tab, Color.Black), new Position(1, 3));
            tab.AddPiece(new King(tab, Color.Black), new Position(2, 4));

            GameScreen.PrintChess(tab);

        }
    }
}
