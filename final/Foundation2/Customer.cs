using System.Diagnostics.Contracts;

public class Customer
{
     private string _name;
     private string _address;

     public Customer( string name, string address)
     {
          this._name = name;
          this._address = address;
     }
     public string GetName()
     {
          return _name;
     }
     public void SetName(string name)
     {
          this._name = name;
     }
     public string GetAddress()
     {

          return _address;
     }
     
     
     



     
    public void SetAdddress(string address)
     {
          this._address = address;
     }
}