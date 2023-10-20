using System;
using System.Runtime.Intrinsics.Arm;

class Program
{



    static void Main(string[] args)
    {
        Video v1 = new Video();
        v1._videoTitle ="Malcolm piano";
        v1._videoAuthor = "Sibahle";
        v1._videoLength =90;

        Thread.Sleep(2000);
        
        Console.WriteLine(v1._videoTitle);
        Console.WriteLine(v1._videoAuthor);
        Console.WriteLine(v1._videoLength);

        Thread.Sleep(3000);




        
        Video v2 = new Video();
        v2._videoTitle ="Pentatonix";
        v2._videoAuthor = "Hallelujah";
        v2._videoLength =340;

        Thread.Sleep(2000);
        
        Console.WriteLine(v2._videoTitle);
        Console.WriteLine(v2._videoAuthor);
        Console.WriteLine(v2._videoLength); 

        Thread.Sleep(3000);




        
        Video v3 = new Video();
        v3._videoTitle ="John Legend.";
        v3._videoAuthor = "All of me!";
        v3._videoLength =180;

        Thread.Sleep(2000);

        Console.WriteLine(v3._videoTitle);
        Console.WriteLine(v3._videoAuthor);
        Console.WriteLine(v3._videoLength);

        Thread.Sleep(3000);

        Console.WriteLine("Now Lets look at the comments of the video!");

        
        Comments c1 = new Comments();
        c1._name = "Malcolm.";
        c1._commentsText ="I really enjoyed this video!";
        c1._number = 400;

        Thread.Sleep(2000);
        
        Console.WriteLine(c1._name);
        Console.WriteLine(c1._commentsText);
        Console.WriteLine(c1._number);

        Thread.Sleep(3000);
        
        
        Comments c2 = new Comments();
        c2._name = "Eric.";
        c2._commentsText ="This group is so good, they should be winning grammys.";
        c2._number = 700;

        Thread.Sleep(2000);
        
        Console.WriteLine(c2._name);
        Console.WriteLine(c2._commentsText);
        Console.WriteLine(c2._number);

        Thread.Sleep(3000);


        Comments c3 = new Comments();
        c3._name = "John.";
        c3._commentsText ="What an amazing performance!";
        c3._number =288 ;


        Console.WriteLine(c3._name);
        Console.WriteLine(c3._commentsText);
        Console.WriteLine(c3._number);


       
       















    }
}