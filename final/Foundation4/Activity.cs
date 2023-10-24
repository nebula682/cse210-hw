public abstract class Activity
{
     private string _date;
     private int _length;
     private double _distance;
     private double _speed;

     private double _numberOfLaps;

     public Activity( string date, int length, double distance, double speed, double numberOfLaps)
     {
          this._date = date;
          this._length = length;
          this._distance = distance;
          this._speed = speed;
          this._numberOfLaps = numberOfLaps;
     }
     public string GetDate()
     {
          return _date;
     }
     public void SetDate( string date)
     {
          _date = date;
     }
     public int GetLength()
     {
          return _length;
     }
     public void SetLength( int length)
     {
          _length = length;
     }
     public double GetDistance()
     {
          return _distance;
     }
     public void SetDistance(double distance)
     {
          _distance = distance;
     }
     public double GetSpeed()
     {
          return _speed;
     }
     public void SetSpeed(double speed)
     {
          _speed = speed;
     }
     public double GetNumberOfLaps()
     {
          return _numberOfLaps;
     }
     public void SetNumbberOfLaps(double numberOfLaps)
     {
          _numberOfLaps = numberOfLaps;
     }
     
     



}

