using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        // Declare a variable named 'inputString' to hold our input.
        String inputString;

        // Read a full line of input from stdin (cin) and save it to our variable, input_string.
        inputString = Console.ReadLine();

        // Print a string literal saying "Hello, World." to stdout using cout.
        Console.WriteLine("Hello, World.");

        // TODO: Write a line of code here that prints the contents of input_string to stdout.
        Console.WriteLine(inputString);

        // Declare second integer, double, and String variables.
        int i2;
        double d2;
        string s2;

        // Read and save an integer, double, and String to your variables.
        i2 = int.Parse(Console.ReadLine());
        d2 = double.Parse(Console.ReadLine());
        s2 = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + i2);

        // Print the sum of the double variables on a new line.
        Console.WriteLine((d + d2).ToString("F1"));

        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + s2);

    }
}
