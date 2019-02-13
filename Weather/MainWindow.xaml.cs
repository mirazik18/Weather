using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Weather
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void city_MouseLeave(object sender, MouseEventArgs e)
        {
            Example example = new Example();
            using (var client = new WebClient())
            {

                string url = " http://api.apixu.com/v1/forecast.json?key=9c045e38b5e44c33934151952191102&q=" + city.Text + "&days=7";
                example = JsonConvert.DeserializeObject<Example>(client.DownloadString(url));
            }
            //for (int i = 0; i < example.forecast.forecastday.Count(); i++)
            //{
            //    wind1.Content = "Скорость ветра:" + example.forecast.forecastday[i].
            //}
            //wind1.Content = "Скорость ветра: " + example.forecast.forecastday.date + " м/c";

            //humidity1.Content = "Влажность: " + example.main.humidity;
            //label1.Content = "Прогноз погоды в " + city.Text + " на 5 дней";
            whichCity.Content = "Прогноз погоды в " + city.Text+" на неделю";

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("http:" + example.forecast.forecastday[0].day.condition.icon);
            image.EndInit();
            Image1.Source = image;
            wind1.Content = "Скорость ветра: " + example.forecast.forecastday[0].day.maxwind_kph+"км/ч";
            humidity1.Content = "Влажность: " + example.forecast.forecastday[0].day.avghumidity+"%";
            temperatureMorning1.Content = "Температура утром: " + example.forecast.forecastday[0].day.mintemp_c+ "°C";
            temperatureNight1.Content = "Температура ночью: " + example.forecast.forecastday[0].day.maxtemp_c + "°C";
            precip1.Content = "Осадки: " + example.forecast.forecastday[0].day.totalprecip_mm + "мм";
            day1.Content = example.forecast.forecastday[0].date;

            BitmapImage image2 = new BitmapImage();
            image2.BeginInit();
            image2.UriSource = new Uri("http:" + example.forecast.forecastday[1].day.condition.icon);
            image2.EndInit();
            Image2.Source = image2;
            wind2.Content = "Скорость ветра: " + example.forecast.forecastday[1].day.maxwind_kph + "км/ч";
            humidity2.Content = "Влажность: " + example.forecast.forecastday[1].day.avghumidity + "%";
            temperatureMorning2.Content = "Температура утром: " + example.forecast.forecastday[1].day.mintemp_c + "°C";
            temperatureNight2.Content = "Температура ночью: " + example.forecast.forecastday[1].day.maxtemp_c + "°C";
            precip2.Content = "Осадки: " + example.forecast.forecastday[1].day.totalprecip_mm + "мм";
            day2.Content = example.forecast.forecastday[1].date;

            BitmapImage image3 = new BitmapImage();
            image3.BeginInit();
            image3.UriSource = new Uri("http:" + example.forecast.forecastday[2].day.condition.icon);
            image3.EndInit();
            Image3.Source = image3;
            wind3.Content = "Скорость ветра: " + example.forecast.forecastday[2].day.maxwind_kph + "км/ч";
            humidity3.Content = "Влажность: " + example.forecast.forecastday[2].day.avghumidity + "%";
            temperatureMorning3.Content = "Температура утром: " + example.forecast.forecastday[2].day.mintemp_c + "°C";
            temperatureNight3.Content = "Температура ночью: " + example.forecast.forecastday[2].day.maxtemp_c + "°C";
            precip3.Content = "Осадки: " + example.forecast.forecastday[2].day.totalprecip_mm + "мм";
            day3.Content = example.forecast.forecastday[2].date;

            BitmapImage image4 = new BitmapImage();
            image4.BeginInit();
            image4.UriSource = new Uri("http:" + example.forecast.forecastday[3].day.condition.icon);
            image4.EndInit();
            Image4.Source = image4;
            wind4.Content = "Скорость ветра: " + example.forecast.forecastday[3].day.maxwind_kph + "км/ч";
            humidity4.Content = "Влажность: " + example.forecast.forecastday[3].day.avghumidity + "%";
            temperatureMorning4.Content = "Температура утром: " + example.forecast.forecastday[3].day.mintemp_c + "°C";
            temperatureNight4.Content = "Температура ночью: " + example.forecast.forecastday[3].day.maxtemp_c + "°C";
            precip4.Content = "Осадки: " + example.forecast.forecastday[3].day.totalprecip_mm + "мм";
            day4.Content = example.forecast.forecastday[3].date;

            BitmapImage image5 = new BitmapImage();
            image5.BeginInit();
            image5.UriSource = new Uri("http:" + example.forecast.forecastday[4].day.condition.icon);
            image5.EndInit();
            Image5.Source = image5;
            wind5.Content = "Скорость ветра: " + example.forecast.forecastday[4].day.maxwind_kph + "км/ч";
            humidity5.Content = "Влажность: " + example.forecast.forecastday[4].day.avghumidity + "%";
            temperatureMorning5.Content = "Температура утром: " + example.forecast.forecastday[4].day.mintemp_c + "°C";
            temperatureNight5.Content = "Температура ночью: " + example.forecast.forecastday[4].day.maxtemp_c + "°C";
            precip5.Content = "Осадки: " + example.forecast.forecastday[4].day.totalprecip_mm + "мм";
            day5.Content = example.forecast.forecastday[4].date;

            BitmapImage image6 = new BitmapImage();
            image6.BeginInit();
            image6.UriSource = new Uri("http:" + example.forecast.forecastday[5].day.condition.icon);
            image6.EndInit();
            Image6.Source = image6;
            wind6.Content = "Скорость ветра: " + example.forecast.forecastday[5].day.maxwind_kph + "км/ч";
            humidity6.Content = "Влажность: " + example.forecast.forecastday[5].day.avghumidity + "%";
            temperatureMorning6.Content = "Температура утром: " + example.forecast.forecastday[5].day.mintemp_c + "°C";
            temperatureNight6.Content = "Температура ночью: " + example.forecast.forecastday[5].day.maxtemp_c + "°C";
            precip6.Content = "Осадки: " + example.forecast.forecastday[5].day.totalprecip_mm + "мм";
            day6.Content = example.forecast.forecastday[5].date;
        }

        private void city_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            var cities = AllCity.GetCity();
            string query = (sender as TextBox).Text;

            hintCities.Children.Clear();

            foreach (var obj in cities)
            {
                if (obj.ToLower().StartsWith(query.ToLower()))
                {
                    addItem(obj);
                
                }
            }
        }
        private void addItem(string text)
        {
          

            TextBlock block = new TextBlock();

            block.Text = text;

            block.Margin = new Thickness(2, 3, 2, 3);
            block.Cursor = Cursors.Hand;

            block.MouseLeftButtonUp += (sender, e) =>
            {
                city.Text = (sender as TextBlock).Text;
                hintCities.Children.Clear();
            };

            block.MouseEnter += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.MediumPurple;
            };

            block.MouseLeave += (sender, e) =>
            {
                TextBlock b = sender as TextBlock;
                b.Background = Brushes.Transparent;
            };

            hintCities.Children.Add(block);
        }

        private void CitySearch_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            city.Clear();
        }
    }
}
