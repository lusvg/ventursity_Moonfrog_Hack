using Cirrious.MvvmCross.WindowsCommon.Views;
using GeeksGames.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GeeksGames.win.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TicTacToeView : MvxWindowsPage
    {
        public TicTacToeView()
        {
            this.InitializeComponent();
        }

        public new TicTacToeViewModel ViewModel
        {
            get { return (TicTacToeViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        private void GoBack(object sender, TappedRoutedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame == null)
            {
                return;
            }

            if (frame.CanGoBack)
            {
                frame.GoBack();
            }
        }

        int turn = 1;
        int click1 = 0, click2 = 0, click3 = 0, click4 = 0, click5 = 0, click6 = 0, click7 = 0, click8 = 0, click9 = 0;
        int player1 = 0, player2 = 0;

        private void Stack1Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (click1 == 0)
            {
                if (turn % 2 != 0)
                {
                    txt1.Text = "X";
                    click1++;
                }
                else
                {
                    txt1.Text = "O";
                    click1++;
                }
                turn++;
            }
            else
            {
                txt1.Text = txt1.Text;
            }
            display();
            checkit();
        }
        int i = 0;
        private void checkit()
        {
            i++;
            if (txt1.Text != "" && txt2.Text != "" && txt3.Text != "")
            {
                if (txt1.Text == txt2.Text && txt1.Text == txt3.Text)
                {
                    btn1.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn2.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn3.Background = new SolidColorBrush(Windows.UI.Colors.Red);

                    if (txt1.Text == "X")
                    {
                        ply1win.Visibility = Visibility.Visible;
                        ply2win.Visibility = Visibility.Collapsed;
                        player1++;
                        pl1sc.Text = player1.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        ply1win.Visibility = Visibility.Collapsed;
                        ply2win.Visibility = Visibility.Visible;
                        player2++;
                        pl2sc.Text = player2.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    DisableButtons();


                }
            }
            if (txt4.Text != "" && txt5.Text != "" && txt6.Text != "")
            {
                if (txt4.Text == txt5.Text && txt4.Text == txt6.Text)
                {
                    btn4.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn5.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn6.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    if (txt4.Text == "X")
                    {
                        ply1win.Visibility = Visibility.Visible;
                        ply2win.Visibility = Visibility.Collapsed;
                        player1++;
                        pl1sc.Text = player1.ToString();
                        PlayAgain.Visibility = Visibility.Visible;

                    }
                    else
                    {
                        ply1win.Visibility = Visibility.Collapsed;
                        ply2win.Visibility = Visibility.Visible;
                        player2++;
                        pl2sc.Text = player2.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    DisableButtons();
                }
            }
            if (txt7.Text != "" && txt8.Text != "" && txt9.Text != "")
            {
                if (txt7.Text == txt8.Text && txt7.Text == txt9.Text)
                {
                    btn7.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn8.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn9.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    if (txt7.Text == "X")
                    {
                        ply1win.Visibility = Visibility.Visible;
                        ply2win.Visibility = Visibility.Collapsed;
                        player1++;
                        pl1sc.Text = player1.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        ply1win.Visibility = Visibility.Collapsed;
                        ply2win.Visibility = Visibility.Visible;
                        player2++;
                        pl2sc.Text = player2.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    DisableButtons();
                }
            }
            if (txt1.Text != "" && txt4.Text != "" && txt7.Text != "")
            {
                if (txt1.Text == txt4.Text && txt1.Text == txt7.Text)
                {
                    btn1.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn4.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn7.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    if (txt1.Text == "X")
                    {
                        ply1win.Visibility = Visibility.Visible;
                        ply2win.Visibility = Visibility.Collapsed;
                        player1++;
                        pl1sc.Text = player1.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        ply1win.Visibility = Visibility.Collapsed;
                        ply2win.Visibility = Visibility.Visible;
                        player2++;
                        pl2sc.Text = player2.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    DisableButtons();
                }
            }
            if (txt2.Text != "" && txt5.Text != "" && txt8.Text != "")
            {
                if (txt2.Text == txt5.Text && txt2.Text == txt8.Text)
                {
                    btn2.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn5.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn8.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    if (txt2.Text == "X")
                    {
                        ply1win.Visibility = Visibility.Visible;
                        ply2win.Visibility = Visibility.Collapsed;
                        player1++;
                        pl1sc.Text = player1.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        ply1win.Visibility = Visibility.Collapsed;
                        ply2win.Visibility = Visibility.Visible;
                        player2++;
                        pl2sc.Text = player2.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    DisableButtons();
                }
            }
            if (txt3.Text != "" && txt6.Text != "" && txt9.Text != "")
            {
                if (txt3.Text == txt6.Text && txt3.Text == txt9.Text)
                {
                    btn3.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn6.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn9.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    if (txt3.Text == "X")
                    {
                        ply1win.Visibility = Visibility.Visible;
                        ply2win.Visibility = Visibility.Collapsed;
                        player1++;
                        pl1sc.Text = player1.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        ply1win.Visibility = Visibility.Collapsed;
                        ply2win.Visibility = Visibility.Visible;
                        player2++;
                        pl2sc.Text = player2.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    DisableButtons();
                }
            }
            if (txt1.Text != "" && txt5.Text != "" && txt9.Text != "")
            {
                if (txt1.Text == txt5.Text && txt1.Text == txt9.Text)
                {
                    btn1.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn5.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn9.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    if (txt1.Text == "X")
                    {
                        ply1win.Visibility = Visibility.Visible;
                        ply2win.Visibility = Visibility.Collapsed;
                        player1++;
                        pl1sc.Text = player1.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        ply1win.Visibility = Visibility.Collapsed;
                        ply2win.Visibility = Visibility.Visible;
                        player2++;
                        pl2sc.Text = player2.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    DisableButtons();
                }
            }
            if (txt3.Text != "" && txt5.Text != "" && txt7.Text != "")
            {
                if (txt3.Text == txt5.Text && txt3.Text == txt7.Text)
                {
                    btn3.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn5.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    btn7.Background = new SolidColorBrush(Windows.UI.Colors.Red);
                    if (txt3.Text == "X")
                    {
                        ply1win.Visibility = Visibility.Visible;
                        ply2win.Visibility = Visibility.Collapsed;
                        player1++;
                        pl1sc.Text = player1.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        ply1win.Visibility = Visibility.Collapsed;
                        ply2win.Visibility = Visibility.Visible;
                        player2++;
                        pl2sc.Text = player2.ToString();
                        PlayAgain.Visibility = Visibility.Visible;
                    }
                    DisableButtons();
                }
            }
           if(i==9)
            {
                PlayAgain.Visibility = Visibility.Visible;
                i = 0;
            }

        }

        public void DisableButtons()
        {
            btn1.IsEnabled = false;
            btn1.IsHitTestVisible = false;
            btn2.IsEnabled = false;
            btn2.IsHitTestVisible = false;
            btn3.IsEnabled = false;
            btn3.IsHitTestVisible = false;
            btn4.IsEnabled = false;
            btn4.IsHitTestVisible = false;
            btn5.IsEnabled = false;
            btn5.IsHitTestVisible = false;
            btn6.IsEnabled = false;
            btn6.IsHitTestVisible = false;
            btn7.IsEnabled = false;
            btn7.IsHitTestVisible = false;
            btn8.IsEnabled = false;
            btn8.IsHitTestVisible = false;
            btn9.IsEnabled = false;
            btn9.IsHitTestVisible = false;
        }

        public void EnableButtons()
        {
            btn1.IsEnabled = true;
            btn1.IsHitTestVisible = true;
            btn2.IsEnabled = true;
            btn2.IsHitTestVisible = true;
            btn3.IsEnabled = true;
            btn3.IsHitTestVisible = true;
            btn4.IsEnabled = true;
            btn4.IsHitTestVisible = true;
            btn5.IsEnabled = true;
            btn5.IsHitTestVisible = true;
            btn6.IsEnabled = true;
            btn6.IsHitTestVisible = true;
            btn7.IsEnabled = true;
            btn7.IsHitTestVisible = true;
            btn8.IsEnabled = true;
            btn8.IsHitTestVisible = true;
            btn9.IsEnabled = true;
            btn9.IsHitTestVisible = true;
        }

        public void cleargame()
        {
            pl1.Visibility = Visibility.Collapsed;
            pl2.Visibility = Visibility.Collapsed;
            turn = 1;
            click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
            btn1.Background = new SolidColorBrush(Windows.UI.Colors.Transparent);
            btn2.Background = new SolidColorBrush(Windows.UI.Colors.Transparent);
            btn3.Background = new SolidColorBrush(Windows.UI.Colors.Transparent);
            btn4.Background = new SolidColorBrush(Windows.UI.Colors.Transparent);
            btn5.Background = new SolidColorBrush(Windows.UI.Colors.Transparent);
            btn6.Background = new SolidColorBrush(Windows.UI.Colors.Transparent);
            btn7.Background = new SolidColorBrush(Windows.UI.Colors.Transparent);
            btn8.Background = new SolidColorBrush(Windows.UI.Colors.Transparent);
            btn9.Background = new SolidColorBrush(Windows.UI.Colors.Transparent);
            EnableButtons();
        }

        private void ResetandPlayAgain(object sender, RoutedEventArgs e)
        {
            cleargame();
            ply1win.Visibility = Visibility.Collapsed;
            ply2win.Visibility = Visibility.Collapsed;
            PlayAgain.Visibility = Visibility.Collapsed;
            pl1.Visibility = Visibility.Visible;
        }

        private void display()
        {
            if (turn % 2 != 0)
            {
                pl1.Visibility = Visibility.Visible;
                pl2.Visibility = Visibility.Collapsed;
            }
            else
            {
                pl1.Visibility = Visibility.Collapsed;
                pl2.Visibility = Visibility.Visible;
            }
        }

        private void Stack2Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (click2 == 0)
            {
                if (turn % 2 != 0)
                {
                    txt2.Text = "X";
                    click2++;
                }
                else
                {
                    txt2.Text = "O";
                    click2++;
                }
                turn++;
            }
            else
            {
                txt2.Text = txt2.Text;
            }
            display();
            checkit();
        }

        private void Stack3Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (click3 == 0)
            {
                if (turn % 2 != 0)
                {
                    txt3.Text = "X";
                    click3++;
                }
                else
                {
                    txt3.Text = "O";
                    click3++;
                }
                turn++;
            }
            else
            {
                txt3.Text = txt3.Text;
            }
            display();
            checkit();
        }

        private void Stack4Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (click4 == 0)
            {
                if (turn % 2 != 0)
                {
                    txt4.Text = "X";
                    click4++;
                }
                else
                {
                    txt4.Text = "O";
                    click4++;
                }
                turn++;
            }
            else
            {
                txt4.Text = txt4.Text;
            }
            display();
            checkit();
        }

        private void Stack5Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (click5 == 0)
            {
                if (turn % 2 != 0)
                {
                    txt5.Text = "X";
                    click5++;
                }
                else
                {
                    txt5.Text = "O";
                    click5++;
                }
                turn++;
            }
            else
            {
                txt5.Text = txt5.Text;
            }
            display();
            checkit();
        }

        private void Stack6Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (click6 == 0)
            {
                if (turn % 2 != 0)
                {
                    txt6.Text = "X";
                    click6++;
                }
                else
                {
                    txt6.Text = "O";
                    click6++;
                }
                turn++;
            }
            else
            {
                txt6.Text = txt6.Text;
            }
            display();
            checkit();
        }

        private void Stack7Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (click7 == 0)
            {
                if (turn % 2 != 0)
                {
                    txt7.Text = "X";
                    click7++;
                }
                else
                {
                    txt7.Text = "O";
                    click7++;
                }
                turn++;
            }
            else
            {
                txt7.Text = txt7.Text;
            }
            display();
            checkit();
        }

        private void Stack8Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (click8 == 0)
            {
                if (turn % 2 != 0)
                {
                    txt8.Text = "X";
                    click8++;
                }
                else
                {
                    txt8.Text = "O";
                    click8++;
                }
                turn++;
            }
            else
            {
                txt8.Text = txt8.Text;
            }
            display();
            checkit();
        }

        private void Stack9Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (click9 == 0)
            {
                if (turn % 2 != 0)
                {
                    txt9.Text = "X";
                    click9++;
                }
                else
                {
                    txt9.Text = "O";
                    click9++;
                }
                turn++;
            }
            else
            {
                txt9.Text = txt9.Text;
            }
            display();
            checkit();
        }
    }
}
