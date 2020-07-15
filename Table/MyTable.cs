namespace chess.Table
{
    public class MyTable
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces { get; set; }

        public MyTable(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece[rows, columns];
        }

        public Piece GetPiece(int row, int column)
        {
            return Pieces[row, column];
        }
    }
}