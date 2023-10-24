public class CyclingActivity : Activity

{
     private int _bikeNumber;
     public CyclingActivity ( string date, int length, double distance, double speed, double numberOfLaps, int bikeNumber)
     :base(date, length,distance,speed,numberOfLaps)
     {
          this._bikeNumber = bikeNumber;

     }
}