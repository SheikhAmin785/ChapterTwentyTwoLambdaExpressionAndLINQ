using System;

namespace ChapterTwentyTwoLambdaExpressionAndLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    static void Main()
    {
        string hellostring = "hello extension method!";
        int wordcount = hellostring.WordCount();
        Console.WriteLine(wordcount);
    }
 
}
