public class LecturesEvent : Events
{
     private string _speakerName;
     private int _capacity;

     public LecturesEvent(string title, string description, int date, int time, string speakerName, int capacity)
     :base(title, description, date, time)
     {
          this._speakerName = speakerName;
          this._capacity = capacity;
     }
     public string GetSpeakerName()
     {
          return _speakerName;
     }
     public int GetCapacity()
     {
          return _capacity;
     }

     public string GetLectureInformation()
     {
          return _speakerName +     _capacity;
     }
}