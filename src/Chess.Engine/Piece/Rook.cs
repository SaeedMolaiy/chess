namespace Chess.Engine
{
    public class Rook : Piece
    {
        public Rook(Position startingPosition) : base(startingPosition)
        {
        }

        public override string Code => "R";

        public override PieceMovementType MovementType => PieceMovementType.Straight;
    }
}