using chess.Table;
namespace chess.ChessGame
{
    public class Tower : Piece
    {
        public Tower(MyTable table, Color color) : base(table, color)
        {

        }
        public override string ToString()
        {
            return "T";
        }
        private bool CanMove(Position pos)
        {
            Piece p = Table.GetPiece(pos);
            return p == null || p.Color != Color;
        }

        public override bool[,] PossibleMoves()
        {
            bool[,] mat = new bool[Table.Rows, Table.Columns];
            Position pos = new Position(0, 0);

            // North
            pos.DefineValues(Position.Rows - 1, Position.Columns);
            while (Table.IsTruePosition(pos) && CanMove(pos))
            {
                mat[pos.Rows, pos.Columns] = true;
                if (Table.GetPiece(pos) != null && Table.GetPiece(pos).Color != Color)
                {
                    break;
                }
                pos.Rows = pos.Rows - 1;

            }
            // South
            pos.DefineValues(Position.Rows + 1, Position.Columns);
            while (Table.IsTruePosition(pos) && CanMove(pos))
            {
                mat[pos.Rows, pos.Columns] = true;
                if (Table.GetPiece(pos) != null && Table.GetPiece(pos).Color != Color)
                {
                    break;
                }
                pos.Rows = pos.Rows + 1;

            }
            // East
            pos.DefineValues(Position.Rows, Position.Columns + 1);
            while (Table.IsTruePosition(pos) && CanMove(pos))
            {
                mat[pos.Rows, pos.Columns] = true;
                if (Table.GetPiece(pos) != null && Table.GetPiece(pos).Color != Color)
                {
                    break;
                }
                pos.Columns = pos.Columns + 1;

            }
            // West
            pos.DefineValues(Position.Rows, Position.Columns - 1);
            while (Table.IsTruePosition(pos) && CanMove(pos))
            {
                mat[pos.Rows, pos.Columns] = true;
                if (Table.GetPiece(pos) != null && Table.GetPiece(pos).Color != Color)
                {
                    break;
                }
                pos.Columns = pos.Columns - 1;

            }
            return mat;
        }
    }
}