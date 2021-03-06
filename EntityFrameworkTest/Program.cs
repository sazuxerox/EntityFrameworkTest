﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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

                Console.WriteLine("Enter a name for a new Category: ");
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

                //The 42nd line will delete the record of the category according to the ID
                var DeleteOp = new DeleteCategory();
               // DeleteOp.DeleteCategoryOperation();
                Console.WriteLine("Delete Operation Completed!");

            }
        }
    }
}
