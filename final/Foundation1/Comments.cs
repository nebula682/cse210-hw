public class Comments
{
     public string _name;
     public string _commentsText;
     public int _number;

     public void Display()
     {
          Console.WriteLine($"{_name} {_commentsText} {_number}");
     }

}