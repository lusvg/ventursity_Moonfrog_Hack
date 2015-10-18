using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksGames.Core.ViewModels
{
    public class SequenceSeriesViewModel : MvxViewModel
    {

        public SequenceSeriesViewModel()
        {
            startingTck = DateTime.Now.Ticks;
        }

        public long RereshTick()
        {
            startingTck = DateTime.Now.Ticks;
            return startingTck;
        }



        public long startingTck { get; set; }
        public long endTck { get; set; }


        public bool CheckThis(int no)
        {
            if (no == 64)
            {
                endTck = DateTime.Now.Ticks;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ElapsedTime()
        {
            int time = Convert.ToInt32(endTck - startingTck);
            return time;
        }

        public void GoToMainMenu()
        {
            this.ShowViewModel<FirstViewModel>();
        }

    }
}
