using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTest
{
    public class DeleteCategory
    {
        Category category = new Category();
        public void DeleteCategoryOperation()
        {
            var db = new BookContext();
            
            Console.WriteLine("Enter the ID of the Category");
            category.CategoryId = Convert.ToInt32(Console.ReadLine());
            db.Categories.Attach(category);
            db.Entry(category).State = EntityState.Deleted;
            db.SaveChanges();
            Console.WriteLine("Done");
        }
    }
}
