using System;
using ReproRegex.Lib;

namespace ReproRegex
{
    public static class Program
    {
        public static void Main(string[] args) =>
            Console.WriteLine(Parser.IsMatch(args[0]) ? "Is match" : "Not a match");
    }
}