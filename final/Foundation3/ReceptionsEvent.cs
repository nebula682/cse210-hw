public class ReceptionsEvent : Events
{
     private string _emailRsvp;

     public ReceptionsEvent( string title, string description, int date, int time, string _emailRsvp)
     :base(title, description, date, time)
     {
          this._emailRsvp = _emailRsvp;
     }
     public string GetEmail()
     {
          return _emailRsvp;
     }
     public string GetReceptionInformation()
     {
          return     _emailRsvp;
     }

     

     
}

