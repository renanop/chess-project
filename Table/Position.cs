namespace chess.Table
{
    public class Position
    {
        public int Rows { get; set; }
        public int Columns { get; set; }

        public Position(int row, int column)
        {
            Rows = row;
            Columns = column;
        }

        public override string ToString()
        {
            return "Row: " + Rows + "\tColumn: " + Columns;
        }
    }
}