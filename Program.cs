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
                    System.Console.WriteLine();
                    System.Console.Write("Origin: ");
                    Position origin = GameScreen.ReadPositionChess().ToPosition();

                    bool[,] possiblePositions = match.Tab.GetPiece(origin).PossibleMoves();
                    GameScreen.PrintChess(match.Tab, possiblePositions);

                    System.Console.Write("Destination: ");
                    Position destination = GameScreen.ReadPositionChess().ToPosition();
                    GameScreen.PrintChess(match.Tab, possiblePositions);
                    System.Console.Write("Destination: ");
                    

                    match.MakeMove(origin, destination);

                }


            }
            catch (Exception t)
            {
                System.Console.WriteLine(t.Message);
            }

            Console.ReadLine();
            
        }
    }
}
