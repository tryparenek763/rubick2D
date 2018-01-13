using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rubick2D
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Game _game= new Game();

        public MainWindow() // конструктор
        {
            InitializeComponent();
           
            
        }

        private void HideButtons()
        {
            NewGame.Visibility = Visibility.Hidden;
            About.Visibility = Visibility.Hidden;
        }

        private void NewGameClick(object sender, RoutedEventArgs e)
        {
            _game.NewGame();
             HideButtons();
        }

        private void AboutClick(object sender, RoutedEventArgs e)
        {
            _game.About();
            HideButtons();
        }
       
    }

    public class Game
    {
        public void NewGame()
        {

        }

        public void About()
        {

        }
    }
}
