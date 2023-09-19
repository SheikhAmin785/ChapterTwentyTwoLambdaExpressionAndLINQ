using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwentyTwoLambdaExpressionAndLINQ
{
    class ArrayOfAnonymous
    {
        public static void Main()
        {
            var arr = new[]
            {
            new{x=3,y=5},
            new{x=1,y=2},
            new{x=0,y=7}
            };
            foreach(var item in arr)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

//{ X = 3, Y = 5 }
//{ X = 1, Y = 2 }
//{ X = 0, Y = 7 }

