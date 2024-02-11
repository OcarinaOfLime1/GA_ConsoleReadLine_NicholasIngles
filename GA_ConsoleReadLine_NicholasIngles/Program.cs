// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");

        string userName = Console.ReadLine();
        Console.WriteLine("\nHello, " + userName + "!");

        Console.WriteLine("\nWhat is your favorite color?");

        string favoriteColor = Console.ReadLine();
        Console.WriteLine("\nAh, " + favoriteColor + " is a great color!");
        Console.WriteLine("\n" + userName + ", who likes " + favoriteColor + ", welcome to the program!");
    }       

}
