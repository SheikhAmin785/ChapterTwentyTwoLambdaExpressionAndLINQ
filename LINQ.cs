using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwentyTwoLambdaExpressionAndLINQ
{
    class LINQ
    {
        static void Main()
        {
            int[] nums = new int[] { 0, 1, 2 };
            var result = from a in nums where a < 3 orderby a select a;
             
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }

        }
        
    }
}
