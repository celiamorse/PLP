# C# (C-Sharp)
Programming Language Project

## Description
1. Programming language developed by Microsoft that runs on the .NET Framework.
2. The language aims to be a straightforward, contemporary, versatile, object-oriented programming language.

## Uses
C# is employed in crafting web apps, desktop software, mobile solutions, games, and various other domains.

## History 
In 2000, Microsoft engineer Anders Hejlsberg created the C# programming language, which went on to become an international standard through Ecma (ECMA-334) in 2002 and ISO/IEC (ISO/IEC 23270) in 2003. Microsoft launched C# alongside the closed-source .NET Framework and Visual Studio development tools.

### Examples
A few instances of web apps constructed using C# comprise Windows Installer XML, Microsoft Visual Studio, and FlashDevelop.

#### Guides
[https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/](url)


# Getting Started 
### What You Need
1. Download and open Visual Studio Code([https://code.visualstudio.com/download](url))
2. Install the C# extension in VSCode

### Start a New C# Project 
1. Create and open a folder in VSCode where you want your program directory to be
2. Start a new terminal and input: dotnet new console 
3. Step 2 should create a .cs file where you can then start your C# program
4. To run your program, input into the terminal: dotnet run

#### Writing Comments
Single Line Comments ( // )
Multi Line Comments ( /* */ )

#### Simple Starter Program
The below code can be written to display a simple statement to the console:
```
// The System namespace includes fundamental classes and methods for a C# program
using System;

// This line declares a namespace, which is used to organize code 
namespace HelloWorld
{

/* A class named "Greetings" is declared, which will contain the programs code.
Note: Your class name and file name must be the same *\
    class Greetings
    {

// The  Main method is the entry point to the application
        static void Main(string[] args)
        {

/* The next line is a method call to WriteLine, which will display
"Hello, World!" to your console! *\
            Console.WriteLine("Hello, World!");
        }
    }
}

```
# Data Types and Naming Conventions
## Case Sensitivity:
C# is case-sensitive, so variable names like myVariable and MyVariable are considered different.

## Lowercase Letters: 
Variable names typically start with lowercase letters, following the camelCase convention. For example, myVariable.

## Starting with Numbers/Symbols: 
Variable names cannot start with numbers or symbols other than underscore _.

### Underscores vs. Camel Case: 
Camel case (ex: myVariable) is more common than underscores (ex: my_variable).

### Example Of Variable Declaration of Common Data Types and Operations:

```
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


```

## Keywords:
C# has a set of keywords that have special meanings in the language. These keywords cannot be used as identifiers (variable, class, or method names) and are reserved for specific language constructs. Examples include if, else, for, while, class, int, and many others.

## Naming Requirements for Variables:
### In C#, variable names must adhere to certain rules:
    1. They must start with a letter (a-z, A-Z) or an underscore (_).
    2. The rest of the name can include letters, digits (0-9), or underscores.
    3. They cannot start with a number or a symbol other than an underscore.

## Naming Conventions:
Naming conventions are not enforced by the C# compiler but are widely followed in the C# community to write clean and readable code.
### Common conventions include:
####    1. Camel Case: 
            Variables start with a lowercase letter, and subsequent words are capitalized (ex: myVariable).
####    2. Pascal Case: 
            Variables start with an uppercase letter, and subsequent words are also capitalized (ex: MyVariable).

## Static or Dynamic Typing:
C# is statically typed, which means that variable types are determined at compile-time. Once you declare a variable with a specific type, its type cannot be changed during execution.
## Strongly or Weakly Typed:
C# is strongly typed, meaning that the type of a variable is enforced, and operations are defined based on the data type. You cannot perform operations on variables of incompatible types without conversion.
## Mutable or Immutable Variables:
C# supports both mutable and immutable variables. Whether a variable is mutable or not depends on its data type. 
###    For example:
           1. Int and float are mutable types; their values can be changed.
           2. String is an immutable type. Once assigned, its value cannot be changed.

## Operators Available for Each Data Type:
C# provides various operators for different data types. 
### For example:
        1. Arithmetic operators (+, -, *, /) work with numeric types (int, float, etc.).
        2. String concatenation (+) is used with strings.
        3. Comparison operators (==, !=, <, >) work with many types for comparisons.
        4. Logical operators (&&, ||, !) work with boolean values: 

```
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

```

## Explicitly or Implicitly Typed:
C# allows both explicitly typed variables and implicitly typed variables:
### Explicit Typing: 
You declare the type explicitly (ex: int myInt = 42;).
### Implicit Typing: 
You use the var keyword to let the compiler infer the type (ex: var myVar = "Hello";).

## Mixed Type Operations in C#:
In C#, you can mix different types of data in operations, like adding an integer and a float

When you mix types, C# automatically converts them to a compatible type. For example, adding an integer and a float gives you a float as the result.

## Identifier and Operator Handling in C#:
In C#, the names you give to variables, classes, and functions are matched with their types during compilation.


















