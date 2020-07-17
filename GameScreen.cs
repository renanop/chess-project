using chess.Table;
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
                    if (tab.GetPiece(i, j) == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        PrintPiece(tab.GetPiece(i,j));
                        System.Console.Write(" ");
                    }
                }

                System.Console.WriteLine();
            }
            System.Console.WriteLine("  " + "a b c d e f g h");
        }

        public static void PrintPiece(Piece piece)
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
        }
    }
}