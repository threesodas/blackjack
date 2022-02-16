using System;

namespace Blackjack
{
    struct Cards
    {
        struct Black
        {
            public static string[] Club = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"};
            public static string[] Spade = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"};
        }
        struct Red
        {
            public static string[] Diamond = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"};
            public static string[] Heart = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"};
        }

        public static string[] Phenotype = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
    }
    public static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}