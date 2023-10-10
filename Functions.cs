using System;

class Functions
{
    static void Main()
    {
        // Call and save the results of function calls
        int result1 = Multiply(5, 3);
        int result2 = CalculateFactorial(5);
        (string part1, string part2) = SplitString("Hello World");
        
        // Display the results
        Console.WriteLine("Multiplication Result: " + result1);
        Console.WriteLine("Factorial Result: " + result2);
        Console.WriteLine("Split Result: Part1 - " + part1 + ", Part2 - " + part2);

        // Check if C# is pass-by-value or pass-by-reference
        int value = 10;
        PassByValue(value);
        Console.WriteLine("After PassByValue: " + value); // Should still be 10

        int[] arr = { 1, 2, 3 };
        PassByReference(arr);
        Console.WriteLine("After PassByReference: " + arr[0]); // Should be 42
    }

    // Function to multiply two numbers and return the result
    static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    // Recursive function to calculate factorial
    static int CalculateFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * CalculateFactorial(n - 1);
        }
    }

    // Function to split a string into two and return both parts
    static (string, string) SplitString(string input)
    {
        string[] parts = input.Split(' ');
        return (parts[0], parts[1]);
    }

    // Function to test pass-by-value
    static void PassByValue(int x)
    {
        x = 20;
    }

    // Function to test pass-by-reference
    static void PassByReference(int[] arr)
    {
        arr[0] = 42;
    }
}
