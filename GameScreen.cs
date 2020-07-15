using chess.Table;

namespace chess
{
    public class GameScreen
    {
        public static void PrintChess(MyTable tab)
        {
            for (int i = 0; i < tab.Rows; i++)
            {
                for (int j = 0; j < tab.Columns; j++)
                {
                    if (tab.GetPiece(i, j) == null)
                    {
                        System.Console.Write("- ");
                    }
                    else
                    {
                        System.Console.Write(tab.GetPiece(i, j) + " " );
                    }
                }

                System.Console.WriteLine();
            }
        }
    }
}