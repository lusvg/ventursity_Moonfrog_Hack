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
    public sealed partial class PredictionView : MvxWindowsPage
    {
        public PredictionView()
        {
            this.InitializeComponent();
        }

        public new PredictionViewModel ViewModel
        {
            get { return (PredictionViewModel)base.ViewModel; }
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

        private void GetCards(object sender, RoutedEventArgs e)
        {
            ViewModel.GetAllCardForDistribution();
        }
    }
}
