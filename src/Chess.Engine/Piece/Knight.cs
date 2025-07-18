namespace Chess.Engine
{
    public class Knight : Piece
    {
        public Knight(Position startingPosition) : base(startingPosition)
        {
        }

        public override string Code => "N";

        public override PieceMovementType MovementType => PieceMovementType.LShape;
    }
}