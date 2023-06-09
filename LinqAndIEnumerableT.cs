using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Tutorial
{
    public class LinqAndIEnumerableT
    {
        public void linqAndIEnumerable()
        {
            var number = new List<int> { 1, 2, 3,4,6,8,3,9,4 };
            var numbersWith10 = number.Append(10);

            Console.WriteLine("Numbers: "+string.Join(", ", number));
            Console.WriteLine("Numbers with 10"+
                              string.Join(", ",numbersWith10));

                //one way
                var oddNumbers = number.Where(number => number % 2 == 1);

                //using linq chain method
                var orderedOddNumbers = number
                    .Where(number => number % 2 == 1)
                    .OrderBy(number => number);


                Console.WriteLine(oddNumbers);
                Console.WriteLine(orderedOddNumbers);
        }
    }
}
