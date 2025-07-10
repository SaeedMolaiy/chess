using System.Windows;

namespace Chess
{
    public partial class MainWindow : Window
    {
        private readonly ChessBoard _board;

        public MainWindow()
        {
            InitializeComponent();

            _board = new ChessBoard(ChessBoardGrid);
        }
    }
}