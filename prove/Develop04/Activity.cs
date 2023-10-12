 public class Activity
 {
     private string _name;
     private string _description;
     private int _duration;

     public Activity(string name, string description, int duration)
     {
          _name = name;
          _description = description;
          _duration = duration;
     }

     public string DisplayWelcomeMessage()
     {
          return "Welcome to the Activity.";
          
     }

     public string DisplayStartingMessage()

     {
          
          return("This Activity will help you with being more mindful in your circumstances.");
          

     }

          
               

          
     public string DisplayEndingMessage()
     {
          return("Thank you for taking time to participate in this activity!");
          

     }
     public void  ShowSpinner(int seconds)
     {

          
     List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(7);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b  \b");

            i ++;

            if(i >= animationStrings.Count)
            {
                i = 0;
            }
        }

        





        
    }
}


     
 

     


