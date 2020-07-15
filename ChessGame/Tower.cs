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
    }
}