using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Menu Options");

        Console.WriteLine("Please select one of the following options!");

        Console.WriteLine("1. Start breathing activity.");
        Console.WriteLine("2. Start Reflecting Activity.");
        Console.WriteLine("3. Start Listing Activity.");
        Console.WriteLine("5. Quit.");

        Console.WriteLine(" Please select a choice from the menu:");

        Thread.Sleep(2000);

        Console.WriteLine("Ready..");

        Console.ReadLine();

        Console.WriteLine("Welcome to the Activity");
        Console.Write("3");
        Thread.Sleep(2000);
        Console.Write("2");
        Thread.Sleep(2000);
        Console.WriteLine("1");

        Console.WriteLine("Lets Go!!");


        

        Activity a1 = new Activity("Mindfulness","This activity will help you with being more mindfull in your life.",20);
        
        Console.WriteLine(a1.DisplayWelcomeMessage());
        Console.WriteLine(a1.DisplayStartingMessage());
        Console.ReadLine();
        Console.WriteLine(a1.DisplayEndingMessage());

        // creating a spinner
        
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

        


        





        




        

        List<string> displayPrompts = new List<string>();
        displayPrompts.Add("Think of a time when you stood up fpr someone else.");
        displayPrompts.Add("Think of a time when you did something really difficult.");
        displayPrompts.Add("Think of a time when you helped someone in need.");
        displayPrompts.Add("Think of a time when you did something truly selfless.");
        

        List<string> displayQuestion = new List<string>();
        displayQuestion.Add("Why was this experience meaningful for you?");
        displayQuestion.Add("Have you ever done something like this before?");
        displayQuestion.Add("How did you get started");
        displayQuestion.Add("What could you learn from this experience, that applies to other situations?");
        displayQuestion.Add("WhaT did you learn about yourdelf through this experience?");
        displayQuestion.Add("What is your favorite thing about this experience?");













        
        
        List<String> randomPrompts = new List<string>();
        randomPrompts.Add("Who are the people that you appreciate?");
        randomPrompts.Add("What are the personal strengths of yours?");
        randomPrompts.Add("Who are the people that you have helped this week?");
        randomPrompts.Add("Who are some of your persona heroes?");
        randomPrompts.Add("When have you felt the Holy Gthost this month?");

        // to exceed core requirements I tried to use pausing , to show a spinner and to provide a manu. I also came up with my own words , sucha s Lets Go and Ready..







        

        
    }
}