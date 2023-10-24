
public class SwimmingActivity : Activity
{
     private string _purpose;
     public SwimmingActivity( string date, int length, double distance, double speed, double numberOfLaps, string purpose)
     :base(date, length, distance, speed, numberOfLaps)
     {
          this._purpose = purpose;

     }
}

