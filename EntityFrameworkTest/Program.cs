using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new BookContext())
            {

                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var category = new Category { Name = name };
                db.Categories.Add(category);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Categories
                            orderby b.Name
                            select b;

                Console.WriteLine("All categories in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();


            }
        }
    }
}
