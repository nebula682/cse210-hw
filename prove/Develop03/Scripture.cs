public class Scripture
{
     private string _reference;
     private string _words;

     public Scripture( string reference, string text)

     {
          this._reference = reference;
          this._words = text;
     }

     public string GetReference()
     {
          return "Proverbs 3:5-6, Trust in the Lord with all thine heart and lean not unto thine own understanding, In all thy ways acknowleddge him and he shall direct thy paths.";
     }
     public void SetReference( string reference)
     {
          this._reference = reference;

     }

     public string GetWords()
     {
          return"Trust in the Lord with all thine heart and lean not unto thine own understanding";
     }
     public void SetWords( string words)
     {
          this._words = words;
     }
     public void HideRandomWords()
     {
          Console.WriteLine("-------");

     }
     
     
     

     
     
}