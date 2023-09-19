using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapterTwentyTwoLambdaExpressionAndLINQ
{
    class AnonyMousType
    {
        public static void Main()
        {
            var MyCar = new { Color="Red",Brand= "bmw",Speed=180};
            Console.WriteLine("My car is a {0} {1} {2}", MyCar.Color, MyCar.Brand, MyCar.Speed);
            Console.WriteLine("tostring:{0}", MyCar.ToString());
            Console.WriteLine("Hash Code:{0}", MyCar.GetHashCode().ToString());
            Console.WriteLine("Equals? {0}", MyCar.Equals(
            new { Color = "Red", Brand = "BMW", Speed = 180 };

        }
    }
}
//Anonymous Type ToString(),Equals(),GetHashCode()
//ToString: { Color = Red, Brand = BMW, Speed = 180 }
//Hash code: 1572002086
//Equals? True