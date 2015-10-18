using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace GeeksGames.win.Convertor
{
    public class CardTypeToImageConvertor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string imageString = "/Assets/Images/Spade.png";
            if (value != null)
            {
                
                if (value.ToString() == "Heart")
                {
                    imageString = "/Assets/Images/Heart.png";
                }
                else if (value.ToString() == "Spade")
                {
                    imageString = "/Assets/Images/Spade.png";
                }
                else if (value.ToString() == "Club")
                {
                    imageString = "/Assets/Images/Club.png";
                }
                else if (value.ToString() == "Diamond")
                {
                    imageString = "/Assets/Images/Diamond.png";
                }
                return imageString;
            }
            return imageString;
        }
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return "";
        }
    }
}
