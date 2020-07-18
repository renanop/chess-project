using System;
using chess.Table;


namespace chess.ChessGame
{
    public class ChessMatch
    {
        public MyTable Tab { get; private set; }
        public int Turn { get; private set; }
        public Color CurrentPlayer {get; private set;}
        public bool IsMatchOver { get; private set; }

        public ChessMatch()
        {
            Tab = new MyTable(8, 8);
            Turn = 1;
            CurrentPlayer = Color.White;
            IsMatchOver = false;
            AddPieces();
        }
        public void MakeMove(Position origin, Position destination)
        {
            Piece p = Tab.RemovePiece(origin);
            p.IncrementNumMovements();
            Piece capturedPiece = Tab.RemovePiece(destination);
            Tab.AddPiece(p, destination);
        }
        public void ChangePlayer()
        {
            if(CurrentPlayer == Color.White)
            {
                CurrentPlayer = Color.Black;
            }
            else
            {
                CurrentPlayer = Color.White;
            }
        }

        public void PlayMove(Position origin, Position destination)
        {
            MakeMove(origin, destination);
            Turn++;
            ChangePlayer();
        }

        public void ValidateOriginPosition(Position pos)
        {
            if (Tab.GetPiece(pos) == null)
            {
                throw new TableException("There is no piece on that position.");
            }
            if (Tab.GetPiece(pos).Color != CurrentPlayer)
            {
                throw new TableException("Chosen piece isn't owned by the current player.");
            }
            if(!Tab.GetPiece(pos).ExistPossibleMoves())
            {
                throw new TableException("There are no available moves for the chosen piece.");
            }
            
        }

        public void ValidateDestinationPosition(Position origin, Position destination)
        {
            if(!Tab.GetPiece(origin).CanMoveToPosition(destination))
            {
                throw new TableException("Destination unavailable.");
            }
        }

        private void AddPieces()
        {
            Tab.AddPiece(new Tower(Tab, Color.White), new PositionChess('c', 1).ToPosition());
            Tab.AddPiece(new Tower(Tab, Color.White), new PositionChess('c', 2).ToPosition());
            Tab.AddPiece(new Tower(Tab, Color.White), new PositionChess('d', 2).ToPosition());
            Tab.AddPiece(new Tower(Tab, Color.White), new PositionChess('e', 2).ToPosition());
            Tab.AddPiece(new Tower(Tab, Color.White), new PositionChess('e', 1).ToPosition());
            Tab.AddPiece(new King(Tab, Color.White), new PositionChess('d', 1).ToPosition());

            Tab.AddPiece(new Tower(Tab, Color.Black), new PositionChess('c', 7).ToPosition());
            Tab.AddPiece(new Tower(Tab, Color.Black), new PositionChess('c', 8).ToPosition());
            Tab.AddPiece(new Tower(Tab, Color.Black), new PositionChess('d', 7).ToPosition());
            Tab.AddPiece(new Tower(Tab, Color.Black), new PositionChess('e', 7).ToPosition());
            Tab.AddPiece(new Tower(Tab, Color.Black), new PositionChess('e', 8).ToPosition());
            Tab.AddPiece(new King(Tab, Color.Black), new PositionChess('d', 8).ToPosition());

        }



    }
}