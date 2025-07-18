namespace Chess.Engine
{
    public abstract class Piece
    {
        private Position currentPosition;

        protected Piece(Position startingPosition)
        {
            SetPosition(startingPosition);
        }

        public abstract string Code { get; }

        public abstract PieceMovementType MovementType { get; }

        private void SetPosition(Position newPosition)
        {
            currentPosition = newPosition;
        }
    }
}