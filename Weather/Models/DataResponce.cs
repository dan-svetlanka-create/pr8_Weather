
namespace Weather.Models
{
    public class DataResponce
    {
        public List<Forecast> forecasts { get; set; }
    }

    public class Forecast
    {
        public DateTime date { get; set; }
        public List<Hour> hours { get; set; }
    }

    public class Hour
    {
        public string hour { get; set; }
        public string condition { get; set; }
        public int humidity { get; set; }
        public int prec_type { get; set; }
        public int temp { get; set; }
        public int pressure_mm { get; set; }

        public string ToCondition()
        {
            return condition switch
            {
                "clear" => "ясно",
                "partly-cloudy" => "малооблачно",
                "cloudy" => "облачно с прояснениями",
                "overcast" => "пасмурно",
                "light-rain" => "небольшой дождь",
                "rain" => "дождь",
                "heavy-rain" => "сильный дождь",
                "showers" => "ливень",
                "wet-snow" => "дождь со снегом",
                "light-snow" => "небольшой снег",
                "snow" => "снег",
                "snow-showers" => "снегопад",
                "hail" => "град",
                "thundershtorm" => "гроза",
                "thunderstorm-with-rain" => "дождь с грозой",
                "thunderstorm-with-hail" => "гроза с градом",
                _ => condition
            };
        }

        public string ToPressureString()
        {
            return $"{pressure_mm} мм рт.ст.";
        }

        public string GetWeatherIcon()
        {
            return condition switch
            {
                "clear" => "☀️",
                "partly-cloudy" => "⛅",
                "cloudy" => "☁️",
                "overcast" => "☁️",
                "light-rain" => "🌧️",
                "rain" => "🌧️",
                "heavy-rain" => "⛈️",
                "showers" => "⛈️",
                "wet-snow" => "🌨️",
                "light-snow" => "❄️",
                "snow" => "❄️",
                "snow-showers" => "❄️",
                "hail" => "🌨️",
                "thundershtorm" => "⛈️",
                "thunderstorm-with-rain" => "⛈️",
                "thunderstorm-with-hail" => "⛈️",
                _ => "🌈"
            };
        }

        public string ToPrecType()
        {
            return prec_type switch
            {
                0 => "без осадков",
                1 => "дождь",
                2 => "дождь со снегом",
                3 => "снег",
                _ => "неизвестно"
            };
        }
    }


}