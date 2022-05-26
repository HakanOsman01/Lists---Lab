using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToList();
            List<int> secondList = Console.ReadLine()
               .Split(" ")
               .Select(int.Parse)
               .ToList();
            List<int> result =GetRemainingElements(firstList,secondList);
            Console.WriteLine(string.Join(' ', result));
        }
        static List<int> GetRemainingElements(List<int> first, List<int> second)
        {
            List<int> result = new List<int>();
            int longestCount = Math.Max(first.Count, second.Count);
            for (int i = 0; i < longestCount; i++)
            {
                if (i < first.Count)
                {
                    result.Add(first[i]);
                }
                if (i < second.Count)
                {
                    result.Add(second[i]);
                }
            }
            return result;
        }
    }
    
}
