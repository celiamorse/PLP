using System;


class Program
{
    static void Main(string[] args)
    {
        // Integer
        int myInt = 42;

        // String
        string myString = "Hello, World!";

        // Floating number
        float myFloat = 3.14f;

        // Boolean
        bool myBool = true;

        // Array/List
        int[] myArray = { 1, 2, 3 };
        List<string> myList = new List<string> { "apple", "banana", "cherry" };

        // Dictionary
        Dictionary<string, int> myDictionary = new Dictionary<string, int>
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 }
        };

        // Operations
        int result1 = myInt + (int)myFloat; // Adding int and float 
        float result2 = myInt / myFloat;    // Division of int and float 

        Console.WriteLine($"result1: {result1}");
        Console.WriteLine($"result2: {result2}");
    }
}