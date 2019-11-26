using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe2009.Model
{
    public class Weather
    {
        public double Temperature { get; set; }
        public string Precipitation { get; set; }
        public string WeatherCondition { get; set; }
        public int Highest { get; set; }
        public int Lowest { get; set; }
        public int Feeling { get; set; }
        public string ImageLink { get; set; }

        public Weather(double temperature, string precipitation, string weatherCondition, int highest, int lowest, int feeling, string imagelink)
        {
            Temperature = temperature;
            Precipitation = precipitation;
            WeatherCondition = weatherCondition;
            Highest = highest;
            Lowest = lowest;
            Feeling = feeling;
            ImageLink = imagelink;
        }
     
        public override string ToString()
        {
            return $"{nameof(Temperature)}: {Temperature}, {nameof(Precipitation)}: {Precipitation}, {nameof(WeatherCondition)}: {WeatherCondition}, {nameof(Highest)}: {Highest}, {nameof(Lowest)}: {Lowest}, {nameof(Feeling)}: {Feeling}";
        }
    }
}
