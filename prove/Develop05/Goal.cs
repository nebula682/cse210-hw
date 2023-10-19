using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

public   class  Goal
{
     private string _name;
     private string _description;
     private int _points;

     public string GetName()
     {
          return _name;

     }
     public void SetName( string name)
     {
          _name = name;
     }
     public string GetDescription()
     {
          return _description;
     }
     public void SetDescription(string description)
     {
          _description = description;
     }
     public int GetPoints()
     {
           return _points;


     }
     public void SetPoints( int points)
     {
          _points = points;
     }
     
     

     }
     

     

     
     
