using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwentyTwoLambdaExpressionAndLINQ
{
    class LambdaExpression

    {
        public string Name { get; set; }

        static void Main()
        {
            List<LambdaExpression> lambda = new List<LambdaExpression>();
            { 
                new LambdaExpression { Name = "alamin" }
            
            };
            var names = lambda.Select(x => x.Name);
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
          
        }

      
        static void Main()
        {

            List<int> num = new List<int>() { 2, 4, 6, 9, 7 };
            List<int> evennumbers = num.FindAll(x => (x % 2 == 0));
            foreach(int list in evennumbers)
            {
                Console.WriteLine("{0}",list);  //result:2 4 6
            }
        }
    }
}
//lambda expression anonymous function that contain expression of sequence of operator
//lambda expression => "gose to"
//left side of lambda operator input parameter
//right side of lambda operator code block and some value
// delegete type,collection processing return some result
//system.core.Dil
//system.LINQ
//collection integer method FindAll(..)