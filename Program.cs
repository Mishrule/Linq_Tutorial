using System;

namespace Linq_Tutorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinqAndExtensionMethod l = new LinqAndExtensionMethod();
            l.LinqsAndExtenstionMethods();

            var multilineString = @"
                There are seven days
                in one week, these are, monday
                Tuesday
                wednesday and so on
              ";


            var countOfLines = StringExtensions.GetCountOfLines(multilineString);
            Console.WriteLine(countOfLines);


            LinqAndIEnumerableT le = new LinqAndIEnumerableT();
            le.linqAndIEnumerable();
        }
    }
}
