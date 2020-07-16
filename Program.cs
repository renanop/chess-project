using System;
using chess.Table;
using chess.ChessGame;

namespace chess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyTable tab = new MyTable(8, 8);
                tab.AddPiece(new Tower(tab, Color.Black), new Position(0, 0));
                tab.AddPiece(new Tower(tab, Color.Black), new Position(1, 3));
                tab.AddPiece(new King(tab, Color.Black), new Position(2, 4));

                GameScreen.PrintChess(tab);

            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }



        }
    }
}
