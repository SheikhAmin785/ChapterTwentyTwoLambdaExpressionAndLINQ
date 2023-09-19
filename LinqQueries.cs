using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwentyTwoLambdaExpressionAndLINQ
{
    class LinqQueries
    {
        static void Main()
        {

            string[] FruitName = { "cherry", "apple", "bluberry" };
            var result = from Fruit in FruitName
                         orderby Fruit.Length descending
                         select Fruit;
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }




        }










        public static void Main()
        {
            List<int> number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var evennumbers = from num in number
                              where num % 2 == 0
                              select num;
            foreach(var item in evennumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}

//LINQ (language integrated Query)
//array of an collection
//very powerfull tool
//similar to sql language logic and syntax
//keyword from,in,select
