using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Price = 10;
           

            string json = JsonConvert.SerializeObject(product);

             Product deserializedProduct = JsonConvert.DeserializeObject<Product>(json);
            String Name = deserializedProduct.Name;
            DateTime Expiry = deserializedProduct.Expiry;
            Double Price = deserializedProduct.Price;
            Console.Write("Name :"+Name+Environment.NewLine+ "Expiry :" + Expiry+ Environment.NewLine + "Price :" + Price+"/-");
            Console.Read();
        }
    }

    public class Product
    {
       public string Name { get; set; }
        public DateTime Expiry { get; set; }
        public double Price { get; set; }
        
    }
}
