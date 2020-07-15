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
    }
}