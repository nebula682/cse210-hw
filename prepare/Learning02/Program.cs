using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using System.Xml.Serialization;

class Program
{
    static void Main (String[]args)
    {
        //User menu

        Console.Write("Welcome to the Journal Program, ");

        Console.WriteLine("please select one of the following options!");

        Console.WriteLine("1-Write");
        Console.WriteLine("2-Display");
        Console.WriteLine("3-Save");
        Console.WriteLine("4-Load");
        Console.WriteLine("5-Quit");

        Console.Write("What would you like to do today?");

        Console.ReadLine();

        //Getting the current date and time

        
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Console.WriteLine(theCurrentTime);




        //List of entries
        
        Entry E1 = new Entry ();
        E1._date ="";
        E1._promptText ="What was the strongest emotion you felt today?";
        E1._entryText ="";
        
        Entry E2 = new Entry ();
        E2._date ="";
        E2._promptText ="What do you wish you could change?";
        E2._entryText ="";
        
        Entry E3 = new Entry ();
        E3._date ="";
        E3._promptText ="How did I see the hand of the Lord in my life today?";
        E3._entryText ="";
        
        Entry E4 = new Entry ();
        E4._date ="";
        E4._promptText ="Who was the most interesting person I interacted with today";
        E4._entryText ="";
        
        Entry E5 = new Entry ();
        E5._date ="";
        E5._promptText ="If I had one thing I could do over today, what would it be?";
        E5._entryText ="";

        Entry E6 = new Entry ();
        E6._date ="";
        E6._promptText ="What made you sad today?";
        E6._entryText ="";
        
        List <Entry> entries = new List<Entry>();
        entries.Add(E1);
        entries.Add(E2);
        entries.Add(E3);
        entries.Add(E4);
        entries.Add(E5);
        entries.Add(E6);

    


        foreach (Entry e in entries)

        {
            Console.WriteLine(e._promptText);
        }

        //Saving to a file

        SaveToFile(entries);

        List<Entry> newEntries = LoadFromFile();
        foreach (Entry e in newEntries)
        {
            Console.WriteLine(e._promptText);
        }

}
    public static void SaveToFile (List<Entry> entries)
    {
        string filename = "entries.txt";

        using(StreamWriter outputFile = new StreamWriter(filename))
        {
            
            foreach (Entry e in entries)

            {
                outputFile.WriteLine($"{e._promptText}~{e._entryText}~ {e._date}");
            }


        }
    }

    //Loading from a file

    public static List<Entry>LoadFromFile()
    {
        Console.WriteLine("Loading list from file");
        List<Entry> entries = new List <Entry>();
        string filename = "entries.txt";

        string[] lines = System.IO.File. ReadAllLines(filename);

        foreach(string line in lines)
        {
            //Console.WriteLine(line);
            //Line will have something like this date~what what was your fav thing to do~ entry

            string[] parts = line.Split("~");
            //parts[0]~date
            //parts[1]~prompttext
            //parts[2]~entrytext

            Entry newEntry = new Entry();
            newEntry._date =parts[0];
            newEntry._promptText= parts[1];
            newEntry._entryText =parts[2];

            entries.Add(newEntry);
        }

        return entries;
    }

}


        
        




    
    
    
    

        
            
            
            
            
            
            
            
            



        
            
        





    
    

    
        


    

         


    



    
        

    
    
        
    



    
 
    
