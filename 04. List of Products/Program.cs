using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int countProducts = int.Parse(Console.ReadLine());
            List<string> nameOfProducts = new List<string>();
            for(int i = 1; i <= countProducts; i++)
            {
                string name = Console.ReadLine();
                nameOfProducts.Add(name);
            }
            nameOfProducts.Sort();
            //Console.WriteLine(string.Join(" ", nameOfProducts));
            int count = 1;
            foreach(string curName in nameOfProducts)
            {
                Console.WriteLine($"{count}.{curName}");
                count++;
            }
        }
    }
}
