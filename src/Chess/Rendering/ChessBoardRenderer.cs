using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace Chess.Rendering
{
    internal static class ChessBoardRenderer
    {
        private const short BoardSize = 8;

        private static Color WhiteSquaresColor = (Color)ColorConverter.ConvertFromString("#EBECD0");
        private static Color BlackSquaresColor = (Color)ColorConverter.ConvertFromString("#779455");

        public static void Render(Grid chessBoardGrid)
        {
            chessBoardGrid.Children.Clear();

            chessBoardGrid.RowDefinitions.Clear();
            chessBoardGrid.ColumnDefinitions.Clear();

            for (short i = 0; i < BoardSize; i++)
            {
                chessBoardGrid.RowDefinitions.Add(new RowDefinition());
                chessBoardGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (short row = 0; row < BoardSize; row++)
            {
                for (short col = 0; col < BoardSize; col++)
                {
                    bool isWhiteSquare = (row + col) % 2 == 0;

                    var backgroundColor =
                       isWhiteSquare
                       ? WhiteSquaresColor
                       : BlackSquaresColor;

                    var textColor =
                        isWhiteSquare
                        ? BlackSquaresColor
                        : WhiteSquaresColor;

                    var squareGrid = new Grid
                    {
                        Background =
                            new SolidColorBrush(backgroundColor)
                    };

                    if (col == 0)
                    {
                        var text =
                            (BoardSize - row).ToString();

                        var label =
                            GetLabel(text, textColor, isWhiteSquare, false);

                        squareGrid.Children.Add(label);
                    }

                    if (row == BoardSize - 1)
                    {
                        var text =
                            ((char)('A' + col)).ToString().ToLower();

                        var label =
                            GetLabel(text, textColor, isWhiteSquare, true);

                        squareGrid.Children.Add(label);
                    }

                    Grid.SetRow(squareGrid, row);
                    Grid.SetColumn(squareGrid, col);

                    chessBoardGrid.Children.Add(squareGrid);
                }
            }
        }

        private static TextBlock GetLabel(object text, Color textColor, bool isWhiteSquare, bool isRow)
        {
            return new TextBlock
            {
                Text = text.ToString(),
                FontFamily = new FontFamily("Tahoma"),
                FontSize = 13.5,
                FontWeight = FontWeights.Medium,
                Foreground = new SolidColorBrush(textColor),

                Margin = isRow
                         ? new Thickness(0, 0, 4, 4)
                         : new Thickness(4, 4, 0, 0),

                HorizontalAlignment =
                        isRow
                        ? HorizontalAlignment.Right
                        : HorizontalAlignment.Left,

                VerticalAlignment =
                        isRow
                        ? VerticalAlignment.Bottom
                        : VerticalAlignment.Top,

                Effect = new DropShadowEffect
                {
                    Color =
                        isWhiteSquare
                        ? BlackSquaresColor
                        : WhiteSquaresColor,

                    BlurRadius = 2,
                    Direction = 315,
                    ShadowDepth = 0,
                    Opacity = 0.5
                }
            };
        }
    }
}