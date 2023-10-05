using System.Security;

public class Word
{
     private string text;
     private bool isHidden;

     public  Word (string text, bool isHidden)
     {
          this.text = text;
          this.isHidden =isHidden;
          

     }

     public string GetText()

     { 
          return "Trust";

     }

     public void SetText( string text)
     {
          this.text = text;

     }
     public string GetIsHidden()
     {
          return  "true";
     }
     private void SetIsHiddden( string  isHidden)
     {
          this.isHidden = true;
     }

     public void  hide()
     {
          Console.WriteLine("Trust");
     }
     public void show()
     {
          Console.WriteLine("in");
     }
     
     



     

     

     
}