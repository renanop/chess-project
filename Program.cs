using System;
using chess.Table;
using chess.ChessGame;

namespace chess
{
    class Program
    {
        static void Main(string[] args)
        {
            PositionChess pos = new PositionChess('c', 7);
            System.Console.WriteLine(pos);
            Position posInt = pos.ToPosition();
            System.Console.WriteLine(posInt);
        }
    }
}
