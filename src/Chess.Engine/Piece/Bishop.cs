namespace Chess.Engine
{
    public class Bishop : Piece
    {
        public Bishop(Position startingPosition) : base(startingPosition)
        {
        }

        public override string Code => "B";

        public override PieceMovementType MovementType => PieceMovementType.Diagonal;
    }
}