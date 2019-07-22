using System;
using System.Text.RegularExpressions;
using exampaper.entity;

namespace exampaper
{
    class Program
    {
        static void Main(string[] args)
        {
            Example();
        }

        public static void Example()
        {
            var people = new People
            {
                Name = "Mary",
                Gender = true,
                Age = 25,
            };

            Console.WriteLine("Simple properties demo");
            Console.WriteLine("Person detail" + people.ToString());
            people.Age = 35;
            Console.WriteLine("Person detail(apter incrementing age):" + people.ToString());
        }

        public static void Example2()
        {
            Console.WriteLine("Enter a String");
            var str = Console.ReadLine();
            Console.WriteLine("Enter a word to search");
            var word = Console.ReadLine();

            var count = Regex.Matches(str, word).Count;
            Console.WriteLine($"Word found {count} times in the string");
        }
    }
}