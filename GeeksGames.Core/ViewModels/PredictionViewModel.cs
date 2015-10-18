using Cirrious.MvvmCross.ViewModels;
using GeeksGames.Core.ServiceModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace GeeksGames.Core.ViewModels
{
    public class PredictionViewModel : MvxViewModel
    {
        public CardDistribution GetCards { get; set; }
        public CardDistribution CardsToShow { get; set; }

        //public PredictionViewModel()
        //{
        //    GetAllCardForDistribution();
        //}

        public async void GetAllCardForDistribution()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://192.168.1.52/");
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("PredictionServices/PredictionServices/Help/cardsdistribution");
                if (response.IsSuccessStatusCode)
                {
                    string get = await response.Content.ReadAsStringAsync();
                    GetCards = Newtonsoft.Json.JsonConvert.DeserializeObject<CardDistribution>(get);
                    //GetCards = (CardDistribution)await GetResponseForJSON(get);
                    if (GetCards != null)
                    {
                        int i = GetCards.CardsSheet.Count;
                        CardsToShow = new CardDistribution();
                        CardsToShow.CardsSheet = new List<CardsSheet>();
                        for (int j = i / 2; j < i; j++)
                        {
                            CardsToShow.CardsSheet.Add(GetCards.CardsSheet[j]);
                        }
                    }
                }
                else
                {
                    GetCards = new CardDistribution();
                }


            }

        }

    }
}
