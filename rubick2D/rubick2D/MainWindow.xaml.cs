using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
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
        private Game _game = new Game();

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
        private Matrix _matrix = new Matrix();

        public void NewGame()
        {
            _matrix.Init();
        }

        public void About()
        {
        }
    }

    public class Matrix

    {
        private int[][] _matrix = new int[4][];


        public int PosX { get; }
        public int PosY { get; }


        public void Init()
        {
            for (int i = 0; i < _matrix.Length; i++)
            {
                _matrix[i] = new int[4];
                for (int j = 0; j < _matrix.Length; j++) // так как матрица квадратная используем _matrix.Length
                {
                    _matrix[i][j] = i * _matrix.Length + j + 1;
                }
            }

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                bool flag = random.Next(0, 1) != 0;
                Shift(flag, !flag);
            }
        }

        public void Shift(bool orientation, bool direction)
        {
            if (orientation) // горизонтальная 
            {             
            }
            else // вертикальная
            {
            }
        }

        int[] ShiftLeft(int[] array)
        {
            int curr = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int next = array[i - 1];
                array[i - 1] = curr;
                curr = next;
            }

            array[array.Length - 1] = curr;
            return array;
        }
        int[] ShiftRight(int[] array)
        {
            int curr = array[0];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                int next = array[i + 1];
                array[i + 1] = curr;
                curr = next;
            }

            array[0] = curr;
            return array;
        }
    }
}