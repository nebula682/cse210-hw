public class Events
{
     private string _title;
     private string _description;
     private int _date;
     private double _time;
     

     public Events(string title, string description, int date, double time)
     {
          this._title = title;
          this._description = description;
          this._date = date;
          this._time = time;
     }
     public string GetTitle()
     {
          return _title;
     }
     public string GetDescription()
     {
          return _description;
     }

     public int GetDate()
     {
          return _date;
     }
     public double GetTime()
     {
          return _time;
     }

     public string GetSummmary()
     {
          return _title     +    _description   +   _date +     _time;
     }

     
}