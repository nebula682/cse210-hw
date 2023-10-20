using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Here is your shipping Label!");
        Product p1 = new Product("Bread","Lobels", 30);
        Console.WriteLine(p1.GetName());
        Console.WriteLine(p1.GetProductID());
        Console.WriteLine(p1.GetQuantity());
        
        Product p2 = new Product("Biscuits","Romany",100);
        Console.WriteLine(p2.GetName());
        Console.WriteLine(p2.GetProductID());
        Console.WriteLine(p2.GetQuantity());
        
        Product p3 = new Product("Clothes","Jeans",800);
        Console.WriteLine(p3.GetName());
        Console.WriteLine(p3.GetProductID());
        Console.WriteLine(p3.GetQuantity());

        Console.WriteLine("Here is your Packing Label");

        Customer c1 = new Customer("Malcolm", "Berverly Hills");
        Console.WriteLine(c1.GetName());
        Console.WriteLine(c1.GetAddress());

        List <Product> products = new List<Product>();
        products.Add(p1);
        products.Add(p2);
        products.Add(p3);

        foreach(Product p in products)
        {
            Console.WriteLine(p1.GetProductID());
            Console.WriteLine(p2.GetName());
            Console.WriteLine(p3.GetQuantity());
        }



    }
}
        
        
        







        
        

        
    
