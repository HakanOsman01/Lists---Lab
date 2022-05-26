using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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
            bool hasChange = false;
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] cmdArgs = command
                   .Split(' ').ToArray();
               
                if (cmdArgs[0] == "Add")
                {
                    int numberAdd = int.Parse(cmdArgs[1]);
                    AddNumber(numbers, numberAdd);
                    hasChange = true;
                }
                else if (cmdArgs[0] == "Remove")
                {
                    int numberRemove = int.Parse(cmdArgs[1]);
                    RemoveNumber(numbers, numberRemove);
                    hasChange = true;

                }
                else if (cmdArgs[0] == "RemoveAt")
                {
                    int index = int.Parse(cmdArgs[1]);
                    RemoveAtNumber(numbers, index);
                    hasChange = true;

                }
                else if (cmdArgs[0] == "Insert")
                {
                    int number = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    InsertNumberIndex(numbers, number, index);
                    hasChange = true;
                }else if(cmdArgs[0]== "Contains")
                {
                    int numberContains = int.Parse(cmdArgs[1]);
                    bool checkIsContains = ContainsNumber(numbers, numberContains);
                    if (checkIsContains)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }


                }else if(cmdArgs[0]=="PrintEven")
                {
                    PrintEvenNumbers(numbers);
                }else if(cmdArgs[0]== "PrintOdd")
                {
                    PrintOddNumbers(numbers);
                }else if(cmdArgs[0]=="GetSum")
                {
                    int sum = GetSum(numbers);
                    Console.WriteLine(sum);
                }else if(cmdArgs[0]== "Filter")
                {
                    string condition = cmdArgs[1];
                    int numberToCompare = int.Parse(cmdArgs[2]);
                    FilterList(numbers, condition, numberToCompare);
                }
                command = Console.ReadLine();
            }
            if (hasChange)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }
            
        }
        static void AddNumber(List<int> numbers, int number)
        {
            numbers.Add(number);
        }
        static void RemoveNumber(List<int> numbers, int number)
        {
            numbers.Remove(number);
        }
        static void RemoveAtNumber(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
        }
        static void InsertNumberIndex(List<int> numbers, int insertNumber, int index)
        {
            numbers.Insert(index, insertNumber);
        }
        static bool ContainsNumber(List<int>numbers,int number)
        {
            bool isContains = false;
            if (numbers.Contains(number))
            {
                isContains = true;
            }
            return isContains;
        }
        static void PrintEvenNumbers(List<int> numbers)
        {
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            Console.WriteLine();
        }
        static void PrintOddNumbers(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
            Console.WriteLine();
        }
        static int GetSum(List<int> numbers)
        {
            int sum = 0;
            for(int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
        static void FilterList(List<int>numbers,string condition,int numberToCompare)
        {
            
            if(condition== "<")
            {
                List<int> filterList = numbers.FindAll(x => x < numberToCompare);
                Console.WriteLine(string.Join(' ',filterList));
            }else if (condition == ">")
            {
                List<int> filterList = numbers.FindAll(x => x > numberToCompare);
                Console.WriteLine(string.Join(' ', filterList));
            }else if (condition == ">=")
            {
                List<int> filterList = numbers.FindAll(x => x >= numberToCompare);
                Console.WriteLine(string.Join(' ', filterList));
            }else if (condition == "<=")
            {
                List<int> filterList = numbers.FindAll(x => x <= numberToCompare);
                Console.WriteLine(string.Join(' ', filterList));
            }
           
        }
    }

 }

