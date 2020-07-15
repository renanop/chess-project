namespace chess.Table
{
    public class Piece
    {
        public Position Position { get; set; }
        public MyTable Table { get; protected set; }
        public Color Color { get; protected set; }
        public int NumMovements { get; protected set; }

        public Piece(Position position, MyTable table, Color color)
        {
            Position = position;
            Table = table;
            Color = color;
            NumMovements = 0;
        }
    }
}