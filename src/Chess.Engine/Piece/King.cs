namespace Chess.Engine
{
    public class King : Piece
    {
        public King(Position startingPosition) : base(startingPosition)
        {
        }

        public override string Code => "K";

        public override PieceMovementType MovementType => PieceMovementType.OneSquare;
    }
}