using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            var result = input.Reverse();


            string ext = String.Format("[{0}]", string.Join(",", result.Select(n => "\"" + n + "\"")));


            Console.WriteLine(ext);

          

            Console.ReadLine();
        }
    }



}
