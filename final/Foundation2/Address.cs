public class Address
{
     private string _street;
     private string _city;
     private string _province;
     private string _country;

     public Address( string street, string city, string province, string country)
     {
          this._street = street;
          this._city = city;
          this._province = province;
          this._country = country;
     }
     public string GetStreet()

     {
          return _street;

     }
     public void SetStreet(string street)
     {
          this._street = street;
     } public string GetCity()
     {
          return _city;
     }
     public void SetCity(string city)
     {
          this._city = city;
     }
     public string GetProvince()
     {
          return _province;
     }
     public void SetProvince( string province)
     {
          this._province = province;
     }

     public string GetCountry()
     {
          return _country;
     }
     public void SetCountry(string country)
     {
          this._country = country;
     }

     

}