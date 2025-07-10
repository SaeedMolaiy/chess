using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Chess
{
    internal class ChessBoard
    {
        private const int BoardSize = 8;

        private readonly Grid _chessBoardGrid;

        public ChessBoard(Grid chessBoardGrid)
        {
            _chessBoardGrid = chessBoardGrid;

            RenderChessBoard();
        }

        private void RenderChessBoard()
        {
            var whiteSquaresColor = (Color)ColorConverter.ConvertFromString("#EBECD0");
            var blackSquaresColor = (Color)ColorConverter.ConvertFromString("#779455");

            _chessBoardGrid.RowDefinitions.Clear();
            _chessBoardGrid.ColumnDefinitions.Clear();

            for (int i = 0; i < BoardSize; i++)
            {
                _chessBoardGrid.RowDefinitions.Add(new RowDefinition());
                _chessBoardGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    bool isWhiteSquare = (row + col) % 2 == 0;

                    var rect = new Border
                    {
                        Background = new SolidColorBrush(isWhiteSquare ? whiteSquaresColor : blackSquaresColor),
                        BorderBrush = Brushes.Transparent,
                        BorderThickness = new Thickness(0)
                    };

                    Grid.SetRow(rect, row);
                    Grid.SetColumn(rect, col);

                    _chessBoardGrid.Children.Add(rect);
                }
            }
        }
    }
}