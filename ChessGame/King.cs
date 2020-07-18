using chess.Table;
namespace chess.ChessGame
{
    public class King : Piece
    {
        public King(MyTable table, Color color) : base(table, color)
        {

        }
        public override string ToString()
        {
            return "K";
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

            // North:
            pos.DefineValues(Position.Rows - 1, Position.Columns);
            if (Table.IsTruePosition(pos) && CanMove(pos))
            {
                mat[pos.Rows, pos.Columns] = true;
            }
            // Northeast:
            pos.DefineValues(Position.Rows - 1, Position.Columns + 1);
            if (Table.IsTruePosition(pos) && CanMove(pos))
            {
                mat[pos.Rows, pos.Columns] = true;
            }
            // East:
            pos.DefineValues(Position.Rows, Position.Columns + 1);
            if (Table.IsTruePosition(pos) && CanMove(pos))
            {
                mat[pos.Rows, pos.Columns] = true;
            }
            // Southeast:
            pos.DefineValues(Position.Rows + 1, Position.Columns + 1);
            if (Table.IsTruePosition(pos) && CanMove(pos))
            {
                mat[pos.Rows, pos.Columns] = true;
            }
            // South:
            pos.DefineValues(Position.Rows + 1, Position.Columns);
            if (Table.IsTruePosition(pos) && CanMove(pos))
            {
                mat[pos.Rows, pos.Columns] = true;
            }
            // Southwest:
            pos.DefineValues(Position.Rows + 1, Position.Columns - 1);
            if (Table.IsTruePosition(pos) && CanMove(pos))
            {
                mat[pos.Rows, pos.Columns] = true;
            }
            // West:
            pos.DefineValues(Position.Rows, Position.Columns - 1);
            if (Table.IsTruePosition(pos) && CanMove(pos))
            {
                mat[pos.Rows, pos.Columns] = true;
            }
            // Northwest:
            pos.DefineValues(Position.Rows - 1, Position.Columns - 1);
            if (Table.IsTruePosition(pos) && CanMove(pos))
            {
                mat[pos.Rows, pos.Columns] = true;
            }

            return mat;
        }
    }
}