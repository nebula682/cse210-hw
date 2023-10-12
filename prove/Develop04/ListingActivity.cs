using System.Reflection.Metadata.Ecma335;

public class ListingActivity : Activity
{
     private int _count;
     private List<string> _prompts;

     public  ListingActivity(string name, string description, int duration, int count, List<string> prompts) 
      :base(name, description, duration)
     {
          _count = count;
          _prompts = prompts;
          
     }

     public string GetListingActivity()
     {
          return "Welcome to the Listing Activity";
     }

     public void Run()
     {
          

     }
     public void GetRandomPrompts()
     {
          
          
          
          
          

     }
     public string GetListFromUser()

     {
          return "";
     


     
      
      


     }
     
} 