namespace Chess.Engine
{
    [Flags]
    public enum PieceMovementType
    {
        OneSquare,
        OneSquareForward,
        TwoSquareForward,
        Straight,
        Diagonal,
        LShape
    }
}