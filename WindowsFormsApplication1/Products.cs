using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsApplication1
{
    public class Products
    {
        static Dictionary<string, Product> products = new Dictionary<string, Product>();

        static Products()
        {
            products.Add("Red shirt", new Product("1001.1", "Red Dress", 100.0));
            products.Add("Blue shirt", new Product("1001.2", "Blue shirt", 100.0));
            products.Add("Yellow shirt", new Product("1001.3", "Yellow shirt", 100.0));
            products.Add("Green shirt", new Product("2001.1", "Green shirt", 10.0));
            products.Add("Purple shirt", new Product("2001.2", "Purple shirt", 10.0));
        }

        public static Product GetProduct(string name)
        {
            return products[name];
        }
    }
}
