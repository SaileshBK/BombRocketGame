﻿using gameLogic;
using GameLogic;
using GameLogic.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using System.Windows.Shapes;
namespace SnakeLadder
{
    public partial class menu : Window
    {
        Decoration decoration = new Decoration();
        PreGame pregameLogic = new PreGame();
        
        private static int turn = 1;   //keep tracks of who's turn is it 
        private static int boot;    //used to contain the random amount of spaces the rocket/bomb send you
        private void How_much_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pregameLogic.How_much_SelectionChanged(sender, e, ref How_much, ref here, ref sele, ref info);
        }

        private void info_Click(object sender, RoutedEventArgs e)
        {
            pregameLogic.info_Click(sender,e, ref info,ref  here, ref Dice, ref its);
        }

        public menu()
        {
            InitializeComponent();
            ColorTable();   // create the playing board
            How_much.SelectedIndex = 0;
            this.KeyDown += MainWindow_KeyDown;   //access responsive key game
        }

        private void Dice_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int rolled = random.Next(1, 7);   //present a cube throw
            dikk(rolled);   //the random number showed to the player
            pregameLogic.playerData[turn - 1].Place += rolled;   //advance the player relatively to his throw
            if (pregameLogic.playerData[turn - 1].Place > 100) pregameLogic.playerData[turn - 1].Place = 100 - (pregameLogic.playerData[turn - 1].Place - 100);   //if the player's roll surpass 100 he'll go back the amount he went over
            else if (pregameLogic.playerData[turn - 1].Place == 100)   //if the player land on 100 he wins
            {
                MessageBox.Show($"player {turn}. {pregameLogic.playerData[turn - 1].Name} won");
                MainWindow main = new MainWindow();
                this.Close();   // close current window
                main.Show();   // goes back to menu
            }
               //we can use both "playerData" and "turn" to use the data of the player currently rolling. since "turn" resets at 1 and list start from 0 we'll need to subtrack 1 from turn to have perfect connection
            int Row =    //every row is 10 spaces, every row is from column 1-10
                 pregameLogic.playerData[turn - 1].Place % 10 != 0 ? 1 + pregameLogic.playerData[turn - 1].Place / 10    //example: player on place 8-> 8/10=0 but we start our column from 1 therefore we'll add 1 to match our board-> 1+8/10=1+0-> row=1
               : pregameLogic.playerData[turn - 1].Place / 10;   //example: player land on 10-> 10/10=1, since every row is 10 spaces, in this case, it will be wrong to add 1-> 10/10=1 -> row=1

            int Colom =   //every column is 10 spaces, every colomn is from row 1-10, every 2nd row the direction is changed-> example:1st row goes left to right, 2nd row goes from right to left 
                Row % 2 != 0 && pregameLogic.playerData[turn - 1].Place % 10 == 0 ? 10   //example:10-> 10's row is 1 using the row's formula, 1%2!=0 and 10%10=0 -> column is set to 10
              : Row % 2 == 0 && pregameLogic.playerData[turn - 1].Place % 10 == 0 ? 1   //example:20-> 20's row is 2, 2%2=0 and 20%10=0 -> column is set to 1
              : Row % 2 == 0 && pregameLogic.playerData[turn - 1].Place % 10 != 0 ? 11 - (pregameLogic.playerData[turn - 1].Place % 10)   //example:11-> 11's row is 2, 2%2=0 and 11%10=1 -> since every 2nd row the path is from right to left we'll count from the right ->11-(11%10)=11-1-> column=10    
              : pregameLogic.playerData[turn - 1].Place % 10;   //example:1-> 1's row is 1, 1%2!=0 and 1%10=1 -> column=1

            int total = 0;   //count the total spaces player gained/lost cause of bombs/rockets
            bool bom = false;   //if player land on bomb raise flag
            bool boos = false;   //if player land on rocket raise flag
            bool falg;   //if player land on anything raise flag 

