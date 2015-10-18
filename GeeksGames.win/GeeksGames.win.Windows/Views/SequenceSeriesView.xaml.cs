using Cirrious.MvvmCross.WindowsCommon.Views;
using GeeksGames.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
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
    public sealed partial class SequenceSeriesView : MvxWindowsPage
    {
        public SequenceSeriesView()
        {
            this.InitializeComponent();
        }

        public new SequenceSeriesViewModel ViewModel
        {
            get { return (SequenceSeriesViewModel)base.ViewModel; }
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

        private void SubmitButtonClick(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(SubmitTxt.Text))
            {
                bool getAnswer = ViewModel.CheckThis(Convert.ToInt32(SubmitTxt.Text));
                if (getAnswer)
                {
                    //Right
                    //  AudioHelper.AudioPlayer.Instance.PlayAudio(@"HelloWorld.wav");
                    //MediaElement m = new MediaElement();
                    //StorageFolder folder = (StorageFolder) GeeksGames.win.Views.Sound;
                    //StorageFile file = await folder.GetFileAsync("applause-01.wav");
                    //var stream = await file.OpenAsync(FileAccessMode.Read);
                    //m.SetSource(stream, file.ContentType);
                    //m.Play();


                    submitbtn.Visibility = Visibility.Collapsed;
                    correctansGrid.Visibility = Visibility.Visible;
                    int time = Convert.ToInt32(TimeSpan.FromTicks(ViewModel.ElapsedTime()).TotalSeconds);
                    
                    elapsedtime.Text = time.ToString();
                    if (time <= 5)
                    {
                        star3img.Visibility = Visibility.Visible;
                        star2img.Visibility = Visibility.Visible;
                        star1img.Visibility = Visibility.Visible;
                    }
                    else if (time > 5 && time <= 10)
                    {
                        star3img.Visibility = Visibility.Collapsed;
                        star2img.Visibility = Visibility.Visible;
                        star1img.Visibility = Visibility.Visible;
                    }
                    else
                    {

                        star3img.Visibility = Visibility.Collapsed;
                        star2img.Visibility = Visibility.Collapsed;
                        star1img.Visibility = Visibility.Visible;

                    }


                }
                else
                {
                    //Wrong
                    submitbtn.Visibility = Visibility.Collapsed;
                    wrongansGrid.Visibility = Visibility.Visible;
                }
            }
            else
            {
                //Show error enter a val
                MessageDialog msgDialog = new MessageDialog("Enter a value.", "Blank value not allowed.");
                //OK Button
                UICommand okBtn = new UICommand("OK");
                okBtn.Invoked = OkBtnClick;
                msgDialog.Commands.Add(okBtn);
                msgDialog.ShowAsync();
            }
        }

        private void OkBtnClick(IUICommand command)
        {

        }

        private void TryAgainButtonClick(object sender, RoutedEventArgs e)
        {
            ViewModel.RereshTick();
            if (correctansGrid.Visibility == Visibility.Visible)
            {
                correctansGrid.Visibility = Visibility.Collapsed;
                submitbtn.Visibility = Visibility.Visible;
            }
            else if (wrongansGrid.Visibility == Visibility.Visible)
            {
                wrongansGrid.Visibility = Visibility.Collapsed;
                submitbtn.Visibility = Visibility.Visible;
            }
        }

        private void GoToMainMenuuButtonClick(object sender, RoutedEventArgs e)
        {
            ViewModel.GoToMainMenu();
        }
    }
}
