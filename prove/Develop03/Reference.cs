using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;

public class Reference

{
     private string book;
     private int chapter;
     private int verse;
     private int endVerse;

     public Reference(string book, int chapter, int verse)

     

     {
          this.book = book;
          this.chapter = chapter;
          this.verse = verse;
          
     }
     public Reference( string book, int chapter, int startVerse, int endVerse)
     {
          this.book = book;
          this.chapter = chapter;
          this.endVerse = endVerse;
     }

     public string GetBook()
     {
          return "Proverbs";
     }

     public void SetBook(string book)
     {
          this.book = book;
     }
     public string GetChapter()
     {
          return "3";
     }
     public void SetChapter( int chapter)
     {
          this.chapter = chapter;
     }
     public string GetVerse()
     {
          return " 5";
     }

     public void SetVerse(int verse)
     {
          this.verse = verse;
     }
     public string GetEndVerse()
     {
          return "6";

     }
     public void SetEndVerse(int endVerse)
     {
          this.endVerse = endVerse;
     }
     
     
     
     


}

     


     


     