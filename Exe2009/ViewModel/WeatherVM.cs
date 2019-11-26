using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Exe2009.Annotations;
using Exe2009.Common;
using Exe2009.Model;


namespace Exe2009.ViewModel
{
    public class WeatherVM : INotifyPropertyChanged
    {
        private Weather _weatherObj;
        private Weather _selectedWeather;

        public Weather WeatherObj
        {
            get { return _weatherObj; }
            set
            {
                _weatherObj = value;
                OnPropertyChanged();
            }
        }
        public List<Weather> Forecast
        {
            get { return forecast; }
            set
            {
                forecast = value;
                OnPropertyChanged();
            }
        }
        public Weather SelectedWeather
        {
            get { return _selectedWeather; }
            set
            {
                _selectedWeather = value;
                OnPropertyChanged();
            }

        }

        public ICommand NextCommand { get; set; }
        public ICommand PreviousCommand { get; set; }
        private int counter = 0;

        public WeatherVM()
        {
            //WeatherObj = new Weather(13, "25%", "Cloudy", 15, 5, 10, "../Assets/partially-cloudy.png");
            WeatherObj = forecast[counter];
            NextCommand= new RelayCommand(HandleNextEvent);
            PreviousCommand= new RelayCommand(HandlePreviousEvent);
        }

        
        public void HandleNextEvent()
        {
            if (counter < forecast.Count-1)
                counter++;
            else counter = 0;
            WeatherObj = forecast[counter];
        }
        public void HandlePreviousEvent()
        {
            if (counter == 0)
                counter= forecast.Count-1;
            else counter--;
            WeatherObj = forecast[counter];
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public static List<Weather> forecast= new List<Weather>()
        {
            new Weather(22,"2%", "Sunny", 30, 20, 26, "/Assets/partially-cloudy.png"),
            new Weather(2,"60%", "Rain", 5, 0, 2, "/Assets/partially-cloudy.png"),
            new Weather(0,"0%", "Snow", 3, 0, 0, "/Assets/partially-cloudy.png"),
            new Weather(30,"3%", "Sunny", 33, 20, 32, "/Assets/partially-cloudy.png"),
            new Weather(15,"90%", "Rain", 20, 6, 13, "/Assets/partially-cloudy.png")

        };
    }
}
