public class Product
{
     private string _name;
     private string _productID;
     private int _quantity;

     public Product(string name, string productID, int quantity)
     {
          this._name = name;
          this._productID = productID;
          this._quantity = quantity;
     }
     public string GetName()
     {
          return _name;
     }
     public void SetName(string name)
     {
          this._name = name;
     }
     public string GetProductID()
     {
          return _productID;
     }
     public void SetProductID( string productID)
     {
          this._productID = productID;
     }
     public int GetQuantity()
     {
          return _quantity;

     }
     public void SetQuantity( int quantity)
     {
          this._quantity = quantity;
     }

     //I hope I submiited this the right way. I am don with foundatuion 1, but I am still working on foundation 2, I feel like there are certain things I need to polish to make sure the program works according to specifications. I might have submitted these two projects together, I hope it works if it doesnt  please let me know how to submitt the right way. I did not know how to seperate these two in my visual studio.
}