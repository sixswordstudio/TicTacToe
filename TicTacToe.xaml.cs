using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToeGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TicTacToe : Window
    {
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void btnClick(object sender, RoutedEventArgs e)
        {
            // When the button is clicked, set the content of the button to "X" or "O" based on the current player
            Button button = (Button)sender;
            if (button.Name == "btn00" || button.Name == "btn01" || button.Name == "btn02" || button.Name == "btn10" || button.Name == "btn11" || button.Name == "btn12" || button.Name == "btn20" || button.Name == "btn21" || button.Name == "btn22")
            {
                button.Content = "X"; // Set the content to "X" for player 1
                // Make the content red foreground color for player 1
                button.Foreground = Brushes.Red;
                button.FontSize = 35; // Set the font size to 35
                button.IsEnabled = false; // Disable the button after it's clicked but ensure it is still visible
                //TODO: Add CheckForWinner(); that Checks if there's a winner
               
            }
        }
    }
}