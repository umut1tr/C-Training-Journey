using System;
using System.Collections.Generic;

namespace IEnumerableDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>() { 8, 6, 2 };

            int[] numberArray = new int[] { 1, 7, 1, 3 };

            Console.WriteLine(" ");

            CollectionSum(numberList);

            Console.WriteLine(" ");

            CollectionSum(numberArray);
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            //sum variable to store the sum of the numbers in anyCollection
            int sum = 0;
            //for each number in the colelction passed to this method 
            foreach(int num in anyCollection)
            {
                //add the num value to sum
                sum += num;

            }

            // print the sum
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
