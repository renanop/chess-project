using chess.Table;
namespace chess.ChessGame
{
    public class PositionChess
    {
        public char CharColumn { get; set; }
        public int Row { get; set; }

        public PositionChess(char charColumn, int row)
        {
            CharColumn = charColumn;
            Row = row;
        }

        public override string ToString()
        {
            return "" + CharColumn + Row;
        }

        public Position ToPosition()
        {
            return new Position(8 - Row, CharColumn - 'a');
        }
    }
}