using Course.Entities;
using System.Linq;
namespace Course
{
    class program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, string> func = NameUpper;

            List<string> result = list.Select(func).ToList();
            foreach (string p in result)
            {
                Console.WriteLine(p);
            }
            
            //OU

            Func<Product, string> func2 = p => p.Name.ToUpper();

            List<string> result2 = list.Select(func2).ToList();
            foreach (string p in result2)
            {
                Console.WriteLine(p);
            }

            //OU

            //List<Product, string> result3 = list.Select(NameUpper).ToList();
        }
        
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}