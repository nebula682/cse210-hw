public class Video
{
     public string _videoTitle;
     public string _videoAuthor;
     public int _videoLength;

     public void Display()
     {
          Console.WriteLine($"{_videoTitle} {_videoAuthor} {_videoLength}");
     }
}