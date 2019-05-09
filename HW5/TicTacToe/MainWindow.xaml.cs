using System;
using System.Collections.Generic;
using System.Linq;
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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Xoro[,] gameBoard;
        private bool player1Turn;
        private bool gameEnded;
        int cnt = 0;
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }
        private void NewGame()
        {
            gameBoard = new Xoro[3, 3];
            uxGrid.IsEnabled = true;
            player1Turn = true;
            uxGrid.Children.Cast<Button>().ToList().ForEach(button => {
                button.Content = string.Empty;
            });
            gameEnded = false;
            cnt = 0;
            uxTurn.Text = "Player 1 it is your turn!";
        }

        private void uxNewGame_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }

        private void uxExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (gameEnded)
            {
                return;
            }
            var button = (Button)sender;
            var tag = button.Tag.ToString();
            string[] position = tag.Split(',');
            int column = int.Parse(position[0]); 
            int row = int.Parse(position[1]);
            if(gameBoard[row,column] != Xoro.Empty)
            {
                return;
            }
            gameBoard[row,column] = player1Turn ? Xoro.X : Xoro.O;
            button.Content = player1Turn ? "X" : "O";
            player1Turn ^= true;
            if (player1Turn)
            {
                uxTurn.Text = "Player 1 go NOW!!!!!!!!!";
            }
            else
            {
                uxTurn.Text = "Player 2 you go please!";
            }
            CheckForWinner();
            CheckForDraw();
            cnt++;
        }

        private void CheckForDraw()
        {
            if (cnt == 8)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (gameBoard[j, i] != Xoro.Empty)
                        {
                            gameEnded = true;
                            uxGrid.IsEnabled = false;
                            uxTurn.Text = "It is a draw!";
                        }
                    }
                }
            }
 
        }

        private void CheckForWinner()
        {
            if (gameBoard[0,0] != Xoro.Empty && (gameBoard[0,0] & gameBoard [1,0] & gameBoard [2,0]) == gameBoard[0, 0])
            {
                if(gameBoard[0,0] == Xoro.X)
                {
                    uxTurn.Text = "Player 1 wins";
                }
                else { uxTurn.Text = "Player 2 wins";}
                gameEnded = true;
                uxGrid.IsEnabled = false;
            }
            if (gameBoard[0, 1] != Xoro.Empty && (gameBoard[0, 1] & gameBoard[1, 1] & gameBoard[2, 1]) == gameBoard[0, 1])
            {
                if (gameBoard[0, 1] == Xoro.X)
                {
                    uxTurn.Text = "Player 1 wins";
                }
                else { uxTurn.Text = "Player 2 wins"; }
                gameEnded = true;
                uxGrid.IsEnabled = false;
            }
            if (gameBoard[0, 2] != Xoro.Empty && (gameBoard[0, 2] & gameBoard[1, 2] & gameBoard[2, 2]) == gameBoard[0, 2])
            {
                if (gameBoard[0, 2] == Xoro.X)
                {
                    uxTurn.Text = "Player 1 wins";
                }
                else { uxTurn.Text = "Player 2 wins"; }
                gameEnded = true;
                uxGrid.IsEnabled = false;
            }
            if (gameBoard[1, 0] != Xoro.Empty && (gameBoard[1, 0] & gameBoard[1, 1] & gameBoard[1, 2]) == gameBoard[1, 0])
            {
                if (gameBoard[1, 0] == Xoro.X)
                {
                    uxTurn.Text = "Player 1 wins";
                }
                else { uxTurn.Text = "Player 2 wins"; }
                gameEnded = true;
                uxGrid.IsEnabled = false;
            }
            if (gameBoard[2, 0] != Xoro.Empty && (gameBoard[2, 0] & gameBoard[2, 1] & gameBoard[2, 2]) == gameBoard[2, 0])
            {
                if (gameBoard[2, 0] == Xoro.X)
                {
                    uxTurn.Text = "Player 1 wins";
                }
                else { uxTurn.Text = "Player 2 wins"; }
                gameEnded = true;
                uxGrid.IsEnabled = false;
            }
            if (gameBoard[0, 0] != Xoro.Empty && (gameBoard[0, 0] & gameBoard[0, 1] & gameBoard[0, 2]) == gameBoard[0, 0])
            {
                if (gameBoard[0, 0] == Xoro.X)
                {
                    uxTurn.Text = "Player 1 wins";
                }
                else { uxTurn.Text = "Player 2 wins"; }
                gameEnded = true;
                uxGrid.IsEnabled = false;
            }
            if (gameBoard[0, 0] != Xoro.Empty && (gameBoard[0, 0] & gameBoard[1, 1] & gameBoard[2, 2]) == gameBoard[0, 0])
            {
                if (gameBoard[0, 0] == Xoro.X)
                {
                    uxTurn.Text = "Player 1 wins";
                }
                else { uxTurn.Text = "Player 2 wins"; }
                gameEnded = true;
                uxGrid.IsEnabled = false;
            }
            if (gameBoard[0, 2] != Xoro.Empty && (gameBoard[0, 2] & gameBoard[1, 1] & gameBoard[2, 0]) == gameBoard[0, 2])
            {
                if (gameBoard[0, 2] == Xoro.X)
                {
                    uxTurn.Text = "Player 1 wins";
                }
                else { uxTurn.Text = "Player 2 wins"; }
                gameEnded = true;
                uxGrid.IsEnabled = false;
            }
        }
    }
}
