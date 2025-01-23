using System.Text.Json;

namespace ProductenLaden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }
        void Run()
        {
            string text = File.ReadAllText("Product.json");
            string text2 = File.ReadAllText("products2.json");
            Product product = JsonSerializer.Deserialize<Product>(text);    
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Description); 
            Console.WriteLine(product.Price);  
            
            Products2 products2 = JsonSerializer.Deserialize<Products2>(text2);
            Console.WriteLine(products2.HP);
            Console.WriteLine(products2.HP2);
            Console.WriteLine(products2.HP3);


        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }

    public class Products2 
    {
        public string HP { get; set; }
        public string HP2 { get; set; }
        public string HP3 { get; set; }
    }


}
