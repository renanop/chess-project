namespace chess.Table
{
    public class Piece
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
    }
}