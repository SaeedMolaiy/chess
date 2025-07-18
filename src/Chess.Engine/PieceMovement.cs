namespace Chess.Engine
{
    public struct PieceMovement
    {
        private readonly string _san;

        public PieceMovement(Piece piece, Position from, Position to, bool isCapture)
        {
            ArgumentNullException.ThrowIfNull(piece);

            _san = GenerateSan(piece, from, to, isCapture);
        }

        private static string GenerateSan(Piece piece, Position from, Position to, bool isCapture)
        {
            if (piece is King)
            {
                if ((from == Position.E1 && to == Position.G1) || (from == Position.E8 && to == Position.G8))
                    return "O-O";

                if ((from == Position.E1 && to == Position.C1) || (from == Position.E8 && to == Position.C8))
                    return "O-O-O";
            }

            var captureMarker = isCapture ? "x" : "";

            if (piece is Pawn && isCapture)
            {
                char file = from.ToString()[0];

                return $"{file}x{to}";
            }

            return $"{piece.Code}{captureMarker}{to}";
        }

        public override readonly string ToString() => _san;
    }
}