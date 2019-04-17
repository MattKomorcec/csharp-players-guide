using System;
using System.Collections.Generic;

namespace Chapter25And26Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PracticeList<int> nums = new PracticeList<int>();

            nums.Add(5);
            nums.Add(25);

            Console.WriteLine(nums.GetItem(1));
        }
    }
}