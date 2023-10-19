using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine(" Welcome to the Eternal Quest Game, you have 0 points!");

        Console.WriteLine("Please select one of the following options from the menu!");
        Thread.Sleep(2000);

        Console.WriteLine("1. Create new Goal.");
        Console.WriteLine("2. List your goals.");
        Console.WriteLine("3. Save your goals.");
        Console.WriteLine("5. Record an event.");
        Console.WriteLine("6. Quit.");

        Console.WriteLine("  Please select a choice from the menu:");

        Thread.Sleep(2000);

        

        Console.ReadLine();

        Console.WriteLine("  The type of goals are..");
        Thread.Sleep(2000);

        Console.WriteLine("Simple goal.");
        Thread.Sleep(2000);
        Console.WriteLine("Eternal goal.");
        Thread.Sleep(2000);
        Console.WriteLine("Checklist goal.");

        Console.WriteLine("You ready..?");
        
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
            Thread.Sleep(500);
            Console.Write("\b  \b");

            i ++;

            if(i >= animationStrings.Count)
            {
                i = 0;
            }
        }

            Thread.Sleep(2000);
            Console.WriteLine("Which type of goal would you like to create?");
            Thread.Sleep(2000);
            Console.ReadLine();

            Console.WriteLine(" What is the name of your goal?");
            Thread.Sleep(2000);
            Console.ReadLine();

            Console.WriteLine("What is the short description of it?");
            Thread.Sleep(2000);
            Console.ReadLine();

            Console.WriteLine("How many points do you want associated with this goal?");
            Thread.Sleep(2000);
            Console.ReadLine();

            Console.WriteLine("Way to go, now let's try it again.");


            CheckListGoal Cgoal = new CheckListGoal();
            Cgoal.SetAmountCompleted(6);
            Cgoal.SetName("CheckList");
            Cgoal.SetDescription("A good game");
            Cgoal.SetPoints(6);
            Cgoal.SetTarget(5);

            SimpleGoal Sgoal = new SimpleGoal();
            Sgoal.SetName("Simple Goal");
            Sgoal.SetPoints(6);
            Sgoal.SetDescription("This is a valid game.");

            // for exceeeidng the requirements, oi insereted some spinners and other words of my own to  make the game more interesting

        
            
        }







    }





            
            

            
            
            
             








        
        

