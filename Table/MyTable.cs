namespace chess.Table
{
    public class MyTable
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces { get; set; }

        // Constructors:
        public MyTable(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece[rows, columns];
        }
        // Methods
        public Piece GetPiece(int row, int column)
        {
            return Pieces[row, column];
        }

        public Piece GetPiece(Position position)
        {
            return Pieces[position.Rows, position.Columns];
        }

        public void AddPiece(Piece piece, Position position)
        {
            if (existPiece(position))
            {
                throw new TableException("A piece already occupies that position!");
            }
            Pieces[position.Rows, position.Columns] = piece;
            piece.Position = position;
        }

        public Piece RemovePiece(Position position)
        {
            if (GetPiece(position) == null)
            {
                return null;
            }
            Piece aux = GetPiece(position);
            aux.Position = null;
            Pieces[position.Rows, position.Columns] = null;
            return aux;
        }

        public bool IsTruePosition(Position position)
        {
            if (position.Rows < 0 || position.Rows > Rows || position.Columns < 0 || position.Columns > Columns)
            {
                return false;
            }
            return true;
        }
        public void ValidPosition(Position position)
        {
            if (!IsTruePosition(position))
            {
                throw new TableException("Invalid Position: One of the values is either out of bounds or negative.");
            }
        }

        public bool existPiece(Position position)
        {
            ValidPosition(position);
            return GetPiece(position) != null;
        }
    }
}