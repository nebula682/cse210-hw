using System.ComponentModel;

public class ReflectingActivity : Activity
{
     private List<string> _prompts;
     private List<string> _questions;
     public ReflectingActivity(string name,string description,int duration, int count,List<string> prompts, List<string> questions)
     :base(name, description, duration)
     {
          _prompts = prompts;
          _questions = questions;

          

     }

     public string ReflectionActivity()
     {
          return "Welcome to the Reflecting Activity!";
     }
      public void Run()
      {

      }

      public string GetRandomPrompt()
      {
          return "_prompts";
      }

      public string GetRandomQuestion()
      {
          return " ";
      }

      public void DisplayPrompt()
      {

      }
      public void DisplayQuestion()
      {

      }


}