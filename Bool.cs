using System;

class Bool
{
    static void Main()
    {
        bool a = false;
        bool b = false;

        // AND  operator
        bool result1 = a && b; // Only true if both a and b are true
        Console.WriteLine("a && b: " + result1); // Output: "a && b: False"

        // OR  operator
        bool result2 = a || b; // True if either a or b (or both) are true
        Console.WriteLine("a || b: " + result2); // Output: "a || b: True"

        // NOT operator
        bool result3 = !a; // Inverts value of a
        Console.WriteLine("!a: " + result3); // Output: "!a: False"
    }
}
