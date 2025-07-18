namespace Chess.Engine
{
    public class Queen : Piece
    {
        public Queen(Position startingPosition) : base(startingPosition)
        {
        }

        public override string Code => "Q";

        public override PieceMovementType MovementType =>
            PieceMovementType.Straight | PieceMovementType.Diagonal;
    }
}