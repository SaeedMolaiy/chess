namespace Chess.Engine
{
    public class Pawn : Piece
    {
        public Pawn(Position startingPosition) : base(startingPosition)
        {
        }

        public override string Code => "";

        public override PieceMovementType MovementType =>
            PieceMovementType.OneSquareForward | PieceMovementType.TwoSquareForward;
    }
}