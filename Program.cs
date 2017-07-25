using System;
using System.Linq;

namespace LinqBasic
{
    /// <summary>
    /// Written by Calvin Brown
    /// Free to use w/o credit for commerical and private use
    /// Write a nice comment on my blog at blog.IamCalvinBrown.com
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Language Integrated Query Example (LINQ)
            Console.WriteLine("Demonstrating Basic Linq");

            int[] listOfNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // get all even numbers
            var result = from number in listOfNumbers
                         where (number % 2) == 0
                         select number;

            foreach(var r in result)
            {
                Console.WriteLine(r.ToString());
            }

            Console.ReadLine();
        }
    }
}
