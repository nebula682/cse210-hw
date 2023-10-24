public class OutdoorGatheringsEvents : Events
{
     private string _weatherForecast;

     public OutdoorGatheringsEvents( string title, string description, int date, int time, string  weatherForecast)
     :base(title, description, date, time)
     {
          this._weatherForecast = weatherForecast;
     }
     public string GetWeatherForecast()
     {
          return _weatherForecast;
     }

     public string GetWeatherInformation()
     {
          return     _weatherForecast;
     }
}