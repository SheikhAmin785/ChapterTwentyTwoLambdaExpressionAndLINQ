using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwentyTwoLambdaExpressionAndLINQ
{
    class TostringAnonymous
    {
        public static void Main()
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);
            Console.WriteLine("The type of st before " +
               "ToString Method: " + st.GetType());
            foreach (int i in st)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("The type of st after " +
          "ToString Method: " + st.ToString().GetType());


            int value = 20;
            Console.WriteLine(value.ToString());

        }
   
    }
}
//output: 5,4,3,2,1
//ToString Return string represention of collection
