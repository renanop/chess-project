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
                    try
                    {
                        System.Console.WriteLine("----------- WELCOME TO THE CHESS MATCH!!--------------");
                        System.Console.WriteLine();
                        GameScreen.PrintChess(match.Tab);
                        System.Console.WriteLine("Turn: " + match.Turn);
                        System.Console.WriteLine("Current Player: " + match.CurrentPlayer);
                        System.Console.WriteLine();
                        System.Console.Write("Origin: ");
                        Position origin = GameScreen.ReadPositionChess().ToPosition();
                        match.ValidateOriginPosition(origin);

                        bool[,] possiblePositions = match.Tab.GetPiece(origin).PossibleMoves();
                        GameScreen.PrintChess(match.Tab, possiblePositions);

                        System.Console.Write("Destination: ");
                        Position destination = GameScreen.ReadPositionChess().ToPosition();
                        match.ValidateDestinationPosition(origin, destination);
                        GameScreen.PrintChess(match.Tab, possiblePositions);
                        System.Console.Write("Destination: ");


                        match.MakeMove(origin, destination);
                    }
                    catch (Exception e)
                    {
                        System.Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }



                }


            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}
