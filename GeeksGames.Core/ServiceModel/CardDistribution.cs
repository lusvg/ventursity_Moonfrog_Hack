using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksGames.Core.ServiceModel
{
    public class CardDistribution
    {
        public List<CardsSheet> CardsSheet { get; set; }
    }
    public class CardsSheet
    {
        public string CardNumber { get; set; }
        public string CardType { get; set; }
    }
   
       
}
