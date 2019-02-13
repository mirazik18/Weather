using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public class Location
    {

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("region")]
        public string region { get; set; }

        [JsonProperty("country")]
        public string country { get; set; }

        [JsonProperty("lat")]
        public double lat { get; set; }

        [JsonProperty("lon")]
        public double lon { get; set; }

        [JsonProperty("tz_id")]
        public string tz_id { get; set; }

        [JsonProperty("localtime_epoch")]
        public int localtime_epoch { get; set; }

        [JsonProperty("localtime")]
        public string localtime { get; set; }
    }

    public class Condition
    {

        [JsonProperty("text")]
        public string text { get; set; }

        [JsonProperty("icon")]
        public string icon { get; set; }

        [JsonProperty("code")]
        public int code { get; set; }
    }

    public class Current
    {

        [JsonProperty("last_updated_epoch")]
        public int last_updated_epoch { get; set; }

        [JsonProperty("last_updated")]
        public string last_updated { get; set; }

        [JsonProperty("temp_c")]
        public double temp_c { get; set; }

        [JsonProperty("temp_f")]
        public double temp_f { get; set; }

        [JsonProperty("is_day")]
        public int is_day { get; set; }

        [JsonProperty("condition")]
        public Condition condition { get; set; }

        [JsonProperty("wind_mph")]
        public double wind_mph { get; set; }

        [JsonProperty("wind_kph")]
        public double wind_kph { get; set; }

        [JsonProperty("wind_degree")]
        public int wind_degree { get; set; }

        [JsonProperty("wind_dir")]
        public string wind_dir { get; set; }

        [JsonProperty("pressure_mb")]
        public double pressure_mb { get; set; }

        [JsonProperty("pressure_in")]
        public double pressure_in { get; set; }

        [JsonProperty("precip_mm")]
        public double precip_mm { get; set; }

        [JsonProperty("precip_in")]
        public double precip_in { get; set; }

        [JsonProperty("humidity")]
        public int humidity { get; set; }

        [JsonProperty("cloud")]
        public int cloud { get; set; }

        [JsonProperty("feelslike_c")]
        public double feelslike_c { get; set; }

        [JsonProperty("feelslike_f")]
        public double feelslike_f { get; set; }

        [JsonProperty("vis_km")]
        public double vis_km { get; set; }

        [JsonProperty("vis_miles")]
        public double vis_miles { get; set; }

        [JsonProperty("uv")]
        public double uv { get; set; }
    }

    public class Day
    {

        [JsonProperty("maxtemp_c")]
        public double maxtemp_c { get; set; }

        [JsonProperty("maxtemp_f")]
        public double maxtemp_f { get; set; }

        [JsonProperty("mintemp_c")]
        public double mintemp_c { get; set; }

        [JsonProperty("mintemp_f")]
        public double mintemp_f { get; set; }

        [JsonProperty("avgtemp_c")]
        public double avgtemp_c { get; set; }

        [JsonProperty("avgtemp_f")]
        public double avgtemp_f { get; set; }

        [JsonProperty("maxwind_mph")]
        public double maxwind_mph { get; set; }

        [JsonProperty("maxwind_kph")]
        public double maxwind_kph { get; set; }

        [JsonProperty("totalprecip_mm")]
        public double totalprecip_mm { get; set; }

        [JsonProperty("totalprecip_in")]
        public double totalprecip_in { get; set; }

        [JsonProperty("avgvis_km")]
        public double avgvis_km { get; set; }

        [JsonProperty("avgvis_miles")]
        public double avgvis_miles { get; set; }

        [JsonProperty("avghumidity")]
        public double avghumidity { get; set; }

        [JsonProperty("condition")]
        public Condition condition { get; set; }

        [JsonProperty("uv")]
        public double Uv { get; set; }
    }

    public class Astro
    {

        [JsonProperty("sunrise")]
        public string sunrise { get; set; }

        [JsonProperty("sunset")]
        public string sunset { get; set; }

        [JsonProperty("moonrise")]
        public string moonrise { get; set; }

        [JsonProperty("moonset")]
        public string moonset { get; set; }
    }

    public class Forecastday
    {

        [JsonProperty("date")]
        public string date { get; set; }

        [JsonProperty("date_epoch")]
        public int date_epoch { get; set; }

        [JsonProperty("day")]
        public Day day { get; set; }

        [JsonProperty("astro")]
        public Astro astro { get; set; }
    }

    public class Forecast
    {

        [JsonProperty("forecastday")]
        public IList<Forecastday> forecastday { get; set; }
    }

    public class Example
    {

        [JsonProperty("location")]
        public Location location { get; set; }

        [JsonProperty("current")]
        public Current current { get; set; }

        [JsonProperty("forecast")]
        public Forecast forecast { get; set; }
    }
}
