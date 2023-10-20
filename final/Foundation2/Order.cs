public class Order
{
     private List<Product> _products;
     private string _customer;

     public Order(List<Product> products,string customer)
     {
          this._products =products;
          this._customer = customer;

     }
     public List<Product> GetProducts()
     {
          return _products;

     }
     public void SetListProduct(string products)
     {

     }

}