            do    // check once if the current player land on either bomb or rocket
            {
                falg = false;
                List<int> boost = new List<int>() { 4, 23, 29, 44, 63, 71 };   //places of every rocket on the board
                foreach (int placeBoost in boost) if (placeBoost == pregameLogic.playerData[turn - 1].Place)
                    {
                           //if player land on rocket show the character  on the rocket before moving him
                        GridPP.Children.Remove(pregameLogic.playerData[turn - 1].TextBlock);
                        Grid.SetRow(pregameLogic.playerData[turn - 1].TextBlock, Row);
                        Grid.SetColumn(pregameLogic.playerData[turn - 1].TextBlock, Colom);
                        GridPP.Children.Add(pregameLogic.playerData[turn - 1].TextBlock);

                        MessageBox.Show($"Player {turn} hit rocket");
                        boot = random.Next(1, 7);   //landing on rocket makes you gain randomly between 1-6 spaces
                        total += boot;
                        pregameLogic.playerData[turn - 1].Place += boot;
                        falg = true;
                        bom = true;
                    }
                List<int> Bomb = new List<int>() { 15, 72, 81, 94, 98 };   //places of every bomb on the board
                foreach (int placeBomb in Bomb) if (placeBomb == pregameLogic.playerData[turn - 1].Place)
                    {
                           //if player land on bomb show the character  on the bomb before moving him
                        GridPP.Children.Remove(pregameLogic.playerData[turn - 1].TextBlock);
                        Grid.SetRow(pregameLogic.playerData[turn - 1].TextBlock, Row);
                        Grid.SetColumn(pregameLogic.playerData[turn - 1].TextBlock, Colom);
                        GridPP.Children.Add(pregameLogic.playerData[turn - 1].TextBlock);
                        MessageBox.Show($"Player {turn} hit bomb");
                        boot = random.Next(1, 13);   //landing on bomb makes you lose randomly between 1-12 spaces
                        total -= boot;
                        pregameLogic.playerData[turn - 1].Place -= boot;
                        falg = true;
                        boos = true;
                    }
                   //in case the bomb/rocket cuased a change of row/column check their value again
                Row = pregameLogic.playerData[turn - 1].Place % 10 != 0 ? 1 + pregameLogic.playerData[turn - 1].Place / 10 : pregameLogic.playerData[turn - 1].Place / 10;
                Colom = Row % 2 != 0 && pregameLogic.playerData[turn - 1].Place % 10 == 0 ? 10 : Row % 2 == 0 && pregameLogic.playerData[turn - 1].Place % 10 == 0 ? 1 : Row % 2 == 0 && pregameLogic.playerData[turn - 1].Place % 10 != 0 ? 11 - (pregameLogic.playerData[turn - 1].Place % 10) : pregameLogic.playerData[turn - 1].Place % 10;

            } while (falg);   //falg raised mean the player land on bomb/rocket and now he's in difference place, therefore we'll need to check if the player land on another bomb/rocket 

               //give the player relative message about how much he gain/lost from landing on bombs/rockets
            if (total > 0)
                message1.Text = boos && bom ? $"Player {turn} hit bombs\nand boosts. in total\ngain {total} steps" :
                                              $"Player {turn} hit boosts.\n in total gain {total} steps";
            else if (total < 0)
                message1.Text = boos && bom ? $"Player {turn} hit bombs\nand boosts. in total\nlose {Math.Abs(total)} steps" :
                                              $"Player {turn} hit bombs.\n in total lose {Math.Abs(total)} steps";
            else
                message1.Text = boos && bom ? $"Player {turn} hit bombs\nand boosts. but stayed\nin his space" :
                                               "";
            
            GridPP.Children.Remove(pregameLogic.playerData[turn - 1].TextBlock);
            Grid.SetRow(pregameLogic.playerData[turn - 1].TextBlock, Row);
            Grid.SetColumn(pregameLogic.playerData[turn - 1].TextBlock, Colom);
            GridPP.Children.Add(pregameLogic.playerData[turn - 1].TextBlock);
            turn = turn == pregameLogic.players ? 1    //if it's the last player's turn then next turn returned to the first player-> 3 players, it's player 3's turn, next turn will be player 1
                : turn + 1;   //else it's the next player turn-> 3 players, it's player 2's turn, next turn will be player 3
            its.Text = $"Player {turn}'s turn";
        }

        private void dikk(int roll)   //showing suitable picture according to the player's roll
        {
            decoration.dikk(ref roll, ref Imagin);
        }      

        private void ColorTable()   //since we have the movement path of the game, it's possible to set the movement to 1 space and fill each space with decoration
        {
            decoration.ColorTable(GridPP);
        }

        private void MainWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)   //once a key pressed enter the method
        {
            switch (e.Key)
            {
                case Key.Escape:   //if player press esc ask him if he's sure he want to exit the game
                    CheckQuit.Visibility = Visibility.Visible;
                    YesQuit.IsChecked = false;
                    NoQuit.IsChecked = false;
                    break;
                case Key.Home:
                    MessageBox.Show("going back to menu");   //if player press home return to menu
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                    break;
                default: break;
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)   //if player press menu button return to the menu 
        {
            MessageBox.Show("going back to menu");
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void exit_Click(object sender, RoutedEventArgs e)   //if player press the exit button exit the game
        {
            CheckQuit.Visibility = Visibility.Visible;
            YesQuit.IsChecked = false;
            NoQuit.IsChecked = false;
        }

        private void YesQuit_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("thanks for playing");
            this.Close();
        }

        private void NoQuit_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("returning to the game");
            CheckQuit.Visibility = Visibility.Hidden;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox comboBox && comboBox.SelectedItem != null)
            {
                comboBox.IsEnabled = false;
                
                foreach (Player player in pregameLogic.playerData)
                {
                    player.charactersHere.Remove(comboBox.SelectedItem.ToString());
                }
            }
           
        }
    }
}
