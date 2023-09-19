using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwentyTwoLambdaExpressionAndLINQ
{
    class JoiningDataWithLinq
    {
        public class Product
        {
            public string Name { get; set; }
            public string CategoryID { get; set; }

            public static void Main()
            {
                List<Product> products = new List<Product>() { 
                
                new Product(){Name="StraBary", CategoryID=1},
                new Product(){Name="Apple",CategoryID=2},
                
                
                };
            }
        }
        public class Category
        {
            private static object products;

            public int ID { get; set; }
            public string Name { get; set; }

            static void Main()
            {
                List<Category> categories = new List<Category>() { 
                
                new Category {ID=1,Name="Fruit"},
                new Category {ID=2,Name="Food"},
                
                };

                var productwithcategory = from Product in products join
                                          Category in categories
                                          on Product.CategoryID equals Category.ID
                                          select new
                                          {
                                              Name = Product.Name
                                              Category = Category.name
                                          };
                foreach(var item in productwithcategory)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
