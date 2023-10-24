
public class RunningActivity : Activity
{
     private string _shoeName;
     public RunningActivity( string date, int length, double distance, double speed, double numberOfLaps, string shoeName)
     :base( date, length, distance, speed, numberOfLaps)
     {
          this._shoeName = shoeName;

     }

     
          

     }



