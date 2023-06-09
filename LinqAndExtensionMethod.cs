using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Tutorial
{
    public  class LinqAndExtensionMethod
    {
        public void LinqsAndExtenstionMethods()
        {
            var words = new[] {"aa", "bb", "ccc", "ddd"};
            var wordsLongerThan2Letters = words.Where(word => word.Length > 2);
            Console.WriteLine(string.Join(", ", wordsLongerThan2Letters));
        }
    }


    public static class StringExtensions
    {
        public static int GetCountOfLines(this string input)
        {
            return input.Split("\n").Length;
        }
    }
}
