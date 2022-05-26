﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> gaussTrick = new List<int>();
            for(int i = 0; i < numbers.Count / 2; i++)
            {
                int newNumber = numbers[i] + numbers[numbers.Count - 1 - i];
                gaussTrick.Add(newNumber);

            }
            if (numbers.Count % 2 != 0)
            {
                gaussTrick.Add(numbers[numbers.Count/2]);
            }
            Console.WriteLine(string.Join(" ", gaussTrick));
        }
    }
}
