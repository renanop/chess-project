using System;
using chess.Table;
using chess.ChessGame;
using chess;

namespace chess
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTable tab = new MyTable(8,8);
            tab.AddPiece(new Tower(tab, Color.White), new Position(0,0));
            tab.AddPiece(new King(tab, Color.Green), new Position(7,7));
            GameScreen.PrintChess(tab);
        }
    }
}
