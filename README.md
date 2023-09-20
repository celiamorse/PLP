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
2. Start a new terminal and input: dotnet new console –framework net7.0
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










