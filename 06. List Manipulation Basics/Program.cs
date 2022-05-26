using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = 
                Console.ReadLine().
                Split(' ')
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] cmdArgs = command
                   .Split(' ').ToArray();
                if(cmdArgs[0]== "Add")
                {
                    int numberAdd = int.Parse(cmdArgs[1]);
                    AddNumber(numbers, numberAdd);
                }else if(cmdArgs[0]== "Remove")
                {
                    int numberRemove = int.Parse(cmdArgs[1]);
                    RemoveNumber(numbers, numberRemove);

                }else if(cmdArgs[0]== "RemoveAt")
                {
                    int index = int.Parse(cmdArgs[1]);
                    RemoveAtNumber(numbers, index);

                }else if(cmdArgs[0]== "Insert")
                {
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    InsertNumberIndex(numbers, number, index);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ',numbers));
        }
        static void AddNumber(List<int> numbers,int number)
        {
            numbers.Add(number);
        }
        static void RemoveNumber(List<int>numbers,int number)
        {
            numbers.Remove(number);
        }
        static void RemoveAtNumber(List<int>numbers,int index)
        {
            numbers.RemoveAt(index);
        }
        static void InsertNumberIndex(List<int>numbers,int insertNumber,int index)
        {
            numbers.Insert(index, insertNumber);
        }
    }
    
}
