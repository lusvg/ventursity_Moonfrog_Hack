using Cirrious.MvvmCross.ViewModels;

namespace GeeksGames.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		
        public void GoToSeqSeriesView()
        {
            this.ShowViewModel<SequenceSeriesViewModel>();
        }

        public void GoToTicTacToe()
        {
            this.ShowViewModel<TicTacToeViewModel>();
        }

        public void GoToPrediction()
        {
            this.ShowViewModel<PredictionViewModel>();
        }

        //public void GoToCardWar()
        //{
        //    this.ShowViewModel<CardWarViewModel>();
        //}


    }
}
