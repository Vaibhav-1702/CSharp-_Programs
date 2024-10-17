using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    class SortByLength
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "apple", "banana", "kiwi", "cherry", "blueberry" };

            var sortedWords = words.OrderBy(word => word).ToList();

            sortedWords.ForEach(word => Console.WriteLine(word));
        }
    }
}
