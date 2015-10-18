using Cirrious.MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksGames.Core.ViewModels
{
    public class CardWarViewModel : MvxViewModel
    {
        public ObservableCollection<CardsDeckViewModel> First { get; set; }
        public ObservableCollection<CardsDeckViewModel> Second { get; set; }
        public ObservableCollection<CardsDeckViewModel> All { get; set; }

        public List<CardsDeckViewModel> CardsCollection = new List<CardsDeckViewModel>();

        public CardsDeckViewModel card = new CardsDeckViewModel();
        public CardWarViewModel()
        {
            //while (All.Count < 52)
            //{
            //    int isFound = 0;
            //    var obj = GenerateCardNumberAndCardType();
            //    foreach (var item in obj)
            //    {
            //        if (item.CardNumber == objCardsDeckViewModel.CardNumber && item.CardType == objCardsDeckViewModel.CardType)
            //        {
            //            isFound = 1;
            //        }
            //    }
            //    if (isFound == 0)
            //    {
            //        CardsJsonFile = CardsJsonFile + "{'CardNumber': '" + objCardsDeckViewModel.CardNumber + "', 'CardType': '" + objCardsDeckViewModel.CardType + "'},";
            //        objFilteredCardsViewModel.CardsCollection.Add(objCardsDeckViewModel);
            //    }
            }
        }
        

        //public  CardsDeckViewModel GenerateCardNumberAndCardType()
        //{
        //    CardsDeckViewModel objCardsDeckViewModel = new CardsDeckViewModel();
        //    Random rnd = new Random();
        //    int card = rnd.Next(1, 14);
        //    objCardsDeckViewModel.CardNumber = Convert.ToString(card);
        //    int cardtypeNumber = rnd.Next(1, 5);
        //    switch (cardtypeNumber)
        //    {
        //        case 1:
        //            objCardsDeckViewModel.CardType = Convert.ToString(CardsTypes.Spade);
        //            break;
        //        case 2:
        //            objCardsDeckViewModel.CardType = Convert.ToString(CardsTypes.Heart);
        //            break;
        //        case 3:
        //            objCardsDeckViewModel.CardType = Convert.ToString(CardsTypes.Club);
        //            break;
        //        case 4:
        //            objCardsDeckViewModel.CardType = Convert.ToString(CardsTypes.Diamond);
        //            break;
        //    }
        //    return objCardsDeckViewModel;
        //}

        
        public class CardsDeckViewModel
        {
            public string CardNumber { get; set; }
            public string CardType { get; set; }
        }

        public enum CardsTypes
        {
            Spade = 1,
            Heart = 2,
            Club = 3,
            Diamond = 4,

        }

    }
