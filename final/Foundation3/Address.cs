public class Address
{
     private string _streetName;
     private string _CityName;

     public Address(string streetName, string CityName)
     {
          this._streetName = streetName;
          this._CityName = CityName;
     }
     public string GetStreetName()
     {
          return _streetName;
     }
     public string GetCityName()
     {
          return _CityName;
     }
     public string GetAddress()

     {
          return _streetName +      _CityName;

     }


}