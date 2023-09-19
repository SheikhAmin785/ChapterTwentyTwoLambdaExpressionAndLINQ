using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwentyTwoLambdaExpressionAndLINQ
{
   public static class IlistExtension
    {
        public static void IncreaseWith (this IList<int>list,int amount)
        {
            for(int i = 0; i < list.Count; i++)
            {
                list[i] += amount;
            }
        }
    }

    public static void MainList() 
    {
        List<int> number = new() {5,4,1,3,9,8,6,7,2,0 };
        List<int> number2 = new() { 15,14,11,13,19,16,17,12,10}
    
    }
         
}
