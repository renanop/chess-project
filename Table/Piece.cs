namespace chess.Table
{
    public abstract class Piece
    {
        public Position Position { get; set; }
        public MyTable Table { get; protected set; }
        public Color Color { get; protected set; }
        public int NumMovements { get; protected set; }

        public Piece(MyTable table, Color color)
        {
            Position = null;
            Table = table;
            Color = color;
            NumMovements = 0;
        }

        public void IncrementNumMovements()
        {
            NumMovements++;
        }

        public bool ExistPossibleMoves()
        {
            bool[,] mat = PossibleMoves();
            for (int i = 0; i < Table.Rows; i++)
            {
                for (int j = 0; j < Table.Columns; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CanMoveToPosition(Position pos)
        {
            return PossibleMoves()[pos.Rows, pos.Columns];
        }

        public abstract bool[,] PossibleMoves();


    }
}