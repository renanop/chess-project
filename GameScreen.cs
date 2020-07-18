using chess.Table;
using chess.ChessGame;
using System;

namespace chess
{
    public class GameScreen
    {
        public static void PrintChess(MyTable tab)
        {
            for (int i = 0; i < tab.Rows; i++)
            {
                System.Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Columns; j++)
                {
                    PrintPiece(tab.GetPiece(i, j));
                }

                System.Console.WriteLine();
            }
            System.Console.WriteLine("  " + "a b c d e f g h");
        }

        public static void PrintChess(MyTable tab, bool[,] possibleMoves)
        {
            ConsoleColor originalBackground = Console.BackgroundColor;
            ConsoleColor newBackground = ConsoleColor.DarkGreen;

            for (int i = 0; i < tab.Rows; i++)
            {
                System.Console.Write(8 - i + " ");
                for (int j = 0; j < tab.Columns; j++)
                {
                    if(possibleMoves[i,j])
                    {
                        Console.BackgroundColor = newBackground;
                    }
                    else
                    {
                        Console.BackgroundColor = originalBackground;
                    }
                    PrintPiece(tab.GetPiece(i, j));
                    Console.BackgroundColor = originalBackground;
                }

                System.Console.WriteLine();
            }
            System.Console.WriteLine("  " + "a b c d e f g h");
            
        }

        public static void PrintPiece(Piece piece)
        {
            if (piece == null)
            {
                System.Console.Write("- ");
            }
            else
            {
                if (piece.Color == Color.White)
                {
                    System.Console.Write(piece);
                }
                else
                {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    System.Console.Write(piece);
                    Console.ForegroundColor = aux;
                }
                System.Console.Write(" ");
            }

        }

        public static PositionChess ReadPositionChess()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1] + "");
            return new PositionChess(column, row);
        }
    }
}