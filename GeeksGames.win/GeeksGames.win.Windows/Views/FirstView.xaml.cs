using Cirrious.MvvmCross.WindowsCommon.Views;
using GeeksGames.Core.ViewModels;

namespace GeeksGames.win.Views
{
    public sealed partial class FirstView : MvxWindowsPage
    {
        public FirstView()
        {
            this.InitializeComponent();
        }

        public new FirstViewModel ViewModel
        {
            get { return (FirstViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        private void GoToSeqSeriesGames(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            ViewModel.GoToSeqSeriesView();
        }

        private void GoToTicTac(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            ViewModel.GoToTicTacToe();
        }

        private void GoToPrediction(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            ViewModel.GoToPrediction(); 
        }

        //private void GoToCardWar(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        //{
        //    ViewModel.GoToCardWar();
        //}
    }
}
