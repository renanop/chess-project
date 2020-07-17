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
            try
            {
                ChessMatch match = new ChessMatch();
                while (!match.IsMatchOver)
                {
                    Console.Clear();
                    System.Console.WriteLine("----------- WELCOME TO THE CHESS MATCH!!--------------");
                    System.Console.WriteLine();
                    GameScreen.PrintChess(match.Tab);
                    System.Console.Write("Origin: ");
                    Position origin = GameScreen.ReadPositionChess().ToPosition();
                    System.Console.Write("Destination: ");
                    Position destination = GameScreen.ReadPositionChess().ToPosition();

                    match.MakeMove(origin, destination);

                }


            }
            catch (TableException t)
            {
                System.Console.WriteLine(t.Message);
            }

            Console.ReadLine();
            
        }
    }
}
